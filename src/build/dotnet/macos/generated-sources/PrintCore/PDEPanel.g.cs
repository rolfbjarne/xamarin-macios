//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace PrintCore {
	#pragma warning disable CS1573
	/// <summary>
	/// Represents a single print dialog panel that manages its own UI, settings persistence, and PPD option handling.
	/// </summary>
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "PDEPanel", WrapperType = typeof (PDEPanelWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WillShow", Selector = "willShow")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ShouldHide", Selector = "shouldHide", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SaveValues", Selector = "saveValuesAndReturnError:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RestoreValues", Selector = "restoreValuesAndReturnError:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { true })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetSupportedPpdOptionKeys", Selector = "supportedPPDOptionKeys", ReturnType = typeof (String[]))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PpdOptionKeyValueDidChange", Selector = "PPDOptionKeyValueDidChange:ppdChoice:", ParameterType = new Type [] { typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetPanelView", Selector = "panelView", ReturnType = typeof (NSView))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetPanelName", Selector = "panelName", ReturnType = typeof (string))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetPanelKind", Selector = "panelKind", ReturnType = typeof (string))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetSummaryInfo", Selector = "summaryInfo", ReturnType = typeof (global::Foundation.NSDictionary<NSString, NSString>))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldShowHelp", Selector = "shouldShowHelp", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldPrint", Selector = "shouldPrint", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PrintWindowWillClose", Selector = "printWindowWillClose:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	public partial interface IPDEPanel : INativeObject, IDisposable
	{
		/// <summary>
		/// Called when the panel is about to be displayed. Use this to perform any final preparations,
		/// such as lazily initializing the user interface.
		/// </summary>
		[global::Foundation.RequiredMember]
		[Export ("willShow")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillShow ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>
		/// Called when the panel is about to be displayed. Use this to perform any final preparations,
		/// such as lazily initializing the user interface.
		/// </summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillShow (IPDEPanel This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("willShow"));
			GC.KeepAlive (This);
		}
		/// <summary>
		/// Called before the panel is removed from view. Return <see langword="false" /> to prevent
		/// hiding (for example, if the user's input is invalid), or <see langword="true" /> to allow it.
		/// </summary><returns><see langword="true" /> if the panel may be hidden; otherwise, <see langword="false" />.
		/// </returns>
		[global::Foundation.RequiredMember]
		[Export ("shouldHide")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldHide ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>
		/// Called before the panel is removed from view. Return <see langword="false" /> to prevent
		/// hiding (for example, if the user's input is invalid), or <see langword="true" /> to allow it.
		/// </summary><returns><see langword="true" /> if the panel may be hidden; otherwise, <see langword="false" />.
		/// </returns>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldHide (IPDEPanel This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("shouldHide"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>
		/// Writes the current values from the panel's UI controls to the permanent store
		/// (print settings or page format, depending on the panel type).
		/// </summary><param name="error">On failure, contains an <see cref="T:Foundation.NSError" /> describing what went wrong.</param><returns><see langword="true" /> if the values were saved successfully; otherwise, <see langword="false" />.
		/// </returns>
		[global::Foundation.RequiredMember]
		[Export ("saveValuesAndReturnError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool SaveValues (out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>
		/// Writes the current values from the panel's UI controls to the permanent store
		/// (print settings or page format, depending on the panel type).
		/// </summary><param name="error">On failure, contains an <see cref="T:Foundation.NSError" /> describing what went wrong.</param><returns><see langword="true" /> if the values were saved successfully; otherwise, <see langword="false" />.
		/// </returns>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _SaveValues (IPDEPanel This, out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle (This.Handle, Selector.GetHandle ("saveValuesAndReturnError:"), &errorValue);
			GC.KeepAlive (This);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <summary>
		/// Refreshes the panel's UI elements by reading values from the page format or print settings.
		/// This is called before the panel is first shown and whenever the user selects a new preset.
		/// </summary><param name="error">On failure, contains an <see cref="T:Foundation.NSError" /> describing what went wrong.</param><returns><see langword="true" /> if the values were restored successfully; otherwise, <see langword="false" />.
		/// </returns>
		[global::Foundation.RequiredMember]
		[Export ("restoreValuesAndReturnError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool RestoreValues (out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>
		/// Refreshes the panel's UI elements by reading values from the page format or print settings.
		/// This is called before the panel is first shown and whenever the user selects a new preset.
		/// </summary><param name="error">On failure, contains an <see cref="T:Foundation.NSError" /> describing what went wrong.</param><returns><see langword="true" /> if the values were restored successfully; otherwise, <see langword="false" />.
		/// </returns>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _RestoreValues (IPDEPanel This, out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle (This.Handle, Selector.GetHandle ("restoreValuesAndReturnError:"), &errorValue);
			GC.KeepAlive (This);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <summary>
		/// Returns the PPD option keys that this panel is responsible for displaying.
		/// Any unclaimed keys will receive dynamically generated UI in the Printer Features panel.
		/// </summary><returns>
		/// An array of PPD option key strings, or <see langword="null" /> if the panel claims no keys.
		/// </returns>
		[global::Foundation.OptionalMember]
		[Export ("supportedPPDOptionKeys")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[]? GetSupportedPpdOptionKeys ()
		{
			return _GetSupportedPpdOptionKeys (this);
		}
		/// <summary>
		/// Returns the PPD option keys that this panel is responsible for displaying.
		/// Any unclaimed keys will receive dynamically generated UI in the Printer Features panel.
		/// </summary><returns>
		/// An array of PPD option key strings, or <see langword="null" /> if the panel claims no keys.
		/// </returns>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string[]? _GetSupportedPpdOptionKeys (IPDEPanel This)
		{
			string[] ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("supportedPPDOptionKeys")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>
		/// Notifies the panel that a PPD option choice was changed externally (for example, during
		/// conflict resolution). The panel should update its internal data for the specified key.
		/// </summary><param name="option">The PPD main key whose value changed.</param><param name="choice">The new PPD choice value for <paramref name="option" />.</param>
		[global::Foundation.RequiredMember]
		[Export ("PPDOptionKeyValueDidChange:ppdChoice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PpdOptionKeyValueDidChange (string option, string choice)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>
		/// Notifies the panel that a PPD option choice was changed externally (for example, during
		/// conflict resolution). The panel should update its internal data for the specified key.
		/// </summary><param name="option">The PPD main key whose value changed.</param><param name="choice">The new PPD choice value for <paramref name="option" />.</param>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PpdOptionKeyValueDidChange (IPDEPanel This, string option, string choice)
		{
			if (option is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (option));
			if (choice is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (choice));
			var nsoption = CFString.CreateNative (option);
			var nschoice = CFString.CreateNative (choice);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("PPDOptionKeyValueDidChange:ppdChoice:"), nsoption, nschoice);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsoption);
			CFString.ReleaseNative (nschoice);
		}
		/// <summary>
		/// Returns the panel's <see cref="T:AppKit.NSView" /> to be embedded into the print or page setup dialog.
		/// </summary><returns>
		/// The <see cref="T:AppKit.NSView" /> for this panel, or <see langword="null" /> if no view is available.
		/// </returns>
		[global::Foundation.RequiredMember]
		[Export ("panelView")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSView? GetPanelView ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>
		/// Returns the panel's <see cref="T:AppKit.NSView" /> to be embedded into the print or page setup dialog.
		/// </summary><returns>
		/// The <see cref="T:AppKit.NSView" /> for this panel, or <see langword="null" /> if no view is available.
		/// </returns>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::AppKit.NSView? _GetPanelView (IPDEPanel This)
		{
			global::AppKit.NSView ret;
			ret =  Runtime.GetNSObject<global::AppKit.NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("panelView")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>
		/// Returns the localized name of this panel, which appears in the panel menu within the print dialog.
		/// </summary><returns>A localized string representing the panel's display name.</returns>
		[global::Foundation.RequiredMember]
		[Export ("panelName")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetPanelName ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>
		/// Returns the localized name of this panel, which appears in the panel menu within the print dialog.
		/// </summary><returns>A localized string representing the panel's display name.</returns>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetPanelName (IPDEPanel This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("panelName")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>
		/// Returns the panel's kind identifier string. This is used to allow overriding built-in system panels.
		/// Return a unique string if the panel does not override any system panel.
		/// </summary><returns>A string identifying the kind of this panel.</returns>
		[global::Foundation.RequiredMember]
		[Export ("panelKind")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetPanelKind ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>
		/// Returns the panel's kind identifier string. This is used to allow overriding built-in system panels.
		/// Return a unique string if the panel does not override any system panel.
		/// </summary><returns>A string identifying the kind of this panel.</returns>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetPanelKind (IPDEPanel This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("panelKind")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>
		/// Returns a dictionary of localized key-value pairs describing the panel's current settings,
		/// suitable for display in a summary view (for example, key "Page Range", value "All").
		/// </summary><returns>
		/// A dictionary mapping setting names to their localized values, or <see langword="null" /> if no summary is available.
		/// </returns>
		[global::Foundation.RequiredMember]
		[Export ("summaryInfo")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, NSString>? GetSummaryInfo ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>
		/// Returns a dictionary of localized key-value pairs describing the panel's current settings,
		/// suitable for display in a summary view (for example, key "Page Range", value "All").
		/// </summary><returns>
		/// A dictionary mapping setting names to their localized values, or <see langword="null" /> if no summary is available.
		/// </returns>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDictionary<NSString, NSString>? _GetSummaryInfo (IPDEPanel This)
		{
			NSDictionary<NSString, NSString> ret;
			ret =  Runtime.GetNSObject<NSDictionary<NSString, NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("summaryInfo")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>
		/// Determines whether the system's default printing help should be shown. Return <see langword="false" />
		/// if the panel implements its own custom help; return <see langword="true" /> (or leave unimplemented)
		/// to use the default printing help.
		/// </summary><returns><see langword="true" /> to show default help; <see langword="false" /> if custom help is handled by the panel.
		/// </returns>
		[global::Foundation.OptionalMember]
		[Export ("shouldShowHelp")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldShowHelp ()
		{
			return _ShouldShowHelp (this);
		}
		/// <summary>
		/// Determines whether the system's default printing help should be shown. Return <see langword="false" />
		/// if the panel implements its own custom help; return <see langword="true" /> (or leave unimplemented)
		/// to use the default printing help.
		/// </summary><returns><see langword="true" /> to show default help; <see langword="false" /> if custom help is handled by the panel.
		/// </returns>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldShowHelp (IPDEPanel This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("shouldShowHelp"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>
		/// Called to determine whether printing should proceed based on the current panel state.
		/// Return <see langword="false" /> to prevent printing. Most panels do not need to implement this.
		/// </summary><returns><see langword="true" /> if printing should proceed; <see langword="false" /> to cancel the print operation.
		/// </returns>
		[global::Foundation.OptionalMember]
		[Export ("shouldPrint")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldPrint ()
		{
			return _ShouldPrint (this);
		}
		/// <summary>
		/// Called to determine whether printing should proceed based on the current panel state.
		/// Return <see langword="false" /> to prevent printing. Most panels do not need to implement this.
		/// </summary><returns><see langword="true" /> if printing should proceed; <see langword="false" /> to cancel the print operation.
		/// </returns>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldPrint (IPDEPanel This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("shouldPrint"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>
		/// Called when the print dialog is about to close. Use this for cleanup tasks such as removing
		/// notification observers.
		/// </summary><param name="userCanceled"><see langword="true" /> if the user canceled the dialog; <see langword="false" /> if the user confirmed.
		/// </param>
		[global::Foundation.OptionalMember]
		[Export ("printWindowWillClose:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrintWindowWillClose (bool userCanceled)
		{
			_PrintWindowWillClose (this, userCanceled);
		}
		/// <summary>
		/// Called when the print dialog is about to close. Use this for cleanup tasks such as removing
		/// notification observers.
		/// </summary><param name="userCanceled"><see langword="true" /> if the user canceled the dialog; <see langword="false" /> if the user confirmed.
		/// </param>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PrintWindowWillClose (IPDEPanel This, bool userCanceled)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("printWindowWillClose:"), userCanceled ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("GetPanelKind()")]
		[DynamicDependencyAttribute ("GetPanelName()")]
		[DynamicDependencyAttribute ("GetPanelView()")]
		[DynamicDependencyAttribute ("GetSummaryInfo()")]
		[DynamicDependencyAttribute ("GetSupportedPpdOptionKeys()")]
		[DynamicDependencyAttribute ("PpdOptionKeyValueDidChange(System.String,System.String)")]
		[DynamicDependencyAttribute ("PrintWindowWillClose(System.Boolean)")]
		[DynamicDependencyAttribute ("RestoreValues(Foundation.NSError@)")]
		[DynamicDependencyAttribute ("SaveValues(Foundation.NSError@)")]
		[DynamicDependencyAttribute ("ShouldHide()")]
		[DynamicDependencyAttribute ("ShouldPrint()")]
		[DynamicDependencyAttribute ("ShouldShowHelp()")]
		[DynamicDependencyAttribute ("WillShow()")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PDEPanelWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IPDEPanel ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class PDEPanelWrapper : BaseWrapper, IPDEPanel {
		public PDEPanelWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PDEPanelWrapper))]
		static PDEPanelWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>
		/// Called when the panel is about to be displayed. Use this to perform any final preparations,
		/// such as lazily initializing the user interface.
		/// </summary>
		[Export ("willShow")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void WillShow ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("willShow"));
		}
		/// <summary>
		/// Called before the panel is removed from view. Return <see langword="false" /> to prevent
		/// hiding (for example, if the user's input is invalid), or <see langword="true" /> to allow it.
		/// </summary><returns><see langword="true" /> if the panel may be hidden; otherwise, <see langword="false" />.
		/// </returns>
		[Export ("shouldHide")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool ShouldHide ()
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldHide"));
			return ret != 0;
		}
		/// <summary>
		/// Writes the current values from the panel's UI controls to the permanent store
		/// (print settings or page format, depending on the panel type).
		/// </summary><param name="error">On failure, contains an <see cref="T:Foundation.NSError" /> describing what went wrong.</param><returns><see langword="true" /> if the values were saved successfully; otherwise, <see langword="false" />.
		/// </returns>
		[Export ("saveValuesAndReturnError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe bool SaveValues (out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle (this.Handle, Selector.GetHandle ("saveValuesAndReturnError:"), &errorValue);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <summary>
		/// Refreshes the panel's UI elements by reading values from the page format or print settings.
		/// This is called before the panel is first shown and whenever the user selects a new preset.
		/// </summary><param name="error">On failure, contains an <see cref="T:Foundation.NSError" /> describing what went wrong.</param><returns><see langword="true" /> if the values were restored successfully; otherwise, <see langword="false" />.
		/// </returns>
		[Export ("restoreValuesAndReturnError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe bool RestoreValues (out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle (this.Handle, Selector.GetHandle ("restoreValuesAndReturnError:"), &errorValue);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <summary>
		/// Notifies the panel that a PPD option choice was changed externally (for example, during
		/// conflict resolution). The panel should update its internal data for the specified key.
		/// </summary><param name="option">The PPD main key whose value changed.</param><param name="choice">The new PPD choice value for <paramref name="option" />.</param>
		[Export ("PPDOptionKeyValueDidChange:ppdChoice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PpdOptionKeyValueDidChange (string option, string choice)
		{
			if (option is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (option));
			if (choice is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (choice));
			var nsoption = CFString.CreateNative (option);
			var nschoice = CFString.CreateNative (choice);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("PPDOptionKeyValueDidChange:ppdChoice:"), nsoption, nschoice);
			CFString.ReleaseNative (nsoption);
			CFString.ReleaseNative (nschoice);
		}
		/// <summary>
		/// Returns the panel's <see cref="T:AppKit.NSView" /> to be embedded into the print or page setup dialog.
		/// </summary><returns>
		/// The <see cref="T:AppKit.NSView" /> for this panel, or <see langword="null" /> if no view is available.
		/// </returns>
		[Export ("panelView")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::AppKit.NSView? GetPanelView ()
		{
			global::AppKit.NSView ret;
			ret =  Runtime.GetNSObject<global::AppKit.NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("panelView")), false)!;
			return ret;
		}
		/// <summary>
		/// Returns the localized name of this panel, which appears in the panel menu within the print dialog.
		/// </summary><returns>A localized string representing the panel's display name.</returns>
		[Export ("panelName")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string GetPanelName ()
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("panelName")), false)!;
			return ret;
		}
		/// <summary>
		/// Returns the panel's kind identifier string. This is used to allow overriding built-in system panels.
		/// Return a unique string if the panel does not override any system panel.
		/// </summary><returns>A string identifying the kind of this panel.</returns>
		[Export ("panelKind")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string GetPanelKind ()
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("panelKind")), false)!;
			return ret;
		}
		/// <summary>
		/// Returns a dictionary of localized key-value pairs describing the panel's current settings,
		/// suitable for display in a summary view (for example, key "Page Range", value "All").
		/// </summary><returns>
		/// A dictionary mapping setting names to their localized values, or <see langword="null" /> if no summary is available.
		/// </returns>
		[Export ("summaryInfo")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDictionary<NSString, NSString>? GetSummaryInfo ()
		{
			NSDictionary<NSString, NSString> ret;
			ret =  Runtime.GetNSObject<NSDictionary<NSString, NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("summaryInfo")), false)!;
			return ret;
		}
	}
}
namespace PrintCore {
	/// <summary>
	/// Represents a single print dialog panel that manages its own UI, settings persistence, and PPD option handling.
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__PrintCore_PDEPanel", false)]
	[Model]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe abstract partial class PDEPanel : NSObject, IPDEPanel {
		/// <summary>Creates a new <see cref="PDEPanel" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PDEPanel () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
			GC.KeepAlive (this);
			}
		}

		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		/// <remarks>
		///     <para>
		///         This constructor should be called by derived classes when they completely construct the object in managed code and merely want the runtime to allocate and initialize the <see cref="Foundation.NSObject" />.
		///         This is required to implement the two-step initialization process that Objective-C uses, the first step is to perform the object allocation, the second step is to initialize the object.
		///         When developers invoke this constructor, they take advantage of a direct path that goes all the way up to <see cref="Foundation.NSObject" /> to merely allocate the object's memory and bind the Objective-C and C# objects together.
		///         The actual initialization of the object is up to the developer.
		///     </para>
		///     <para>
		///         This constructor is typically used by the binding generator to allocate the object, but prevent the actual initialization to take place.
		///         Once the allocation has taken place, the constructor has to initialize the object.
		///         With constructors generated by the binding generator this means that it manually invokes one of the "init" methods to initialize the object.
		///     </para>
		///     <para>It is the developer's responsibility to completely initialize the object if they chain up using this constructor chain.</para>
		///     <para>
		///         In general, if the developer's constructor invokes the corresponding base implementation, then it should also call an Objective-C init method.
		///         If this is not the case, developers should instead chain to the proper constructor in their class.
		///     </para>
		///     <para>
		///         The argument value is ignored and merely ensures that the only code that is executed is the construction phase is the basic <see cref="Foundation.NSObject" /> allocation and runtime type registration.
		///         Typically the chaining would look like this:
		///     </para>
		///     <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // The NSObjectFlag constructor merely allocates the object and registers the C# class with the Objective-C runtime if necessary.
		/// // No actual initXxx method is invoked, that is done later in the constructor
		/// //
		/// // This is taken from the iOS SDK's source code for the UIView class:
		/// //
		/// [Export ("initWithFrame:")]
		/// public UIView (CGRect frame) : base (NSObjectFlag.Empty)
		/// {
		///     // Invoke the init method now.
		///     var initWithFrame = new Selector ("initWithFrame:").Handle;
		///     if (IsDirectBinding) {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, initWithFrame, frame);
		///     } else {
		///         unsafe {
		///             var __objc_super__ = new ObjCRuntime.ObjCSuper (this);
		///             Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (&__objc_super__, initWithFrame, frame);
		///         }
		///         GC.KeepAlive (this);
		///     }
		/// }
		/// ]]></code>
		///     </example>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PDEPanel (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">Pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PDEPanel (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <summary>
		/// Returns the panel's kind identifier string. This is used to allow overriding built-in system panels.
		/// Return a unique string if the panel does not override any system panel.
		/// </summary><returns>A string identifying the kind of this panel.</returns>
		[Export ("panelKind")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetPanelKind ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>
		/// Returns the localized name of this panel, which appears in the panel menu within the print dialog.
		/// </summary><returns>A localized string representing the panel's display name.</returns>
		[Export ("panelName")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetPanelName ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>
		/// Returns the panel's <see cref="T:AppKit.NSView" /> to be embedded into the print or page setup dialog.
		/// </summary><returns>
		/// The <see cref="T:AppKit.NSView" /> for this panel, or <see langword="null" /> if no view is available.
		/// </returns>
		[Export ("panelView")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSView? GetPanelView ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>
		/// Returns a dictionary of localized key-value pairs describing the panel's current settings,
		/// suitable for display in a summary view (for example, key "Page Range", value "All").
		/// </summary><returns>
		/// A dictionary mapping setting names to their localized values, or <see langword="null" /> if no summary is available.
		/// </returns>
		[Export ("summaryInfo")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, NSString>? GetSummaryInfo ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>
		/// Returns the PPD option keys that this panel is responsible for displaying.
		/// Any unclaimed keys will receive dynamically generated UI in the Printer Features panel.
		/// </summary><returns>
		/// An array of PPD option key strings, or <see langword="null" /> if the panel claims no keys.
		/// </returns>
		[Export ("supportedPPDOptionKeys")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[]? GetSupportedPpdOptionKeys ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>
		/// Notifies the panel that a PPD option choice was changed externally (for example, during
		/// conflict resolution). The panel should update its internal data for the specified key.
		/// </summary><param name="option">The PPD main key whose value changed.</param><param name="choice">The new PPD choice value for <paramref name="option" />.</param>
		[Export ("PPDOptionKeyValueDidChange:ppdChoice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PpdOptionKeyValueDidChange (string option, string choice)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>
		/// Called when the print dialog is about to close. Use this for cleanup tasks such as removing
		/// notification observers.
		/// </summary><param name="userCanceled"><see langword="true" /> if the user canceled the dialog; <see langword="false" /> if the user confirmed.
		/// </param>
		[Export ("printWindowWillClose:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrintWindowWillClose (bool userCanceled)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>
		/// Refreshes the panel's UI elements by reading values from the page format or print settings.
		/// This is called before the panel is first shown and whenever the user selects a new preset.
		/// </summary><param name="error">On failure, contains an <see cref="T:Foundation.NSError" /> describing what went wrong.</param><returns><see langword="true" /> if the values were restored successfully; otherwise, <see langword="false" />.
		/// </returns>
		[Export ("restoreValuesAndReturnError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool RestoreValues (out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>
		/// Writes the current values from the panel's UI controls to the permanent store
		/// (print settings or page format, depending on the panel type).
		/// </summary><param name="error">On failure, contains an <see cref="T:Foundation.NSError" /> describing what went wrong.</param><returns><see langword="true" /> if the values were saved successfully; otherwise, <see langword="false" />.
		/// </returns>
		[Export ("saveValuesAndReturnError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool SaveValues (out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>
		/// Called before the panel is removed from view. Return <see langword="false" /> to prevent
		/// hiding (for example, if the user's input is invalid), or <see langword="true" /> to allow it.
		/// </summary><returns><see langword="true" /> if the panel may be hidden; otherwise, <see langword="false" />.
		/// </returns>
		[Export ("shouldHide")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldHide ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>
		/// Called to determine whether printing should proceed based on the current panel state.
		/// Return <see langword="false" /> to prevent printing. Most panels do not need to implement this.
		/// </summary><returns><see langword="true" /> if printing should proceed; <see langword="false" /> to cancel the print operation.
		/// </returns>
		[Export ("shouldPrint")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldPrint ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>
		/// Determines whether the system's default printing help should be shown. Return <see langword="false" />
		/// if the panel implements its own custom help; return <see langword="true" /> (or leave unimplemented)
		/// to use the default printing help.
		/// </summary><returns><see langword="true" /> to show default help; <see langword="false" /> if custom help is handled by the panel.
		/// </returns>
		[Export ("shouldShowHelp")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldShowHelp ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>
		/// Called when the panel is about to be displayed. Use this to perform any final preparations,
		/// such as lazily initializing the user interface.
		/// </summary>
		[Export ("willShow")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillShow ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class PDEPanel */
}
