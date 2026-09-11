using ProtoBuf;

namespace VolumetricaProtcol.Bridge;

[ProtoContract]
internal enum ConnectionStatusEnum
{
	Success = 1,
	Failed,
	Aborted
}
