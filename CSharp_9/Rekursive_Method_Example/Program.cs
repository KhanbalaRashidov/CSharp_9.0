using System;
using System.Diagnostics;

namespace Rekursive_Method_Example
{
    class Program
    {
        static int Fibo(int n)
        {
            return (n == 1 || n == 2) ? 1 : Fibo(n - 1) + Fibo(n - 2);
        }

        static int FiboLoop(int n)
        {
            int num1 = 1;
            int num2 = 1;
            int fibo = num2;
            for (int i = 2; i < n; i++)
            {
                fibo = num1 + num2;
                num1 = num2;
                num2 = fibo;
            }
            return fibo;
        }

        static string Numbers(int n)
        {
             return (n < 10) ? n.ToString() : $"{Numbers(n /10)} {n % 10}";
           // return (n < 10) ? n.ToString() : $"{n % 10}  {Numbers(n / 10)}";
        }
        static void Find(char [] set, char [] word, int n)
        {
            if (n==word.Length)
            {
                foreach (var item in word)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
                return;
            }
            char[] newWord = word;
            for (int i = 0; i < set.Length; i++)
            {
                newWord[n] = set[i];
                Find(set, newWord, n + 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Rekursive Method");
            Console.Write($"{Fibo(10)}\n");
            for (int i = 1; i <=30; i++)
            {
                Console.WriteLine($"Fibo({i,2}) {Fibo(i)}  {FiboLoop(i)}");
            }

            Console.WriteLine("Numbers...");
            Console.Write($"{Numbers(123)}");
            Console.WriteLine();

            char[] alphabit = { 'a', 'b','c','d','e','f'};
            char[] word = new char[3];
            Find(alphabit, word, 0);
        }
    }
}
