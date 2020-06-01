using System;
using System.Linq;

public class Kata
{
  public static bool IsValidWalk(string[] walk)
  {
    return walk.Count(x => x == "n") - walk.Count(x => x == "s") == 0 && 
           walk.Count(x => x == "w") - walk.Count(x => x == "e") == 0 &&
           walk.Count() == 10;
  }
}