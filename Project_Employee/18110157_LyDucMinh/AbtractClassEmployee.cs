using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18110157_LyDucMinh
{
    abstract class Employee
    {
        private Date birthDate;
        private Date hireDate;

        private string firstName;
        private string lastName;

        // constructor
        public Employee(string firstNameValue, string lastNameValue,
                        int birthMonth, int birthDay, int birthYear,
                        int hireMonth, int hireDay, int hireYear)
        {
            firstName = firstNameValue;
            lastName = lastNameValue;

            birthDate = new Date(birthMonth, birthDay, birthYear);
            hireDate = new Date(hireMonth, hireDay, hireYear);
        }

        /*public string ToEmployeeString()
        {
            return lastName + ", " + firstName +
                    " Hired: " + hireDate.ToDateString() +
                    " Birthday: " + birthDate.ToDateString();
        }*/

        //properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }


        public override string ToString()
        {

            return FirstName + " " + LastName
                + "--Hired: " + hireDate.ToDateString()
                + "--Birthday: " + birthDate.ToDateString();
        }

        public abstract decimal Earnings();
    }
}

