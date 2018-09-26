using System;
using Blackjack;

namespace Blackjack.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleGame newGame = new ConsoleGame();
            bool playAgain = true;

            while (playAgain)
            {
                Console.Clear();
                newGame.StartNewConsoleGame();

                Console.Write("\nPlay Again Y/N:\t");
                char input=Console.ReadKey().KeyChar;
                if(input.Equals('n') || input.Equals('N'))
                {
                    playAgain = false;
                }
            }
        }
    }
}
