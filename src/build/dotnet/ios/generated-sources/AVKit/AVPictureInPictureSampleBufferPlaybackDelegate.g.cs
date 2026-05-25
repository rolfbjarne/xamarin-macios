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
namespace AVKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>AVPictureInPictureSampleBufferPlaybackDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "AVPictureInPictureSampleBufferPlaybackDelegate", WrapperType = typeof (AVPictureInPictureSampleBufferPlaybackDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetPlaying", Selector = "pictureInPictureController:setPlaying:", ParameterType = new Type [] { typeof (AVKit.AVPictureInPictureController), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetTimeRange", Selector = "pictureInPictureControllerTimeRangeForPlayback:", ReturnType = typeof (CMTimeRange), ParameterType = new Type [] { typeof (AVKit.AVPictureInPictureController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "IsPlaybackPaused", Selector = "pictureInPictureControllerIsPlaybackPaused:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (AVKit.AVPictureInPictureController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidTransitionToRenderSize", Selector = "pictureInPictureController:didTransitionToRenderSize:", ParameterType = new Type [] { typeof (AVKit.AVPictureInPictureController), typeof (CMVideoDimensions) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SkipByInterval", Selector = "pictureInPictureController:skipByInterval:completionHandler:", ParameterType = new Type [] { typeof (AVKit.AVPictureInPictureController), typeof (CMTime), typeof (Action) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldProhibitBackgroundAudioPlayback", Selector = "pictureInPictureControllerShouldProhibitBackgroundAudioPlayback:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (AVKit.AVPictureInPictureController) }, ParameterByRef = new bool [] { false })]
	public partial interface IAVPictureInPictureSampleBufferPlaybackDelegate : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("pictureInPictureController:setPlaying:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPlaying (AVPictureInPictureController pictureInPictureController, bool playing)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetPlaying (IAVPictureInPictureSampleBufferPlaybackDelegate This, AVPictureInPictureController pictureInPictureController, bool playing)
		{
			var pictureInPictureController__handle__ = pictureInPictureController!.GetNonNullHandle (nameof (pictureInPictureController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("pictureInPictureController:setPlaying:"), pictureInPictureController__handle__, playing ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (pictureInPictureController);
		}
		[global::Foundation.RequiredMember]
		[Export ("pictureInPictureControllerTimeRangeForPlayback:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreMedia.CMTimeRange GetTimeRange (AVPictureInPictureController pictureInPictureController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::CoreMedia.CMTimeRange _GetTimeRange (IAVPictureInPictureSampleBufferPlaybackDelegate This, AVPictureInPictureController pictureInPictureController)
		{
			var pictureInPictureController__handle__ = pictureInPictureController!.GetNonNullHandle (nameof (pictureInPictureController));
			global::CoreMedia.CMTimeRange ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CMTimeRange_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pictureInPictureControllerTimeRangeForPlayback:"), pictureInPictureController__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CMTimeRange_objc_msgSend_stret_NativeHandle (This.Handle, Selector.GetHandle ("pictureInPictureControllerTimeRangeForPlayback:"), pictureInPictureController__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (pictureInPictureController);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("pictureInPictureControllerIsPlaybackPaused:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsPlaybackPaused (AVPictureInPictureController pictureInPictureController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _IsPlaybackPaused (IAVPictureInPictureSampleBufferPlaybackDelegate This, AVPictureInPictureController pictureInPictureController)
		{
			var pictureInPictureController__handle__ = pictureInPictureController!.GetNonNullHandle (nameof (pictureInPictureController));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pictureInPictureControllerIsPlaybackPaused:"), pictureInPictureController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pictureInPictureController);
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("pictureInPictureController:didTransitionToRenderSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidTransitionToRenderSize (AVPictureInPictureController pictureInPictureController, global::CoreMedia.CMVideoDimensions newRenderSize)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidTransitionToRenderSize (IAVPictureInPictureSampleBufferPlaybackDelegate This, AVPictureInPictureController pictureInPictureController, global::CoreMedia.CMVideoDimensions newRenderSize)
		{
			var pictureInPictureController__handle__ = pictureInPictureController!.GetNonNullHandle (nameof (pictureInPictureController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CMVideoDimensions (This.Handle, Selector.GetHandle ("pictureInPictureController:didTransitionToRenderSize:"), pictureInPictureController__handle__, newRenderSize);
			GC.KeepAlive (This);
			GC.KeepAlive (pictureInPictureController);
		}
		[global::Foundation.RequiredMember]
		[Export ("pictureInPictureController:skipByInterval:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SkipByInterval (AVPictureInPictureController pictureInPictureController, global::CoreMedia.CMTime skipInterval, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SkipByInterval (IAVPictureInPictureSampleBufferPlaybackDelegate This, AVPictureInPictureController pictureInPictureController, global::CoreMedia.CMTime skipInterval, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			var pictureInPictureController__handle__ = pictureInPictureController!.GetNonNullHandle (nameof (pictureInPictureController));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CMTime_NativeHandle (This.Handle, Selector.GetHandle ("pictureInPictureController:skipByInterval:completionHandler:"), pictureInPictureController__handle__, skipInterval, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (pictureInPictureController);
		}
		[global::Foundation.OptionalMember]
		[Export ("pictureInPictureControllerShouldProhibitBackgroundAudioPlayback:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldProhibitBackgroundAudioPlayback (AVPictureInPictureController pictureInPictureController)
		{
			return _ShouldProhibitBackgroundAudioPlayback (this, pictureInPictureController);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldProhibitBackgroundAudioPlayback (IAVPictureInPictureSampleBufferPlaybackDelegate This, AVPictureInPictureController pictureInPictureController)
		{
			var pictureInPictureController__handle__ = pictureInPictureController!.GetNonNullHandle (nameof (pictureInPictureController));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pictureInPictureControllerShouldProhibitBackgroundAudioPlayback:"), pictureInPictureController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pictureInPictureController);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("DidTransitionToRenderSize(AVKit.AVPictureInPictureController,CoreMedia.CMVideoDimensions)")]
		[DynamicDependencyAttribute ("GetTimeRange(AVKit.AVPictureInPictureController)")]
		[DynamicDependencyAttribute ("IsPlaybackPaused(AVKit.AVPictureInPictureController)")]
		[DynamicDependencyAttribute ("SetPlaying(AVKit.AVPictureInPictureController,System.Boolean)")]
		[DynamicDependencyAttribute ("ShouldProhibitBackgroundAudioPlayback(AVKit.AVPictureInPictureController)")]
		[DynamicDependencyAttribute ("SkipByInterval(AVKit.AVPictureInPictureController,CoreMedia.CMTime,System.Action)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVPictureInPictureSampleBufferPlaybackDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAVPictureInPictureSampleBufferPlaybackDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IAVPictureInPictureSampleBufferPlaybackDelegate" /> interface to support all the methods from the AVPictureInPictureSampleBufferPlaybackDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IAVPictureInPictureSampleBufferPlaybackDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original AVPictureInPictureSampleBufferPlaybackDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class AVPictureInPictureSampleBufferPlaybackDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldProhibitBackgroundAudioPlayback (this IAVPictureInPictureSampleBufferPlaybackDelegate This, AVPictureInPictureController pictureInPictureController)
		{
			var pictureInPictureController__handle__ = pictureInPictureController!.GetNonNullHandle (nameof (pictureInPictureController));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pictureInPictureControllerShouldProhibitBackgroundAudioPlayback:"), pictureInPictureController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pictureInPictureController);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AVPictureInPictureSampleBufferPlaybackDelegateWrapper : BaseWrapper, IAVPictureInPictureSampleBufferPlaybackDelegate {
		public AVPictureInPictureSampleBufferPlaybackDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVPictureInPictureSampleBufferPlaybackDelegateWrapper))]
		static AVPictureInPictureSampleBufferPlaybackDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("pictureInPictureController:setPlaying:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetPlaying (AVPictureInPictureController pictureInPictureController, bool playing)
		{
			var pictureInPictureController__handle__ = pictureInPictureController!.GetNonNullHandle (nameof (pictureInPictureController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, Selector.GetHandle ("pictureInPictureController:setPlaying:"), pictureInPictureController__handle__, playing ? (byte) 1 : (byte) 0);
			GC.KeepAlive (pictureInPictureController);
		}
		[Export ("pictureInPictureControllerTimeRangeForPlayback:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::CoreMedia.CMTimeRange GetTimeRange (AVPictureInPictureController pictureInPictureController)
		{
			var pictureInPictureController__handle__ = pictureInPictureController!.GetNonNullHandle (nameof (pictureInPictureController));
			global::CoreMedia.CMTimeRange ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CMTimeRange_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("pictureInPictureControllerTimeRangeForPlayback:"), pictureInPictureController__handle__);
			} else {
				ret = global::ObjCRuntime.Messaging.CMTimeRange_objc_msgSend_stret_NativeHandle (this.Handle, Selector.GetHandle ("pictureInPictureControllerTimeRangeForPlayback:"), pictureInPictureController__handle__);
			}
			GC.KeepAlive (pictureInPictureController);
			return ret!;
		}
		[Export ("pictureInPictureControllerIsPlaybackPaused:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool IsPlaybackPaused (AVPictureInPictureController pictureInPictureController)
		{
			var pictureInPictureController__handle__ = pictureInPictureController!.GetNonNullHandle (nameof (pictureInPictureController));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("pictureInPictureControllerIsPlaybackPaused:"), pictureInPictureController__handle__);
			GC.KeepAlive (pictureInPictureController);
			return ret != 0;
		}
		[Export ("pictureInPictureController:didTransitionToRenderSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidTransitionToRenderSize (AVPictureInPictureController pictureInPictureController, global::CoreMedia.CMVideoDimensions newRenderSize)
		{
			var pictureInPictureController__handle__ = pictureInPictureController!.GetNonNullHandle (nameof (pictureInPictureController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CMVideoDimensions (this.Handle, Selector.GetHandle ("pictureInPictureController:didTransitionToRenderSize:"), pictureInPictureController__handle__, newRenderSize);
			GC.KeepAlive (pictureInPictureController);
		}
		[Export ("pictureInPictureController:skipByInterval:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void SkipByInterval (AVPictureInPictureController pictureInPictureController, global::CoreMedia.CMTime skipInterval, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			var pictureInPictureController__handle__ = pictureInPictureController!.GetNonNullHandle (nameof (pictureInPictureController));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CMTime_NativeHandle (this.Handle, Selector.GetHandle ("pictureInPictureController:skipByInterval:completionHandler:"), pictureInPictureController__handle__, skipInterval, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (pictureInPictureController);
		}
	}
}
namespace AVKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IAVPictureInPictureSampleBufferPlaybackDelegate" /> (for the protocol <c>AVPictureInPictureSampleBufferPlaybackDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IAVPictureInPictureSampleBufferPlaybackDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__AVKit_AVPictureInPictureSampleBufferPlaybackDelegate", false)]
	[Model]
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe abstract partial class AVPictureInPictureSampleBufferPlaybackDelegate : NSObject, IAVPictureInPictureSampleBufferPlaybackDelegate {
		/// <summary>Creates a new <see cref="AVPictureInPictureSampleBufferPlaybackDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected AVPictureInPictureSampleBufferPlaybackDelegate () : base (NSObjectFlag.Empty)
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
		protected AVPictureInPictureSampleBufferPlaybackDelegate (NSObjectFlag t) : base (t)
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
		protected internal AVPictureInPictureSampleBufferPlaybackDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("pictureInPictureController:didTransitionToRenderSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidTransitionToRenderSize (AVPictureInPictureController pictureInPictureController, global::CoreMedia.CMVideoDimensions newRenderSize)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("pictureInPictureControllerTimeRangeForPlayback:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreMedia.CMTimeRange GetTimeRange (AVPictureInPictureController pictureInPictureController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("pictureInPictureControllerIsPlaybackPaused:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsPlaybackPaused (AVPictureInPictureController pictureInPictureController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("pictureInPictureController:setPlaying:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPlaying (AVPictureInPictureController pictureInPictureController, bool playing)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("pictureInPictureControllerShouldProhibitBackgroundAudioPlayback:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldProhibitBackgroundAudioPlayback (AVPictureInPictureController pictureInPictureController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("pictureInPictureController:skipByInterval:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SkipByInterval (AVPictureInPictureController pictureInPictureController, global::CoreMedia.CMTime skipInterval, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class AVPictureInPictureSampleBufferPlaybackDelegate */
}
