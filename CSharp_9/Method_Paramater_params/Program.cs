using System;

namespace Method_Paramater_params
{
    class Program
    {
        static int Sum(params int [] Args)
        {
            int result = 0;
            foreach (var item in Args)
            {
                result += item;
            }
            return result;
        }
        static int Sum(int factor,params int[] Args)
        {
            int result = 0;
            foreach (var item in Args)
            {
                result += item;
            }
            return result+factor;
        }

        static int Sum(int factor, string text, params int[] Args) => 0;
        static int Sum(float factor, string text, params int[] Args)=>1;
        static int Sum(double factor, string text, params int[] Args) => 2;
        static void Main(string[] args)
        {
            int res = Sum(1);
            Console.WriteLine($"Sum(1)   res={res}");
            res = Sum(1, 2);
            Console.WriteLine($"Sum(1,2)   res={res}");
            res = Sum(1, 2, 3);
            Console.WriteLine($"Sum(1,2,3)   res={res}");
            res = Sum(1, 2, 3, 4);
            Console.WriteLine($"Sum(1,2,3,4)   res={res}");
            res = Sum(1, 2, 3, 4, 5);
            Console.WriteLine($"Sum(1,2,3,4,5)   res={res}");
            res = Sum(1, 2, 3, 4, 5, 6);
            Console.WriteLine($"Sum(1,2,3,4,5,6)   res={res}");

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            res = Sum(arr);
            Console.WriteLine($"Sum(arr)   res={res}");
            res = Sum(100, arr);
            Console.WriteLine($"Sum(int factor,arr){res}");
            res = Sum(new int [] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 });
            Console.WriteLine($"Sum(new int [])   res={res}");

            res = Sum(new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 });
            Console.WriteLine($"Sum(new int[])   res={res}");

            res = Sum(100, 1, 2, 3, 4, 5, 6, 7, 8);
            Console.WriteLine($"Sum(int factor,params int [] Args)  res={res}");

            res = Sum(14, "invalid", 1, 2, 3, 4, 5);
            Console.WriteLine($"Sum(int factor, string text,params int [] Args res={res})");

            res = Sum(14f, "invalid", 1, 2, 3, 4, 5);
            Console.WriteLine($"Sum(float factor,string text, params int []) res={res}");

            res = Sum(16.9, "invalid", 1, 2, 3, 4, 5, 6);
            Console.WriteLine($"Sum(double factor,string text, params int []) res={res}");


        }
    }
}
