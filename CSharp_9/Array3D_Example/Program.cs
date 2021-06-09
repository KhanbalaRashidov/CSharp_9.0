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
            Console.ReadKey();
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

            Console.WriteLine("\n\n");
            int[,,,,] matrix5D = new int[3, 4, 5, 6,7];
            Console.WriteLine($"matrix5D.Rank={matrix5D.Rank}");

            Console.WriteLine($"matrix5D.Length={matrix5D.Length}");
            Console.WriteLine($"matrix5D.GetLangth(0)={matrix5D.GetLength(0)}");
            Console.WriteLine($"matrix5D.GetLangth(1)={matrix5D.GetLength(1)}");
            Console.WriteLine($"matrix5D.GetLangth(2)={matrix5D.GetLength(2)}");
            Console.WriteLine($"matrix5D.GetLangth(3)={matrix5D.GetLength(3)}");

            Console.WriteLine("\n<--- matrix5D --->");
            for (int i = 0; i < matrix5D.GetLength(0); i++)
            {
                for (int j = 0; j < matrix5D.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix5D.GetLength(2); k++)
                    {
                        for (int m = 0; m < matrix5D.GetLength(3); m++)
                        {
                            for (int l = 0; l < matrix5D.GetLength(4); l++)
                            {
                                matrix5D[i, j, k, m,l] = random.Next(1, 10);
                                Console.Write($"{matrix5D[i, j, k, m,l]}\t");
                            }
                            Console.WriteLine("\n");
                        }
                        Console.WriteLine("\n");
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("\n\n");
            int[,,,,,] matrix6D = new int[3, 4, 5, 6, 7,8];
            Console.WriteLine($"matrix6D.Rank={matrix6D.Rank}");

            Console.WriteLine($"matrix6D.Length={matrix6D.Length}");
            Console.WriteLine($"matrix6D.GetLangth(0)={matrix6D.GetLength(0)}");
            Console.WriteLine($"matrix6D.GetLangth(1)={matrix6D.GetLength(1)}");
            Console.WriteLine($"matrix6D.GetLangth(2)={matrix6D.GetLength(2)}");
            Console.WriteLine($"matrix6D.GetLangth(3)={matrix6D.GetLength(3)}");

            Console.WriteLine("\n<--- matrix6D --->");
            for (int i = 0; i < matrix6D.GetLength(0); i++)
            {
                for (int j = 0; j < matrix6D.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix6D.GetLength(2); k++)
                    {
                        for (int m = 0; m < matrix6D.GetLength(3); m++)
                        {
                            for (int l = 0; l < matrix6D.GetLength(4); l++)
                            {
                                for (int n = 0; n < matrix6D.GetLength(5); n++)
                                {
                                    matrix6D[i, j, k, m, l,n] = random.Next(1, 10);
                                    Console.Write($"{matrix6D[i, j, k, m, l,n]}\t");
                                }
                                Console.WriteLine("\n");
                            }
                            Console.WriteLine("\n");
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
