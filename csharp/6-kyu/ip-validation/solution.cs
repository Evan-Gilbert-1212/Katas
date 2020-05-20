using System;

namespace Solution
{
    class Kata
    {
        public static bool is_valid_IP(string ipAddres)
        {
          var numbers = ipAddres.Split('.');
          var intResult = 0;
          
          if (numbers.Length != 4)
              return false;
          
          foreach (var num in numbers)
          {
            if (num.Length == 0)
              return false;
            else if (num[0] == '0' && num.Length > 1)
              return false;
            else if (num.Contains(" "))
              return false;
            else if (!Int32.TryParse(num, out intResult))
              return false;
            else if (intResult < 0 || intResult > 255)
              return false;
          }
          
          return true;
        }
    }
}