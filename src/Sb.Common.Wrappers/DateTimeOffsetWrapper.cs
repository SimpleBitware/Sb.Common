using System;

namespace Sb.Common.Wrappers
{
    public class DateTimeOffsetWrapper: IDateTimeOffsetWrapper
    {
        public DateTimeOffset Now => DateTimeOffset.Now;
        public DateTimeOffset UtcNow => DateTimeOffset.UtcNow;
    }
}
