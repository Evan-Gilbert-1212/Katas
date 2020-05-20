using System;
using System.Linq;

public class Digits
{
  public static string Explode(string s)
  {
    var output = "";
    
    for (var i = 0; i < s.Length; i++)
    {
      output += new string(s[i], Int32.Parse(s[i].ToString()));
    }
    
    return output;
  }
}