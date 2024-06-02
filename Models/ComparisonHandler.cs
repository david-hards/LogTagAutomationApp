using LogTag.SDK.LogTagIO;
using System;
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
            Debug.WriteLine("COMPARING READINGS");
            //Debug.WriteLine($"Dostmann has {DostmannHandler.DostmannRawReadings.Count} raw readings");
            foreach (Logger logger in LTDHandler.ExtractedLoggers)
            {
                Debug.WriteLine($"Logger {logger.SerialNumber} has {logger.Readings.Count} raw readings");
            }

            /*
             * Foreach logger, get a matching list of dostmann/logger results
             * Print them
             * For testing will only be two or three
             * In real, should be a matching result for each log taken (give or take)
             * 
             * From that, for each 10c step in the logger json
             * Get an array of matching readings,
             * Get the middle 50%
             * ensure none stray outside the bounds
             * if that is true
             * Get the average variance of that 50%
             * Save it as the logger record for that temp
             *
             * 
             * 
             */

            foreach (var logger in LTDHandler.ExtractedLoggers)
            {
                Debug.WriteLine($"Comparing {logger.Model} to Dostmann");
                //if (logger.RawReadings != null && logger.RawReadings.Count > 0)
                //{

                //}


                //// New list to store matching key-value pairs
                //List<MatchedReading> matchingReadings = new List<MatchedReading>();



                //Debug.WriteLine("MATCHES!!!");
                //Debug.WriteLine("MATCHES!!!");
                //Debug.WriteLine("MATCHES!!!");
                //Debug.WriteLine("MATCHES!!!");
                //Debug.WriteLine("MATCHES!!!");

                //foreach (var reading in matchingReadings)
                //{
                //    Debug.WriteLine($"On {reading.KeyTime} the dostmann was {reading.ValueFromDostmann} and the logger was {reading.ValueFromLogger}");
                //}


            }
        }
    }
}




// This can possibly be moved into the comparison section as it doesn't need to be here? --------------------------------------
//public static void GetLTDReadings()
//{
//    LoggersRawReadings = new List<Dictionary<string, string>>();

//    LoggersRawReadings.Clear();

//    CultureInfo culture = new CultureInfo("en-NZ");
//    culture.DateTimeFormat.AMDesignator = "am";
//    culture.DateTimeFormat.PMDesignator = "pm";


//    foreach (var logger in ExtractedLoggers)
//    {
//        Dictionary<string, string> newDict = new Dictionary<string, string>();

//        foreach (SensorReading reading in logger.Readings)
//        {
//            //string key = reading.TimeStamp.ToString();
//            //string value = reading.Reading[0].ToString();

//            var inputdate = reading.TimeStamp;

//            string key = inputdate.ToString("dd/MM/yyyy h:mm:ss tt", culture);
//            string value = reading.Reading[0].ToString();

//            // Add key value pair to the dictionary
//            newDict[key] = value;

//        }

//        LoggersRawReadings.Add(newDict);
//    }

//    foreach (var logger in LoggersRawReadings)
//    {
//        foreach (var kvp in logger)
//        {
//            Debug.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
//        }
//    }


//}