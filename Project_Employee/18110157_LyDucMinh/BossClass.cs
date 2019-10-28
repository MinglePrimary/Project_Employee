using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18110157_LyDucMinh
{

    class Boss : Employee
    {
        private decimal salary;
        // constructor
        public Boss(string firstNameValue, string lastNameValue,
                        int birthMonth, int birthDay, int birthYear,
                        int hireMonth, int hireDay, int hireYear,
                    decimal salaryValue) 
            : base(firstNameValue, lastNameValue, birthMonth, birthDay, birthYear,
                    hireMonth, hireDay, hireYear)
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

