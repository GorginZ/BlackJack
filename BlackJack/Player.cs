
using System.Collections.Generic;
using System.Linq;

namespace BlackJack
{
  public class Player
  {
    public Hand Hand { get; } = new Hand();
    public Player()
    {

    }
    public void Hit(Deck deck)
    {
      var drawnCard = deck.Draw();
      Hand.AddCard(drawnCard);
    }

    public int GetHandValue()
    {
      return Hand.CalculateValue();
    }
  }
}