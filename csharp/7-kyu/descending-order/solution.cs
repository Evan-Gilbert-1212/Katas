using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static int DescendingOrder(int num)
  {     
     var charArray = num.ToString().ToCharArray();
     
     Array.Sort(charArray);
     
     Array.Reverse(charArray);
     
     return Int32.Parse(new string(charArray));
  }
}