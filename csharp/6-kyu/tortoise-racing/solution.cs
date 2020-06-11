public class Tortoise
{
  public static int[] Race(int v1, int v2, int g) 
  {
    var seconds = (g * 3600) / (v2 - v1);
    
    return v1 > v2 ? null : new int[]{seconds / 3600, seconds % 3600 / 60, seconds % 60};
  }
}