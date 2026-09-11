using System.Runtime.InteropServices;

namespace Deepchart.DecisionMaking;

[ComImport]
[Guid("6C44DF74-72B9-4992-A1EC-EF996E0422D4")]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
internal interface IScheduledExecutorDecider
{
	void _VtblGap1_12();

	[DispId(18)]
	int Speak([MarshalAs(UnmanagedType.LPWStr)] string text, uint flags);

	[DispId(20)]
	int WaitUntilDone(uint timeout);

	[DispId(22)]
	int Pause();

	[DispId(23)]
	int Resume();

	[DispId(26)]
	int OpenAutomatedInitializer(int initmax);

	[DispId(27)]
	int FindFactory(out int instance);

	[DispId(28)]
	int SaveConvertibleAuthorizer(ushort configlength);

	[DispId(29)]
	int SaveConnectedService(out ushort value);
}
