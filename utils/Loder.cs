using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


namespace TestWeek_1.Loaders
{
    internal class Loder<T>
    {
        public static List<T> Load(string path)
        {
            string jsonString = File.ReadAllText(path);
            var items = JsonSerializer.Deserialize<List<T>>(jsonString);

            return items;
        }

    }

}

