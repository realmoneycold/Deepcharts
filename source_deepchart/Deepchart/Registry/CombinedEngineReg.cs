using VolAnalysis.Drivers;

namespace Deepchart.Registry;

internal delegate void CombinedEngineReg(string message, SequentialProjectDriverState logLevel = (SequentialProjectDriverState)1, string source = null, bool? showToat = null);
