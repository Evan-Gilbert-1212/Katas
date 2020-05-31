namespace Solution {
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class BasicTests
  {
    [Test]
    public void BasicTest()
    {
      Assert.AreEqual(180, Kata.Angle(3));
      Assert.AreEqual(360, Kata.Angle(4));
    }
  }
}