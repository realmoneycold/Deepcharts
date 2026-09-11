using System.Windows.Input;
using VolAnalysis.Generators;

namespace Deepchart.Management;

internal delegate void ScalableClientAllocator(ExpandableHandlerGenerator hitTest, MouseButtonEventArgs mouse, ref bool needToPaint);
