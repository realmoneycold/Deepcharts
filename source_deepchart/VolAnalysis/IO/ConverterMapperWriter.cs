using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace VolAnalysis.IO;

[ProtoContract]
internal class ConverterMapperWriter : IExtensible
{
	private IExtension automatedEncryptorWriter;

	[CompilerGenerated]
	private double _RoleFinalizer;

	[CompilerGenerated]
	private int m_InternalCompressorFlag;

	[CompilerGenerated]
	private int m_WriterMapperConfigurationCap;

	[CompilerGenerated]
	private int m_WriterConfigurationStackIdx;

	internal static ConverterMapperWriter TrackParameter;

	[ProtoMember(1)]
	public double Price
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public int Volume
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public int ControlAggregator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public int EvaluateLogger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IExtension IExtensible.GetExtensionObject(bool compareasset)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ConverterMapperWriter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConverterMapperWriter()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RestartProxy()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ConverterMapperWriter DirectSet()
	{
		return null;
	}
}
