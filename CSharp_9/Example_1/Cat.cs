using System;
namespace Example_1
{
    class Cat
    {
        public Cat(string NickName, string Breed)
        {
            this.NickName = NickName;
            this.Breed = Breed;
        }
        private string breed;
        public string NickName { get; set; }

        public string Breed { get { return "Poroda" + breed; } set { breed = value; } }

        public void ToPlay() 
        {
            Console.WriteLine($"{NickName} play");
        }

        public void ToSleep() 
        { 
            Console.WriteLine($"{NickName} sleep"); 
        }

        public void ToEat() 
        { 
            Console.WriteLine($"{NickName} eat"); 
        }

        public void ToMew() 
        { 
            Console.WriteLine($"{NickName} mew! ");
        }
    }
}

