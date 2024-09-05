using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeek_1.TSB;
using System.Text.Json;
using TestWeek_1.Loaders;

namespace TestWeek_1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            string defencePath = "C:\\Users\\user\\source\\repos\\data\\Tests\\Week_1\\TestWeek_1\\defenceStrategiesBalanced.json";
            string threatPath = "C:\\Users\\user\\source\\repos\\data\\Tests\\Week_1\\TestWeek_1\\threats.json";

            var defences = Loder<Defence>.Load(defencePath);
            var threat = Loder<Threat>.Load(threatPath);


            foreach (Defence defence in defences)
            {
                tree.Insert(defence);
            }
            Console.WriteLine(tree.Find(20).ToString());
            //tree.Print();
            
            
            
            Console.ReadLine();
        }
    }
}
