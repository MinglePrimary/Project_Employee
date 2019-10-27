using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Employee
{
    class Boss : Employee
    {
        private decimal salary;
        // constructor
        public Boss(string firstNameValue, string lastNameValue,
                    decimal salaryValue) : base(firstNameValue, lastNameValue)
        {
            WeeklySalary = salaryValue;
        }
        // property WeeklySalary
        public decimal WeeklySalary
        {
            get { return salary; }
            set
            {
                if (value > 0)
                    salary = value;
            }
        }
        public override decimal Earnings()
        {
            return salary;
        }

        public override string ToString()
        {
            return "Boss: " + base.ToString();
        }
    }
}
