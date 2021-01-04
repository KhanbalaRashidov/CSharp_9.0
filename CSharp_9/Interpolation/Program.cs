using System;
using System.Collections.Generic;

namespace Interpolation
{
   public class Vegetable
    {
        public Vegetable(string name) => Name = name;
        public string Name { get; }
        public override string ToString() => Name;
       

    }
    class Program
    {
        public enum Unit {item,kilogram,gram,dozen }
        static void Main(string[] args)
        {
            string name = "Khanbala";
            Console.WriteLine($"Hello {name}. How are you?");

            //Animal class
            var item = new Vegetable("tomato");
            var date = DateTime.Now;
            var price = 1.55m;
            var unit = Unit.item;
            Console.WriteLine($"On {date:d}, the price of {item} was {price:C2} per {unit}. ");

            //
            var titles = new Dictionary<string, string>()
            {
                ["Doyle, Arthur Conan"] = "Hound of the Baskervilles, The",
                ["London, Jack"] = "Call of the Wild, The",
                ["Shakespeare, William"] = "Tempest, The"
            };

            Console.WriteLine("-Author and Title list-");
            Console.WriteLine();
            Console.WriteLine($"|{"Autor",-25}|{"Title",31}|");
            foreach (var title in titles)
            {
                Console.WriteLine($"|{title.Key,-25}|{title.Value,31}|");
            }
            Console.WriteLine();
            Console.WriteLine($"|{"Autor",25}|{"Title",31}|");
            foreach (var title in titles)
            {
                Console.WriteLine($"|{title.Key,25}|{title.Value,31}|");
            }
            Console.WriteLine();
            Console.WriteLine($"[{DateTime.Now,-10:d}] Hour [{DateTime.Now,-2:HH}] [{1063.342,10:N2}] feet");
            Console.ReadKey();
        }
    }
}
