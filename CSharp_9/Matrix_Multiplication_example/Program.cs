using System;

namespace Matrix_Multiplication_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the matrix A.\n");
            int a_row = int.Parse(Console.ReadLine());
            int a_column = int.Parse(Console.ReadLine());
            float[,] matrix_A = new float[a_row, a_column];
            for (int i = 0; i < a_row; i++)
            {
                for (int j = 0; j < a_column; j++)
                {
                    matrix_A[i, j] = float.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nEnter the size of the matrix B.\n");
            int b_row = int.Parse(Console.ReadLine());
            int b_column = int.Parse(Console.ReadLine());
            float[,] matrix_B = new float[b_row, b_column];

            for (int i = 0; i < b_row; i++)
            {
                for (int j = 0; j < b_column; j++)
                {
                    matrix_B[i, j] = float.Parse(Console.ReadLine());

                }
            }

            if (a_column != b_row)
            {
                Console.WriteLine("Multiplication cannot be performed on matrices\n");
            }
            else
            {
                if ((a_row > 0 && a_row <= 100) && (b_column > 0 && b_column <= 100) && (Check(matrix_A) == true && Check(matrix_B) == true))
                {

                    float[,] matrix_C = Mult(matrix_A, matrix_B);
                    Console.WriteLine($"{a_row}  {b_column}");
                    Console.WriteLine("Print Matrix C:\n");
                    Print(matrix_C);
                }
            }
        }
        public static float[,] Mult(float[,] arr1, float[,] arr2)
        {
            float[,] arr3 = new float[arr1.GetLongLength(0), arr2.GetLongLength(1)];

            for (int i = 0; i < arr3.GetLongLength(0); i++)
            {
                for (int j = 0; j < arr3.GetLongLength(1); j++)
                {
                    arr3[i, j] = 0;
                    for (int k = 0; k < arr3.GetLongLength(1); k++)
                    {
                        arr3[i, j] += arr1[i, k] * arr2[k, j];
                    }
                }
            }
            return arr3;
        }

        public static void Print(float[,] arr)
        {
            for (int i = 0; i < arr.GetLongLength(0); i++)
            {
                for (int j = 0; j < arr.GetLongLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}   ");
                }
                Console.WriteLine();
            }
        }

        static bool Check(float[,] arr)
        {
            bool check = true;
            for (int i = 0; i < arr.GetLongLength(0); i++)
            {
                for (int j = 0; j < arr.GetLongLength(1); j++)
                {
                    if (Math.Abs(arr[i, j]) > 100)
                    {
                        check = false;
                        break;
                    }
                }
            }
            return check;
        }
    }
}
