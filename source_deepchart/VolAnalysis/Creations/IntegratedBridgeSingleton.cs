using System.ComponentModel;
using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Creations;

[ProtoContract]
internal class IntegratedBridgeSingleton : IExtensible
{
	[ProtoContract]
	internal enum AllocatorUserConsentState
	{
		[ProtoEnum(Name = "STOPS_LIMITS")]
		m_IteratorRole,
		[ProtoEnum(Name = "OPPOSITE_QTY")]
		procFinder
	}

	private IExtension _TransferableEncryptorSingleton;

	[CompilerGenerated]
	private string _BufferTemplateTxt;

	[CompilerGenerated]
	private AllocatorUserConsentState _LocatorIteratorSingleton;

	[CompilerGenerated]
	private long[] m_IteratorTransformerSingletonData;

	private static IntegratedBridgeSingleton VerifyProvider;

	[ProtoMember(1)]
	[DefaultValue("")]
	public string AccountId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ProtoMember(2, Name = "type")]
	public AllocatorUserConsentState Type
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (AllocatorUserConsentState)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public long[] PeekPool
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IExtension IExtensible.GetExtensionObject(bool removeinfo)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IntegratedBridgeSingleton()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static IntegratedBridgeSingleton()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RunParser()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntegratedBridgeSingleton AttachConcreteContextBuffer()
	{
		return null;
	}
}
