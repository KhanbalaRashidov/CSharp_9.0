using System;


namespace Constructor_OOP
{
    struct Worker
    {
        public string FirstName;

        public string LastName;

        public string Position;

        public uint Salary;

        public DateTime DateOfBrith;

        public void Print()
        {
            Console.WriteLine($"\nFirst Name: {FirstName}  Last Name: {LastName}  Position: {Position} Salary: {Salary} Date of Brith: {DateOfBrith}\n");

        }

        
        public Worker(string FirstName, string LastName, string Position, uint Salary, DateTime DateOfBirth)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Position = Position;
            this.Salary = Salary;
            this.DateOfBrith = DateOfBirth;
        }
        
        #region Constructor v1
        /*
        public Worker(string FirstName,string LastName,string Position, uint Salary)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Position = Position;
            this.Salary = Salary;
            this.DateOfBrith = new DateTime(2000, 03, 03);
        }

        public Worker(string FirstName, string LastName,string Position)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Position = Position;
            this.Salary = 0;
            this.DateOfBrith = new DateTime(2000, 03, 03);

        }

        public Worker(string FirstName,string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Position = String.Empty;
            this.Salary = 0;
            this.DateOfBrith = new DateTime(2000, 03, 03);
        }

        public Worker(string FirstName)
        {
            this.FirstName = FirstName;
            this.LastName = String.Empty;
            this.Position = String.Empty;
            this.Salary = 0;
            this.DateOfBrith = new DateTime(2000, 03, 03,00,00,00);
        }
        */
        #endregion

        #region Constructor v2

        public Worker(string FirstName,string LastName,string Position,uint Salary):
            this(FirstName,LastName,Position,Salary,new DateTime(2000,03,03))
        {

        }
        public Worker(string FirstName,string LastName,string Position):
            this(FirstName,LastName,Position,0,new DateTime(2000,03,03))
        {

        }

        public Worker(string FirstName,string LastName):
            this(FirstName,LastName,String.Empty,0,new DateTime(2000,03,03))
        {

        }

        public Worker(string FirstName):
            this(FirstName,String.Empty,String.Empty,0,new DateTime(2000,03,03))
        {

        }
        #endregion
    }

}
