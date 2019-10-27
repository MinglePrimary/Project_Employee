﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Project_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss boss = new Boss("John", "Smith", 800);
            CommissionWorker commissionWorker = new CommissionWorker("Sue", "Jones", 400, 3, 150);
            PieceWorker pieceWorker = new PieceWorker("Bob", "Lewis", Convert.ToDecimal(2.5), 200 );
            HourlyWorker hourlyWorker = new HourlyWorker("Karen", "Price", Convert.ToDecimal(13.75), 50);

            Employee employee = boss;
            string output = GetString(employee) + boss + " earned " +
                boss.Earnings().ToString("C") + "\n\n";

            employee = commissionWorker;
            output += GetString(employee) + commissionWorker
                + " earned " + commissionWorker.Earnings().ToString("C") + "\n\n";

            employee = pieceWorker;
            output += GetString(employee) + pieceWorker 
                + " earned " + commissionWorker.Earnings().ToString("C") + "\n\n";

            employee = hourlyWorker;
            output += GetString(employee) + hourlyWorker
                + " earned " + hourlyWorker.Earnings().ToString("C") + "\n\n";

            MessageBox.Show(output, "Demonstrating Polymorphism", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
        }

        public static string GetString(Employee worker)
        {
            return worker.ToString() + " earned " +
                worker.Earnings().ToString("C")+"\n";
        }
    }
}
