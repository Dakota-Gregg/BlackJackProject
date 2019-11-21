using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Hand
    {
        private int score;
        private int aceCount;
        private List<string> cardList = new List<string>();

        public Hand()
        {
            this.score = 0;
            this.aceCount = 0;
        }

        public int Score
        {
            get
            {
                return this.score;
            }
            set
            {
                this.score = value;
            }
        }

        public int Aces
        {
            get
            {
                return this.aceCount;
            }
            set
            {
                this.aceCount = value;
            }
        }

        public List<string> CardList
        {
            get
            {
                return this.cardList;
            }
            set
            {
                this.cardList = value;
            }
        }

        public void decreaseAces()
        {
            this.aceCount--;
        }

        public void DrawCard(CardStore deck)
        {
            Card card = deck.DrawCard();
            cardList.Add(card.GetImage());
            
            
            int value = card.GetValue();
            
            if (value >= 10)
            {
                value = 10;
            }
            else if(value == 0)
            {
                value = 11;
                this.aceCount++;
            }
            else
            {
                value++;
            }
          
            this.score += value;

        }
        public void reset()
        {
            cardList.Clear();

        }

    }
}
