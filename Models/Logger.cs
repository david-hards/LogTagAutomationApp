using System;
using System.Collections.Generic;

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
        public Dictionary<DateTime, double> Readings { get; set; } = new Dictionary<DateTime, double>();

        public Logger() { }

        public override string ToString()
        {
            return Model; // Remove this AND change the PopulateComboBox in LoggerController if there are errors around naming.
        }
    }
}
