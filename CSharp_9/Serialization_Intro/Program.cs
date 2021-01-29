using System;
using System.IO;
namespace Serialization_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Serialization");
            string pathCSV = @"data.csv";
            string pathXML = @"data.xml";
            string pathJSON = @"data.json";

            #region csv

            Random random = new Random();
            using (StreamWriter sw=new StreamWriter(pathCSV))
            {
                sw.WriteLine($"{"FistName",20},{"LastName",20},{"Age",10}");
                for (int i = 0; i < 20; i++)
                {
                    sw.WriteLine($"{$"FirstName{i}",20},{$"LastName{i}",20},{random.Next(20, 30),10}");
                }
            }

            using (StreamReader sr=new StreamReader(pathCSV))
            {
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }

            /* Data csv format
            FistName,            LastName,       Age
          FirstName0,           LastName0,        25
          FirstName1,           LastName1,        21
          FirstName2,           LastName2,        25
          FirstName3,           LastName3,        25
          FirstName4,           LastName4,        22
          FirstName5,           LastName5,        23
          FirstName6,           LastName6,        24
          FirstName7,           LastName7,        22
          FirstName8,           LastName8,        28
          FirstName9,           LastName9,        23
         FirstName10,          LastName10,        27
         FirstName11,          LastName11,        29
         FirstName12,          LastName12,        27
         FirstName13,          LastName13,        24
         FirstName14,          LastName14,        29
         FirstName15,          LastName15,        20
         FirstName16,          LastName16,        26
         FirstName17,          LastName17,        27
         FirstName18,          LastName18,        28
         FirstName19,          LastName19,        21
             */


            #endregion
            #region xml
            using (StreamWriter sw =new StreamWriter(pathXML))
            {
                sw.WriteLine($"{"FistName",20},{"LastName",20},{"Age",10}");
                for (int i = 0; i < 20; i++)
                {
                    sw.WriteLine($"{$"FirstName{i}",20},{$"LastName{i}",20},{random.Next(20, 30),10}");
                }
            }
            #endregion
        }
    }
}
