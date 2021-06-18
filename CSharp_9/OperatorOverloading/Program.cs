using System;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operator Overloading\n");

            Apple apple1 = new Apple("Apple1",250,2);
            Apple apple2 = new Apple("Apple2", 250, 2);
           
            
            var result=Apple.Add(apple1,apple2);
            Console.WriteLine(result);
            var sumApple = apple1 + apple2;
            Console.WriteLine(sumApple);
        }
    }
   
}
