using System;
using System.Net;
using System.Text;

namespace Network_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Network");

            WebClient webClient = new() { Encoding = Encoding.UTF8 };
            webClient.BaseAddress = @"https://dzone.com/storage/temp/";
           string  path = @"12334613-971.jpg";
            webClient.DownloadFile(path, "12334613-971.jpg");
            Console.WriteLine("Download image file");
        }
    }
}
