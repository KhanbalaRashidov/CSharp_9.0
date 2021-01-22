using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prop_OOP
{
    class Cat3
    {
        
        public Cat3(string Breed, string Nickname)
        {
            this.Breed = Breed;
            this.Nickname = Nickname;
        }

       
        private string Nickname;

        
        private void SetNickname(string NewNickname)
        {
            this.Nickname = NewNickname;
        }

        public string GetNickname()
        {
            return this.Nickname;
        }

        
        private string Breed;

        
        public void SetBreed(string NewBreed)
        {
            this.Breed = NewBreed;
        }

       
        private string GetBreed()
        {
            return this.Breed;
        }
    }
}
