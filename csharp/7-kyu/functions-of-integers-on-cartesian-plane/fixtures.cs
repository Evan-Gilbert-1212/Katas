using System;

using NUnit.Framework;

[TestFixture]
public class FuncijTests {

Random randomGenerator = new Random();	
    
[Test]
  public void Test01() {
		Assert.AreEqual(55, Funcij.sumin(5));
  }
[Test]
  public void Test04() {
		Assert.AreEqual(372, Funcij.sumax(8));
  }
[Test]
  public void Test05() {
		Assert.AreEqual(576, Funcij.sumsum(8));
  }

}
