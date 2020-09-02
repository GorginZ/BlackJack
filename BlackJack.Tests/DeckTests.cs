using System;
using Xunit;

namespace BlackJack.Tests
{
    public class DeckTests
    {
        [Fact]
        public void NewDeckHas52Cards()
        {
            var deck = new Deck();

            const int expectedCount = 52;
            var actualCount = deck.Cards.Count;
            Assert.Equal(expectedCount, actualCount);
        }

//note for next time - see if we can do this with Linq
        public void NewDeckContainsUniqueCards()
        {
            var deck = new Deck();

            bool cardsAreUnique = true;



            for(int i = 0; i < deck.Cards.Count; i++)
            {
                for(int j = i + 1; j < deck.Cards.Count; j++)
                {
                    if (CardsAreEqual(deck.Cards[i], deck.Cards[j]))
                    {
                        cardsAreUnique = false;
                    }
                }
            }

        }

        private bool CardsAreEqual(Card card1, Card card2)
        {
            return card1.Rank == card2.Rank && card1.Suit == card2.Suit;
        }
    }
}
