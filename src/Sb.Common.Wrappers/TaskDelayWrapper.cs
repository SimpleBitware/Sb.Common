using System;
using System.Threading;
using System.Threading.Tasks;

namespace Sb.Common.Wrappers
{
    public class TaskDelayWrapper : ITaskDelayWrapper
    {
        public Task Delay(int millisecondsDelay)
        {
            return Task.Delay(millisecondsDelay);
        }

        public Task Delay(int millisecondsDelay, CancellationToken cancellationToken)
        {
            return Task.Delay(millisecondsDelay, cancellationToken);
        }

        public Task Delay(TimeSpan delay)
        {
            return Task.Delay(delay);
        }

        public Task Delay(TimeSpan delay, CancellationToken cancellationToken)
        {
            return Task.Delay(delay, cancellationToken);
        }
    }
}
