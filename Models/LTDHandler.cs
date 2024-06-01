﻿using LogTag.SDK.LogTagIO;
using LogTagAutomationApp.Controllers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace LogTagAutomationApp.Models
{
    public class LTDHandler
    {
        public static List<ProductInfo> LoggersWithReadings { get; set; } = new List<ProductInfo>();
        public static List<Dictionary<string, string>> LoggersRawReadings;

        /// <summary>
        /// Code for extracting logger info from an LTD file. Returns an SDK Error Code
        /// </summary>
        public static ERROR_CODES ExtractLTDs()
        {
            LoggersWithReadings.Clear();

            foreach (var path in FileController.LTDPaths)
            {
                ProductInfo logger = new ProductInfo();
                var result = RetrieveDataFromLogger(ref logger, path);

                if( result != ERROR_CODES.SUCCESS)
                {
                    Debug.WriteLine($"Logger at {path} was a {result}: {logger.DeviceModel}, serial {logger.SerialNumber}");
                    return ERROR_CODES.FAILURE;
                }
                else
                {
                    Debug.WriteLine($"Logger at {path} was a {result}: {logger.DeviceModel}, serial {logger.SerialNumber}");
                    LoggersWithReadings.Add(logger);
                }
            }
            return ERROR_CODES.SUCCESS;
        }

        /// <summary>
        /// Code from LogTag SDK to retrieve data from a Logger
        /// </summary>
        /// <param name="Info">Reference to the ProductInfo object that the readings will be stored in</param>
        /// <param name="Filename">The file name and location of the .ltd file to read from</param>
        /// <param name="Scale">Sensor scale in Celcius or Fahrenheit</param>
        /// <returns></returns>
        public static ERROR_CODES RetrieveDataFromLogger(ref ProductInfo Info, String Filename, SENSOR_SCALE Scale = SENSOR_SCALE.CELSIUS)
        {
            ERROR_CODES result = 0;
            //// Check if filename has the ltd file extension
            if (Path.GetExtension(Filename).ToLower() != ".ltd")
            {
                result = ERROR_CODES.UNSUPPORTED_FILE; // unsupported file extension
                return result;
            }

            // Create a new LogTag handle, this is used to manage the following operations
            LogTagHandle handle = LogTagIO.LT_OpenAccess();
            // Check if the file exists
            if (File.Exists(Filename) == false)
            {
                result = ERROR_CODES.ACCESS_FILE; // Can't access file provided
                return result;
            }

            // Try and open the specified filename
            result = LogTagIO.LT_OpenPath(handle, Filename);
            if (result != ERROR_CODES.SUCCESS)
            { // Check for success opening the file
                return result; // return the error
            }

            // If Info object is not initialised
            if (Info == null) { Info = new ProductInfo(); } // Create new ProductInfo object

            // Get the populated ProductInfo for the specified file
            result = LogTagIO.LT_GetData(handle, ref Info, Scale);

            LogTagIO.LT_Close(handle); // finished with the handle

            // Return the result of the operation
            return result;
        }

        // This can possibly be moved into the comparison section as it doesn't need to be here? --------------------------------------
        public static void GetLTDReadings()
        {
            Debug.WriteLine("GET LTDREADINGS CALLED");

            LoggersRawReadings = new List<Dictionary<string, string>>();

            LoggersRawReadings.Clear();


            foreach (var logger in LoggersWithReadings)
            {
                Dictionary<string, string> newDict = new Dictionary<string, string>();

                foreach (SensorReading reading in logger.Readings)
                {
                    string key = reading.TimeStamp.ToString();
                    string value = reading.Reading[0].ToString();

                    // Add key value pair to the dictionary
                    newDict[key] = value;
                    
                }

                LoggersRawReadings.Add(newDict);
            }

            Debug.WriteLine("TESTING LTD KVPS");
            Debug.WriteLine($"Number of loggers in dict: {LoggersRawReadings.Count}");
            Debug.WriteLine($"Loogerswithreadings: {LoggersWithReadings.Count}");

            foreach(var logger in LoggersRawReadings)
            {
                Debug.WriteLine($"NEW LOGGER!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                foreach (var kvp in logger)
                {
                    Debug.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
                }
            }

            
        }


}
}
