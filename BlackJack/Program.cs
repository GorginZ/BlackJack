using System;

namespace BlackJack
{
  class Program
  {

    static void Main(string[] args)
    {
      var humanPlayer = new Player();
      var aiDealer = new Player();

      var game = new Game(humanPlayer, aiDealer);

      Console.WriteLine("Hello, Welcome to the casino!");
      NextAction nextAction;

      do
      {
        Console.WriteLine($"You currently at {game.GetPlayerHandValue()}");
        //TODO: Add some logic to show if it's a soft hand
        Console.WriteLine($"with the hand {game.GetPlayerHandAsString()}");
        Console.WriteLine("Hit or stay? (Hit = 1, Stay = 0)");
        nextAction = GetNextAction();
        if(nextAction == NextAction.Hit)
        {
          game.Hit();
        }
      } while (!game.HumanPlayerIsBlackjack() && !game.HumanPlayerIsBust() && nextAction != NextAction.Stay);

      if(game.HumanPlayerIsBlackjack())
      {
        Console.WriteLine("Blackjack!");
        Console.WriteLine($"with the hand {game.GetPlayerHandAsString()}");
      }

      if (game.HumanPlayerIsBust())
      {
        Console.WriteLine("Bust!");
        Console.WriteLine($"with the hand {game.GetPlayerHandAsString()}");
      }
    }
    private static NextAction GetNextAction()
    {
      var input = Console.ReadLine();
      NextAction nextAction;
      while (!InputParser.TryParse(input, out nextAction))
      {
        Console.WriteLine("Invalid input! Please enter 1 to hit or 0 to stay...");
        input = Console.ReadLine();
      }
      return nextAction;
    }

  }
}
