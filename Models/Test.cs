using System.Collections.Generic;

namespace LogTagAutomationApp.Models
{
    public class Test
    {
        public string TesterName { get; set; }
        public string DateOfTest { get; set; }
        public List<Logger> Loggers { get; set; }
        public bool Result { get; set; } = false;
        // public Dictionary<double, List<double>> Readings { get; set; }
        // Dict = < temp range vale (eg -20), {-19.9, -19.9, -20.1, -19.9} >
        // Where index 0 = dostmann and index 1-6 = six potential loggers
    }
}
