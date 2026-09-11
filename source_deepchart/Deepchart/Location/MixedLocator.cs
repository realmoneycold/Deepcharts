using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Deepchart.Management;
using VolAnalysis.Generators;
using VolAnalysis.Wrapping;

namespace Deepchart.Location;

internal class MixedLocator : Window, IComponentConnector, IStyleConnector
{
	private List<CommonGenerator.DriverSpec> m_LocatorStructList;

	private CommonGenerator portableLocator;

	private Action<bool> _StaticAnnotation;

	private Dictionary<string, string> m_ElementLocatorDic;

	private IAllocatorTokenQueue m_ErrorSystem;

	private bool m_IsInternalLocator;

	private bool m_IsCacheManager;

	internal TabControl tbcIndList;

	internal TabItem tbpAll;

	internal ListView lbxAllInd;

	internal TabItem tbpVolume;

	internal ListView lbxVolInd;

	internal TabItem tbpCommon;

	internal ListView lbxCommonInd;

	internal ListView lbxUserInd;

	private bool _IsConnectedFilter;

	internal static MixedLocator SimulateInterruptibleConfig;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MixedLocator(CommonGenerator ident, Dictionary<string, string> attr, IAllocatorTokenQueue template, Action<bool> token2, bool includecont3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int WatchPredictor()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ConvertTransformer(object item, RoutedEventArgs cfg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearBasicMatcher(LocatorHandler ident)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadTree(object instance, RoutedEventArgs second)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetGenerator(object v, RoutedEventArgs ivk)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearEditableProc(object asset, MouseButtonEventArgs map)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisableProject(object instance, MouseButtonEventArgs token)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IdentifyStaticPredicate(object config, DragEventArgs cont)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int size_info, object b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IStyleConnector.Connect(int asset_High, object second)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MixedLocator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateIterableConfiguration()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MixedLocator SimulateHiddenRecommender()
	{
		return null;
	}
}
