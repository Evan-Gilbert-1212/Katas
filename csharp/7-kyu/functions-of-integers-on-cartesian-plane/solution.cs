public class Funcij {

  public static ulong sumin(ulong n)
  {
    ulong sumMin = 0;
    
    for (ulong i = 1; i <= n; i++)
    {
      sumMin += (i * ((n * 2 + 1) - (i * 2)));
    }
    
    return sumMin;
  }
  
  public static ulong sumax(ulong n)
  {
    ulong sumMax = 0;
    
    for (ulong i = n; i >= 1; i--)
    {
      sumMax += (i * (i * 2 - 1));
    }
    
    return sumMax;
  }
  
  public static ulong sumsum(ulong n)
  {
     return sumin(n) + sumax(n);
  }
}