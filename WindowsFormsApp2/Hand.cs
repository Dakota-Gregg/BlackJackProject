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

        public Hand()
        {
            this.score = 0;
        }

        public int getScore()
        {
            return this.score;
        }

        public void DrawCard(CardStore deck)
        {
            Card card = deck.DrawCard();
            int value = card.GetValue();

            if(value >= 10)
            {
                value = 10;
            }
            else if(value == 0)
            {
                value = 11;
            }
            else
            {
                value++;
            }

            this.score += value;
        }
    }
}
