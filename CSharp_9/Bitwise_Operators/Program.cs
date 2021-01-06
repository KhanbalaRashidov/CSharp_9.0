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
            //neqativ number
            {
                int x = 12;
                int y = ~x;
                y += 1;
                Console.WriteLine(y);   // -12
            }
            //Shift Operator
            {
                //shift left 
                {
                    int x = 14 << 1;
                    Console.WriteLine(x);
                }
                //shift right
                {
                    int x = 16 >> 1;
                    Console.WriteLine(x);
                }
            }
            {

                #region inversiya
                Console.WriteLine("<--Inversiya-->");
                bool variable1 = true;
                bool variable2 = false;

                Console.WriteLine($"variable1={variable1}  !variable1={!variable1}");
                Console.WriteLine($"variable2={variable2}  !variable2={!variable2}");

                #endregion
                #region konyuktsiya &&
                variable1 = true;
                variable2 = false;
                bool result = variable1 && variable2;
                Console.WriteLine(result);
                Console.WriteLine($" {true} && {true}  ={true && true}");
                Console.WriteLine($" {true} && {false} ={true && false}");
                Console.WriteLine($"{false} && {true}  ={false && true}");
                Console.WriteLine($"{false} && {false} ={false && false}");
                Console.ReadKey();
                #endregion
                #region disunktsiya ||
                variable1 = true;
                variable2 = false;
                result = variable1 || variable2;
                Console.WriteLine(result);
                Console.WriteLine($" {true} || {true}  ={true || true}");
                Console.WriteLine($" {true} || {false} ={true || false}");
                Console.WriteLine($"{false} || {true}  ={false || true}");
                Console.WriteLine($"{false} || {false} ={false || false}");
                Console.ReadKey();
                #endregion
                #region XOR ^
                variable1 = true;
                variable2 = false;
                result = variable1 ^ variable2;
                Console.WriteLine(result);
                Console.WriteLine($" {true} ^ {true}  ={true ^ true}");
                Console.WriteLine($" {true} ^ {false} ={true ^ false}");
                Console.WriteLine($"{false} ^ {true}  ={false ^ true}");
                Console.WriteLine($"{false} ^ {false} ={false ^ false}");
                Console.ReadKey();
                #endregion
                #region more operation
                bool flag1 = 3 > 2; Console.WriteLine(flag1);
                bool flag2 = 3 < 2; Console.WriteLine(flag2);
                bool flag3 = 'X' == 'X'; Console.WriteLine(flag3);
                bool flag4 = 3 == 3; Console.WriteLine(flag4);
                bool flag5 = 3 >= 2; Console.WriteLine(flag5);
                bool flag6 = 3 <= 3; Console.WriteLine(flag6);
                bool flag7 = 3 != 2; Console.WriteLine(flag7);

                string c = "C#";
                bool flag8 = 3 != 2 && c == "C#"; Console.WriteLine(flag8);
                #endregion
                #region Math logical operation
                int x1 = 30, x2 = 150; //coordinat rectangle point
                int y1 = 20, y2 = 90;

                int pA = 100, pB = 70; //point coordinat
                bool check = ((pA >= x1) && (pA <= x2) && (pB >= y1) && (pB<=y2));
                Console.WriteLine(check);
                #region
                Console.ReadKey();
                pA = 50;
                pB = 110;
                check = ((pA >= x1) && (pA <= x2) && (pB >= y1) && (pB <= y2));
                Console.WriteLine(check);
                #endregion
                #endregion
            }

            Console.ReadKey();
        }
    }
}
