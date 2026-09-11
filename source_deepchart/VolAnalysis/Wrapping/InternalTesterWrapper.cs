using System;
using System.Threading.Tasks;
using Deepchart.Location;

namespace VolAnalysis.Wrapping;

internal delegate Task InternalTesterWrapper(HiddenLocatorLocator connection, Exception exception);
