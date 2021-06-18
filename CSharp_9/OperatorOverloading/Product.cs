using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public abstract class Product
    {
        public string Name { get;  }
        public int Calorie { get;  }
        public int Volume { get;  }

        public double Energy
        {
            get
            {
                return Volume * Calorie / 100.0;
            }
        }

        public Product(string name, int calorie,int volume)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (calorie<0)
            {
                throw new ArgumentException(nameof(calorie));
            }
            if (volume<=0)
            {
                throw new ArgumentException(nameof(volume));
            }
            Name = name;
            Calorie = calorie;
            Volume = volume;
        }
        public override string ToString()
        {
            return $"Product:{Name} Energy:{Energy}";
        }
    }
}
