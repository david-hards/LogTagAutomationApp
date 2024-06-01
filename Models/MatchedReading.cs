namespace LogTagAutomationApp.Models
{
    // Custom class to store matched key and both values
    internal class MatchedReading
    {
        public string KeyTime { get; set; }
        public string ValueFromDostmann { get; set; }
        public string ValueFromLogger { get; set; }
    }
}
