using System;
using System.IO;
using System.Text;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Xanish\Desktop\bio_whatsapp.txt";
            string text = File.ReadAllText(path);
            Console.WriteLine(text);
            Console.WriteLine();
            string[] textArr = File.ReadAllLines(path,Encoding.UTF8);
            foreach (var s in textArr)
            {
                Console.WriteLine(s);
            }
            textArr =new []{ "One","Two","Three"};
            Console.WriteLine();
            string path2 = @"C:\Users\Xanish\Desktop\test.txt";
            File.WriteAllLines(path2, textArr);
            text = File.ReadAllText(@"C:\Users\Xanish\Desktop\tests.txt");
            Console.WriteLine("Path2 file text");
            Console.WriteLine(text);
            text = "Hello Text";
            string path3 = @"C:\Users\Xanish\Desktop\test2.txt";
            File.WriteAllText(path3, text);
            Console.WriteLine("Path3 file text");
            Console.WriteLine(File.ReadAllText(@"C:\Users\Xanish\Desktop\test2.txt"));
           // File.Copy(@"C:\Users\Xanish\Desktop\bio_whatsapp.txt", @"C:\Users\Xanish\Desktop\test3.txt");
          
            Console.WriteLine(File.ReadAllText(path3));
           // Console.WriteLine(File.ReadAllText(@"C:\Users\Xanish\Desktop\test3.txt"));
            ///Console.WriteLine(File.Exists(@"C:\Users\Xanish\Desktop\test3.txt"));
            //File.Delete(@"C:\Users\Xanish\Desktop\test3.txt");
            Console.WriteLine(File.Exists(@"C:\Users\Xanish\Desktop\test3.txt"));
            //File.Move(path, @"C:\Users\Xanish\Desktop\test3.txt");
           
        }
    }
}
