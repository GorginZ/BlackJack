
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

        public int GetHandValue()
        {
          var value = 0;

          foreach (var card in Hand)
          {
            if(card.Rank == Rank.Jack || card.Rank == Rank.Queen || card.Rank == Rank.King)
            {
              
              value += 10;
            } else
            {
              value += (int)card.Rank;
            }
          }
          return value;
        }
    }
}