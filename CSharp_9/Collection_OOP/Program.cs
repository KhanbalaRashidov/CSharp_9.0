using System;

namespace Collection_OOP
{
    class Program
    {

        static void PrintArray(int[] Array, string Text="")
        {
            Console.WriteLine(Text, "\n");
            foreach (var element in Array)
            {
                Console.Write($"{element}\t");
            }
            Console.WriteLine("\n");
        }

        static bool RemoveAt(ref int[] Col, int Position)
        {
            bool result = false;
            if (Position >= 0 && Position < Col.Length)
            {
                for (int i = Position; i < Col.Length - 1; i++)
                {
                    Col[i] = Col[i + 1];
                }
                Array.Resize(ref Col, Col.Length - 1);
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Collection\n");
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            PrintArray(arr, "Added");

            RemoveAt(ref arr, 3);
            PrintArray(arr,"Remove index=3");
        }
    }
}
