using System;

namespace Sb.Common.Wrappers
{
    public class DateTimeWrapper : IDateTimeWrapper
    {
        public DateTime Now => DateTime.Now;

        public DateTime UtcNow => DateTime.UtcNow;

        public DateTime Today => DateTime.Today;
    }
}
