using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_OOP
{
    public struct Computer3
    {
        public string Title { get; set; }

        private bool condition;

        public int Indicator { get { return condition ? 1 : 0; } }
        public Computer3(string Title)
        {
            this.Title = Title;
            condition = false;
        }

        private void ActivationBIOS() => Console.WriteLine($"{this.Title} |.\\.| Activation  BIOS...");

        private void ActivationOS() => Console.WriteLine($"\n{this.Title} |.\\.| Activation  OS...\n");

        private void Greeting() => Console.WriteLine($"{Title} |.\\.| Hello...");
        private void DeactivationBIOS() => Console.WriteLine($"{this.Title} |.\\.| Activation  BIOS...");

        private void DeactivationOS() => Console.WriteLine($"{this.Title} |.\\.| Activation  OS...");

        private void Parting() => Console.WriteLine($"\n{Title} |.\\.| Bye...\n");

        private void PowerOn()
        {
            ActivationOS();
            ActivationBIOS();
            Greeting();
            Calculation();

        } 
        private void PowerOff()
        {
            Parting();
            DeactivationOS();
            DeactivationBIOS();
           
        }

        #region Method Open/Close
        public void Power()
        {
            if (condition)
            {
                PowerOff();
                condition = false;
            }
            else
            {
                PowerOn();
                condition = true;
            }
        }
        #endregion
        private void Calculation() => Console.WriteLine($"{Title} |.\\.| Calculation...");
        
    }
}
