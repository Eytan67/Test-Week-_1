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
        public List<Threat> _threats;
        private BinarySearchTree _defencesTree;
        public Firewall(BinarySearchTree tree, List<Threat> threats)
        {
            _defencesTree = tree;
            _threats = threats;
        }
        public void Defence()
        {
            for (int i = 0; i < _threats.Count; ++i)
            {
                var defence = _defencesTree.Find(_threats[i].Severity);
                if (defence != null)
                {
                    Console.WriteLine(">>>>>>>>>>>>>");//!!!!!!!!!!!!
                defence.Active();
                    Console.WriteLine("<<<<<<<<<<<<<");//!!!!!!!!!!!!
                }
                else
                {
                    string massage =
                    _threats[i].Severity < _defencesTree.Min() ?
                    _lowMassage : _noSuitableMassage;
                    Console.WriteLine(massage);
                }
                Thread.Sleep(2000);
            }

        }
    }
}
