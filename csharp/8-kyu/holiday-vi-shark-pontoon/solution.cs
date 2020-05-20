public class Kata
{
    public static string Shark(
      int pontoonDistance, 
      int sharkDistance, 
      int yourSpeed, 
      int sharkSpeed, 
      bool dolphin)
    {
        var timeToBoat = pontoonDistance / yourSpeed;
        var timeUntilEaten = sharkDistance / (dolphin ? sharkSpeed / 2 : sharkSpeed); 
        
        return (timeToBoat < timeUntilEaten) ? "Alive!" : "Shark Bait!";
    }
}