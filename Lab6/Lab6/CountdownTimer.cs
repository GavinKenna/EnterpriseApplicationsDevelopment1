using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Lab6
{
    class CountdownTimer
    {
        private double time;
        public double Time
        {
            get
            {
                return this.time;
            }
        }

        public CountdownTimer(double time)
        {
            this.time = time;
        }

        public void StartCountdown()
        {
            Thread.Sleep(TimeSpan.FromMilliseconds(this.time));
            this.time = 0.0;
            Finished.Invoke();
        }

        public event EventHandler Finished;


    }
}
