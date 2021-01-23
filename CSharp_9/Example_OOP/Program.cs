using System;
using System.IO;
namespace Example_OOP
{
    class Program
    {
        static  void Main(string[] args)
        {
            string path = @"data.csv";

            Repository repository = new Repository(path);
            repository.Load();
            repository.PrintDataConsole();
            Console.WriteLine(repository.Count);
        }
    }
}
