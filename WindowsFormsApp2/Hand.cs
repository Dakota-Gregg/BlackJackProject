using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Hand
    {
        private int score;
        private int aceCount;
        private List<string> cardList = new List<string>();

        public Hand()
        {
            this.score = 0;
            this.aceCount = 0;
        }

        public int getScore()
        {
            return this.score;
        }

        public void setScore(int value)
        {
            this.score = value;
        }

        public int getAces()
        {
            return this.aceCount;
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
        public List<string> GetCardList()
        {
            
            return this.cardList;
        }
        public void reset()
        {
            cardList.Clear();

        }

    }
}
