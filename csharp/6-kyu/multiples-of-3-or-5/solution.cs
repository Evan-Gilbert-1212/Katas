using System.Collections.Generic;
using System.Linq;
 
public static class Kata
{
  public static int Solution(int value)
  {
    List<int> multiples = new List<int>();
    
    for (int i = 1; i < value; i ++)
      if (i % 3 == 0 || i % 5 == 0)
        multiples.Add(i);
      
    return multiples.Sum();
  }
}