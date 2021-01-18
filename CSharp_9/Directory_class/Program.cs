using System;
using System.IO;
namespace Directory_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Diectory class...\n");
            string basePath = @"C:\Test_File\";
            string path = @"C:\Test_File\Test";

            //Method CreateDirectory --> Creates all the directories in a specified path.
            Directory.CreateDirectory(path);
            Console.WriteLine($"\nThe directory was created successfully at {Directory.CreateDirectory(path)}");

            //Method Delete --> Deletes a specified directory, and optionally any subdirectories.
            //Directory.Delete(path);
            Console.WriteLine("\nThe directory was deleted successfully");

            //Exists method --> Determines whether the given path refers to an existing directory on disk.
            bool currentDirectory = Directory.Exists(path);
            Console.WriteLine(currentDirectory? "\nDirectory exists" : "\nDirectory does not exist.");

            //Move method --> Moves a file or a directory and its contents to a new location.
            string newPath = @"C:\Test_File\Test1\";
            Directory.Move(path,newPath);
            Console.WriteLine($"\n{path} moved was to {newPath}.\n");

            //GetCreationTime method --> Gets the creation date and time of a directory.
            DateTime date = Directory.GetCreationTime(newPath);
            Console.WriteLine(date);

            //GetDirectories method --> Returns the names of subdirectories that meet specified criteria.
            string[] dirs = Directory.GetDirectories(basePath, "T*");
            foreach (var dir in dirs)
            {
                Console.WriteLine($"{dir}");
            }

            //GetFiles method --> Returns the names of files that meet specified criteria.
            string[] fiels = Directory.GetFiles(basePath);
            foreach (var file in fiels)
            {
                Console.WriteLine(file);
            }

            //GetParent method --> Retrieves the parent directory of the specified path, including both absolute and relative paths.
           var root = Directory.GetParent(basePath);
            Console.WriteLine($"\n{root}");

            //GetLastAccessTime method --> Returns the date and time the specified file or directory was last accessed.
            date = Directory.GetLastAccessTime(basePath);
            Console.WriteLine($"\ndate: {date}");

            //GetLastWriteTime method --> Returns the date and time the specified file or directory was last written to.
            date = Directory.GetLastWriteTime(basePath);
            Console.WriteLine($"\ndate: {date}");

        }
    }
}
