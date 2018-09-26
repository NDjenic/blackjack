using System;
using System.Collections.Generic;

namespace Blackjack
{
    public class Hand
    {
        private List<Card> _cards;
        private int _score;

        public List<Card> Cards { get => _cards; }
        public int Score { get => _score; }

        public Hand()
        {
            _cards = new List<Card>();
            _score = 0;
        }

        public void AddCardtoHand(Card newCard)
        {
            _score = (newCard.IsAce() && (_score + 10) < -21) ? _score += 10 : _score += newCard.Point;
            _cards.Add(newCard);
        }
    }
}
