using System;

namespace Static_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("Name1", "Surname1");
            var person2=new Person("Name2", "Surname2");

           

            for (int i = 0; i < 10; i++)
            {
                var position1 = person1.Run();
                var position2 = person2.Run();

                Console.WriteLine($"Position1=> {position1}");
                Console.WriteLine($"Position2=>{position2}");

            }
            Console.ReadKey(); Console.Clear();

            for (int i = 0; i < 10; i++)
            {
                var position1 = Person.RunStatic();
                var position2 = Person.RunStatic();

                Console.WriteLine($"Position1=> {position1}");
                Console.WriteLine($"Position2=>{position2}");

            }

        }
    }
}
