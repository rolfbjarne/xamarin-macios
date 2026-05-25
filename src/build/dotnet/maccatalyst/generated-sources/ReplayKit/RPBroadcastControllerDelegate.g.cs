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
using UIKit;
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
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
namespace ReplayKit {
	#pragma warning disable CS1573
	/// <summary>Delegate object that responds to changes in a broadcast.</summary><related type="externalDocumentation" href="https://developer.apple.com/reference/ReplayKit/RPBroadcastControllerDelegate">Apple documentation for <c>RPBroadcastControllerDelegate</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "RPBroadcastControllerDelegate", WrapperType = typeof (RPBroadcastControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinish", Selector = "broadcastController:didFinishWithError:", ParameterType = new Type [] { typeof (ReplayKit.RPBroadcastController), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateServiceInfo", Selector = "broadcastController:didUpdateServiceInfo:", ParameterType = new Type [] { typeof (ReplayKit.RPBroadcastController), typeof (global::Foundation.NSDictionary<NSString, INSCoding>) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateBroadcastUrl", Selector = "broadcastController:didUpdateBroadcastURL:", ParameterType = new Type [] { typeof (ReplayKit.RPBroadcastController), typeof (NSUrl) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IRPBroadcastControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="broadcastController">The controller for the broadcast that finished.</param><param name="error"><para>The error, if any, that ended the broadcast.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("broadcastController:didFinishWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinish (RPBroadcastController broadcastController, NSError? error)
		{
			_DidFinish (this, broadcastController, error);
		}
		/// <param name="broadcastController">The controller for the broadcast that finished.</param><param name="error"><para>The error, if any, that ended the broadcast.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinish (IRPBroadcastControllerDelegate This, RPBroadcastController broadcastController, NSError? error)
		{
			var broadcastController__handle__ = broadcastController!.GetNonNullHandle (nameof (broadcastController));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("broadcastController:didFinishWithError:"), broadcastController__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (broadcastController);
			GC.KeepAlive (error);
		}
		/// <param name="broadcastController">To be added.</param><param name="serviceInfo">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("broadcastController:didUpdateServiceInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateServiceInfo (RPBroadcastController broadcastController, NSDictionary<NSString, INSCoding> serviceInfo)
		{
			_DidUpdateServiceInfo (this, broadcastController, serviceInfo);
		}
		/// <param name="broadcastController">To be added.</param><param name="serviceInfo">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateServiceInfo (IRPBroadcastControllerDelegate This, RPBroadcastController broadcastController, NSDictionary<NSString, INSCoding> serviceInfo)
		{
			var broadcastController__handle__ = broadcastController!.GetNonNullHandle (nameof (broadcastController));
			var serviceInfo__handle__ = serviceInfo!.GetNonNullHandle (nameof (serviceInfo));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("broadcastController:didUpdateServiceInfo:"), broadcastController__handle__, serviceInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (broadcastController);
			GC.KeepAlive (serviceInfo);
		}
		/// <param name="broadcastController">To be added.</param><param name="broadcastUrl">To be added.</param><summary>Method that is called when the broadcast URL is updated.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("broadcastController:didUpdateBroadcastURL:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateBroadcastUrl (RPBroadcastController broadcastController, NSUrl broadcastUrl)
		{
			_DidUpdateBroadcastUrl (this, broadcastController, broadcastUrl);
		}
		/// <param name="broadcastController">To be added.</param><param name="broadcastUrl">To be added.</param><summary>Method that is called when the broadcast URL is updated.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateBroadcastUrl (IRPBroadcastControllerDelegate This, RPBroadcastController broadcastController, NSUrl broadcastUrl)
		{
			var broadcastController__handle__ = broadcastController!.GetNonNullHandle (nameof (broadcastController));
			var broadcastUrl__handle__ = broadcastUrl!.GetNonNullHandle (nameof (broadcastUrl));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("broadcastController:didUpdateBroadcastURL:"), broadcastController__handle__, broadcastUrl__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (broadcastController);
			GC.KeepAlive (broadcastUrl);
		}
		[DynamicDependencyAttribute ("DidFinish(ReplayKit.RPBroadcastController,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidUpdateBroadcastUrl(ReplayKit.RPBroadcastController,Foundation.NSUrl)")]
		[DynamicDependencyAttribute ("DidUpdateServiceInfo(ReplayKit.RPBroadcastController,Foundation.NSDictionary{Foundation.NSString,Foundation.INSCoding})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (RPBroadcastControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IRPBroadcastControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IRPBroadcastControllerDelegate" /> interface to support all the methods from the RPBroadcastControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IRPBroadcastControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original RPBroadcastControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class RPBroadcastControllerDelegate_Extensions {
		/// <param name="broadcastController">The controller for the broadcast that finished.</param><param name="error"><para>The error, if any, that ended the broadcast.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinish (this IRPBroadcastControllerDelegate This, RPBroadcastController broadcastController, NSError? error)
		{
			var broadcastController__handle__ = broadcastController!.GetNonNullHandle (nameof (broadcastController));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("broadcastController:didFinishWithError:"), broadcastController__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (broadcastController);
			GC.KeepAlive (error);
		}
		/// <param name="broadcastController">To be added.</param><param name="serviceInfo">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateServiceInfo (this IRPBroadcastControllerDelegate This, RPBroadcastController broadcastController, NSDictionary<NSString, INSCoding> serviceInfo)
		{
			var broadcastController__handle__ = broadcastController!.GetNonNullHandle (nameof (broadcastController));
			var serviceInfo__handle__ = serviceInfo!.GetNonNullHandle (nameof (serviceInfo));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("broadcastController:didUpdateServiceInfo:"), broadcastController__handle__, serviceInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (broadcastController);
			GC.KeepAlive (serviceInfo);
		}
		/// <param name="broadcastController">To be added.</param><param name="broadcastUrl">To be added.</param><summary>Method that is called when the broadcast URL is updated.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateBroadcastUrl (this IRPBroadcastControllerDelegate This, RPBroadcastController broadcastController, NSUrl broadcastUrl)
		{
			var broadcastController__handle__ = broadcastController!.GetNonNullHandle (nameof (broadcastController));
			var broadcastUrl__handle__ = broadcastUrl!.GetNonNullHandle (nameof (broadcastUrl));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("broadcastController:didUpdateBroadcastURL:"), broadcastController__handle__, broadcastUrl__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (broadcastController);
			GC.KeepAlive (broadcastUrl);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class RPBroadcastControllerDelegateWrapper : BaseWrapper, IRPBroadcastControllerDelegate {
		public RPBroadcastControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (RPBroadcastControllerDelegateWrapper))]
		static RPBroadcastControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace ReplayKit {
	/// <summary>Delegate object that responds to changes in a broadcast.</summary><related type="externalDocumentation" href="https://developer.apple.com/reference/ReplayKit/RPBroadcastControllerDelegate">Apple documentation for <c>RPBroadcastControllerDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__ReplayKit_RPBroadcastControllerDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class RPBroadcastControllerDelegate : NSObject, IRPBroadcastControllerDelegate {
		/// <summary>Creates a new <see cref="RPBroadcastControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public RPBroadcastControllerDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
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
		protected RPBroadcastControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal RPBroadcastControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="broadcastController">The controller for the broadcast that finished.</param><param name="error"><para>The error, if any, that ended the broadcast.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("broadcastController:didFinishWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinish (RPBroadcastController broadcastController, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="broadcastController">To be added.</param><param name="broadcastUrl">To be added.</param><summary>Method that is called when the broadcast URL is updated.</summary><remarks>To be added.</remarks>
		[Export ("broadcastController:didUpdateBroadcastURL:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateBroadcastUrl (RPBroadcastController broadcastController, NSUrl broadcastUrl)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="broadcastController">To be added.</param><param name="serviceInfo">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("broadcastController:didUpdateServiceInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateServiceInfo (RPBroadcastController broadcastController, NSDictionary<NSString, INSCoding> serviceInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class RPBroadcastControllerDelegate */
}
