using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArray_Example
{
    class MyArray
    {
        private int[] data;
        private int index;
        public MyArray(int Size)
        {
            data = new int[Size];
            index = 0;
        }

        public void  Add(int Element)
        {
            if (index>=data.Length)
            {
                Array.Resize(ref data, data.Length * 2);
            }
            data[index++] = Element;
        }

        public void RemoveAt(int Position)
        {
            for (int i = Position; i <data.Length-1; i++)
            {
                data[i] = data[i + 1];
            }
            index--;
        }

        public string Print(string Text = "")
        {
            string result = String.Empty;
            for (int i = 0; i < index; i++)
            {
                result += $"{data[i]}\t";
            }

            return $"{Text} : {result}".Trim();
        }

        public int this[int i]
        {
            get { return this.data[i]; }
            set { data[i] = value; }
        }

        public int Count { get { return index; } }
    }
}
