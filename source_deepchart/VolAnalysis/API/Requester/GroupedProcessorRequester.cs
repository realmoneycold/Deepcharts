using System.Threading.Tasks;
using Deepchart.Location;

namespace VolAnalysis.API.Requester;

internal delegate Task GroupedProcessorRequester(HiddenLocatorLocator connection, string message);
