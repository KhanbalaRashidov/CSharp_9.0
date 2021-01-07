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
            #region switch operator
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
            #endregion
            #region example 2
            Console.WriteLine("Enter the level");
            int level = Convert.ToInt32(Console.ReadLine());
            if (level==1)
            {
                Console.WriteLine("NPC generation");
                Console.WriteLine("NPC generation");
            }
            else if (level == 2)
            {
                Console.WriteLine("NPC generation");
                Console.WriteLine("NPC generation");
                Console.WriteLine("NPC generation");
                Console.WriteLine("NPC generation");
            }
            else if (level==3)
            {
                Console.WriteLine("NPC generation");
                Console.WriteLine("NPC generation");
                Console.WriteLine("NPC generation");
                Console.WriteLine("NPC generation");
                Console.WriteLine("NPC generation");
            }
            else
            {
                Console.WriteLine("You did not enter the level correctly");
            }

            switch (level)
            {
                case 1:
                    Console.WriteLine("NPC generation");
                    Console.WriteLine("NPC generation");
                    break;
                case 2:
                    Console.WriteLine("NPC generation");
                    Console.WriteLine("NPC generation");
                    Console.WriteLine("NPC generation");
                    Console.WriteLine("NPC generation");
                    break;
                case 3:
                    Console.WriteLine("NPC generation");
                    Console.WriteLine("NPC generation");
                    Console.WriteLine("NPC generation");
                    Console.WriteLine("NPC generation");
                    Console.WriteLine("NPC generation");
                    break;
                default:
                    Console.WriteLine("You did not enter the level correctly");
                    break;
            }
            #endregion
            #region example 3
            Random rand = new Random();

            int value = rand.Next(16);

            if (value>=0 && value<7)
            {
                Console.WriteLine("0 <= value <7");
            }
            else if (value>=7 && value<16)
            {
                Console.WriteLine("7 <= value <16");
            }

            switch (value)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:Console.WriteLine("0 <= value <7 "); break;
                default:
                    Console.WriteLine(" 7 <= value <16");
                    break;
            }

            #endregion
        }
    }
}
