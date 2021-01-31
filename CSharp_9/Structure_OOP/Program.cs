using System;

namespace Structure_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MonthlyReport
            MonthlyReport report = new ();
            report.Month = "Junuary";
            report.Income = 2_000;
            report.Consumption = 1_000;
            report.Arrived = report.Income - report.Consumption;

            Console.WriteLine("Month: {0} Income: {1}  Consumption: {2}  Arrived:{3}",
                report.Month,
                report.Income,
                report.Consumption,
                report.Arrived);

            MonthlyReport[] monthReport = new MonthlyReport[12];
            monthReport[0] = new ()
            {
                Month = "Junuary",
                Income = 1_500,
                Consumption = 900,
                Arrived = 1500 - 900
            };

            Console.WriteLine("Month: {0} Income: {1}  Consumption: {2}  Arrived:{3}",
                monthReport[0].Month,
                monthReport[0].Income,
                monthReport[0].Consumption,
                monthReport[0].Arrived);

            monthReport[1] = new ();
            monthReport[1].Month = "February";
            monthReport[1].Income = 2_500;
            monthReport[1].Consumption = 1950;
            monthReport[1].Arrived = monthReport[1].Income - monthReport[1].Consumption;

            Console.WriteLine("Month: {0} Income: {1}  Consumption: {2}  Arrived:{3}",
                monthReport[1].Month,
                monthReport[1].Income,
                monthReport[1].Consumption,
                monthReport[1].Arrived);
            #endregion

            #region Worker
            Console.ReadKey(); Console.Clear();
            Worker worker = new ()
            {
                Position = "Engineer",
                FirstName = "Khanbala",
                LastName = "Rashidov",
                Age = 20,
                Salary = 1_000
            };
            Console.WriteLine("Woker FullName : {0} {1} Age: {2} Position: {3} Salary: {4}",
                worker.FirstName,
                worker.LastName,
                worker.Age,
                worker.Position,
                worker.Salary);
            #endregion
        }
    }
}
