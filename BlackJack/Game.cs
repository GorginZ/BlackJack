using System;
using System.Collections.Generic;

namespace BlackJack
{
  public class Game
  {
    private Deck _deck = new Deck();

    //Revisit this players list, do we need a list? (think about number of players)
    private Player _humanPlayer { get; }
    private Player _aiDealer { get; }


    public Game(Player humanPlayer, Player aiDealer)
    {
      _humanPlayer = humanPlayer;
      _aiDealer = aiDealer;
      ShuffleDeck();
      DealFirstHandToPlayer(_humanPlayer);
    }

    private void ShuffleDeck()
    {
      _deck.Shuffle();
    }

    private void DealFirstHandToPlayer(Player player)
    {
      player.Hand.Add(_deck.Draw());
      player.Hand.Add(_deck.Draw());
    }

    public void Hit()
    {
      _humanPlayer.DrawCard(_deck);
    }

    public bool HumanPlayerIsBust()
    {
      return _humanPlayer.GetHandValue() > 21;
    }

    public bool HumanPlayerIsBlackjack()
    {
      return _humanPlayer.GetHandValue() == 21 && _humanPlayer.Hand.Count == 2;
    }

    public int GetPlayerHandValue()
    {
      return _humanPlayer.GetHandValue();
    }

    public string GetPlayerHandAsString()
    {
      return _humanPlayer.GetHandAsString();
    }

  }
}