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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AVFoundation {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>AVPlaybackCoordinatorPlaybackControlDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "AVPlaybackCoordinatorPlaybackControlDelegate", WrapperType = typeof (AVPlaybackCoordinatorPlaybackControlDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidIssuePlayCommand", Selector = "playbackCoordinator:didIssuePlayCommand:completionHandler:", ParameterType = new Type [] { typeof (AVDelegatingPlaybackCoordinator), typeof (AVDelegatingPlaybackCoordinatorPlayCommand), typeof (Action) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidIssuePauseCommand", Selector = "playbackCoordinator:didIssuePauseCommand:completionHandler:", ParameterType = new Type [] { typeof (AVDelegatingPlaybackCoordinator), typeof (AVDelegatingPlaybackCoordinatorPauseCommand), typeof (Action) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidIssueSeekCommand", Selector = "playbackCoordinator:didIssueSeekCommand:completionHandler:", ParameterType = new Type [] { typeof (AVDelegatingPlaybackCoordinator), typeof (AVDelegatingPlaybackCoordinatorSeekCommand), typeof (Action) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidIssueBufferingCommand", Selector = "playbackCoordinator:didIssueBufferingCommand:completionHandler:", ParameterType = new Type [] { typeof (AVDelegatingPlaybackCoordinator), typeof (AVDelegatingPlaybackCoordinatorBufferingCommand), typeof (Action) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	public partial interface IAVPlaybackCoordinatorPlaybackControlDelegate : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("playbackCoordinator:didIssuePlayCommand:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidIssuePlayCommand (AVDelegatingPlaybackCoordinator coordinator, AVDelegatingPlaybackCoordinatorPlayCommand playCommand, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidIssuePlayCommand (IAVPlaybackCoordinatorPlaybackControlDelegate This, AVDelegatingPlaybackCoordinator coordinator, AVDelegatingPlaybackCoordinatorPlayCommand playCommand, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			var playCommand__handle__ = playCommand!.GetNonNullHandle (nameof (playCommand));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playbackCoordinator:didIssuePlayCommand:completionHandler:"), coordinator__handle__, playCommand__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (coordinator);
			GC.KeepAlive (playCommand);
		}
		[global::Foundation.RequiredMember]
		[Export ("playbackCoordinator:didIssuePauseCommand:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidIssuePauseCommand (AVDelegatingPlaybackCoordinator coordinator, AVDelegatingPlaybackCoordinatorPauseCommand pauseCommand, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidIssuePauseCommand (IAVPlaybackCoordinatorPlaybackControlDelegate This, AVDelegatingPlaybackCoordinator coordinator, AVDelegatingPlaybackCoordinatorPauseCommand pauseCommand, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			var pauseCommand__handle__ = pauseCommand!.GetNonNullHandle (nameof (pauseCommand));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playbackCoordinator:didIssuePauseCommand:completionHandler:"), coordinator__handle__, pauseCommand__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (coordinator);
			GC.KeepAlive (pauseCommand);
		}
		[global::Foundation.RequiredMember]
		[Export ("playbackCoordinator:didIssueSeekCommand:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidIssueSeekCommand (AVDelegatingPlaybackCoordinator coordinator, AVDelegatingPlaybackCoordinatorSeekCommand seekCommand, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidIssueSeekCommand (IAVPlaybackCoordinatorPlaybackControlDelegate This, AVDelegatingPlaybackCoordinator coordinator, AVDelegatingPlaybackCoordinatorSeekCommand seekCommand, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			var seekCommand__handle__ = seekCommand!.GetNonNullHandle (nameof (seekCommand));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playbackCoordinator:didIssueSeekCommand:completionHandler:"), coordinator__handle__, seekCommand__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (coordinator);
			GC.KeepAlive (seekCommand);
		}
		[global::Foundation.RequiredMember]
		[Export ("playbackCoordinator:didIssueBufferingCommand:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidIssueBufferingCommand (AVDelegatingPlaybackCoordinator coordinator, AVDelegatingPlaybackCoordinatorBufferingCommand bufferingCommand, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidIssueBufferingCommand (IAVPlaybackCoordinatorPlaybackControlDelegate This, AVDelegatingPlaybackCoordinator coordinator, AVDelegatingPlaybackCoordinatorBufferingCommand bufferingCommand, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			var bufferingCommand__handle__ = bufferingCommand!.GetNonNullHandle (nameof (bufferingCommand));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playbackCoordinator:didIssueBufferingCommand:completionHandler:"), coordinator__handle__, bufferingCommand__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (coordinator);
			GC.KeepAlive (bufferingCommand);
		}
		[DynamicDependencyAttribute ("DidIssueBufferingCommand(AVFoundation.AVDelegatingPlaybackCoordinator,AVFoundation.AVDelegatingPlaybackCoordinatorBufferingCommand,System.Action)")]
		[DynamicDependencyAttribute ("DidIssuePauseCommand(AVFoundation.AVDelegatingPlaybackCoordinator,AVFoundation.AVDelegatingPlaybackCoordinatorPauseCommand,System.Action)")]
		[DynamicDependencyAttribute ("DidIssuePlayCommand(AVFoundation.AVDelegatingPlaybackCoordinator,AVFoundation.AVDelegatingPlaybackCoordinatorPlayCommand,System.Action)")]
		[DynamicDependencyAttribute ("DidIssueSeekCommand(AVFoundation.AVDelegatingPlaybackCoordinator,AVFoundation.AVDelegatingPlaybackCoordinatorSeekCommand,System.Action)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVPlaybackCoordinatorPlaybackControlDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAVPlaybackCoordinatorPlaybackControlDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AVPlaybackCoordinatorPlaybackControlDelegateWrapper : BaseWrapper, IAVPlaybackCoordinatorPlaybackControlDelegate {
		public AVPlaybackCoordinatorPlaybackControlDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVPlaybackCoordinatorPlaybackControlDelegateWrapper))]
		static AVPlaybackCoordinatorPlaybackControlDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("playbackCoordinator:didIssuePlayCommand:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void DidIssuePlayCommand (AVDelegatingPlaybackCoordinator coordinator, AVDelegatingPlaybackCoordinatorPlayCommand playCommand, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			var playCommand__handle__ = playCommand!.GetNonNullHandle (nameof (playCommand));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("playbackCoordinator:didIssuePlayCommand:completionHandler:"), coordinator__handle__, playCommand__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (coordinator);
			GC.KeepAlive (playCommand);
		}
		[Export ("playbackCoordinator:didIssuePauseCommand:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void DidIssuePauseCommand (AVDelegatingPlaybackCoordinator coordinator, AVDelegatingPlaybackCoordinatorPauseCommand pauseCommand, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			var pauseCommand__handle__ = pauseCommand!.GetNonNullHandle (nameof (pauseCommand));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("playbackCoordinator:didIssuePauseCommand:completionHandler:"), coordinator__handle__, pauseCommand__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (coordinator);
			GC.KeepAlive (pauseCommand);
		}
		[Export ("playbackCoordinator:didIssueSeekCommand:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void DidIssueSeekCommand (AVDelegatingPlaybackCoordinator coordinator, AVDelegatingPlaybackCoordinatorSeekCommand seekCommand, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			var seekCommand__handle__ = seekCommand!.GetNonNullHandle (nameof (seekCommand));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("playbackCoordinator:didIssueSeekCommand:completionHandler:"), coordinator__handle__, seekCommand__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (coordinator);
			GC.KeepAlive (seekCommand);
		}
		[Export ("playbackCoordinator:didIssueBufferingCommand:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void DidIssueBufferingCommand (AVDelegatingPlaybackCoordinator coordinator, AVDelegatingPlaybackCoordinatorBufferingCommand bufferingCommand, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			var bufferingCommand__handle__ = bufferingCommand!.GetNonNullHandle (nameof (bufferingCommand));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("playbackCoordinator:didIssueBufferingCommand:completionHandler:"), coordinator__handle__, bufferingCommand__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (coordinator);
			GC.KeepAlive (bufferingCommand);
		}
	}
}
namespace AVFoundation {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IAVPlaybackCoordinatorPlaybackControlDelegate" /> (for the protocol <c>AVPlaybackCoordinatorPlaybackControlDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IAVPlaybackCoordinatorPlaybackControlDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__AVFoundation_AVPlaybackCoordinatorPlaybackControlDelegate", false)]
	[Model]
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe abstract partial class AVPlaybackCoordinatorPlaybackControlDelegate : NSObject, IAVPlaybackCoordinatorPlaybackControlDelegate {
		/// <summary>Creates a new <see cref="AVPlaybackCoordinatorPlaybackControlDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected AVPlaybackCoordinatorPlaybackControlDelegate () : base (NSObjectFlag.Empty)
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
		protected AVPlaybackCoordinatorPlaybackControlDelegate (NSObjectFlag t) : base (t)
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
		protected internal AVPlaybackCoordinatorPlaybackControlDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("playbackCoordinator:didIssueBufferingCommand:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidIssueBufferingCommand (AVDelegatingPlaybackCoordinator coordinator, AVDelegatingPlaybackCoordinatorBufferingCommand bufferingCommand, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("playbackCoordinator:didIssuePauseCommand:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidIssuePauseCommand (AVDelegatingPlaybackCoordinator coordinator, AVDelegatingPlaybackCoordinatorPauseCommand pauseCommand, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("playbackCoordinator:didIssuePlayCommand:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidIssuePlayCommand (AVDelegatingPlaybackCoordinator coordinator, AVDelegatingPlaybackCoordinatorPlayCommand playCommand, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("playbackCoordinator:didIssueSeekCommand:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidIssueSeekCommand (AVDelegatingPlaybackCoordinator coordinator, AVDelegatingPlaybackCoordinatorSeekCommand seekCommand, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class AVPlaybackCoordinatorPlaybackControlDelegate */
}
