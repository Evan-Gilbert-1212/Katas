public class BouncingBall {
  
  public static int bouncingBall(double h, double bounce, double window) {
    if (h > 0 && bounce > 0 && bounce < 1 && window < h)
    {
      var ballSeen = 1;
      var nextBounceHeight = h * bounce;
      
      while (nextBounceHeight > window)
      {
        nextBounceHeight = nextBounceHeight * bounce;
        ballSeen += 2;
      }
      
      return ballSeen;
    }
    else
      return -1;
  }
}