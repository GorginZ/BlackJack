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
            game.DealFirstHandToPlayer(game.Player1);
            Console.WriteLine($"You currently at {game.Player1.GetHandValue()}");
        }

    }
}
