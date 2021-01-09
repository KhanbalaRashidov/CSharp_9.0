using System;

namespace Break_and_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<--Multiplication table-->");

            for (int i = 1; i <=10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i}x{j}={i*j} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
