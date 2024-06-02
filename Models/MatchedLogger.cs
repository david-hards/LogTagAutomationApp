using System;
using System.Collections.Generic;

namespace LogTagAutomationApp.Models
{
    // Class to store matched key and both values
    public class MatchedLogger
    {
        public string Serial {  get; set; }
        public string Model {  get; set; }
        public List<MatchedReading> MatchedReadings { get; set; }

        public MatchedLogger(string serial, string model)
        {
            this.Serial = serial;
            this.Model = model;
            this.MatchedReadings = new List<MatchedReading>(); // Initialize the list here
            Model = model;
        }
    }

    public class MatchedReading
    {
        public DateTime KeyTime { get; set; }
        public double ValueFromLogger { get; set; }
        public double ValueFromDostmann { get; set; }
    }
}
