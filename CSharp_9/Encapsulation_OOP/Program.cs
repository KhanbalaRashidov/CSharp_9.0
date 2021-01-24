using System;

namespace Encapsulation_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Encapsulation\n");

            #region Computer1

            Computer1 computer1 = new Computer1("Computer_1");
            computer1.ActivationBIOS();
            computer1.ActivationOS();
            computer1.Calculation();
            computer1.DeactivationBIOS();
            computer1.DeactivationOS();
            computer1.Parting();
            #endregion

            #region Computer2
            Console.ReadKey(); Console.Clear();
            Computer2 computer2 = new Computer2("Computer_2");
            computer2.PowerOff();
            computer2.PowerOn();
            #endregion

            #region Computer3
            Console.ReadKey(); Console.Clear();
            Computer3 computer3 = new Computer3("Computer_3");
            for (int i = 0; i < 5; i++)
            {
                computer3.Power();
                Console.WriteLine(computer3.Indicator);
                Console.ReadKey();
            }

            #endregion
        }
    }
    
}
