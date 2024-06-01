using LogTagAutomationApp.Models;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace LogTagAutomationApp.Controllers
{
    internal class FolderController
    {
        /// <summary>
        /// Creates a folder for the day's tests
        /// </summary>
        /// <param name="path">The file path the folder is created at</param>
        /// <param name="date">The date of the folder to be created</param>
        /// <param name="currentLogger">The logger / subfolder name</param>
        /// <returns>The path of the created folder</returns>
        public static string CreateTestFolder(string path, string date, Logger currentLogger)
        {
            // Create a folder for the day
            var today = CreateFolder(path, date);
            // Create subfolder for the logger
            var loggerFolder = CreateFolder(today, currentLogger.Model);
            return loggerFolder;
        }

        /// <summary>
        /// Creates an individual folder in the specified location
        /// </summary>
        /// <param name="path">The file path the folder is created at</param>
        /// <param name="name">The name of the folder to be created</param>
        /// <returns>The path of the created folder</returns>
        public static string CreateFolder(string path, string name)
        {
            try
            {
                var filePath = Path.Combine(path, name);
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                    return filePath;
                }
                // Folder already exists
                return filePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// Changes the specified file to a CSV
        /// </summary>
        /// <param name="filePath">The path of the file to change</param>
        /// <returns>The path of the changed CSV file</returns>
        public static string RenameToCSV(string filePath)
        {
            // Check if the file exists
            if (!File.Exists(filePath))
            {
                Debug.WriteLine($"RenameToCSV: File '{filePath}' does not exist.");
                return null;
            }

            try
            {
                // Get the directory and file name without extension
                string directory = Path.GetDirectoryName(filePath);
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);

                // Form the new file path with .csv extension
                string newFilePath = Path.Combine(directory, fileNameWithoutExtension + ".csv");

                // Rename the file
                File.Move(filePath, newFilePath);

                Console.WriteLine($"File '{filePath}' renamed to '{newFilePath}'");

                return newFilePath;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// Changes the specified file to a DBF
        /// </summary>
        /// <param name="filePath">The path of the file to change</param>
        /// <returns>The path of the changed DBF file</returns>
        public static string RenameToDBF(string filePath)
        {
            // Check if the file exists
            if (!File.Exists(filePath))
            {
                Debug.WriteLine($"RenameToBDF: File '{filePath}' does not exist.");
                return null;
            }

            try
            {
                // Get the directory and file name without extension
                string directory = Path.GetDirectoryName(filePath);
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);

                // Form the new file path with .csv extension
                string newFilePath = Path.Combine(directory, fileNameWithoutExtension + ".dbf");

                // Rename the file
                File.Move(filePath, newFilePath);

                Console.WriteLine($"File '{filePath}' renamed to '{newFilePath}'");

                return newFilePath;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// Copies the files at the specified locations to a new folder
        /// </summary>
        /// <param name="toPath">The location to be copied to</param>
        /// <param name="fromPaths">The locations to be taken from</param>
        public static void CopyFilesToFolder(string toPath, string[] fromPaths)
        {
            try
            {
                if (!Directory.Exists(toPath))
                {
                    Directory.CreateDirectory(toPath);
                }

                foreach (string filePath in fromPaths)
                {
                    if (File.Exists(filePath))
                    {
                        string fileName = Path.GetFileName(filePath);
                        string destinationFilePath = Path.Combine(toPath, fileName);
                        File.Copy(filePath, destinationFilePath, true);
                        //Debug.WriteLine($"Copied '{filePath}' to '{destinationFilePath}'");
                    }
                    else
                    {
                        Debug.WriteLine($"CopyFilesToFolde: File '{filePath}' does not exist.");
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"CopyFilesToFolde: An error occurred: {ex.Message}");
            }
        }
    }
}
