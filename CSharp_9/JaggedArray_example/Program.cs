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
            Console.WriteLine("indices and range...");
            #region indices and range
            var jagged = new int[10][]
            {
              new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 },
              new int[10] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 },
              new int[10] { 20, 21, 22, 23, 24, 25, 26, 27, 28, 29 },
              new int[10] { 30, 31, 32, 33, 34, 35, 36, 37, 38, 39 },
              new int[10] { 40, 41, 42, 43, 44, 45, 46, 47, 48, 49 },
              new int[10] { 50, 51, 52, 53, 54, 55, 56, 57, 58, 59 },
              new int[10] { 60, 61, 62, 63, 64, 65, 66, 67, 68, 69 },
              new int[10] { 70, 71, 72, 73, 74, 75, 76, 77, 78, 79 },
              new int[10] { 80, 81, 82, 83, 84, 85, 86, 87, 88, 89 },
              new int[10] { 90, 91, 92, 93, 94, 95, 96, 97, 98, 99 },
            };

            var selectedRows = jagged[3..^3];

            foreach (var row in selectedRows)
            {
                var selectedColumns = row[2..^2];
                foreach (var cell in selectedColumns)
                {
                    Console.Write($"{cell}, ");
                }
                Console.WriteLine();
            }
            #endregion

        }
    }
}
