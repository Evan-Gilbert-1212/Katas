using System;
using System.Collections;
using System.Collections.Generic;

public class ListFilterer
{
   public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
   {
     var resultList = new List<int>();
     
     foreach (var obj in listOfItems)
     {
       if (obj is int)
         resultList.Add((int)obj);
     }    
     
     return resultList;
   }
}
