using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace LogTagAutomationApp.Models
{
    internal class JSONWriteToFile
    {
        public static void AppendTestToMasterFile(string filePath, Test test)
        {
            try
            {
                List<Test> testsList;

                // Check if the file exists
                if (File.Exists(filePath))
                {
                    //Debug.WriteLine($"AppendTestToMasterFile: Existing file found. Attempting to read JSON.");

                    // Read the existing JSON from file
                    string json = File.ReadAllText(filePath);

                    // Deserialize JSON to list of tests
                    testsList = JsonConvert.DeserializeObject<List<Test>>(json);

                    if (testsList == null)
                    {
                        //Debug.WriteLine("AppendTestToMasterFile: Failed to deserialize JSON into List<Test>. Creating new list.");
                        testsList = new List<Test>();
                    }
                }
                else
                {
                    //Debug.WriteLine($"AppendTestToMasterFile: File does not exist. Creating new file.");
                    testsList = new List<Test>();
                }

                // Add the new test to the list
                testsList.Add(test);

                // Serialize the updated list to JSON
                string updatedJson = JsonConvert.SerializeObject(testsList, Formatting.Indented);

                // Write the JSON back to the file
                File.WriteAllText(filePath, updatedJson);

                //Debug.WriteLine($"JSONWriteToFile.AppendToMasterFile: Test appended successfully.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"AppendTestToMasterFile: An error occurred: {ex.Message}");
            }
        }
    }
}
