using Xunit;

namespace BlackJack.Tests
{
  public class GameTests
  {
    [Fact]
    public void ShouldDealFirstTwoCardsToPlayer()
    {
      var game = new Game();

      game.DealFirstHandToPlayer(game.Player1);

      const int expectedPlayer1HandCount = 2;
      var actualPlayer1HandCount = game.Player1.Hand.Cards.Count;

      Assert.Equal(expectedPlayer1HandCount, actualPlayer1HandCount);
    }
  }
}