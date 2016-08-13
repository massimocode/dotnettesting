using NUnit.Framework;

[TestFixture]
public class CalculatorSpec {
  [Test]
  public void ShouldPass() {
    Assert.AreEqual(3, new Calculator().Add(1, 2));
  }

  [Test]
  public void ShouldFail() {
    Assert.AreEqual(3, new Calculator().Add(1, 2));
  }

  [Test]
  public void Will_Fail() {
    Assert.AreEqual(3, new Calculator().Add(1, 2));
  }
}