using System;
using System.Collections.Generic;

namespace BlackJack
{
  public class Game
  {
    private Deck _deck = new Deck();

    //Revisit this players list, do we need a list? (think about number of players)
    public Player HumanPlayer { get; }
    public Player AIDealer { get; }


    public Game()
    {
      HumanPlayer = new Player();
      AIDealer = new Player();
      ShuffleDeck();
      DealFirstHandToPlayer(HumanPlayer);
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

    public void ProcessHumanPlayerAction(NextAction nextAction)
    {
      if (nextAction == NextAction.Hit)
      {
        HumanPlayer.Hit(_deck);
        ApplyBustRule(HumanPlayer);
      }
      else if (nextAction == NextAction.Stay)
      {
        HumanPlayer.HasStayed = true;

      }
      else
      {
        throw new InvalidOperationException("Next Action was invalid");

      }
    }

    private void ApplyBustRule(Player player)
    {
      if (player.GetHandValue() > 21)
      {
        player.HasBust = true;
      }
    }

  }
}