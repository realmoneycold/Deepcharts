using System.Windows.Input;
using VolAnalysis.IO;

namespace Deepchart.Management;

internal delegate void RequesterGatewayAllocator(ExtendedBufferWriter hitTest, MouseButtonEventArgs mouse, ref bool needToPaint);
