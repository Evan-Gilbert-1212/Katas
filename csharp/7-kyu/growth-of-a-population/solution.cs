using System;

class Arge {
    
    public static int NbYear(int p0, double percent, int aug, int p) {
      var yearlyPop = p0;
      var noOfYears = 0;
      percent = percent / 100;
      
      while (yearlyPop < p)
      {
        yearlyPop += (int)(yearlyPop * percent + aug);
        noOfYears++;
      }
      
      return noOfYears;
    }
}