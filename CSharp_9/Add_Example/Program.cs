using System;
using System.IO;
using System.IO.Compression;
using System.Text;
namespace Add_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"C:\Test_File\Test2.txt", Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var ch = sr.Read();
                    Console.WriteLine($"{ch} - {(char)ch}");
                }
            }
            Console.WriteLine();
            using (StreamReader sr = new StreamReader(@"C:\Test_File\Test2.txt", Encoding.Default))
            {
                Console.WriteLine(sr.ReadToEnd());
            }

            #region BinaryStream
            Console.WriteLine("Press Enter to continue \n");

            string[] names = { "Khanbala", "Orxan", "Qismet", "Ferhad", "Elvan", "Yalchin", "Sadiq" };
            string path = @"C:\Test_File\binaryName.dat";
            using (BinaryWriter bWriter = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                foreach (var name in names)
                {
                    bWriter.Write(name);
                }
                Console.WriteLine($"File {path} created successfully. Press Enter to continue");
                Console.ReadLine();
            }

            using (BinaryReader bReader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                while (bReader.PeekChar() > -1)
                {
                    string name = bReader.ReadString();
                    Console.WriteLine(name);
                }
            }

            #endregion

            #region FileStream
            Console.ReadKey(); Console.Clear();
            Console.Write("Enter the text:");

            string text = Console.ReadLine();
            using (FileStream fileStream = new FileStream(@"note.txt", FileMode.Create))
            {
                byte[] array = Encoding.Default.GetBytes(text);
                fileStream.Write(array, 0, array.Length);
            }
            Console.WriteLine();

            using (FileStream fileRead = File.OpenRead(@"note.txt"))
            {
                byte[] array = new byte[fileRead.Length];
                fileRead.Read(array, 0, array.Length);
                text = Encoding.Default.GetString(array);
                Console.WriteLine($"text={text}");
            }
            #endregion

            #region GZipStream

            Console.ReadKey(); Console.Clear();

            string source = "csharp-via.txt";
            string compressed = "csharp-via.zip";

            using (FileStream fileStream=new FileStream(source,FileMode.OpenOrCreate))
            {
                using (FileStream newFileStream=File.Create(compressed))
                {
                    using (GZipStream zipStream=new GZipStream(newFileStream,CompressionMode.Compress))
                    {
                        fileStream.CopyTo(zipStream);
                        Console.WriteLine($"The compression of the file {source} is complete. Was: {fileStream.Length} Now: {newFileStream.Length}");
                    }
                }
            }
            Console.WriteLine($"Press enter to continue...");
            Console.ReadKey();

            using (FileStream fileStream =new FileStream(compressed,FileMode.OpenOrCreate))
            {
                using (FileStream newFile = File.Create($"_{source}.txt"))
                {
                    using (GZipStream gZipStream=new GZipStream(fileStream,CompressionMode.Decompress))
                    {
                        gZipStream.CopyTo(newFile);
                        Console.WriteLine($"{source} restored.");

                        Console.WriteLine($"Restoration of file {source} completed. Was: {fileStream.Length} Now: {newFile.Length}");
                    }
                }
            }
         


            #endregion
        }
    }
}
