using System.Threading.Tasks;
using VolAnalysis.IO;

namespace VolAnalysis.Wrapping;

internal delegate Task WrapperValidatorHandler(string contractName, ReceiverValue.AxisName subType);
