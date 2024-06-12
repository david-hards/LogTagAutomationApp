using LogTag.SDK.LogTagIO;
using LogTagAutomationApp.Models;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Windows.Forms;
using LogTagAutomationApp.Views;
using System.Diagnostics;

namespace LogTagAutomationApp.Controllers
{
    public class TestController
    {
        public static List<Test> CompletedTests = new List<Test>();
        public static int NumOfLoggers { get; set; }
        public static string BatchNumber { get; set; }
        private static string dateTested;
        private static string tester;

        public static void LoadPreviousTests()
        {
            CompletedTests = JSONReadFromFile.ReadTestsFromFile();
        }

        public static void CreateTest()
        {
            try
            {
                // Get test attributes and create folders
                dateTested = DateTime.Today.ToString("yyyy-MM-dd");
                tester = SessionController.UserName;

                // Create a new test object
                Test newTest = new Test
                {
                    TesterName = tester,
                    DateOfTest = dateTested,
                    Result = false,
                };

                Debug.WriteLine($"Dostmann Path is {FileController.DostmannPath}");

                var dostmannResult = DostmannHandler.ExtractDostmann();

                // Check to see if all data extractions were succesful
                if (dostmannResult == false)
                {
                    MessageBox.Show("There was an error extracting the Dostmann results from the .dbf file");
                    return;
                }

                // Generate LTD and store in objects
                var ltdResult = LTDHandler.ExtractLTDs();

                if(ltdResult != ERROR_CODES.SUCCESS)
                {
                    MessageBox.Show("There was an error extracting the Logger results from the .ltd file\nMake sure all loggers are updated and supported.");
                    return;
                }

                Debug.WriteLine($"LOGGERS TO ADD: {LTDHandler.ExtractedLoggers.Count}");

                foreach(var logger in LTDHandler.ExtractedLoggers)
                {
                    newTest.Loggers.Add(logger);
                }

                // Compare readings between Dostmann and Loggers
                if (ComparisonHandler.CalculateMatches(newTest))
                {
                    newTest.Result = true;
                }

                Logger currentLogger = SessionController.CurrentSelectedLogger;
                var pathToCurrentTestFolder = FolderController.CreateTestFolder(SessionController.MainOutputFolder, dateTested, currentLogger);

                // Copy files across. Add Dostmann and LTD filepaths to a single array.
                // This means CopyFilesToFolder will always receive an arg >= 2
                string[] paths = FileController.LTDPaths;
                paths = paths.Concat(new[] { FileController.DostmannPath }).ToArray();
                FolderController.CopyFilesToFolder(pathToCurrentTestFolder, paths);

                // Rename the Dostmann file back to a DBF
                //FileController.DostmannPath = FolderController.RenameToDBF(FileController.DostmannPath);
            }
            catch
            {
                // Rename the Dostmann file back to a DBF
                FileController.DostmannPath = FolderController.RenameToDBF(FileController.DostmannPath); /////////////////////////////////
            }            
        }

        public static void DisplayTestResults(List<MatchedLogger> matchedLoggers, Test test)
        {
            Debug.WriteLine("TestController.DisplayTestResults");
            ucTestResult.DisplayTestResults(matchedLoggers, test);

            var pathToMasterTestFolder = SessionController.MainOutputFolder + "\\" + SessionController.TestsMasterFile;
            JSONWriteToFile.AppendTestToMasterFile(pathToMasterTestFolder, test);
        }
    }
}



