using System;

namespace Loop_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Enter the size of the array...");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(-9, 10);
            }

            Console.WriteLine("Array element");
            foreach (var item in numbers)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            #region
            Random random = new Random();
            int[][] jaggedDataTime = new int[24][];
            for (int j = 0; j < jaggedDataTime.Length; j++)
            {
                jaggedDataTime[j] = (j >= 9 && j < 21) ? new int[12] : new int[4];
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("jaggedDatatime[][]");
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < jaggedDataTime.Length; i++)
            {
                for (int j = 0; j < jaggedDataTime[i].Length; j++)
                {
                    jaggedDataTime[i][j] = random.Next(20);

                }
            }

            foreach (var array in jaggedDataTime)
            {
                foreach (var item in array)
                {
                    Console.Write($"{item}\t");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            #endregion
            Console.WriteLine();
            #region string for foreach
            string fullName = "I'm Khanbala Rashidov";
            for (int i = 0; i < fullName.Length; i++)
            {
                Console.Write($"{fullName[i]} ");
            }
            Console.WriteLine();
            foreach (var item in fullName)
            {
                Console.Write($"{item} ");
            }
            #endregion
           
        }
    }
}
