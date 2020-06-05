using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static string SpinWords(string sentence)
  {
    var strArray = sentence.Split(' ');
    
    for (var i = 0; i < strArray.Length; i++)
      if (strArray[i].Length >= 5)
      {
        var charArray = strArray[i].ToCharArray();
        
        Array.Reverse(charArray);
        
        strArray[i] = new string(charArray);
      }
        
    return string.Join(" ", strArray);
  }
}