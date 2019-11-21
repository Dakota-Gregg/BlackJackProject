using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace WindowsFormsApp2
{
    public class User
    {
        private string userName;
        private string name;
        private MailAddress email;
        private string password;
        private string address;
        private int[] phone = new int[3];
        private int[] card = new int[4];
        private double balance;
        private int win;
        private int lose;

        private Hand player = new Hand();
        private Hand dealer = new Hand();

        public User()
        {
            this.userName = "Guest";
            this.name = "";
            this.email = new MailAddress("Guest@test.com");
            this.password = "";
            this.address = "";
            this.balance = 20.0;
            this.win = 0;
            this.lose = 0;

            
        }

        public string UserName
        {
            get
            {
                return this.userName;
            }
            set
            {
                this.userName = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public MailAddress Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }

        public int[] Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                for(int i = 0; i < 3; i++)
                {
                    this.phone[i] = value[i];
                }
            }
        }

        public int[] Card
        {
            get
            {
                return this.card;
            }
            set
            {
                for (int i = 0; i < 4; i++)
                {
                    this.card[i] = value[i];
                }
            }
        }

        public double Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public int Win
        {
            get
            {
                return this.win;
            }
            set
            {
                this.win = value;
            }
        }

        public int Lose
        {
            get
            {
                return this.lose;
            }
            set
            {
                this.lose = value;
            }
        }

        public Hand Player
        {
            get
            {
                return this.player;
            }
            set
            {
                this.player = value;
            }
        }

        public Hand Dealer
        {
            get
            {
                return this.dealer;
            }
            set
            {
                this.dealer = value;
            }
        }
    }

}
