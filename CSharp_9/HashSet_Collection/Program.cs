using System;
using System.Collections.Generic;
namespace HashSet_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome HashSet!");
            //HashSet<T> -->Represents a set of values.
            HashSet<int> hashset = new HashSet<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 ,9,10});
            foreach (var item in hashset)
            {
                Console.WriteLine($"{item}");
            }
            // Add - Adds the specified element to a set.
            hashset.Add(11);
            foreach (var item in hashset)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine();
            // Remove - Removes the specified element from a HashSet<T> object.
            hashset.Remove(11);
            foreach (var item in hashset)
            {
                Console.WriteLine($"{item}");
            }
            // Contains - Determines whether a HashSet<T> object contains the specified element.
            Console.WriteLine(hashset.Contains(1));
            // UnionWith - Modifies the current HashSet<T> object to contain all elements that are present in itself, the specified collection, or both.
            hashset.UnionWith(new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            foreach (var item in hashset)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine();

            // IntersectWith - Modifies the current HashSet<T> object to contain only elements that are present in that object and in the specified collection.
            Console.WriteLine("IntersecWith method");
            hashset.IntersectWith(new int[] { 1, 2, 3, 3, 4, 4, 5, 6 });
            foreach (var item in hashset)
            {
                Console.WriteLine($"{item}");
            }
            // ExceptWith -Removes all elements in the specified collection from the current HashSet<T> object.
            Console.WriteLine("ExceptWith method");
            hashset.ExceptWith(new int[] { 1, 2, 3, 4 });
            foreach (var item in hashset)
            {
                Console.WriteLine($"{item}");
            }
            // IsSubsutOf - Determines whether a HashSet<T> object is a subset of the specified collection.
            Console.WriteLine("IsSubsutOf method");
            Console.WriteLine(hashset.IsSubsetOf(new int[] { 5,6}));
            // IsSuperSetOf - Determines whether a HashSet<T> object is a superset of the specified collection.
            Console.WriteLine("IsSuperSetOf method");
            Console.WriteLine(hashset.IsSupersetOf(new int[] { 1,2,3,4,5}));
            // IsProperSubsetOf - Determines whether a HashSet<T> object is a proper subset of the specified collection.
            Console.WriteLine("IsProperySubsetOf method");
            Console.WriteLine(hashset.IsProperSubsetOf(new int[] { 1,2,3,4,5}));
            // IsProperSupersetOf - Determines whether a HashSet<T> object is a proper superset of the specified collection.
            Console.WriteLine("IsPropertySupersetOf");
            Console.WriteLine(hashset.IsProperSupersetOf(new int[] { 1,2,3,4}));

        }
    }
}
