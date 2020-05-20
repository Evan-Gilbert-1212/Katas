using System;

public class DivSeven
{
  public static long[] Seven(long m)
  {
    long steps = 0;
    
    while (m > 99)
    {
      var x = m/10;
      var y = 2 * (m%10);
      m = x - y;
      
      steps++;
    }
    
    return new long[] {m, steps};
  }
}