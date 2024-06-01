using LogTagAutomationApp.Controllers;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;

namespace LogTagAutomationApp.Models
{
    public class DostmannHandler
    {
        public static Dictionary<string, string> DostmannRawReadings { get; set; }

        public static bool ExtractDostmann()
        {
            try
            {
                string filePath = FileController.DostmannPath;

                if (!File.Exists(filePath))
                {
                    Debug.WriteLine("DostmannHandler.ExtractDostmann: File not found.");
                    return false;
                }

                // Read the CSV file
                string[] lines = File.ReadAllLines(filePath);

                // Dictionary to store column 4 and 5 as key value pairs
                DostmannRawReadings = new Dictionary<string, string>(); // change to float here or in comparison?

                // Iterate through each line and extract column 4 and 5
                foreach (string line in lines)
                {
                    string[] columns = line.Split(',');

                    // Check if there are enough columns in the CSV
                    if (columns.Length >= 5)
                    {
                        // Extract column 4 and 5
                        string key = columns[3];
                        string value = columns[4];

                        // Add key value pair to the dictionary
                        DostmannRawReadings[key] = value;
                    }
                }

                //Display key value pairs in Debug.WriteLine
                foreach (var kvp in DostmannRawReadings)
                {
                    Debug.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
                }

                return true;
            }
            catch
            {
                return false;
            }
            
        }
    }
}
