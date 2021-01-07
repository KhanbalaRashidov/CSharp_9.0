using System;

namespace Ternary_Operator
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();

            #region ? operator
            double x = rand.NextDouble();
            Console.WriteLine($"x={x:F1}");

            int result = (x > 0.5) ? 1 : 0;
            Console.WriteLine($"result={result}");

            Console.WriteLine((x > 0.5) ? 1 : 0);
            if (x>0.5)
            {
                result = 1;
            }
            else
            {
                result = 0;
            }

            if (x>0.5)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }

            #endregion
            #region
            Console.ReadKey();
            int firstNumber = rand.Next(-20, 20);
            int secondNumber = rand.Next(-20, 20);
            int thridNumber = rand.Next(-20, 20);

            int maxValue;
            if ((firstNumber>secondNumber) &&(firstNumber>thridNumber) )
            {
                maxValue = firstNumber;
            }
            else
            {
                if (secondNumber>thridNumber)
                {
                    maxValue = secondNumber;
                }
                else
                {
                    maxValue = thridNumber;
                }
            }
            Console.WriteLine($"Max value={maxValue}");
            //if-else
            Console.ReadKey();

            int a = rand.Next(-30, 30);
            int b = rand.Next(-30, 30);
            int c = rand.Next(-30, 30);
            Console.WriteLine($"a={a}  b={b} c={c}");
            maxValue = ((a > b) && (a > c)) ? a : (b > c) ? b : c;
            Console.WriteLine($"Max value={maxValue}");
            maxValue = ((firstNumber > secondNumber) && (firstNumber > thridNumber))
                ? firstNumber : (secondNumber > thridNumber) ? secondNumber : thridNumber;
            Console.WriteLine($"max value{maxValue}");

            Console.ReadKey();
            #endregion
            bool flag = a > b;
            int outputInt = flag ? a : b;
            Console.WriteLine($"outputInt={outputInt}");

            string outputString = flag ? "Yes" : "No";
            Console.WriteLine($"outputString={outputString}");

            var resultInt = flag ? a : b;
            var resultString = flag ? "Yes" : "No";
            Console.WriteLine($"resultInt={resultInt}\nresultString={resultString}");

            Console.ReadKey();
        }
    }
}
