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
namespace ImageCaptureCore {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>ICScannerDeviceDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[Protocol (Name = "ICScannerDeviceDelegate", WrapperType = typeof (ICScannerDeviceDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBecomeAvailable", Selector = "scannerDeviceDidBecomeAvailable:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICScannerDevice) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectFunctionalUnit", Selector = "scannerDevice:didSelectFunctionalUnit:error:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICScannerDevice), typeof (ImageCaptureCore.ICScannerFunctionalUnit), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidScanToUrl", Selector = "scannerDevice:didScanToURL:data:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICScannerDevice), typeof (NSUrl), typeof (NSData) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidScanToUrl", Selector = "scannerDevice:didScanToURL:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICScannerDevice), typeof (NSUrl) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidScanToBandData", Selector = "scannerDevice:didScanToBandData:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICScannerDevice), typeof (ImageCaptureCore.ICScannerBandData) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCompleteOverviewScan", Selector = "scannerDevice:didCompleteOverviewScanWithError:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICScannerDevice), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCompleteScan", Selector = "scannerDevice:didCompleteScanWithError:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICScannerDevice), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IICScannerDeviceDelegate : INativeObject, IDisposable, 
		ImageCaptureCore.IICDeviceDelegate
	{
		[global::Foundation.OptionalMember]
		[Export ("scannerDeviceDidBecomeAvailable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBecomeAvailable (ICScannerDevice scanner)
		{
			_DidBecomeAvailable (this, scanner);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidBecomeAvailable (IICScannerDeviceDelegate This, ICScannerDevice scanner)
		{
			var scanner__handle__ = scanner!.GetNonNullHandle (nameof (scanner));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("scannerDeviceDidBecomeAvailable:"), scanner__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scanner);
		}
		[global::Foundation.OptionalMember]
		[Export ("scannerDevice:didSelectFunctionalUnit:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectFunctionalUnit (ICScannerDevice scanner, ICScannerFunctionalUnit functionalUnit, NSError? error)
		{
			_DidSelectFunctionalUnit (this, scanner, functionalUnit, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSelectFunctionalUnit (IICScannerDeviceDelegate This, ICScannerDevice scanner, ICScannerFunctionalUnit functionalUnit, NSError? error)
		{
			var scanner__handle__ = scanner!.GetNonNullHandle (nameof (scanner));
			var functionalUnit__handle__ = functionalUnit!.GetNonNullHandle (nameof (functionalUnit));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("scannerDevice:didSelectFunctionalUnit:error:"), scanner__handle__, functionalUnit__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scanner);
			GC.KeepAlive (functionalUnit);
			GC.KeepAlive (error);
		}
		[global::Foundation.OptionalMember]
		[Export ("scannerDevice:didScanToURL:data:")]
		[ObsoletedOSPlatform ("macos10.7")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidScanToUrl (ICScannerDevice scanner, NSUrl url, NSData data)
		{
			_DidScanToUrl (this, scanner, url, data);
		}
		[ObsoletedOSPlatform ("macos10.7")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidScanToUrl (IICScannerDeviceDelegate This, ICScannerDevice scanner, NSUrl url, NSData data)
		{
			var scanner__handle__ = scanner!.GetNonNullHandle (nameof (scanner));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("scannerDevice:didScanToURL:data:"), scanner__handle__, url__handle__, data__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scanner);
			GC.KeepAlive (url);
			GC.KeepAlive (data);
		}
		[global::Foundation.OptionalMember]
		[Export ("scannerDevice:didScanToURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidScanToUrl (ICScannerDevice scanner, NSUrl url)
		{
			_DidScanToUrl (this, scanner, url);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidScanToUrl (IICScannerDeviceDelegate This, ICScannerDevice scanner, NSUrl url)
		{
			var scanner__handle__ = scanner!.GetNonNullHandle (nameof (scanner));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("scannerDevice:didScanToURL:"), scanner__handle__, url__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scanner);
			GC.KeepAlive (url);
		}
		[global::Foundation.OptionalMember]
		[Export ("scannerDevice:didScanToBandData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidScanToBandData (ICScannerDevice scanner, ICScannerBandData data)
		{
			_DidScanToBandData (this, scanner, data);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidScanToBandData (IICScannerDeviceDelegate This, ICScannerDevice scanner, ICScannerBandData data)
		{
			var scanner__handle__ = scanner!.GetNonNullHandle (nameof (scanner));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("scannerDevice:didScanToBandData:"), scanner__handle__, data__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scanner);
			GC.KeepAlive (data);
		}
		[global::Foundation.OptionalMember]
		[Export ("scannerDevice:didCompleteOverviewScanWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCompleteOverviewScan (ICScannerDevice scanner, NSError? error)
		{
			_DidCompleteOverviewScan (this, scanner, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidCompleteOverviewScan (IICScannerDeviceDelegate This, ICScannerDevice scanner, NSError? error)
		{
			var scanner__handle__ = scanner!.GetNonNullHandle (nameof (scanner));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("scannerDevice:didCompleteOverviewScanWithError:"), scanner__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scanner);
			GC.KeepAlive (error);
		}
		[global::Foundation.OptionalMember]
		[Export ("scannerDevice:didCompleteScanWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCompleteScan (ICScannerDevice scanner, NSError? error)
		{
			_DidCompleteScan (this, scanner, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidCompleteScan (IICScannerDeviceDelegate This, ICScannerDevice scanner, NSError? error)
		{
			var scanner__handle__ = scanner!.GetNonNullHandle (nameof (scanner));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("scannerDevice:didCompleteScanWithError:"), scanner__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scanner);
			GC.KeepAlive (error);
		}
		[DynamicDependencyAttribute ("DidBecomeAvailable(ImageCaptureCore.ICScannerDevice)")]
		[DynamicDependencyAttribute ("DidCompleteOverviewScan(ImageCaptureCore.ICScannerDevice,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidCompleteScan(ImageCaptureCore.ICScannerDevice,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidScanToBandData(ImageCaptureCore.ICScannerDevice,ImageCaptureCore.ICScannerBandData)")]
		[DynamicDependencyAttribute ("DidScanToUrl(ImageCaptureCore.ICScannerDevice,Foundation.NSUrl,Foundation.NSData)")]
		[DynamicDependencyAttribute ("DidScanToUrl(ImageCaptureCore.ICScannerDevice,Foundation.NSUrl)")]
		[DynamicDependencyAttribute ("DidSelectFunctionalUnit(ImageCaptureCore.ICScannerDevice,ImageCaptureCore.ICScannerFunctionalUnit,Foundation.NSError)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ICScannerDeviceDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IICScannerDeviceDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IICScannerDeviceDelegate" /> interface to support all the methods from the ICScannerDeviceDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IICScannerDeviceDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original ICScannerDeviceDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class ICScannerDeviceDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidBecomeAvailable (this IICScannerDeviceDelegate This, ICScannerDevice scanner)
		{
			var scanner__handle__ = scanner!.GetNonNullHandle (nameof (scanner));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("scannerDeviceDidBecomeAvailable:"), scanner__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scanner);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSelectFunctionalUnit (this IICScannerDeviceDelegate This, ICScannerDevice scanner, ICScannerFunctionalUnit functionalUnit, NSError? error)
		{
			var scanner__handle__ = scanner!.GetNonNullHandle (nameof (scanner));
			var functionalUnit__handle__ = functionalUnit!.GetNonNullHandle (nameof (functionalUnit));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("scannerDevice:didSelectFunctionalUnit:error:"), scanner__handle__, functionalUnit__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scanner);
			GC.KeepAlive (functionalUnit);
			GC.KeepAlive (error);
		}
		[ObsoletedOSPlatform ("macos10.7")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidScanToUrl (this IICScannerDeviceDelegate This, ICScannerDevice scanner, NSUrl url, NSData data)
		{
			var scanner__handle__ = scanner!.GetNonNullHandle (nameof (scanner));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("scannerDevice:didScanToURL:data:"), scanner__handle__, url__handle__, data__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scanner);
			GC.KeepAlive (url);
			GC.KeepAlive (data);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidScanToUrl (this IICScannerDeviceDelegate This, ICScannerDevice scanner, NSUrl url)
		{
			var scanner__handle__ = scanner!.GetNonNullHandle (nameof (scanner));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("scannerDevice:didScanToURL:"), scanner__handle__, url__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scanner);
			GC.KeepAlive (url);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidScanToBandData (this IICScannerDeviceDelegate This, ICScannerDevice scanner, ICScannerBandData data)
		{
			var scanner__handle__ = scanner!.GetNonNullHandle (nameof (scanner));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("scannerDevice:didScanToBandData:"), scanner__handle__, data__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scanner);
			GC.KeepAlive (data);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidCompleteOverviewScan (this IICScannerDeviceDelegate This, ICScannerDevice scanner, NSError? error)
		{
			var scanner__handle__ = scanner!.GetNonNullHandle (nameof (scanner));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("scannerDevice:didCompleteOverviewScanWithError:"), scanner__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scanner);
			GC.KeepAlive (error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidCompleteScan (this IICScannerDeviceDelegate This, ICScannerDevice scanner, NSError? error)
		{
			var scanner__handle__ = scanner!.GetNonNullHandle (nameof (scanner));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("scannerDevice:didCompleteScanWithError:"), scanner__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scanner);
			GC.KeepAlive (error);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class ICScannerDeviceDelegateWrapper : BaseWrapper, IICScannerDeviceDelegate {
		public ICScannerDeviceDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ICScannerDeviceDelegateWrapper))]
		static ICScannerDeviceDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("didRemoveDevice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidRemoveDevice (ICDevice device)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didRemoveDevice:"), device__handle__);
			GC.KeepAlive (device);
		}
	}
}
namespace ImageCaptureCore {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IICScannerDeviceDelegate" /> (for the protocol <c>ICScannerDeviceDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IICScannerDeviceDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__ImageCaptureCore_ICScannerDeviceDelegate", false)]
	[Model]
	public unsafe partial class ICScannerDeviceDelegate : NSObject, IICScannerDeviceDelegate, IICDeviceDelegate {
		/// <summary>Creates a new <see cref="ICScannerDeviceDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ICScannerDeviceDelegate () : base (NSObjectFlag.Empty)
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
		protected ICScannerDeviceDelegate (NSObjectFlag t) : base (t)
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
		protected internal ICScannerDeviceDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("scannerDeviceDidBecomeAvailable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBecomeAvailable (ICScannerDevice scanner)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("deviceDidBecomeReady:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBecomeReady (ICDevice device)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("deviceDidChangeName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeName (ICDevice device)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("deviceDidChangeSharingState:")]
		[ObsoletedOSPlatform ("macos10.13")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeSharingState (ICDevice device)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("device:didCloseSessionWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCloseSession (ICDevice device, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("scannerDevice:didCompleteOverviewScanWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCompleteOverviewScan (ICScannerDevice scanner, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("scannerDevice:didCompleteScanWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCompleteScan (ICScannerDevice scanner, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("device:didEncounterError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEncounterError (ICDevice device, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("device:didOpenSessionWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidOpenSession (ICDevice device, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("device:didReceiveButtonPress:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveButtonPress (ICDevice device, NSString buttonType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("device:didReceiveCustomNotification:data:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveCustomNotification (ICDevice device, NSDictionary<NSString, NSObject> notification, NSData data)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("device:didReceiveStatusInformation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveStatusInformation (ICDevice device, NSDictionary<NSString, NSObject> status)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didRemoveDevice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveDevice (ICDevice device)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("scannerDevice:didScanToBandData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidScanToBandData (ICScannerDevice scanner, ICScannerBandData data)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("scannerDevice:didScanToURL:data:")]
		[ObsoletedOSPlatform ("macos10.7")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidScanToUrl (ICScannerDevice scanner, NSUrl url, NSData data)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("scannerDevice:didScanToURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidScanToUrl (ICScannerDevice scanner, NSUrl url)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("scannerDevice:didSelectFunctionalUnit:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectFunctionalUnit (ICScannerDevice scanner, ICScannerFunctionalUnit functionalUnit, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class ICScannerDeviceDelegate */
}
