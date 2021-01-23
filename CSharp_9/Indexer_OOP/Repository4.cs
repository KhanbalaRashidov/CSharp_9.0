using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_OOP
{
    class Repository4
    {
        private Worker[] Workers;

        public string this[int index]
        {
            get { return Workers[index].Print(); }
         
        }
        public string this[string symbol]
        {
            get
            {
                switch (symbol)
                {
                    case "+":return "Plus";
                    case "-": return "Minus";
                    case "*":return "Multiply";
                    default :
                        return "Somthing else ";
                }
            }
        }
        public Repository4(params Worker[] Args)
        {
            Workers = Args;
        }
    }
}
