using System;
using System.Collections.Generic;

namespace BlackJack
{
  public class Game
  {
    private Deck _deck = new Deck();

    //Revisit this players list, do we need a list? (think about number of players)
    public List<Player> Players { get; } = new List<Player>();
    public int activePlayerIndex { get; private set; }

    public Game()
    {
      var player1 = new Player();
      var dealer = new Player();
      Players.Add(player1);
      Players.Add(dealer);
      activePlayerIndex = 0;
      ShuffleDeck();
      DealFirstHandToPlayer(Players[0]);
    }

    private void ShuffleDeck()
    {
      _deck.Shuffle();
    }

    private void DealFirstHandToPlayer(Player player)
    {
      player.Hand.AddCard(_deck.Draw());
      player.Hand.AddCard(_deck.Draw());
    }

    public void ProcessNextAction(NextAction nextAction)
    {
      if (nextAction == NextAction.Hit)
      {
        Players[activePlayerIndex].Hit(_deck);
      }
      else if (nextAction == NextAction.Stay)
      {
        activePlayerIndex = 1;

      }
      else
      {
        throw new InvalidOperationException("Next Action was invalid");

      }
    }

    public bool IsBust()
    {
      if (Players[activePlayerIndex].GetHandValue() > 21)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

  }
}