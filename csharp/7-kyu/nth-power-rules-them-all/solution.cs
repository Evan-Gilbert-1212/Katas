using System;
using System.Linq;

public class Kata
{
  public static int ModifiedSum(int[] a, int n)
  {
    return a.Select(number => (int)Math.Pow(number, n)).Sum() - a.Sum();
  }
}