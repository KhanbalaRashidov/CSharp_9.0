using System;
using System.IO;
namespace Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Streams...");

            var directories = new DirectoryInfo(@"C:\").GetDirectories();

            #region StreamWriter
            //Implements a TextWriter for writing characters to a stream in a particular encoding.
            StreamWriter streamWriter = new StreamWriter(@"C:\Test_File\cDirs.txt");

            //Method WriteLine() --> Writes out a formatted string and a new line to the stream, using the same semantics as Format(String, Object).

            foreach (var dir in directories)
            {
                
                streamWriter.WriteLine(dir.FullName);
                Console.WriteLine($">>{dir.FullName}");
            }
            //Method Write --> Writes data to the stream.
            Console.WriteLine("<---Write method--->");
            foreach (var dir in directories)
            {
                streamWriter.Write($"{dir.FullName}");
                Console.Write($"$\\:{dir.FullName}\n");
            }

            Console.ReadKey();

            //Method Flush --> Clears all buffers for the current writer and causes any buffered data to be written to the underlying stream.
            streamWriter.Flush();

            //Closes the current StreamWriter object and the underlying stream.
            streamWriter.Close();
            #endregion

            #region StreamReader

            //StreamReader --> Implements a TextReader that reads characters from a byte stream in a particular encoding.

            //Method Peek --> The following code example reads lines from a file until the end of the file is reached.
            using (StreamReader sr = new StreamReader(@"C:\Test_File\cDirs.txt"))
            {
                int peek = sr.Peek();
                Console.WriteLine($"peek={peek}");
            }

            //ReadLine method --> Reads a line of characters from the current stream and returns the data as a string.
            using (StreamReader sr = new StreamReader(@"C:\Test_File\cDirs.txt"))
            {
                while (sr.Peek()>-1)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
            Console.ReadKey();
            Console.WriteLine();
            //Read method --> Reads the next character or next set of characters from the input stream.
            using (StreamReader sr = new StreamReader(@"C:\Test_File\cDirs.txt"))
            {
                while (!sr.EndOfStream)
                {
                    Console.Write((char)sr.Read());
                }
            }
            #endregion
        }
    }
}
