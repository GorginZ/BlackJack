
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
  public class Player
  {
    public List<Card> Hand { get; set; } = new List<Card>();
  
  public void DrawCard(Deck deck)
  {
    var drawnCard = deck.Draw();
    Hand.Add(drawnCard);
  }

  public int GetHandValue()
  {
    return HandCalculator.Calculate(Hand);
  }

//to do move GetHandAsString - static formatter class as potential solution.
  public string GetHandAsString()
  {
    var cardStrings = new List<string>();

    foreach (var card in Hand)
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