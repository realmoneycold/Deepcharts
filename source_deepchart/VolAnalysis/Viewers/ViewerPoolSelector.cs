using VolAnalysis.IO;

namespace VolAnalysis.Viewers;

internal delegate bool ViewerPoolSelector(WriterServerRecommender Sender, string Symbol, decimal Quantity, out string msg);
