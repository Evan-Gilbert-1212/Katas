public class Kata
{
  public static int Solve(string s)
  {
    var runningTotal = 0;
    var highestTotal = 0;
    
    if (s.Length > 0)
    {
      foreach (var character in s)
      {
        if (!"aeiou".Contains(character))
          runningTotal += (byte)(character) - 96;  
        else
        {
          if (runningTotal > highestTotal)
            highestTotal = runningTotal;
          
          runningTotal = 0;
        }
      }
    }
    
    if (runningTotal > highestTotal)
      highestTotal = runningTotal;
    
    return highestTotal;
  }
}