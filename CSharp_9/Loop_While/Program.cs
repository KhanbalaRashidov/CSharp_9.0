using System;

namespace Loop_While
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condition = false;
            while (condition)
            {

            }
            Console.WriteLine("Output value 0-10");
            int i = 0;
            while (i<=10)
            {
                Console.Write($"{i}  ");
                i++;
            }

            Console.WriteLine("\nOutput value -10-10");
            i = -10;
            while (i<=10)
            {
                Console.Write($"{i}   ");
                i++;
            }

            Console.WriteLine("\nOutput value 10-0");
            i = 0;
            while (i<=10)
            {
                Console.Write($"{10-i}  ");
                i++;
            }
            Console.WriteLine("\nOutput value 10-0");
            i = 10;
            while (i>=0)
            {
                Console.Write($"{i}  ");
                i--;
            }

            Console.WriteLine("\n3 step numbers between 1 and 50");
            int counter = 1;
            while (counter>=50)
            {
                Console.Write($"{counter}   ");
                counter += 3;
            }

            Console.WriteLine("\n0.125 step numbers between -1 and 1");
            double j = -1;
            while (j<=1)
            {
                Console.Write($"{j:F3}  ");
                j += 0.125;
            }

            Console.WriteLine("\n-0.25 step numbers between 1 and -1");
            j = 1;
            while (j>=-1)
            {
                Console.Write($"{j:F2}  ");
                j-= 0.25;
            }

            Console.WriteLine("\nEnter the number...");
            int startNum = Convert.ToInt32(Console.ReadLine());
            int endNum = startNum + 20;
            while (startNum<=endNum)
            {
                Console.WriteLine($"{startNum,5}^2={startNum * startNum }");
                startNum++;
            }

            Console.WriteLine("Enter the start:");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the end:");
            int end = Convert.ToInt32(Console.ReadLine());
            while (start<=end)
            {
                Console.WriteLine($"{start,4}^2={start * i}");
                start++;
            }

            Console.WriteLine("Numerical average");
            double value, average = 0;
            int k = 0;
            while (k<10)
            {
                Console.WriteLine("Enter the value");
                value = double.Parse(Console.ReadLine());
                average += value;
                k++;
            }
            Console.WriteLine($"The numerical middle of 10 numbers: {average / 10}");

            Console.WriteLine("Enter the numerator");
            double numerator = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the donominator");
            double donominator = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"---> {numerator}/{donominator}");

            double a = numerator, b = donominator;
            int count = 0;
            k = 0;
            while (k<=10000)
            {
                if (a != b)
                {
                    if (a > b) a -= b; else b -= a;
                    Console.WriteLine($"a={a}  b={b}");
                    count++;
                    k++;
                    break;
                }
            }
            Console.WriteLine($"count={count}");
            Console.WriteLine(a);
            Console.WriteLine($"{numerator / a} / {donominator / a} ");

            Console.WriteLine("Start game");
            Random rand = new Random();
            int randNumber = rand.Next(1, 80);
            int stepCount = 0;
            int userNumber;
            while (true)
            {
                Console.WriteLine("Enter number");
                stepCount++;
                userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber > randNumber)
                {
                    Console.WriteLine("The numbers you enter are large. Please re-enter");

                }
                else if (randNumber > userNumber)
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
