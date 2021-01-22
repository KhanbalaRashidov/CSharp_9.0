using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prop_OOP
{
    class Cat4
    {

        public Cat4(string NickName,string Breed )
        {
            this.nickname = NickName;
            this.breed = Breed;
        }

        
        private string nickname;

        
        public string Nickname
        {
            get { return this.nickname; }
            set { this.nickname = value; }
        }

        #region Nickname old

        

        
        //public void SetNickname(string value)
        //{
        //    this.Nickname = value;
        //}

       
        //public string GetNickname()
        //{
        //    return this.Nickname;
        //}


        #endregion


       
        private string breed;

        
        public string Breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }

        #region Breed old



        //private string Breed;


        //public void SetBreed(string NewBreed)
        //{
        //    this.Breed = NewBreed;
        //}


        //public string GetBreed()
        //{
        //    return this.Breed;
        //}

        #endregion

        public string EyeColor { get; private set; } = "Green";
    }
}
