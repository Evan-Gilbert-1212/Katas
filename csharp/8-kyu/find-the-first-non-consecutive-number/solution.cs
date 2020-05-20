public class Kata
{
  public static object FirstNonConsecutive(int[] arr)
  {
    var previousNumber = arr[0] - 1;
    
    foreach (var num in arr)
      if (num != previousNumber + 1)
        return num;
      else 
        previousNumber = num;
    
    return null;
  }
}