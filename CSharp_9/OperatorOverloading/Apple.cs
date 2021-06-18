using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
   public class Apple:Product
    {
        public Apple(string name, int calorie, int volume)
            :base(name,calorie,volume)
        {

        }
        public static Apple Add(Apple apple1, Apple apple2)
        {
            int calories = (int)Math.Round((apple1.Calorie + apple2.Calorie) / 2.0);
            var volume = apple1.Volume + apple2.Volume;
            var apple = new Apple("Apple", calories, volume);
            return apple;
        }
        public static Apple operator +(Apple apple1, Apple apple2)
        {
            int calories = (int)Math.Round((apple1.Calorie + apple2.Calorie) / 2.0);
            var volume = apple1.Volume + apple2.Volume;
            var apple = new Apple("Apple", calories, volume);
            return apple;

        }
        public static bool operator ==(Apple apple1, Apple apple2)
        {
            return apple1==apple2;
        }
        public static bool operator !=(Apple apple1, Apple apple2)
        {
            return apple1==apple2;
        }
    }
}
