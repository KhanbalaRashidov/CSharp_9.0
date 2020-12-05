using System;

namespace Literals
{
    class Program
    {
        static void Main(string[] args)
        {
            //numerics
            {   //decimal 
                Console.WriteLine(10);    //10
                Console.WriteLine(-3);    //-3
                Console.WriteLine(1609);  //1609
                                          //binary
                Console.WriteLine(0b11);        // 3
                Console.WriteLine(0b1011);      // 11
                Console.WriteLine(0b100001);    // 33

                //hexodecimal
                Console.WriteLine(0x0A);    // 10
                Console.WriteLine(0xFF);    // 255
                Console.WriteLine(0xA1);    // 161
            }
            //double
            {
                //1.
                Console.WriteLine(10.5);
               Console.WriteLine(-6.9);
             Console.WriteLine(3.0);
            }
            //MEp
            {
                Console.WriteLine(3.14e4);    // 3.2 * 10^3= 3200
                Console.WriteLine(1.2E-1);   // 1.2 * 10^-1=0.12
            }
            //char
            {
                Console.WriteLine('X');
                Console.WriteLine('R');
            }
            //ASCII code
            {
                Console.WriteLine('\x78');    // x
                Console.WriteLine('\x5A');    // Z
            }
            //Unicode
            {
                Console.WriteLine('\u0420');    // Р
                Console.WriteLine('\u0421');    // С
            }
            //string
            {
                Console.WriteLine("hello");
                Console.WriteLine("Salam");
                Console.WriteLine("hello word");

                // \"
                Console.WriteLine("Kompaniya \"Deliveroff\""); //Kompaniye "Deliveroff"

                //\n
                Console.WriteLine("Hello \nWorld");  /*Hello
                                                     World*/
            }
            Console.ReadKey();
        }
    }
}
