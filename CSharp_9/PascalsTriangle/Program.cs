using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalsTriangle
{
    public class TriangleProgram
    {

        public static int row = 20;
        public static int[,] triangle = new int[row, row];
        public const int cellWidth = 5;

        public static void FillTriangle()
        {
            for (int i = 0; i < row; i++)
            {
                triangle[i, 0] = 1;
                triangle[i, i] = 1;
            }

            for (int i = 2; i < row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
                }
            }
        }

        public static void PrintTriangle()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (triangle[i, j] != 0) Console.Write($"{triangle[i, j],cellWidth}");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            FillTriangle();

            //Console.SetCursorPosition

            int col = cellWidth * row;
            Console.ReadLine();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.SetCursorPosition(col, i + 1);
                    if (triangle[i, j] != 0) Console.Write($"{triangle[i, j],cellWidth}");
                    col += cellWidth * 2;
                   // Console.WriteLine("*");
                }

                col = cellWidth * row - cellWidth * (i + 1);

                Console.WriteLine();
            }




            //PrintTriangle();

        }


    }
}