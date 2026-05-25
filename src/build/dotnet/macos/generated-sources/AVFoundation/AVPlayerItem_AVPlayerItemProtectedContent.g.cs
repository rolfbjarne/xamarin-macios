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
namespace AVFoundation {
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class AVPlayerItem_AVPlayerItemProtectedContent  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCancelContentAuthorizationRequestX = "cancelContentAuthorizationRequest";
		static readonly NativeHandle selCancelContentAuthorizationRequestXHandle = Selector.GetHandle ("cancelContentAuthorizationRequest");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentAuthorizationRequestStatusX = "contentAuthorizationRequestStatus";
		static readonly NativeHandle selContentAuthorizationRequestStatusXHandle = Selector.GetHandle ("contentAuthorizationRequestStatus");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsApplicationAuthorizedForPlaybackX = "isApplicationAuthorizedForPlayback";
		static readonly NativeHandle selIsApplicationAuthorizedForPlaybackXHandle = Selector.GetHandle ("isApplicationAuthorizedForPlayback");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAuthorizationRequiredForPlaybackX = "isAuthorizationRequiredForPlayback";
		static readonly NativeHandle selIsAuthorizationRequiredForPlaybackXHandle = Selector.GetHandle ("isAuthorizationRequiredForPlayback");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsContentAuthorizedForPlaybackX = "isContentAuthorizedForPlayback";
		static readonly NativeHandle selIsContentAuthorizedForPlaybackXHandle = Selector.GetHandle ("isContentAuthorizedForPlayback");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestContentAuthorizationAsynchronouslyWithTimeoutInterval_CompletionHandler_X = "requestContentAuthorizationAsynchronouslyWithTimeoutInterval:completionHandler:";
		static readonly NativeHandle selRequestContentAuthorizationAsynchronouslyWithTimeoutInterval_CompletionHandler_XHandle = Selector.GetHandle ("requestContentAuthorizationAsynchronouslyWithTimeoutInterval:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVPlayerItem");
		/// <summary>To be added.</summary><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("cancelContentAuthorizationRequest")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CancelContentAuthorizationRequest (this AVPlayerItem This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, selCancelContentAuthorizationRequestXHandle);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("contentAuthorizationRequestStatus")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVContentAuthorizationStatus GetContentAuthorizationRequestStatus (this AVPlayerItem This)
		{
			AVContentAuthorizationStatus ret;
			ret = (AVContentAuthorizationStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, selContentAuthorizationRequestStatusXHandle);
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("isApplicationAuthorizedForPlayback")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsApplicationAuthorizedForPlayback (this AVPlayerItem This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, selIsApplicationAuthorizedForPlaybackXHandle);
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("isAuthorizationRequiredForPlayback")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsAuthorizationRequiredForPlayback (this AVPlayerItem This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, selIsAuthorizationRequiredForPlaybackXHandle);
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("isContentAuthorizedForPlayback")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsContentAuthorizedForPlayback (this AVPlayerItem This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, selIsContentAuthorizedForPlaybackXHandle);
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="timeoutInterval">To be added.</param><param name="handler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("requestContentAuthorizationAsynchronouslyWithTimeoutInterval:completionHandler:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RequestContentAuthorizationAsynchronously (this AVPlayerItem This, double timeoutInterval, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action handler)
		{
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDAction.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_Double_NativeHandle (This.Handle, selRequestContentAuthorizationAsynchronouslyWithTimeoutInterval_CompletionHandler_XHandle, timeoutInterval, (IntPtr) block_ptr_handler);
			GC.KeepAlive (This);
		}
	} /* class AVPlayerItem_AVPlayerItemProtectedContent */
}
