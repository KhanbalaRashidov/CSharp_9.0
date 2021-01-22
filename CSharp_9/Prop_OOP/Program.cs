using System;

namespace Prop_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Properties");

            Cat1 cat1 = new Cat1("Turkish Angora", "Mesi");
            Console.WriteLine($"Cat1 Breed: {cat1.Breed}  NickName: {cat1.NickName}\n");

            Cat2 cat2 = new Cat2("Toyger", "Xalli");
            Console.WriteLine($"private Breed: {cat2.GetBreed()} NickName:  {cat2.NickName}");

            Account1 account1 = new Account1("Khanbala", "pass123");
            Console.WriteLine($"Username: {account1.UserName} password: {account1.Password}");

            Account2 account2 = new Account2("Khanbala", "pass123");
            account2.SetPassword("Password321");

            Cat4 cat4 = new Cat4("Bosic","Toyger");
            Console.WriteLine($"NickName: {cat4.Nickname} Breed: {cat4.Breed}");

            cat4.Nickname = "Mesi";
            Console.WriteLine(cat4.Nickname);

            Console.WriteLine(cat4.EyeColor);

        }
    }
}
