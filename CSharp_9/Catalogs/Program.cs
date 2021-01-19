using System;
using System.IO;
using System.Text;
namespace Catalogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Catalog");

            using (StreamWriter sw = new StreamWriter(@"C:\Test_File\db.csv",true,Encoding.Unicode))
            {
                char key = 'x';
                do
                {
                    string note = string.Empty;
                    Console.Write($"{"Enter the author's name:",20}");
                    note += $"{Console.ReadLine()}\t";

                    string now = DateTime.Now.ToString();
                    note += $"{now}\t";

                    Console.Write($"Enter a description for the note:");
                    note += $"{Console.ReadLine()}\t";
                    sw.WriteLine(note);

                    Console.WriteLine($"Continue n / a"); 
                    key=(Console.ReadKey(true).KeyChar);

                } while (key=='x');
            }

            Console.ReadLine();
            using (StreamReader sr=new StreamReader(@"C:\Test_File\db.csv",Encoding.Unicode))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{"Author",10} {"Date",15}       {"Note",8}");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string line;
                while ((line=sr.ReadLine())!=null)
                {
                    string[] data = line.Split('\t');
                    Console.WriteLine($"{data[0],10}  {data[1],15}  {data[2],8}");
                }
                Console.ForegroundColor = ConsoleColor.Green;
            }
        }
    }
}
