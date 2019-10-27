using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Employee
{
    public abstract class Employee
    {

        private string firstName;
        private string lastName;
        // constructor
        public Employee(string firstNameValue, string lastNameValue)
        {
            firstName = firstNameValue;
            lastName = lastNameValue;
        }

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
            return FirstName + " " + LastName;
        }
        public abstract decimal Earnings();
    }
}
