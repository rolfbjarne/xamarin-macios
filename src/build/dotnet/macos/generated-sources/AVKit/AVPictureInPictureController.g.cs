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
	/// <summary>Provides video playback in a floating, resizable window on larger devices.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/prerelease/ios/documentation/AVKit/Reference/AVPictureInPictureControllerDelegate_Protocol/index.html#//apple_ref/doc/uid/TP40016161">Apple documentation for <c>AVPictureInPictureController</c></related>
	[Register("AVPictureInPictureController", true)]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe sealed partial class AVPictureInPictureController : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentSourceX = "contentSource";
		static readonly NativeHandle selContentSourceXHandle = Selector.GetHandle ("contentSource");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithContentSource_X = "initWithContentSource:";
		static readonly NativeHandle selInitWithContentSource_XHandle = Selector.GetHandle ("initWithContentSource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithPlayerLayer_X = "initWithPlayerLayer:";
		static readonly NativeHandle selInitWithPlayerLayer_XHandle = Selector.GetHandle ("initWithPlayerLayer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInvalidatePlaybackStateX = "invalidatePlaybackState";
		static readonly NativeHandle selInvalidatePlaybackStateXHandle = Selector.GetHandle ("invalidatePlaybackState");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsPictureInPictureActiveX = "isPictureInPictureActive";
		static readonly NativeHandle selIsPictureInPictureActiveXHandle = Selector.GetHandle ("isPictureInPictureActive");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsPictureInPicturePossibleX = "isPictureInPicturePossible";
		static readonly NativeHandle selIsPictureInPicturePossibleXHandle = Selector.GetHandle ("isPictureInPicturePossible");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsPictureInPictureSupportedX = "isPictureInPictureSupported";
		static readonly NativeHandle selIsPictureInPictureSupportedXHandle = Selector.GetHandle ("isPictureInPictureSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsPictureInPictureSuspendedX = "isPictureInPictureSuspended";
		static readonly NativeHandle selIsPictureInPictureSuspendedXHandle = Selector.GetHandle ("isPictureInPictureSuspended");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPictureInPictureButtonStartImageX = "pictureInPictureButtonStartImage";
		static readonly NativeHandle selPictureInPictureButtonStartImageXHandle = Selector.GetHandle ("pictureInPictureButtonStartImage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPictureInPictureButtonStopImageX = "pictureInPictureButtonStopImage";
		static readonly NativeHandle selPictureInPictureButtonStopImageXHandle = Selector.GetHandle ("pictureInPictureButtonStopImage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlayerLayerX = "playerLayer";
		static readonly NativeHandle selPlayerLayerXHandle = Selector.GetHandle ("playerLayer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequiresLinearPlaybackX = "requiresLinearPlayback";
		static readonly NativeHandle selRequiresLinearPlaybackXHandle = Selector.GetHandle ("requiresLinearPlayback");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetContentSource_X = "setContentSource:";
		static readonly NativeHandle selSetContentSource_XHandle = Selector.GetHandle ("setContentSource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRequiresLinearPlayback_X = "setRequiresLinearPlayback:";
		static readonly NativeHandle selSetRequiresLinearPlayback_XHandle = Selector.GetHandle ("setRequiresLinearPlayback:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartPictureInPictureX = "startPictureInPicture";
		static readonly NativeHandle selStartPictureInPictureXHandle = Selector.GetHandle ("startPictureInPicture");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopPictureInPictureX = "stopPictureInPicture";
		static readonly NativeHandle selStopPictureInPictureXHandle = Selector.GetHandle ("stopPictureInPicture");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVPictureInPictureController");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		internal AVPictureInPictureController (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = true;
		}

		[Export ("initWithPlayerLayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVPictureInPictureController (global::AVFoundation.AVPlayerLayer playerLayer)
			: base (NSObjectFlag.Empty)
		{
			var playerLayer__handle__ = playerLayer!.GetNonNullHandle (nameof (playerLayer));
			IsDirectBinding = true;
			InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithPlayerLayer_XHandle, playerLayer__handle__), "initWithPlayerLayer:");
			GC.KeepAlive (playerLayer);
		}
		[Export ("initWithContentSource:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVPictureInPictureController (AVPictureInPictureControllerContentSource contentSource)
			: base (NSObjectFlag.Empty)
		{
			var contentSource__handle__ = contentSource!.GetNonNullHandle (nameof (contentSource));
			IsDirectBinding = true;
			InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithContentSource_XHandle, contentSource__handle__), "initWithContentSource:");
			GC.KeepAlive (contentSource);
		}
		[Export ("invalidatePlaybackState")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InvalidatePlaybackState ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selInvalidatePlaybackStateXHandle);
		}
		[Export ("startPictureInPicture")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void StartPictureInPicture ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStartPictureInPictureXHandle);
		}
		[Export ("stopPictureInPicture")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void StopPictureInPicture ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStopPictureInPictureXHandle);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public AVPictureInPictureControllerContentSource? ContentSource {
			[Export ("contentSource", ArgumentSemantic.Retain)]
			get {
				AVPictureInPictureControllerContentSource? ret;
				ret =  Runtime.GetNSObject<AVPictureInPictureControllerContentSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selContentSourceXHandle), false)!;
				return ret!;
			}
			[Export ("setContentSource:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetContentSource_XHandle, value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>An instance of the AVKit.IAVPictureInPictureControllerDelegate model class which acts as the class delegate.</summary><value>The instance of the AVKit.IAVPictureInPictureControllerDelegate model class</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IAVPictureInPictureControllerDelegate? Delegate {
			get {
				return (WeakDelegate as IAVPictureInPictureControllerDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsPictureInPictureSupported {
			[Export ("isPictureInPictureSupported")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsPictureInPictureSupportedXHandle);
				return ret != 0;
			}
		}
		/// <summary>Gets a value that tells whether Picture in Picture is currently displayed.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool PictureInPictureActive {
			[Export ("isPictureInPictureActive")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsPictureInPictureActiveXHandle);
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.0")]
		public static global::AppKit.NSImage PictureInPictureButtonStartImage {
			[Export ("pictureInPictureButtonStartImage")]
			get {
				global::AppKit.NSImage? ret;
				ret =  Runtime.GetNSObject<global::AppKit.NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selPictureInPictureButtonStartImageXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.0")]
		public static global::AppKit.NSImage PictureInPictureButtonStopImage {
			[Export ("pictureInPictureButtonStopImage")]
			get {
				global::AppKit.NSImage? ret;
				ret =  Runtime.GetNSObject<global::AppKit.NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selPictureInPictureButtonStopImageXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>Gets a value that tells whether Picture in Picture is currently possible on the device.</summary><value><see langword="false" /> if another app is running Picture in Picture.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool PictureInPicturePossible {
			[Export ("isPictureInPicturePossible")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsPictureInPicturePossibleXHandle);
				return ret != 0;
			}
		}
		/// <summary>Gets a value that tells whether Picture in Picture playback has been paused and moved off the screen by another application.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool PictureInPictureSuspended {
			[Export ("isPictureInPictureSuspended")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsPictureInPictureSuspendedXHandle);
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::AVFoundation.AVPlayerLayer PlayerLayer {
			[Export ("playerLayer")]
			get {
				global::AVFoundation.AVPlayerLayer? ret;
				ret =  Runtime.GetNSObject<global::AVFoundation.AVPlayerLayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPlayerLayerXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.0")]
		public bool RequiresLinearPlayback {
			[Export ("requiresLinearPlayback")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selRequiresLinearPlaybackXHandle);
				return ret != 0;
			}
			[Export ("setRequiresLinearPlayback:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetRequiresLinearPlayback_XHandle, value ? (byte) 1 : (byte) 0);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject? ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDelegateXHandle), false)!;
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDelegate_XHandle, value__handle__);
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class AVPictureInPictureController */
}
