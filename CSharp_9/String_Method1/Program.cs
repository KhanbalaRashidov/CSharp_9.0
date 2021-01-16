using System;

namespace String_Method1
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "Visual programming language ";
            Console.WriteLine($"str = {str} ");
          
            //str.IndexOf method
            Console.WriteLine($"str.IndexOf('i') = {str.IndexOf('i')}");
            Console.WriteLine($"str.IndexOf('%') = {str.IndexOf('%')}");

          //str.LastIndexOfmethod
            Console.WriteLine($"str.LastIndexOf('i') = {str.LastIndexOf('i')}");

           
            Console.WriteLine($"str.LastIndexOf('z') = {str.LastIndexOf('z')}");

           
            string s = str.Insert(str.IndexOf(' ') + 1, "C# 9.0 ");
            Console.WriteLine($"s = {s}");

            //str.Remove method
            Console.WriteLine($"str.Remove(6) = {str.Remove(6)}");
            
            Console.WriteLine($"str.Remove(6, 3) = {str.Remove(6, 3)}");

            //str.Replace method
            Console.WriteLine($"str.Replace('a','z') = {str.Replace('a', 'z')}");

            string str2 = "Hello";
            Console.WriteLine($"str2.Concat(str2,str)={String.Concat(str2," ",str)}");

           //str.Substring method
            Console.WriteLine($"str.Substring(4) = {str.Substring(4)}");

            //str.ToUpper
            Console.WriteLine($"str.ToUpper() = {str.ToUpper()}");
            //str.ToLower
            Console.WriteLine($"str.ToLower() = {str.ToLower()}");


            //str.Trim();    
            Console.WriteLine($"str.Trim()={str.Trim()}");
            //str.TrimEnd();  
            Console.WriteLine($"str.TrimEnd()={str.TrimEnd()}");
            //str.TrimStart(); 
            Console.WriteLine($"str.TrimStart()={str.TrimStart()}");

            // Разбивает строку на подстроки в зависимости от символов в массиве.
            string[] array ="1 2 3 4,5 6;7 8 9;10".Split(' ', ',', ';');
            
            foreach (var item in array)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            string test = null;
            //String.IsNullOrEmpty method
            Console.WriteLine($"String.IsNullOrEmpty(test) = {String.IsNullOrEmpty(test)}");    // True

            //String.Empty method
            test = String.Empty;
            Console.WriteLine($"String.IsNullOrEmpty(test) = {String.IsNullOrEmpty(test)}");    // True

            test = "Skill";
            Console.WriteLine($"String.IsNullOrEmpty(test) = {String.IsNullOrEmpty(test)}");    // False


           

        }
    }
}
