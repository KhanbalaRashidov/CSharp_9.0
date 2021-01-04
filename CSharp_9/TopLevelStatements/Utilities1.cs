using System;
using System.Threading.Tasks;

namespace TopLevelStatements
{
    public static class  Utilities1
    {

        public static async Task ShowConsoleAnimation()
        {
            /*for (int i = 0; i < 20; i++)
            {
                Console.Write("| -");
                await Task.Delay(150);
                Console.Write("\b\b\b");
                Console.Write("/ \\");
                await Task.Delay(100);
                Console.Write("\b\b\b");
                Console.Write("- |");
                await Task.Delay(200);
                Console.Write("\b\b\b");
                Console.Write("\\ /");
                await Task.Delay(300);
                Console.Write("\b\b\b");
            }
            */
            foreach (string s in new[] { "| -", "/ \\", "- |", "\\ /", })
            {
                Console.Write(s);
                await Task.Delay(50);
                Console.Write("\b\b\b");
            }
            Console.WriteLine();
        }
        
    }
}
