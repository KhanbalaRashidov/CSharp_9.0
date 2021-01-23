using System;
using System.Threading;
namespace Indexer_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome  Indexer\n");

            #region Repository1
            Repository1 repository1 = new Repository1(

                new Worker("Name_1", "Position_1", 1000),
                new Worker("Name_2", "Position_2", 1500),
                new Worker("Name_3", "Position_3", 2000),
                new Worker("Name_4", "Position_4", 2500)
                );
            Console.WriteLine("Repository1 with indexer\n");
            Console.WriteLine(repository1.Workers[0].Print());
            Console.WriteLine(repository1.Workers[1].Print());
            Console.WriteLine(repository1.Workers[2].Print());
            Console.WriteLine(repository1.Workers[3].Print());
            #endregion
            #region Repository2
            Thread.Sleep(1000);  Console.Clear();
            Console.WriteLine("Repository2 with indexer\n");
            Repository2 repository2 = new Repository2(

                new Worker("Name_1", "Position_1", 1000),
                new Worker("Name_2", "Position_2", 1500),
                new Worker("Name_3", "Position_3", 2000),
                new Worker("Name_4", "Position_4", 2500)
                );
            Console.WriteLine(repository2[0].Print());
            Console.WriteLine(repository2[1].Print());
            Console.WriteLine(repository2[2].Print());
            Console.WriteLine(repository2[3].Print());
            #endregion
            #region Repository3 

            Thread.Sleep(1000); Console.Clear();
            Console.WriteLine("Repository3 with indexer\n");
            Repository3 repository3 = new Repository3(

                new Worker("Name_1", "Position_1", 1000),
                new Worker("Name_2", "Position_2", 1500),
                new Worker("Name_3", "Position_3", 2000),
                new Worker("Name_4", "Position_4", 2500)
                );
            Console.WriteLine(repository3[0]);
            Console.WriteLine(repository3[1]);
            Console.WriteLine(repository3[2]);
            Console.WriteLine(repository3[3]);
            #endregion
            #region Repository4
            Thread.Sleep(1000); Console.Clear();
            Console.WriteLine("Repository3 with indexer\n");
            Repository4 repository4 = new Repository4(

                new Worker("Name_1", "Position_1", 1000),
                new Worker("Name_2", "Position_2", 1500),
                new Worker("Name_3", "Position_3", 2000),
                new Worker("Name_4", "Position_4", 2500)
                );
            Console.WriteLine(repository4[0]);
            Console.WriteLine(repository4["+"]);
            Console.WriteLine(repository4[1]);
            Console.WriteLine(repository4["-"]);
            Console.WriteLine(repository4[2]);
            Console.WriteLine(repository4["*"]);
            Console.WriteLine(repository4[3]);
            Console.WriteLine(repository4["/"]);

            #endregion
            #region Matrix
            Console.ReadKey();
            Console.WriteLine("Matrix with indexer\t");

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Matrix matrix = new Matrix(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{matrix[i]}\t");
            }
            #endregion

        }
    }

    
}
