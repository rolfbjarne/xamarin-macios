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
namespace AVKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>AVPlayerViewPictureInPictureDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "AVPlayerViewPictureInPictureDelegate", WrapperType = typeof (AVPlayerViewPictureInPictureDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillStart", Selector = "playerViewWillStartPictureInPicture:", ParameterType = new Type [] { typeof (AVKit.AVPlayerView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidStart", Selector = "playerViewDidStartPictureInPicture:", ParameterType = new Type [] { typeof (AVKit.AVPlayerView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FailedToStart", Selector = "playerView:failedToStartPictureInPictureWithError:", ParameterType = new Type [] { typeof (AVKit.AVPlayerView), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillStop", Selector = "playerViewWillStopPictureInPicture:", ParameterType = new Type [] { typeof (AVKit.AVPlayerView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidStop", Selector = "playerViewDidStopPictureInPicture:", ParameterType = new Type [] { typeof (AVKit.AVPlayerView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RestoreUserInterface", Selector = "playerView:restoreUserInterfaceForPictureInPictureStopWithCompletionHandler:", ParameterType = new Type [] { typeof (AVKit.AVPlayerView), typeof (global::System.Action<bool>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V2) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldAutomaticallyDismiss", Selector = "playerViewShouldAutomaticallyDismissAtPictureInPictureStart:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (AVKit.AVPlayerView) }, ParameterByRef = new bool [] { false })]
	public partial interface IAVPlayerViewPictureInPictureDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("playerViewWillStartPictureInPicture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillStart (AVPlayerView playerView)
		{
			_WillStart (this, playerView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillStart (IAVPlayerViewPictureInPictureDelegate This, AVPlayerView playerView)
		{
			var playerView__handle__ = playerView!.GetNonNullHandle (nameof (playerView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewWillStartPictureInPicture:"), playerView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerView);
		}
		[global::Foundation.OptionalMember]
		[Export ("playerViewDidStartPictureInPicture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStart (AVPlayerView playerView)
		{
			_DidStart (this, playerView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidStart (IAVPlayerViewPictureInPictureDelegate This, AVPlayerView playerView)
		{
			var playerView__handle__ = playerView!.GetNonNullHandle (nameof (playerView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewDidStartPictureInPicture:"), playerView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerView);
		}
		[global::Foundation.OptionalMember]
		[Export ("playerView:failedToStartPictureInPictureWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedToStart (AVPlayerView playerView, NSError error)
		{
			_FailedToStart (this, playerView, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FailedToStart (IAVPlayerViewPictureInPictureDelegate This, AVPlayerView playerView, NSError error)
		{
			var playerView__handle__ = playerView!.GetNonNullHandle (nameof (playerView));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerView:failedToStartPictureInPictureWithError:"), playerView__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerView);
			GC.KeepAlive (error);
		}
		[global::Foundation.OptionalMember]
		[Export ("playerViewWillStopPictureInPicture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillStop (AVPlayerView playerView)
		{
			_WillStop (this, playerView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillStop (IAVPlayerViewPictureInPictureDelegate This, AVPlayerView playerView)
		{
			var playerView__handle__ = playerView!.GetNonNullHandle (nameof (playerView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewWillStopPictureInPicture:"), playerView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerView);
		}
		[global::Foundation.OptionalMember]
		[Export ("playerViewDidStopPictureInPicture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStop (AVPlayerView playerView)
		{
			_DidStop (this, playerView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidStop (IAVPlayerViewPictureInPictureDelegate This, AVPlayerView playerView)
		{
			var playerView__handle__ = playerView!.GetNonNullHandle (nameof (playerView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewDidStopPictureInPicture:"), playerView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerView);
		}
		[global::Foundation.OptionalMember]
		[Export ("playerView:restoreUserInterfaceForPictureInPictureStopWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RestoreUserInterface (AVPlayerView playerView, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<bool> completionHandler)
		{
			_RestoreUserInterface (this, playerView, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RestoreUserInterface (IAVPlayerViewPictureInPictureDelegate This, AVPlayerView playerView, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<bool> completionHandler)
		{
			var playerView__handle__ = playerView!.GetNonNullHandle (nameof (playerView));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V2.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerView:restoreUserInterfaceForPictureInPictureStopWithCompletionHandler:"), playerView__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (playerView);
		}
		[global::Foundation.OptionalMember]
		[Export ("playerViewShouldAutomaticallyDismissAtPictureInPictureStart:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldAutomaticallyDismiss (AVPlayerView playerView)
		{
			return _ShouldAutomaticallyDismiss (this, playerView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldAutomaticallyDismiss (IAVPlayerViewPictureInPictureDelegate This, AVPlayerView playerView)
		{
			var playerView__handle__ = playerView!.GetNonNullHandle (nameof (playerView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewShouldAutomaticallyDismissAtPictureInPictureStart:"), playerView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerView);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("DidStart(AVKit.AVPlayerView)")]
		[DynamicDependencyAttribute ("DidStop(AVKit.AVPlayerView)")]
		[DynamicDependencyAttribute ("FailedToStart(AVKit.AVPlayerView,Foundation.NSError)")]
		[DynamicDependencyAttribute ("RestoreUserInterface(AVKit.AVPlayerView,System.Action{System.Boolean})")]
		[DynamicDependencyAttribute ("ShouldAutomaticallyDismiss(AVKit.AVPlayerView)")]
		[DynamicDependencyAttribute ("WillStart(AVKit.AVPlayerView)")]
		[DynamicDependencyAttribute ("WillStop(AVKit.AVPlayerView)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVPlayerViewPictureInPictureDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAVPlayerViewPictureInPictureDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IAVPlayerViewPictureInPictureDelegate" /> interface to support all the methods from the AVPlayerViewPictureInPictureDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IAVPlayerViewPictureInPictureDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original AVPlayerViewPictureInPictureDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class AVPlayerViewPictureInPictureDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillStart (this IAVPlayerViewPictureInPictureDelegate This, AVPlayerView playerView)
		{
			var playerView__handle__ = playerView!.GetNonNullHandle (nameof (playerView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewWillStartPictureInPicture:"), playerView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidStart (this IAVPlayerViewPictureInPictureDelegate This, AVPlayerView playerView)
		{
			var playerView__handle__ = playerView!.GetNonNullHandle (nameof (playerView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewDidStartPictureInPicture:"), playerView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FailedToStart (this IAVPlayerViewPictureInPictureDelegate This, AVPlayerView playerView, NSError error)
		{
			var playerView__handle__ = playerView!.GetNonNullHandle (nameof (playerView));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerView:failedToStartPictureInPictureWithError:"), playerView__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerView);
			GC.KeepAlive (error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillStop (this IAVPlayerViewPictureInPictureDelegate This, AVPlayerView playerView)
		{
			var playerView__handle__ = playerView!.GetNonNullHandle (nameof (playerView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewWillStopPictureInPicture:"), playerView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidStop (this IAVPlayerViewPictureInPictureDelegate This, AVPlayerView playerView)
		{
			var playerView__handle__ = playerView!.GetNonNullHandle (nameof (playerView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewDidStopPictureInPicture:"), playerView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RestoreUserInterface (this IAVPlayerViewPictureInPictureDelegate This, AVPlayerView playerView, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<bool> completionHandler)
		{
			var playerView__handle__ = playerView!.GetNonNullHandle (nameof (playerView));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V2.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerView:restoreUserInterfaceForPictureInPictureStopWithCompletionHandler:"), playerView__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (playerView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldAutomaticallyDismiss (this IAVPlayerViewPictureInPictureDelegate This, AVPlayerView playerView)
		{
			var playerView__handle__ = playerView!.GetNonNullHandle (nameof (playerView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewShouldAutomaticallyDismissAtPictureInPictureStart:"), playerView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerView);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AVPlayerViewPictureInPictureDelegateWrapper : BaseWrapper, IAVPlayerViewPictureInPictureDelegate {
		public AVPlayerViewPictureInPictureDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVPlayerViewPictureInPictureDelegateWrapper))]
		static AVPlayerViewPictureInPictureDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AVKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IAVPlayerViewPictureInPictureDelegate" /> (for the protocol <c>AVPlayerViewPictureInPictureDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IAVPlayerViewPictureInPictureDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AVKit_AVPlayerViewPictureInPictureDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class AVPlayerViewPictureInPictureDelegate : NSObject, IAVPlayerViewPictureInPictureDelegate {
		/// <summary>Creates a new <see cref="AVPlayerViewPictureInPictureDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AVPlayerViewPictureInPictureDelegate () : base (NSObjectFlag.Empty)
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
		protected AVPlayerViewPictureInPictureDelegate (NSObjectFlag t) : base (t)
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
		protected internal AVPlayerViewPictureInPictureDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("playerViewDidStartPictureInPicture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStart (AVPlayerView playerView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("playerViewDidStopPictureInPicture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStop (AVPlayerView playerView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("playerView:failedToStartPictureInPictureWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedToStart (AVPlayerView playerView, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("playerView:restoreUserInterfaceForPictureInPictureStopWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RestoreUserInterface (AVPlayerView playerView, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<bool> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("playerViewShouldAutomaticallyDismissAtPictureInPictureStart:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldAutomaticallyDismiss (AVPlayerView playerView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("playerViewWillStartPictureInPicture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillStart (AVPlayerView playerView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("playerViewWillStopPictureInPicture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillStop (AVPlayerView playerView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class AVPlayerViewPictureInPictureDelegate */
}
