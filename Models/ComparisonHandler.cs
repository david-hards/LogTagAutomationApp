﻿using LogTagAutomationApp.Controllers;
using System.Collections.Generic;
using System.Diagnostics;

namespace LogTagAutomationApp.Models
{
    /// <summary>
    /// Class for comparing Dostmann and Logger results, and creating a list of matches
    /// </summary>
    public class ComparisonHandler
    {
        /// <summary>
        /// Calculates a list of all results where the Dostmann and Logger have a record at the same time and puts them in a list.
        /// </summary>
        /// <param name="test">Accepts a tests to add the final result to</param>
        public static bool CalculateMatches(Test test)
        {
            bool match = false;

            Debug.WriteLine($"CalculateMatches");

            // Creates a list of Matched Loggers. This is a data type that has a serial for ID, and a list of Timestamps, dostmann, and logger temps
            List<MatchedLogger> matchedLoggers = new List<MatchedLogger>();

            Debug.WriteLine($"Number of Extracted Loggers: {LTDHandler.ExtractedLoggers.Count}");

            // For each Logger that data has been extracted from
            for (int i = 0; i < LTDHandler.ExtractedLoggers.Count; i++)
            {

                Logger logger = LTDHandler.ExtractedLoggers[i];
                Debug.WriteLine($"Extracted Logger {i + 1}: serial {logger.SerialNumber}");
                // Create a new logger to store the info in
                MatchedLogger matchedLogger = new MatchedLogger(logger.SerialNumber, logger.Model); 

                // For each reading in this logger
                foreach (var reading in logger.Readings)
                {
                    Debug.WriteLine($"Reading is {reading.Value}");

                    // Compare it against the Dostmann records and see if there are logs taken at the same time
                    foreach (var kvp in DostmannHandler.DostmannReadings)
                    {
                        // If true
                        if (kvp.Key == reading.Key)
                        {
                            // Add all the data to the Matched Logger
                            Debug.WriteLine($"MATCH AT {kvp.Key}");
                            MatchedReading matchedReading = new MatchedReading();
                            matchedReading.KeyTime = kvp.Key;
                            matchedReading.ValueFromLogger = reading.Value;
                            matchedReading.ValueFromDostmann = kvp.Value;
                            matchedLogger.MatchedReadings.Add(matchedReading);
                            // There is a match
                            match = true;
                        }
                    }
                }
                matchedLoggers.Add(matchedLogger);
            }
            CalculateTemps(matchedLoggers, test);
            return match;
        }

        private static void CalculateTemps(List<MatchedLogger> matchedLoggers, Test test)
        {
            Debug.WriteLine($"CalculateTemps called");
            Debug.WriteLine($"MatchedLoggers count: {matchedLoggers.Count}");

            foreach(var logger in matchedLoggers)
            {
                var minTemp = LoggerController.getMinTemp(logger.Model);
                var maxTemp = LoggerController.getMaxTemp(logger.Model);

                Debug.WriteLine($"Running CalculateTemps Comparison for Model {logger.Model} has min of {minTemp} and max of {maxTemp}");

                for(int i = 0; i < logger.MatchedReadings.Count; i++)
                {
                    Debug.WriteLine($"Temp at reading {i+1} is {logger.MatchedReadings[i].ValueFromLogger}");
                }

            }

            TestController.DisplayTestResults(matchedLoggers, test);
        }

    }
}