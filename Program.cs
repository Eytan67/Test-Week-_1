using System;
using TestWeek_1.TSB;
using TestWeek_1.Loaders;

namespace TestWeek_1
{
    internal class Program
    {
        private readonly static string _basePath = "C:\\\\Users\\\\user\\\\source\\\\repos\\\\data\\\\Tests\\\\Week_1\\\\TestWeek_1\\\\JsonFiles\\";
        private readonly static string _defencePath = $"{_basePath}defenceStrategiesBalanced.json";
        private readonly static string _threatPath = $"{_basePath}threats.json";
        
        static void Main(string[] args)
        {

            //Load json files.
            var defences = Loder<Defence>.Load(_defencePath);
            var threat = Loder<Threat>.Load(_threatPath);

            //Create tree and print it.
            BinarySearchTree tree = new BinarySearchTree(defences);
            tree.Print();

            //Initialize and run defence process.
            Firewall firewall = new Firewall(tree, threat);
            firewall.Defence();

            Console.ReadLine();
        }

    }

}

