using System;
using System.IO;

namespace DriveInfos
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] driveInfos = DriveInfo.GetDrives();

            int length = driveInfos.Length;
            Console.WriteLine(length);
            Console.ReadKey();
            for (int i = 0; i <length; i++)
            {
                //gets the drive name
                Console.WriteLine($"Name={driveInfos[i].Name}");

                //is the disc ready (for example, the DVD may not be inserted in the drive)
                Console.WriteLine($"IsReady={driveInfos[i].IsReady}");

                //total disk size in bytes
                Console.WriteLine($"TotalSize={driveInfos[i].TotalSize}");

                //indicates the amount of free disk space available in bytes
                Console.WriteLine($"AvialableFreeSpace={driveInfos[i].AvailableFreeSpace}");


                //gets the total amount of free disk space in bytes
                Console.WriteLine($"TotalFreeSpace={driveInfos[i].TotalFreeSpace}");

                //represents the disc type
                Console.WriteLine($"DriveType={driveInfos[i].DriveType}");

                //gets the name of the filesystem
                Console.WriteLine($"DriveFormat={driveInfos[i].DriveFormat}");

                //Gets the root directory of a drive.
                Console.WriteLine($"RootDirectory={driveInfos[i].RootDirectory}");

                //Gets or sets the volume label of a drive.
                Console.WriteLine($"VolumeLabel={driveInfos[i].VolumeLabel}");
            }
            
            
        }
    }
}
