using System;

namespace AppCool.Project.Event
{
    public struct DateTimeViewer
    {
        public DateTime FixedDateTime { private set; get; }
        public DateTime UnfixedDateTime { private set; get; }

        public TimeSpan RangeBetween 
        { 
            get
            {
                if (FixedDateTime == null)
                    throw new Exception("Fixate has not been done.");

                if (UnfixedDateTime == null)
                    throw new Exception("Unfixate has not been done.");

                return UnfixedDateTime - FixedDateTime;
            }
        }

        public void Fixate()
        {
            if (FixedDateTime != null)
                throw new Exception("Fixate has been done.");

            if (UnfixedDateTime != null)
                throw new Exception("Unfixate has been done.");

            FixedDateTime = DateTime.Now;
        }

        public void Unfixate()
        {
            if (FixedDateTime == null)
                throw new Exception("Fixate has not been done.");

            if (UnfixedDateTime != null)
                throw new Exception("Unfixate has been done.");

            UnfixedDateTime = DateTime.Now;
        }
    }
}
