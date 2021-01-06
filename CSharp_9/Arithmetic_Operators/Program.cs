using System;

namespace Arithmetic_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //The operation of adding two numbers
            {
                int num1 = 3;
                int sum = num1 + 14; //17
                Console.WriteLine($"Number1={num1}  Sum={sum}");

                long a = 3;
                byte b = 14;
                long c = a + b;
                Console.WriteLine(c); //type long

                short a1 = 3;
                uint b1 = 14;
                uint c1 = (uint)(b1 + a1); // short < uint < int 
                Console.WriteLine(c1);
            }
            //The operation of subtracting two numbers
            {
                int num1 = 14;
                int subtraction = num1 - 3; //11
                Console.WriteLine($"Number1={num1}  subtraction={subtraction}");

                long a = 3;
                byte b = 14;
                long c = b - a;
                Console.WriteLine(c); //type long

                short a1 = 3;
                uint b1 = 14;
                uint c1 = (uint)(b1 - a1); // short < uint < int 
                Console.WriteLine(c1);
            }
            //The operation of multiplying two numbers
            {
                int num1 = 14;
                int multiplication = num1 * 3;
                Console.WriteLine($"Number1={num1}  multiplication={multiplication}");

                long a = 3;
                byte b = 14;
                long c = a * b;
                Console.WriteLine(c); //type long

                short a1 = 3;
                uint b1 = 14;
                uint c1 = (uint)(b1 * a1); // short < uint < int 
                Console.WriteLine(c1);
            }
            //division operation of two numbers
            {
                int num1 = 14;
                int ratio = num1 / 2; //7
                Console.WriteLine($"Number1={num1}  ratio={ratio}");

                double doubleNum1 = 10;
                double doubleRatio = doubleNum1 / 3; //3.33333333
                Console.WriteLine($"Double Number1={doubleNum1} double ratio={doubleRatio}");

                //When dividing, keep in mind that if both operands represent integers, then the result will also be rounded to an integer

                double doubleRatio2 = 10 / 4;  // out:2
                Console.WriteLine($"int ratio2={doubleRatio2}");

                /*
                  Despite the fact that the result of the operation is eventually
                  placed in a variable of type double, which allows you to preserve
                  the fractional part, the operation itself involves two literals, which by default
                  are treated as int objects, that is, integers, and the result will be an integer.
                */

                double doubleRatio3 = 10.4 / 4.0; //2.5
                Console.WriteLine($"double ration3={doubleRatio3}");

                long a = 3;
                byte b = 14;
                long c = b / a;
                Console.WriteLine(c); //type long

                short a1 = 3;
                uint b1 = 14;
                uint c1 = (uint)(b1 / a1); // short < uint < int 
                Console.WriteLine(c1);
            }
            //The operation of obtaining the remainder of an integer division of two numbers
            {
                int num1 = 14;
                int residual = num1 % 3; //2
                Console.WriteLine($"residual={residual}");

                long a = 3;
                byte b = 14;
                long c = b % a;
                Console.WriteLine($"14/3={b / a} residual={c}"); //type long

                short a1 = 3;
                uint b1 = 14;
                uint c1 = (uint)(b1 % a1); // short < uint < int 
                Console.WriteLine($"14/3={(uint)(b1 / a1)} residual={c1}");
            }
            //operator increment 
            {
                //prefix => ++x
                int num1 = 3;
                int num2 = ++num1;
                Console.WriteLine($"num1={num1} num2={num2}");

                //postfix => x++
                int num3 = 3;
                int num4 = num3++;
                Console.WriteLine($"num1={num3}  num3={num4}");

            }
            //operator decrement
            {
                //prefix => --x
                int num1 = 3;
                int num2 = --num1;
                Console.WriteLine($"num1={num1} num2={num2}");

                //postfix => x--
                int num3 = 3;
                int num4 = num3--;
                Console.WriteLine($"num1={num3}  num3={num4}");
            }
            //Consider a set of operations
            {
                //1
                {
                    int num1 = 3;
                    int num2 = 5;
                    int num3 = 40;
                    int result = num3-- - num2 * num1;    // num1=3  num2=5  num3=39  result=25
                    Console.WriteLine($"num1={num1}  num2={num2}  num3={num3}  result={result}");
                }
                //2
                {
                    int num1 = 3;
                    int num2 = 5;
                    int num3 = 40;
                    int result = (num3 - (--num2)) * num1;    // num1=3  num2=4  num3=40  result=108
                    Console.WriteLine($"num1={num1}  num2={num2}  num3={num3}  result={result}");
                }

            }
            {
                int a = 3;
                int b = 5;
                int c = 40;
                int d = c-- - b * a;    // a=3  b=5  c=39  d=25
                Console.WriteLine($"a={a}  b={b}  c={c}  d={d}");
            }
            {
                int a = 3;
                Console.WriteLine($"a={a++}");
                Console.WriteLine($"a={++a}");
                int b = a + a * a++ + ++a;
                Console.WriteLine($"a + a * a++ + ++a ={b}");

            }
        }
    }
}
