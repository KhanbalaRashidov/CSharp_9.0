using System;

namespace Array3D_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] matrix3D = new int[3, 4, 5];

            Console.WriteLine($"matrix3D.Rank={matrix3D.Rank}");

            Console.WriteLine($"matrix3D.Length={matrix3D.Length}");
            Console.WriteLine($"matrix3D.GetLangth(0)={matrix3D.GetLength(0)}");
            Console.WriteLine($"matrix3D.GetLangth(1)={matrix3D.GetLength(1)}");
            Console.WriteLine($"matrix3D.GetLangth(2)={matrix3D.GetLength(2)}");

            Random random = new Random();
            for (int i = 0; i < matrix3D.GetLength(0); i++)
            {
                for (int j = 0; j < matrix3D.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix3D.GetLength(2); k++)
                    {
                        matrix3D[i, j, k] = random.Next(1, 10);
                        Console.Write($"{matrix3D[i,j,k]}\t");
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n\n");
            int[,,,] matrix4D = new int[3, 4, 5, 6];
            Console.WriteLine($"matrix3D.Rank={matrix4D.Rank}");

            Console.WriteLine($"matrix4D.Length={matrix4D.Length}");
            Console.WriteLine($"matrix4D.GetLangth(0)={matrix4D.GetLength(0)}");
            Console.WriteLine($"matrix4D.GetLangth(1)={matrix4D.GetLength(1)}");
            Console.WriteLine($"matrix4D.GetLangth(2)={matrix4D.GetLength(2)}");
            Console.WriteLine($"matrix4D.GetLangth(3)={matrix4D.GetLength(3)}");

            Console.WriteLine("\n<--- matrix4D --->");
            for (int i = 0; i < matrix4D.GetLength(0); i++)
            {
                for (int j = 0; j < matrix4D.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix4D.GetLength(2); k++)
                    {
                        for (int m = 0; m < matrix4D.GetLength(3); m++)
                        {
                            matrix4D[i, j, k, m] = random.Next(1, 10);
                            Console.Write($"{matrix4D[i,j,k,m]}\t");
                        }
                        Console.WriteLine("\n");
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine("\n");
            }

        }
    }
}
