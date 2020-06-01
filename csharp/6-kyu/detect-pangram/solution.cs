using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static bool IsPangram(string str)
  {
    Dictionary<char, int> letterCount = new Dictionary<char, int>();

    var lowerString = str.ToLower();
   
    foreach (var character in "abcdefghijklmnopqrstuvwxyz")
      letterCount.Add(character, lowerString.Where(letter => letter == character).Count());
        
    return (!letterCount.ContainsValue(0)) ? true : false;
  }
}