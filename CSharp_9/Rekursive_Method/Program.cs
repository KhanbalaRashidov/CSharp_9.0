using System;
using System.Threading;
namespace Rekursive_Method
{
    class Program
    {
        static void Infinty()
        {
            Console.Write($"o_o-");
            Thread.Sleep(1000);
            Infinty();
        }
        static void NotInfinty(int count)
        {
            Console.Write($"o_o-");
            Thread.Sleep(100);
            count--;
            if (count>0)
            {
                NotInfinty(count);
            }
        }
        static void Main(string[] args)
        {
            // Infinty();
            NotInfinty(10000);
        }
    }
}
