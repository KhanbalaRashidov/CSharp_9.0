using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_OOP
{
    public struct Computer1
    {
        public string Title { get; set; }

        
        public Computer1(string Title)
        {
            this.Title = Title;
        }

        #region Методы Open/Close

        
        public void ActivationBIOS() { Console.WriteLine($"{this.Title} | Activation BIOS..."); }

       
        public void ActivationOS() { Console.WriteLine($"{this.Title} | Activation OS..."); }

        
        public void Greeting() { Console.WriteLine($"{this.Title} | Hello..."); }

        public void DeactivationBIOS() { Console.WriteLine($"{this.Title} | Deactivation BIOS..."); }

        
        public void DeactivationOS() { Console.WriteLine($"{this.Title} | Deactivation OS..."); }

       
        public void Parting() { Console.WriteLine($"{this.Title} | Bye..."); }

        #endregion

       
        public void Calculation()
        {
            Console.WriteLine($"\n{this.Title} | Calculation...\n");
        }
    }
}
