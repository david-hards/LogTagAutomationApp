using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogTagAutomationApp.Models
{
    public class Logger
    {
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public string BatchNumber { get; set; }
        public bool IsHumidity { get; set; }
        public bool IsExternal { get; set; }
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }
        public Dictionary<int, float> Readings { get; set; } = new Dictionary<int, float>();

        public Logger() { }

        public Logger(string model, string serial, string batchNumber, bool isHumidity, bool isExternal, int minTemp, int maxTemp)
        {
            Model = model;
            SerialNumber = serial;
            BatchNumber = batchNumber;
            IsHumidity = isHumidity;
            IsExternal = isExternal;
            MinTemp = minTemp;
            MaxTemp = maxTemp;
        }

        public override string ToString()
        {
            return Model; // Remove this AND change the PopulateComboBox in LoggerController if there are errors around naming.
        }
    }
}
