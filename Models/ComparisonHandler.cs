using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace LogTagAutomationApp.Models
{
    public class ComparisonHandler
    {
        public static void GenerateResults(Test test)
        {
            //var dostmannReadings = DostmannHandler.DostmannReadings;
            //Debug.WriteLine("COMPARING READINGS");
            Debug.WriteLine($"Dostmann has {DostmannHandler.DostmannRawReadings.Count} raw readings");
            foreach(var v in LTDHandler.LoggersRawReadings)
            {
                Debug.WriteLine($"Logger {v} has {v.Count} raw readings");
            }




            // New list to store matching key-value pairs
            List<MatchedReading> matchingReadings = new List<MatchedReading>();

            // Check if there are dictionaries in LoggersRawReadings
            if (LTDHandler.LoggersRawReadings != null && LTDHandler.LoggersRawReadings.Count > 0)
            {
                // Get the first dictionary from LoggersRawReadings
                Dictionary<string, string> firstLoggerReadings = LTDHandler.LoggersRawReadings.First();

                // Perform a join between DostmannRawReadings and the firstLoggerReadings
                var joinedData = from dostmannKvp in DostmannHandler.DostmannRawReadings
                                 join firstLoggerKvp in firstLoggerReadings on dostmannKvp.Key equals firstLoggerKvp.Key
                                 select new MatchedReading
                                 {
                                     KeyTime = dostmannKvp.Key,
                                     ValueFromDostmann = dostmannKvp.Value,
                                     ValueFromLogger = firstLoggerKvp.Value
                                 };

                // Add the matching key-value pairs to the list
                matchingReadings.AddRange(joinedData);
            }


            Debug.WriteLine("MATCHES!!!");
            Debug.WriteLine("MATCHES!!!");
            Debug.WriteLine("MATCHES!!!");
            Debug.WriteLine("MATCHES!!!");
            Debug.WriteLine("MATCHES!!!");

            foreach(var reading in matchingReadings)
            {
                Debug.WriteLine($"On {reading.KeyTime} the dostmann was {reading.ValueFromDostmann} and the logger was {reading.ValueFromLogger}");
            }



        }
    }
}
