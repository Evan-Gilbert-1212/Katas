using System;

public static class Kata
{
  public static string Greet(string name)
  {
    return $"Hello {char.ToUpper(name[0]) + name.Substring(1).ToLower()}!"; 
  }
}