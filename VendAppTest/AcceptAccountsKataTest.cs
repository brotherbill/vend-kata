using VendApp;
using Xunit;

namespace VendAppTest
{
  public class AcceptAccountsKataTest
  {
    [Fact]
    public void Should_Detect_A_Nickel()
    {
      // Arrange
      float weight = 5.02f;
      float diameter = 21.1f;

      // Act
      int actualCoin = CoinDetector.CoinValue(weight, diameter);

      // Assert
      Assert.Equal(5, actualCoin);
    }

    [Fact]
    public void Should_Detect_A_Dime()
    {
      // Arrange
      float weight = 2.25f;
      float diameter = 18.0f;

      // Act
      int actualCoin = CoinDetector.CoinValue(weight, diameter);

      // Assert
      Assert.Equal(10, actualCoin);
    }

    [Fact]
    public void Should_Detect_A_Quarter()
    {
      // Arrange
      float weight = 5.67f;
      float diameter = 25.0f;

      // Act
      int actualCoin = CoinDetector.CoinValue(weight, diameter);

      // Assert
      Assert.Equal(25, actualCoin);
    }

    [Theory]
    [InlineData(100f, 200f)]
    [InlineData(4.990f, 21.31f)]
    [InlineData(4.990f, 21.09f)]
    [InlineData(2.24f, 18.00f)]
    [InlineData(2.281f, 18.00f)]
    public void Should_Detect_Slugs(float weight, float diameter)
    {
      // Arrange (see weight and diameter)
      // Act
      int actualCoin = CoinDetector.CoinValue(weight, diameter);

      // Assert
      Assert.Equal(0, actualCoin);
    }
  }
}
