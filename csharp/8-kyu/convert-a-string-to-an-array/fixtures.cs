namespace Solution {
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void _1_Example()
    {
      Assert.AreEqual(new string[] {"Robin", "Singh"}, Solution.StringToArray("Robin Singh"));
    }

    [Test]
    public void _2_Example()
    {
      Assert.AreEqual(new string[] {"I", "love", "arrays", "they", "are", "my", "favorite"}, Solution.StringToArray("I love arrays they are my favorite"));
    }
  }
}