using System;

namespace Method_Overloading_Example
{
    class Program
    {
        static int Sum(int v1) => v1;
        static int Sum(int v1, int v2) => v1 + v2;
        static int Sum(int v1, int v2, int v3) => v1 + v2 + v3;
        static int Sum(int v1, int v2, int v3, int v4) => v1 + v2 + v3 + v4;
        static int Sum(int v1, int v2, int v3, int v4, int v5) => v1 + v2 + v3 + v4 + v5;
        static int Sum(int v1, int v2, int v3, int v4, int v5, int v6) => v1 + v2 + v3 + v4 + v5 + v6;

        static int Sum(int[] arr)
        {
            int result = 0;
            foreach (var item in arr)
            {
                result += item;
            }
            return result;
        }
        //return type float
        static float Sum(float v1) => v1;
        static float Sum(float v1, float v2) => v1 + v2;
        static float Sum(float v1, float v2, float v3) => v1 + v2 + v3;
        static float Sum(float v1, float v2, float v3, float v4) => v1 + v2 + v3 + v4;
        static float Sum(float v1, float v2, float v3, float v4, float v5) => v1 + v2 + v3 + v4 + v5;
        static float Sum(float v1, float v2, float v3, float v4, float v5, float v6) => v1 + v2 + v3 + v4 + v5 + v6;

        

        static float Sum(float[] arr)
        {
            float result = 0f;
            foreach (var item in arr)
            {
                result += item;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int res = Sum(1);
            Console.WriteLine($"res={res}");
            res = Sum(1, 2);
            Console.WriteLine($"res={res}");
            res = Sum(1, 2, 3);
            Console.WriteLine($"res={res}");
            res = Sum(1, 2, 3, 4);
            Console.WriteLine($"res={res}");
            res = Sum(1, 2, 3, 4, 5);
            Console.WriteLine($"res={res}");
            res = Sum(1, 2, 3, 4, 5, 6);
            Console.WriteLine($"res={res}");

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            res = Sum(arr);
            Console.WriteLine($"res={res}");
            Console.WriteLine("\n\n");
            float result = Sum(1f);
            Console.WriteLine($"result={result}");
            result = Sum(1f, 2f);
            Console.WriteLine($"result={result}");
            result = Sum(1f, 2f, 3f);
            Console.WriteLine($"result={result}");
            result = Sum(1f, 2f, 3f, 4f);
            Console.WriteLine($"result={result}");
            result = Sum(1f, 2f, 3f, 4f, 5f);
            Console.WriteLine($"result={result}");
            result = Sum(1f, 2f, 3f, 4f, 5f, 6f);
            Console.WriteLine($"result={result}");

            float[] arrFloat = { 1f, 2f, 3f, 4f, 5f, 6f, 7f, 8f, 9f };
            result = Sum(arrFloat);
            Console.WriteLine($"result={result}");


        }
    }
}
