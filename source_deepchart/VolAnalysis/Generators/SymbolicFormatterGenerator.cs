using System.Windows.Input;
using VolAnalysis.IO;

namespace VolAnalysis.Generators;

internal delegate void SymbolicFormatterGenerator(ExtendedBufferWriter hitTest, MouseEventArgs mouse, ref bool needToPaint);
