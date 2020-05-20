using System;

public static class Kata
{
  public static int Solve(string str)
  {
    var longestVowelString = 0;
    var currentVowelString = 0;
    
    for (var i = 0; i < str.Length; i++)
    {
      if ("aeiou".Contains(str[i]))
      {
         currentVowelString++; 
      }
      else
      {
        if (currentVowelString > longestVowelString)
          longestVowelString = currentVowelString;
        
        currentVowelString = 0;
      }
    }
    
    if (currentVowelString > longestVowelString)
      longestVowelString = currentVowelString;
    
    return longestVowelString;
  }
}