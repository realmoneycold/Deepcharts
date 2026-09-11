using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using VolAnalysis.Drivers;
using VolAnalysis.Wrapping;

namespace Deepchart.Registry;

internal class RegMap : INotifyPropertyChanged
{
	[CompilerGenerated]
	private string _OrderedDefinitionRegText;

	[CompilerGenerated]
	private string iteratorParserName;

	[CompilerGenerated]
	private bool _IsRegParameter;

	[CompilerGenerated]
	private bool _IsCheckerService;

	[CompilerGenerated]
	private string m_RegFilterMsg;

	[CompilerGenerated]
	private Guid? compilerDictionary;

	[CompilerGenerated]
	private RegMap _RegPredicate;

	[CompilerGenerated]
	private readonly bool isRequestWorker;

	[CompilerGenerated]
	private bool m_IsRandomEncryptor;

	[CompilerGenerated]
	private bool m_IsExplorerParameter;

	[CompilerGenerated]
	private bool isErrorRequester;

	[CompilerGenerated]
	private string regPoolID;

	[CompilerGenerated]
	private string flexibleInterpreterRegNote;

	[CompilerGenerated]
	private string _EngineResolverStatus;

	[CompilerGenerated]
	private DateTime m_ClientWrapper;

	[CompilerGenerated]
	private ObservableCollection<RegMap> m_RegProfile;

	private DriverStruct m_RegStruct;

	[CompilerGenerated]
	private PropertyChangedEventHandler regDecorator;

	internal static RegMap ConcatRunner;

	public string Name
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

	public string Category
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

	public bool IsFolder
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

	public string FullPath
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

	public bool HasParent
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
	}

	public bool Owner
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

	public bool IsShared
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

	public string Author
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

	public string Description
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

	public string ImageUrl
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

	public DateTime LastEdit
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DateTime)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public ObservableCollection<RegMap> Children
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

	public bool CanPaste
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
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
	[SpecialName]
	[CompilerGenerated]
	public bool ExecuteCentralInspector()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void RestartChecker(bool isvalue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public Guid? OpenCommonReporter()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void CollectControllableTransmitter(Guid? reference)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public RegMap SaveEfficientIterator()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void FormatTree(RegMap instance)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public bool MergeProject()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void StoreExtendedProfiler(bool isasset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RegMap(DriverStruct key, string connection, RegMap proc = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DetachHandler(string instance, string ord)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StoreVisualReg()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegMap()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateControllableSender()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RegMap ExcludeRole()
	{
		return null;
	}
}
