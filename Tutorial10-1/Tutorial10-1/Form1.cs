using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial10_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetCDData(CDAccount account)
        {
            decimal interestRate;
            decimal balance;


            account.AccNumber = accNumberTB.Text;
            account.MatDate = matDateTB.Text;

            if (decimal.TryParse(intRateTB.Text, out interestRate))
            {
                account.InterestRate = interestRate;

                if (decimal.TryParse(balanceTB.Text, out balance))
                {
                    account.Balance = balance;
                }

                else
                {
                    MessageBox.Show("Invalid Balance");
                }
            }

            else
            {
                MessageBox.Show("Invalid Interest Rate");
            }

        }

        private void createObjBtn_Click(object sender, EventArgs e)
        {
            CDAccount myAccount = new CDAccount();

            GetCDData(myAccount);

            accNumberLbl.Text = myAccount.AccNumber;
            intRateLbl.Text = myAccount.InterestRate.ToString("n2");
            balanceLbl.Text = myAccount.Balance.ToString("c");
            matDateLbl.Text = myAccount.MatDate;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
