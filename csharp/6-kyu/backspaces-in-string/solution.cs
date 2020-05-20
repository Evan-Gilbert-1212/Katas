using System;

public class Kata
{
  public static string CleanString(string s)
  {
    var result = "";
    
    foreach (var character in s)
    {
      if (character != '#')
        result += character;
      else if (result.Length > 0)
        result = result.Remove(result.Length - 1, 1);
    }
    
    return result;
  }
}