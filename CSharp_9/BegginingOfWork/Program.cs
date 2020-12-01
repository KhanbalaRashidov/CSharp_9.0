using System;

namespace BegginingOfWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter the Name: ");
            string name = Console.ReadLine();
            Console.Write($"Name: {name}");
            Console.ReadKey();
        }
    }
}
