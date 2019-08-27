using System;

namespace DesignAStopwatch
{
    class StopWatch
    {
        private DateTime StartTime;
        private DateTime EndTime;
        private bool IsStopWatchRunning;

        public StopWatch()
        {
            this.IsStopWatchRunning = false;
        }

        public void Start()
        {
            if (!this.IsStopWatchRunning)
            {
                this.StartTime = DateTime.Now;
                this.IsStopWatchRunning = true;
            }
            else
            {
                throw new InvalidOperationException("StopWatch is already running");
            }
        }

        public void Stop()
        {
            if (this.IsStopWatchRunning)
            {
                this.EndTime = DateTime.Now;
                this.IsStopWatchRunning = false;
            }
            else
            {
                throw new InvalidOperationException("StopWatch is not running");
            }
        }

        public TimeSpan GetDuration()
        {
            if (!this.IsStopWatchRunning)
            {
                return this.EndTime - this.StartTime;
            }
            else
            {
                throw new InvalidOperationException("StopWatch is running");
            }
        }
    }
}
