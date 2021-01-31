using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationComplicatedJSON
{

    public struct Worker
    {
        #region Constructor
        public Worker(string FirstName, string LastName, string Position, string Departament, int Salary)
        {
            firstName = FirstName;

            lastName = LastName;
            position = Position;
            departament = Departament;
            salary = Salary;
        }
        #endregion

        #region Properties
        public string FirstName
        {

            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }
        public string Position
        {
            get
            {
                return this.position;
            }
            set
            {
                this.position = value;
            }
        }
        public string Departament
        {
            get
            {
                return this.departament;
            }
            set
            {
                this.departament = value;
            }
        }
        public int Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                this.salary = value;
            }
        }

        public double HourRate
        {
            get
            {
                byte workingDays = 25;
                byte workingHour = 8;
                return ((double)Salary) / (workingDays * workingHour);
            }
        }
        #endregion
        #region Method
        public string Print()
        {
            return $"{FirstName,15} {LastName,15} {Position,15} {Departament,15} {Salary,10}";
        }


        #endregion

        #region field
        public string firstName;

        public string lastName;

        public string position;

        public string departament;

        public int salary;
        #endregion
    }

}
