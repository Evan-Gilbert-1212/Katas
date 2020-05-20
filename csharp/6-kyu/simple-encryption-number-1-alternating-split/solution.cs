using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
  public static string Encrypt(string text, int n)
  {
    if (text == null)
      return text;
    else
    {
      var encryptedString = text;
    
      for (var i = 0; i < n; i++)
      {
        var oddCharacters = encryptedString.Where((character, index) => index % 2 > 0).ToArray();
        var evenCharacters = encryptedString.Where((character, index) => index % 2 == 0).ToArray();
      
        encryptedString = new string(oddCharacters) + new string(evenCharacters);
      }
    
      return encryptedString;
    };
  }
  
  public static string Decrypt(string encryptedText, int n)
  {
    var decryptedString = encryptedText;
    
    for (var i = 0; i < n; i++)
    {
      var oddCharacters = new List<char>(decryptedString.Substring(0, decryptedString.Length / 2));
      var evenCharacters = new List<char>(decryptedString.Substring(decryptedString.Length / 2));
      
      var tempString = "";
      
      while (oddCharacters.Count > 0 || evenCharacters.Count > 0)
      {
        if (evenCharacters.Count > 0)
        {
          tempString += evenCharacters[0];
          evenCharacters.RemoveAt(0);
        }
        
        if (oddCharacters.Count > 0)
        {
          tempString += oddCharacters[0];
          oddCharacters.RemoveAt(0);
        }
      }
      
      decryptedString = tempString;
    }
    
    return decryptedString;
  }
}