using Stopwatch;
using Xunit;
namespace VendAppTest
{
    public class StopwatchTest
    {
        [Fact]
        public void Should_Start_At_Zero()
        {
            // Arrange
            IStopwatch sw = new FakeStopwatch(tickIncrementMilliseconds: 400);

            // Act
            int actualTime = sw.ElapsedTimeMs;

            // Assert
            Assert.Equal(0, actualTime);
        }

        [Fact]
        public void Should_Advance_Forward()
        {
            // Arrange
            IStopwatch sw = new FakeStopwatch(tickIncrementMilliseconds: 400);

            // Act
            const int times = 3;
            for (int i = times - 1; i >= 0; i--)
                sw.Advance();

            // Assert
            Assert.Equal(1_200, sw.ElapsedTimeMs);
            Assert.Equal(1, sw.ElapsedTimeSeconds);
        }

        [Fact]
        public void Should_Reset_Back_To_Zero()
        {
            // Arrange
            IStopwatch sw = new FakeStopwatch(tickIncrementMilliseconds: 400);

            // Act
            sw.Advance();
            sw.Restart();

            // Assert
            Assert.Equal(0, sw.ElapsedTimeMs);
            Assert.Equal(0, sw.ElapsedTimeSeconds);
        }
    }
}
