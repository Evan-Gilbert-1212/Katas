using System.Linq;

public class Kata
{
  // Return the missing number!
  public static int FindNumber(int[] array)
  {
    for (var i = 1; i <= array.Length; i++)
      if (!array.Contains(i))
        return i;

    return array.Length + 1;
  }
}