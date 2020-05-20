using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Kata
{
  public string Rps(string p1, string p2)
  {
    var resultString = "";

    if (p1 == "scissors")
    {
      if (p2 == "scissors")
        resultString = "Draw!";
      else if (p2 == "rock")
        resultString = "Player 2 won!";
      else if (p2 == "paper")
        resultString = "Player 1 won!";
    }
    else if (p1 == "rock")
    {
      if (p2 == "scissors")
        resultString = "Player 1 won!";
      else if (p2 == "rock")
        resultString = "Draw!";
      else if (p2 == "paper")
        resultString = "Player 2 won!";    
    }
    else if (p1 == "paper")
    {
      if (p2 == "scissors")
        resultString = "Player 2 won!";
      else if (p2 == "rock")
        resultString = "Player 1 won!";
      else if (p2 == "paper")
        resultString = "Draw!";
    }
    
    return resultString;    
  }
}