﻿using LogTag.SDK.LogTagIO;
using LogTagAutomationApp.Models;
using System.Collections.Generic;
using System;
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

                // Rename the Dostmann file to a .csv and extract the information, then rename it back to .dbf
                FileController.DostmannPath = FolderController.RenameToCSV(FileController.DostmannPath);
                var dostmannResult = DostmannHandler.ExtractDostmann();
                FileController.DostmannPath = FolderController.RenameToDBF(FileController.DostmannPath);

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



                // Compare readings between Dostmann and Loggers
                ComparisonHandler.CalculateMatches(newTest);

                
                
                Logger currentLogger = SessionController.CurrentSelectedLogger;
                var pathToCurrentTestFolder = FolderController.CreateTestFolder(SessionController.MainOutputFolder, dateTested, currentLogger);
                var pathToMasterTestFolder = SessionController.MainOutputFolder + "\\" + SessionController.TestsMasterFile;

                // if some logic passes all the tests: //////////////////////////////////////////////////////////////////////////////////
                JSONWriteToFile.AppendTestToMasterFile(pathToMasterTestFolder, newTest);

                // Copy files across. Add Dostmann and LTD filepaths to a single array.
                // This means CopyFilesToFolder will always receive an arg >= 2
                string[] paths = FileController.LTDPaths;
                paths = paths.Concat(new[] { FileController.DostmannPath }).ToArray();
                FolderController.CopyFilesToFolder(pathToCurrentTestFolder, paths);

                // Rename the Dostmann file back to a DBF
                FileController.DostmannPath = FolderController.RenameToDBF(FileController.DostmannPath);
            }
            catch
            {
                // Rename the Dostmann file back to a DBF
                FileController.DostmannPath = FolderController.RenameToDBF(FileController.DostmannPath); /////////////////////////////////
            }            
        }

        //private static void DisplayTestResults(Test test)
        //{
        //    ucTestResult.DisplayTestResults(test);
        //    VisibilityController.ShowUserControl("testResult");
        //    foreach (var logger in LTDHandler.LoggersWithReadings)
        //    {
        //        Debug.WriteLine("\nNEW LOGGER\n");
        //        Debug.WriteLine($"Number of readings in {logger.SerialNumber} is {logger.Readings.Count}");
        //        foreach(SensorReading reading in logger.Readings)
        //        {
        //            Debug.WriteLine($"At {reading.TimeStamp}, temp was {reading.Reading[0]}");
        //        }
                
        //    }
        //}
    }
}



