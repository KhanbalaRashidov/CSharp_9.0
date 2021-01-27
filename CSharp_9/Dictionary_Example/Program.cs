using System;
using System.Collections.Generic;

namespace Dictionary_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            Random r = new Random();
            for (int i = 0; i < 1000; i++)
            {
                list.Add(r.Next(20));
            }

            var dictionary = new Dictionary<int, int>();

            foreach (var e in list)
            {
                if (!dictionary.ContainsKey(e)) dictionary.Add(e, 0);
                dictionary[e]++;
            }

            foreach (KeyValuePair<int, int> e in dictionary)
            {
                Console.WriteLine($"{e.Key,3} meets {e.Value,4} .");
            }
        }
    }
}
