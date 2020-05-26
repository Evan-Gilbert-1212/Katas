namespace Age {
  using System;
  
  public class Kata
    {
        public static string HowOld(DateTime birthday)
        {
           var ageYears = DateTime.Now.Year - birthday.Year;
           var ageMonths = DateTime.Now.Month - birthday.Month;
           var ageDays = DateTime.Now.Day - birthday.Day;

           if (ageMonths < 0)
           {
             ageYears--;
             ageMonths += 12;
           }
           
           if (ageDays < 0)
           {
             ageMonths--;
             ageDays += 30;
           }
           
           return $"Peter is {ageYears} years, {ageMonths} months and {ageDays} days old";             
        }
    }
}