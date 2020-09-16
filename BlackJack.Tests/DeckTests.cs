using System;
using System.Linq;
using Xunit;

namespace BlackJack.Tests
{
    public class DeckTests
    {
        [Fact]
        public void NewDeckContains52UniqueCards()
        {
            var deck = new Deck();

            const int expectedDistinctCardCount = 52;
            var actualDistinctCardCount = deck.Cards.Distinct().Count();

            Assert.Equal(expectedDistinctCardCount, actualDistinctCardCount);
        }

        [Fact]
        public void DrawingRemovesCardFromDeck()
        {
            var deck = new Deck();
            var cardDrawn = deck.Draw();

            Assert.DoesNotContain(cardDrawn, deck.Cards);
            Assert.Equal(51, deck.Cards.Count);
        }

        [Fact]
        public void CanShuffle()
        {
            var deck1 = new Deck();
            var deck2 = new Deck();
            
            deck2.Shuffle();

            Assert.Equal(52, deck2.Cards.Count);
            Assert.NotEqual(deck1.Cards, deck2.Cards);
        }

    }
}
