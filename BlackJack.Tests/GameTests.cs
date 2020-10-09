using Xunit;

namespace BlackJack.Tests
{
  public class GameTests
  {
    [Fact]
    public void NewGameShouldDealFirstTwoCardsToPlayer()
    {
      var game = new Game();

      const int expectedPlayer1HandCount = 2;
      var actualPlayer1HandCount = game.players[0].Hand.Cards.Count;

      Assert.Equal(expectedPlayer1HandCount, actualPlayer1HandCount);
    }

    [Fact]
    public void StayingEndsHumanPlayerTurnAndSwitchesToDealer_DoesNotDrawCard()
    {
      var game = new Game();

      game.ProcessNextAction(NextAction.Stay);

      const int expectedPlayer1HandCount = 2;
      var actualPlayer1HandCount = game.players[0].Hand.Cards.Count;
      const int expectedActivePlayerIndex = 1;
      var actualActivePlayerIndex = game.activePlayerIndex;

      Assert.Equal(expectedPlayer1HandCount, actualPlayer1HandCount);
      Assert.Equal(expectedActivePlayerIndex, actualActivePlayerIndex);
    }
  }
}