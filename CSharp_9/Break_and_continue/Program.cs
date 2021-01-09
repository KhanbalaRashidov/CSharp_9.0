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

            char[] symbols = { 'K','H','A','N' };
            int count = 0;
            for (int i = 0; i < symbols.Length; i++)
            {
                for (int j = 0; j < symbols.Length; j++)
                {
                    for (int k = 0; k < symbols.Length; k++)
                    {
                        Console.WriteLine($"{++count,3}: {symbols[i]}{symbols[j]}{symbols[k]}");
                    }
                }
            }
            Console.WriteLine();
            double result = 0;
            for (double a = 0; a < 100; a++)
            {
                for (double b = 0; b < 100; b++)
                {
                    result = (2 * (a * a * a) + 3 * (b * b));
                    if (result==8337)
                    {
                        Console.WriteLine($"a={a}  b={b}");
                    }
                }
            }
            Console.WriteLine();

            for (int i = 1; i <=10; i++)
            {
                if (i%2==0)
                {
                    continue;
                }
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i}x{j}={i*j}");
                }
                Console.WriteLine();
            }
            count = 0;
            for (int i = 1; i <= 1_000; i++)
            {
                for (int j = 1; j <= 1_000; j++)
                {
                    count++;
                    Console.Write($"{i*j}  ");
                    if (count % 10 == 0) break;
                }
                Console.WriteLine();
            }
            Console.WriteLine($"count={count}");
            Console.ReadKey();
        }
    }
}
