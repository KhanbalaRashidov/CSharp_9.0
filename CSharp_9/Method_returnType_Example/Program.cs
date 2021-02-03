using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace Method_returnType_Example
{
    class Program
    {
        static string GetRandomString(int count)
        {
            return Guid.NewGuid().ToString().Substring(0, count);
        }
        static string GetPath(bool fileName)
        {
            return fileName ? Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) : Assembly.GetExecutingAssembly().Location;
        }
        static int[] Inverse(int[] array)
        {
            int[] inverseArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                inverseArray[i] = -array[i];
            }
            return inverseArray;
        }
        static void Pause(int interval)
        {
            Thread.Sleep(1000 * interval);
        }

        static void Fill(int[] arr)
        {
            Random random = new Random ();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(10);
            }
        }
        static void Print(int [] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }
        static int MaxElement(int [] arr)
        {
            //return arr.Max();
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }
        static int MinElement(int[] arr)
        {
            // return arr.Min();
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min>arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
        }
        static void Main(string[] args)
        {
            #region Example1 
            Console.WriteLine("Method parametr");
            Console.WriteLine(GetRandomString(14));
            Console.WriteLine(GetRandomString(16));
            Console.WriteLine(GetRandomString(9));
            Console.WriteLine(GetPath(true));
            Console.WriteLine(GetPath(false));

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }
            
            Console.WriteLine("\n\nInverse Array");
            int[] inverseArray = Inverse(array);
            foreach (var item in inverseArray)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            #endregion
            #region Example 2
            Random random = new Random();
            int n = random.Next(10, 21);
            int[] arrA = new int[n];
            Fill(arrA);
            Console.WriteLine();
            Print(arrA);
            Console.WriteLine($"max element arrA={MaxElement(arrA)}");
            Console.WriteLine($"Min element arrA={MinElement(arrA)}");
            Console.WriteLine();
            int m = random.Next(10, 21);
            int[] arrB = new int[m];
            Pause(5);

            Fill(arrB);
            Console.WriteLine();
            Print(arrB);
            Console.WriteLine($"max element arrB={MaxElement(arrB)}");
            Console.WriteLine($"min element arrB={MinElement(arrB)}");
            #endregion

        }
    }
}
