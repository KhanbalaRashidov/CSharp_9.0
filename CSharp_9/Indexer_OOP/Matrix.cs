using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_OOP
{
    class Matrix
    {
        private int[] matrix;
        public int this[int i]
        {
            get { return matrix[i];}
            set { matrix[i] = value; }
        }

        public Matrix( int[] arr)
        {
            matrix = arr;
        }
    }
}
