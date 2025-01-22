using System.Threading;
using System.Threading.Tasks;

namespace Sb.CommonWrappers
{
    public interface ITaskDelayWrapper
    {
        Task DelayAsync(int millis, CancellationToken cancellationToken);
    }
}
