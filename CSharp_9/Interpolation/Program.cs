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
        public enum Unit { item, kilogram, gram, dozen }
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

            //
            double a = 3;
            double b = 14;
            double PerimetrRectangle(double a, double b) => 2.0 * (a + b);
            Console.WriteLine($"The area of a rectangle with sides {a} and {b} : {a * b}.");
            Console.WriteLine($"The perimeter of a rectangle with sides {a} and {b} : {PerimetrRectangle(a, b)}");
            Console.WriteLine();
            //
            var datePI = new DateTime(1987, 03, 14).GetDateTimeFormats();
            Console.WriteLine($"Fans celebrate {Math.PI:F5} Day on {date:dddd, MMMM dd, yyyy} at 1:59 p.m.");
            //escape
            var xs = new int[] { 1, 2, 7, 9 };
            var ys = new int[] { 7, 9, 12 };
            Console.WriteLine($"Find the intersection of the {{{string.Join(", ", xs)}}} and {{{string.Join(", ", ys)}}} sets.");
            var userName = "Khanbala";
            var stringWithEscapes = $"C:\\Users\\{userName}\\Desktop";
            var verbatimInterpolated = $@"C:\Users\{userName}\Desktop";
            Console.WriteLine(stringWithEscapes);
            Console.WriteLine(verbatimInterpolated);
            Console.WriteLine();
            //ternary
            var rand = new Random();
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Coin flip: {(rand.NextDouble() < 0.5 ? "heads" : "tails")}");
            }
            //culture-specific
            Console.WriteLine();
            var cultures = new System.Globalization.CultureInfo[]
             {
               System.Globalization.CultureInfo.GetCultureInfo("en-US"),
               System.Globalization.CultureInfo.GetCultureInfo("en-GB"),
               System.Globalization.CultureInfo.GetCultureInfo("nl-NL"),
               System.Globalization.CultureInfo.InvariantCulture
             };

            var dateNow = DateTime.Now;
            var number = 31_415_926.536;
            FormattableString message = $"{dateNow,20}{number,20:N3}";
            foreach (var culture in cultures)
            {
                var cultureSpecificMessage = message.ToString(culture);
                Console.WriteLine($"{culture.Name,-10}{cultureSpecificMessage}");
            }
            //invariant culture
            string messageInInvariantCulture = FormattableString.Invariant($"Date and time in invariant culture: {DateTime.Now}");
            Console.WriteLine(messageInInvariantCulture);

            Console.ReadKey();
        }
    }
}
