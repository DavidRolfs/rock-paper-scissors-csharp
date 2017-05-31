using Nancy;
using System.Collections.Generic;
using System.Diagnostics;

namespace Object.Objects
{
  public class Object
  {
    private string _player1;
    private string _player2;

    public Object(string userInput1, string userInput2)
    {
      _player1 = userInput1;
      _player2 = userInput2;
    }
    public string Compare()
    {
      _player1 = _player1.ToLower();
      _player2 = _player2.ToLower();

      if(_player1 == _player2)
      {
        return "DRAW";
      }
      else if (_player1 == "rock")
      {
        if(_player2 == "scissors")
        {
          return _player1;
        }
        else
        {
          return _player2;
        }
      }
      else if(_player1 == "scissors")
      {
        if(_player2 == "rock")
        {
          return _player2;
        }
        else
        {
          return _player1;
        }
      }
      else if(_player1 == "paper")
      {
        if(_player2 == "rock")
        {
          return _player1;
        }
        else
        {
          return _player2;
        }
      }
      else
      {
        return "error";
      }
    }
  }
}
