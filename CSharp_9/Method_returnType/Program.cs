using System;
using System.Reflection;
using System.IO;
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
                case 0: text+= $"Hello";break;
                case 1:text+= $"Hi"; break;
                case 2: text+=$"Good morning";break;
                case 3:text+= $"Good night";break;
                default:
                    text+= $"See you";
                    break;
            }
            return text;
        }
        static string GetPath()
        {
            return Assembly.GetEntryAssembly().Location;
            //return AppDomain.CurrentDomain.BaseDirectory;
        }
      

        static int Max(int value1,int value2)
        {
            return value1 > value2 ? value1 : value2;
        }
        
        static void Main(string[] args)
        {
            #region Example1
            Console.WriteLine("Method no parametr");
            string result = GetRandomString(); Console.WriteLine(result);
            result = GetRandomHi(); Console.WriteLine(result);
            result = GetPath(); Console.WriteLine(result);
            #endregion
            #region Example2
            
            Console.WriteLine(Max(14,16));

            
            #endregion
        }
    }
}
