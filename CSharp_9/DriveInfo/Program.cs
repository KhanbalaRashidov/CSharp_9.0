using System;
using System.IO;

namespace DriveInfos
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] driveInfos = DriveInfo.GetDrives();
            foreach (var item in driveInfos)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.DriveType);
                if (item.IsReady)
                {
                    Console.WriteLine(item.TotalSize);
                    Console.WriteLine(item.TotalFreeSpace);
                    Console.WriteLine(item.RootDirectory);
                }
            }
        }
    }
}
