using System;

namespace Prop_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Properties");

            Cat1 cat1 = new Cat1("Turkish Angora","Mesi");
            Console.WriteLine($"Cat1 Breed: {cat1.Breed}  NickName: {cat1.NickName}\n");

            Cat2 cat2 = new Cat2("Toyger", "Xalli");
            Console.WriteLine($"private Breed: {cat2.GetBreed()} NickName:  {cat2.NickName}");
        }
    }
}
