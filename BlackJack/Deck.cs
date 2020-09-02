using System.Collections.Generic;

namespace BlackJack
{
    public class Deck
    {
        public List<Card> Cards { get; } = new List<Card>();

        public Deck()
        {
            foreach( Suit suit in Suit.GetValues(typeof(Suit)) )
            {
                foreach( Rank rank in Rank.GetValues(typeof(Rank)) )
                {
                    Cards.Add(new Card(suit, rank));
                }
            }
        }
    }
}