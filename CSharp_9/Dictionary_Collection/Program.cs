using System;
using System.Collections.Generic;

namespace Dictionary_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Dictionary\n");

            //Represents a collection of keys and values.
            Dictionary<string, string> pairs = new Dictionary<string, string>()
            {
                ["Insan"] = "Person",
                ["Shagird"]="Student"
            };

            #region Struct
            //Struct KeyValuePair<string, string> -> Defines a key/value pair that can be set or retrieved.
            Console.WriteLine("\npairs");
            foreach (KeyValuePair<string, string> e in pairs) Console.WriteLine($"{e} ");      // Output of all pairs      
            #endregion

            #region Properties
            //Prop Count -->  Gets the number of key/value pairs contained in the Dictionary<TKey,TValue>.
            Console.WriteLine($"Elements in the dictionary: {pairs.Count}"); // 3

            //Prop [] --> Gets or sets the value associated with the specified key.
            Console.WriteLine($"\n\npairs[\"Muellim\"] = {pairs["Muellim"]}"); // Teacher

            //Prop Keys --> Gets a collection containing the keys in the Dictionary<TKey,TValue>.
            Console.WriteLine("\npairs.Keys");
            foreach (var e in pairs.Keys) Console.Write($"{e} ");      // Outputting all keys

            //Prop Values --> Gets a collection containing the values in the Dictionary<TKey,TValue>.
            Console.WriteLine("\n\npairs.Values");
            foreach (var e in pairs.Values) Console.Write($"{e} ");      // Outputting all keys
            #endregion
            #region Method 
            //Method  Add -->  Adds the specified key and value to the dictionary.
            pairs.Add("Muellim", "Teacher");
            pairs.Add("Yoxla", "Check");
            pairs.Add("Komputer", "Computer");
            pairs.Add("Avtomobil", "Car");

            //Method ContainsKey --> Determines whether the Dictionary<TKey,TValue> contains the specified key.
            Console.WriteLine(pairs.ContainsKey("Muellim"));

            //Method Remove --> Removes the value with the specified key from the Dictionary<TKey,TValue>.
            Console.WriteLine("\n\nDelete \"Muellim\"");

            pairs.Remove("Muellim");  // Delete by key

            Console.WriteLine("\npairs");
            foreach (KeyValuePair<string, string> e in pairs) Console.WriteLine($"{e} ");      // Output of all pairs   

            Console.WriteLine("\n");

           
            
            //Method Clear --> Removes all keys and values from the Dictionary<TKey,TValue>.
            pairs.Clear();             // Clear dictionary
            Console.WriteLine("pairs.Clear(); completed");
            Console.WriteLine($"Elements in the dictionary: {pairs.Count}"); // 0
            #endregion
        }
    }
}
