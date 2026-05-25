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
	/// Callback protocol implemented by the print system that allows printing dialog extensions to obtain
	/// information about the current printer and print job, including session, settings, page format,
	/// printer, and PPD data.
	/// </summary>
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "PDEPlugInCallbackProtocol", WrapperType = typeof (PDEPlugInCallbackProtocolWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetPrintSession", Selector = "printSession", ReturnType = typeof (PrintCore.PMPrintSession))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetPrintSettings", Selector = "printSettings", ReturnType = typeof (PrintCore.PMPrintSettings))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetPageFormat", Selector = "pageFormat", ReturnType = typeof (PrintCore.PMPageFormat))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetPrinter", Selector = "PMPrinter", ReturnType = typeof (PrintCore.PMPrinter))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetPpdFile", Selector = "ppdFile", ReturnType = typeof (IntPtr))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WillChangePpdOptionKeyValue", Selector = "willChangePPDOptionKeyValue:ppdChoice:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IPDEPlugInCallbackProtocol : INativeObject, IDisposable
	{
		/// <summary>
		/// Returns the current print session.
		/// </summary><returns>The current <see cref="T:PrintCore.PMPrintSession" />, or <see langword="null" /> if unavailable.</returns>
		[global::Foundation.RequiredMember]
		[Export ("printSession")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PMPrintSession? GetPrintSession ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>
		/// Returns the current print session.
		/// </summary><returns>The current <see cref="T:PrintCore.PMPrintSession" />, or <see langword="null" /> if unavailable.</returns>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static PMPrintSession? _GetPrintSession (IPDEPlugInCallbackProtocol This)
		{
			PMPrintSession ret;
			ret = Runtime.GetINativeObject<global::PrintCore.PMPrintSession> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("printSession")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>
		/// Returns the print settings being modified by the dialog.
		/// </summary><returns>
		/// The current <see cref="T:PrintCore.PMPrintSettings" />, or <see langword="null" /> if the dialog
		/// is not operating on print settings (for example, a page setup dialog).
		/// </returns>
		[global::Foundation.RequiredMember]
		[Export ("printSettings")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PMPrintSettings? GetPrintSettings ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>
		/// Returns the print settings being modified by the dialog.
		/// </summary><returns>
		/// The current <see cref="T:PrintCore.PMPrintSettings" />, or <see langword="null" /> if the dialog
		/// is not operating on print settings (for example, a page setup dialog).
		/// </returns>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static PMPrintSettings? _GetPrintSettings (IPDEPlugInCallbackProtocol This)
		{
			PMPrintSettings ret;
			ret = Runtime.GetINativeObject<global::PrintCore.PMPrintSettings> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("printSettings")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>
		/// Returns the page format used by the dialog.
		/// </summary><returns>
		/// The current <see cref="T:PrintCore.PMPageFormat" />, or <see langword="null" /> if the dialog is
		/// operating without a page format.
		/// </returns>
		[global::Foundation.RequiredMember]
		[Export ("pageFormat")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PMPageFormat? GetPageFormat ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>
		/// Returns the page format used by the dialog.
		/// </summary><returns>
		/// The current <see cref="T:PrintCore.PMPageFormat" />, or <see langword="null" /> if the dialog is
		/// operating without a page format.
		/// </returns>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static PMPageFormat? _GetPageFormat (IPDEPlugInCallbackProtocol This)
		{
			PMPageFormat ret;
			ret = Runtime.GetINativeObject<global::PrintCore.PMPageFormat> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("pageFormat")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>
		/// Returns the current printer. For a page setup dialog this is the default printer;
		/// for a print dialog it is the currently selected printer.
		/// </summary><returns>The current <see cref="T:PrintCore.PMPrinter" />.</returns>
		[global::Foundation.RequiredMember]
		[Export ("PMPrinter")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PMPrinter GetPrinter ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>
		/// Returns the current printer. For a page setup dialog this is the default printer;
		/// for a print dialog it is the currently selected printer.
		/// </summary><returns>The current <see cref="T:PrintCore.PMPrinter" />.</returns>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static PMPrinter _GetPrinter (IPDEPlugInCallbackProtocol This)
		{
			PMPrinter ret;
			ret = Runtime.GetINativeObject<global::PrintCore.PMPrinter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("PMPrinter")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>
		/// Returns a pointer to the CUPS PPD structure (<c>ppd_file_s</c>) for the current printer.
		/// Use CUPS PPD functions to query and set options on the returned pointer.
		/// </summary><returns>
		/// A pointer to the native <c>ppd_file_s</c> CUPS PPD structure for the current printer.
		/// </returns>
		[global::Foundation.RequiredMember]
		[Export ("ppdFile")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetPpdFile ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>
		/// Returns a pointer to the CUPS PPD structure (<c>ppd_file_s</c>) for the current printer.
		/// Use CUPS PPD functions to query and set options on the returned pointer.
		/// </summary><returns>
		/// A pointer to the native <c>ppd_file_s</c> CUPS PPD structure for the current printer.
		/// </returns>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetPpdFile (IPDEPlugInCallbackProtocol This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("ppdFile"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>
		/// Notifies the print system that the plugin intends to change a PPD option choice.
		/// The print system validates the change and returns whether it is allowed.
		/// </summary><param name="option">The PPD main key identifying the option to change.</param><param name="choice">The desired PPD choice value for <paramref name="option" />.</param><returns><see langword="true" /> if the change is allowed; <see langword="false" /> if the change
		/// conflicts with another setting and should not proceed.
		/// </returns>
		[global::Foundation.RequiredMember]
		[Export ("willChangePPDOptionKeyValue:ppdChoice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WillChangePpdOptionKeyValue (string option, string choice)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>
		/// Notifies the print system that the plugin intends to change a PPD option choice.
		/// The print system validates the change and returns whether it is allowed.
		/// </summary><param name="option">The PPD main key identifying the option to change.</param><param name="choice">The desired PPD choice value for <paramref name="option" />.</param><returns><see langword="true" /> if the change is allowed; <see langword="false" /> if the change
		/// conflicts with another setting and should not proceed.
		/// </returns>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _WillChangePpdOptionKeyValue (IPDEPlugInCallbackProtocol This, string option, string choice)
		{
			if (option is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (option));
			if (choice is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (choice));
			var nsoption = CFString.CreateNative (option);
			var nschoice = CFString.CreateNative (choice);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("willChangePPDOptionKeyValue:ppdChoice:"), nsoption, nschoice);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsoption);
			CFString.ReleaseNative (nschoice);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("GetPageFormat()")]
		[DynamicDependencyAttribute ("GetPpdFile()")]
		[DynamicDependencyAttribute ("GetPrinter()")]
		[DynamicDependencyAttribute ("GetPrintSession()")]
		[DynamicDependencyAttribute ("GetPrintSettings()")]
		[DynamicDependencyAttribute ("WillChangePpdOptionKeyValue(System.String,System.String)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PDEPlugInCallbackProtocolWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IPDEPlugInCallbackProtocol ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class PDEPlugInCallbackProtocolWrapper : BaseWrapper, IPDEPlugInCallbackProtocol {
		public PDEPlugInCallbackProtocolWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PDEPlugInCallbackProtocolWrapper))]
		static PDEPlugInCallbackProtocolWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>
		/// Returns the current print session.
		/// </summary><returns>The current <see cref="T:PrintCore.PMPrintSession" />, or <see langword="null" /> if unavailable.</returns>
		[Export ("printSession")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PMPrintSession? GetPrintSession ()
		{
			PMPrintSession ret;
			ret = Runtime.GetINativeObject<global::PrintCore.PMPrintSession> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("printSession")), false)!;
			return ret;
		}
		/// <summary>
		/// Returns the print settings being modified by the dialog.
		/// </summary><returns>
		/// The current <see cref="T:PrintCore.PMPrintSettings" />, or <see langword="null" /> if the dialog
		/// is not operating on print settings (for example, a page setup dialog).
		/// </returns>
		[Export ("printSettings")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PMPrintSettings? GetPrintSettings ()
		{
			PMPrintSettings ret;
			ret = Runtime.GetINativeObject<global::PrintCore.PMPrintSettings> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("printSettings")), false)!;
			return ret;
		}
		/// <summary>
		/// Returns the page format used by the dialog.
		/// </summary><returns>
		/// The current <see cref="T:PrintCore.PMPageFormat" />, or <see langword="null" /> if the dialog is
		/// operating without a page format.
		/// </returns>
		[Export ("pageFormat")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PMPageFormat? GetPageFormat ()
		{
			PMPageFormat ret;
			ret = Runtime.GetINativeObject<global::PrintCore.PMPageFormat> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("pageFormat")), false)!;
			return ret;
		}
		/// <summary>
		/// Returns the current printer. For a page setup dialog this is the default printer;
		/// for a print dialog it is the currently selected printer.
		/// </summary><returns>The current <see cref="T:PrintCore.PMPrinter" />.</returns>
		[Export ("PMPrinter")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PMPrinter GetPrinter ()
		{
			PMPrinter ret;
			ret = Runtime.GetINativeObject<global::PrintCore.PMPrinter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("PMPrinter")), false)!;
			return ret;
		}
		/// <summary>
		/// Returns a pointer to the CUPS PPD structure (<c>ppd_file_s</c>) for the current printer.
		/// Use CUPS PPD functions to query and set options on the returned pointer.
		/// </summary><returns>
		/// A pointer to the native <c>ppd_file_s</c> CUPS PPD structure for the current printer.
		/// </returns>
		[Export ("ppdFile")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint GetPpdFile ()
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("ppdFile"));
			return ret;
		}
		/// <summary>
		/// Notifies the print system that the plugin intends to change a PPD option choice.
		/// The print system validates the change and returns whether it is allowed.
		/// </summary><param name="option">The PPD main key identifying the option to change.</param><param name="choice">The desired PPD choice value for <paramref name="option" />.</param><returns><see langword="true" /> if the change is allowed; <see langword="false" /> if the change
		/// conflicts with another setting and should not proceed.
		/// </returns>
		[Export ("willChangePPDOptionKeyValue:ppdChoice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool WillChangePpdOptionKeyValue (string option, string choice)
		{
			if (option is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (option));
			if (choice is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (choice));
			var nsoption = CFString.CreateNative (option);
			var nschoice = CFString.CreateNative (choice);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("willChangePPDOptionKeyValue:ppdChoice:"), nsoption, nschoice);
			CFString.ReleaseNative (nsoption);
			CFString.ReleaseNative (nschoice);
			return ret != 0;
		}
	}
}
namespace PrintCore {
	/// <summary>
	/// Callback protocol implemented by the print system that allows printing dialog extensions to obtain
	/// information about the current printer and print job, including session, settings, page format,
	/// printer, and PPD data.
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__PrintCore_PDEPlugInCallbackProtocol", false)]
	[Model]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe abstract partial class PDEPlugInCallbackProtocol : NSObject, IPDEPlugInCallbackProtocol {
		/// <summary>Creates a new <see cref="PDEPlugInCallbackProtocol" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PDEPlugInCallbackProtocol () : base (NSObjectFlag.Empty)
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
		protected PDEPlugInCallbackProtocol (NSObjectFlag t) : base (t)
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
		protected internal PDEPlugInCallbackProtocol (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <summary>
		/// Returns the page format used by the dialog.
		/// </summary><returns>
		/// The current <see cref="T:PrintCore.PMPageFormat" />, or <see langword="null" /> if the dialog is
		/// operating without a page format.
		/// </returns>
		[Export ("pageFormat")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PMPageFormat? GetPageFormat ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>
		/// Returns a pointer to the CUPS PPD structure (<c>ppd_file_s</c>) for the current printer.
		/// Use CUPS PPD functions to query and set options on the returned pointer.
		/// </summary><returns>
		/// A pointer to the native <c>ppd_file_s</c> CUPS PPD structure for the current printer.
		/// </returns>
		[Export ("ppdFile")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetPpdFile ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>
		/// Returns the current print session.
		/// </summary><returns>The current <see cref="T:PrintCore.PMPrintSession" />, or <see langword="null" /> if unavailable.</returns>
		[Export ("printSession")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PMPrintSession? GetPrintSession ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>
		/// Returns the print settings being modified by the dialog.
		/// </summary><returns>
		/// The current <see cref="T:PrintCore.PMPrintSettings" />, or <see langword="null" /> if the dialog
		/// is not operating on print settings (for example, a page setup dialog).
		/// </returns>
		[Export ("printSettings")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PMPrintSettings? GetPrintSettings ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>
		/// Returns the current printer. For a page setup dialog this is the default printer;
		/// for a print dialog it is the currently selected printer.
		/// </summary><returns>The current <see cref="T:PrintCore.PMPrinter" />.</returns>
		[Export ("PMPrinter")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PMPrinter GetPrinter ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>
		/// Notifies the print system that the plugin intends to change a PPD option choice.
		/// The print system validates the change and returns whether it is allowed.
		/// </summary><param name="option">The PPD main key identifying the option to change.</param><param name="choice">The desired PPD choice value for <paramref name="option" />.</param><returns><see langword="true" /> if the change is allowed; <see langword="false" /> if the change
		/// conflicts with another setting and should not proceed.
		/// </returns>
		[Export ("willChangePPDOptionKeyValue:ppdChoice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WillChangePpdOptionKeyValue (string option, string choice)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class PDEPlugInCallbackProtocol */
}
