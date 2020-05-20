using System;
using System.Linq;

public class Kata
{
  public static string DuplicateEncode(string word)
  {
    var output = "";
    
    foreach (var letter in word)
    {
      var count = 0;
      
      for (var i = 0; i < word.Length; i++) 
      {
        if (char.ToLower(letter) == char.ToLower(word[i]))
          count++;
      }
      
      if (count > 1)
        output += ')';
      else
        output += '(';
    }
    
    return output;
  }
}