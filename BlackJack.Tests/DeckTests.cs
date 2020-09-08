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

    }
}
