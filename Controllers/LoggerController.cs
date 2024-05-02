using LogTagAutomationApp.Models;
using System.Collections.Generic;
using System.Diagnostics;

namespace LogTagAutomationApp.Controllers
{
    internal class LoggerController
    {
        // Specific Logger profiles to slect from when creating a test
        public static List<Logger> LoggerProfiles;

        /// <summary>
        /// Loads the list of loggers from the loggers.json file
        /// </summary>
        public static void LoadLoggerProfilesFromFile()
        {
            //Debug.WriteLine("LoadLoggerProfilesFromFile");
            LoggerProfiles = JSONReadFromFile.ReadLoggerProfilesFromFile();
        }
    }
}
