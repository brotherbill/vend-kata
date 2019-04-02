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
  }
}
