using LogTagAutomationApp.Controllers;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace LogTagAutomationApp.Models
{
    /// <summary>
    /// Class for handling the extraction of information from the Dostmann .dbf file
    /// </summary>
    public class DostmannHandler
    {
        // A Dictionary for storing all Dostmann readings
        public static Dictionary<DateTime, double> DostmannReadings { get; set; }

        /// <summary>
        /// Extracts readings from the Dostmann file location provided by user
        /// </summary>
        /// <returns>True or false if information was correctly extracte</returns>
        public static bool ExtractDostmann()
        {
            try
            {
                // Check Dostmann file path is valid
                string filePath = FileController.DostmannPath;

                if (!File.Exists(filePath))
                {
                    Debug.WriteLine("DostmannHandler.ExtractDostmann: File not found.");
                    return false;
                }

                // Read in entire file as text string, stops formatting errors in CSV
                string alltext = File.ReadAllText(filePath);
                string[] parts = alltext.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                // Turn each text line into a List object
                List<string> lines = new List<string>();
                string currentLine = "";

                // Iterate through each part and construct lines
                foreach (string part in parts)
                {
                    // Add the part to the current line
                    currentLine += part + " ";

                    // Check if the current line contains more than 6 elements (assuming index, timestamp, date, time, temp1, temp2)
                    if (Regex.Matches(currentLine, @"\S+").Count >= 6)
                    {
                        // Add the current line to the list of lines
                        lines.Add(currentLine.Trim());
                        // Start a new line
                        currentLine = "";
                    }
                }

                // Add the last line if it's not empty
                if (!string.IsNullOrEmpty(currentLine))
                {
                    lines.Add(currentLine.Trim());
                }

                // Dictionary to store column 4 and 5 as key value pairs
                DostmannReadings = new Dictionary<DateTime, double>();

                // Iterate through each line and extract column index 2+3 and 4
                foreach (string line in lines.Skip(1)) // Skip the first line as it is headers
                {
                    string[] columns = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    // Check if there are enough columns in the line
                    if (columns.Length >= 6) // Assuming index, timestamp, date, time, temp1, temp2
                    {
                        string index = columns[0];
                        string timeStampAndDate = columns[1]; // Combined timestamp and date
                        string time = columns[2];
                        string dateSuffix = columns[3];
                        string temp1 = columns[4];
                        string temp2 = columns[5];

                        int dateLength = 10; // Length of the date component 12/34/5678 plus 2x '/'
                        if (timeStampAndDate.Length >= dateLength)
                        {
                            //string timestampString = timeStampAndDate.Substring(0, timeStampAndDate.Length - dateLength); // Timestamp component
                            string dateString = timeStampAndDate.Substring(timeStampAndDate.Length - dateLength); // Date component

                           //Parse date and time components
                           DateTime parsedDateTime;
                            if (DateTime.TryParseExact(dateString + " " + time + " " + dateSuffix, "dd/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDateTime))
                            {
                                // Parse the temperature value
                                double temperature;
                                if (double.TryParse(columns[4], out temperature))
                                {
                                    // Add key-value pair to the dictionary
                                    DostmannReadings[parsedDateTime] = temperature;
                                    //Debug.WriteLine($"Line added to Dostmann: Date={parsedDateTime}, Temperature={temperature}");
                                }
                                else
                                {
                                    // Handle parsing failure if necessary
                                    Debug.WriteLine($"Failed to parse temperature at line: {line}");
                                }
                            }
                            else
                            {
                                // Handle parsing failure if necessary
                                Debug.WriteLine($"Failed to parse date and time at line: {line}");
                            }
                        }
                        else
                        {
                            // Handle invalid timestamp format if necessary
                            Debug.WriteLine($"Invalid timestamp format at line: {line}");
                        }
                    }
                    else
                    {
                        // Handle insufficient columns in the line if necessary
                        Debug.WriteLine($"Insufficient columns in the line: {line}");
                    }
                }

                Debug.WriteLine("DOSTMANN READINGS FOLLOW!");
                //Display key value pairs in Debug.WriteLine // DELETE AFTER TESTING --------------------------------------------------------
                foreach (var kvp in DostmannReadings)
                {
                    Debug.WriteLine($"DOSTMANN: Key: {kvp.Key}, Value: {kvp.Value}");
                }

                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }
    }
}
