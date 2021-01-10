using System;

namespace Array2D_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example 1
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[,] b = new int[3, 3];

            int counter = 0;
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    b[i, j] = a[counter++];
                    Console.Write($"{b[i, j]}\t");
                }
                Console.WriteLine("\n\n");
            }
            Console.ReadKey();
            #endregion
            #region Example 2
            Random random = new Random();
            double[,] z = new double[3, 3];
            Console.WriteLine($"{"<-- Array z -->",20}");
            for (int i = 0; i < z.GetLength(0); i++)
            {
                for (int j = 0; j < z.GetLength(1); j++)
                {
                    z[i, j] = random.Next(1, 10);
                    Console.Write($"{z[i, j],6}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"{"Array z[3,3] after",20}");
            Console.WriteLine();
            for (int i = 0; i < z.GetLength(0); i++)
            {
                double div = z[i, i];
                for (int j = 0; j < z.GetLength(1); j++)
                {
                    z[i, j] /= div;
                    Console.Write($"{z[i, j]:F2}\t");
                }
                Console.WriteLine("\n\n");
            }
            #endregion
            #region
            
            int[,] array = new int[4, 4];
            Console.WriteLine($"{"<---array[4,4]--->",25}");
            Console.WriteLine();
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int sumLine = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1, 10);
                    sum += array[i, j];
                    sumLine+=array[i,j];
                    
                    Console.Write($"{array[i,j],5}\t");
                }
                
                Console.Write($" :{sumLine}");
                Console.WriteLine("\n");
            }
            Console.WriteLine($"\nsum={sum}");
            #endregion
            
        }
    }
}
