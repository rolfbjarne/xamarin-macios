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
	/// <summary>This interface represents the Objective-C protocol <c>ICDeviceBrowserDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[Protocol (Name = "ICDeviceBrowserDelegate", WrapperType = typeof (ICDeviceBrowserDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidAddDevice", Selector = "deviceBrowser:didAddDevice:moreComing:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICDeviceBrowser), typeof (ImageCaptureCore.ICDevice), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidRemoveDevice", Selector = "deviceBrowser:didRemoveDevice:moreGoing:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICDeviceBrowser), typeof (ImageCaptureCore.ICDevice), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DeviceDidChangeName", Selector = "deviceBrowser:deviceDidChangeName:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICDeviceBrowser), typeof (ImageCaptureCore.ICDevice) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DeviceDidChangeSharingState", Selector = "deviceBrowser:deviceDidChangeSharingState:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICDeviceBrowser), typeof (ImageCaptureCore.ICDevice) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RequestsSelectDevice", Selector = "deviceBrowser:requestsSelectDevice:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICDeviceBrowser), typeof (ImageCaptureCore.ICDevice) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEnumerateLocalDevices", Selector = "deviceBrowserDidEnumerateLocalDevices:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICDeviceBrowser) }, ParameterByRef = new bool [] { false })]
	public partial interface IICDeviceBrowserDelegate : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("deviceBrowser:didAddDevice:moreComing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddDevice (ICDeviceBrowser browser, ICDevice device, bool moreComing)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidAddDevice (IICDeviceBrowserDelegate This, ICDeviceBrowser browser, ICDevice device, bool moreComing)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("deviceBrowser:didAddDevice:moreComing:"), browser__handle__, device__handle__, moreComing ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (device);
		}
		[global::Foundation.RequiredMember]
		[Export ("deviceBrowser:didRemoveDevice:moreGoing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveDevice (ICDeviceBrowser browser, ICDevice device, bool moreGoing)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRemoveDevice (IICDeviceBrowserDelegate This, ICDeviceBrowser browser, ICDevice device, bool moreGoing)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("deviceBrowser:didRemoveDevice:moreGoing:"), browser__handle__, device__handle__, moreGoing ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (device);
		}
		[global::Foundation.OptionalMember]
		[Export ("deviceBrowser:deviceDidChangeName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeviceDidChangeName (ICDeviceBrowser browser, ICDevice device)
		{
			_DeviceDidChangeName (this, browser, device);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DeviceDidChangeName (IICDeviceBrowserDelegate This, ICDeviceBrowser browser, ICDevice device)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("deviceBrowser:deviceDidChangeName:"), browser__handle__, device__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (device);
		}
		[global::Foundation.OptionalMember]
		[Export ("deviceBrowser:deviceDidChangeSharingState:")]
		[ObsoletedOSPlatform ("macos10.13")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeviceDidChangeSharingState (ICDeviceBrowser browser, ICDevice device)
		{
			_DeviceDidChangeSharingState (this, browser, device);
		}
		[ObsoletedOSPlatform ("macos10.13")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DeviceDidChangeSharingState (IICDeviceBrowserDelegate This, ICDeviceBrowser browser, ICDevice device)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("deviceBrowser:deviceDidChangeSharingState:"), browser__handle__, device__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (device);
		}
		[global::Foundation.OptionalMember]
		[Export ("deviceBrowser:requestsSelectDevice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RequestsSelectDevice (ICDeviceBrowser browser, ICDevice device)
		{
			_RequestsSelectDevice (this, browser, device);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RequestsSelectDevice (IICDeviceBrowserDelegate This, ICDeviceBrowser browser, ICDevice device)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("deviceBrowser:requestsSelectDevice:"), browser__handle__, device__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (device);
		}
		[global::Foundation.OptionalMember]
		[Export ("deviceBrowserDidEnumerateLocalDevices:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEnumerateLocalDevices (ICDeviceBrowser browser)
		{
			_DidEnumerateLocalDevices (this, browser);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidEnumerateLocalDevices (IICDeviceBrowserDelegate This, ICDeviceBrowser browser)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("deviceBrowserDidEnumerateLocalDevices:"), browser__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
		}
		[DynamicDependencyAttribute ("DeviceDidChangeName(ImageCaptureCore.ICDeviceBrowser,ImageCaptureCore.ICDevice)")]
		[DynamicDependencyAttribute ("DeviceDidChangeSharingState(ImageCaptureCore.ICDeviceBrowser,ImageCaptureCore.ICDevice)")]
		[DynamicDependencyAttribute ("DidAddDevice(ImageCaptureCore.ICDeviceBrowser,ImageCaptureCore.ICDevice,System.Boolean)")]
		[DynamicDependencyAttribute ("DidEnumerateLocalDevices(ImageCaptureCore.ICDeviceBrowser)")]
		[DynamicDependencyAttribute ("DidRemoveDevice(ImageCaptureCore.ICDeviceBrowser,ImageCaptureCore.ICDevice,System.Boolean)")]
		[DynamicDependencyAttribute ("RequestsSelectDevice(ImageCaptureCore.ICDeviceBrowser,ImageCaptureCore.ICDevice)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ICDeviceBrowserDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IICDeviceBrowserDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IICDeviceBrowserDelegate" /> interface to support all the methods from the ICDeviceBrowserDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IICDeviceBrowserDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original ICDeviceBrowserDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class ICDeviceBrowserDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DeviceDidChangeName (this IICDeviceBrowserDelegate This, ICDeviceBrowser browser, ICDevice device)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("deviceBrowser:deviceDidChangeName:"), browser__handle__, device__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (device);
		}
		[ObsoletedOSPlatform ("macos10.13")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DeviceDidChangeSharingState (this IICDeviceBrowserDelegate This, ICDeviceBrowser browser, ICDevice device)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("deviceBrowser:deviceDidChangeSharingState:"), browser__handle__, device__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (device);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RequestsSelectDevice (this IICDeviceBrowserDelegate This, ICDeviceBrowser browser, ICDevice device)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("deviceBrowser:requestsSelectDevice:"), browser__handle__, device__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (device);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidEnumerateLocalDevices (this IICDeviceBrowserDelegate This, ICDeviceBrowser browser)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("deviceBrowserDidEnumerateLocalDevices:"), browser__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class ICDeviceBrowserDelegateWrapper : BaseWrapper, IICDeviceBrowserDelegate {
		public ICDeviceBrowserDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ICDeviceBrowserDelegateWrapper))]
		static ICDeviceBrowserDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("deviceBrowser:didAddDevice:moreComing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidAddDevice (ICDeviceBrowser browser, ICDevice device, bool moreComing)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (this.Handle, Selector.GetHandle ("deviceBrowser:didAddDevice:moreComing:"), browser__handle__, device__handle__, moreComing ? (byte) 1 : (byte) 0);
			GC.KeepAlive (browser);
			GC.KeepAlive (device);
		}
		[Export ("deviceBrowser:didRemoveDevice:moreGoing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidRemoveDevice (ICDeviceBrowser browser, ICDevice device, bool moreGoing)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (this.Handle, Selector.GetHandle ("deviceBrowser:didRemoveDevice:moreGoing:"), browser__handle__, device__handle__, moreGoing ? (byte) 1 : (byte) 0);
			GC.KeepAlive (browser);
			GC.KeepAlive (device);
		}
	}
}
namespace ImageCaptureCore {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IICDeviceBrowserDelegate" /> (for the protocol <c>ICDeviceBrowserDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IICDeviceBrowserDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__ImageCaptureCore_ICDeviceBrowserDelegate", false)]
	[Model]
	public unsafe abstract partial class ICDeviceBrowserDelegate : NSObject, IICDeviceBrowserDelegate {
		/// <summary>Creates a new <see cref="ICDeviceBrowserDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected ICDeviceBrowserDelegate () : base (NSObjectFlag.Empty)
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
		protected ICDeviceBrowserDelegate (NSObjectFlag t) : base (t)
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
		protected internal ICDeviceBrowserDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("deviceBrowser:deviceDidChangeName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeviceDidChangeName (ICDeviceBrowser browser, ICDevice device)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("deviceBrowser:deviceDidChangeSharingState:")]
		[ObsoletedOSPlatform ("macos10.13")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeviceDidChangeSharingState (ICDeviceBrowser browser, ICDevice device)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("deviceBrowser:didAddDevice:moreComing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddDevice (ICDeviceBrowser browser, ICDevice device, bool moreComing)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("deviceBrowserDidEnumerateLocalDevices:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEnumerateLocalDevices (ICDeviceBrowser browser)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("deviceBrowser:didRemoveDevice:moreGoing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveDevice (ICDeviceBrowser browser, ICDevice device, bool moreGoing)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("deviceBrowser:requestsSelectDevice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RequestsSelectDevice (ICDeviceBrowser browser, ICDevice device)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class ICDeviceBrowserDelegate */
}
