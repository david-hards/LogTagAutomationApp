using LogTag.SDK.LogTagIO;
using LogTagAutomationApp.Controllers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;

namespace LogTagAutomationApp.Models
{
    public class LTDHandler
    {
        //public static List<ProductInfo> LoggersWithReadings { get; set; } = new List<ProductInfo>();
        public static List<Logger> ExtractedLoggers { get; set; } = new List<Logger>();
        //public static List<Dictionary<string, string>> LoggersRawReadings;

        /// <summary>
        /// Code for extracting logger info from an LTD file. Returns an SDK Error Code
        /// </summary>
        public static ERROR_CODES ExtractLTDs()
        {
            ExtractedLoggers.Clear();

            foreach (var path in FileController.LTDPaths)
            {
                Logger newLogger = new Logger();

                ProductInfo info = new ProductInfo();
                var result = RetrieveDataFromLogger(ref info, path);

                if( result != ERROR_CODES.SUCCESS)
                {
                    Debug.WriteLine($"Logger retrieval failure");
                    return ERROR_CODES.FAILURE;
                }
                else
                {
                    newLogger.Model = info.DeviceModel.ToString();
                    newLogger.SerialNumber = info.SerialNumber;
                    newLogger.BatchNumber = TestController.BatchNumber;

                    foreach (var reading in info.Readings)
                    {
                        DateTime timeStamp = reading.TimeStamp;
                        double temp = reading.Reading[0];
                        newLogger.Readings.Add(timeStamp, temp);
                    }

                    ExtractedLoggers.Add(newLogger);
                    Debug.WriteLine($"Logger {newLogger.SerialNumber} added to Extracted Loggers");
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
    }
}
