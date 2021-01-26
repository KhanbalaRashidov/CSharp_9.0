using System;
using System.Collections.Generic;
namespace Queue_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Queue");

            //Represents a first-in, first-out collection of objects. First In First Out = FIFO.
            Queue<string> queue = new Queue<string>();

            #region Method 
            //Method Enqueue --> Adds an object to the end of the Queue<T>.
            Console.WriteLine("Method Equeue");
            queue.Enqueue("Person");
            queue.Enqueue("Student");
            queue.Enqueue("Teacher");
            queue.Enqueue("Computer");

            //Method Dequeue --> Removes and returns the object at the beginning of the Queue<T>.
            Console.WriteLine("Mehod Dequeue");
            string removeItem = queue.Dequeue();
            Console.WriteLine($"removeItem={removeItem}\n");

            Console.WriteLine("All item");
            foreach (var item in queue)
            {
                Console.Write($"{item}\t");
            }

            //Method Peek --> Returns the object at the beginning of the Queue<T> without removing it.
            Console.WriteLine("\nMethod Peek\n");

            string peekItem = queue.Peek();
            Console.WriteLine($"peekItem={peekItem}");
            Console.WriteLine("\nAll item");
            foreach (var item in queue)
            {
                Console.Write($"{item}\t");
            }

            //Method Clear --> Removes all objects from the Queue<T>.
            Console.WriteLine("Clear items");
            queue.Clear();
            Console.WriteLine("\nAll item");
                foreach (var item in queue)
            {
                Console.Write($"{item}\t");
            }
            #endregion

            #region Property
            //Prop Count --> Gets the number of elements contained in the Queue<T>.
            Console.WriteLine($"\ncount={queue.Count}");
            #endregion
        }
    }
}
