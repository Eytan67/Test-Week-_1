using System;
using System.Collections.Generic;
using System.Threading;
using TestWeek_1.TSB;


namespace TestWeek_1
{
    internal class Firewall
    {
        private readonly int _sleepDuration = 2000;
        private string _lowMassage = "is severity Attack below the threshold. Attack is ignored";
        private string _noSuitableMassage = "was defence suitable No found. Brace for impact";
        private List<Threat> _threats;
        private BinarySearchTree _defencesTree;

        public Firewall(BinarySearchTree tree, List<Threat> threats)
        {
            _defencesTree = tree;
            _threats = threats;
        }

        //O(k log(n)).
        public void Defence()
        {
            for (int i = 0; i < _threats.Count; ++i)
            {
                Console.WriteLine($"{i}). Handles an {_threats[i].ThreatType} type threat");
                var defence = _defencesTree.Find(_threats[i].Severity);
                if (defence != null)
                {
                    defence.Active();
                    Console.WriteLine("    The threat has been removed\n");
                }
                else
                {
                    string massage =
                    _threats[i].Severity < _defencesTree.Min() ?
                    _lowMassage 
                    : _noSuitableMassage;

                    Console.WriteLine($"\t{massage}\n");
                }
                Thread.Sleep(_sleepDuration);
            }

        }

    }

}

