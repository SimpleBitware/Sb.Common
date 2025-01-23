using System.Threading;
using System.Threading.Tasks;

namespace Sb.Common.Wrappers
{
    public class TaskDelayWrapper : ITaskDelayWrapper
    {
        public Task DelayAsync(int millis, CancellationToken cancellationToken)
        {
            return Task.Delay(millis, cancellationToken);
        }
    }
}
