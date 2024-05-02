using LogTagAutomationApp.Controllers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace LogTagAutomationApp.Models
{
    internal class JSONReadFromFile
    {
        public static List<Logger> ReadLoggerProfilesFromFile()
        {
            var file = "loggers.json"; //SessionController.LoggerProfileFileName;
            if (!File.Exists(file))
            {
                Debug.WriteLine($"ReadLoggerProfilesFromFile: {file} file not found.");
                return null;
            }

            try
            {
                var loggers = new List<Logger>();

                // Read the JSON file content
                string json = File.ReadAllText(file);
                // Parse the JSON content
                JObject jsonObj = JObject.Parse(json);
                // Get the array of loggers
                JArray loggersArray = (JArray)jsonObj["Loggers"];

                // Iterate through each logger object
                foreach (JToken loggerToken in loggersArray)
                {
                    Logger logger = new Logger();
                    // Get the logger model
                    string loggerModel = (string)loggerToken["Model"];
                    bool isHumidity = (bool)loggerToken["IsHumidity"];
                    bool isExternal = (bool)loggerToken["IsExternal"];
                    int minTemp = (int)loggerToken["MinTemp"];
                    int maxTemp = (int)loggerToken["MaxTemp"];
                    logger.Model = loggerModel;
                    logger.IsHumidity = isHumidity;
                    logger.IsExternal = isExternal;
                    logger.MinTemp = minTemp;
                    logger.MaxTemp = maxTemp;
                    loggers.Add(logger);
                }
                return loggers;
            }
            catch
            {
                Debug.WriteLine($"ReadLoggerProfilesFromFile: Loggers could not be loaded from {file}");
                return null;
            }
        }

        public static List<Test> ReadTestsFromFile()
        {
            var folderDirectory = SessionController.MainOutputFolder;
            var jsonFile = SessionController.TestsMasterFile;
            var fileName = Path.Combine(folderDirectory, jsonFile);
            //Debug.WriteLine($"JsonReder.ReadTestsFromFile from {fileName}");

            if (!File.Exists(fileName))
            {
                MessageBox.Show($"Cannot find {SessionController.TestsMasterFile} at \n{SessionController.MainOutputFolder}");
                return null;
            }

            string json = File.ReadAllText(fileName);
            var tests = JsonConvert.DeserializeObject<List<Test>>(json);

            if (tests != null)
            {
                //Debug.WriteLine("JsonReder.ReadTestsFromFile: Tests loaded successfully.");
                return tests;
            }
            else
            {
                Debug.WriteLine("ReadTestsFromFile: Failed to deserialize tests from JSON. JSON file empty");
                return null;
            }
        }

        public static void ReadDefaultSettingsFromFile()
        {

        }
    }
}
