using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Configuration;
using System.Diagnostics;

namespace WindowsFormsApp2
{
    public partial class FormPlayGame : Form
    {
        public FormPlayGame()
        {
            InitializeComponent();
        }

        User user = new User();


        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            Form1 newGame = new Form1();
            this.user.Player = null;
            this.user.Dealer = null;
            newGame.user = this.user;
            newGame.RefToMenu = this;
            newGame.Show();
            this.Hide();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            if (!(user.UserName == "Guest" && user.Email.ToString() == "Guest@test.com"))
            {
                SaveFile();
            }
            this.Close();
        }

        private void buttonProfileInfo_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.user = this.user;
            profile.RefToMenu = this;
            profile.Show();
            this.Hide();
        }

        public void LoadText()
        {
            labelUser.Text = this.user.UserName;
            labelWinCount.Text = this.user.Win.ToString();
            labelLoseCount.Text = this.user.Lose.ToString();
            labelMoneyAmount.Text = this.user.Balance.ToString();
        }

        private void FormPlayGame_Load(object sender, EventArgs e)
        {
            LoadText();
        }

        private void buttonResume_Click(object sender, EventArgs e)
        {
            Form1 newGame = new Form1();
            newGame.user = this.user;
            newGame.RefToMenu = this;
            newGame.Show();
            this.Hide();
        }

        private void buttonNewProfile_Click(object sender, EventArgs e)
        {
            FormCreateProfile createProfile = new FormCreateProfile();
            createProfile.user = this.user;
            createProfile.RefToMenu = this;
            createProfile.Show();
            this.Hide();
        }

        private void SaveFile()
        {
            System.Text.StringBuilder sb = new StringBuilder();
            sb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            sb.AppendLine("<configuration>");
            sb.AppendLine("<appSettings>");
            sb.AppendLine("<add key='Username' value='"+user.UserName+"'/>");
            sb.AppendLine("<add key='Password' value='" + user.Password + "'/>");
            sb.AppendLine("<add key='Name' value='" + user.Name + "'/>");
            sb.AppendLine("<add key='Email' value='" + user.Email.ToString() + "'/>");
            sb.AppendLine("<add key='Phone' value='" + user.Phone[0] + "-" + user.Phone[1] + "-" + user.Phone[2] + "'/>");
            sb.AppendLine("<add key='Address' value='" + user.Address + "'/>");
            sb.AppendLine("<add key='Card' value='" + user.Card[0] + "-" + user.Card[1] + "-" + user.Card[2] + "-" + user.Card[3] + "'/>");
            sb.AppendLine("<add key='Balance' value='" + user.Balance + "'/>");
            sb.AppendLine("<add key='Win' value='" + user.Win + "'/>");
            sb.AppendLine("<add key='Lose' value='" + user.Lose + "'/>");
            sb.AppendLine("<add key='PlayerScore' value='" + user.Player.Score + "'/>");
            sb.AppendLine("<add key='PlayerAce' value='" + user.Player.Aces + "'/>");
            int cardCounter = 0;
            foreach(string image in user.Player.CardList)
            {
                sb.AppendLine("<add key='PlayerCard"+cardCounter+"' value='" + image + "'/>");
                cardCounter++;
            }
            sb.AppendLine("<add key='PlayerCardCount' value='" + cardCounter + "'/>");

            sb.AppendLine("<add key='DealerScore' value='" + user.Dealer.Score + "'/>");
            sb.AppendLine("<add key='DealerAce' value='" + user.Player.Aces + "'/>");
            cardCounter = 0;
            foreach (string image in user.Dealer.CardList)
            {
                sb.AppendLine("<add key='DealerCard" + cardCounter + "' value='" + image + "'/>");
                cardCounter++;
            }
            sb.AppendLine("<add key='DealerCardCount' value='" + cardCounter + "'/>");

            sb.AppendLine("</appSettings>");
            sb.AppendLine("</configuration>");

            string loc = @"../../Users/";
            System.IO.File.WriteAllText(String.Concat(loc, user.UserName+".config"), sb.ToString());
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormLogin Login = new FormLogin();
            Login.RefToMenu = this;
            Login.user = this.user;
            Login.ShowDialog();
        }

        private void buttonRules_Click(object sender, EventArgs e)
        {
            Process.Start("https://bicyclecards.com/how-to-play/blackjack/");
        }
    }
}
