using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.IO;

namespace LogTagAutomationApp.Controllers
{
    public class FileController
    {
        // Path to the json files in the project directory
        private const string settingsfilePath = "settings.json";
        // Path to the current Dostmann file
        public static string DostmannPath { get; set; }
        // Array of paths to the current LTD files
        public static string[] LTDPaths { get; set; }

        /// <summary>
        /// At launch, loads the default settings from the settings.json file
        /// </summary>
        public static void LoadDefaultSettings()
        {
            // Check if the file exists
            if (!File.Exists(settingsfilePath))
            {
                Debug.WriteLine($"{settingsfilePath} file not found.");
                return;
            }
            // Attempt loading
            try
            {
                // Read the JSON file content
                string json = File.ReadAllText(settingsfilePath);

                // Parse the JSON content
                JObject jsonObj = JObject.Parse(json);

                // Get the value of attributes
                string defaultUserName = (string)jsonObj["defaultUserName"];
                string mainOutputFolder = (string)jsonObj["mainOutputFolder"];
                string lastLoggedInDate = (string)jsonObj["lastLoggedInDate"];
                string resultsMasterFileName = (string)jsonObj["resultsMasterFileName"];
                string loggerProfileFileName = (string)jsonObj["loggerProfileFileName"];

                // Set the attributes to Session Controller
                SessionController.SetUsername(defaultUserName);
                SessionController.MainOutputFolder = mainOutputFolder;
                SessionController.TestsMasterFile = resultsMasterFileName;
            }
            catch
            {
                Debug.WriteLine("Settings could not be loaded from settings.json");
            }
        }
    }
}
