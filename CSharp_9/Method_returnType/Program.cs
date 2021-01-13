using System;
using static System.Net.Mime.MediaTypeNames;
namespace Method_returnType
{
    class Program
    {
        static string GetRandomString()
        {
            return Guid.NewGuid().ToString();
        }
        static string GetRandomHi()
        {
            Random random = new Random();
            string text = string.Empty;
            switch (random.Next(4))
            {
                case 0: text= $"Hello";break;
                case 1:text= $"Hi"; break;
                case 2: text=$"Good morning";break;
                case 3:text= $"Good night";break;
                default:
                    text= $"See you";
                    break;
            }
            return text;
        }
        static string GetPath()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }
        static void Main(string[] args)
        {
            GetRandomHi();
            GetRandomString();
            //GetPath();
        }
    }
}
