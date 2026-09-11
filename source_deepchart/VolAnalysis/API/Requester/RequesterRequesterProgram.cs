using System.Threading.Tasks;
using Deepchart.Location;
using VolAnalysis.IO;

namespace VolAnalysis.API.Requester;

internal delegate Task RequesterRequesterProgram(LocatorSelectorTransaction connection, ReceiverValue.RegWLanProfileConnectionType newStatus);
