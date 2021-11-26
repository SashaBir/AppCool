using System;

namespace AppCool.Project.Time
{
    public class Timer
    {
        public event Action OnOut = delegate { };

        public Timer(uint second)
        {
            Second = second;
        }

        public uint Second { set; private get; }

        public void Start()
        {

        }

        public void Stop()
        {

        }
    }
}
