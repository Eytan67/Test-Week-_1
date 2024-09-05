using System.Collections.Generic;


namespace TestWeek_1
{
    internal class Threat
    {
        public string ThreatType { get; set; }
        public int Volume { get; set; }
        public int Sophistication { get; set; }
        public string Target { get; set; }
        public int Severity { get { return CalculateSeverity(); } }

        //O(1).
        private int CalculateSeverity()
        {
            return (Volume * Sophistication) + TargetValues(Target);
        }

        //O(1).
        private int TargetValues(string targets)
        {
            int value = 5;
            _targetsValues.TryGetValue(targets, out value);
            return value;
        }

        private Dictionary<string, int> _targetsValues = new Dictionary<string, int>
        {
            { "Web Server", 10 },
            { "Database", 15 },
            { "User Credentials", 20 }
        };

    }

}

