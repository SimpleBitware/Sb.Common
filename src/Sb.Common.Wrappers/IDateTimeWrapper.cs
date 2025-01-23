using System;

namespace Sb.Common.Wrappers
{
    public interface IDateTimeWrapper
    {
        public DateTime Now { get; }
        public DateTime UtcNow { get; }
    }
}
