using System;
using System.Collections.Generic;
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
      var actualPlayer1HandCount = game.HumanPlayer.Hand.Cards.Count;

      Assert.Equal(expectedPlayer1HandCount, actualPlayer1HandCount);
    }

    [Fact]
    public void ProcessStayActionDoesNotDrawCardStaysPlayer()
    {
      var game = new Game();

      game.ProcessHumanPlayerAction(NextAction.Stay);

      const int expectedPlayer1HandCount = 2;
      var actualPlayer1HandCount = game.HumanPlayer.Hand.Cards.Count;

      Assert.True(game.HumanPlayer.HasStayed == true);
      Assert.Equal(expectedPlayer1HandCount, actualPlayer1HandCount);
    }

    [Fact]
    public void ProcessHitActionDrawsCard()
    {
      var game = new Game();

      game.ProcessHumanPlayerAction(NextAction.Hit);

      const int expectedPlayer1HandCount = 3;
      var actualPlayer1HandCount = game.HumanPlayer.Hand.Cards.Count;

      Assert.Equal(expectedPlayer1HandCount, actualPlayer1HandCount);
  
    }

    [Fact]
    public void ProcessingInvalidActionThrowsInvalidOperationException()
    {
      var game = new Game();

      var ex = Assert.Throws<InvalidOperationException>(() => game.ProcessHumanPlayerAction(NextAction.Invalid));

      Assert.Equal("Next Action was invalid", ex.Message);
    }

    public void PlayerBustsWhenHandValueExceeds21()
    {
      var game = new Game();
   






  }

  }
}