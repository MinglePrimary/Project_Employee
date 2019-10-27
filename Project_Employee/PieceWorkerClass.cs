using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Employee
{
    class PieceWorker : Employee
    {
        private decimal wagePerPiece;
        private int quantity;

        // constructor
        public PieceWorker (string firstNameValue, string lastNameValue,
                            decimal wagePerPieceValue, int quantityValue)
                            :base (firstNameValue, lastNameValue)
        {
            WagePerPiece = wagePerPieceValue;
            Quantity = quantityValue;
        }

        public decimal WagePerPiece
        {
            get { return wagePerPiece; }
            set
            {
                if (value > 0)
                    wagePerPiece = value;
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value > 0)
                    quantity = value;
            }
        }

        public override decimal Earnings()
        {
            return Quantity * WagePerPiece;
        }

        public override string ToString()
        {
            return "PieceWorker: " + base.ToString();
        }
    }
}
