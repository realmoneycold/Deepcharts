using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;

namespace VolAnalysis.Wrapping;

internal class ProjectWrapper : LocatorRequest
{
	internal enum IsolatedRequesterAllocator
	{
		High,
		Low,
		Open,
		Close,
		Volume
	}

	[CompilerGenerated]
	private IsolatedRequesterAllocator _WrapperProvider;

	[CompilerGenerated]
	private int _RemoteResponders;

	[CompilerGenerated]
	private bool m_IsWrapperQueue;

	[CompilerGenerated]
	private IntegratedMapperWriter.ProgramSingletonTypes listAuthenticator;

	[CompilerGenerated]
	private int _AutomatedWrapperErrorCode;

	private IntegratedMapperWriter basicWrapper;

	internal static ProjectWrapper ReadWriter;

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
	public IsolatedRequesterAllocator InputData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (IsolatedRequesterAllocator)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, MinValue = 1.0, MaxValue = 2147483647.0)]
	public int Length
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

	[DisplayName("Enable")]
	[Category("Average")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
	public bool ActivateAvg
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Average")]
	[DisplayName("Average Type")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1)]
	public IntegratedMapperWriter.ProgramSingletonTypes AvgType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (IntegratedMapperWriter.ProgramSingletonTypes)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Average")]
	[DisplayName("Length")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2)]
	public int AvgPeriod
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
	static ProjectWrapper()
	{
		WrapperStreamEditor.AnalyzeRecord();
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 989)
					{
						break;
					}
					goto case 1;
				case 1:
					WrapperStreamEditor.CoverPortableElement();
					num2 = 0;
					if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_85ba16e4dce54edcb3824b8a2ce69527 != 0)
					{
						num2 = 0;
					}
					continue;
				case 0:
					WrapperStreamEditor.PresentConfiguration();
					WriterCommandResolver.ReflectDefinitionSelector();
					DicSender.DetermineScopeCompiler(Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555451)), new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x6230729B ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_08dae726799141e1901ebb35e52034f0), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x7E456FE5 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_64fb42df218c4a83b207dfafc0a085d2), MapResponderLocator.BasicRecordReg.Oscillator));
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ProjectWrapper(ScopeEncryptor.HiddenModelDecider info, MapResponderLocator.TransformableUserEncryptor pred, int sizethird)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool skipinfo, bool iscounter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DecodeListener(bool isvar1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StoreSequentialChooser()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EncapsulateEfficientRecord(bool verifyasset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool isconfig)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool isinit)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachDynamicSynchronizerSingleton()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ProjectWrapper SimulateReadableSingletonCalculator()
	{
		return null;
	}
}
