using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Deepchart.Registry;
using VolAnalysis.API.Requester;
using VolAnalysis.Creations;
using VolAnalysis.CrmModels;
using VolAnalysis.Drivers;
using VolAnalysis.Wrapping;
using VolumetricaControls;

namespace Deepchart.Management;

internal class GenericAllocator : Window, IComponentConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAddFolder_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GenericAllocator _003C_003E4__this;

		public RegMap parent;

		public string folderName;

		private TaskAwaiter<UserConfigurationFolderHeaderViewModel> _003C_003Eu__1;

		internal static object SimulateTransformableDecryptorDefinition;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003CAddFolder_003Ed__37()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RemoveExtractor()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateSimpleSelectorInitializer()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCutAndPasteFile_003Ed__46 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GenericAllocator _003C_003E4__this;

		public RegMap dest;

		public RegMap src;

		private TaskAwaiter<UserConfigurationResourceHeaderViewModel> _003C_003Eu__1;

		internal static object DetachWatcher;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003CCutAndPasteFile_003Ed__46()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachVisualResponderAuthorizer()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ScanEditor()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCutAndPasteFolder_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GenericAllocator _003C_003E4__this;

		public RegMap dest;

		public RegMap src;

		private TaskAwaiter<UserConfigurationFolderHeaderViewModel> _003C_003Eu__1;

		private static object ExecuteCache;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003CCutAndPasteFolder_003Ed__40()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ControlSubscriber()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VerifyClient()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadResources_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GenericAllocator _003C_003E4__this;

		public string overrideLocalPath;

		private TaskAwaiter<UserConfigurationWrapperViewModel> _003C_003Eu__1;

		private static object RunExecutor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003CLoadResources_003Ed__27()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateConcreteListLocator()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateCentralLocatorVerifier()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRemoveFile_003Ed__45 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GenericAllocator _003C_003E4__this;

		public RegMap item;

		private TaskAwaiter _003C_003Eu__1;

		internal static object AttachAdvancedVerifierProvider;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003CRemoveFile_003Ed__45()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachOrderedProviderParser()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateAlphabeticParserProgram()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRemoveFolder_003Ed__39 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GenericAllocator _003C_003E4__this;

		public RegMap item;

		private TaskAwaiter _003C_003Eu__1;

		private static object CollectStream;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003CRemoveFolder_003Ed__39()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HandleManager()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateControllableParameterProxy()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRenameFile_003Ed__44 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GenericAllocator _003C_003E4__this;

		public string fileName;

		public RegMap item;

		private TaskAwaiter<UserConfigurationResourceHeaderViewModel> _003C_003Eu__1;

		internal static object GenerateRemoteProxySet;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003CRenameFile_003Ed__44()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateEfficientSetServer()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachTransferableServerModule()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRenameFolder_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GenericAllocator _003C_003E4__this;

		public RegMap item;

		public string folderName;

		private TaskAwaiter<UserConfigurationFolderHeaderViewModel> _003C_003Eu__1;

		private static object ViewDecryptor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003CRenameFolder_003Ed__38()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ProcessDefinition()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateDetachedValidatorReg()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private readonly string m_AllocatorFunctionMsg;

	[CompilerGenerated]
	private readonly string _AllocatorSystemMsg;

	[CompilerGenerated]
	private readonly bool m_IsDynamicAllocator;

	[CompilerGenerated]
	private readonly string _AllocatorConfigurationTitle;

	[CompilerGenerated]
	private List<LoggerRecord> _InterruptibleAllocatorList;

	private RegMap allocatorSubscriber;

	private RequesterCaseConversion _AllocatorProc;

	private DriverStruct allocatorState;

	internal ListView lswSources;

	internal SingletonNodeProxy spnContainer;

	internal Grid grdTree;

	internal ListView lswTree;

	internal Border brdSave;

	internal Grid grdSave;

	internal TextBoxWatermark txtSaveName;

	internal IconButton btnSaveNew;

	internal Border brdPreview;

	internal Grid grdPreview;

	internal TextBlock lblEmpty;

	internal TextBlock lblDescription;

	internal TextBlock lblAuthor;

	internal Label lblDate;

	private bool isDividedAllocator;

	internal static GenericAllocator SimulateAttachedVisitor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private string ReleaseIntegratedPolicy()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private string ReleaseCustomizableContainer()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private bool ClearJoinedTransaction()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private string GenerateNextConnectedMapper()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal List<LoggerRecord> AllocateAutomatableReporter()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal void EncodeCombinedTransmitter(List<LoggerRecord> reference)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GenericAllocator(bool containsvalue, string cont, string field, string cust2, bool overridepred3 = true, RequesterCaseConversion config4 = RequesterCaseConversion.PersonalLocal)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitMember(object info, RoutedEventArgs visitor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ObserveProcessor(object ident, SelectionChangedEventArgs pol)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AssignStatelessSelector(object var1, MouseEventArgs visitor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ObservableCollection<RegMap> ReleaseActiveInitializer(string v, RegMap ivk)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ObservableCollection<RegMap> AssignFilteredResponder(RegMap asset, List<UserConfigurationFolderHeaderViewModel> token, List<UserConfigurationResourceHeaderViewModel> comp)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RegMap ReleasePortableAuthorizer(RegMap reference, UserConfigurationResourceHeaderViewModel counter)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RegMap ReleaseSymbolicService(RegMap i, UserConfigurationFolderHeaderViewModel selection)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoadResources_003Ed__27))]
	private void AssignConcreteSchema(string reference = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AssignCentralValue(object res, RoutedEventArgs b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DefineAuthorizer(object param, MouseButtonEventArgs cust)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CustomizeService(object last, RoutedEventArgs ivk)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AssignAlphabeticLocator(object setup, RoutedEventArgs ivk)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ManageValue(object first, RoutedEventArgs ord)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseCommonProvider(object item, RoutedEventArgs attr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseControllableParser(object instance, RoutedEventArgs ivk)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AssignRemoteProgram(object info, RoutedEventArgs selection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseEfficientPublisher(object info, RoutedEventArgs selection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddFolder_003Ed__37))]
	private void AddFolder(string folderName, RegMap parent)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRenameFolder_003Ed__38))]
	private void RenameFolder(string folderName, RegMap item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveFolder_003Ed__39))]
	private void AllocateTransferableParameter(RegMap var1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCutAndPasteFolder_003Ed__40))]
	private void NewParser(RegMap asset, RegMap caller)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AssignGlobalSet(RegMap def)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AssignDetachedServer(RegMap var1, string visitor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AllocateExtendedModule(RegMap task)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRenameFile_003Ed__44))]
	private void AllocateCustomDecorator(string item, RegMap b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveFile_003Ed__45))]
	private void ReleaseAttachedValidator(RegMap res)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCutAndPasteFile_003Ed__46))]
	public void AllocateBasicReg(RegMap task, RegMap pred)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AssignOperationalFormatter(object asset, SelectionChangedEventArgs counter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AllocateFlexibleGateway(object item, MouseButtonEventArgs pred)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseEditableCompiler(object res, MouseButtonEventArgs vis)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int previousconfig, object map)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GenericAllocator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachBasicDecryptor()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GenericAllocator LoadViewer()
	{
		return null;
	}
}
