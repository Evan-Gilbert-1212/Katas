using System;
using System.Linq;

public class Kata {
  public static char AddLetters(char[] letters) {
    var alphabet = "abcdefghijklmnopqrstuvwxyz";
 
    var sum = letters.Select(l => alphabet.IndexOf(l) + 1).Sum();
    
    return sum == 0 ? 'z' : alphabet[(sum - 1) % 26];
  }
}