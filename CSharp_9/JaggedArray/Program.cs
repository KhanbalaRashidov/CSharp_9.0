using System;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[2];
            jaggedArray[0][0] = 1;
            jaggedArray[0][1] = 2;
            

            jaggedArray[1] = new int[3];
            jaggedArray[1][0] = 3;
            jaggedArray[1][1] = 4;
            jaggedArray[1][2] = 5;

            jaggedArray[2] = new int[4];
            jaggedArray[2][0] = 6;
            jaggedArray[2][1] = 7;
            jaggedArray[2][2] = 8;
            jaggedArray[2][3] = 9;

            Console.WriteLine("<---Jagged Array--->");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"{jaggedArray[i][j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
