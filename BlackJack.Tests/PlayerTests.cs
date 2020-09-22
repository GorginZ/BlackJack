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

        [Theory]
        [InlineData(Rank.King, Rank.Five, Rank.Two, 17)]
        [InlineData(Rank.Four, Rank.Six, Rank.Three, 13)]
        [InlineData(Rank.Ace, Rank.Four, Rank.Two, 17)]
        [InlineData(Rank.Ace, Rank.Ten, Rank.Three, 14)]
        public void CanGetValueOfHand(Rank card1Rank, Rank card2Rank, Rank card3Rank, int expectedValue)
        {
            var player = new Player();
            var card1 = new Card(Suit.Hearts, card1Rank);
            var card2 = new Card(Suit.Hearts, card2Rank);
            var card3 = new Card(Suit.Hearts, card3Rank);


            player.Hand.AddRange(new Card[]{card1, card2, card3});
            
            var actualValue = player.GetHandValue();

            Assert.Equal(expectedValue, actualValue);
        }

    }
}