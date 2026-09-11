using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis.API.Requester;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;
using VolumetricaAPI;

namespace VolAnalysis.Viewers;

internal class RemoteDefinitionViewer : LocatorRequest
{
	internal enum ConnectionError
	{
		Volume,
		[Display(Name = "Order (MBO)")]
		Order
	}

	internal enum ViewerPrimaryComputerEvaluationType
	{
		Delta,
		AskVolume,
		BidVolume
	}

	internal enum LocatorTreatWarningsSetting
	{
		Fixed,
		Fading
	}

	[CompilerGenerated]
	private ConnectionError _RemoteConnection;

	[CompilerGenerated]
	private int _GatewayCollectionViewerPerc;

	[CompilerGenerated]
	private int _MonoLoggerValue;

	[CompilerGenerated]
	private int _CollectionCollectorViewerPerc;

	[CompilerGenerated]
	private ViewerPrimaryComputerEvaluationType _ScopeTreeViewer;

	[CompilerGenerated]
	private LocatorTreatWarningsSetting _SeparatedCalc;

	[CompilerGenerated]
	private double m_ViewerCollectorTokenizer;

	private int _ContextServerLevel;

	private bool isPassiveMapWrapper;

	private int generalBufferViewerErrorCode;

	private long _ExpandableTagViewerPosition;

	private int m_TokenizerAuditorViewerFreq;

	private int _ConfigurationDefinitionVol;

	private bool isSetSorter;

	private bool isGenericVerifierViewer;

	private Common.WriterWrapperHandler _ConnectedRequest;

	private VisualWrapperRequester<long> m_DispatcherSubscriber;

	private static RemoteDefinitionViewer GenerateCustomizableModuleDecorator;

	[Category("Data Settings")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
	public ConnectionError InputData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ConnectionError)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1)]
	[Category("Data Settings")]
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

	[Category("Data Settings")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2)]
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3)]
	[Category("Data Settings")]
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

	[Category("Plot Settings")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
	public ViewerPrimaryComputerEvaluationType DisplayMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ViewerPrimaryComputerEvaluationType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1)]
	[Category("Plot Settings")]
	public LocatorTreatWarningsSetting ColorMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (LocatorTreatWarningsSetting)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0, MinValue = 0.0, MaxValue = 6.0, IncrementValue = 0.25, DecimalPosToShow = 2)]
	[Category("Std Dev")]
	public double StdDevLine
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	static RemoteDefinitionViewer()
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
					goto IL_001f;
				case 0:
					WrapperStreamEditor.PresentConfiguration();
					WriterCommandResolver.ReflectDefinitionSelector();
					DicSender.DetermineScopeCompiler(Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555758)), new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5AABF44D ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_877aca160c5349ef8f66247ed3998e6c), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x7B9BB9EB ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_d31258d3a4894c03ac95c76f9ac2cfba), MapResponderLocator.BasicRecordReg.Volume)
					{
						Hidden = true
					});
					return;
				case 1:
					break;
				}
				goto IL_00b0;
				IL_001f:
				if (num == 989)
				{
					break;
				}
				goto IL_00b0;
				IL_00b0:
				WrapperStreamEditor.CoverPortableElement();
				num2 = 1;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_40eea5bdecae4eab88fb94f74d66de22 != 0)
				{
					num2 = 0;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RemoteDefinitionViewer(ScopeEncryptor.HiddenModelDecider var1, MapResponderLocator.TransformableUserEncryptor result, int length_proc)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool requiresinit, bool applyattr)
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
	public override void DecodeListener(bool isi)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ViewSetSorter(bool containsreference)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool isvar1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool verifyspec)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer DisplaySortedContainer(Color info)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VisitAuthorizer()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RemoteDefinitionViewer CheckService()
	{
		return null;
	}
}
