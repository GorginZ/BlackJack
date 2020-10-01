using Xunit;
using System.Linq;
using System.Collections.Generic;

namespace BlackJack.Tests
{
    public class PlayerTests
    {
        [Fact]
        public void CanDrawCardIntoHand()
        {
            var player = new Player();
            var deck = new Deck();

            player.Hit(deck);

            const int expectedHandCount = 1;
            var actualHand = player.Hand.Cards;

            Assert.Equal(expectedHandCount, actualHand.Count);

        }

    }
}