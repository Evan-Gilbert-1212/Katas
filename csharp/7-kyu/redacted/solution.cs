using System;

public class Dinglemouse
{
    public static bool Redacted(string doc1, string doc2)
    {
      if (doc2.Length != doc1.Length)
        return false;
         
      for (int i = 0; i < doc2.Length; i++)
      {
        if (doc2[i] != doc1[i] && (doc1[i] != 'X' || doc2[i] == '\n'))
          return false;
      }

      return true;
    }
}