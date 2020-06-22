using System.Collections.Generic;

public class SqInRect {
  
  public static List<int> sqInRect(int lng, int wdth) {
    if (lng == wdth)
      return null;
    else
    {
      var squares = new List<int>();
      var currentLength = lng;
      var currentWidth = wdth;
    
      while (currentLength > 0 && currentWidth > 0)
      {
        if (currentLength > currentWidth)
        {
          squares.Add(currentWidth);
          currentLength -= currentWidth;
        }
        else if (currentWidth > currentLength)
        {
          squares.Add(currentLength);
          currentWidth -= currentLength;      
        }
        else
        {
          squares.Add(currentLength);
          currentWidth = 0;
          currentWidth = 0;
        }
      }
    
      return squares;   
    }  
  }
}