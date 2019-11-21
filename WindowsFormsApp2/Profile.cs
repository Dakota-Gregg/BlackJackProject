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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }
        public FormPlayGame RefToMenu { get; set; }

        public User user { get; set; }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.RefToMenu.LoadText();
            this.RefToMenu.Show();
            this.Close();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            LoadText();

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormEditProfile profileCreate = new FormEditProfile();
            profileCreate.user = this.user;
            profileCreate.RefToMenu = this;
            profileCreate.Show();
            this.Hide();
        }

        public void LoadText()
        {
            if (user.UserName == "Guest" && user.Email.ToString() == "Guest@test.com")
            {
                buttonEdit.Enabled = false;
            }
            else
            {
                buttonEdit.Enabled = true;
            }
            labelUserText.Text = user.UserName;
            labelNameText.Text = user.Name;
            labelEmailText.Text = (user.Email.ToString() == "Guest@test.com")? null :user.Email.ToString();
            labelPhoneText.Text = (user.Phone[0] == 0)? null: String.Concat(user.Phone[0], '-', user.Phone[1], '-', user.Phone[2]);
            labelCardText.Text = (user.Card[0] == 0) ? null : user.Card[3].ToString();
            labelAddressText.Text = user.Address;
        }
    }
}
