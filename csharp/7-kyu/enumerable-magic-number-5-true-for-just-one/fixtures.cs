namespace Solution 
{
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class KataTests
  {
    [Test]
    public void BasicTest()
    {
      Assert.AreEqual(true, Kata.One(new int[] { 1,2,3,4,5 }, v => v < 2));
      Assert.AreEqual(false, Kata.One(new int[] { 1,2,3,4,5 }, v => v % 2 != 0));
      Assert.AreEqual(false, Kata.One(new int[] { 1,2,3,4,5 }, v => v > 5));
    }
  }
}