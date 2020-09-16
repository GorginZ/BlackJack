using Xunit;
using System.Linq;

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
            var actualHandCount = player.Hand.Count;

            Assert.Equal(expectedHandCount, actualHandCount);

        }

    }
}