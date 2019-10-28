using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18110157_LyDucMinh
{
    class HourlyWorker : Employee
    {
        private decimal wage;
        private double hoursWorked;

        // constructor
        public HourlyWorker(string firstNameValue, string lastNameValue,
                            int birthMonth, int birthDay, int birthYear,
                            int hireMonth, int hireDay, int hireYear,
                            decimal wageValue, double hoursWorkedValue)
            : base(firstNameValue, lastNameValue,
                    birthMonth, birthDay, birthYear,
                    hireMonth, hireDay, hireYear)
        {
            wage = wageValue;
            HoursWorked = hoursWorkedValue;
        }

        public decimal Wage
        {
            get { return wage; }
            set
            {
                if (value > 0)
                    wage = value;
            }
        }
        public double HoursWorked
        {
            get { return hoursWorked; }
            set
            {
                if (value > 0)
                    hoursWorked = value;
            }
        }
        public override decimal Earnings()
        {
            if (HoursWorked <= 40)
            {
                return Wage * Convert.ToDecimal(HoursWorked);
            }
            else
            {
                decimal basePay = Wage * Convert.ToDecimal(40);
                decimal overtimPay = Wage * 1.5M * Convert.ToDecimal(HoursWorked - 40);
                return basePay + overtimPay;
            }
        }
        public override string ToString()
        {
            return "HourlyWorker: " + base.ToString();
        }
    }
}

