using System;

namespace Okay
{
    class Program
    {
        static void Main(string[] args)
        {
            int eded, k = 0;
            Console.WriteLine("Massivin olcusun daxil edin:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                eded = array[i];
                bool f = true;
                while (eded != 0 && f)
                {
                    k = eded % 10;
                    if (k % 2 == 0) f = false;
                    eded /= 10;
                }
                if (f) Console.WriteLine(array[i]);

            }


            Console.ReadKey();
        }
    }
}
