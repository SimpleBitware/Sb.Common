using System;

namespace Sb.Common.Wrappers
{
    public interface IDateTimeOffsetWrapper
    {
        public DateTimeOffset Now { get; }
        public DateTimeOffset UtcNow { get; }
    }
}
