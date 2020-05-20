using System;

public class Kata
{
  public static string GetMiddle(string s)
  {
    if (s.Length % 2 == 0)
    {
      return s[s.Length/2 - 1].ToString() + s[s.Length/2].ToString(); 
    }
    else
    {
      var position = (int)Math.Ceiling((double) s.Length/2) - 1;
      
      return s[position].ToString();
    }
  }
}