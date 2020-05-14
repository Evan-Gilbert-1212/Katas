namespace Solution {
  using NUnit.Framework;
  using System;
  
  [TestFixture]
  public class SolutionTest {    
    [Test]
    public void BasicTests() {
      Assert.AreEqual('f', Kata.AddLetters(new char[] {'a', 'b', 'c'}));
      Assert.AreEqual('z', Kata.AddLetters(new char[] {'z'}));
      Assert.AreEqual('c', Kata.AddLetters(new char[] {'a', 'b'}));
      Assert.AreEqual('c', Kata.AddLetters(new char[] {'c'}));
      Assert.AreEqual('a', Kata.AddLetters(new char[] {'z', 'a'}));
      Assert.AreEqual('d', Kata.AddLetters(new char[] {'y', 'c', 'b'}));
      Assert.AreEqual('z', Kata.AddLetters(new char[] {}));
    }
  }
}