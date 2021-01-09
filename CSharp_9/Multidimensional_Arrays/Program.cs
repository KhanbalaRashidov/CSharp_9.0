using System;

namespace Multidimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 4];
            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }



            Console.WriteLine("Enter the row");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the col");
            int col = int.Parse(Console.ReadLine());
            int[,] array2D = new int[row, col];
            Console.WriteLine("<--Created array2D-->");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    array2D[i, j] = random.Next(1, 10);
                    Console.Write($"{array2D[i, j]}\t");
                }
                Console.WriteLine("\n\n");
                
            }
            Console.WriteLine();

            string[,] table = { {"00","01","02"},
                                {"10","11","12"},
                                {"20","21","22"} 
            };

            Console.WriteLine();
            Console.WriteLine($"table.Rank={table.Rank}");
            Console.WriteLine($"array2D.GetLength(0)={array2D.GetLength(0)}");
            Console.WriteLine($"array2D.GetLength(1)={array2D.GetLength(1)}");

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write($"{table[i,j]}\t");
                }
                Console.WriteLine("\n\n");
               
            }



        }
    }
}
