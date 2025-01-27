using System;

namespace Sb.Common.Wrappers
{
    public interface IDateTimeWrapper
    {
        DateTime Now { get; }
        DateTime UtcNow { get; }
        DateTime Today { get; }
    }
}
