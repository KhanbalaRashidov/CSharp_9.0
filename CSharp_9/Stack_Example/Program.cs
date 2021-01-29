using System;
using System.Collections.Generic;

namespace Stack_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = "( ( 2 + 2 ) * 2 )"; Console.WriteLine($"Expected Result: {((2 + 2) * 2)}");
             expression = "( ( 9 + ( 4 * 6 ) ) / 10 )"; Console.WriteLine($"Expected Result: {((9.0 + (4 * 6)) / 10)}");
             expression = "( ( 1 + ( 2 * 3 ) ) ^ 4 )"; Console.WriteLine($"Ожидаемый результат: {Math.Pow(1 + (2 * 3), 4)}");

            var expressionArray = expression.Replace('(', ' ').Trim().Split(' ');   // Parsing an arithmetic expression into components

            Console.WriteLine("expression");
           foreach (var e  in expressionArray) Console.WriteLine(e);

            Stack<double> numbers = new Stack<double>();    // Stack for storing numbers
            Stack<string> operations = new Stack<string>(); // Operation storage stack


            foreach (var e in expressionArray)  // viewing the components of an arithmetic expression
            {
                double n;   //Auxiliary number

                if (String.IsNullOrEmpty(e)) continue; // ignore empty elements

                // If expressionArray is a number, add numbers to the stack
                if (double.TryParse(e, out n)) { numbers.Push(n); continue; }

                // If expressionArray is an operation, add to the stack with operations
                if (@"+/*-^".IndexOf(e) > -1) { operations.Push(e); continue; }

                // Closing parenthesis - call to action
                if (e == ")")
                {
                    double n1 = numbers.Pop();  // Extracting two numbers
                    double n2 = numbers.Pop();  // from the stack with numbers
                    string operation = operations.Pop(); //fetching the operation


                    switch (operation)                                      //
                    {                                                       //
                        case "+": numbers.Push(n2 + n1); break;             // We perform the operation
                        case "-": numbers.Push(n2 - n1); break;             // and put the result
                        case "/": numbers.Push(n2 / n1); break;             // on the stack with numbers
                        case "*": numbers.Push(n2 * n1); break;             //
                        case "^": numbers.Push(Math.Pow(n2, n1)); break;     //
                    }
                }
            }

            Console.WriteLine("\n\nnumbers");

            foreach (var item in numbers) Console.WriteLine(item);

            Console.WriteLine("\n\noperations");

            foreach (var item in operations) Console.WriteLine(item);

            Console.WriteLine($"Result: {numbers.Pop()}"); // The only item in the number stack is the answer

        }
    }
}
