using System;

namespace String_Method1
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "Visual alusiV";
            Console.WriteLine($"str = {str} ");
          
            Console.WriteLine($"str.IndexOf('i') = {str.IndexOf('i')}");
            Console.WriteLine($"str.IndexOf('%') = {str.IndexOf('%')}");

          
            Console.WriteLine($"str.LastIndexOf('i') = {str.LastIndexOf('i')}");

           
            Console.WriteLine($"str.LastIndexOf('z') = {str.LastIndexOf('z')}");

           
            string s = str.Insert(str.IndexOf(' ') + 1, "C# ");
            Console.WriteLine($"s = {s}");

            
            Console.WriteLine($"str.Remove(6) = {str.Remove(6)}");
            
            Console.WriteLine($"str.Remove(6, 3) = {str.Remove(6, 3)}");

            
            Console.WriteLine($"str.Replace('a','z') = {str.Replace('a', 'z')}");


           
            Console.WriteLine($"str.Substring(4) = {str.Substring(4)}");


            Console.WriteLine($"str.ToUpper() = {str.ToUpper()}");
            Console.WriteLine($"str.ToLower() = {str.ToLower()}");


            //str.Trim();    
            //str.TrimEnd();    
            //str.TrimStart();  

            // Разбивает строку на подстроки в зависимости от символов в массиве.
            string[] array = "1 2 3 4,5 6;7 8 9;10".Split(' ', ',', ';');


            string test = null;

            Console.WriteLine($"String.IsNullOrEmpty(test) = {String.IsNullOrEmpty(test)}");    // True

            test = String.Empty;
            Console.WriteLine($"String.IsNullOrEmpty(test) = {String.IsNullOrEmpty(test)}");    // True

            test = "Skill";
            Console.WriteLine($"String.IsNullOrEmpty(test) = {String.IsNullOrEmpty(test)}");    // False

        }
    }
}
