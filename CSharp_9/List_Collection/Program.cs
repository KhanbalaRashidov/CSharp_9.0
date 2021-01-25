using System;
using System.Collections.Generic;

namespace List_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We;come  List\n");

            //List<T> class -->Represents a strongly typed list of objects that can be accessed by index. Provides methods to search, sort, and manipulate lists.
            // T --> The type of elements in the list.
            //Inheritance  Object -> List<T>


            List<int> list = new List<int>();

            #region List Method
            //Method Add -> Adds an object to the end of the List<T>.
            list.Add(1);
            list.Add(2);
            foreach (var element in list)
            {
                Console.Write($"{element}\t");
            }
            Console.WriteLine();
            //Method AddRange --> Adds the elements of the specified collection to the end of the List<T>.
            Console.ReadKey();
            int[] arr1 = { 3, 4, 6, 5, 7, 8, 9, 9, 9, 9, 9 };
            list.AddRange(arr1);
            Console.WriteLine("New list\n");
            foreach (var element in list)
            {
                Console.Write($"{element}\t");
            }

            //Method Clear --> Removes all elements from the List<T>.
            Console.WriteLine();
            //  list.Clear();

            //Method IndexOf -->Returns the zero-based index of the first occurrence of a value in the List<T> or in a portion of it.
            int firstIndex = list.IndexOf(3);
            Console.WriteLine($"\nfirstIndex= {firstIndex}");

            int firstIndexBetween = list.IndexOf(3, 0, 4);
            Console.WriteLine($"firstIndexBetween= {firstIndexBetween}\n");

            //Method LastIndexOf --> Returns the zero-based index of the last occurrence of a value in the List<T> or in a portion of it.
            int lastIndex = list.LastIndexOf(3);
            Console.WriteLine($"lastIndex= {lastIndex}");
            int lastIndexBetween = list.LastIndexOf(3, 5, 3);
            Console.WriteLine($"lastIndexBetween= {lastIndexBetween}\n");

            //Method Insert --> Inserts an element into the List<T> at the specified index.
            list.Insert(0, 14);
            Console.WriteLine("\nInsert element 14\n");
            foreach (var element in list)
            {
                Console.Write($"{element}\t");
            }
            Console.WriteLine();

            //Method Remove --> Removes the first occurrence of a specific object from the List<T>.
            list.Remove(9);
            Console.WriteLine("\nRemove element 9\n");
            foreach (var element in list)
            {
                Console.Write($"{element}\t");
            }

            //Method RemoveAt --> Removes the element at the specified index of the List<T>.
            list.RemoveAt(3);
            Console.WriteLine("\nRemoveAtt index 3\n");
            foreach (var element in list)
            {
                Console.Write($"{element}\t");
            }

            //Method Sort --> Sorts the elements or a portion of the elements in the List<T> 
            //using either the specified or default IComparer<T>
            //implementation or a provided Comparison<T> delegate to compare list elements.

            list.Sort();
            Console.WriteLine("\nSort list\n");
            foreach (var element in list)
            {
                Console.Write($"{element}\t");
            }

            //Method Reverse --> Reverses the order of the elements in the List<T> or a portion of it.
            list.Reverse();
            Console.WriteLine("\nReverse list\n");
            foreach (var element in list)
            {
                Console.Write($"{element}\t");
            }
            Console.WriteLine();
            //Method Contains --> Determines whether an element is in the List<T>.
            bool flag = list.Contains(3);
            bool flag2 = list.Contains(20);
            Console.WriteLine($"\nflag={flag} flag2={flag2}\n");
            #endregion
            #region Properties
            //Prop Capacity --> Gets or sets the total number of elements the internal data structure can hold without resizing.
            int capacity = list.Capacity;
            Console.WriteLine($"capacity={capacity}\n");

            //prop Count --> Gets the number of elements contained in the List<T>.

            int count = list.Count;
            Console.WriteLine($"count={count}\n");

            //prop item[] --> Gets or sets the element at the specified index.
            Console.WriteLine($"list[3]={list[3]}\n");

            #endregion

        }
    }
}
