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
            var actualHand = player.Hand;

            Assert.Equal(expectedHandCount, actualHand.Count);

        }

        [Fact]
        public void CanGetHandAsString()
        {
            var player = new Player();
            player.Hand.Add(new Card(Suit.Hearts, Rank.King));
            player.Hand.Add(new Card(Suit.Spades, Rank.Five));

            const string expected = "[['KING', 'HEARTS'], [5, 'SPADES']]";
            var actual = player.GetHandAsString();

            Assert.Equal(expected, actual);
        }
    }
}