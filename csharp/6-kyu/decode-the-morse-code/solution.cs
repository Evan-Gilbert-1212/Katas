class MorseCodeDecoder
{
  public static string Decode(string morseCode)
  {
    var letterArray = morseCode.Split(' ');
    var decodedMessage = "";
    
    foreach (var letter in letterArray)
    {
      if (letter == "" && !decodedMessage.EndsWith(" "))
        decodedMessage += " ";
      else
        decodedMessage += MorseCode.Get(letter);
    }
      
    return decodedMessage.Trim();
  }
}