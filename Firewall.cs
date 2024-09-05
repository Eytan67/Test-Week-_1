using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestWeek_1.TSB;


namespace TestWeek_1
{
    internal class Firewall
    {
        private string _lowMassage = "is severity Attack below the threshold. Attack is ignored";
        private string _noSuitableMassage = "was defence suitable No found. Brace for impact";
        public List<Threat> Threats;
        public BinarySearchTree DefencesTree;

        public void Defence()
        {
            for (int i = 0; i < Threats.Count; ++i)
            {
                var defence = DefencesTree.Find(Threats[i].Severity);
                if (defence != null)
                {
                    Console.WriteLine("תחילת הגנה");//!!!!!!!!!!!!
                defence.Active();
                    Console.WriteLine("תחילת הגנה");//!!!!!!!!!!!!
                }
                else
                {
                    string massage =
                    Threats[i].Severity < DefencesTree.Min() ?
                    _lowMassage : _noSuitableMassage;
                    Console.WriteLine(massage);
                }
                Thread.Sleep(2000);
            }

        }
    }
}
