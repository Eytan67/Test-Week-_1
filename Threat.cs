using System.Collections.Generic;
using TestWeek_1.Enums;

namespace TestWeek_1
{
    internal class Threat
    {
        public string ThreatType { get; set; }
        public int Volume { get; set; }
        public int Sophistication { get; set; }
        public string Target { get; set; }
        public int Severity { get { return CalculateSeverity(); } }
        private int CalculateSeverity()
        {
            return (Volume * Sophistication) + TargetValues(Target);
        }
        private int TargetValues(string targets)
        {
            int value = 5;
            TargetsValues.TryGetValue(targets, out value);
            return value;
        }
        private Dictionary<string, int> TargetsValues = new Dictionary<string, int>
        {
            { "Web Server", 10 },
            { "Database", 15 },
            { "User Credentials", 20 }
        };






    }
}
