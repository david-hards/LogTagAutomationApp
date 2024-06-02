using LogTagAutomationApp.Controllers;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using System;
using System.Globalization;
using System.Linq;

namespace LogTagAutomationApp.Models
{
    public class DostmannHandler
    {
        public static Dictionary<DateTime, double> DostmannRawReadings { get; set; }

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
                DostmannRawReadings = new Dictionary<DateTime, double>();

                // Skip the first line
                string[] dataLines = lines.Skip(1).ToArray();

                // Iterate through each line and extract column 4 and 5
                foreach (string line in dataLines)
                {
                    string[] columns = line.Split(',');

                    // Check if there are enough columns in the CSV
                    if (columns.Length >= 5)
                    {
                        // Extract column 4 and 5
                        string dateTime = columns[2] + " " + columns[3];
                        DateTime parsedDateTime = DateTime.ParseExact(dateTime, "dd/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);

                        // Parse the value to a float
                        float value;
                        if (float.TryParse(columns[4], out value))
                        {
                            // Add key-value pair to the dictionary
                            DostmannRawReadings[parsedDateTime] = value;
                        }
                        else
                        {
                            // Handle parsing failure if necessary
                            Debug.WriteLine($"Failed to parse value at line: {line}");
                        }
                    }
                }

                //Display key value pairs in Debug.WriteLine // DELETE AFTER TESTING --------------------------------------------------------
                foreach (var kvp in DostmannRawReadings)
                {
                    Debug.WriteLine($"DOSTMANN: Key: {kvp.Key}, Value: {kvp.Value}");
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
