using System;

namespace JaggedArray_example
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exapmle 1
            int[,] dataTime;
            dataTime = new int[24, 12];

            Random random = new Random();

            for (int i = 0; i < dataTime.GetLength(0); i++)
            {
                Console.Write($"{i,3} hour ");
                for (int j = 0; j < dataTime.GetLength(1); j++)
                {
                    if (i>=9 && i<21)
                    {
                        dataTime[i, j] = random.Next(20);
                    }
                    else
                    {
                        dataTime[i, j] = (j < 4) ? random.Next(20) : 0;
                    }
                    Console.Write($"{dataTime[i,j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");
            Console.ReadKey();
            for (int i = 0; i < dataTime.GetLength(0); i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{i,3} hour ");
                for (int j = 0; j < dataTime.GetLength(1); j++)
                {
                    if (i >= 9 && i < 21)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        
                    }
                    else
                    {
                        Console.ForegroundColor = (j < 4) ? ConsoleColor.Cyan : ConsoleColor.Red;
                    }
                    Console.Write($"{dataTime[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            #endregion
            #region
            Console.ReadKey(); Console.Clear();
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
                    Console.Write($"{jaggedDataTime[i][j]}\t");
                }
                Console.WriteLine();
            }
            #endregion

        }
    }
}
