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
        CardStore deck = new CardStore();
        Hand player = new Hand();
        Hand dealer = new Hand();

        public Form1()
        {
            InitializeComponent();
        } 

        private void Form1_Load(object sender, EventArgs e)
        {
            NewHand();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            player.DrawCard(deck);
            if(dealer.getScore() < 17)
            {
                dealer.DrawCard(deck);
            }
            labelPlayerScore.Text = player.getScore().ToString();
            labelDealerScore.Text = dealer.getScore().ToString();


        }

        public void NewHand()
        {
            for(int x = 0; x < 2; x++)
            {
                player.DrawCard(deck);
                dealer.DrawCard(deck);
            }

            labelPlayerScore.Text = player.getScore().ToString();
            labelDealerScore.Text = dealer.getScore().ToString();
        }
    }
}
