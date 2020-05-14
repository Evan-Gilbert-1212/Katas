using System;
using System.Linq;

public class Kata
{
  public static bool IsIsogram(string str) 
  {
    var letterCount = "abcdefghijklmnopqrstuvwxyz".ToDictionary(key => key, value => 0);
    
    var lowerStr = str.ToLower();
    
    foreach (var letter in lowerStr)
    {
      if (letterCount.ContainsKey(letter))
      {
        letterCount[letter]++;
      }
    }
    
    return letterCount.Values.Max() <= 1 ? true : false;
  }
}