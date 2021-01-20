using System;
using System.Text;

namespace StringBuilder_method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome StringBuilder...");

            #region string example
            string str1 = "Helo";
            string str2 = str1.Insert(3, "l");
            Console.WriteLine($"str1={str1}  str2={str2}");
            Console.WriteLine($"The amount of allocated memory");
            Console.WriteLine($"str1={str1.Length*2} byte  str2={str2.Length*2} byte");
            #endregion

            #region StringBuilder
            Console.WriteLine("\nStringBuilder\n");
            //StringBuilder --> Represents a mutable string of characters. This class cannot be inherited.

            StringBuilder sb1 = new StringBuilder("Helo");

            //Length prop --> Gets or sets the length of the current StringBuilder object.
            Console.WriteLine($"sb1.Length={sb1.Length}");

            //Capacity prop --> Gets or sets the maximum number of characters that can be contained in the memory allocated by the current instance.
            Console.WriteLine($"sb1.Capacity={sb1.Capacity}");


            StringBuilder sb2 = new StringBuilder(101);
            Console.WriteLine($"sb2.Length={sb2.Length}");
            Console.WriteLine($"sb2.Capacity={sb2.Capacity}");
            /*
            Initializes a new instance of the StringBuilder class.

            public StringBuilder ();

            public StringBuilder (int capacity);

            public StringBuilder (string value);

            public StringBuilder (int capacity, int maxCapacity);

            public StringBuilder (string value, int capacity);

            public StringBuilder (string value, int startIndex, int length, int capacity);

             */
            //Append method --> Appends the string representation of a specified object to this instance.
            sb2.Append("One");
            Console.WriteLine($"sb2={sb2} sb2.Length={sb2.Length}  sb2.Capacity={sb2.Capacity}");

            //AppendFormat method --> Appends the string returned by processing a composite format string, which contains zero or more format items, to this instance.
            //Each format item is replaced by the string representation of a corresponding object argument.
            sb2.AppendFormat(" {0} {1}", "Two", "Three");
            Console.WriteLine($"sb2={sb2} sb2.Length={sb2.Length} sb2.Capacity={sb2.Capacity}");

            //AppendLine method --> Appends the default line terminator, or a copy of a specified string and the default line terminator, to the end of this instance.
            //Appends the default line terminator to the end of the current StringBuilder object.
            sb2.AppendLine();
            Console.WriteLine($"sb2={sb2} sb2.Length={sb2.Length} sb2.Capacity={sb2.Capacity}");

            //AppendLine(String) --> Appends a copy of the specified string followed by the default line terminator to the end of the current StringBuilder object.
            sb2.AppendLine(" Four");
            Console.WriteLine($"sb2={sb2} sb2.Length={sb2.Length} sb2.Capacity={sb2.Capacity}");

            //Remove(int startIndex, int length) method -->Removes the specified range of characters from this instance.
            sb2.Remove(10, 4);
            Console.WriteLine($"sb2={sb2} sb2.Length={sb2.Length} sb2.Capacity={sb2.Capacity}");

            /*Replace method --> Replaces all occurrences of a specified character or string in this instance with another specified character or string.
            
             Replaces all occurrences of a specified character in this instance with another specified character
             public StringBuilder Replace(char oldChar, char newChar)

            Replaces all occurrences of a specified string in this instance with another specified string.
            public StringBuilder Replace (string oldValue, string? newValue);

            Replaces, within a substring of this instance, all occurrences of a specified character with another specified character.
            public StringBuilder Replace (char oldChar, char newChar, int startIndex, int count);

            Replaces, within a substring of this instance, all occurrences of a specified string with another specified string.
            public StringBuilder Replace (string oldValue, string? newValue, int startIndex, int count);
             */

            sb2.Replace('T', 't');
            Console.WriteLine($"sb2={sb2}");

            sb2.Replace("Three", "three");
            Console.WriteLine($"sb2={sb2}");

            sb2.Replace('F', 'f', 10, 2);
            Console.WriteLine($"sb2={sb2}");

            sb2.Replace("Four", "four", 3, 3);
            Console.WriteLine($"sb2={sb2}");

            #endregion

            #region Recommendations for use

            // String StringBuilder
            // A small number of operations and changes to line elements
            // When a search is required, such as IndexOf, that is, StringBuilder has no such methods.

            //
            // If you do not know the number of operations that will be performed on lines during the program
            #endregion
        }
    }
}
