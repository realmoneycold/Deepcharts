using System.Windows.Input;
using VolAnalysis.Generators;

namespace VolAnalysis.IO;

internal delegate void WriterFilterAuthenticator(ExpandableHandlerGenerator hitTest, MouseEventArgs mouse, ref bool needToPaint);
