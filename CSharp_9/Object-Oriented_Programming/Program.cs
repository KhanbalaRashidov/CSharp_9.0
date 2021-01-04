using System;

namespace Object_Oriented_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new();
            Person person2 = new("Khanbala");
            Person person3 = new("Khanbala,20");

            Console.WriteLine(person1);
            Console.WriteLine(person2);
            Console.WriteLine(person3);

            Console.ReadKey();
            
        }
    }

    class Person
    {
        public string name;
        public int age;
        public Person()
        {
            name = "Unknown";
            age = 20;
        }
        public Person(string name)
        {
            this.name = name;
            age = 20;
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }


        /* public Person():this("unknown")
         {

         }
         public Person(string name) : this(name, 20)
         {

         }
         public Person(string name, int age)
         {
             this.name = name;
             this.age = age;
         }
        */

        public override string ToString() => $"Name:{name} Age:{age}";

    }
}
