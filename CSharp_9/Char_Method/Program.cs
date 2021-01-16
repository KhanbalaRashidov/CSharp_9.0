using System;

namespace Char_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            char x = '\u000d';
            Console.WriteLine($"x={x}");
            Console.WriteLine($"Char.IsDigit(x)={Char.IsDigit(x)}"); //false
            Console.WriteLine($"Char.IsLetter(x)={Char.IsLetter(x)}"); //true
            Console.WriteLine($"Char.IsUpper(x)={Char.IsUpper(x)}"); //false
            Console.WriteLine($"Char.IsLower(x)={Char.IsLower(x)}"); //true

            //Char.IsSymbol()
            Console.WriteLine($"Char.IsSymbol(x){Char.IsSymbol(x)}"); //false
            //Char.IsNumber()
            Console.WriteLine($"Char.IsNunber(x){Char.IsNumber(x)}"); //false


            char[] symbols = "symbols".ToCharArray();
            
            foreach (var item in symbols)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            string s = new string(symbols);
            Console.WriteLine(s);
         
            Console.WriteLine($"Char.IsDigit(s,2)={Char.IsDigit(s,2)}"); //false
            Console.WriteLine($"Char.IsLetter(s,2)={Char.IsLetter(s,2)}"); //true
            Console.WriteLine($"Char.IsUpper(s,2)={Char.IsUpper(s,2)}"); //false
            Console.WriteLine($"Char.IsLower(s,2)={Char.IsLower(s,2)}"); //true
        }
    }
}
