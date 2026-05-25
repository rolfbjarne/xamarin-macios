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
	/// <summary>This interface represents the Objective-C protocol <c>ICDeviceDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[Protocol (Name = "ICDeviceDelegate", WrapperType = typeof (ICDeviceDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidRemoveDevice", Selector = "didRemoveDevice:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICDevice) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidOpenSession", Selector = "device:didOpenSessionWithError:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICDevice), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBecomeReady", Selector = "deviceDidBecomeReady:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICDevice) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCloseSession", Selector = "device:didCloseSessionWithError:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICDevice), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeName", Selector = "deviceDidChangeName:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICDevice) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeSharingState", Selector = "deviceDidChangeSharingState:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICDevice) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveStatusInformation", Selector = "device:didReceiveStatusInformation:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICDevice), typeof (global::Foundation.NSDictionary<NSString, NSObject>) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEncounterError", Selector = "device:didEncounterError:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICDevice), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveButtonPress", Selector = "device:didReceiveButtonPress:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICDevice), typeof (NSString) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveCustomNotification", Selector = "device:didReceiveCustomNotification:data:", ParameterType = new Type [] { typeof (ImageCaptureCore.ICDevice), typeof (global::Foundation.NSDictionary<NSString, NSObject>), typeof (NSData) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IICDeviceDelegate : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("didRemoveDevice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveDevice (ICDevice device)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRemoveDevice (IICDeviceDelegate This, ICDevice device)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didRemoveDevice:"), device__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (device);
		}
		[global::Foundation.OptionalMember]
		[Export ("device:didOpenSessionWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidOpenSession (ICDevice device, NSError? error)
		{
			_DidOpenSession (this, device, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidOpenSession (IICDeviceDelegate This, ICDevice device, NSError? error)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("device:didOpenSessionWithError:"), device__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (device);
			GC.KeepAlive (error);
		}
		[global::Foundation.OptionalMember]
		[Export ("deviceDidBecomeReady:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBecomeReady (ICDevice device)
		{
			_DidBecomeReady (this, device);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidBecomeReady (IICDeviceDelegate This, ICDevice device)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("deviceDidBecomeReady:"), device__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (device);
		}
		[global::Foundation.OptionalMember]
		[Export ("device:didCloseSessionWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCloseSession (ICDevice device, NSError? error)
		{
			_DidCloseSession (this, device, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidCloseSession (IICDeviceDelegate This, ICDevice device, NSError? error)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("device:didCloseSessionWithError:"), device__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (device);
			GC.KeepAlive (error);
		}
		[global::Foundation.OptionalMember]
		[Export ("deviceDidChangeName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeName (ICDevice device)
		{
			_DidChangeName (this, device);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidChangeName (IICDeviceDelegate This, ICDevice device)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("deviceDidChangeName:"), device__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (device);
		}
		[global::Foundation.OptionalMember]
		[Export ("deviceDidChangeSharingState:")]
		[ObsoletedOSPlatform ("macos10.13")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeSharingState (ICDevice device)
		{
			_DidChangeSharingState (this, device);
		}
		[ObsoletedOSPlatform ("macos10.13")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidChangeSharingState (IICDeviceDelegate This, ICDevice device)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("deviceDidChangeSharingState:"), device__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (device);
		}
		[global::Foundation.OptionalMember]
		[Export ("device:didReceiveStatusInformation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveStatusInformation (ICDevice device, NSDictionary<NSString, NSObject> status)
		{
			_DidReceiveStatusInformation (this, device, status);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveStatusInformation (IICDeviceDelegate This, ICDevice device, NSDictionary<NSString, NSObject> status)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			var status__handle__ = status!.GetNonNullHandle (nameof (status));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("device:didReceiveStatusInformation:"), device__handle__, status__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (device);
			GC.KeepAlive (status);
		}
		[global::Foundation.OptionalMember]
		[Export ("device:didEncounterError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEncounterError (ICDevice device, NSError? error)
		{
			_DidEncounterError (this, device, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidEncounterError (IICDeviceDelegate This, ICDevice device, NSError? error)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("device:didEncounterError:"), device__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (device);
			GC.KeepAlive (error);
		}
		[global::Foundation.OptionalMember]
		[Export ("device:didReceiveButtonPress:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveButtonPress (ICDevice device, NSString buttonType)
		{
			_DidReceiveButtonPress (this, device, buttonType);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveButtonPress (IICDeviceDelegate This, ICDevice device, NSString buttonType)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			var buttonType__handle__ = buttonType!.GetNonNullHandle (nameof (buttonType));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("device:didReceiveButtonPress:"), device__handle__, buttonType__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (device);
			GC.KeepAlive (buttonType);
		}
		[global::Foundation.OptionalMember]
		[Export ("device:didReceiveCustomNotification:data:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveCustomNotification (ICDevice device, NSDictionary<NSString, NSObject> notification, NSData data)
		{
			_DidReceiveCustomNotification (this, device, notification, data);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveCustomNotification (IICDeviceDelegate This, ICDevice device, NSDictionary<NSString, NSObject> notification, NSData data)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("device:didReceiveCustomNotification:data:"), device__handle__, notification__handle__, data__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (device);
			GC.KeepAlive (notification);
			GC.KeepAlive (data);
		}
		[DynamicDependencyAttribute ("DidBecomeReady(ImageCaptureCore.ICDevice)")]
		[DynamicDependencyAttribute ("DidChangeName(ImageCaptureCore.ICDevice)")]
		[DynamicDependencyAttribute ("DidChangeSharingState(ImageCaptureCore.ICDevice)")]
		[DynamicDependencyAttribute ("DidCloseSession(ImageCaptureCore.ICDevice,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidEncounterError(ImageCaptureCore.ICDevice,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidOpenSession(ImageCaptureCore.ICDevice,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidReceiveButtonPress(ImageCaptureCore.ICDevice,Foundation.NSString)")]
		[DynamicDependencyAttribute ("DidReceiveCustomNotification(ImageCaptureCore.ICDevice,Foundation.NSDictionary{Foundation.NSString,Foundation.NSObject},Foundation.NSData)")]
		[DynamicDependencyAttribute ("DidReceiveStatusInformation(ImageCaptureCore.ICDevice,Foundation.NSDictionary{Foundation.NSString,Foundation.NSObject})")]
		[DynamicDependencyAttribute ("DidRemoveDevice(ImageCaptureCore.ICDevice)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ICDeviceDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IICDeviceDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IICDeviceDelegate" /> interface to support all the methods from the ICDeviceDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IICDeviceDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original ICDeviceDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class ICDeviceDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidOpenSession (this IICDeviceDelegate This, ICDevice device, NSError? error)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("device:didOpenSessionWithError:"), device__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (device);
			GC.KeepAlive (error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidBecomeReady (this IICDeviceDelegate This, ICDevice device)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("deviceDidBecomeReady:"), device__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (device);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidCloseSession (this IICDeviceDelegate This, ICDevice device, NSError? error)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("device:didCloseSessionWithError:"), device__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (device);
			GC.KeepAlive (error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidChangeName (this IICDeviceDelegate This, ICDevice device)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("deviceDidChangeName:"), device__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (device);
		}
		[ObsoletedOSPlatform ("macos10.13")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidChangeSharingState (this IICDeviceDelegate This, ICDevice device)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("deviceDidChangeSharingState:"), device__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (device);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidReceiveStatusInformation (this IICDeviceDelegate This, ICDevice device, NSDictionary<NSString, NSObject> status)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			var status__handle__ = status!.GetNonNullHandle (nameof (status));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("device:didReceiveStatusInformation:"), device__handle__, status__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (device);
			GC.KeepAlive (status);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidEncounterError (this IICDeviceDelegate This, ICDevice device, NSError? error)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("device:didEncounterError:"), device__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (device);
			GC.KeepAlive (error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidReceiveButtonPress (this IICDeviceDelegate This, ICDevice device, NSString buttonType)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			var buttonType__handle__ = buttonType!.GetNonNullHandle (nameof (buttonType));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("device:didReceiveButtonPress:"), device__handle__, buttonType__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (device);
			GC.KeepAlive (buttonType);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidReceiveCustomNotification (this IICDeviceDelegate This, ICDevice device, NSDictionary<NSString, NSObject> notification, NSData data)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("device:didReceiveCustomNotification:data:"), device__handle__, notification__handle__, data__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (device);
			GC.KeepAlive (notification);
			GC.KeepAlive (data);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class ICDeviceDelegateWrapper : BaseWrapper, IICDeviceDelegate {
		public ICDeviceDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ICDeviceDelegateWrapper))]
		static ICDeviceDelegateWrapper ()
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
	///   <para>This is a class that implements the interface <see cref="IICDeviceDelegate" /> (for the protocol <c>ICDeviceDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IICDeviceDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__ImageCaptureCore_ICDeviceDelegate", false)]
	[Model]
	public unsafe abstract partial class ICDeviceDelegate : NSObject, IICDeviceDelegate {
		/// <summary>Creates a new <see cref="ICDeviceDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected ICDeviceDelegate () : base (NSObjectFlag.Empty)
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
		protected ICDeviceDelegate (NSObjectFlag t) : base (t)
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
		protected internal ICDeviceDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
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
	} /* class ICDeviceDelegate */
}
