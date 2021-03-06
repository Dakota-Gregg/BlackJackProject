﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace WindowsFormsApp2
{
    public partial class FormCreateProfile : Form
    {
        private string EmptyError = "* Required Information *";
        private string NameError = "* Invalid Name *";
        private string LetterError = "* Name Requires at Least 5 Letters *";
        private string NumberError = "* Name Not Allowed Numbers *";
        private string EmailError = "* Email Not Valid *";
        private string PhoneError = "* Phone Number Not Valid *";
        private string CardError = "* Credit/Debit Card Not Valid *";
        private string AddressError = "* Address Not Valid *";
        private string PasswordError = "* Invalid Password *";
        private string PasswordMatchError = "* Passwords Do Not Match *";

        Regex invalid = new Regex(@"[^a-zA-Z0-9\.\@\!]");
        Regex letters = new Regex(@"[a-zA-Z]{5,}");
        Regex name = new Regex(@"[a-zA-z]");
        Regex numbers = new Regex(@"\d");
        Regex phone = new Regex(@"\b\d{3}\b");
        Regex card = new Regex(@"\b\d{4}\b");
        Regex ZIP = new Regex(@"\b\d{5}\b");
        Regex address = new Regex(@"(Dr.|Ave.|St.|Rd.|Blvd.|Ln.|Pkwy.|Cir.)", RegexOptions.IgnoreCase);
        Regex comma = new Regex(@",");

        static Profile menuForm = new Profile();

        public FormPlayGame RefToMenu { get; set; }

        public User user { get; set; }


        public FormCreateProfile()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (CheckValues())
            {
                this.RefToMenu.LoadText();
                this.RefToMenu.Show();
                this.Close();
            }
        }

        private void FormCreateProfile_Load(object sender, EventArgs e)
        {
            
        }

        private bool CheckValues()
        {
            bool test = false;
            bool userTest = false;
            bool nameTest = false;
            bool emailTest = false;
            bool phoneTest = false;
            bool addressTest = false;
            bool cardTest = false;
            bool passwordTest = false;

            if(textBoxUser.Text.Length == 0)
            {
                labelUserError.Text = EmptyError;
                labelUserError.Visible = true;
                userTest = false;
            }
            else if (invalid.IsMatch(textBoxUser.Text))
            {
                labelUserError.Text = NameError;
                labelUserError.Visible = true;
                userTest = false;
            }
            else if (!letters.IsMatch(textBoxUser.Text))
            {
                labelUserError.Text = LetterError;
                labelUserError.Visible = true;
                userTest = false;
            }
            else
            {
                user.UserName = textBoxUser.Text;
                labelUserError.Visible = false;
                userTest = true;

            }

            if (textBoxName.Text.Length == 0)
            {
                labelNameError.Text = EmptyError;
                labelNameError.Visible = true;
                nameTest = false;
            }
            else if (!name.IsMatch(textBoxName.Text))
            {
                labelNameError.Text = NameError;
                labelNameError.Visible = true;
                nameTest = false;
            }
            else if (numbers.IsMatch(textBoxName.Text))
            {
                labelNameError.Text = NumberError;
                labelNameError.Visible = true;
                nameTest = false;
            }
            else
            {
                user.Name = textBoxName.Text;
                labelNameError.Visible = false;
                nameTest = true;

            }

            if (textBoxEmail.Text.Length == 0)
            {
                labelEmailError.Text = EmptyError;
                labelEmailError.Visible = true;
                emailTest = false;
            }
            else if (invalid.IsMatch(textBoxEmail.Text))
            {
                labelEmailError.Text = NameError;
                labelEmailError.Visible = true;
                emailTest = false;
            }
            else
            {
                try
                {
                    MailAddress m = new MailAddress(textBoxEmail.Text);

                    user.Email = m;
                    labelEmailError.Visible = false;
                    emailTest = true;
                }
                catch (FormatException)
                {
                    labelEmailError.Text = EmailError;
                    labelEmailError.Visible = true;
                    emailTest = false;
                }
            }

            if (!(phone.IsMatch(textBoxPhone1.Text) && phone.IsMatch(textBoxPhone2.Text) && card.IsMatch(textBoxPhone3.Text)))
            {
                labelPhoneError.Text = PhoneError;
                labelPhoneError.Visible = true;
                phoneTest = false;
            }
            else
            {
                int[] phone = { Int32.Parse(textBoxPhone1.Text), Int32.Parse(textBoxPhone2.Text), Int32.Parse(textBoxPhone3.Text) };
                user.Phone = phone;
                labelPhoneError.Visible = false;
                phoneTest = true;
            }

            if (textBoxAddress.Text.Length == 0)
            {
                labelAddressError.Text = EmptyError;
                labelAddressError.Visible = true;
                addressTest = false;
            }
            else if (!(name.IsMatch(textBoxAddress.Text) && numbers.IsMatch(textBoxAddress.Text) && address.IsMatch(textBoxAddress.Text)))
            {
                labelAddressError.Text = AddressError;
                labelAddressError.Visible = true;
                addressTest = false;
            }
            else
            {
                labelAddressError.Visible = false;
                if (comboBoxStates.Text.Length == 0)
                {
                    labelStateError.Text = EmptyError;
                    labelStateError.Visible = true;
                    addressTest = false;
                }
                else
                {
                    if (!(ZIP.IsMatch(textBoxZip.Text)))
                    {
                        labelStateError.Text = EmptyError;
                        labelStateError.Visible = true;
                        addressTest = false;
                    }
                    else
                    {
                        user.Address = String.Concat(textBoxAddress.Text, ", ", comboBoxStates.Text, ", ", textBoxZip.Text);
                        labelStateError.Visible = false;
                        addressTest = true;
                    }
                }    
            }

            if (!(card.IsMatch(textBoxCard1.Text) && card.IsMatch(textBoxCard2.Text) && card.IsMatch(textBoxCard3.Text) && card.IsMatch(textBoxCard4.Text)))
            {
                labelCardError.Text = CardError;
                labelCardError.Visible = true;
                cardTest = false;
            }
            else
            {
                int[] card = { Int32.Parse(textBoxCard1.Text), Int32.Parse(textBoxCard2.Text), Int32.Parse(textBoxCard3.Text), Int32.Parse(textBoxCard4.Text) };
                user.Card = card;
                labelCardError.Visible = false;
                cardTest = true;
            }

            if (textBoxPassword.Text.Length == 0)
            {
                labelPasswordError.Text = EmptyError;
                labelPasswordError.Visible = true;
                passwordTest = false;
            }
            else if (invalid.IsMatch(textBoxPassword.Text))
            {
                labelPasswordError.Text = PasswordError;
                labelPasswordError.Visible = true;
                passwordTest = false;
            }
            else if (!(textBoxPassword.Text == textBoxPasswordConfirm.Text))
            {
                labelPasswordError.Text = PasswordMatchError;
                labelPasswordError.Visible = true;
                passwordTest = false;
            }
            else
            {
                user.Password = textBoxPassword.Text;
                labelPasswordError.Visible = false;
                passwordTest = true;
            }

            if (userTest && nameTest && emailTest && phoneTest && addressTest && cardTest && passwordTest)
            {
                test = true;
            }
            return test;
        }
    }
}
