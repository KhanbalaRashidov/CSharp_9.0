using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prop_OOP
{
    struct Account2
    {

        public string Login;


        private string Password;


        public void SetPassword(string NewPassword)
        {
            this.Password = NewPassword;
        }


        public Account2(string Login, string Password)
        {
            this.Login = Login;
            this.Password = Password;
        }
    }
}
