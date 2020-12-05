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
                Console.Write(name);
                Console.Write(age);
            }
            //ReadLine
            {
                Console.Write("Enter the your name: ");
                string name = Console.ReadLine();
                Console.WriteLine($"Hello {name}");
            }
            //Convert.
            {
                Console.Write("Enter name: ");
                string name5 = Console.ReadLine();

                Console.Write("Enter age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter height: ");
                double height = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter salary: ");
                decimal salary = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine($"Name: {name5}  Age: {age}  Height: {height} m  Salary: {salary}$");

            }
            Console.ReadKey();
        }
    }
}
