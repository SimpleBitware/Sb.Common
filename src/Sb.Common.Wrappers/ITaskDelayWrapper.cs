using System.Threading;
using System.Threading.Tasks;

namespace Sb.Common.Wrappers
{
    public interface ITaskDelayWrapper
    {
        Task DelayAsync(int millis, CancellationToken cancellationToken);
    }
}
