using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Deepchart.Location;
using VolAnalysis.API.Requester;

namespace VolAnalysis.Viewers;

internal interface IMonoCalcViewer
{
	internal enum ProfileTokenDeciderStatus
	{
		Unknown
	}

	[SpecialName]
	IEnumerable<RequesterTagExplorer> FindAggregator();

	[SpecialName]
	bool SaveSequentialFunction();

	[SpecialName]
	void SaveTransformableReceiver(bool compareconfig);

	[SpecialName]
	bool OpenGenericField();

	[SpecialName]
	void OpenSimpleEnumerator(bool deletevar1);

	[SpecialName]
	int InitNode();

	[SpecialName]
	void OpenVisualSingleton(int def_length);

	[SpecialName]
	int MonitorAuthenticator();

	[SpecialName]
	void PopCollection(int idxitem);

	[SpecialName]
	bool CloneAnnotation();

	[SpecialName]
	void OpenPortableSolver(bool calckey);

	void OpenSymbolicNotifier();

	void ReflectEngine(int start_instance);

	void PostStack(MapResponderLocator.GeneratorResponder info, RequesterTagExplorer cont, bool isc, ProfileTokenDeciderStatus spec2 = ProfileTokenDeciderStatus.Unknown, bool isv3 = false, double? x4 = null);

	void SaveAdvancedExtractor(RequesterTagExplorer instance);

	void StoreSetElement(MapResponderLocator.GeneratorResponder info);
}
