using System;
using System.Linq;

namespace smile67Kata
{
  public class Kata
  {
    public string calculateString(string calcIt)
    {
      var mathResult = 0.00;
      string result = new string(calcIt.Where(c => "+-*/.0123456789".Contains(c)).ToArray());

      if (result.IndexOf('+') > 0)
      {
        var numbers = result.Split('+');
        mathResult = Convert.ToDouble(numbers[0]) + Convert.ToDouble(numbers[1]);
      }
      else if (result.IndexOf('-') > 0)
      {
        var numbers = result.Split('-');
        mathResult = Convert.ToDouble(numbers[0]) - Convert.ToDouble(numbers[1]);
      }
      else if (result.IndexOf('*') > 0)
      {
        var numbers = result.Split('*');
        mathResult = Convert.ToDouble(numbers[0]) * Convert.ToDouble(numbers[1]);
      }
      else if (result.IndexOf('/') > 0)
      {
        var numbers = result.Split('/');
        mathResult = Convert.ToDouble(numbers[0]) / Convert.ToDouble(numbers[1]);
      }

      return Math.Round(mathResult, 0).ToString();
    }
  }
}
