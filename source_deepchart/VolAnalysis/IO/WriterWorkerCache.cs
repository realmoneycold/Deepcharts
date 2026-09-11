using Deepchart.Location;

namespace VolAnalysis.IO;

internal delegate void WriterWorkerCache(string Symbol, LocatorQueueTransferProtocol fundType, long longVal, double doubleVal);
