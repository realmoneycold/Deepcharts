using VolAnalysis.API.Requester;

namespace Deepchart.Registry;

internal delegate void SymbolicWrapperReg(object sender, RequesterTagExplorer Ann, JoinedTokenizerRegFlags state, ref bool needToPaint, out bool discardReset);
