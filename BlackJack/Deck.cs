using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack
{
    public class Deck
    {
        public List<Card> Cards {get; }  = new List<Card>();

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


        public void Shuffle()
        {  
            var rng = new Random();
            var currentIndex = Cards.Count;  
            while (currentIndex > 1) {  
                currentIndex--;  
                var randomIndex = rng.Next(currentIndex + 1);  
                var randomCard = Cards[randomIndex];  
                Cards[randomIndex] = Cards[currentIndex];  
                Cards[currentIndex] = randomCard;  
            }  
        }

        public Card Draw()
        {
            var cardDrawn = Cards.Last();
            Cards.RemoveAt(Cards.Count - 1);
            return cardDrawn;
        }

    }
}