using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Blackjack
{
    public class Deck
    {
        //LIFO data structure.
        private Stack<Card> _deck;
        
        //Deck is created when class is instantiated.
        public Deck()
        {
            _deck = new Stack<Card>();
            string[] suits= { "Hearts", "Clubs", "Diamonds", "Spades" };
            string[] values = { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" }; //replace with enum?

            foreach(string suit in suits)
            {
                foreach(string value in values)
                {
                    _deck.Push(new Card(value, suit));
                }
            }
        }

        public void ShuffleDeck()
        {
            //Improved code, thanks to https://stackoverflow.com/questions/33643104/shuffling-a-stackt
            Card[] deckArray = _deck.ToArray(); //Store the deck elsewhere. Memoisation
            _deck.Clear();
            foreach (Card card in deckArray.OrderBy(s=> new Random().Next(0,52)))
            {
                _deck.Push(card);
            }
        }

        public void ShowDeck()
        {
            foreach(Card card in _deck)
            {
                Console.WriteLine(card.ToString());
            }
        }

        //Have to find a way to do a stack here.
        public Card GetNextCard()
        {
            if(_deck.Count>0)
            {
                return _deck.Pop();
            }
            return null;
        }
    }
}
