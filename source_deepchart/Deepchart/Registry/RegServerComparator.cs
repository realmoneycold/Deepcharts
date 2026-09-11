using Deepchart.Location;
using VolAnalysis.Drivers;

namespace Deepchart.Registry;

internal delegate void RegServerComparator(LocatorSelectorTransaction sender, string message, SequentialProjectDriverState logLevel, bool? showToast = null);
