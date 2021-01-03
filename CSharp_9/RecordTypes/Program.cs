using System;
using System.Collections.Generic;

namespace RecordTypes
{
    class Program
    {
        private static DailyTemperature[] data = new DailyTemperature[]
        {
            new DailyTemperature(HighTemp: 57, LowTemp: 30),
            new DailyTemperature(60, 35),
            new DailyTemperature(63, 33),
            new DailyTemperature(68, 29),
            new DailyTemperature(72, 47),
            new DailyTemperature(75, 55),
            new DailyTemperature(77, 55),
            new DailyTemperature(72, 58),
            new DailyTemperature(70, 47),
            new DailyTemperature(77, 59),
            new DailyTemperature(85, 65),
            new DailyTemperature(87, 65),
            new DailyTemperature(85, 72),
            new DailyTemperature(83, 68),
            new DailyTemperature(77, 65),
            new DailyTemperature(72, 58),
            new DailyTemperature(77, 55),
            new DailyTemperature(76, 53),
            new DailyTemperature(80, 60),
            new DailyTemperature(85, 66)
        };
        static void Main(string[] args)
        {
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }

            var heatingDegreeDays = new HeatingDegreeDays(65, data);
            Console.WriteLine(heatingDegreeDays);
            var coolingDegreeDays = new CoolingDegreeDays(65, data);
            Console.WriteLine(coolingDegreeDays);

            //Person
            var person1 = new Person { Age = 20, Name = "Khanbala" };
            Console.WriteLine($"Name={person1.Name} - Age={person1.Age}"); //Name=Khanbala - Age=20
            var person2 = new Person { Age = 20, Name = "Khanbala" };
            Console.WriteLine($"Name={person2.Name} -Age={person2.Age}"); //Name=Khanbala - Age=20
            Console.WriteLine(person1==person2); //true
            //class Person1
            var person3 = new Person1 { Age = 20, Name = "Khanbala" }; 
            Console.WriteLine($"Name={person3.Name} - Age={person1.Age}"); //Name=Khanbala - Age=20
            var person4 = new Person1 { Age = 20, Name = "Khanbala" };
            Console.WriteLine($"Name={person4.Name} -Age={person2.Age}"); //Name=Khanbala - Age=20
            Console.WriteLine(person3 == person4); //false

            //
            // Growing degree days measure warming to determine plant growing rates
            var growingDegreeDays = coolingDegreeDays with { BaseTemperature = 65 };
            Console.WriteLine(growingDegreeDays);

            List<CoolingDegreeDays> movingAccumulation = new();
            int rangeSize = (data.Length > 5) ? 5 : data.Length;
            for (int start = 0; start < data.Length - rangeSize; start++)
            {
                var fiveDayTotal = growingDegreeDays with { TempRecords = data[start..(start + rangeSize)] };
                movingAccumulation.Add(fiveDayTotal);
            }
            Console.WriteLine();
            Console.WriteLine("Total degree days in the last five days");
            foreach (var item in movingAccumulation)
            {
                Console.WriteLine(item);
            }
            //with
            var growingDegreeDays1 = heatingDegreeDays with { };
            Console.WriteLine(growingDegreeDays);

            List<HeatingDegreeDays> movingAccumulation1 = new();
            int rangeSize1 = (data.Length > 5) ? 5 : data.Length;
            for (int start = 0; start < data.Length - rangeSize1; start++)
            {
                var fiveDayTotal = growingDegreeDays1 with { TempRecords = data[start..(start + rangeSize)] };
                movingAccumulation1.Add(fiveDayTotal);
            }
            Console.WriteLine();
            Console.WriteLine("Total degree days in the last five days");
            foreach (var item in movingAccumulation1)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
    public record Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class Person1
    {
        public string  Name { get; set; }
        public int Age { get; set; }
    }
    public record Person2(string Name, int Age);
}
