using System;

namespace Method_Example
{
    class Program
    {
        static void Hi()
        {
            Console.WriteLine("Hello");
        }
        static void Pause()
        {
            Console.ReadKey();
        }
        static void ApplauseAndOvations()
        {
            Random rand = new Random();
            for (int i = 0; i < rand.Next(30,51); i++)
            {
                int posX = rand.Next(Console.WindowWidth - 5);
                int posY = rand.Next(Console.WindowHeight - 1);
                Console.SetCursorPosition(posX, posY+1);
                Console.Write(rand.Next(2)==0?"Yeahh":"Yuuu");
            }
        }
        static void Main(string[] args)
        {
            Hi();
            ApplauseAndOvations();
            Pause();

        }
    }
}
