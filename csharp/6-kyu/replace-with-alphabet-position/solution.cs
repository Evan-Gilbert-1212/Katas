using System;
using System.Linq;

public static class Kata
{
  public static string AlphabetPosition(string text)
  {
    return string.Join(" ", 
             text.Where(c => Char.IsLetter(c))
                 .ToArray()
                 .Select(c => c % 32));
  }
}