using System;

namespace VolAnalysis.Generators;

internal delegate void ConvertibleChooserGenerator(DateTime utcDt, string Symbol, bool NeedToReset);
