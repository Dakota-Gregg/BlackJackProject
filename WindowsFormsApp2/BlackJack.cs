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
        int payout = 2;
        int insuranceflag = 0;
        double blackjackpayout = 2.5;
        double balance;
        double pot = 0;
        double bet = 0;
        CardStore deck = new CardStore();
        Hand player = new Hand();
        Hand dealer = new Hand();
        
        public FormPlayGame RefToMenu { get; set; }

        public User user { get; set; }


        public Form1()
        {
            InitializeComponent();
           
        }

        private void buttonBet_Click(object sender, EventArgs e)
        {
            if (textBet.Text == "")
                Console.WriteLine("Error: No Bet Entered");
            else
            {
                try
                {
                    bet = Convert.ToDouble(textBet.Text);
                    if (bet > balance)
                        Console.WriteLine("Error: Not enough balance for bet");
                    else
                    {
                        pot = pot + bet;
                        balance = balance - bet;
                        formatPot(pot);
                        formatBalance(balance);
                        textBet.Text = "";
                    }
                }
                catch
                {
                    Console.WriteLine("Error: Please input a valid bet amount");
                }
            }

        }
        private void formatPot(double amount)
        {
            lblCurrentPot.Text = string.Format("{0:C}", amount);
        }

        private void formatBalance(double amount)
        {
            lblBalance.Text = string.Format("{0:C}", amount);
        }
        private void playerWin()
        {
            balance = balance + (pot * payout);
            pot = 0;
            formatBalance(balance);
            formatPot(pot);
        }
        private void dealerWin()
        {
            pot = 0;
            formatPot(pot);
        }
        private void playerBlackJack()
        {
            balance = balance + (pot * blackjackpayout);
            pot = 0;
            formatBalance(balance);
            formatPot(pot);
        }
        private void buttonNewHand_Click(object sender, EventArgs e)
        {
            
            player.Score = 0;
            while (player.Aces > 0)
            {
                player.decreaseAces();
            }

            dealer.Score = 0;
            while (dealer.Aces > 0)
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
            buttonSave.Enabled = false;
            while (dealer.Score < 17)
            {
                dealer.DrawCard(deck);

                if (dealer.Score > 21 && dealer.Aces >= 1)
                {
                    dealer.Score = dealer.Score - 10;
                    dealer.decreaseAces();
                }
            }

            labelDealerScore.Text = dealer.Score.ToString();

            CalculateWinner();
        }

        private void buttonHit_Click(object sender, EventArgs e)
        {

            if (player.Score >= 21)
            {
                CalculateWinner();
                return;
            }

            
            player.DrawCard(deck);

            PictureBox[] Dboxes = { boxD1, boxD2, boxD3, boxD4, boxD5, boxD6, boxD7, boxD8 };
            PictureBox[] Pboxes = { boxP1, boxP2, boxP3, boxP4, boxP5, boxP6, boxP7, boxP8 };
            Pboxes[count].Visible = true;
            Pboxes[count].BringToFront();
            Pboxes[count].ImageLocation = player.CardList[count];
            Pboxes[count].Refresh();
            
            if (dealer.Score < 17)
            {
                dealer.DrawCard(deck);
                Dboxes[count].ImageLocation = @"../../card-BMPs/b2fv.bmp";
                Dboxes[count].Visible = true;
                Dboxes[count].BringToFront();

                if (dealer.Score > 21 && dealer.Aces >= 1)
                {
                    dealer.Score =dealer.Score - 10;
                    dealer.decreaseAces();
                }
            }
            count++;
            if (player.Score > 21 && player.Aces >= 1)
            {
                player.Score =player.Score - 10;
                player.decreaseAces();
            }

            labelPlayerScore.Text = player.Score.ToString();
            labelDealerScore.Text = dealer.Score.ToString();

            
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            balance = user.Balance;
            formatBalance(balance);
            if (user.Player == null)
            {
                NewHand();
            }
            else
            {
                player = user.Player;
                labelPlayerScore.Text = player.Score.ToString();
                PictureBox[] Pboxes = { boxP1, boxP2, boxP3, boxP4, boxP5, boxP6, boxP7, boxP8 };
                for (count = 0; count < 8; count++)
                {
                    try
                    {
                        Pboxes[count].ImageLocation = player.CardList[count];
                        Pboxes[count].Visible = true;
                        Pboxes[count].BringToFront();
                        Pboxes[count].Refresh();
                    }
                    catch
                    {
                        break;
                    }
                }

                dealer = user.Dealer;
                labelDealerScore.Text = dealer.Score.ToString();
                PictureBox[] Dboxes = { boxD1, boxD2, boxD3, boxD4, boxD5, boxD6, boxD7, boxD8 };
                int dealercards = 0;
                foreach (string image in dealer.CardList)
                {
                    Dboxes[dealercards].ImageLocation = @"../../card-BMPs/b2fv.bmp";
                    Dboxes[dealercards].Visible = true;
                    Dboxes[dealercards].BringToFront();
                    Dboxes[dealercards].Refresh();
                    dealercards++;
                }
                Dboxes[0].ImageLocation = dealer.CardList[0];
                Dboxes[0].Refresh();
                
            }

        }

        private void NewHand()
        { 
            labelDealerScore.Visible = false;
            buttonNewHand.Enabled = false;
            buttonHit.Enabled = true;
            buttonStay.Enabled = true;
            buttonSave.Enabled = true;

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
                Pboxes[count].ImageLocation=player.CardList[count];
                Pboxes[count].Refresh();

                //List<Card> cardList = player.GetCardList();
                //Card card = cardList.First();
                //boxP1.Image = Image.FromFile(card.GetImage());
                dealer.DrawCard(deck);
                Dboxes[count].Visible = true;
            }
            Dboxes[0].ImageLocation = dealer.CardList[0];
            Dboxes[1].ImageLocation = @"../../card-BMPs/b2fv.bmp";
            labelPlayerScore.Text = player.Score.ToString();
            labelDealerScore.Text = dealer.Score.ToString();
            formatPot(pot);
            formatBalance(balance);
        }

        private void CalculateWinner()
        {
            buttonNewHand.Enabled = true;
            buttonStay.Enabled = false;
            buttonHit.Enabled = false;

            PictureBox[] Dboxes = { boxD1, boxD2, boxD3, boxD4, boxD5, boxD6, boxD7, boxD8 };
            int x = 0;
            foreach (string image in dealer.CardList)
            {
                Dboxes[x].ImageLocation = image;
                Dboxes[x].Visible = true;
                Dboxes[x].Refresh();
                Dboxes[x].BringToFront();
                x++;
            }
            if (dealer.Score==21 && insuranceflag == 1)
            {
                user.Win++;
                Console.WriteLine("Player Wins!");
                MessageBox.Show("Wins: " + user.Win + "    Lose: " + user.Lose, "Player Wins!");
                playerWin();
            }
            else if (dealer.Score!=21 && insuranceflag == 1)
            {
                user.Lose++;
                Console.WriteLine("Dealers Wins!");
                MessageBox.Show("Wins: " + user.Win + "    Lose: " + user.Lose, "Player Loses!");
                dealerWin();
            }
            else if (player.Score == 21)
            {
                user.Win++;
                Console.WriteLine("Player Wins!");
                MessageBox.Show("Wins: " + user.Win + "    Lose: " + user.Lose, "Player Wins!");
                if (count == 2)
                    playerBlackJack();
                else
                    playerWin();
            }
            else if(player.Score > 21)
            {
                user.Lose++;
                Console.WriteLine("Dealers Wins!");
                MessageBox.Show("Wins: " + user.Win + "    Lose: " + user.Lose, "Player Loses!");
                dealerWin();
            }
            else if(dealer.Score == 21)
            {
                user.Lose++;
                Console.WriteLine("Dealers Wins!");
                MessageBox.Show("Wins: " + user.Win + "    Lose: " + user.Lose, "Player Loses!");
                dealerWin();
            }
            else if (dealer.Score > 21)
            {
                user.Win++;
                Console.WriteLine("Player Wins!");
                MessageBox.Show("Wins: " + user.Win + "    Lose: " + user.Lose, "Player Wins!");
                playerWin();
            }
            else
            {
                if(player.Score > dealer.Score)
                {
                    user.Win++;
                    Console.WriteLine("Player Wins!");
                    MessageBox.Show("Wins: " + user.Win + "    Lose: " + user.Lose, "Player Wins!");
                }
                else if (player.Score == dealer.Score)
                {
                    dealer.DrawCard(deck);
                    CalculateWinner();
                }
                else
                {
                    user.Lose++;
                    Console.WriteLine("Dealer Wins!");
                    MessageBox.Show("Wins: " + user.Win + "    Lose: " + user.Lose, "Player Loses!");
                    dealerWin();
                }
            }

            labelDealerScore.Visible = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            

            System.IO.File.WriteAllText(@"../../Test.txt",lblBalance.Text);
            user.Player = player;
            user.Dealer = dealer;
            user.Balance = balance;

            this.RefToMenu.LoadText();
            this.RefToMenu.Show();
            this.Close();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            lblBalance.Text=System.IO.File.ReadAllText(@"../../Test.txt");
        }

        private void buttonInsurance_Click(object sender, EventArgs e)
        {
            insuranceflag = 1;
            if (textBet.Text == "")
                Console.WriteLine("Error: No Bet Entered");
            else
            {
                try
                {
                    bet = Convert.ToDouble(textBet.Text);
                    if (bet > balance)
                        Console.WriteLine("Error: Not enough balance for insurance bet");
                    else
                    {
                        pot = pot + bet;
                        balance = balance - bet;
                        formatPot(pot);
                        formatBalance(balance);
                        textBet.Text = "";
                    }
                }
                catch
                {
                    Console.WriteLine("Error: Please input a valid bet amount");
                }
            }
                CalculateWinner();
        }
    }
}
