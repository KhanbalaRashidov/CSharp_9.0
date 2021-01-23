using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_OOP
{
    class Worker
    {
        public string Name { get; set; }
        public string  Position { get; set; }

        public uint Salary { get; set; }

        public string Print()
        {
            return $"{Name} {Position} {Salary}";
        }
        public Worker(string Name,string Position,uint Salary)
        {
            this.Name = Name;
            this.Position = Position;
            this.Salary = Salary;
        }
    }
}
