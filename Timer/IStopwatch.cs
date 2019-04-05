namespace Stopwatch
{
    /*
     * A Timer that rolls over every 24 days
     */
    public interface IStopwatch
    {
        /// <summary>
        /// Restart the stopwatch to zero
        /// </summary>
        void Restart();

        /// <summary>
        /// Advance Stopwatch
        /// </summary>
        void Advance();

        /// <summary>
        /// Elapsed time is milliseconds
        /// </summary>
        int ElapsedTimeMs { get; }

        /// <summary>
        /// Elapsed time in seconds
        /// </summary>
        int ElapsedTimeSeconds { get; }
    }
}
