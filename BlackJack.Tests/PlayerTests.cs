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
            var actualHandCount = player.Hand.Count;

            Assert.Equal(expectedHandCount, actualHandCount);

        }

        [Theory]
        [MemberData(nameof(InputData))]
        public void CanCalculateCorrectValueOfHand(List<Card> hand, int expected)
        {
            var player = new Player();
            player.Hand.AddRange(hand);
            
            var actual = player.GetHandValue();

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
        
        // [Theory]
        // [MemberData(nameof(InputData))]
        // //[Trait("Category", "Unit")]
        // public void UserHasWon_Given4BlackPegs_ShouldReturnTrue(List<string>keyPegs, bool expectedResult)
        // {
        //     _decodingBoard.UpdateKeyPegs(keyPegs);
        //     var actualResult = _winnerFinder.UserHasWon(_decodingBoard);
        //     Assert.Equal(expectedResult, actualResult);
        // }

        

    }
}