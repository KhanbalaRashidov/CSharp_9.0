using System;
using System.Linq;
using System.Xml.Linq;

namespace SerializationComplicatedXml
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome Serialization Complicated Xml\n");

            #region XDocument.Parse


            string xml = System.IO.File.ReadAllText("_weather.xml");

            var col = XDocument.Parse(xml)
                               .Descendants("MMWEATHER")
                               .Descendants("REPORT")
                               .Descendants("TOWN")
                               .Descendants("FORECAST")
                               .ToList();

            foreach (var item in col)
            {
                Console.WriteLine($"\n\n{item}");
            }

            Console.ReadLine(); Console.Clear();

            foreach (var item in col)
            {
                Console.WriteLine("day: {0} month: {1} year: {2}",
                                    item.Attribute("day").Value,
                                    item.Attribute("month").Value,
                                    item.Attribute("year").Value);
            }

            Console.ReadLine(); Console.Clear();

            foreach (var item in col)
            {
                Console.WriteLine("min: {0} max: {1}",
                                    item.Element("TEMPERATURE").Attribute("min").Value,
                                    item.Element("TEMPERATURE").Attribute("max").Value);
            }

            Console.ReadLine(); Console.Clear();


            string city = XDocument.Parse(xml)
                                   .Element("MMWEATHER")
                                   .Element("REPORT")
                                   .Element("TOWN")
                                   .Attribute("sname").Value;

            Console.WriteLine(city);

            #endregion

            #region XDocument.Create

            XElement myMMWEATHER = new("MMWEATHER");
            XElement myTOWN = new("TOWN");
            XElement myFORECAST = new("FORECAST");
            XElement myTEMPERATURE = new("TEMPERATURE");

            XAttribute xAttributeMin = new("min", 7);
            XAttribute xAttributeMax = new("max", 10);

            myTEMPERATURE.Add(xAttributeMin, xAttributeMax);
            myFORECAST.Add(myTEMPERATURE);

            XAttribute xAttributeCityName = new("sname", "Baku");


            myTOWN.Add(myFORECAST, xAttributeCityName);
            myTOWN.Add(myFORECAST);
            myTOWN.Add(myFORECAST);
            myTOWN.Add(myFORECAST);

            myMMWEATHER.Add(myTOWN);

            myMMWEATHER.Save("_myWeather.xml");

            #endregion
        }
    }
}
