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
	/// Factory for creating <see cref="T:PrintCore.PDEPanel" /> instances. The factory receives the type of printer panel
	/// needed (page setup or print dialog) along with the current printer, and uses this information to
	/// determine which panels should be created.
	/// </summary>
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "PDEPlugIn", WrapperType = typeof (PDEPlugInWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetPanels", Selector = "PDEPanelsForType:withHostInfo:", ReturnType = typeof (PrintCore.IPDEPanel[]), ParameterType = new Type [] { typeof (string), typeof (PrintCore.IPDEPlugInCallbackProtocol) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IPDEPlugIn : INativeObject, IDisposable
	{
		/// <summary>
		/// Returns an array of <see cref="T:PrintCore.IPDEPanel" /> instances for the specified panel type and host context.
		/// </summary><param name="pdeType">
		/// The type of print panels to create (for example, <c>kGeneralPageSetupDialogTypeIDStr</c>
		/// for page setup or <c>kGeneralPrintDialogTypeIDStr</c> for the print dialog).
		/// </param><param name="host">
		/// A print-system-provided instance implementing <see cref="T:PrintCore.IPDEPlugInCallbackProtocol" />,
		/// used to obtain the current printer, print settings, or page format.
		/// </param><returns>
		/// An array of <see cref="T:PrintCore.IPDEPanel" /> instances, or <see langword="null" /> if no panels
		/// should be used for the given type.
		/// </returns>
		[global::Foundation.RequiredMember]
		[Export ("PDEPanelsForType:withHostInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IPDEPanel[]? GetPanels (string pdeType, IPDEPlugInCallbackProtocol host)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>
		/// Returns an array of <see cref="T:PrintCore.IPDEPanel" /> instances for the specified panel type and host context.
		/// </summary><param name="pdeType">
		/// The type of print panels to create (for example, <c>kGeneralPageSetupDialogTypeIDStr</c>
		/// for page setup or <c>kGeneralPrintDialogTypeIDStr</c> for the print dialog).
		/// </param><param name="host">
		/// A print-system-provided instance implementing <see cref="T:PrintCore.IPDEPlugInCallbackProtocol" />,
		/// used to obtain the current printer, print settings, or page format.
		/// </param><returns>
		/// An array of <see cref="T:PrintCore.IPDEPanel" /> instances, or <see langword="null" /> if no panels
		/// should be used for the given type.
		/// </returns>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IPDEPanel[]? _GetPanels (IPDEPlugIn This, string pdeType, IPDEPlugInCallbackProtocol host)
		{
			if (pdeType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (pdeType));
			var host__handle__ = host!.GetNonNullHandle (nameof (host));
			var nspdeType = CFString.CreateNative (pdeType);
			IPDEPanel[]? ret;
			ret = CFArray.ArrayFromHandle<IPDEPanel>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("PDEPanelsForType:withHostInfo:"), nspdeType, host__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (host);
			CFString.ReleaseNative (nspdeType);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetPanels(System.String,PrintCore.IPDEPlugInCallbackProtocol)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PDEPlugInWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IPDEPlugIn ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class PDEPlugInWrapper : BaseWrapper, IPDEPlugIn {
		public PDEPlugInWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PDEPlugInWrapper))]
		static PDEPlugInWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>
		/// Returns an array of <see cref="T:PrintCore.IPDEPanel" /> instances for the specified panel type and host context.
		/// </summary><param name="pdeType">
		/// The type of print panels to create (for example, <c>kGeneralPageSetupDialogTypeIDStr</c>
		/// for page setup or <c>kGeneralPrintDialogTypeIDStr</c> for the print dialog).
		/// </param><param name="host">
		/// A print-system-provided instance implementing <see cref="T:PrintCore.IPDEPlugInCallbackProtocol" />,
		/// used to obtain the current printer, print settings, or page format.
		/// </param><returns>
		/// An array of <see cref="T:PrintCore.IPDEPanel" /> instances, or <see langword="null" /> if no panels
		/// should be used for the given type.
		/// </returns>
		[Export ("PDEPanelsForType:withHostInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IPDEPanel[]? GetPanels (string pdeType, IPDEPlugInCallbackProtocol host)
		{
			if (pdeType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (pdeType));
			var host__handle__ = host!.GetNonNullHandle (nameof (host));
			var nspdeType = CFString.CreateNative (pdeType);
			IPDEPanel[]? ret;
			ret = CFArray.ArrayFromHandle<IPDEPanel>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("PDEPanelsForType:withHostInfo:"), nspdeType, host__handle__), false)!;
			GC.KeepAlive (host);
			CFString.ReleaseNative (nspdeType);
			return ret!;
		}
	}
}
namespace PrintCore {
	/// <summary>
	/// Factory for creating <see cref="T:PrintCore.PDEPanel" /> instances. The factory receives the type of printer panel
	/// needed (page setup or print dialog) along with the current printer, and uses this information to
	/// determine which panels should be created.
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__PrintCore_PDEPlugIn", false)]
	[Model]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe abstract partial class PDEPlugIn : NSObject, IPDEPlugIn {
		/// <summary>Creates a new <see cref="PDEPlugIn" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PDEPlugIn () : base (NSObjectFlag.Empty)
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
		protected PDEPlugIn (NSObjectFlag t) : base (t)
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
		protected internal PDEPlugIn (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <summary>
		/// Returns an array of <see cref="T:PrintCore.IPDEPanel" /> instances for the specified panel type and host context.
		/// </summary><param name="pdeType">
		/// The type of print panels to create (for example, <c>kGeneralPageSetupDialogTypeIDStr</c>
		/// for page setup or <c>kGeneralPrintDialogTypeIDStr</c> for the print dialog).
		/// </param><param name="host">
		/// A print-system-provided instance implementing <see cref="T:PrintCore.IPDEPlugInCallbackProtocol" />,
		/// used to obtain the current printer, print settings, or page format.
		/// </param><returns>
		/// An array of <see cref="T:PrintCore.IPDEPanel" /> instances, or <see langword="null" /> if no panels
		/// should be used for the given type.
		/// </returns>
		[Export ("PDEPanelsForType:withHostInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IPDEPanel[]? GetPanels (string pdeType, IPDEPlugInCallbackProtocol host)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class PDEPlugIn */
}
