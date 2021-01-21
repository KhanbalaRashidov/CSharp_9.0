using System;
using Structure_OOP;
namespace AccesModifier_OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            #region access modifier

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



            // public class:
           public class Bicycle
           {
            // protected method:
            protected void Pedal() { }

            // private field:
            private int wheels = 3;

            // protected internal property:
            protected internal int Wheels
            {
                get { return wheels; }
            }

        }


    }
    }

}        
        
        
        
     



