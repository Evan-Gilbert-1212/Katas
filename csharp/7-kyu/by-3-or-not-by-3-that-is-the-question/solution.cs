using System;
using System.Linq;

public static class Kata
{
  public static bool DivisibleByThree(string n)
  {
    return Array.ConvertAll(n.ToCharArray(), i => Char.GetNumericValue(i)).Sum() % 3 == 0;
  }
}