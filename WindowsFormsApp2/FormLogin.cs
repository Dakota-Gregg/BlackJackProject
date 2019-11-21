using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace WindowsFormsApp2
{
    public partial class FormLogin : Form
    {

        public User user { get; set; }

        public FormPlayGame RefToMenu { get; set; }


        string username;
        string password;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            username = textBoxUser.Text;
            password = textBoxPassword.Text;

            FindUser();
            RefToMenu.LoadText();
        }

        private void FindUser()
        {
            ExeConfigurationFileMap configMap = new ExeConfigurationFileMap();
            string filePath = @"..\..\Users\" + username + ".config";
            try
            {
                configMap.ExeConfigFilename = filePath;
                Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configMap, ConfigurationUserLevel.None);

                if ( (username == config.AppSettings.Settings["Username"].Value && password == config.AppSettings.Settings["Password"].Value))
                {
                    LoadUser(config);
                }
                else
                {
                    labelError.Text = "Incorrect Password";
                    labelError.Visible = true;
                }
            }
            catch
            {
                labelError.Text = "User Does Not Exist";
                labelError.Visible = true;
            }
        }

        private void LoadUser(Configuration config)
        {
            Regex split = new Regex(@"-");
            int[] phone = new int[3];
            int[] card = new int[4];

            int x = 0;
            foreach (string number in split.Split(config.AppSettings.Settings["Phone"].Value))
            {
                int phoneNumber = Int32.Parse(number);
                phone[x] = phoneNumber;
                x++;
            }
            x = 0;
            foreach (string number in split.Split(config.AppSettings.Settings["Card"].Value))
            {
                int cardNumber = Int32.Parse(number);
                card[x] = cardNumber;
                x++;
            }

            
            user.UserName = config.AppSettings.Settings["Username"].Value;
            user.Password = config.AppSettings.Settings["Password"].Value;
            user.Name = config.AppSettings.Settings["Name"].Value;
            user.Email = new MailAddress(config.AppSettings.Settings["Email"].Value);
            user.Address = config.AppSettings.Settings["Address"].Value;
            user.Balance = Int32.Parse(config.AppSettings.Settings["Balance"].Value);
            user.Win = Int32.Parse(config.AppSettings.Settings["Win"].Value);
            user.Lose = Int32.Parse(config.AppSettings.Settings["Lose"].Value);
            user.Player.Score = Int32.Parse(config.AppSettings.Settings["PlayerScore"].Value);
            user.Player.Aces = Int32.Parse(config.AppSettings.Settings["PlayerAce"].Value);
            user.Dealer.Score = Int32.Parse(config.AppSettings.Settings["DealerScore"].Value);
            user.Dealer.Score = Int32.Parse(config.AppSettings.Settings["DealerScore"].Value);


            user.Phone = phone;
            user.Card = card;

            int cardCount = Int32.Parse(config.AppSettings.Settings["PlayerCardCount"].Value);
         
            for (x = 0; x < cardCount; x++)
            {
                user.Player.CardList.Add(config.AppSettings.Settings["PlayerCard" + x].Value);
            }

            cardCount = Int32.Parse(config.AppSettings.Settings["DealerCardCount"].Value);
            for (x = 0; x < cardCount; x++)
            {
                user.Dealer.CardList.Add(config.AppSettings.Settings["DealerCard" + x].Value);
            }
      


            RefToMenu.LoadText();
            this.Close();
        }
    }
}