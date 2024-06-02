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
        public static void CalculateMatches(Test test)
        {
            // Creates a list of Matched Loggers. This is a data type that has a serial for ID, and a list of Timestamps, dostmann, and logger temps
            List<MatchedLogger> matchedLoggers = new List<MatchedLogger>();

            // For each Logger that data has been extracted from
            for (int i = 0; i < LTDHandler.ExtractedLoggers.Count; i++)
            {
                Logger logger = LTDHandler.ExtractedLoggers[i];
                // Create a new logger to store the info in
                MatchedLogger matchedLogger = new MatchedLogger(logger.SerialNumber, logger.Model); 

                // For each reading in this logger
                foreach (var reading in LTDHandler.ExtractedLoggers[i].Readings)
                {
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
                        }
                    }
                }
                matchedLoggers.Add(matchedLogger);
            }
            //matchedLoggers.ForEach(logger => {
            //    Debug.WriteLine($"MATCH PRINT FOR {logger.Serial}");
            //    logger.MatchedReadings.ForEach(reading => {
            //        Debug.WriteLine($"Reading taken on {reading.KeyTime} at {reading.ValueFromDostmann} and {reading.ValueFromLogger}");
            //    });
            //});
        }
    }
}