using System;
using System.Linq;
using System.Collections.Generic;

public class Brace {

    public static bool validBraces(String braces) 
    {  
      var braceList = new List<char>();
      
      foreach (var brace in braces)
      {
        if (brace == '(' || brace == '[' || brace == '{') 
          braceList.Add(brace);
        else if (brace == ')' || brace == ']' || brace == '}')
        {
          if (braceList.Count > 0)
          {
            if ((brace == ')' && braceList[braceList.Count - 1] == '(') ||
                (brace == ']' && braceList[braceList.Count - 1] == '[') ||
                (brace == '}' && braceList[braceList.Count - 1] == '{'))
              braceList.RemoveAt(braceList.Count - 1);
            else 
              return false;
          }
          else
            return false;
        }
      }
      
      return braceList.Count == 0;
    }
}