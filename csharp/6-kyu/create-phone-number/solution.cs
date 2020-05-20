public class Kata
{
  public static string CreatePhoneNumber(int[] numbers)
  {
    var phoneNumber = "(";
    
    for (var i = 0; i <= 2; i++)
      phoneNumber += numbers[i];
      
    phoneNumber += ") ";
    
    for (var i = 3; i <= 5; i++)
      phoneNumber += numbers[i];
      
    phoneNumber += "-";
    
    for (var i = 6; i <= 9; i++)
      phoneNumber += numbers[i];
      
    return phoneNumber;
    
  }
}