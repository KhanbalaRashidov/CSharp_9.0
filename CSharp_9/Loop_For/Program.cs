using System;

namespace Loop_For
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                //Empaty operation
            }

            // 0 between 10
            Console.WriteLine("Output value 0-10");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i}");
            }

            Console.WriteLine("Output value -10-10");
            for (int i = -10; i <= 10; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("Output value 10-0");
            for (int j = 0; j <= 10; j++)
            {
                Console.Write($"{10 - j} ");
            }

            Console.WriteLine("Output vale 10-0");
            for (int i = 10; i <= 0; i--)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("3 step numbers between 1 and 50");
            for (int counter = 1; counter < 50; counter += 3)
            {
                Console.Write($"{counter}  ");
            }

            Console.WriteLine("0.125 step numbers between -1 and 1");
            for (double step = -1; step <= 1; step += 0.125)
            {
                Console.Write($"{step:F3}  ");
            }

            Console.WriteLine("-0.25 step numbers between 1 and -1");
            for (double step = 1; step >= -1; step -= 0.25)
            {
                Console.Write($"{step:F2}  ");
            }

            Console.WriteLine("\nEnter the number...");
            int startNum = Convert.ToInt32(Console.ReadLine());
            for (int i = startNum; i < startNum + 20; i++)
            {
                Console.WriteLine($"{i,5}^2={i * i}");
            }
            Console.WriteLine();
            for (int i = startNum; i < startNum + 20; i++)
            {
                Console.WriteLine($"{i,5}^3={i * i * i}");
            }

            Console.WriteLine("Enter the start:");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the end:");
            int end = Convert.ToInt32(Console.ReadLine());
            for (int i = start; i < end; i++)
            {
                Console.WriteLine($"{i,4}^2={i * i}");
            }

            Console.WriteLine("Numerical average");
            double value, average = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter the value");
                value = double.Parse(Console.ReadLine());
                average += value;
            }
            Console.WriteLine($"The numerical middle of 10 numbers: {average / 10}");

            Console.WriteLine("Enter the numerator");
            double numerator = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the donominator");
            double donominator = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"---> {numerator}/{donominator}");

            double a = numerator, b = donominator;
            int count = 0;
            for (int i = 0; i < 100000; i++)
            {
                if (a != b)
                {
                    if (a > b) a -= b; else b -= a;
                    Console.WriteLine($"a={a}  b={b}");
                    count++;
                    break;
                }
            }
            Console.WriteLine($"count={count}");
            Console.WriteLine(a);
            Console.WriteLine($"{numerator/a} / {donominator/a} ");

            Console.WriteLine("Start game");
            Random rand = new Random();
            int randNumber = rand.Next(1, 80);
            int stepCount = 0;
            int userNumber;
            for(; ; )
            {
                Console.WriteLine("Enter number");
                stepCount++;
                userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber > randNumber)
                {
                    Console.WriteLine("The numbers you enter are large. Please re-enter");
                    
                }
                else if (randNumber>userNumber)
                {
                    Console.WriteLine("The number you entered is small. Please re-enter");
                }
                else
                {
                    Console.WriteLine($"Congratulations. You found it in {stepCount} steps");
                    Console.ReadKey();
                    break;
                }
            }

           
        }
    }
}
