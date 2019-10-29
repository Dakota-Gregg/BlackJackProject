﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBlackJack
{
    public class Card
    {
        private int value;
        private int suit;
        private string name;

        public Card()
        {
            Calculate();
            CardName();

        }

        private void Calculate()
        {
            // import random number generator
            Random rand = new Random();

            //constants
            const int max = 52;
            const int min = 1;
            const int CardTypes = 13;

            //generate a random number in the deck
            numberGenerator:
            int randNum = rand.Next(min, max);

            //use that random number to generate a value and suit for the card
            int suit = randNum / CardTypes;
            int value = randNum % CardTypes;

            //Track recent cards so no duplicates are created
            Tuple<int, int> tmp = new Tuple<int, int>(suit, value);
            Dictionary<string, Tuple<int, int>> cardDictionary = CardStore.GetCardDictionary();
            if (cardDictionary.ContainsValue(tmp))
            {
                goto numberGenerator;
            }

            //If a new unique card is created store the values
            this.suit = suit;
            this.value = value;

        }

        private void CardName()
        {
            string name = "";

            //Give this card a meaningful name using the value and suit numbers
            switch (this.value)
            {
                case 0: name += "Ace of "; break;
                case 1: name += "Two of "; break;
                case 2: name += "Three of "; break;
                case 3: name += "Four of "; break;
                case 4: name += "Five of "; break;
                case 5: name += "Six of "; break;
                case 6: name += "Seven of "; break;
                case 7: name += "Eight of "; break;
                case 8: name += "Nine of "; break;
                case 9: name += "Ten of "; break;
                case 10: name += "Jack of "; break;
                case 11: name += "Queen of "; break;
                case 12: name += "King of "; break;
            }

            switch (this.suit)
            {
                case 0: name += "Clubs"; break;
                case 1: name += "Diamonds"; break;
                case 2: name += "Hearts"; break;
                case 3: name += "Spades"; break;
            }

            // If the length is null for some reason set the value to Joker as a joke (maybe we ran out of cards?)
            if(name.Length != 0)
            {
                this.name = name;
            }
            else
            {
                this.name = "Joker";
            }
        }

        // return this card's name
        public string GetName()
        {
            return this.name;
        }

        // return this card's suit number
        public int GetSuit()
        {
            return this.suit;
        }

        // return this card's value
        public int GetValue()
        {
            return this.value;
        }
    }
}
