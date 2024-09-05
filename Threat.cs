using TestWeek_1.Enums;

namespace TestWeek_1
{
    internal class Threat
    {
        public string ThreatType {  get; set; }
        public int Volume {  get; set; }
        public int Sophistication {  get; set; }
        public ETargets Targets { get; set; }
    }
}
