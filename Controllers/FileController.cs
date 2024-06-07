using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
                //string lastLoggedInDate = (string)jsonObj["lastLoggedInDate"];
                string resultsMasterFileName = (string)jsonObj["resultsMasterFileName"];
                //string loggerProfileFileName = (string)jsonObj["loggerProfileFileName"];

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

        /// <summary>
        /// Saves default username to settings.json
        /// </summary>
        /// <param name="username">Name to save</param>
        /// <returns>Value of successful save</returns>
        public static bool SaveDefaultUsernameJson(string username)
        {
            try
            {
                // Check if the file exists
                if (!File.Exists(settingsfilePath))
                {
                    Debug.WriteLine("settings.json file not found.");
                    return false;
                }

                // Read the JSON file content
                string json = File.ReadAllText(settingsfilePath);

                // Parse the JSON content
                JObject jsonObj = JObject.Parse(json);

                // Update the defaultUserName attribute
                jsonObj["defaultUserName"] = username;

                // Convert the JObject back to a JSON string
                string updatedJson = jsonObj.ToString();

                // Write the updated JSON content back to the file
                File.WriteAllText(settingsfilePath, updatedJson);

                Debug.WriteLine("Default UserName overwritten successfully: " + username);

                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("SaveUserNameJsonError: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Sets the filepath of the default Test folder
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Value of successul save</returns>
        public static bool SetDefaultTestFolder(string path)
        {
            try
            {
                // Check if the file exists
                if (!File.Exists(settingsfilePath))
                {
                    Debug.WriteLine("settings.json file not found.");
                    return false;
                }
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                // Read the JSON file content
                string json = File.ReadAllText(settingsfilePath);

                // Parse the JSON content
                JObject jsonObj = JObject.Parse(json);

                // Update the defaultUserName attribute
                jsonObj["mainOutputFolder"] = path;

                // Convert the JObject back to a JSON string
                string updatedJson = jsonObj.ToString();

                // Write the updated JSON content back to the file
                File.WriteAllText(settingsfilePath, updatedJson);

                Debug.WriteLine("Default FilePath overwritten successfully: " + path);

                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("SaveUserNameJsonError: " + ex.Message);
                return false;
            }
        }
    }
}
