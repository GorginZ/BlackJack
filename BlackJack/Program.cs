using System;

namespace BlackJack
{
  class Program
  {

    static void Main(string[] args)
    {
      var game = new Game();
      Console.WriteLine("Hello, Welcome to the casino!");
      NextAction nextAction;

      do
      {
        Console.WriteLine($"You currently at {game.Players[0].GetHandValue()}");
        Console.WriteLine($"with the hand {game.Players[0].GetHandAsString()}");
        Console.WriteLine("Hit or stay? (Hit = 1, Stay = 0)");
        nextAction = GetNextAction();
        game.ProcessNextAction(nextAction);
      } while (nextAction != NextAction.Stay);
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
