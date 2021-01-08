using System;
using System.Diagnostics;

namespace Example_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Even numbers");
            for (int i = 0; i < 100; i++)
            {
                if (i%2==0)
                {
                    Debug.Write(">>>");
                    Debug.Write($"{i}");
                   

                }
            }

        }
    }
}
