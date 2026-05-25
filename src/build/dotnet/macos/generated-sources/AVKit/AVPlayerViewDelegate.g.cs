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
	/// <summary>This interface represents the Objective-C protocol <c>AVPlayerViewDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "AVPlayerViewDelegate", WrapperType = typeof (AVPlayerViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillEnterFullScreen", Selector = "playerViewWillEnterFullScreen:", ParameterType = new Type [] { typeof (AVKit.AVPlayerView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEnterFullScreen", Selector = "playerViewDidEnterFullScreen:", ParameterType = new Type [] { typeof (AVKit.AVPlayerView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillExitFullScreen", Selector = "playerViewWillExitFullScreen:", ParameterType = new Type [] { typeof (AVKit.AVPlayerView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidExitFullScreen", Selector = "playerViewDidExitFullScreen:", ParameterType = new Type [] { typeof (AVKit.AVPlayerView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RestoreUserInterfaceForFullScreenExit", Selector = "playerView:restoreUserInterfaceForFullScreenExitWithCompletionHandler:", ParameterType = new Type [] { typeof (AVKit.AVPlayerView), typeof (global::System.Action<bool>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V2) })]
	public partial interface IAVPlayerViewDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("playerViewWillEnterFullScreen:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEnterFullScreen (AVPlayerView playerView)
		{
			_WillEnterFullScreen (this, playerView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillEnterFullScreen (IAVPlayerViewDelegate This, AVPlayerView playerView)
		{
			var playerView__handle__ = playerView!.GetNonNullHandle (nameof (playerView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewWillEnterFullScreen:"), playerView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerView);
		}
		[global::Foundation.OptionalMember]
		[Export ("playerViewDidEnterFullScreen:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEnterFullScreen (AVPlayerView playerView)
		{
			_DidEnterFullScreen (this, playerView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidEnterFullScreen (IAVPlayerViewDelegate This, AVPlayerView playerView)
		{
			var playerView__handle__ = playerView!.GetNonNullHandle (nameof (playerView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewDidEnterFullScreen:"), playerView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerView);
		}
		[global::Foundation.OptionalMember]
		[Export ("playerViewWillExitFullScreen:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillExitFullScreen (AVPlayerView playerView)
		{
			_WillExitFullScreen (this, playerView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillExitFullScreen (IAVPlayerViewDelegate This, AVPlayerView playerView)
		{
			var playerView__handle__ = playerView!.GetNonNullHandle (nameof (playerView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewWillExitFullScreen:"), playerView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerView);
		}
		[global::Foundation.OptionalMember]
		[Export ("playerViewDidExitFullScreen:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidExitFullScreen (AVPlayerView playerView)
		{
			_DidExitFullScreen (this, playerView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidExitFullScreen (IAVPlayerViewDelegate This, AVPlayerView playerView)
		{
			var playerView__handle__ = playerView!.GetNonNullHandle (nameof (playerView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewDidExitFullScreen:"), playerView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerView);
		}
		[global::Foundation.OptionalMember]
		[Export ("playerView:restoreUserInterfaceForFullScreenExitWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RestoreUserInterfaceForFullScreenExit (AVPlayerView playerView, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<bool> completionHandler)
		{
			_RestoreUserInterfaceForFullScreenExit (this, playerView, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RestoreUserInterfaceForFullScreenExit (IAVPlayerViewDelegate This, AVPlayerView playerView, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<bool> completionHandler)
		{
			var playerView__handle__ = playerView!.GetNonNullHandle (nameof (playerView));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V2.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerView:restoreUserInterfaceForFullScreenExitWithCompletionHandler:"), playerView__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (playerView);
		}
		[DynamicDependencyAttribute ("DidEnterFullScreen(AVKit.AVPlayerView)")]
		[DynamicDependencyAttribute ("DidExitFullScreen(AVKit.AVPlayerView)")]
		[DynamicDependencyAttribute ("RestoreUserInterfaceForFullScreenExit(AVKit.AVPlayerView,System.Action{System.Boolean})")]
		[DynamicDependencyAttribute ("WillEnterFullScreen(AVKit.AVPlayerView)")]
		[DynamicDependencyAttribute ("WillExitFullScreen(AVKit.AVPlayerView)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVPlayerViewDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAVPlayerViewDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IAVPlayerViewDelegate" /> interface to support all the methods from the AVPlayerViewDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IAVPlayerViewDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original AVPlayerViewDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class AVPlayerViewDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillEnterFullScreen (this IAVPlayerViewDelegate This, AVPlayerView playerView)
		{
			var playerView__handle__ = playerView!.GetNonNullHandle (nameof (playerView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewWillEnterFullScreen:"), playerView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidEnterFullScreen (this IAVPlayerViewDelegate This, AVPlayerView playerView)
		{
			var playerView__handle__ = playerView!.GetNonNullHandle (nameof (playerView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewDidEnterFullScreen:"), playerView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillExitFullScreen (this IAVPlayerViewDelegate This, AVPlayerView playerView)
		{
			var playerView__handle__ = playerView!.GetNonNullHandle (nameof (playerView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewWillExitFullScreen:"), playerView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidExitFullScreen (this IAVPlayerViewDelegate This, AVPlayerView playerView)
		{
			var playerView__handle__ = playerView!.GetNonNullHandle (nameof (playerView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewDidExitFullScreen:"), playerView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RestoreUserInterfaceForFullScreenExit (this IAVPlayerViewDelegate This, AVPlayerView playerView, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<bool> completionHandler)
		{
			var playerView__handle__ = playerView!.GetNonNullHandle (nameof (playerView));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V2.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerView:restoreUserInterfaceForFullScreenExitWithCompletionHandler:"), playerView__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (playerView);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AVPlayerViewDelegateWrapper : BaseWrapper, IAVPlayerViewDelegate {
		public AVPlayerViewDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVPlayerViewDelegateWrapper))]
		static AVPlayerViewDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AVKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IAVPlayerViewDelegate" /> (for the protocol <c>AVPlayerViewDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IAVPlayerViewDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AVKit_AVPlayerViewDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class AVPlayerViewDelegate : NSObject, IAVPlayerViewDelegate {
		/// <summary>Creates a new <see cref="AVPlayerViewDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AVPlayerViewDelegate () : base (NSObjectFlag.Empty)
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
		protected AVPlayerViewDelegate (NSObjectFlag t) : base (t)
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
		protected internal AVPlayerViewDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("playerViewDidEnterFullScreen:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEnterFullScreen (AVPlayerView playerView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("playerViewDidExitFullScreen:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidExitFullScreen (AVPlayerView playerView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("playerView:restoreUserInterfaceForFullScreenExitWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RestoreUserInterfaceForFullScreenExit (AVPlayerView playerView, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<bool> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("playerViewWillEnterFullScreen:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEnterFullScreen (AVPlayerView playerView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("playerViewWillExitFullScreen:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillExitFullScreen (AVPlayerView playerView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class AVPlayerViewDelegate */
}
