using System;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;

namespace XML_Serialization
{
    class Program
    {
        static void WorkerSerialize(Worker CurrentWorker, string Path)
        {
            //Open or create stream
            FileStream fileStream = new(Path, FileMode.Append, FileAccess.Write);
            //create serializer type
            XmlSerializer xmlSerializer = new (typeof(Worker));
            //serializer data
            xmlSerializer.Serialize(fileStream, CurrentWorker);
            //close stream
            fileStream.Close();

        }
        static Worker WorkerDeserialize(string Path)
        {
            Worker deserializerWororker = new();

            FileStream fileStream = new(Path, FileMode.Open, FileAccess.Read);

            XmlSerializer xmlSerializer = new(typeof(Worker));

            deserializerWororker = (Worker)xmlSerializer.Deserialize(fileStream) ;
            fileStream.Close();

            return deserializerWororker;
        }

        static void WorkerListSerialize(List<Worker> CurrentWorkerList,string Path)
        {
            //Open or create stream
            FileStream fileStream = new(Path, FileMode.Append, FileAccess.Write);
            //create serializer type
            XmlSerializer xmlSerializer = new(typeof(List<Worker>));
            //serializer data
            xmlSerializer.Serialize(fileStream, CurrentWorkerList);
            //close stream
            fileStream.Close();
        }
        static List<Worker> WorkerListDeserialize(string Path)
        {
            List<Worker> deserializerWororkerList = new();

            FileStream fileStream = new(Path,FileMode.Open,FileAccess.Read);

            XmlSerializer xmlSerializer = new(typeof(List<Worker>));

            deserializerWororkerList =(List<Worker>)xmlSerializer.Deserialize(fileStream);
            fileStream.Close();

            return deserializerWororkerList;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome XML Serialization\n");

            #region Worker
            Worker worker = new("Khanbala", "Rashidov", "Developer", "IT", 2000);
            WorkerSerialize(worker, @"_khanbala.xml");

            Console.WriteLine(worker.Print());

            Console.WriteLine(WorkerDeserialize(@"_khanbala.xml").Print());
            #endregion
            #region List Worker
            List<Worker> list = new();
            for (int i = 1; i <= 5; i++)
            {
                list.Add(new($"FirstName{i}", $"LastName{i}", $"Positon{i}", $"Departament{i}", 1000 + i));
            }
            WorkerListSerialize(list, @"_listKhanbala.xml");

            List<Worker> workers = WorkerListDeserialize(@"_listKhanbala.xml");
            foreach (var item in workers)
            {
                Console.WriteLine(item.Print());
            }

            #endregion

        }
    }
}
