using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBlackJack
{
    class CardStore
    {
        //These are the total cards drawn thus far (can't differentiate between hand
        private static List<Card> cardList = new List<Card>();
        private static Dictionary<string, Tuple<int, int>> cardDictionary = new Dictionary<string, Tuple<int, int>>();

        public CardStore()
        {

        }

        public void DrawCard()
        {
            // creat a brand new unique card
            Card card = new Card();

            // add the card to the list of recent cards
            cardList.Add(card);

            // add the card to the dictionary of recent cards
            Tuple<int, int> tmp = new Tuple<int, int>(card.GetSuit(), card.GetValue());
            cardDictionary.Add(card.GetName(), tmp);

            //print out this card's name as a test
            Console.WriteLine(card.GetName());

            //best way to differentiate between players is to pass in a value and set that value as a key to a separate dictionary perhaps
        }

        // return a dictionary of recently used cards
        public static Dictionary<string, Tuple<int, int>> GetCardDictionary()
        {
            return cardDictionary;
        }

        // return a list of recently used cards
        public static List<Card> GetCardList()
        {
            return cardList;
        }
    }
}
