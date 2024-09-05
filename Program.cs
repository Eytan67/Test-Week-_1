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
            string path = "C:\\Users\\user\\source\\repos\\data\\Tests\\Week_1\\TestWeek_1\\defenceStrategiesBalanced.json";

            var defences = Loder<Defence>.Load(path);

            foreach (Defence defence in defences)
            {
                tree.Insert(defence);
            }
            
            
            
            Console.ReadLine();
        }
    }
}
