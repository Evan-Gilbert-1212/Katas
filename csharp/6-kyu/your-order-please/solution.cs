using System;
using System.Text.RegularExpressions;

public static class Kata
{
  public static string Order(string words)
  {
    var wordArray = words.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    
    var orderedArray = new string[wordArray.Length];
    
    foreach (var word in wordArray)
      orderedArray[Int32.Parse(Regex.Match(word, @"\d+").Value) - 1] = word;
    
    return words == "" ? "" : string.Join(' ', orderedArray);
  }
}