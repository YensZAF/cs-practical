using NUnit.Framework;

namespace Oware.Tests
{
  public class Tests
  {
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
      // Arrange
      House h = new House(1, 2);
      for (int i = 0; i < 8; i++)
      {
        h.AddSeedInPot(new Seed());
      }
      // Act
      h.ResetHouse();
      // Assert
      Assert.AreEqual(4, h.GetCount(), "House should reset back to having 4 seeds.");
      //Assert.Pass();
    }

    [Test]
    public void Test2()
    {
      // Arrange

      // Act

      // Assert
      Assert.Pass();
    }

  }
}