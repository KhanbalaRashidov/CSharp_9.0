using System;

namespace Methods
{
    class Program
    {

        public static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
        static void Delay()
        {
            Console.ReadKey();
        }
        static void Display(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
        static void ArrayAssign(int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(10);
            }
        }
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
        }
        static void ArrayMaxElement(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"\nmax={max}");
        }
        static void ArrayMinElement(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"\nmin={min}");
        }
        static void Main(string[] args)
        {
            HelloWorld();
            Display("Khanbala");
            Delay();
            Console.WriteLine("Enter the array size");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            ArrayAssign(array);
            PrintArray(array);
            ArrayMaxElement(array);
            ArrayMinElement(array);
        }
    }
}
