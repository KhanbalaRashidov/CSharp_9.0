using System;
using System.IO;

namespace Example_OOP
{
    struct Repository
    {
        private Worker[] workers;
        private string path;
        int index;
        string[] titles;
        public Repository(string Path)
        {
            this.path = Path;
            this.index = 0;
            this.titles = new string[5];
            this.workers = new Worker[2];
        }

        private void Resize(bool Flag)
        {
            if (Flag)
            {
                Array.Resize(ref this.workers, this.workers.Length * 2);
            }
        }

        public void Add(Worker NewWorker)
        {
            this.Resize(index >= workers.Length);
            this.workers[index] = NewWorker;
            this.index++;
        }

        public void Load()
        {
            using (StreamReader sr=new (this.path))
            {
                titles = sr.ReadLine().Split(',');

                while (!sr.EndOfStream)
                {
                    string[] args = sr.ReadLine().Split(',');
                    Add(new Worker(args[0], args[1], args[2],args[3],Convert.ToInt32(args[4])));
                }
                
            }
        }

        public void PrintDataConsole()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{titles[0],15} {titles[1],15} {titles[2],15} {titles[3],15} {titles[4],10}");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine($"{workers[i].Print()}");
            }
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public int Count { get { return index; } }
       
    }
}
