using System;

namespace Assignment_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //= operator
            {
                int number = 16;
                Console.WriteLine($"number={number}");
                int number1, number2, number3;
                number1 = number2 = number3 = 9;
                Console.WriteLine($"number1={number1}  number2={number2}  number3={number3}");

                int number_1, number_2, number_3;
                number_1 = number_2 = number_3 = 3 * 16 * 9;
                Console.WriteLine($"number_1={number_1}  number_2={number_2}  number_3={number_3}");
            }
            // += operator
            {
                int number = 10;
                int number2 = 9;
                Console.WriteLine($"number={number} number+number2={number+number2}");
                number += 10; //==> number=number+10
                Console.WriteLine($"number={number}");

                int num1 = 2_000_000_000;
                int num2 = 2_000_000_000;
                int sum1 = num1 + num2; //overflow
                Console.WriteLine($"sum1={sum1}");
            }
            // -= operator
            {
                int number = 10;
                int number2 = 9;
                Console.WriteLine($"number={number} number-number2={number-number2}");
                number -= 5; //==> number=number-5
                Console.WriteLine($"number={number}");
                int num1 = 2_000_000_000;
                int num2 = -2_000_000_000;
                int sum1 = num2 - num1;
                Console.WriteLine($"-sum1={sum1}");
            }
            // *= operator
            {
                int number = 10;
                int number2 = 9;
                Console.WriteLine($"number={number} number * number2 ={number*number2}");
                number *= 3; //==> number=number*3
                Console.WriteLine($"number={number}");
            }
            // /= operator
            {
                int number = 10;
                int number2 = 9;
                Console.WriteLine($"number={number} number/number2={number/number2}");
                number /= 5; //==> number=number/5
                Console.WriteLine($"number={number}");
            }
            // %= operator
            {
                int number = 10;
                int number2 = 9;
                Console.WriteLine($"number={number} number%number2={number%number2}");
                number %= 3; //==>number=number%3
                Console.WriteLine($"number={number}");
            }
            // &= operator
            {
                int number = 10;
                int number2 = 9;
                Console.WriteLine($"number={number} number&number2={number&number2}");
                number &= 5; //==>number=number&5
                Console.WriteLine($"number={number}");
            }
            // |= operator
            {
                int number = 10;
                int number2=9;
                Console.WriteLine($"number={number} number|number2={number|number2}");
                number |= 5; //==> number=number|5
                Console.WriteLine($"number={number}");
            }
            // ^= operator
            {
                int number = 10;
                int number2 = 9;
                Console.WriteLine($"number={number} number^number2={number^number2}");
                number ^= 2; //==>number=number^2
                Console.WriteLine($"number={number}");
            }

            Console.ReadKey();
        }
    }
}
