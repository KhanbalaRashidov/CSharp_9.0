using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_OOP
{
    class Repository3
    {
        private Worker[] Workers;

        public string this[int index]
        {
            get { return Workers[index].Print(); }
            
        }
        public Repository3(params Worker[] Args)
        {
            Workers = Args;
        }
    }
}
