using System.Collections.Generic;
using Xunit;

namespace BlackJack.Tests
{
    public class HandCalculatorTests
    {
        [Theory]
        [MemberData(nameof(InputData))]
        public void CanCalculateCorrectValueOfHand(List<Card> hand, int expected)
        {

            var actual = HandCalculator.Calculate(hand);
            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> InputData()
        {  yield return new object[]
            {
                new List<Card>() {new Card(Suit.Clubs, Rank.Ace), new Card(Suit.Hearts, Rank.Ten), new Card(Suit.Diamonds, Rank.Three)},
                14
            };
            yield return new object[]
            {
                new List<Card>() {new Card(Suit.Hearts, Rank.King), new Card(Suit.Clubs, Rank.Five), new Card(Suit.Spades, Rank.Two)},
                17
            };
            yield return new object[]
            {
                new List<Card>() {new Card(Suit.Spades, Rank.Four), new Card(Suit.Diamonds, Rank.Six), new Card(Suit.Clubs, Rank.Three)},
                13
            };
            yield return new object[]
            {
                new List<Card>() {new Card(Suit.Diamonds, Rank.Ace), new Card(Suit.Spades, Rank.Four), new Card(Suit.Hearts, Rank.Two), new Card(Suit.Clubs, Rank.Two)},
                19
            };
        }
    }
}