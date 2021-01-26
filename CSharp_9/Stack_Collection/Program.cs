using System;
using System.Collections.Generic;
namespace Stack_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom Stack");
            //Stack<T> --> Represents a variable size
            //last-in-first-out (LIFO) collection of instances of the same specified type.
            Stack<int> stack = new Stack<int>();

            //Method Push --> Inserts an object at the top of the Stack<T>.
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            Console.WriteLine("Numbers\n");
            foreach (var number in stack)
            {
                Console.Write($"{number}\t");
            }

            //Method Pop --> Removes and returns the object at the top of the Stack<T>.
            stack.Pop();
            Console.WriteLine("\nMethod Pop");
            Console.WriteLine("Numbers\n");
            foreach (var number in stack)
            {
                Console.Write($"{number}\t");
            }

            //Method Peek --> Returns the object at the top of the Stack<T> without removing it.
            int lastNumber = stack.Peek();
            Console.WriteLine("\nMethod Peek");
            Console.WriteLine($"lastNumber={lastNumber}");

            Console.WriteLine("Numbers\n");
            foreach (var number in stack)
            {
                Console.Write($"{number}\t");
            }

            //Method Clear --> Removes all objects from the Stack<T>.
            stack.Clear();
            Console.WriteLine("\nMethod Clear\n");
            Console.WriteLine("Numbers\n");
            foreach (var number in stack)
            {
                Console.Write($"{number}\t");
            }
        }
    }
}
