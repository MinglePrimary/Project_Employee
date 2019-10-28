using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _18110157_LyDucMinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Boss boss = new Boss("John", "Smith",
                                1, 2, 6,
                                1, 3, 12,
                                2.01600M);
        CommissionWorker commissionWorker = new CommissionWorker(
                            "Sue", "Jones",
                                12, 2, 69,
                                3, 12, 16,
                                850,1,1);
        HourlyWorker hourlyWorker = new HourlyWorker(
                                "Karen", "Price",
                                    2, 2, 89,
                                    3, 11, 18,
                                    756.25M, 1.0);
        PieceWorker pieceWorker = new PieceWorker(
                                "Bob", "Lewis",
                                 2, 6, 89,
                                 3, 12, 17,
                                 500.00M, 1);

        public string output1, output2, output3, output4;

        private void btSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("textfile.txt"))
            {
                sw.WriteLine("Ket qua:");
                sw.WriteLine(output1);
                sw.WriteLine();
                sw.WriteLine(output2);
                sw.WriteLine();
                sw.WriteLine(output3);
                sw.WriteLine();
                sw.WriteLine(output4);
                sw.Close();
            }

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application exit");
            Application.Exit();
        }

        private void btDis_Click(object sender, EventArgs e)
        {
            lblHienThi.Text = "Ket qua:\n"+ output1 + "\n" + output2 + "\n"
                                            + output3 + "\n" + output4;
        }
        
        
        private void btSet_Click(object sender, EventArgs e)
        {
            
            if (txtHuman.Text == "1" || txtHuman.Text == "boss")
            {
                output1 = boss + "--Earned " + boss.Earnings().ToString("C") + "\n";
                lblDis.Text = txtHuman.Text + ": " + output1;
            }
            else if (txtHuman.Text == "2" || txtHuman.Text == "commissionWorker")
            {
                output2 = commissionWorker  + "--Earned " + commissionWorker.Earnings().ToString("C") + "\n";
                lblDis.Text = txtHuman.Text + ": " + output2;
            }
            else if (txtHuman.Text == "3" || txtHuman.Text == "pieceworker")
            {
                output3 = pieceWorker  + "--Earned " + pieceWorker.Earnings().ToString("C") + "\n";
                lblDis.Text = txtHuman.Text + ": " + output3;
            }
            else if (txtHuman.Text == "4" || txtHuman.Text == "hourlyWorker")
            {
                output4 = hourlyWorker + "--Earned " + hourlyWorker.Earnings().ToString("C") + "\n";
                lblDis.Text = txtHuman.Text + ": " + output4;
            }
            else lblDis.Text = "Not found";
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            txtHuman.Clear();
        }


    }
}
