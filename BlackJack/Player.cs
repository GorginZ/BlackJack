
using System.Collections.Generic;
using System.Linq;

namespace BlackJack
{
  public class Player
  {
    public List<Card> Hand { get; } = new List<Card>();
    public Player()
    {

    }

    public void Hit(Deck deck)
    {
      var drawnCard = deck.Draw();
      Hand.Add(drawnCard);
    }

    public int GetHandValue()
    {
      var value = 0;
      var acesInHand = new List<Card>();

      foreach (var card in Hand)
      {
        if (card.Rank == Rank.Jack || card.Rank == Rank.Queen || card.Rank == Rank.King)
        {

          value += 10;
        }
        else if (card.Rank == Rank.Ace)
        {
          acesInHand.Add(card);
        }
        else 
        {
          value += (int)card.Rank;
        }
      }

      value += AddAces(acesInHand, value);
      return value;
    }

    public int AddAces(List<Card> acesInHand, int valueBeforeAces)
    {

      var valueOfAces = 0;
      foreach (var card in acesInHand)
      {
        valueOfAces = valueBeforeAces <= 10 ? (valueOfAces += 11) : (valueOfAces += 1);
      }
      return valueOfAces;
    }




  }
}