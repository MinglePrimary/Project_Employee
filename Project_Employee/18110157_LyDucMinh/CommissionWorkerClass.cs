using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18110157_LyDucMinh
{
    class CommissionWorker : Employee
    {

        private decimal salary;
        private decimal commission;
        private int quantity;
        public CommissionWorker(string firstNameValue, string lastNameValue,
                                int birthMonth, int birthDay, int birthYear,
                                 int hireMonth, int hireDay, int hireYear, 
                                 decimal salaryValue, decimal commissionValue, int quantityValue)
                : base(firstNameValue, lastNameValue,
                        birthMonth, birthDay, birthYear,
                        hireMonth, hireDay, hireYear)
        {
            WeeklySalary = salaryValue;
            Commission = commissionValue;
            Quantity = quantityValue;
        }

        public decimal WeeklySalary
        {
            get { return salary; }
            set { salary = value; }
        }

        public decimal Commission
        {
            get { return commission; }
            set { commission = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public override decimal Earnings()
        {
            return WeeklySalary + Commission
                * Quantity;
        }

        public override string ToString()
        {
            return "CommissionWorker: " + base.ToString();
        }
    }
}
