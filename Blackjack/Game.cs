using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    public class Game
    {
        private bool _isGameEnded, _hasPlayerWon;
        private Hand _playerHand, _dealerHand;
        private Deck _gameDeck;

        public Hand PlayerHand { get => _playerHand; }
        public Hand DealerHand { get => _dealerHand; }
        public bool IsGameEnded { get => _isGameEnded; }
        public bool HasPlayerWon { get => _hasPlayerWon; }

        public Game()
        {
            _gameDeck = new Deck();
            _dealerHand = new Hand();
            _playerHand = new Hand();
            _gameDeck.ShuffleDeck();
        }

        #region Game Functionalities

        public void DealStartingCards(Hand hand)
        {
            hand.AddCardtoHand(_gameDeck.GetNextCard());
            hand.AddCardtoHand(_gameDeck.GetNextCard());
        }

        public void Stay()
        {
            _isGameEnded = true;
        }

        public void Hit()
        {
            PlayerHand.AddCardtoHand(_gameDeck.GetNextCard());
            if(PlayerHand.Score>=21)
            {
                _isGameEnded = true;
            }
        }

        public void CheckGame()
        {
            if (_isGameEnded)
            {
                //If the player's score is greater than 21 = Lose
                if (_dealerHand.Score > 21)
                {
                    _hasPlayerWon = true;
                }
                else if (PlayerHand.Score <= 21 && PlayerHand.Score > _dealerHand.Score)
                {
                    _hasPlayerWon = true;
                }
                else if (_dealerHand.Score == PlayerHand.Score)
                {
                    _hasPlayerWon = false;
                }
            }
        }

        #endregion region Game Functionalities
    }
}
