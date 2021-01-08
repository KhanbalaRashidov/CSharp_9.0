using System;

namespace Loop_do
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condition = false;
            do
            {

            } while (condition);

            Console.WriteLine("Output value 0-10");
            int i = 0;
            do
            {
                Console.Write($"{i}  ");
                i++;
            } while (i<10);

            Console.WriteLine("\nOutput value -10-10");
            i = -10;
            do
            {
                Console.Write($"{i}  ");
                i++;
            } while (i<10);

            Console.WriteLine("\nOutput value 10-0");
            i = 0;
            do
            {
                Console.Write($"{10 - i}  ");
                i++;
            } while (i<10);

            Console.WriteLine("\nOutput value 10-0");
            i = 10;
            do
            {
                Console.Write($"{i} ");
                i--;
            } while (i>0);

            Console.WriteLine("\n3 step numbers between 1 and 50");
            int counter = 1;
            do
            {
                Console.Write($"{counter}  ");
                counter += 3;
            } while (counter<50);

            Console.WriteLine("\n0.125 step numbers between -1 and 1");
            double j = -1;
            do
            {
                Console.Write($"{j:F3}  ");
                j += 0.125;
            } while (j <= 1);

            Console.WriteLine("\n-0.25 step numbers between 1 and -1");
            j = 1;
            do
            {
                Console.Write($"{j:F2}  ");
                j -= 0.25;
            } while (j>=-1);

            Console.WriteLine("\nEnter the number...");
            int startNum = Convert.ToInt32(Console.ReadLine());
            int endNum = startNum + 20;
            do
            {
                Console.WriteLine($"{startNum,5}^2={startNum * startNum }");
                startNum++;
            } while (startNum>endNum);

            Console.WriteLine("Enter the start:");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the end:");
            int end = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine($"{start,4}^2={start * i}");
                start++;
            } while (start<end);

            Console.WriteLine("Numerical average");
            double value, average = 0;
            int k = 0;
            do
            {
                Console.WriteLine("Enter the value");
                value = double.Parse(Console.ReadLine());
                average += value;
                k++;
            } while (k<10);
            Console.WriteLine($"The numerical middle of 10 numbers: {average / 10}");

            Console.WriteLine("Enter the numerator");
            double numerator = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the donominator");
            double donominator = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"---> {numerator}/{donominator}");

            double a = numerator, b = donominator;
            int count = 0;
            k = 0;
            do
            {
                if (a != b)
                {
                    if (a > b) a -= b; else b -= a;
                    Console.WriteLine($"a={a}  b={b}");
                    count++;
                    k++;

                }
                else
                {
                    break;
                }

            } while (k<10000);

            Console.WriteLine($"count={count}");
            Console.WriteLine(a);
            Console.WriteLine($"{numerator / a} / {donominator / a} ");

            Console.WriteLine("Start game");
            Random rand = new Random();
            int randNumber = rand.Next(1, 80);
            int stepCount = 0;
            int userNumber;
            do
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

            } while (true);

            int r = 0;
            do
            {
                Console.Write($"{rand.Next(1,11)}");
            } while (r<10);
        }
    }
}
