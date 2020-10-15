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
      var actualPlayer1HandCount = game.Players[0].Hand.Cards.Count;

      Assert.Equal(expectedPlayer1HandCount, actualPlayer1HandCount);
    }

    [Fact]
    public void ProcessStayActionEndsHumanPlayerTurnAndSwitchesToDealer_DoesNotDrawCard()
    {
      var game = new Game();

      game.ProcessNextAction(NextAction.Stay);

      const int expectedPlayer1HandCount = 2;
      var actualPlayer1HandCount = game.Players[0].Hand.Cards.Count;
      const int expectedActivePlayerIndex = 1;
      var actualActivePlayerIndex = game.activePlayerIndex;

      Assert.Equal(expectedPlayer1HandCount, actualPlayer1HandCount);
      Assert.Equal(expectedActivePlayerIndex, actualActivePlayerIndex);
    }

    [Fact]
    public void ProcessHitActionDrawsCardDoesNotEndTurn()
    {
      var game = new Game();

      game.ProcessNextAction(NextAction.Hit);

      const int expectedPlayer1HandCount = 3;
      var actualPlayer1HandCount = game.Players[0].Hand.Cards.Count;
      const int expectedActivePlayerIndex = 0;
      var actualActivePlayerIndex = game.activePlayerIndex;

      Assert.Equal(expectedPlayer1HandCount, actualPlayer1HandCount);
      Assert.Equal(expectedActivePlayerIndex, actualActivePlayerIndex);
    }

    [Fact]
    public void ProcessingInvalidActionThrowsInvalidOperationException()
    {
      var game = new Game();

      var ex = Assert.Throws<InvalidOperationException>(() => game.ProcessNextAction(NextAction.Invalid));

      Assert.Equal("Next Action was invalid", ex.Message);
    }

    public void PlayerBustsWhenHandValueExceeds21()
    {
      var game = new Game();

  



  }

  }
}