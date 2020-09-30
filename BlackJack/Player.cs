
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
      var handWithoutAces = GetHandWithoutAces();
      var acesInHand = GetAcesFromHand();
      var runningValue = SumNonAces(handWithoutAces);
      runningValue += SumAces(acesInHand, runningValue);
      return runningValue;
    }

    private List<Card> GetHandWithoutAces()
    {
      return Hand.Where(card => card.Rank != Rank.Ace).ToList();
    }

    private List<Card> GetAcesFromHand()
    {
      return Hand.Where(card => card.Rank == Rank.Ace).ToList();
    }
    private bool IsFaceCard(Card card)
    {
      return card.Rank == Rank.Jack || card.Rank == Rank.Queen || card.Rank == Rank.King;
    }

    private int SumNonAces(List<Card> handWithoutAces)
    {
      var runningValue = 0;
      foreach (var card in handWithoutAces)
      {
        if (IsFaceCard(card))
        {
          runningValue += 10;
        }
        else
        {
          runningValue += (int)card.Rank;
        }
      }
      return runningValue;
    }
    public int SumAces(List<Card> acesInHand, int valueBeforeAces)
    {
      return acesInHand.Aggregate(0, (currentValue, card) => valueBeforeAces <= 10 ? (currentValue + 11) : (currentValue + 1));
    }
  }
}