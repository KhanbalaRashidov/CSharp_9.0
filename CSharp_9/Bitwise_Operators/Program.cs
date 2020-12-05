using System;

namespace Bitwise_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //&- operator
            {
                int x1 = 2; //010
                int y1 = 5;//101
                Console.WriteLine(x1 & y1); // output 0

                int x2 = 4; //100
                int y2 = 5; //101
                Console.WriteLine(x2 & y2); // output 4
            }
            // | operator
            {
                int x1 = 2; //010
                int y1 = 5;//101
                Console.WriteLine(x1 | y1); // output 7 - 111
                int x2 = 4; //100
                int y2 = 5;//101
                Console.WriteLine(x2 | y2); // output 5 - 101
            }
            // ^ operator
            {
                int x = 45; // The value to be encrypted - in binary form 101101
                int key = 102; //Let this be the key - in binary form 1100110
                int encrypt = x ^ key; //The result will be the number 1001011 or 75
                Console.WriteLine("Encrypted number: " + encrypt);

                int decrypt = encrypt ^ key; // The result will be the original number 45
                Console.WriteLine("Decrypted number: " + decrypt);
            }
            // ~ operator
            {
                int x = 12;                 // 00001100
                Console.WriteLine(~x);      // 11110011   or -13
            }


            Console.ReadKey();
        }
    }
}
