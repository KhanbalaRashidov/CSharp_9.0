using System;
using System.IO;
namespace DirecoryInfo_class
{
    class Program
    {
        static void GetDir(string path, string trim = "")
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            foreach (var item in directoryInfo.GetDirectories())
            {
                Console.WriteLine($"{trim}{item.Name}");
                GetDir(item.FullName, trim = "     ");
            }
            foreach (var item in directoryInfo.GetFiles())
            {
                Console.WriteLine($"{trim}{item.Name}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome DirecoryInfo class...\n");

            GetDir(@"C:\Users\Xanish\Desktop\Khanbala_Rashidov\CSharp_9.0\CSharp_9");
            Console.ReadKey(); Console.Clear();
            string path = @"C:\Test_File\Lesson1";
            DirectoryInfo directoryInfo = new DirectoryInfo(path);

            //Create() method --> Creates a directory.
            directoryInfo.Create();
            Console.WriteLine($"\n{path} directory created");

            //CreateSubdirectory method --> Creates a subdirectory or subdirectories on the specified path. The specified path can be relative to this instance of the DirectoryInfo class.
            string subPath = "test";
            directoryInfo.CreateSubdirectory(subPath);
            Console.WriteLine($"\n{path+"test"} created subdirectory");

            //Delete method --> Deletes a DirectoryInfo and its contents from a path.
           // directoryInfo.Delete(true);
            Console.WriteLine($"\n{subPath}  subdiercory deleted");

            //Exists prop --> Gets a value indicating whether the directory exists.
            bool currentDirectory = directoryInfo.Exists;
            Console.WriteLine($"directoryInfo.Exists={currentDirectory}");

            //Name prop --> Gets the name of this DirectoryInfo instance.
            string name = directoryInfo.Name;
            Console.WriteLine($"name={name}");

            //Parent prop -->Gets the parent directory of a specified subdirectory.
            string parent = directoryInfo.Parent.ToString();
            Console.WriteLine($"parent={parent}");

            //Root prop --> Gets the root portion of the directory.
            string root = directoryInfo.Root.ToString();
            Console.WriteLine($"root={root}");

            //directoryInfo.Attributes
            string attribute = directoryInfo.Attributes.ToString();
            Console.WriteLine($"attribute={attribute}");

            //directoryInfo.FullName
            string fullName = directoryInfo.FullName;
            Console.WriteLine($"fullName={fullName}");

            //GetDirectories() method --> Returns the subdirectories of the current directory.
            string getDirectories = directoryInfo.GetDirectories().ToString();
            Console.WriteLine($"GetDirectories()={getDirectories}");

            //GetFiles() method --> Returns a file list from the current directory.
            FileInfo[] getFiles = directoryInfo.GetFiles();
            foreach (var file in getFiles)
            {
                Console.WriteLine($"Name{file.Name} DirectoryName={file.DirectoryName}");
            }
            //MoveTo() method -->Moves a DirectoryInfo instance and its contents to a new path.
            string movePath = "Test33";
            directoryInfo.MoveTo(movePath);
            Console.WriteLine($"{path} moved was to {movePath}");
          

        }
    }
}
