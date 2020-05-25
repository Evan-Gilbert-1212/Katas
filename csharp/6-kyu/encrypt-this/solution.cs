using System;

namespace EncryptThis
{
    public class Kata
    {
        public static string EncryptThis(string input)
        {
          var wordArr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
          var result = "";
          
          foreach (var word in wordArr)
          {
            if (result != "")
              result += " ";

            if (word.Length == 1)
              result += ((int)word[0]).ToString();
            else if (word.Length == 2) 
              result += ((int)word[0]).ToString() + word[1];
            else 
              result += ((int)word[0]).ToString() + 
                        word[word.Length - 1] +
                        word.Substring(2, word.Length - 3) +
                        word[1];
          }
          
          return result;
        }
    }
}