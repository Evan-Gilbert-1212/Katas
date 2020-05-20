namespace Solution {
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void Tests() {
      Assert.AreEqual(4, Kata.getVolumeOfCubiod(1,2,2));
      Assert.AreEqual(63, Kata.getVolumeOfCubiod(6.3,2,5));
    }
  }
}