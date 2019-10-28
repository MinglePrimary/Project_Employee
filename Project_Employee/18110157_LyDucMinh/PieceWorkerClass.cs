using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18110157_LyDucMinh
{
    class PieceWorker : Employee
    {
        private decimal wagePerPiece;
        private int quantity;

        // constructor
        public PieceWorker(string firstNameValue, string lastNameValue,
                        int birthMonth, int birthDay, int birthYear,
                        int hireMonth, int hireDay, int hireYear,
                            decimal wagePerPieceValue, int quantityValue)
                            : base(firstNameValue, lastNameValue,
                                  birthMonth, birthDay, birthYear,
                                  hireMonth, hireDay, hireYear)
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

