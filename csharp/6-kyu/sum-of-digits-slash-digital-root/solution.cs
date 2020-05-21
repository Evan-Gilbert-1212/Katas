using System;
using System.Linq;

public class Number
{
  public int DigitalRoot(long n)
  {
    var stringValue = n.ToString();
    
    while (stringValue.Length > 1)
    {
      stringValue = stringValue.Select(number => (int)char.GetNumericValue(number))
                               .ToArray().Sum().ToString();
    }
    
    return Int32.Parse(stringValue);
  }
}