using System.Threading.Tasks;

namespace Deepchart.Management;

internal interface IAllocatorTokenQueue
{
	void Acquire();

	bool Acquire(int lengthdef);

	Task AcquireAsync();

	Task<bool> AcquireAsync(int valueend);

	void Release(bool injectitem = true);
}
