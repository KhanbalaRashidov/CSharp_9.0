using System;

namespace Method_Overloading
{
    class Program
    {
        

        static void Fill(int[] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(10);
            }
        }
        static void Fill(int[] arr,int count)
        {
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                arr[i] = random.Next(10);
            }
        }
        static void Fill(int[] arr, int bottomRange,int upperRange )
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(bottomRange,upperRange);
            }
        }
        static void Fill(int[] arr,int count,int bottomRange,int upperRange)
        {
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                arr[i] = random.Next(bottomRange,upperRange);
            }
        }
        static void Print(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item}   ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr = new int[20];

            Console.WriteLine("Method Fill(int [] arr,int count)");
            Fill(arr,10);
            Print(arr);
            Console.ReadKey();

            Console.WriteLine("Method Fill(int [] arr)");
            Fill(arr);
            Print(arr);
            Console.ReadKey();

            Console.WriteLine("Method Fill(int [] arr, int bottomRange, int upperRange)");
            Fill(arr, 30, 50);
            Print(arr);
            Console.ReadKey();

            Console.WriteLine("Method Fill(int [] arr, int count, int bottomRange, int upperRange)");
            Fill(arr, 15, 20, 30);
            Print(arr);
            Console.ReadKey();
        }
    }
}
