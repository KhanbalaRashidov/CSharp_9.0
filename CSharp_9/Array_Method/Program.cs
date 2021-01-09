using System;

namespace Array_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.WriteLine("Enter the size of the array...");
            int size_of = int.Parse(Console.ReadLine());
            int[] array = new int[size_of];
            Console.WriteLine("Array element");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 2);
                Console.Write($"{array[i]} ");
            }

            #region Old

            /*
              int head = 0;
            int tail = array.Length - 1;

            bool flag = true;

            while (head < tail)
            {
                if (flag)
                {
                    if (array[head] == 1)
                    {
                        flag = false;
                    }
                    else head++;
                }
                else
                {
                    if (array[tail] == 0)
                    {
                        flag = true;
                    }
                    else tail--;
                }

                if (array[head]==1 && array[tail]==0)
                {
                    int temp = array[head];
                    array[head] = array[tail];
                    array[tail] = temp;

                    head++;
                    tail--;
                }

            }
             */
            #endregion
            #region TODo
            Array.Sort(array);
            #endregion
            Console.WriteLine("\n Change Array");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.ReadKey();

            int[] data = { 1, 2, 3, 5, 4, 6, 7, 1, 8, 9, 0, 5, 2 };
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"{data[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine($"data.Length={data.Length}");

            int result = Array.IndexOf(data, 5);
            Console.WriteLine($"Array.Indexof(data,5)={result}");

            result = Array.LastIndexOf(data, 5);
            Console.WriteLine($"Array.LastIndexOf(data,5)={result}");

            int rank = data.Rank;
            Console.WriteLine($"data.Rank={rank}");

            Array.Sort(data);
            Console.WriteLine("\nArray.Sort(data):");
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"{data[i]} ");
            }
            Console.WriteLine();

            Array.Reverse(data);
            Console.WriteLine("\nArray.Reverse(data):");
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"{data[i]} ");
            }
            Console.WriteLine();

            Array.Clear(data, 6, 3);
            Console.WriteLine("\nUdate array Array.Clear(data,6,3):");
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"{data[i]} ");
            }
            Console.WriteLine();

            int[] copyData = new int[20];
            Array.ConstrainedCopy(data, 0, copyData, 3, 10);
            Console.WriteLine("Copy Array:");
            for (int i = 0; i < copyData.Length; i++)
            {
                Console.Write($"{copyData[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine("Array.ConstrainedCopy(data, 0, copyData, 3, 10):");
            for (int i = 0; i < copyData.Length; i++)
            {
                Console.Write($"{copyData[i]} ");
            }
            Console.WriteLine();

            int[] copydata=new int[10];
            Array.Copy(data, copydata, 10);
            Console.WriteLine("Array.Copy(data, copydata, 10):");
            for (int i = 0; i < copydata.Length; i++)
            {
                Console.Write($"{copydata[i]} ");
            }
            Console.WriteLine();


        }
    }
}
