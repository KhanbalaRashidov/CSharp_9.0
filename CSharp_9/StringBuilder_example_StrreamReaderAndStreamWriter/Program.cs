using System;
using System.IO;
using System.Text;
namespace StringBuilder_example_StringReaderAndStringWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(100);
            string s = "Lesson 5. Class StrinBuilder";
            sb.Append(s);
            Console.WriteLine(sb);
            using (StringWriter sw = new StringWriter(sb))
            {
                sw.Write("..!!");
            }
            Console.WriteLine(sb);

            using (StringReader sr = new StringReader(s))
            {
                char[] bufer = new char[5];
                sr.ReadBlock(bufer, 0, bufer.Length);
            }

           
        }
    }
}
