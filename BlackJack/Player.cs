
using System.Collections.Generic;
using System.Linq;

namespace BlackJack
{
    public class Player
    {
      public List<Card> Hand { get; } = new List<Card>();
        public Player(){

        }

        public void Hit(Deck deck)
        {
          var drawnCard = deck.Draw();
          Hand.Add(drawnCard);
        }
    }
}