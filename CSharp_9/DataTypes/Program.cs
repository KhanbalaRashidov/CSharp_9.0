using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool type
            bool alive = true;
            Console.WriteLine(alive);
            bool isDead = false;
            Console.WriteLine(isDead);

            //byte type
            byte bit1 = 0; //min
            Console.WriteLine(bit1);
            byte bit2 = 255; //max
            Console.WriteLine(bit2);

            //sbyte type 
            sbyte sBit1 = -128; //min
            Console.WriteLine(sBit1);
            sbyte sBit2 = 127;  //max
            Console.WriteLine(sBit2);

            //short type 
            short short1 = -32768; //min
            Console.WriteLine(short1);
            short short2 = 32767;  // max
            Console.WriteLine(short2);

            //ushort type 
            ushort ushort1 = 0;  //min
            Console.WriteLine(ushort1);
            ushort ushort2 = 65535; //max
            Console.WriteLine(ushort2);

            //int type 
            int num1 = -2147483648; //min
            Console.WriteLine(num1);
            int num2 = 2147483647;  //max
            Console.WriteLine(num2);

            //uint type 
            uint uNum1 = 0;   //min
            Console.WriteLine(uNum1);
            uint uNum2 = 4294967295; //max
            Console.WriteLine(uNum2);

            //long type 
            long longNum1 = -9223372036854775808; //min
            Console.WriteLine(longNum1);
            long longNum2 = 9223372036854775807;  //max
            Console.WriteLine(longNum2);

            //ulong type
            ulong ulongNum1 = 0; //min
            Console.WriteLine(ulongNum1);
            ulong ulongNum2 = 18446744073709551615; //max
            Console.WriteLine(ulongNum2);

            //float type 
            float floatNum = Single.MinValue;  //min -3,4028235E+38
            Console.WriteLine(floatNum);
            float floatNum2 = Single.MaxValue; //max   3,4028235E+38
            Console.WriteLine(floatNum2);

            //double type 
            double doubleNum1 = Double.MinValue; //min  -1,7976931348623157E+308
            Console.WriteLine(doubleNum1);
            double doubleNum2 = Double.MaxValue; //max   1,7976931348623157E+308
            Console.WriteLine(doubleNum2);


            //decimal type 
            decimal decimalNum1 = Decimal.MinValue; //min  
            Console.WriteLine(decimalNum1);
            decimal decimalNum2 = Decimal.MaxValue; //max
            Console.WriteLine(decimalNum2);

            object c = 5;
            Console.WriteLine(c.GetType());
            var data = c;
            Console.WriteLine(data.GetType());

            char chMin = Char.MinValue;
            Console.WriteLine(chMin);
            char chMax = Char.MaxValue;
            Console.WriteLine(chMax);
            Console.Beep();



            string UpperCamelCase = "Pascal case";
            Console.WriteLine(UpperCamelCase);
            string lowerCamelCase = "Camel case";
            Console.WriteLine(lowerCamelCase);
            string snake_case = "Snake case";
            Console.WriteLine(snake_case);
            string FAT_SNAKE_CASE = "fAT sNAKE CASE";
            Console.WriteLine(FAT_SNAKE_CASE);
            // string kebab-world = "kebab case";
            string sHungariancase = "Hungarian case";
            Console.WriteLine(sHungariancase);




        }
    }
}
