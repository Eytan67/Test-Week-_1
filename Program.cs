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

        public static string defencePath = "C:\\Users\\user\\source\\repos\\data\\Tests\\Week_1\\TestWeek_1\\JsonFiles\\defenceStrategiesBalanced.json";
        public static string threatPath = "C:\\Users\\user\\source\\repos\\data\\Tests\\Week_1\\TestWeek_1\\JsonFiles\\threats.json";
        static void Main(string[] args)
        {
         //string currentDirectory = Directory.GetCurrentDirectory();


            var defences = Loder<Defence>.Load(defencePath);
            BinarySearchTree tree = new BinarySearchTree(defences);
            tree.Print();

            var threat = Loder<Threat>.Load(threatPath);

            Firewall firewall = new Firewall(tree, threat);
            firewall.Defence();

            Console.ReadLine();
        }
    }
}
