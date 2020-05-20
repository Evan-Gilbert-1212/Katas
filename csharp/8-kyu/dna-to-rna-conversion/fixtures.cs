namespace Converter {
  using NUnit.Framework;
  using System;
  
  [TestFixture]
  public class Test
  {
    [Test]
    public void test()
    {
      Converter converter = new Converter();
      Assert.AreEqual("UUUU", converter.dnaToRna("TTTT"));
    }
  }
}