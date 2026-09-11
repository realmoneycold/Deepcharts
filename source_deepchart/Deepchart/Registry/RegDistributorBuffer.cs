using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using Deepchart.DecisionMaking;
using VolAnalysis;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace Deepchart.Registry;

internal class RegDistributorBuffer : UserControl, IComponentConnector, IStyleConnector
{
	public static readonly DependencyProperty _RegBufferReg;

	[CompilerGenerated]
	private RoutedEventHandler m_NewClick;

	[CompilerGenerated]
	private RoutedEventHandler _ServiceProxy;

	[CompilerGenerated]
	private Action m_WorkspaceOpen;

	[CompilerGenerated]
	private EventHandler<Workspace> m_WorkspaceChanged;

	[CompilerGenerated]
	private EventHandler<Workspace> m_WorkspaceClosed;

	[CompilerGenerated]
	private EventHandler<Workspace> m_WorkspaceSave;

	[CompilerGenerated]
	private EventHandler<Workspace> m_WorkspaceSaveAs;

	private IEnumerable<Workspace> virtualSelectorReg;

	private Popup popWorkspaceList;

	private ListView lswConnections;

	internal Button btn;

	internal TextBlock lblMain;

	internal Border brdMenuIcon;

	private bool m_IsOrderedTransaction;

	private static RegDistributorBuffer EncryptDistributor;

	public IEnumerable ItemSource
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public event RoutedEventHandler NewClick
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action WorkspaceOpen
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public event EventHandler<Workspace> WorkspaceChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public event EventHandler<Workspace> WorkspaceClosed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public event EventHandler<Workspace> WorkspaceSave
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public event EventHandler<Workspace> WorkspaceSaveAs
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void SaveConnectedConverter(DependencyObject res, DependencyPropertyChangedEventArgs map)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void StoreAccessibleModule(RoutedEventHandler instance)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void StorePassiveDecorator(RoutedEventHandler key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RegDistributorBuffer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OpenExpandableAggregator(object instance, RoutedEventArgs counter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DecodePool(DependencyObject last, DependencyPropertyChangedEventArgs ivk)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DetachTracer(object def, EventArgs map)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveGroupedLogger(object info, EventArgs caller)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StoreIdentifiableTester(object asset, NotifyCollectionChangedEventArgs map)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StoreInternalTracker(object init, PropertyChangedEventArgs pol)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ControlTree(IEnumerable<Workspace> config)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StoreInterruptibleLocator(object asset, RoutedEventArgs token)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OpenIterableVerifier(object i, RoutedEventArgs visitor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OpenHiddenProvider(object def, RoutedEventArgs vis)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OpenModularParser(object def, RoutedEventArgs pred)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveLocalProgram(object config, RoutedEventArgs map)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OpenConfigurablePublisher(object ident, RoutedEventArgs attr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	public void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int value_Low, object ivk)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IStyleConnector.Connect(int row_first, object attr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegDistributorBuffer()
	{
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		_RegBufferReg = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x699B7A69 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_1612b9924ad849609afe1e85493cd616), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777352)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555943)), new PropertyMetadata((object)null, new PropertyChangedCallback(SaveConnectedConverter)));
		int num = 2;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_2ea89dc7adc644ac872bdb9b263ac659 != 0)
		{
			num = 0;
		}
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 0:
				return;
			}
			if (num2 == 988)
			{
				num = num2;
				continue;
			}
			return;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateIsolatedQueueExtractor()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RegDistributorBuffer GenerateSeparatedExtractorFinder()
	{
		return null;
	}
}
