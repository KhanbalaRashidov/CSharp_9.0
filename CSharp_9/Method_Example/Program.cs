using System;
using System.Threading;

namespace Method_Example
{
    class Program
    {
        static void Hi()
        {
            Console.WriteLine("Hello");
        }
        public static void Hi(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
        static void Pause()
        {
            Console.ReadKey();
        }
        public static void Pause(int interval)
        {
            Thread.Sleep(interval * 1000);
        }
        static void ApplauseAndOvations()
        {
            Random rand = new Random();
            for (int i = 0; i < rand.Next(30, 51); i++)
            {
                int posX = rand.Next(Console.WindowWidth - 5);
                int posY = rand.Next(Console.WindowHeight - 1);
                Console.SetCursorPosition(posX, posY + 1);
                Console.Write(rand.Next(2) == 0 ? "Yeahh" : "Yuuu");
            }
        }
        public static void ApplauseAndOvations(string text1,string text2,int count)
        {
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                int posX = rand.Next(Console.WindowWidth - 5);
                int posY = rand.Next(Console.WindowHeight - 1);
                Console.SetCursorPosition(posX, posY + 1);
                Console.Write(rand.Next(2) == 0 ?text1 : text2);
            }
        }
        static void Main(string[] args)
        {
            Hi();
            ApplauseAndOvations();
            Pause();

            Hi("Khanbala");
            ApplauseAndOvations("Yess", "Ouuu", 16);
            Pause(1);

        }
    }
}
