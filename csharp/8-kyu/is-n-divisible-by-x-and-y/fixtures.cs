using System;
using NUnit.Framework;

[TestFixture]
public class DivisibleNbTests {

[Test]
  public void Test1() {
    Assert.AreEqual(true, DivisibleNb.isDivisible(12,4,3));
  }
[Test]
  public void Test2() {
    Assert.AreEqual(false, DivisibleNb.isDivisible(3,3,4));
  }
[Test]  public void Test3() {
    Assert.AreEqual(false, DivisibleNb.isDivisible(8,3,4));
  }
    
}
  