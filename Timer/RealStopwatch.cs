using Diag = System.Diagnostics; 

namespace Stopwatch
{
    public class RealStopwatch : IStopwatch
    {
        private readonly Diag.Stopwatch _stopwatch;

        public RealStopwatch()
        {
            _stopwatch = new Diag.Stopwatch();
            Restart();
        }

        public void Restart()
        {
            _stopwatch.Restart();
        }

        public void Advance()
        {
            // NOP
        }

        public int ElapsedTimeMs => (int) _stopwatch.ElapsedMilliseconds;
        public int ElapsedTimeSeconds => ElapsedTimeMs / 1000;
    }
}
