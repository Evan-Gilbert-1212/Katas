using System;

class Kata
{
    public static int MaxNumber(int n)
    {
     var charArray = n.ToString().ToCharArray();
     
     Array.Sort(charArray);
     
     Array.Reverse(charArray);
     
     return Int32.Parse(new string(charArray));    
    }
}