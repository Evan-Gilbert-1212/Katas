using System;
using System.Linq;

public class Kata
{
  public static int[] ArrayDiff(int[] a, int[] b)
  {
    return a.Where(n => !Array.Exists(b, num => num == n)).ToArray();  
  }
}