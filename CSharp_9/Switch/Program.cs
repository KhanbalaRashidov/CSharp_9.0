using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayIndex = int.Parse(Console.ReadLine());
            #region if else-if
            if (dayIndex == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (dayIndex == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (dayIndex == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (dayIndex == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (dayIndex == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (dayIndex == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (dayIndex == 7)
            {
                Console.WriteLine("Sunday");
            }
            else
            {
                Console.WriteLine("There are seven days on planet earth in a week");
            }
            #endregion
            switch (dayIndex)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("There are seven days on planet earth in a week");
                    break;
            }
        }
    }
}
