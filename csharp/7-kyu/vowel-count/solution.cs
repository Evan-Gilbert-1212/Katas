using System;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
       return str.Count(letter => "aeiou".Contains(letter));
    }
}