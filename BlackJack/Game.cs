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

    public void ProcessHumanPlayerAction(NextAction nextAction)
    {
      if (nextAction == NextAction.Hit)
      {
        _humanPlayer.Hit(_deck);
        ApplyBustRule(_humanPlayer);
      }
      else if (nextAction == NextAction.Stay)
      {
        _humanPlayer.HasStayed = true;

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
        player.HasBusted = true;
      }
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