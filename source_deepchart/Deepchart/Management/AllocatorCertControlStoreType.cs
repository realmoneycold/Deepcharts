using ProtoBuf;

namespace Deepchart.Management;

[ProtoContract]
internal enum AllocatorCertControlStoreType
{
	[ProtoEnum(Name = "FIFO")]
	_AllocatorRecommenderSender,
	[ProtoEnum(Name = "LIFO")]
	m_ElementPolicy
}
