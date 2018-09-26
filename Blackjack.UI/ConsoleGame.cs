using System;
using System.Collections.Generic;
using System.Text;
using Blackjack;

namespace Blackjack.UI
{
    public class ConsoleGame
    {
        private Game consoleGame;
        public ConsoleGame()
        {
            consoleGame = new Game();
        }
        #region Console Functionalities

        public void StartNewConsoleGame()
        {
            consoleGame = new Game();
            Console.WriteLine("Welcome to Blackjack");

            consoleGame.DealStartingCards(consoleGame.DealerHand);
            ShowCardsConsole(false);

            consoleGame.DealStartingCards(consoleGame.PlayerHand);
            ShowCardsConsole(true);

            while (!consoleGame.IsGameEnded)
            {
                HitOrStay();

            }

            consoleGame.CheckGame();
            Console.WriteLine();
            if (consoleGame.HasPlayerWon)
            {
                Console.WriteLine("--- You Win ---");
            }
            else
            {
                Console.WriteLine("--- Dealer Wins ---");
            }
        }

        private void ShowCardsConsole(bool player)
        {
            string actor;
            Hand hand;
            if (player)
            {
                actor = "Player";
                hand = consoleGame.PlayerHand;
            }
            else
            {
                actor = "Dealer";
                hand = consoleGame.DealerHand;
            }

            Console.WriteLine("\n" + actor + " Cards are:\n");
            foreach (Card card in hand.Cards)
            {
                Console.WriteLine(card.ToString());
            }
            Console.WriteLine(actor + " Points: " + hand.Score);
        }

        private void HitOrStay()
        {
            Console.Write("\nPress H to hit, S to stay:\t");
            char input = Console.ReadKey().KeyChar;
            if (input.Equals('h'))
            {
                consoleGame.Hit();
                Console.Clear();
                ShowCardsConsole(false);
                ShowCardsConsole(true);
            }
            else if (input.Equals('s'))
            {
                consoleGame.Stay();
            }
        }

        #endregion Console Functionalities
    }
}
