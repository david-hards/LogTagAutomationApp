using LogTag.SDK.LogTagIO;
using System;
using System.Diagnostics;
using System.IO;

namespace LogTagAutomationApp.Models
{
    public class ComparisonHandler
    {
        public static void GenerateResults(Test test)
        {
            //var dostmannReadings = DostmannHandler.DostmannReadings;
            Debug.WriteLine("COMPARING READINGS");
            Debug.WriteLine($"Dostmann has {DostmannHandler.DostmannRawReadings.Count} raw readings");
            foreach(var v in LTDHandler.LoggersRawReadings)
            {
                Debug.WriteLine($"Logger {v} has {v.Count} raw readings");
            }
            

        }
    }
}
