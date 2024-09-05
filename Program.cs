using System;
using TestWeek_1.TSB;
using TestWeek_1.Loaders;

namespace TestWeek_1
{
    internal class Program
    {

        private readonly static string _defencePath = "C:\\Users\\user\\source\\repos\\data\\Tests\\Week_1\\TestWeek_1\\JsonFiles\\defenceStrategiesBalanced.json";
        private readonly static string _threatPath = "C:\\Users\\user\\source\\repos\\data\\Tests\\Week_1\\TestWeek_1\\JsonFiles\\threats.json";
        
        static void Main(string[] args)
        {
         //string currentDirectory = Directory.GetCurrentDirectory();

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

