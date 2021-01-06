using System;

namespace RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomize = new Random();

            int maxValue = int.MaxValue;
            int minValue = int.MinValue;
            Console.WriteLine(maxValue);
            Console.WriteLine(minValue);

            int randomResult = randomize.Next();
            Console.WriteLine(randomResult);

            //between max value=int.MaxValue
            randomResult = randomize.Next(100);
            Console.WriteLine(randomResult);

            randomResult = randomize.Next(10, 1000);
            Console.WriteLine(randomResult);
            //NextDouble 
            double doubleRandomResult = randomize.NextDouble(); //0.0 - 1.0
            Console.WriteLine(doubleRandomResult);
            doubleRandomResult = randomize.NextDouble() * 100;
            Console.WriteLine(doubleRandomResult);
            doubleRandomResult = randomize.NextDouble() + randomResult;
            Console.WriteLine(doubleRandomResult);
            //NextByte
            byte[] bytes = new byte [100];
            randomize.NextBytes(bytes);
            foreach (var item in bytes)
            {
                Console.WriteLine(item);
            }
           
            Console.ReadKey(); Console.Clear();
        }
    }
}
