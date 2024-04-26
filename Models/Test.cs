using System.Collections.Generic;

namespace LogTagAutomationApp.Models
{
    public class Test
    {
        public string TesterName { get; set; }
        public string DateOfTest { get; set; }
        public List<Logger> Loggers { get; set; }
        public bool Result { get; set; } = false;
        public Dictionary<int, float> DostmannResults { get; set; }
    }
}
