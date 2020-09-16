using System;

namespace BlackJack
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var game = new Game();
        
            Console.WriteLine("Hello, Welcome to the casino!");
            game.ShuffleDeck();

            //TODO next session : Wrtie a test then implement
            game.DealFirstCards();
            //Console.WriteLine($"You currently at {player1.getHandValue();}");
        }

    }
}
