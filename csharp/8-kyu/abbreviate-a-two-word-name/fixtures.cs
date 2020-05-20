namespace Solution {
  using NUnit.Framework;
  using System;  

  [TestFixture]
  public class KataTests
  {
    [Test]
    public void BasicTests()
    {
      Assert.AreEqual("S.H", Kata.AbbrevName("Sam Harris"));
      Assert.AreEqual("P.F", Kata.AbbrevName("Patrick Feenan"));
      Assert.AreEqual("E.C", Kata.AbbrevName("Evan Cole"));
      Assert.AreEqual("P.F", Kata.AbbrevName("P Favuzzi"));
      Assert.AreEqual("D.M", Kata.AbbrevName("David Mendieta"));
    }
  }
}