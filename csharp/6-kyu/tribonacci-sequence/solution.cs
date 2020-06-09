using System;
using System.Collections.Generic;
using System.Linq;

public class Xbonacci
{
  public double[] Tribonacci(double[] signature, int n)
  {
    if (n <= 3)
      return signature.Take(n).ToArray();
    else
    {
      var numList = new List<double>(signature);
        
      while (numList.Count < n)
      {
        numList.Reverse();
        var sumOfThree = numList.Take(3).Sum();
        numList.Reverse();

        numList.Add(sumOfThree);
      }
      
      return numList.ToArray();
    }
  }
}