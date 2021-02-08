using System;
namespace Example_1
{
    class Robot
    {
        public Robot(string NickName, string Discolation)
        {
            this.NickName = NickName;
            discolation= Discolation;
        }

        public string NickName { get; set; }

        private string discolation;
        public string Discolation { get { return this.discolation;} }
    }
}
