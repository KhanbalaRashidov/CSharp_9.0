using System;
using System.IO;
namespace FileInfo_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom FileInfo class...\n");
            FileInfo fileInfo = new FileInfo(@"C:\Test_File\Test.txt");

            //Atributes prop --> Gets or sets the attributes for the current file or directory. (Inherited from FileSystemInfo)
            Console.WriteLine($"fileInfo.Attributes={fileInfo.Attributes}");

            //CreationTime prop --> Gets or sets the creation time of the current file or directory.(Inherited from FileSystemInfo)
            Console.WriteLine($"fileInfo.CreationTime={fileInfo.CreationTime}");

            //Directory prop --> Gets an instance of the parent directory.
            Console.WriteLine($"fileInfo.Directory={fileInfo.Directory}");

            //DirectoryName prop --> Gets a string representing the directory's full path.
            Console.WriteLine($"fileInfo.DirectoryName={fileInfo.DirectoryName}");

            //Exists prop --> Gets a value indicating whether a file exists.
            Console.WriteLine($"fileInfo.Exists={fileInfo.Exists}");

            //Extension prop --> Gets the string representing the extension part of the file.(Inherited fotm FileSystemInfo)
            Console.WriteLine($"fileInfo.Extension={fileInfo.Extension}");

            //FullName prop --> Gets the full path of the directory or file.(Inherited from FileSystemInfo)
            Console.WriteLine($"fileInfo.FullName={fileInfo.FullName}");

            //IsReadOnly prop --> Gets or sets a value that determines if the current file is read only.
            Console.WriteLine($"fileInfo.IsReadOnly={fileInfo.IsReadOnly}");

            //LastAccessTime prop --> Gets or sets the time the current file or directory was last accessed.(Inherited from FileSystemInfo)
            Console.WriteLine($"fileInfo.LastAccessTime={fileInfo.LastAccessTime}");

            //LastWriteTime prop --> Gets or sets the time when the current file or directory was last written to.(Inherited from FileSystemInfo)
            Console.WriteLine($"fileInfo.LastWriteTime={fileInfo.LastWriteTime}");

            //Length prop --> Gets the size, in bytes, of the current file.
            Console.WriteLine($"fileInfo.Length={fileInfo.Length}");

            //Name prop --> Gets the name of the file.
            Console.WriteLine($"fileInfo.Name={fileInfo.Name}");
        }
    }
}
