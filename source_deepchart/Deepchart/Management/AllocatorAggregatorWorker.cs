using System;
using System.Threading.Tasks;
using Deepchart.Location;

namespace Deepchart.Management;

internal delegate Task AllocatorAggregatorWorker(HiddenLocatorLocator connection, ArraySegment<byte> wrapper);
