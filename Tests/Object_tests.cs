using Xunit;
using System;
using System.Collections.Generic;

namespace Object.Objects
{
  public class ObjectTests
  {

    [Fact]
    public void compare_turnLettersLowerCase_true()
    {
      Object newObject = new Object("rOcK", "SciSsoRs");

      Assert.Equal("rock", newObject.Compare());
    }
    [Fact]
    public void compare_compareIfInputsAreTheSame_DRAW()
    {
      Object newObject = new Object("rOcK", "rOcK");

      Assert.Equal("DRAW", newObject.Compare());
    }
    [Fact]
    public void compare_ifRockWins_rock()
    {
      Object newObject = new Object("rOcK", "SciSsors");

      Assert.Equal("rock", newObject.Compare());
    }
    [Fact]
    public void compare_ifScissorsWin_scissors()
    {
      Object newObject = new Object("ScisSorS", "Paper");

      Assert.Equal("scissors", newObject.Compare());
    }
    [Fact]
    public void compare_ifPaperWins_paper()
    {
      Object newObject = new Object("pAper", "rock");

      Assert.Equal("paper", newObject.Compare());
    }
    //////////////////////////
    [Fact]
    public void compare_ifPlayer2RockWins_rock()
    {
      Object newObject = new Object("ScisSors", "rOck");

      Assert.Equal("rock", newObject.Compare());
    }
    [Fact]
    public void compare_ifPlayer2ScissorsWin_scissors()
    {
      Object newObject = new Object("Paper", "scIsSors");

      Assert.Equal("scissors", newObject.Compare());
    }
    [Fact]
    public void compare_ifPlayer2PaperWins_paper()
    {
      Object newObject = new Object("rOcK", "pAper");

      Assert.Equal("paper", newObject.Compare());
    }
  }
}
