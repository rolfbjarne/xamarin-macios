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
namespace AVKit {
	#pragma warning disable CS1573
	/// <summary>Delegate object for the picture-in-picture controller. When overridden, the methods allow the developer to respond to events relating to p-in-p playback.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AVKit/Reference/AVPlayerViewControllerDelegate_Protocol/index.html">Apple documentation for <c>AVPlayerViewControllerDelegate</c></related>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "AVPlayerViewControllerDelegate", WrapperType = typeof (AVPlayerViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillStartPictureInPicture", Selector = "playerViewControllerWillStartPictureInPicture:", ParameterType = new Type [] { typeof (AVKit.AVPlayerViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidStartPictureInPicture", Selector = "playerViewControllerDidStartPictureInPicture:", ParameterType = new Type [] { typeof (AVKit.AVPlayerViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FailedToStartPictureInPicture", Selector = "playerViewController:failedToStartPictureInPictureWithError:", ParameterType = new Type [] { typeof (AVKit.AVPlayerViewController), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillStopPictureInPicture", Selector = "playerViewControllerWillStopPictureInPicture:", ParameterType = new Type [] { typeof (AVKit.AVPlayerViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidStopPictureInPicture", Selector = "playerViewControllerDidStopPictureInPicture:", ParameterType = new Type [] { typeof (AVKit.AVPlayerViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldAutomaticallyDismissAtPictureInPictureStart", Selector = "playerViewControllerShouldAutomaticallyDismissAtPictureInPictureStart:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (AVKit.AVPlayerViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RestoreUserInterfaceForPictureInPicture", Selector = "playerViewController:restoreUserInterfaceForPictureInPictureStopWithCompletionHandler:", ParameterType = new Type [] { typeof (AVKit.AVPlayerViewController), typeof (global::System.Action<bool>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V0) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidPresentInterstitialTimeRange", Selector = "playerViewController:didPresentInterstitialTimeRange:", ParameterType = new Type [] { typeof (AVKit.AVPlayerViewController), typeof (AVKit.AVInterstitialTimeRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldDismiss", Selector = "playerViewControllerShouldDismiss:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (AVKit.AVPlayerViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillBeginDismissalTransition", Selector = "playerViewControllerWillBeginDismissalTransition:", ParameterType = new Type [] { typeof (AVKit.AVPlayerViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEndDismissalTransition", Selector = "playerViewControllerDidEndDismissalTransition:", ParameterType = new Type [] { typeof (AVKit.AVPlayerViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPresentInterstitialTimeRange", Selector = "playerViewController:willPresentInterstitialTimeRange:", ParameterType = new Type [] { typeof (AVKit.AVPlayerViewController), typeof (AVKit.AVInterstitialTimeRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillResumePlaybackAfterUserNavigatedFromTime", Selector = "playerViewController:willResumePlaybackAfterUserNavigatedFromTime:toTime:", ParameterType = new Type [] { typeof (AVKit.AVPlayerViewController), typeof (CMTime), typeof (CMTime) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectMediaSelectionOption", Selector = "playerViewController:didSelectMediaSelectionOption:inMediaSelectionGroup:", ParameterType = new Type [] { typeof (AVKit.AVPlayerViewController), typeof (AVMediaSelectionOption), typeof (AVMediaSelectionGroup) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectExternalSubtitleOptionLanguage", Selector = "playerViewController:didSelectExternalSubtitleOptionLanguage:", ParameterType = new Type [] { typeof (AVKit.AVPlayerViewController), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetTimeToSeekAfterUserNavigated", Selector = "playerViewController:timeToSeekAfterUserNavigatedFromTime:toTime:", ReturnType = typeof (CMTime), ParameterType = new Type [] { typeof (AVKit.AVPlayerViewController), typeof (CMTime), typeof (CMTime) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SkipToNextItem", Selector = "skipToNextItemForPlayerViewController:", ParameterType = new Type [] { typeof (AVKit.AVPlayerViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SkipToPreviousItem", Selector = "skipToPreviousItemForPlayerViewController:", ParameterType = new Type [] { typeof (AVKit.AVPlayerViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldPresentContentProposal", Selector = "playerViewController:shouldPresentContentProposal:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (AVKit.AVPlayerViewController), typeof (AVContentProposal) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAcceptContentProposal", Selector = "playerViewController:didAcceptContentProposal:", ParameterType = new Type [] { typeof (AVKit.AVPlayerViewController), typeof (AVContentProposal) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRejectContentProposal", Selector = "playerViewController:didRejectContentProposal:", ParameterType = new Type [] { typeof (AVKit.AVPlayerViewController), typeof (AVContentProposal) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillTransitionToVisibilityOfTransportBar", Selector = "playerViewController:willTransitionToVisibilityOfTransportBar:withAnimationCoordinator:", ParameterType = new Type [] { typeof (AVKit.AVPlayerViewController), typeof (bool), typeof (AVKit.IAVPlayerViewControllerAnimationCoordinator) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetNextChannelInterstitialViewController", Selector = "nextChannelInterstitialViewControllerForPlayerViewController:", ReturnType = typeof (UIViewController), ParameterType = new Type [] { typeof (AVKit.AVPlayerViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SkipToNextChannel", Selector = "playerViewController:skipToNextChannel:", ParameterType = new Type [] { typeof (AVKit.AVPlayerViewController), typeof (global::System.Action<bool>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V0) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SkipToPreviousChannel", Selector = "playerViewController:skipToPreviousChannel:", ParameterType = new Type [] { typeof (AVKit.AVPlayerViewController), typeof (global::System.Action<bool>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V0) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPreviousChannelInterstitialViewController", Selector = "previousChannelInterstitialViewControllerForPlayerViewController:", ReturnType = typeof (UIViewController), ParameterType = new Type [] { typeof (AVKit.AVPlayerViewController) }, ParameterByRef = new bool [] { false })]
	public partial interface IAVPlayerViewControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="playerViewController">To be added.</param><summary>Picture In Picture playback is about to start.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("playerViewControllerWillStartPictureInPicture:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillStartPictureInPicture (AVPlayerViewController playerViewController)
		{
			_WillStartPictureInPicture (this, playerViewController);
		}
		/// <param name="playerViewController">To be added.</param><summary>Picture In Picture playback is about to start.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillStartPictureInPicture (IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewControllerWillStartPictureInPicture:"), playerViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
		}
		/// <param name="playerViewController">To be added.</param><summary>Picture In Picture playback has started.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("playerViewControllerDidStartPictureInPicture:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStartPictureInPicture (AVPlayerViewController playerViewController)
		{
			_DidStartPictureInPicture (this, playerViewController);
		}
		/// <param name="playerViewController">To be added.</param><summary>Picture In Picture playback has started.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidStartPictureInPicture (IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewControllerDidStartPictureInPicture:"), playerViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
		}
		/// <param name="playerViewController">To be added.</param><param name="error">To be added.</param><summary>Picture In Picture playback failed to start.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("playerViewController:failedToStartPictureInPictureWithError:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedToStartPictureInPicture (AVPlayerViewController playerViewController, NSError error)
		{
			_FailedToStartPictureInPicture (this, playerViewController, error);
		}
		/// <param name="playerViewController">To be added.</param><param name="error">To be added.</param><summary>Picture In Picture playback failed to start.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FailedToStartPictureInPicture (IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, NSError error)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerViewController:failedToStartPictureInPictureWithError:"), playerViewController__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
			GC.KeepAlive (error);
		}
		/// <param name="playerViewController">To be added.</param><summary>Picture In Picture playback is about to stop.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("playerViewControllerWillStopPictureInPicture:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillStopPictureInPicture (AVPlayerViewController playerViewController)
		{
			_WillStopPictureInPicture (this, playerViewController);
		}
		/// <param name="playerViewController">To be added.</param><summary>Picture In Picture playback is about to stop.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillStopPictureInPicture (IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewControllerWillStopPictureInPicture:"), playerViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
		}
		/// <param name="playerViewController">To be added.</param><summary>Picture In Picture playback has stopped.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("playerViewControllerDidStopPictureInPicture:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStopPictureInPicture (AVPlayerViewController playerViewController)
		{
			_DidStopPictureInPicture (this, playerViewController);
		}
		/// <param name="playerViewController">To be added.</param><summary>Picture In Picture playback has stopped.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidStopPictureInPicture (IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewControllerDidStopPictureInPicture:"), playerViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
		}
		/// <param name="playerViewController">To be added.</param><summary>App developers should return <see langword="true" /> to indicate that the player viewer should dismiss when Picture In Picture playback starts, or <see langword="false" /> to prevent this.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("playerViewControllerShouldAutomaticallyDismissAtPictureInPictureStart:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldAutomaticallyDismissAtPictureInPictureStart (AVPlayerViewController playerViewController)
		{
			return _ShouldAutomaticallyDismissAtPictureInPictureStart (this, playerViewController);
		}
		/// <param name="playerViewController">To be added.</param><summary>App developers should return <see langword="true" /> to indicate that the player viewer should dismiss when Picture In Picture playback starts, or <see langword="false" /> to prevent this.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldAutomaticallyDismissAtPictureInPictureStart (IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewControllerShouldAutomaticallyDismissAtPictureInPictureStart:"), playerViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
			return ret != 0;
		}
		/// <param name="playerViewController">To be added.</param><param name="completionHandler">To be added.</param><summary>Picture In Picture playback is about to stop. Called to give the app the opportunity to provide a playback user interface by passing <see langword="true" /> to <paramref name="completionHandler" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("playerViewController:restoreUserInterfaceForPictureInPictureStopWithCompletionHandler:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RestoreUserInterfaceForPictureInPicture (AVPlayerViewController playerViewController, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> completionHandler)
		{
			_RestoreUserInterfaceForPictureInPicture (this, playerViewController, completionHandler);
		}
		/// <param name="playerViewController">To be added.</param><param name="completionHandler">To be added.</param><summary>Picture In Picture playback is about to stop. Called to give the app the opportunity to provide a playback user interface by passing <see langword="true" /> to <paramref name="completionHandler" />.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RestoreUserInterfaceForPictureInPicture (IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> completionHandler)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerViewController:restoreUserInterfaceForPictureInPictureStopWithCompletionHandler:"), playerViewController__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
		}
		[global::Foundation.OptionalMember]
		[Export ("playerViewController:didPresentInterstitialTimeRange:")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPresentInterstitialTimeRange (AVPlayerViewController playerViewController, AVInterstitialTimeRange interstitial)
		{
			_DidPresentInterstitialTimeRange (this, playerViewController, interstitial);
		}
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidPresentInterstitialTimeRange (IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, AVInterstitialTimeRange interstitial)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			var interstitial__handle__ = interstitial!.GetNonNullHandle (nameof (interstitial));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerViewController:didPresentInterstitialTimeRange:"), playerViewController__handle__, interstitial__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
			GC.KeepAlive (interstitial);
		}
		[global::Foundation.OptionalMember]
		[Export ("playerViewControllerShouldDismiss:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldDismiss (AVPlayerViewController playerViewController)
		{
			return _ShouldDismiss (this, playerViewController);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldDismiss (IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewControllerShouldDismiss:"), playerViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("playerViewControllerWillBeginDismissalTransition:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillBeginDismissalTransition (AVPlayerViewController playerViewController)
		{
			_WillBeginDismissalTransition (this, playerViewController);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillBeginDismissalTransition (IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewControllerWillBeginDismissalTransition:"), playerViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
		}
		[global::Foundation.OptionalMember]
		[Export ("playerViewControllerDidEndDismissalTransition:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndDismissalTransition (AVPlayerViewController playerViewController)
		{
			_DidEndDismissalTransition (this, playerViewController);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidEndDismissalTransition (IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewControllerDidEndDismissalTransition:"), playerViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
		}
		[global::Foundation.OptionalMember]
		[Export ("playerViewController:willPresentInterstitialTimeRange:")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresentInterstitialTimeRange (AVPlayerViewController playerViewController, AVInterstitialTimeRange interstitial)
		{
			_WillPresentInterstitialTimeRange (this, playerViewController, interstitial);
		}
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillPresentInterstitialTimeRange (IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, AVInterstitialTimeRange interstitial)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			var interstitial__handle__ = interstitial!.GetNonNullHandle (nameof (interstitial));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerViewController:willPresentInterstitialTimeRange:"), playerViewController__handle__, interstitial__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
			GC.KeepAlive (interstitial);
		}
		[global::Foundation.OptionalMember]
		[Export ("playerViewController:willResumePlaybackAfterUserNavigatedFromTime:toTime:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillResumePlaybackAfterUserNavigatedFromTime (AVPlayerViewController playerViewController, global::CoreMedia.CMTime oldTime, global::CoreMedia.CMTime targetTime)
		{
			_WillResumePlaybackAfterUserNavigatedFromTime (this, playerViewController, oldTime, targetTime);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillResumePlaybackAfterUserNavigatedFromTime (IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, global::CoreMedia.CMTime oldTime, global::CoreMedia.CMTime targetTime)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CMTime_CMTime (This.Handle, Selector.GetHandle ("playerViewController:willResumePlaybackAfterUserNavigatedFromTime:toTime:"), playerViewController__handle__, oldTime, targetTime);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
		}
		[global::Foundation.OptionalMember]
		[Export ("playerViewController:didSelectMediaSelectionOption:inMediaSelectionGroup:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectMediaSelectionOption (AVPlayerViewController playerViewController, global::AVFoundation.AVMediaSelectionOption? mediaSelectionOption, global::AVFoundation.AVMediaSelectionGroup mediaSelectionGroup)
		{
			_DidSelectMediaSelectionOption (this, playerViewController, mediaSelectionOption, mediaSelectionGroup);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSelectMediaSelectionOption (IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, global::AVFoundation.AVMediaSelectionOption? mediaSelectionOption, global::AVFoundation.AVMediaSelectionGroup mediaSelectionGroup)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			var mediaSelectionOption__handle__ = mediaSelectionOption.GetHandle ();
			var mediaSelectionGroup__handle__ = mediaSelectionGroup!.GetNonNullHandle (nameof (mediaSelectionGroup));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerViewController:didSelectMediaSelectionOption:inMediaSelectionGroup:"), playerViewController__handle__, mediaSelectionOption__handle__, mediaSelectionGroup__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
			GC.KeepAlive (mediaSelectionOption);
			GC.KeepAlive (mediaSelectionGroup);
		}
		[global::Foundation.OptionalMember]
		[Export ("playerViewController:didSelectExternalSubtitleOptionLanguage:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectExternalSubtitleOptionLanguage (AVPlayerViewController playerViewController, string language)
		{
			_DidSelectExternalSubtitleOptionLanguage (this, playerViewController, language);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSelectExternalSubtitleOptionLanguage (IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, string language)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			if (language is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (language));
			var nslanguage = CFString.CreateNative (language);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerViewController:didSelectExternalSubtitleOptionLanguage:"), playerViewController__handle__, nslanguage);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
			CFString.ReleaseNative (nslanguage);
		}
		[global::Foundation.OptionalMember]
		[Export ("playerViewController:timeToSeekAfterUserNavigatedFromTime:toTime:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreMedia.CMTime GetTimeToSeekAfterUserNavigated (AVPlayerViewController playerViewController, global::CoreMedia.CMTime oldTime, global::CoreMedia.CMTime targetTime)
		{
			return _GetTimeToSeekAfterUserNavigated (this, playerViewController, oldTime, targetTime);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::CoreMedia.CMTime _GetTimeToSeekAfterUserNavigated (IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, global::CoreMedia.CMTime oldTime, global::CoreMedia.CMTime targetTime)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			global::CoreMedia.CMTime ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_NativeHandle_CMTime_CMTime (This.Handle, Selector.GetHandle ("playerViewController:timeToSeekAfterUserNavigatedFromTime:toTime:"), playerViewController__handle__, oldTime, targetTime);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret_NativeHandle_CMTime_CMTime (This.Handle, Selector.GetHandle ("playerViewController:timeToSeekAfterUserNavigatedFromTime:toTime:"), playerViewController__handle__, oldTime, targetTime);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (playerViewController);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("skipToNextItemForPlayerViewController:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SkipToNextItem (AVPlayerViewController playerViewController)
		{
			_SkipToNextItem (this, playerViewController);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SkipToNextItem (IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("skipToNextItemForPlayerViewController:"), playerViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
		}
		[global::Foundation.OptionalMember]
		[Export ("skipToPreviousItemForPlayerViewController:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SkipToPreviousItem (AVPlayerViewController playerViewController)
		{
			_SkipToPreviousItem (this, playerViewController);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SkipToPreviousItem (IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("skipToPreviousItemForPlayerViewController:"), playerViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
		}
		[global::Foundation.OptionalMember]
		[Export ("playerViewController:shouldPresentContentProposal:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldPresentContentProposal (AVPlayerViewController playerViewController, global::AVFoundation.AVContentProposal proposal)
		{
			return _ShouldPresentContentProposal (this, playerViewController, proposal);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldPresentContentProposal (IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, global::AVFoundation.AVContentProposal proposal)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			var proposal__handle__ = proposal!.GetNonNullHandle (nameof (proposal));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerViewController:shouldPresentContentProposal:"), playerViewController__handle__, proposal__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
			GC.KeepAlive (proposal);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("playerViewController:didAcceptContentProposal:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAcceptContentProposal (AVPlayerViewController playerViewController, global::AVFoundation.AVContentProposal proposal)
		{
			_DidAcceptContentProposal (this, playerViewController, proposal);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidAcceptContentProposal (IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, global::AVFoundation.AVContentProposal proposal)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			var proposal__handle__ = proposal!.GetNonNullHandle (nameof (proposal));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerViewController:didAcceptContentProposal:"), playerViewController__handle__, proposal__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
			GC.KeepAlive (proposal);
		}
		[global::Foundation.OptionalMember]
		[Export ("playerViewController:didRejectContentProposal:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRejectContentProposal (AVPlayerViewController playerViewController, global::AVFoundation.AVContentProposal proposal)
		{
			_DidRejectContentProposal (this, playerViewController, proposal);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRejectContentProposal (IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, global::AVFoundation.AVContentProposal proposal)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			var proposal__handle__ = proposal!.GetNonNullHandle (nameof (proposal));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerViewController:didRejectContentProposal:"), playerViewController__handle__, proposal__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
			GC.KeepAlive (proposal);
		}
		[global::Foundation.OptionalMember]
		[Export ("playerViewController:willTransitionToVisibilityOfTransportBar:withAnimationCoordinator:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillTransitionToVisibilityOfTransportBar (AVPlayerViewController playerViewController, bool visible, IAVPlayerViewControllerAnimationCoordinator coordinator)
		{
			_WillTransitionToVisibilityOfTransportBar (this, playerViewController, visible, coordinator);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillTransitionToVisibilityOfTransportBar (IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, bool visible, IAVPlayerViewControllerAnimationCoordinator coordinator)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool_NativeHandle (This.Handle, Selector.GetHandle ("playerViewController:willTransitionToVisibilityOfTransportBar:withAnimationCoordinator:"), playerViewController__handle__, visible ? (byte) 1 : (byte) 0, coordinator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
			GC.KeepAlive (coordinator);
		}
		[global::Foundation.OptionalMember]
		[Export ("nextChannelInterstitialViewControllerForPlayerViewController:")]
		[SupportedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIViewController GetNextChannelInterstitialViewController (AVPlayerViewController playerViewController)
		{
			return _GetNextChannelInterstitialViewController (this, playerViewController);
		}
		[SupportedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::UIKit.UIViewController _GetNextChannelInterstitialViewController (IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			global::UIKit.UIViewController? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("nextChannelInterstitialViewControllerForPlayerViewController:"), playerViewController__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("playerViewController:skipToNextChannel:")]
		[SupportedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SkipToNextChannel (AVPlayerViewController playerViewController, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> completion)
		{
			_SkipToNextChannel (this, playerViewController, completion);
		}
		[SupportedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SkipToNextChannel (IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> completion)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerViewController:skipToNextChannel:"), playerViewController__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
		}
		[global::Foundation.OptionalMember]
		[Export ("playerViewController:skipToPreviousChannel:")]
		[SupportedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SkipToPreviousChannel (AVPlayerViewController playerViewController, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> completion)
		{
			_SkipToPreviousChannel (this, playerViewController, completion);
		}
		[SupportedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SkipToPreviousChannel (IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> completion)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerViewController:skipToPreviousChannel:"), playerViewController__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
		}
		[global::Foundation.OptionalMember]
		[Export ("previousChannelInterstitialViewControllerForPlayerViewController:")]
		[SupportedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIViewController GetPreviousChannelInterstitialViewController (AVPlayerViewController playerViewController)
		{
			return _GetPreviousChannelInterstitialViewController (this, playerViewController);
		}
		[SupportedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::UIKit.UIViewController _GetPreviousChannelInterstitialViewController (IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			global::UIKit.UIViewController? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("previousChannelInterstitialViewControllerForPlayerViewController:"), playerViewController__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
			return ret!;
		}
		[DynamicDependencyAttribute ("DidAcceptContentProposal(AVKit.AVPlayerViewController,AVFoundation.AVContentProposal)")]
		[DynamicDependencyAttribute ("DidEndDismissalTransition(AVKit.AVPlayerViewController)")]
		[DynamicDependencyAttribute ("DidPresentInterstitialTimeRange(AVKit.AVPlayerViewController,AVKit.AVInterstitialTimeRange)")]
		[DynamicDependencyAttribute ("DidRejectContentProposal(AVKit.AVPlayerViewController,AVFoundation.AVContentProposal)")]
		[DynamicDependencyAttribute ("DidSelectExternalSubtitleOptionLanguage(AVKit.AVPlayerViewController,System.String)")]
		[DynamicDependencyAttribute ("DidSelectMediaSelectionOption(AVKit.AVPlayerViewController,AVFoundation.AVMediaSelectionOption,AVFoundation.AVMediaSelectionGroup)")]
		[DynamicDependencyAttribute ("DidStartPictureInPicture(AVKit.AVPlayerViewController)")]
		[DynamicDependencyAttribute ("DidStopPictureInPicture(AVKit.AVPlayerViewController)")]
		[DynamicDependencyAttribute ("FailedToStartPictureInPicture(AVKit.AVPlayerViewController,Foundation.NSError)")]
		[DynamicDependencyAttribute ("GetNextChannelInterstitialViewController(AVKit.AVPlayerViewController)")]
		[DynamicDependencyAttribute ("GetPreviousChannelInterstitialViewController(AVKit.AVPlayerViewController)")]
		[DynamicDependencyAttribute ("GetTimeToSeekAfterUserNavigated(AVKit.AVPlayerViewController,CoreMedia.CMTime,CoreMedia.CMTime)")]
		[DynamicDependencyAttribute ("RestoreUserInterfaceForPictureInPicture(AVKit.AVPlayerViewController,System.Action{System.Boolean})")]
		[DynamicDependencyAttribute ("ShouldAutomaticallyDismissAtPictureInPictureStart(AVKit.AVPlayerViewController)")]
		[DynamicDependencyAttribute ("ShouldDismiss(AVKit.AVPlayerViewController)")]
		[DynamicDependencyAttribute ("ShouldPresentContentProposal(AVKit.AVPlayerViewController,AVFoundation.AVContentProposal)")]
		[DynamicDependencyAttribute ("SkipToNextChannel(AVKit.AVPlayerViewController,System.Action{System.Boolean})")]
		[DynamicDependencyAttribute ("SkipToNextItem(AVKit.AVPlayerViewController)")]
		[DynamicDependencyAttribute ("SkipToPreviousChannel(AVKit.AVPlayerViewController,System.Action{System.Boolean})")]
		[DynamicDependencyAttribute ("SkipToPreviousItem(AVKit.AVPlayerViewController)")]
		[DynamicDependencyAttribute ("WillBeginDismissalTransition(AVKit.AVPlayerViewController)")]
		[DynamicDependencyAttribute ("WillPresentInterstitialTimeRange(AVKit.AVPlayerViewController,AVKit.AVInterstitialTimeRange)")]
		[DynamicDependencyAttribute ("WillResumePlaybackAfterUserNavigatedFromTime(AVKit.AVPlayerViewController,CoreMedia.CMTime,CoreMedia.CMTime)")]
		[DynamicDependencyAttribute ("WillStartPictureInPicture(AVKit.AVPlayerViewController)")]
		[DynamicDependencyAttribute ("WillStopPictureInPicture(AVKit.AVPlayerViewController)")]
		[DynamicDependencyAttribute ("WillTransitionToVisibilityOfTransportBar(AVKit.AVPlayerViewController,System.Boolean,AVKit.IAVPlayerViewControllerAnimationCoordinator)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVPlayerViewControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAVPlayerViewControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IAVPlayerViewControllerDelegate" /> interface to support all the methods from the AVPlayerViewControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IAVPlayerViewControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original AVPlayerViewControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class AVPlayerViewControllerDelegate_Extensions {
		/// <param name="playerViewController">To be added.</param><summary>Picture In Picture playback is about to start.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillStartPictureInPicture (this IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewControllerWillStartPictureInPicture:"), playerViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
		}
		/// <param name="playerViewController">To be added.</param><summary>Picture In Picture playback has started.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidStartPictureInPicture (this IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewControllerDidStartPictureInPicture:"), playerViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
		}
		/// <param name="playerViewController">To be added.</param><param name="error">To be added.</param><summary>Picture In Picture playback failed to start.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FailedToStartPictureInPicture (this IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, NSError error)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerViewController:failedToStartPictureInPictureWithError:"), playerViewController__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
			GC.KeepAlive (error);
		}
		/// <param name="playerViewController">To be added.</param><summary>Picture In Picture playback is about to stop.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillStopPictureInPicture (this IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewControllerWillStopPictureInPicture:"), playerViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
		}
		/// <param name="playerViewController">To be added.</param><summary>Picture In Picture playback has stopped.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidStopPictureInPicture (this IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewControllerDidStopPictureInPicture:"), playerViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
		}
		/// <param name="playerViewController">To be added.</param><summary>App developers should return <see langword="true" /> to indicate that the player viewer should dismiss when Picture In Picture playback starts, or <see langword="false" /> to prevent this.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldAutomaticallyDismissAtPictureInPictureStart (this IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewControllerShouldAutomaticallyDismissAtPictureInPictureStart:"), playerViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
			return ret != 0;
		}
		/// <param name="playerViewController">To be added.</param><param name="completionHandler">To be added.</param><summary>Picture In Picture playback is about to stop. Called to give the app the opportunity to provide a playback user interface by passing <see langword="true" /> to <paramref name="completionHandler" />.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RestoreUserInterfaceForPictureInPicture (this IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> completionHandler)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerViewController:restoreUserInterfaceForPictureInPictureStopWithCompletionHandler:"), playerViewController__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
		}
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidPresentInterstitialTimeRange (this IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, AVInterstitialTimeRange interstitial)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			var interstitial__handle__ = interstitial!.GetNonNullHandle (nameof (interstitial));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerViewController:didPresentInterstitialTimeRange:"), playerViewController__handle__, interstitial__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
			GC.KeepAlive (interstitial);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldDismiss (this IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewControllerShouldDismiss:"), playerViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
			return ret != 0;
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillBeginDismissalTransition (this IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewControllerWillBeginDismissalTransition:"), playerViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidEndDismissalTransition (this IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerViewControllerDidEndDismissalTransition:"), playerViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
		}
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillPresentInterstitialTimeRange (this IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, AVInterstitialTimeRange interstitial)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			var interstitial__handle__ = interstitial!.GetNonNullHandle (nameof (interstitial));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerViewController:willPresentInterstitialTimeRange:"), playerViewController__handle__, interstitial__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
			GC.KeepAlive (interstitial);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillResumePlaybackAfterUserNavigatedFromTime (this IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, global::CoreMedia.CMTime oldTime, global::CoreMedia.CMTime targetTime)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CMTime_CMTime (This.Handle, Selector.GetHandle ("playerViewController:willResumePlaybackAfterUserNavigatedFromTime:toTime:"), playerViewController__handle__, oldTime, targetTime);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSelectMediaSelectionOption (this IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, global::AVFoundation.AVMediaSelectionOption? mediaSelectionOption, global::AVFoundation.AVMediaSelectionGroup mediaSelectionGroup)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			var mediaSelectionOption__handle__ = mediaSelectionOption.GetHandle ();
			var mediaSelectionGroup__handle__ = mediaSelectionGroup!.GetNonNullHandle (nameof (mediaSelectionGroup));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerViewController:didSelectMediaSelectionOption:inMediaSelectionGroup:"), playerViewController__handle__, mediaSelectionOption__handle__, mediaSelectionGroup__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
			GC.KeepAlive (mediaSelectionOption);
			GC.KeepAlive (mediaSelectionGroup);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSelectExternalSubtitleOptionLanguage (this IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, string language)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			if (language is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (language));
			var nslanguage = CFString.CreateNative (language);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerViewController:didSelectExternalSubtitleOptionLanguage:"), playerViewController__handle__, nslanguage);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
			CFString.ReleaseNative (nslanguage);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::CoreMedia.CMTime GetTimeToSeekAfterUserNavigated (this IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, global::CoreMedia.CMTime oldTime, global::CoreMedia.CMTime targetTime)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			global::CoreMedia.CMTime ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_NativeHandle_CMTime_CMTime (This.Handle, Selector.GetHandle ("playerViewController:timeToSeekAfterUserNavigatedFromTime:toTime:"), playerViewController__handle__, oldTime, targetTime);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret_NativeHandle_CMTime_CMTime (This.Handle, Selector.GetHandle ("playerViewController:timeToSeekAfterUserNavigatedFromTime:toTime:"), playerViewController__handle__, oldTime, targetTime);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (playerViewController);
			return ret!;
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SkipToNextItem (this IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("skipToNextItemForPlayerViewController:"), playerViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SkipToPreviousItem (this IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("skipToPreviousItemForPlayerViewController:"), playerViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldPresentContentProposal (this IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, global::AVFoundation.AVContentProposal proposal)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			var proposal__handle__ = proposal!.GetNonNullHandle (nameof (proposal));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerViewController:shouldPresentContentProposal:"), playerViewController__handle__, proposal__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
			GC.KeepAlive (proposal);
			return ret != 0;
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidAcceptContentProposal (this IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, global::AVFoundation.AVContentProposal proposal)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			var proposal__handle__ = proposal!.GetNonNullHandle (nameof (proposal));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerViewController:didAcceptContentProposal:"), playerViewController__handle__, proposal__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
			GC.KeepAlive (proposal);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRejectContentProposal (this IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, global::AVFoundation.AVContentProposal proposal)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			var proposal__handle__ = proposal!.GetNonNullHandle (nameof (proposal));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerViewController:didRejectContentProposal:"), playerViewController__handle__, proposal__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
			GC.KeepAlive (proposal);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillTransitionToVisibilityOfTransportBar (this IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, bool visible, IAVPlayerViewControllerAnimationCoordinator coordinator)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool_NativeHandle (This.Handle, Selector.GetHandle ("playerViewController:willTransitionToVisibilityOfTransportBar:withAnimationCoordinator:"), playerViewController__handle__, visible ? (byte) 1 : (byte) 0, coordinator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
			GC.KeepAlive (coordinator);
		}
		[SupportedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIViewController GetNextChannelInterstitialViewController (this IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			global::UIKit.UIViewController? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("nextChannelInterstitialViewControllerForPlayerViewController:"), playerViewController__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
			return ret!;
		}
		[SupportedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void SkipToNextChannel (this IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> completion)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerViewController:skipToNextChannel:"), playerViewController__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
		}
		[SupportedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void SkipToPreviousChannel (this IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> completion)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerViewController:skipToPreviousChannel:"), playerViewController__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
		}
		[SupportedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIViewController GetPreviousChannelInterstitialViewController (this IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			global::UIKit.UIViewController? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("previousChannelInterstitialViewControllerForPlayerViewController:"), playerViewController__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AVPlayerViewControllerDelegateWrapper : BaseWrapper, IAVPlayerViewControllerDelegate {
		public AVPlayerViewControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVPlayerViewControllerDelegateWrapper))]
		static AVPlayerViewControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AVKit {
	/// <summary>Delegate object for the picture-in-picture controller. When overridden, the methods allow the developer to respond to events relating to p-in-p playback.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AVKit/Reference/AVPlayerViewControllerDelegate_Protocol/index.html">Apple documentation for <c>AVPlayerViewControllerDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_tvOS__AVKit_AVPlayerViewControllerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class AVPlayerViewControllerDelegate : NSObject, IAVPlayerViewControllerDelegate {
		/// <summary>Creates a new <see cref="AVPlayerViewControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AVPlayerViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected AVPlayerViewControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal AVPlayerViewControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("playerViewController:didAcceptContentProposal:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAcceptContentProposal (AVPlayerViewController playerViewController, global::AVFoundation.AVContentProposal proposal)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("playerViewControllerDidEndDismissalTransition:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndDismissalTransition (AVPlayerViewController playerViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("playerViewController:didPresentInterstitialTimeRange:")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPresentInterstitialTimeRange (AVPlayerViewController playerViewController, AVInterstitialTimeRange interstitial)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("playerViewController:didRejectContentProposal:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRejectContentProposal (AVPlayerViewController playerViewController, global::AVFoundation.AVContentProposal proposal)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("playerViewController:didSelectExternalSubtitleOptionLanguage:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectExternalSubtitleOptionLanguage (AVPlayerViewController playerViewController, string language)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("playerViewController:didSelectMediaSelectionOption:inMediaSelectionGroup:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectMediaSelectionOption (AVPlayerViewController playerViewController, global::AVFoundation.AVMediaSelectionOption? mediaSelectionOption, global::AVFoundation.AVMediaSelectionGroup mediaSelectionGroup)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="playerViewController">To be added.</param><summary>Picture In Picture playback has started.</summary><remarks>To be added.</remarks>
		[Export ("playerViewControllerDidStartPictureInPicture:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStartPictureInPicture (AVPlayerViewController playerViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="playerViewController">To be added.</param><summary>Picture In Picture playback has stopped.</summary><remarks>To be added.</remarks>
		[Export ("playerViewControllerDidStopPictureInPicture:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStopPictureInPicture (AVPlayerViewController playerViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="playerViewController">To be added.</param><param name="error">To be added.</param><summary>Picture In Picture playback failed to start.</summary><remarks>To be added.</remarks>
		[Export ("playerViewController:failedToStartPictureInPictureWithError:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedToStartPictureInPicture (AVPlayerViewController playerViewController, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("nextChannelInterstitialViewControllerForPlayerViewController:")]
		[SupportedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIViewController GetNextChannelInterstitialViewController (AVPlayerViewController playerViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("previousChannelInterstitialViewControllerForPlayerViewController:")]
		[SupportedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIViewController GetPreviousChannelInterstitialViewController (AVPlayerViewController playerViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("playerViewController:timeToSeekAfterUserNavigatedFromTime:toTime:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreMedia.CMTime GetTimeToSeekAfterUserNavigated (AVPlayerViewController playerViewController, global::CoreMedia.CMTime oldTime, global::CoreMedia.CMTime targetTime)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="playerViewController">To be added.</param><param name="completionHandler">To be added.</param><summary>Picture In Picture playback is about to stop. Called to give the app the opportunity to provide a playback user interface by passing <see langword="true" /> to <paramref name="completionHandler" />.</summary><remarks>To be added.</remarks>
		[Export ("playerViewController:restoreUserInterfaceForPictureInPictureStopWithCompletionHandler:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RestoreUserInterfaceForPictureInPicture (AVPlayerViewController playerViewController, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="playerViewController">To be added.</param><summary>App developers should return <see langword="true" /> to indicate that the player viewer should dismiss when Picture In Picture playback starts, or <see langword="false" /> to prevent this.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("playerViewControllerShouldAutomaticallyDismissAtPictureInPictureStart:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldAutomaticallyDismissAtPictureInPictureStart (AVPlayerViewController playerViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("playerViewControllerShouldDismiss:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldDismiss (AVPlayerViewController playerViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("playerViewController:shouldPresentContentProposal:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldPresentContentProposal (AVPlayerViewController playerViewController, global::AVFoundation.AVContentProposal proposal)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("playerViewController:skipToNextChannel:")]
		[SupportedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SkipToNextChannel (AVPlayerViewController playerViewController, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("skipToNextItemForPlayerViewController:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SkipToNextItem (AVPlayerViewController playerViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("playerViewController:skipToPreviousChannel:")]
		[SupportedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SkipToPreviousChannel (AVPlayerViewController playerViewController, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("skipToPreviousItemForPlayerViewController:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SkipToPreviousItem (AVPlayerViewController playerViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("playerViewControllerWillBeginDismissalTransition:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillBeginDismissalTransition (AVPlayerViewController playerViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("playerViewController:willPresentInterstitialTimeRange:")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresentInterstitialTimeRange (AVPlayerViewController playerViewController, AVInterstitialTimeRange interstitial)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("playerViewController:willResumePlaybackAfterUserNavigatedFromTime:toTime:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillResumePlaybackAfterUserNavigatedFromTime (AVPlayerViewController playerViewController, global::CoreMedia.CMTime oldTime, global::CoreMedia.CMTime targetTime)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="playerViewController">To be added.</param><summary>Picture In Picture playback is about to start.</summary><remarks>To be added.</remarks>
		[Export ("playerViewControllerWillStartPictureInPicture:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillStartPictureInPicture (AVPlayerViewController playerViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="playerViewController">To be added.</param><summary>Picture In Picture playback is about to stop.</summary><remarks>To be added.</remarks>
		[Export ("playerViewControllerWillStopPictureInPicture:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillStopPictureInPicture (AVPlayerViewController playerViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("playerViewController:willTransitionToVisibilityOfTransportBar:withAnimationCoordinator:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillTransitionToVisibilityOfTransportBar (AVPlayerViewController playerViewController, bool visible, IAVPlayerViewControllerAnimationCoordinator coordinator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class AVPlayerViewControllerDelegate */
}
