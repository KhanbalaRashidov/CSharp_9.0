using System;

namespace Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Cat
            Cat cat1 = new Cat("NickName1", "Breed1");
            Cat cat2 = new Cat("NickName2", "Breed2");
            #endregion
            #region
            House house1 = new House(10, 20, "Baku");
            House house2 = new House(11, 21, "Siazan");
            #endregion
            #region
            Robot robot = new Robot("NickName", "Discolation");
            #endregion
        }
    }
}
