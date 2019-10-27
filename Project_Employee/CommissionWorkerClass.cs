using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Employee
{
    class CommissionWorker: Employee
    {
       
        private decimal salary;
        private decimal commission;
        private int quantity;
        public CommissionWorker(string firstNameValue,
            string lastnameValue, decimal salaryValue,
            decimal commissionValue, int quantityValue)
                :base(firstNameValue, lastnameValue)
        {
            WeeklySalary = salaryValue;
            Commission = commissionValue;
            Quantity = quantityValue;
        }

        public decimal WeeklySalary
        {
            get { return salary ; }
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
