using System;
using System.IO;
using System.Text;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"C:\Test_File\Test.txt";
            //Method ReadAllText --> Opens a text file, reads all the text in the file into a string, and then closes the file.
            string text = File.ReadAllText(path1);
            Console.WriteLine($"{text}\n");

            //Method ReadAllLines --> Opens a text file, reads all lines of the file into a string array, and then closes the file.
            string[] lines = File.ReadAllLines(path1);
            foreach (var line in lines) Console.WriteLine($"-->{line}<--");
            Console.WriteLine();
            //Method WriteAllLines --> Creates a new file, writes one or more strings to the file, and then closes the file.
            string newPath1 = @"C:\Test_File\Test2.txt";
            lines = new[] { "Zero","One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            File.WriteAllLines(newPath1, lines);
            text = File.ReadAllText(newPath1);
            Console.WriteLine($"\n{text}");

            //Method WriteAllText --> Creates a new file, write the contents to the file, and then closes the file. If the target file already exists, it is overwritten.
            string newPath2 = @"C:\Test_File\Test3.txt";
            text = "Welcome File class";
            File.WriteAllText(newPath2, text);
            text = File.ReadAllText(newPath2);
            Console.WriteLine($"\n{text}");

            //Method Create --> Creates or overwrites a file in the specified path.
            string newPath3= @"C:\Test_File\Test4.txt";
            File.Create(newPath3);
            Console.WriteLine("\nTest4.txt file created");

            //Method Copy --> Copies an existing file to a new file.
            string newPath4= @"C:\Test_File\Test5.txt";
            File.Copy(path1, newPath4);
            Console.WriteLine("\nThe Test1.txt file was copied to the Test5.txt file");

            //Method Exists --> Determines whether the specified file exists.
            bool currentFile = File.Exists(newPath4);
            Console.WriteLine(currentFile? "\nFile exists": "\nFile does not exist.");

            //Method Delete --> Deletes the specified file.
            File.Delete(newPath4);
            Console.WriteLine("\nTest5.txt file deleted.");

            currentFile = File.Exists(newPath4);
            Console.WriteLine(currentFile ? "\nFile exists" : "\nFile does not exist.");

            //Method Move --> Moves a specified file to a new location, providing the option to specify a new file name.
            string newPath5 = @"C:\Test_File\Test6.txt";
            if (File.Exists(newPath5)) File.Delete(newPath5);
            File.Move(newPath2, newPath5);
            Console.WriteLine($"\n{newPath3} was moved to {newPath5}");

            text = File.ReadAllText(newPath5);
            Console.WriteLine(text);
        }
    }
}
