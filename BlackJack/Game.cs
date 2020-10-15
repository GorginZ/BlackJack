using System;
using System.Collections.Generic;

namespace BlackJack
{
  public class Game
  {
    private Deck _deck = new Deck();

    //Revisit this players list, do we need a list? (think about number of players)
    public List<Player> players { get; } = new List<Player>();
    public int activePlayerIndex { get; private set; }

    public Game()
    {
      var player1 = new Player();
      var dealer = new Player();
      players.Add(player1);
      players.Add(dealer);
      activePlayerIndex = 0;
      ShuffleDeck();
      DealFirstHandToPlayer(players[0]);
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
        players[activePlayerIndex].Hit(_deck);
      }
      else
      {
        activePlayerIndex = 1;

      }
      throw new InvalidOperationException("Next Action was invalid");
    }

  }
}