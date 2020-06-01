using System;
using System.Linq;

public class Kata
{
  public static int DuplicateCount(string str)
  {
    return str.Where(character => str.Where(x => Char.ToLower(x) == character).Count() > 1)
              .Distinct().ToArray().Count();
  }
}