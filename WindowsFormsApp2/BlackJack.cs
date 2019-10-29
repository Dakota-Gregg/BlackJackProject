using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBet_Click(object sender, EventArgs e)
        {
            double balance, bet;
            balance = Convert.ToDouble(lblBalance.Text);
            bet = Convert.ToDouble(textBet.Text);

            balance = balance - bet;
            lblCurrentPot.Text = string.Format("{0:C}", bet);
            lblBalance.Text = string.Format("{0:C}", balance);

        }

        private void buttonNewHand_Click(object sender, EventArgs e)
        {

        }

        private void buttonStay_Click(object sender, EventArgs e)
        {

        }

        private void buttonHit_Click(object sender, EventArgs e)
        {

        }
    }
}
