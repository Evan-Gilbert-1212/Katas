namespace Solution {
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class Test
  {
    [Test]
    public void SampleTest()
    {
      Assert.AreEqual(6, Kata.FirstNonConsecutive(new int[] {1, 2, 3, 4, 6, 7, 8}));
    }
  }
}