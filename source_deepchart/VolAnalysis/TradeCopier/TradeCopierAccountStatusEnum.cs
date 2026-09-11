using System;

namespace VolAnalysis.TradeCopier;

[Serializable]
internal enum TradeCopierAccountStatusEnum
{
	WaitingConnection,
	ConnectionNotFound,
	NotSynchronized,
	WaitingParentAccount,
	AccountNotFound,
	Ready
}
