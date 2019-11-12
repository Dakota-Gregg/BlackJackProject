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
        int count=0;
        int dcount = 0;
        CardStore deck = new CardStore();
        Hand player = new Hand();
        Hand dealer = new Hand();
        
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
            lblCurrentPot.Text = Convert.ToString(bet);
            lblBalance.Text = Convert.ToString(balance);
            //lblCurrentPot.Text = string.Format("{0:C}", bet);
            //lblBalance.Text = string.Format("{0:C}", balance);

        }

        private void buttonNewHand_Click(object sender, EventArgs e)
        {
            
            player.setScore(0);
            while (player.getAces() > 0)
            {
                player.decreaseAces();
            }

            dealer.setScore(0);
            while (dealer.getAces() > 0)
            {
                dealer.decreaseAces();
            }

            deck.reset();
            player.reset();
            dealer.reset();
            NewHand();
        }

        private void buttonStay_Click(object sender, EventArgs e)
        {
            buttonHit.Enabled = false;
            while (dealer.getScore() < 17)
            {
                dealer.DrawCard(deck);

                if (dealer.getScore() > 21 && dealer.getAces() >= 1)
                {
                    dealer.setScore(dealer.getScore() - 10);
                    dealer.decreaseAces();
                }
            }

            labelDealerScore.Text = dealer.getScore().ToString();

            CalculateWinner();
        }

        private void buttonHit_Click(object sender, EventArgs e)
        {

            if (player.getScore() >= 21)
            {
                CalculateWinner();
                return;
            }

            
            player.DrawCard(deck);

            PictureBox[] Dboxes = { boxD1, boxD2, boxD3, boxD4, boxD5, boxD6, boxD7, boxD8 };
            PictureBox[] Pboxes = { boxP1, boxP2, boxP3, boxP4, boxP5, boxP6, boxP7, boxP8 };
            Pboxes[count].Visible = true;
            Pboxes[count].BringToFront();
            Pboxes[count].ImageLocation = player.GetCardList()[count];
            Pboxes[count].Refresh();
            
            if (dealer.getScore() < 17)
            {
                dealer.DrawCard(deck);
                Dboxes[count].ImageLocation = @"../../card-BMPs/b2fv.bmp";
                Dboxes[count].Visible = true;
                Dboxes[count].BringToFront();
                dcount++;

                if (dealer.getScore() > 21 && dealer.getAces() >= 1)
                {
                    dealer.setScore(dealer.getScore() - 10);
                    dealer.decreaseAces();
                }
            }
            count++;
            if (player.getScore() > 21 && player.getAces() >= 1)
            {
                player.setScore(player.getScore() - 10);
                player.decreaseAces();
            }

            labelPlayerScore.Text = player.getScore().ToString();
            labelDealerScore.Text = dealer.getScore().ToString();

            
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewHand();
          

        }

        private void NewHand()
        { 
            labelDealerScore.Visible = false;
            buttonNewHand.Enabled = false;
            buttonHit.Enabled = true;
            PictureBox[] Pboxes = { boxP1, boxP2, boxP3, boxP4, boxP5, boxP6, boxP7, boxP8 };
            PictureBox[] Dboxes = { boxD1, boxD2, boxD3, boxD4, boxD5, boxD6, boxD7, boxD8 };
            for (count = 0; count < 8; count++)
            {
                Pboxes[count].ImageLocation = null;
                Pboxes[count].Refresh();
                Pboxes[count].Visible = false;
            }
            for (count = 0; count < 8; count++)
            {
                Dboxes[count].ImageLocation = null;
                Dboxes[count].Refresh();
                Dboxes[count].Visible = false;
            }
            for ( count = 0; count < 2; count++)
            {
                player.DrawCard(deck);
                Pboxes[count].Visible = true;
                Pboxes[count].ImageLocation=player.GetCardList()[count];
                Pboxes[count].Refresh();

                //List<Card> cardList = player.GetCardList();
                //Card card = cardList.First();
                //boxP1.Image = Image.FromFile(card.GetImage());
                dealer.DrawCard(deck);
                Dboxes[count].Visible = true;
            }
            Dboxes[0].ImageLocation = dealer.GetCardList()[0];
            Dboxes[1].ImageLocation = @"../../card-BMPs/b2fv.bmp";
            dcount = 2;
            labelPlayerScore.Text = player.getScore().ToString();
            labelDealerScore.Text = dealer.getScore().ToString();
        }

        private void CalculateWinner()
        {
            buttonNewHand.Enabled = true;
            PictureBox[] Dboxes = { boxD1, boxD2, boxD3, boxD4, boxD5, boxD6, boxD7, boxD8 };
            for (int x=0;x<dcount;x++)
            {
                Dboxes[x].ImageLocation = dealer.GetCardList()[x];
                Dboxes[x].Refresh();
                Dboxes[x].BringToFront();
            }
            if (player.getScore() == 21)
            {
                Console.WriteLine("Player Wins!");
            }
            else if(player.getScore() > 21)
            {
                Console.WriteLine("Dealers Wins!");
            }
            else if(dealer.getScore() == 21)
            {
                Console.WriteLine("Dealers Wins!");
            }
            else if (dealer.getScore() > 21)
            {
                Console.WriteLine("Player Wins!");
            }
            else
            {
                if(player.getScore() > dealer.getScore())
                {
                    Console.WriteLine("Player Wins!");
                }
                else if (player.getScore() == dealer.getScore())
                {
                    dealer.DrawCard(deck);
                    CalculateWinner();
                }
                else
                {
                    Console.WriteLine("Dealer Wins!");
                }
            }

            labelDealerScore.Visible = true;
        }

        private void boxP2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            

            System.IO.File.WriteAllText(@"../../Test.txt",lblBalance.Text);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            lblBalance.Text=System.IO.File.ReadAllText(@"../../Test.txt");
        }
    }
}
