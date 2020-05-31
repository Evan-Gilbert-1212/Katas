using System;
using System.Linq;

public class Persist 
{
  public static int Persistence(long n) 
  {
    var numString = n.ToString();
    var multPersistence = 0;
    
    while (numString.Length > 1)
    {
      numString = numString.ToCharArray().Select(character => int.Parse(character.ToString()))
                  .ToArray().Aggregate(1, (agg, num) => agg * num).ToString();
              
      multPersistence++;
    }
    
    return multPersistence;
  }
}