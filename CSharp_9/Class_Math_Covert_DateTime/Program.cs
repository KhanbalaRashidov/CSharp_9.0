using System;

namespace Class_Math_Covert_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Convert class
            //byte
            //sbyte
            //int
            //char
            //bool
            //double
            //long
            //float
            //decimal
            //DateTime
            //uint
            //short
            //ushort
            //ulong
            //string

            int i = Convert.ToByte("30");
            int j = byte.Parse("30");
            Console.WriteLine($"i={i}  j={j}");

            i = Convert.ToByte(16.9);
            Console.WriteLine($"i={i}");
            j = Convert.ToByte(9.16);
            Console.WriteLine($"j={j}");

            i = Convert.ToByte(16.9f);
            Console.WriteLine($"i={i}");
            j = Convert.ToByte(9.16f);
            Console.WriteLine($"j={j}");

            i = Convert.ToByte(16.9m);
            Console.WriteLine($"i={i}");
            j = Convert.ToByte(9.16m);
            Console.WriteLine($"j={j}");



            #endregion
        }
    }
}
