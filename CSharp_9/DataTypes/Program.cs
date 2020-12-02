using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool type
            bool alive = true;
            bool isDead = false;

            //byte type
            byte bit1 = 0; //min
            byte bit2 = 255; //max

            //sbyte type 
            sbyte sBit1 = -128; //min
            sbyte sBit2 = 127;  //max

            //short type 
            short short1 = -32768; //min
            short short2 = 32767;  // max

            //ushort type 
            ushort ushort1 = 0;  //min
            ushort ushort2 = 65535; //max

            //int type 
            int num1 = -2147483648; //min
            int num2 = 2147483647;  //max

            //uint type 
            uint uNum1 = 0;   //min
            uint uNum2 = 4294967295; //max

            //long type 
            long longNum1 = -9223372036854775808; //min
            long longNum2 = 9223372036854775807;  //max

            //ulong type
            ulong ulongNum1 = 0; //min
            ulong ulongNum2 = 18446744073709551615; //max

            //float type 
            float floatNum = Single.MinValue;  //min -3,4028235E+38
            float floatNum2 = Single.MaxValue; //max   3,4028235E+38

            //double type 
            double doubleNum1 = Double.MinValue; //min  -1,7976931348623157E+308
            double doubleNum2 = Double.MaxValue; //max   1,7976931348623157E+308

            //decimal type 
            decimal decimalNum1 = Decimal.MinValue; //min  
            Console.WriteLine(decimalNum1);
            decimal decimalNum2=Decimal.MaxValue; //max
            Console.WriteLine(decimalNum2);
          


        }
    }
}
