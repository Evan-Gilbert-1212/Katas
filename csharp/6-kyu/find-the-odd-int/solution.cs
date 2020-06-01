using System.Linq;

namespace Solution
{
  class Kata
    {
    public static int find_it(int[] seq) 
      {
        foreach (int checkNum in seq)
        {
          if (seq.Count(num => num == checkNum) % 2 > 0)
            return checkNum;
        }
        
        return -1;
      }
       
    }
}