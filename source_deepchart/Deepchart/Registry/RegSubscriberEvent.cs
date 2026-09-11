using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis.API.Requester;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;
using VolumetricaAPI;

namespace Deepchart.Registry;

internal class RegSubscriberEvent : LocatorRequest
{
	internal enum ViewerCLSComplianceSpec
	{
		Volume,
		[Display(Name = "Order (MBO)")]
		Order
	}

	internal enum ScopeConnectionRequesterStatus
	{
		Fixed,
		Fading
	}

	[CompilerGenerated]
	private ViewerCLSComplianceSpec m_RegEventNotifier;

	[CompilerGenerated]
	private int _HiddenSummarizerRegDist;

	[CompilerGenerated]
	private int regNotifierContainerStep;

	[CompilerGenerated]
	private int _RegContainerObserverCnt;

	[CompilerGenerated]
	private ScopeConnectionRequesterStatus mapperParameter;

	[CompilerGenerated]
	private bool _IsEnumeratorConverter;

	[CompilerGenerated]
	private IntegratedMapperWriter.ProgramSingletonTypes _AlphabeticResponderReg;

	[CompilerGenerated]
	private int m_MonoArgumentRegLimit;

	private int observerFilterScore;

	private bool _IsRegObserverMap;

	private int regMapParameterValue;

	private long regParameterFilterCount;

	private long regFilterPredicatePosition;

	private long scalableCollectorRegAge;

	private int _FilteredContainerIndex;

	private int m_DetachedCheckerVal;

	private bool m_IsRegPredicatePool;

	private bool isIsolatedExecutorReg;

	private Common.WriterWrapperHandler m_PortableTransmitter;

	private VisualWrapperRequester<long> _CentralManager;

	private VisualWrapperRequester<long> _SeparatedConnectionReg;

	private VisualWrapperRequester<long> logicalStateReg;

	private IntegratedMapperWriter regPoolProfile;

	private IntegratedMapperWriter regProfileStruct;

	private EncryptorCacheBuffer.Series_Prop _GenericMemberWrapper;

	private EncryptorCacheBuffer.Series_Prop m_TransferableWorkerReg;

	private EncryptorCacheBuffer.Series_Prop _ConvertibleTransmitter;

	internal static RegSubscriberEvent SimulateConvertibleRegFormatter;

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
	public ViewerCLSComplianceSpec InputData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ViewerCLSComplianceSpec)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, MaxValue = 2147483647.0)]
	public int FilterMin
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2, MaxValue = 2147483647.0)]
	[Category("General")]
	public int FilterMax
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3, MaxValue = 2147483647.0)]
	[Category("General")]
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

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 4)]
	public ScopeConnectionRequesterStatus DeltaColorMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ScopeConnectionRequesterStatus)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Smoothing")]
	[DisplayName("Enable")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
	public bool SmoothEnable
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

	[DisplayName("Average Type")]
	[Category("Smoothing")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1)]
	public IntegratedMapperWriter.ProgramSingletonTypes SmoothAverageType
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2, MaxValue = 2147483647.0)]
	[Category("Smoothing")]
	[DisplayName("Length")]
	public int SmoothLength
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
	static RegSubscriberEvent()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		int num = 0;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_08dae726799141e1901ebb35e52034f0 == 0)
		{
			num = 4;
		}
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				if (num2 == 988)
				{
					goto IL_0013;
				}
				break;
			case 0:
				break;
			}
			break;
			IL_0013:
			num = num2;
		}
		Type? typeFromHandle = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555762));
		MapResponderLocator.SortedPublisherWrapper sortedPublisherWrapper = new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x52A3E95C ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_ad988de0321245748764c114d1eb58f7), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x41BDCB5 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_42fbc1ba04824a6bbb0b9900cd13a5de), MapResponderLocator.BasicRecordReg.Volume);
		sortedPublisherWrapper.SetList(new List<string>
		{
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4F0FE6 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_46e95ad839704ca099af4c1d66957282),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x2095F300 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_44601b03c0d2455aaacef613651d5743),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x316AB3B2 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4d9096fd915e49d381ca886fe6751708)
		});
		DicSender.DetermineScopeCompiler(typeFromHandle, sortedPublisherWrapper);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RegSubscriberEvent(ScopeEncryptor.HiddenModelDecider i, MapResponderLocator.TransformableUserEncryptor pred, int mincomp)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool infoneeded, bool testvisitor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveVisualSynchronizer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StoreSequentialChooser()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DecodeListener(bool isasset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool testparam)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool extracttask)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FindProgram(bool excludev)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AssembleValue()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RegSubscriberEvent GenerateExpandableGatewayCompiler()
	{
		return null;
	}
}
