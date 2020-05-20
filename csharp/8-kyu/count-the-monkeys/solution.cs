public static class MonkeyCounter
{
  public static int[] MonkeyCount(int n)
  {
    var monkeyList = new int[n];
    
    for (var i = 1; i <= n; i++)
      monkeyList[i - 1] = i;
      
    return monkeyList;
  }
}