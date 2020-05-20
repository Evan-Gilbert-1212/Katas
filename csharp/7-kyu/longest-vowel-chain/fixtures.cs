namespace Solution 
{
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SolutionTest
  {
    [Test, Description("Basic Tests")]
    public void SampleTest()
    {
      Assert.AreEqual(2, Kata.Solve("codewarriors"));
      Assert.AreEqual(3, Kata.Solve("suoidea"));
      Assert.AreEqual(3, Kata.Solve("ultrarevolutionariees"));
      Assert.AreEqual(1, Kata.Solve("strengthlessnesses"));
      Assert.AreEqual(2, Kata.Solve("cuboideonavicuare"));
      Assert.AreEqual(5, Kata.Solve("chrononhotonthuooaos"));
      Assert.AreEqual(8, Kata.Solve("iiihoovaeaaaoougjyaw"));
    }
  }
}