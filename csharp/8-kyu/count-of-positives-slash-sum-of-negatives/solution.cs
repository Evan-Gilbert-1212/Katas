using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
        var posTotal = 0;
        var negTotal = 0;
        
        if (input != null)
        {
          for (var i = 0; i < input.Length; i++)
          {
            if (input[i] > 0)
              posTotal++;
            else
              negTotal += input[i];
          }
        }
        
        if (posTotal == 0 && negTotal == 0)
          return new int[0];
        else
          return new int[] {posTotal, negTotal}; 
    }
}