using System;
using System.Collections.Generic;
using System.Threading;


namespace TestWeek_1.TSB
{
    internal class Defence
    {
        private readonly int _sleepDuration = 2000;
        public int MinSeverity { get; set; }
        public int MaxSeverity { get; set; }
        public List<string> Defenses { get; set; }
        public Defence Left { get; set; }
        public Defence Right { get; set; }

        public string ToString()
        {
            return $" [{MinSeverity}-{MaxSeverity} Defences: {Defenses}]";
        }
        public void Active()
        {
            for (int i = 0; i < Defenses.Count; i++)
            {
                Console.WriteLine($"\t{Defenses[i]}");
                Thread.Sleep(_sleepDuration);
            }
        }

    }

}

