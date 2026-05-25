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
namespace HomeKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>HMCameraStreamControlDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "HMCameraStreamControlDelegate", WrapperType = typeof (HMCameraStreamControlDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidStartStream", Selector = "cameraStreamControlDidStartStream:", ParameterType = new Type [] { typeof (HomeKit.HMCameraStreamControl) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidStopStream", Selector = "cameraStreamControl:didStopStreamWithError:", ParameterType = new Type [] { typeof (HomeKit.HMCameraStreamControl), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IHMCameraStreamControlDelegate : INativeObject, IDisposable
	{
		/// <param name="cameraStreamControl">To be added.</param><summary>Called by the system when the <paramref name="cameraStreamControl" /> successfully starts the video stream.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("cameraStreamControlDidStartStream:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStartStream (HMCameraStreamControl cameraStreamControl)
		{
			_DidStartStream (this, cameraStreamControl);
		}
		/// <param name="cameraStreamControl">To be added.</param><summary>Called by the system when the <paramref name="cameraStreamControl" /> successfully starts the video stream.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidStartStream (IHMCameraStreamControlDelegate This, HMCameraStreamControl cameraStreamControl)
		{
			var cameraStreamControl__handle__ = cameraStreamControl!.GetNonNullHandle (nameof (cameraStreamControl));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("cameraStreamControlDidStartStream:"), cameraStreamControl__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (cameraStreamControl);
		}
		/// <param name="cameraStreamControl">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Called by the system when the <paramref name="cameraStreamControl" /> video stream stops.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("cameraStreamControl:didStopStreamWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStopStream (HMCameraStreamControl cameraStreamControl, NSError? error)
		{
			_DidStopStream (this, cameraStreamControl, error);
		}
		/// <param name="cameraStreamControl">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Called by the system when the <paramref name="cameraStreamControl" /> video stream stops.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidStopStream (IHMCameraStreamControlDelegate This, HMCameraStreamControl cameraStreamControl, NSError? error)
		{
			var cameraStreamControl__handle__ = cameraStreamControl!.GetNonNullHandle (nameof (cameraStreamControl));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("cameraStreamControl:didStopStreamWithError:"), cameraStreamControl__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (cameraStreamControl);
			GC.KeepAlive (error);
		}
		[DynamicDependencyAttribute ("DidStartStream(HomeKit.HMCameraStreamControl)")]
		[DynamicDependencyAttribute ("DidStopStream(HomeKit.HMCameraStreamControl,Foundation.NSError)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (HMCameraStreamControlDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IHMCameraStreamControlDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IHMCameraStreamControlDelegate" /> interface to support all the methods from the HMCameraStreamControlDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IHMCameraStreamControlDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original HMCameraStreamControlDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class HMCameraStreamControlDelegate_Extensions {
		/// <param name="cameraStreamControl">To be added.</param><summary>Called by the system when the <paramref name="cameraStreamControl" /> successfully starts the video stream.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidStartStream (this IHMCameraStreamControlDelegate This, HMCameraStreamControl cameraStreamControl)
		{
			var cameraStreamControl__handle__ = cameraStreamControl!.GetNonNullHandle (nameof (cameraStreamControl));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("cameraStreamControlDidStartStream:"), cameraStreamControl__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (cameraStreamControl);
		}
		/// <param name="cameraStreamControl">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Called by the system when the <paramref name="cameraStreamControl" /> video stream stops.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidStopStream (this IHMCameraStreamControlDelegate This, HMCameraStreamControl cameraStreamControl, NSError? error)
		{
			var cameraStreamControl__handle__ = cameraStreamControl!.GetNonNullHandle (nameof (cameraStreamControl));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("cameraStreamControl:didStopStreamWithError:"), cameraStreamControl__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (cameraStreamControl);
			GC.KeepAlive (error);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class HMCameraStreamControlDelegateWrapper : BaseWrapper, IHMCameraStreamControlDelegate {
		public HMCameraStreamControlDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (HMCameraStreamControlDelegateWrapper))]
		static HMCameraStreamControlDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace HomeKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IHMCameraStreamControlDelegate" /> (for the protocol <c>HMCameraStreamControlDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IHMCameraStreamControlDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__HomeKit_HMCameraStreamControlDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class HMCameraStreamControlDelegate : NSObject, IHMCameraStreamControlDelegate {
		/// <summary>Creates a new <see cref="HMCameraStreamControlDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public HMCameraStreamControlDelegate () : base (NSObjectFlag.Empty)
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
		protected HMCameraStreamControlDelegate (NSObjectFlag t) : base (t)
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
		protected internal HMCameraStreamControlDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="cameraStreamControl">To be added.</param><summary>Called by the system when the <paramref name="cameraStreamControl" /> successfully starts the video stream.</summary><remarks>To be added.</remarks>
		[Export ("cameraStreamControlDidStartStream:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStartStream (HMCameraStreamControl cameraStreamControl)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="cameraStreamControl">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Called by the system when the <paramref name="cameraStreamControl" /> video stream stops.</summary><remarks>To be added.</remarks>
		[Export ("cameraStreamControl:didStopStreamWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStopStream (HMCameraStreamControl cameraStreamControl, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class HMCameraStreamControlDelegate */
}
