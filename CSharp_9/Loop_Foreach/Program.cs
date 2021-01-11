using System;

namespace Loop_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Enter the size of the array...");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(-9, 10);
            }

            Console.WriteLine("Array element");
            foreach (var item in numbers)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            #region
            Random random = new Random();
            int[][] jaggedDataTime = new int[24][];
            for (int j = 0; j < jaggedDataTime.Length; j++)
            {
                jaggedDataTime[j] = (j >= 9 && j < 21) ? new int[12] : new int[4];
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("jaggedDatatime[][]");
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < jaggedDataTime.Length; i++)
            {
                for (int j = 0; j < jaggedDataTime[i].Length; j++)
                {
                    jaggedDataTime[i][j] = random.Next(20);

                }
            }

            foreach (var array in jaggedDataTime)
            {
                foreach (var item in array)
                {
                    Console.Write($"{item}\t");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            #endregion
            Console.WriteLine();
            #region string for foreach
            string fullName = "I'm Khanbala Rashidov";
            for (int i = 0; i < fullName.Length; i++)
            {
                Console.Write($"{fullName[i]} ");
            }
            Console.WriteLine();
            foreach (var item in fullName)
            {
                Console.Write($"{item} ");
            }
            #endregion
            #region string
            string[] words = { "soz0", "soz1", "soz2", "soz3", "soz4", "soz5", "soz6", "soz7", "soz8", "soz9" };
            /*
             soz0 soz1 soz2 soz3
             soz1 soz4 soz5 soz6
             soz2 soz5 soz7 soz8
             soz3 soz6 soz8 soz9
             
             
             */
            Console.WriteLine("\nSozler");
            int k = 1;
            for (int i = 0; i <4; i++)
            {
                if (i<2)
                {

                    Console.Write($"{words[i]} {words[k++]} {words[k++]} {words[k++]}\t");
                    Console.WriteLine();
                }
                else if(i==2) 
                {
                    int m = k - 2;
                    Console.Write($"{words[i]} {words[m]} {words[k++]} {words[k++]}\t");
                    Console.WriteLine();
                }
                else
                {
                    int m = k - 3;
                    Console.Write($"{words[i]} {words[m]} {words[k-1]} {words[k]}");
                }
                
            }
            #endregion
        }
    }
}
