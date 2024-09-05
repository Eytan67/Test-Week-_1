using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace TestWeek_1
{
    internal class Attack
    {
        public List<Threat> Threats;
        public void SendThreats()
        {
            for(int i = 0; i < Threats.Count; ++i)
            {
                Program.threats.Enqueue(Threats[i]);
                Thread.Sleep(2000);
            }

        }
    }
}
