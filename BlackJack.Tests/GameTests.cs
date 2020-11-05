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
      var humanPlayer = new Player();
      var aiDealer = new Player();

      var game = new Game(humanPlayer, aiDealer);

      const int expectedPlayer1HandCount = 2;
      var actualPlayer1HandCount = humanPlayer.Hand.Count;

      Assert.Equal(expectedPlayer1HandCount, actualPlayer1HandCount);
    }

    [Fact]
    public void ProcessStayActionDoesNotDrawCardStaysPlayer()
    {
      var humanPlayer = new Player();
      var aiDealer = new Player();

      var game = new Game(humanPlayer, aiDealer);

      game.ProcessHumanPlayerAction(NextAction.Stay);

      const int expectedPlayer1HandCount = 2;
      var actualPlayer1HandCount = humanPlayer.Hand.Count;

      Assert.True(humanPlayer.HasStayed == true);
      Assert.Equal(expectedPlayer1HandCount, actualPlayer1HandCount);
    }

    [Fact]
    public void ProcessHitActionDrawsCard()
    {
      var humanPlayer = new Player();
      var aiDealer = new Player();

      var game = new Game(humanPlayer, aiDealer);

      game.ProcessHumanPlayerAction(NextAction.Hit);

      const int expectedPlayer1HandCount = 3;
      var actualPlayer1HandCount = humanPlayer.Hand.Count;

      Assert.Equal(expectedPlayer1HandCount, actualPlayer1HandCount);
  
    }

    [Fact]
    public void ProcessingInvalidActionThrowsInvalidOperationException()
    {
      var humanPlayer = new Player();
      var aiDealer = new Player();

      var game = new Game(humanPlayer, aiDealer);

      var ex = Assert.Throws<InvalidOperationException>(() => game.ProcessHumanPlayerAction(NextAction.Invalid));

      Assert.Equal("Next Action was invalid", ex.Message);
    }

    public void PlayerBustsWhenHandValueExceeds21()
    {
      var humanPlayer = new Player();
      var aiDealer = new Player();
      var game = new Game(humanPlayer, aiDealer);

      humanPlayer.Hand = new List<Card>{new Card(Suit.Hearts, Rank.King), new Card(Suit.Spades, Rank.Ace)};
    }


    






  }

  }
}