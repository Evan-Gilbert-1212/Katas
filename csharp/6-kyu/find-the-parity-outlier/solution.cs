using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static int Find(int[] integers)
  {
    bool evenOutlier = (integers.Where(x => x % 2 == 0).Count() == 1);
    
    return evenOutlier ? integers.FirstOrDefault(x => x % 2 == 0) :
                         integers.FirstOrDefault(x => x % 2 > 0);
  }
}