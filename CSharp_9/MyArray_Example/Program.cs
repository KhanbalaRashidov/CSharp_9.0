using System;

namespace MyArray_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray myArray = new MyArray(5);
            myArray.Add(1);
            Console.WriteLine(myArray.Print("Test1: "));

            myArray.Add(2);
            myArray.Add(3);
            Console.WriteLine(myArray.Print("Test2: "));
            myArray.Add(4);
            myArray.RemoveAt(0);
            Console.WriteLine(myArray.Print("Test4: "));

            Console.WriteLine($"Count ={myArray.Count}");
            Console.WriteLine($"index=0:{myArray[0]}");
        }
    }
}
