using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_OOP
{
    class Repository1
    {
        public Worker[] Workers { get; set; }

        public Repository1(params Worker[] Args)
        {
            Workers = Args;
        }
    }
}
