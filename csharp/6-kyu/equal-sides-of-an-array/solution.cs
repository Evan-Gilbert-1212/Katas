using System.Linq;

public class Kata
{
  public static int FindEvenIndex(int[] arr)
  {
    var rightValue = arr.Sum();
    var leftValue = 0;
    
    for (var i = 0; i < arr.Length; i++)
    {
      rightValue -= arr[i];
      
      if (leftValue == rightValue)
        return i;
      
      leftValue += arr[i];
    }
    
    return -1;
  }
}