using System;

public class Accumul 
{
  public static String Accum(string s) 
  {
     var output = "";
     
     for (var i = 0; i < s.Length; i++)
     {
       if (output != "")
         output += "-";
         
      var lowerStr = new string(s[i], i).ToLower();
         
       output += char.ToUpper(s[i]) + lowerStr;
     }
     
     return output;
  }
}