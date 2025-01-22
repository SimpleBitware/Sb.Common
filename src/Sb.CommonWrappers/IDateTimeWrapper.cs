using System;

namespace Sb.CommonWrappers
{
    public interface IDateTimeWrapper
    {
        public DateTime Now { get; }
        public DateTime UtcNow { get; }
    }
}
