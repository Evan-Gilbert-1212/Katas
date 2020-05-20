using System.Linq;

public class Kata
{
  public static string AbbrevName(string name)
  {
    return string.Join('.', name.Split().Select(word => char.ToUpper(word[0])));
  }
}