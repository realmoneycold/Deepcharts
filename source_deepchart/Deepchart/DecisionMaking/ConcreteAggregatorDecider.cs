using System.Collections.Generic;
using Deepchart.Location;

namespace Deepchart.DecisionMaking;

internal delegate void ConcreteAggregatorDecider(LocatorSelectorTransaction sender, Dictionary<long, string> contrSymbDict, List<DeciderEvaluatorExplorer> buffers, ref int index);
