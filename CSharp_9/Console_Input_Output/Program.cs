using System;

namespace Console_Input_Output
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteLine part1
            {
                string name = "Khanbala";
                int age = 20;
                double height = 1.7;
                Console.WriteLine("Name: {0}  Age: {2}  Height: {1}м", name, height, age);

            }
            //WriteLine part2
            {
                string name = "Khanbala";
                int age = 20;
                double height = 1.7;
                Console.WriteLine("Name: {0}  Age: {2}  Height: {1}м", name, height, age);

            }
            //Write
            {
                string name = "Khanbala";
                int age = 20;
                Console.WriteLine(name);
                Console.WriteLine(age);
            }
            //ReadLine
            {
                Console.WriteLine("Enter the your name: ");
                string name = Console.ReadLine();
                Console.WriteLine($"Hello {name}");
            }
            //Convert.
            {
                Console.WriteLine("Enter name: ");
                string name5 = Console.ReadLine();

                Console.WriteLine("Enter age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter height: ");
                double height = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter salary: ");
                decimal salary = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine($"Name: {name5}  Age: {age}  Height: {height} m  Salary: {salary}$");

            }
            {
                string pattern = "First Name: {0}  Last Name: {1} Age: {2} Brith Year: {3} ";
                string firstName = "Khanbala";
                string lastName = "Rashidov";
                byte age = 20;
                short bYear = 2000;
                Console.WriteLine(pattern, firstName, lastName, age, bYear);
            }
            //Numbers after point
            {
                Console.ReadKey(); Console.Clear();
                double number = 123456.654321;
                Console.WriteLine(number);

                string numberFormated = number.ToString("#.###");
                Console.WriteLine(numberFormated);
                Console.WriteLine(number.ToString("#.###"));
                Console.WriteLine("{0:0.0000}",number);
                numberFormated = number.ToString("## ## ##.## ## ##");
                Console.WriteLine(numberFormated);
                numberFormated = number.ToString("### ### ###.## ## ## ## ##");
                Console.WriteLine(numberFormated);
                Console.WriteLine("{0:000 000 000.000 000 000}",number);

            }
            //Date
            {
                Console.WriteLine();
                var date = new DateTime(2021, 03, 03, 03, 03, 03);
                Console.WriteLine(date);

                Console.ReadKey();
                Console.WriteLine($"{date:HH:mm}");
                Console.WriteLine($"{date:yyyy-mm-dd}");
                Console.WriteLine($"{date:dd.MM.yyyy}");
                Console.WriteLine($"{date:yy.mm.dd}");
            }
            Console.ReadKey();
        }
    }
}
