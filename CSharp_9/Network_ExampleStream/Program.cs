using System;
using System.Net;
using System.IO;
namespace Network_ExampleStream
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new WebClient();
            string url = @"https://algs4.cs.princeton.edu/14analysis/1Mints.txt";
            using (Stream sr = client.OpenRead(url))
            {
                using (StreamReader reader=new StreamReader(sr))
                {
                    string line = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(reader.ReadToEnd());
                    }
                }
            }

            Console.WriteLine("Txt file read!");
            Console.ReadKey();
        }
    }
}
