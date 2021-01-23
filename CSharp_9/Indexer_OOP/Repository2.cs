using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_OOP
{
    class Repository2
    {
        private Worker[] Workers;

        public Worker this[int index]
        {
            get { return Workers[index]; }
            set { Workers[index] = value; }
        }

        public Repository2(params Worker[] Args)
        {
            Workers = Args;
        }
    }
}
