using System;
using NUnit.Framework;

[TestFixture]
public class DivSevenTests {

    [Test]
    public void Test1() {
        Console.WriteLine("****** Basic Tests");    
        Assert.AreEqual(new long[] {10, 2}, DivSeven.Seven(1021));
        Assert.AreEqual(new long[] {7, 2}, DivSeven.Seven(1603));
        Assert.AreEqual(new long[] {35, 1}, DivSeven.Seven(371));
        Assert.AreEqual(new long[] {42, 1}, DivSeven.Seven(483));        
    }
}