using LogTag.SDK.LogTagIO;
using LogTagAutomationApp.Models;
using LogTagAutomationApp.Views;
using QualityAutomation.Controllers;
using System.Collections.Generic;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace LogTagAutomationApp.Controllers
{
    public class TestController
    {
        public static List<Test> CompletedTests = new List<Test>();
        public static int NumOfLoggers { get; set; }
        public static string BatchNumber { get; set; }
        private static string dateTested;
        private static string tester;
        //private static string? pathToCurrentTestFolder;

        public static void LoadPreviousTests()
        {
            Debug.WriteLine("TestController.LoadPreviousTests");
            CompletedTests = JSONReadFromFile.ReadTestsFromFile();
        }

        public bool DeleteTest(Test test)
        {
            return true;
        }

        public static void CreateTest() // WRAP THE FILE CHANGING IN SUCCESS BOOLS SO FILES DONT GET RENAMED AND STAY THAT WAY
        {
            Debug.WriteLine($"TestContoller.CreateTest");
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
                    Loggers = new List<Logger>(),
                    DostmannResults = new Dictionary<int, float>()
                };

                // Rename the Dostmann file to a CSV and extract the information
                FileController.DostmannPath = FolderController.RenameToCSV(FileController.DostmannPath);
                var dostmannResult = DostmannHandler.ExtractDostmann();

                // Generate LTD and store in objects
                var ltdResult = LTDHandler.ExtractLTDs();

                //Create a Logger for every file dropped into the LTD drop box
                //for (int i = 0; i < NumOfLoggers; i++)
                Debug.WriteLine($"Number of loggers in LTDHandler.LoggerReadings is {LTDHandler.LoggersWithReadings.Count}");
                Debug.WriteLine($"LTD Error code success: {ltdResult}");

                // Create a Logger for every file dropped into the LTD drop box
                //for (int i = 0; i < LTDHandler.LoggersWithReadings.Count; i++)
                foreach(var logger in LTDHandler.LoggersWithReadings)
                {
                    // Ensure LoggerReadings array is not null before accessing its elements
                    if (LTDHandler.LoggersWithReadings != null)
                    {
                        Logger newLogger = new Logger();
                        newLogger.SerialNumber = logger.SerialNumber;
                        newTest.Loggers.Add(newLogger);
                    }
                    else
                    {
                        // Handle the case where LoggerReadings[i] is null
                        Debug.WriteLine($"LoggersWithReadings is null.");
                    }
                }

                // Check to see if all data extractions were succesful
                if (dostmannResult == false)
                {
                    MessageBox.Show("There was an error extracting the Dostmann results from the .dbf file");
                    return;
                }
                if (ltdResult != ERROR_CODES.SUCCESS)
                {
                    MessageBox.Show("There was an error extracting the Logger results from the .ltd file");
                    return;
                }

                Logger currentLogger = SessionController.CurrentSelectedLogger;
                var pathToCurrentTestFolder = FolderController.CreateTestFolder(SessionController.MainOutputFolder, dateTested, currentLogger);
                var pathToMasterTestFolder = SessionController.MainOutputFolder + "\\" + SessionController.TestsMasterFile;

                // if some logic passes all the tests: ///////////////////////////////////////////////////////////////////////////////////
                JSONWriteToFile.AppendTestToMasterFile(pathToMasterTestFolder, newTest);

                // Copy files across. Add Dostmann and LTD filepaths to a single array.
                // This means CopyFilesToFolder will always receive an arg >= 2
                string[] paths = FileController.LTDPaths;
                paths = paths.Concat(new[] { FileController.DostmannPath }).ToArray();
                FolderController.CopyFilesToFolder(pathToCurrentTestFolder, paths);

                // Rename the Dostmann file back to a DBF
                FileController.DostmannPath = FolderController.RenameToDBF(FileController.DostmannPath);

                // Update UI
                DisplayTestResults(newTest);
            }
            catch
            {
                // Rename the Dostmann file back to a DBF
                FileController.DostmannPath = FolderController.RenameToDBF(FileController.DostmannPath);
            }            
        }

        private static void DisplayTestResults(Test test)
        {
            ucTestResult.DisplayTestResults(test);
            VisibilityController.ShowUserControl("testResult");
        }
    }
}



