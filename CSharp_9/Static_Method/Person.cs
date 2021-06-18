using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Method
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        public static int Z { get; set; }
        public static  int R { get; set; }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
            X = 0;
            Y = 0;
            R = 0;
            Z = 0;
        }
        public string Run()
        {
            var rnd = new Random();
            X = rnd.Next(-3, 3);
            Y = rnd.Next(-3, 3);
            return $"{Name} ({X},{Y}) Coordinat";
        }

        public static string RunStatic()
        {
            var rnd = new Random();
            Z = rnd.Next(-3, 3);
            R = rnd.Next(-3, 3);
            return $"Random ({Z},{R}) Coordinat";
        }
    }
}
