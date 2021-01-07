using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            #region if
            int x = rand.Next(10);
            Console.WriteLine($"x={x}");
            if (x<9)
            {
                Console.WriteLine("numbers are between 0 and 8");
            }
            if(x<9)
                Console.WriteLine("numbers are between 0 and 8");
            #endregion
            #region if-else
            int y = rand.Next(10);
            Console.WriteLine("y="+y);
            //form1
            if (y<7)
            {
                Console.WriteLine("Numbers are less than 7");
            }
            else
            {
                Console.WriteLine("numbers are greater than 7");
            }
            //form2
            if(y<7)
                Console.WriteLine("Numbers are less than 7");
            else
                Console.WriteLine("Numbers are greater than 7");
            #endregion
            #region if-else-if
            int z = rand.Next(10);
            Console.WriteLine("z="+z);
            //form1
            if (z<7)
            {
                Console.WriteLine("Numbers are less than 7");
            }
            else if (z>7)
            {
                Console.WriteLine("Numbers are greater than 7");
            }
            else
            {
                Console.WriteLine("The number is equal to 7");
            }
            //form2
            if (z<7)
            {
                Console.WriteLine("Numbers are less than 7");
            }
            else
            {
                if (z>7)
                {
                    Console.WriteLine("Numbers are greater than 7");
                }
                else
                {
                    Console.WriteLine("The number is equal to 7");
                }
            }
            //form3
            if (true)
            {

            }
            else
            {
                if (true)
                {

                }
                else
                {
                    if (true)
                    {

                    }
                    else
                    {

                    }
                }
            }

            #endregion

            #region example 1
            int temperature = rand.Next(30);
            Console.WriteLine($"Temperature {temperature}");
            if (temperature<17)
            {
                Console.WriteLine("You need to wear a jacket when the weather is cold");
            }
            else
            {
                Console.WriteLine("It is not necessary to wear a jacket when the weather is hot");
            }

            bool temp = temperature < 17;
            if (temp)
            {
                Console.WriteLine("You need to wear a jacket when the weather is cold");
            }
            else
            {
                Console.WriteLine("It is not necessary to wear a jacket when the weather is hot");
            }

            #endregion
            #region example 2
            int firstNumber = rand.Next(-20, 20);
            int seconNumber = rand.Next(-20, 20);

           // firstNumber = int.Parse(Console.ReadLine());
           // seconNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"first number={firstNumber}  last number={seconNumber}");
            //variant 1
            if (firstNumber>seconNumber)
            {
                Console.WriteLine($"Max value={firstNumber}");
            }
            else
            {
                Console.WriteLine($"Max value={seconNumber}");
            }

            if (firstNumber<seconNumber)
            {
                Console.WriteLine($"Min value={firstNumber}");
            }
            else
            {
                Console.WriteLine($"Min value={seconNumber}");
            }

            Console.WriteLine();

            //variant 2
            if (firstNumber>seconNumber)
            {
                Console.WriteLine($"Max value={firstNumber}");
                Console.WriteLine($"Min value={seconNumber}");
            }
            else
            {
                Console.WriteLine($"Max value={seconNumber}");
                Console.WriteLine($"Min value={firstNumber}");
            }
            Console.WriteLine();

            //variant 3
            bool flag = firstNumber > seconNumber;

            if (flag)
            {
                Console.WriteLine($"Max value={firstNumber}");
                Console.WriteLine($"Min value={seconNumber}");
            }
            else
            {
                Console.WriteLine($"Max value={seconNumber}");
                Console.WriteLine($"Min value={firstNumber}");
            }
            Console.WriteLine();

            //variant 4
            int maxValue, minValue;

            if (firstNumber>seconNumber)
            {
                maxValue = firstNumber;
                minValue = seconNumber;
            }
            else
            {
                maxValue = seconNumber;
                minValue = firstNumber;
            }
            

            Console.WriteLine($"Max value={maxValue}");
            Console.WriteLine($"Min value={minValue}");

            Console.WriteLine();

            if (firstNumber>seconNumber)
            {
                maxValue = firstNumber;
                minValue = seconNumber;
            }
            else if (firstNumber<seconNumber)
            {
                maxValue = seconNumber;
                minValue = firstNumber;
            }
            else
            {
                Console.WriteLine("Numbers equal");
            }
            Console.WriteLine($"Max value={maxValue}");
            Console.WriteLine($"Min value={minValue}");
            #endregion
            #region
            Console.WriteLine("Enter the day index");
            int dayIndex = int.Parse(Console.ReadLine());
            #region variant 1
            if (dayIndex==1)
            {
                Console.WriteLine("Monday");
            }
            else
            {
                if (dayIndex==2)
                {
                    Console.WriteLine("Tuesday");
                }
                else
                {
                    if (dayIndex==3)
                    {
                        Console.WriteLine("Wednesday");
                    }
                    else
                    {
                        if (dayIndex==4)
                        {
                            Console.WriteLine("Thursday");
                        }
                        else
                        {
                            if (dayIndex==5)
                            {
                                Console.WriteLine("Friday");
                            }
                            else
                            {
                                if (dayIndex==6)
                                {
                                    Console.WriteLine("Saturday");
                                }
                                else
                                {
                                    if (dayIndex==7)
                                    {
                                        Console.WriteLine("Sunday");
                                    }
                                    else
                                    {
                                        Console.WriteLine("There are seven days on planet earth in a week");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            #endregion
            #endregion
            #region variant 2
            if (dayIndex==1)
            {
                Console.WriteLine("Monday");
            }
            else if (dayIndex==2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (dayIndex==3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (dayIndex==4)
            {
                Console.WriteLine("Thursday");
            }
            else if (dayIndex==5)
            {
                Console.WriteLine("Friday");
            }
            else if (dayIndex==6)
            {
                Console.WriteLine("Saturday");
            }
            else if (dayIndex==7)
            {
                Console.WriteLine("Sunday");
            }
            else
            {
                Console.WriteLine("There are seven days on planet earth in a week");
            }
            #endregion
        }
    }
}
