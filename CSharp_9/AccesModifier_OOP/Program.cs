using System;
using Structure_OOP;
namespace AccesModifier_OOP
{
    class Program
    {
        static void Main(string[] args)
        {


            // public: The type or member can be accessed by 
            //any other code in the same assembly or another assembly that references it.

            // private: The type or member can be accessed only by code in the same class or struct.

            //protected: The type or member can be accessed only by code
            //in the same class, or in a class that is derived from that class.

            //internal: The type or member can be accessed by any code 
            // in the same assembly, but not from another assembly.

            //protected internal: The type or member can be accessed by any code  
            // in the assembly in which it's declared, or from within a derived class in another assembly.

            // private protected: The type or member can be accessed only within its  
            // declaring assembly, by code in the same class or in a type that is derived from that class.

            


        }






    }

    //Classes and structs declared directly within a namespace 
    //(in other words, that aren't nested within other classes or structs) can be either public or internal.
    //Internal is the default if no access modifier is specified.

    // public class:
    public class Tricycle
    {
        // protected method:
        protected static void Pedal() { Console.WriteLine("Pedal"); }

        // private field:
        private int wheels = 3;

        // protected internal property:
        protected internal int Wheels
        {
            get { return wheels; }
        }
    }

    //Default internal:
    class Person:Tricycle
    {

      
    }
}










