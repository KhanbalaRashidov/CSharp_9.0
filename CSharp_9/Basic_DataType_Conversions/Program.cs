using System;

namespace Basic_DataType_Conversions
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                byte num1 = 3;
                Console.WriteLine(num1);
                int numShort = num1 + 1;
                Console.WriteLine(numShort);
            }
            {
                byte num1 = 4;
                Console.WriteLine(num1);
                // byte num2 = num1 + 5; //error
                byte num2 = (byte)(num1 + 10);
                Console.WriteLine(num2);

            }

            Console.ReadKey();
        }
    }
}
