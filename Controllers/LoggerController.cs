using LogTagAutomationApp.Models;
using System.Collections.Generic;
using System.Linq;

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
            LoggerProfiles = JSONReadFromFile.ReadLoggerProfilesFromFile();
        }

        public static int getMinTemp(string model)
        {
            var loggerProfile = LoggerProfiles.FirstOrDefault(profile => profile.Model == model);
            return loggerProfile != null ? loggerProfile.MinTemp : -30;
        }

        public static int getMaxTemp(string model)
        {
            var loggerProfile = LoggerProfiles.FirstOrDefault(profile => profile.Model == model);
            return loggerProfile != null ? loggerProfile.MaxTemp : 60;
        }
    }
}
