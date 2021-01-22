using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prop_OOP
{
    class Cat2
    {
        

        public Cat2(string Breed, string NickName)
        {
            this.Breed = Breed;
            this.NickName = NickName;
        }

        public string NickName;

        private string Breed;

        public string GetBreed()
        {
            return this.Breed;
        }

    }
}
