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
using GLKit;
using Metal;
using CoreML;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace ReplayKit {
	#pragma warning disable CS1573
	/// <summary>Responds to changes in the UI that is presented by a <see cref="T:ReplayKit.RPBroadcastActivityViewController" />.</summary><related type="externalDocumentation" href="https://developer.apple.com/reference/ReplayKit/RPBroadcastActivityViewControllerDelegate">Apple documentation for <c>RPBroadcastActivityViewControllerDelegate</c></related>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "RPBroadcastActivityViewControllerDelegate", WrapperType = typeof (RPBroadcastActivityViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFinish", Selector = "broadcastActivityViewController:didFinishWithBroadcastController:error:", ParameterType = new Type [] { typeof (ReplayKit.RPBroadcastActivityViewController), typeof (ReplayKit.RPBroadcastController), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IRPBroadcastActivityViewControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="broadcastActivityViewController">The selection UI to be dismissed. Optional. <see langword="null" /> if the user canceled setup.</param><param name="broadcastController"><para>The broadcast controller.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error">The error that occurred, if present. Otherwise, <see langword="null" />.<para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Method that is called when the broadcast activity view controller selection UI is about to be dismissed.</summary><remarks>If <paramref name="error" /> is <see langword="null" /> then the system is configured for broadcasting.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("broadcastActivityViewController:didFinishWithBroadcastController:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinish (RPBroadcastActivityViewController broadcastActivityViewController, RPBroadcastController? broadcastController, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="broadcastActivityViewController">The selection UI to be dismissed. Optional. <see langword="null" /> if the user canceled setup.</param><param name="broadcastController"><para>The broadcast controller.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error">The error that occurred, if present. Otherwise, <see langword="null" />.<para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Method that is called when the broadcast activity view controller selection UI is about to be dismissed.</summary><remarks>If <paramref name="error" /> is <see langword="null" /> then the system is configured for broadcasting.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinish (IRPBroadcastActivityViewControllerDelegate This, RPBroadcastActivityViewController broadcastActivityViewController, RPBroadcastController? broadcastController, NSError? error)
		{
			var broadcastActivityViewController__handle__ = broadcastActivityViewController!.GetNonNullHandle (nameof (broadcastActivityViewController));
			var broadcastController__handle__ = broadcastController.GetHandle ();
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("broadcastActivityViewController:didFinishWithBroadcastController:error:"), broadcastActivityViewController__handle__, broadcastController__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (broadcastActivityViewController);
			GC.KeepAlive (broadcastController);
			GC.KeepAlive (error);
		}
		[DynamicDependencyAttribute ("DidFinish(ReplayKit.RPBroadcastActivityViewController,ReplayKit.RPBroadcastController,Foundation.NSError)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (RPBroadcastActivityViewControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IRPBroadcastActivityViewControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class RPBroadcastActivityViewControllerDelegateWrapper : BaseWrapper, IRPBroadcastActivityViewControllerDelegate {
		public RPBroadcastActivityViewControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (RPBroadcastActivityViewControllerDelegateWrapper))]
		static RPBroadcastActivityViewControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="broadcastActivityViewController">The selection UI to be dismissed. Optional. <see langword="null" /> if the user canceled setup.</param><param name="broadcastController"><para>The broadcast controller.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error">The error that occurred, if present. Otherwise, <see langword="null" />.<para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Method that is called when the broadcast activity view controller selection UI is about to be dismissed.</summary><remarks>If <paramref name="error" /> is <see langword="null" /> then the system is configured for broadcasting.</remarks>
		[Export ("broadcastActivityViewController:didFinishWithBroadcastController:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidFinish (RPBroadcastActivityViewController broadcastActivityViewController, RPBroadcastController? broadcastController, NSError? error)
		{
			var broadcastActivityViewController__handle__ = broadcastActivityViewController!.GetNonNullHandle (nameof (broadcastActivityViewController));
			var broadcastController__handle__ = broadcastController.GetHandle ();
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("broadcastActivityViewController:didFinishWithBroadcastController:error:"), broadcastActivityViewController__handle__, broadcastController__handle__, error__handle__);
			GC.KeepAlive (broadcastActivityViewController);
			GC.KeepAlive (broadcastController);
			GC.KeepAlive (error);
		}
	}
}
namespace ReplayKit {
	/// <summary>Responds to changes in the UI that is presented by a <see cref="T:ReplayKit.RPBroadcastActivityViewController" />.</summary><related type="externalDocumentation" href="https://developer.apple.com/reference/ReplayKit/RPBroadcastActivityViewControllerDelegate">Apple documentation for <c>RPBroadcastActivityViewControllerDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_tvOS__ReplayKit_RPBroadcastActivityViewControllerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class RPBroadcastActivityViewControllerDelegate : NSObject, IRPBroadcastActivityViewControllerDelegate {
		/// <summary>Creates a new <see cref="RPBroadcastActivityViewControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected RPBroadcastActivityViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected RPBroadcastActivityViewControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal RPBroadcastActivityViewControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="broadcastActivityViewController">The selection UI to be dismissed. Optional. <see langword="null" /> if the user canceled setup.</param><param name="broadcastController"><para>The broadcast controller.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error">The error that occurred, if present. Otherwise, <see langword="null" />.<para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Method that is called when the broadcast activity view controller selection UI is about to be dismissed.</summary><remarks>If <paramref name="error" /> is <see langword="null" /> then the system is configured for broadcasting.</remarks>
		[Export ("broadcastActivityViewController:didFinishWithBroadcastController:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinish (RPBroadcastActivityViewController broadcastActivityViewController, RPBroadcastController? broadcastController, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class RPBroadcastActivityViewControllerDelegate */
}
