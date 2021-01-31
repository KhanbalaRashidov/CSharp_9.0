using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SerializationComplicatedJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Parse
            string json = File.ReadAllText("telegram.json");
            Console.WriteLine(json);
            Console.ReadKey(); Console.Clear();
            Console.WriteLine(JObject.Parse(json)["ok"].ToString());

            var message = JObject.Parse(json)["result"].ToArray();

            foreach (var item in message)
            {
                Console.WriteLine(item["message"]["message_id"].ToString());
                Console.WriteLine(item["message"]["chat"].ToString());
                Console.WriteLine(item["message"]["text"]);
            }

            Console.ReadKey(); Console.Clear();
            #endregion

            #region Create
            JArray array = new();
            JObject mainTree = new();
            mainTree["ok"] = true;

            JObject jObj = new();
            jObj["update_id"] = 1234567;
            jObj["message_id"] = 169;

            array.Add(jObj);
            array.Add(jObj);
            array.Add(jObj);

            mainTree["messages"] = array;

            JObject userObj = new();
            userObj["id"] = 14;
            userObj["first_name"] = "R.X";
            userObj["user_name"] = "rx";

            mainTree["user"] = userObj;

            json = mainTree.ToString();
            Console.WriteLine(json);

            #endregion
            Console.ReadKey(); Console.Clear();
            List<Worker> list = new();

            JObject data = new();
            JArray jArray = new();

            for (int i = 1; i <= 20; i++)
            {
                JObject obj = new();
                obj["FirstName"] = $"FirstName_{i}";
                obj["LastName"] = $"LastName_{i}";
                obj["Position"] = $"Position_{i}";
                obj["Departament"] = $"Departament_{i}";
                obj["Salary"] = i * 1000;
                jArray.Add(obj);

            }
            Console.WriteLine(jArray.ToString());


            Console.ReadKey(); Console.Clear();

            data["data"] = jArray;

            Console.WriteLine("\ndata\n");
            Console.WriteLine(data.ToString());

            Console.ReadKey(); Console.Clear();
            using (StreamWriter stream = new("data.json"))
            {
                stream.WriteLine(data.ToString());
            }

            Console.WriteLine("StreamReader");
            using (StreamReader sr = new("data.json"))
            {
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }

            Console.ReadKey(); Console.Clear();
            Console.WriteLine("List<Worker>");
            
            list = jArray.ToObject<List<Worker>>();
            foreach (var item in list)
            {
                Console.WriteLine(item.Print());
            }

        }
    }
}
