using System;

namespace Constructor_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Constructor.");

            Worker worker = new Worker
            {
                FirstName = "Khanbala",
                LastName = "Rashidov",
                Position = "Programmer",
                Salary = 1000,
                DateOfBrith = new DateTime(2000, 03, 03)
            };
            worker.Print();

            Worker worker5Parametr = new Worker("Khanbala", "Rashidov", "Programmer", 1000, new DateTime(2000, 03, 03));
            worker5Parametr.Print();

            Worker worker4Parametr = new Worker("Khanbala", "Rashidov", "Programmer", 1000);
            worker4Parametr.Print();

            Worker worker3Parametr = new Worker("Khanbala", "Rashidov", "Programmer");
            worker3Parametr.Print();

            Worker worker2Parametr = new Worker("Khanbala","Rasidov");
            worker2Parametr.Print();

            Worker worker1Parametr = new Worker("Khanbala");
            worker1Parametr.Print();


        }
    }
}
