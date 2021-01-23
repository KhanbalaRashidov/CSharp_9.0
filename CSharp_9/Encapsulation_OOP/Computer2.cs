using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_OOP
{
    public struct Computer2
    {
        public string Title { get; set; }

        
        public Computer2(string Title)
        {
            this.Title = Title;
        }

        #region Method Open/Close

       
        private void ActivationBIOS() { Console.WriteLine($"{this.Title} | Activation BIOS..."); }

        
        private void ActivationOS() { Console.WriteLine($"\n{this.Title} | Activation OS..."); }

       
        private void Greeting() { Console.WriteLine($"\n{this.Title} | Hello..."); }

        
        private void DeactivationBIOS() { Console.WriteLine($"{this.Title} | Deactivation BIOS..."); }

      
        public void DeactivationOS() { Console.WriteLine($"{this.Title} | Deactivation OS..."); }

        
        private void Parting() { Console.WriteLine($"\n{this.Title} | Bye..."); }

        #endregion

        public void PowerOn()
        {
            this.ActivationBIOS();
            this.ActivationOS();
            this.Greeting();
            this.Calculation();
        }

        public void PowerOff()
        {
            this.Parting();
            this.DeactivationOS();
            this.DeactivationBIOS();
        }


       
        private void Calculation()
        {
            Console.WriteLine($"\n{this.Title} | Calculation...\n");
        }

    }
}
