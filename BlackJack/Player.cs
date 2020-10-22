
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
  public class Player
  {
    public Hand Hand { get; set; } = new Hand();
    public bool HasBust { get; set; } = false;
    public bool HasStayed { get; set; } = false;
  
  public void Hit(Deck deck)
  {
    var drawnCard = deck.Draw();
    Hand.AddCard(drawnCard);
  }

  public int GetHandValue()
  {
    return Hand.CalculateValue();
  }

//to do move GetHandAsString - static formatter class as potential solution.
  public string GetHandAsString()
  {
    var cardStrings = new List<string>();

    foreach (var card in Hand.Cards)
    {
      var rankAsString = ((int)card.Rank >= 2 && (int)card.Rank <= 10) ? ((int)card.Rank).ToString() : $"'{card.Rank.ToString().ToUpper()}'";
      var suitAsString = $"'{card.Suit.ToString().ToUpper()}'";


      var cardString = $"[{rankAsString}, {suitAsString}]";
      cardStrings.Add(cardString);
    }

    return $"[{string.Join(", ", cardStrings)}]";
  }
}
}