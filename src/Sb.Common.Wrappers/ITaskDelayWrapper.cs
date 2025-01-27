using System;
using System.Threading;
using System.Threading.Tasks;

namespace Sb.Common.Wrappers
{
    public interface ITaskDelayWrapper
    {
        Task Delay(int millisecondsDelay);
        Task Delay(int millisecondsDelay, CancellationToken cancellationToken);
        Task Delay(TimeSpan delay);
        Task Delay(TimeSpan delay, CancellationToken cancellationToken);
    }
}
