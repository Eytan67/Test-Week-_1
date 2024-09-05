using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace TestWeek_1.TSB
{
    internal class Defence
    {
        public int MinSeverity { get; set; }
        public int MaxSeverity { get; set; }
        public List<string> Defenses { get; set; }
        public Defence Left { get; set; }
        public Defence Right { get; set; }

        public string ToString()
        {
            return $"[{MinSeverity}-{MaxSeverity} Defences: {Defenses}]";
        }
        public void Active()
        {
            for (int i = 0; i < Defenses.Count; i++)
            {
                Console.WriteLine(Defenses[i]);
                Thread.Sleep(2000);
            }
        }
    }
}
