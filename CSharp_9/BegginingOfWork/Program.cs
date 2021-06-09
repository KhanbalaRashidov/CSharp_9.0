using System;
namespace BegginingOfWork
{
    
    
    record Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        

    }
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

    class Program
    {

        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            Console.Write("Enter the Name: ");
            string name = Console.ReadLine();
            Console.Write($"Name: {name}\n");
            Person person1 = new Person { Name = "Test1", Id = 1 };
            Person person2 = person1; /*with { /*Id = 2*/ 
            Console.WriteLine($"{person2.Id},{person2.Name}");
        

           

            
            Console.ReadKey();
        }
    }
}
/*
 <- New structur->
 using System;


            Console.WriteLine("Hello World!");
            Console.Write("Enter the Name: ");
            string name = Console.ReadLine();
            Console.Write($"Name: {name}");
            Console.ReadKey();
 

 */