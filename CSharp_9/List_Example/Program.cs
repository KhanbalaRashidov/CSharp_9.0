using System;
using System.Collections.Generic;
namespace List_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<Worker> workers = new List<Worker>();

            //Add worker

            for (int i = 1; i <= 10; i++)
            {
                workers.Add(new Worker(
                    $"FirstName_{i}",
                    $"LastName_{i}",
                    $"Position_{i}",
                    $"Departament_{i}",
                    random.Next(1000, 2000)
                    ));
            }

            //Print Worker list

            foreach (var worker in workers)
            {
                Console.WriteLine(worker.Print());
            }
        }
    }
}
