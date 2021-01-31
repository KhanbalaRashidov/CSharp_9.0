using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;


namespace JSON_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Json Serialization\n");

            Worker worker = new Worker("Khanbala", "Rashidov", "Developer", "IT", 2000);
            string json = JsonConvert.SerializeObject(worker);
            File.WriteAllText("_khanbala.json", json);

            var jsonDeserialize = File.ReadAllText("_khanbala.json");
            var deserializeWorker = JsonConvert.DeserializeObject<Worker>(jsonDeserialize);
            Console.WriteLine(deserializeWorker.Print());

            List<Worker> list = new List<Worker>();
            for (int i = 1; i <= 5; i++)
            {
                list.Add(new Worker($"FirstName{i}", $"LastName{i}", $"Position{i}", $"Position{i}", 1000 + i));
            }

            string jsonWorkerList = JsonConvert.SerializeObject(list);
            File.WriteAllText("_WorkerList.json",jsonWorkerList);

            var workerList = File.ReadAllText("_WorkerList.json");
            list = JsonConvert.DeserializeObject<List<Worker>>(workerList);
            Console.WriteLine();

            foreach (var item in list)
            {
                Console.Write($"{item.Print()}\n");
                Console.WriteLine($"\n{item.firstName,15} {item.lastName,15} {item.position,15} {item.departament,15} {item.salary,10}\n");
            }

            string name = "Khanbala";
            Console.WriteLine(name.Substring(0,4));
            
        }
    }
}
