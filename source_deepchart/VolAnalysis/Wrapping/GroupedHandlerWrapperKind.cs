using ProtoBuf;

namespace VolAnalysis.Wrapping;

[ProtoContract]
internal enum GroupedHandlerWrapperKind
{
	Unknown = 0,
	New = 1,
	Modify = 2,
	Cancel = 3,
	Filled = 5
}
