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
namespace PhotosUI {
	#pragma warning disable CS1573
	/// <summary>Delegate object for <see cref="T:PhotosUI.PHLivePhotoView" /> objects that adds methods for responding to playback beginning and ending.</summary><related type="externalDocumentation" href="https://developer.apple.com/reference/PhotosUI/PHLivePhotoViewDelegate">Apple documentation for <c>PHLivePhotoViewDelegate</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "PHLivePhotoViewDelegate", WrapperType = typeof (PHLivePhotoViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanBeginPlayback", Selector = "livePhotoView:canBeginPlaybackWithStyle:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (PhotosUI.PHLivePhotoView), typeof (PhotosUI.PHLivePhotoViewPlaybackStyle) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillBeginPlayback", Selector = "livePhotoView:willBeginPlaybackWithStyle:", ParameterType = new Type [] { typeof (PhotosUI.PHLivePhotoView), typeof (PhotosUI.PHLivePhotoViewPlaybackStyle) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEndPlayback", Selector = "livePhotoView:didEndPlaybackWithStyle:", ParameterType = new Type [] { typeof (PhotosUI.PHLivePhotoView), typeof (PhotosUI.PHLivePhotoViewPlaybackStyle) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetExtraMinimumTouchDuration", Selector = "livePhotoView:extraMinimumTouchDurationForTouch:withStyle:", ReturnType = typeof (double), ParameterType = new Type [] { typeof (PhotosUI.PHLivePhotoView), typeof (UITouch), typeof (PhotosUI.PHLivePhotoViewPlaybackStyle) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IPHLivePhotoViewDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("livePhotoView:canBeginPlaybackWithStyle:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanBeginPlayback (PHLivePhotoView livePhotoView, PHLivePhotoViewPlaybackStyle playbackStyle)
		{
			return _CanBeginPlayback (this, livePhotoView, playbackStyle);
		}
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _CanBeginPlayback (IPHLivePhotoViewDelegate This, PHLivePhotoView livePhotoView, PHLivePhotoViewPlaybackStyle playbackStyle)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var livePhotoView__handle__ = livePhotoView!.GetNonNullHandle (nameof (livePhotoView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("livePhotoView:canBeginPlaybackWithStyle:"), livePhotoView__handle__, (IntPtr) (long) playbackStyle);
			GC.KeepAlive (This);
			GC.KeepAlive (livePhotoView);
			return ret != 0;
		}
		/// <param name="livePhotoView">To be added.</param><param name="playbackStyle">To be added.</param><summary>Method that is called just before playback begins.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("livePhotoView:willBeginPlaybackWithStyle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillBeginPlayback (PHLivePhotoView livePhotoView, PHLivePhotoViewPlaybackStyle playbackStyle)
		{
			_WillBeginPlayback (this, livePhotoView, playbackStyle);
		}
		/// <param name="livePhotoView">To be added.</param><param name="playbackStyle">To be added.</param><summary>Method that is called just before playback begins.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillBeginPlayback (IPHLivePhotoViewDelegate This, PHLivePhotoView livePhotoView, PHLivePhotoViewPlaybackStyle playbackStyle)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var livePhotoView__handle__ = livePhotoView!.GetNonNullHandle (nameof (livePhotoView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("livePhotoView:willBeginPlaybackWithStyle:"), livePhotoView__handle__, (IntPtr) (long) playbackStyle);
			GC.KeepAlive (This);
			GC.KeepAlive (livePhotoView);
		}
		/// <param name="livePhotoView">To be added.</param><param name="playbackStyle">To be added.</param><summary>Method that is called aftr playback ends.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("livePhotoView:didEndPlaybackWithStyle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndPlayback (PHLivePhotoView livePhotoView, PHLivePhotoViewPlaybackStyle playbackStyle)
		{
			_DidEndPlayback (this, livePhotoView, playbackStyle);
		}
		/// <param name="livePhotoView">To be added.</param><param name="playbackStyle">To be added.</param><summary>Method that is called aftr playback ends.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidEndPlayback (IPHLivePhotoViewDelegate This, PHLivePhotoView livePhotoView, PHLivePhotoViewPlaybackStyle playbackStyle)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var livePhotoView__handle__ = livePhotoView!.GetNonNullHandle (nameof (livePhotoView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("livePhotoView:didEndPlaybackWithStyle:"), livePhotoView__handle__, (IntPtr) (long) playbackStyle);
			GC.KeepAlive (This);
			GC.KeepAlive (livePhotoView);
		}
		[global::Foundation.OptionalMember]
		[Export ("livePhotoView:extraMinimumTouchDurationForTouch:withStyle:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double GetExtraMinimumTouchDuration (PHLivePhotoView livePhotoView, global::UIKit.UITouch touch, PHLivePhotoViewPlaybackStyle playbackStyle)
		{
			return _GetExtraMinimumTouchDuration (this, livePhotoView, touch, playbackStyle);
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static double _GetExtraMinimumTouchDuration (IPHLivePhotoViewDelegate This, PHLivePhotoView livePhotoView, global::UIKit.UITouch touch, PHLivePhotoViewPlaybackStyle playbackStyle)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var livePhotoView__handle__ = livePhotoView!.GetNonNullHandle (nameof (livePhotoView));
			var touch__handle__ = touch!.GetNonNullHandle (nameof (touch));
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("livePhotoView:extraMinimumTouchDurationForTouch:withStyle:"), livePhotoView__handle__, touch__handle__, (IntPtr) (long) playbackStyle);
			GC.KeepAlive (This);
			GC.KeepAlive (livePhotoView);
			GC.KeepAlive (touch);
			return ret!;
		}
		[DynamicDependencyAttribute ("CanBeginPlayback(PhotosUI.PHLivePhotoView,PhotosUI.PHLivePhotoViewPlaybackStyle)")]
		[DynamicDependencyAttribute ("DidEndPlayback(PhotosUI.PHLivePhotoView,PhotosUI.PHLivePhotoViewPlaybackStyle)")]
		[DynamicDependencyAttribute ("GetExtraMinimumTouchDuration(PhotosUI.PHLivePhotoView,UIKit.UITouch,PhotosUI.PHLivePhotoViewPlaybackStyle)")]
		[DynamicDependencyAttribute ("WillBeginPlayback(PhotosUI.PHLivePhotoView,PhotosUI.PHLivePhotoViewPlaybackStyle)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PHLivePhotoViewDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IPHLivePhotoViewDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IPHLivePhotoViewDelegate" /> interface to support all the methods from the PHLivePhotoViewDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IPHLivePhotoViewDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original PHLivePhotoViewDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class PHLivePhotoViewDelegate_Extensions {
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanBeginPlayback (this IPHLivePhotoViewDelegate This, PHLivePhotoView livePhotoView, PHLivePhotoViewPlaybackStyle playbackStyle)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var livePhotoView__handle__ = livePhotoView!.GetNonNullHandle (nameof (livePhotoView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("livePhotoView:canBeginPlaybackWithStyle:"), livePhotoView__handle__, (IntPtr) (long) playbackStyle);
			GC.KeepAlive (This);
			GC.KeepAlive (livePhotoView);
			return ret != 0;
		}
		/// <param name="livePhotoView">To be added.</param><param name="playbackStyle">To be added.</param><summary>Method that is called just before playback begins.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillBeginPlayback (this IPHLivePhotoViewDelegate This, PHLivePhotoView livePhotoView, PHLivePhotoViewPlaybackStyle playbackStyle)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var livePhotoView__handle__ = livePhotoView!.GetNonNullHandle (nameof (livePhotoView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("livePhotoView:willBeginPlaybackWithStyle:"), livePhotoView__handle__, (IntPtr) (long) playbackStyle);
			GC.KeepAlive (This);
			GC.KeepAlive (livePhotoView);
		}
		/// <param name="livePhotoView">To be added.</param><param name="playbackStyle">To be added.</param><summary>Method that is called aftr playback ends.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidEndPlayback (this IPHLivePhotoViewDelegate This, PHLivePhotoView livePhotoView, PHLivePhotoViewPlaybackStyle playbackStyle)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var livePhotoView__handle__ = livePhotoView!.GetNonNullHandle (nameof (livePhotoView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("livePhotoView:didEndPlaybackWithStyle:"), livePhotoView__handle__, (IntPtr) (long) playbackStyle);
			GC.KeepAlive (This);
			GC.KeepAlive (livePhotoView);
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static double GetExtraMinimumTouchDuration (this IPHLivePhotoViewDelegate This, PHLivePhotoView livePhotoView, global::UIKit.UITouch touch, PHLivePhotoViewPlaybackStyle playbackStyle)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var livePhotoView__handle__ = livePhotoView!.GetNonNullHandle (nameof (livePhotoView));
			var touch__handle__ = touch!.GetNonNullHandle (nameof (touch));
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("livePhotoView:extraMinimumTouchDurationForTouch:withStyle:"), livePhotoView__handle__, touch__handle__, (IntPtr) (long) playbackStyle);
			GC.KeepAlive (This);
			GC.KeepAlive (livePhotoView);
			GC.KeepAlive (touch);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class PHLivePhotoViewDelegateWrapper : BaseWrapper, IPHLivePhotoViewDelegate {
		public PHLivePhotoViewDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PHLivePhotoViewDelegateWrapper))]
		static PHLivePhotoViewDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace PhotosUI {
	/// <summary>Delegate object for <see cref="T:PhotosUI.PHLivePhotoView" /> objects that adds methods for responding to playback beginning and ending.</summary><related type="externalDocumentation" href="https://developer.apple.com/reference/PhotosUI/PHLivePhotoViewDelegate">Apple documentation for <c>PHLivePhotoViewDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__PhotosUI_PHLivePhotoViewDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class PHLivePhotoViewDelegate : NSObject, IPHLivePhotoViewDelegate {
		/// <summary>Creates a new <see cref="PHLivePhotoViewDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PHLivePhotoViewDelegate () : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
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
		protected PHLivePhotoViewDelegate (NSObjectFlag t) : base (t)
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
		protected internal PHLivePhotoViewDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("livePhotoView:canBeginPlaybackWithStyle:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanBeginPlayback (PHLivePhotoView livePhotoView, PHLivePhotoViewPlaybackStyle playbackStyle)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="livePhotoView">To be added.</param><param name="playbackStyle">To be added.</param><summary>Method that is called aftr playback ends.</summary><remarks>To be added.</remarks>
		[Export ("livePhotoView:didEndPlaybackWithStyle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndPlayback (PHLivePhotoView livePhotoView, PHLivePhotoViewPlaybackStyle playbackStyle)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("livePhotoView:extraMinimumTouchDurationForTouch:withStyle:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double GetExtraMinimumTouchDuration (PHLivePhotoView livePhotoView, global::UIKit.UITouch touch, PHLivePhotoViewPlaybackStyle playbackStyle)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="livePhotoView">To be added.</param><param name="playbackStyle">To be added.</param><summary>Method that is called just before playback begins.</summary><remarks>To be added.</remarks>
		[Export ("livePhotoView:willBeginPlaybackWithStyle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillBeginPlayback (PHLivePhotoView livePhotoView, PHLivePhotoViewPlaybackStyle playbackStyle)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class PHLivePhotoViewDelegate */
}
