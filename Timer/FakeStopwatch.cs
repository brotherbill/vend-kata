namespace Stopwatch
{
    public class FakeStopwatch : IStopwatch
    {
        private int _elapsedTimeMs;
        private readonly int _tickIncrementMs;

        public FakeStopwatch(int tickIncrementMilliseconds)
        {
            _tickIncrementMs = tickIncrementMilliseconds;
            Restart();
        }

        public void Restart()
        {
            _elapsedTimeMs = 0;
        }

        public void Advance() => _elapsedTimeMs += _tickIncrementMs;

        public int ElapsedTimeMs => _elapsedTimeMs;

        public int ElapsedTimeSeconds => ElapsedTimeMs / 1000;
    }
}
