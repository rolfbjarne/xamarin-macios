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
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RestoreUserInterfaceForPictureInPicture", Selector = "playerViewController:restoreUserInterfaceForPictureInPictureStopWithCompletionHandler:", ParameterType = new Type [] { typeof (AVKit.AVPlayerViewController), typeof (global::System.Action<bool>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V4) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidPresentInterstitialTimeRange", Selector = "playerViewController:didPresentInterstitialTimeRange:", ParameterType = new Type [] { typeof (AVKit.AVPlayerViewController), typeof (AVKit.AVInterstitialTimeRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPresentInterstitialTimeRange", Selector = "playerViewController:willPresentInterstitialTimeRange:", ParameterType = new Type [] { typeof (AVKit.AVPlayerViewController), typeof (AVKit.AVInterstitialTimeRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillBeginFullScreenPresentation", Selector = "playerViewController:willBeginFullScreenPresentationWithAnimationCoordinator:", ParameterType = new Type [] { typeof (AVKit.AVPlayerViewController), typeof (IUIViewControllerTransitionCoordinator) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillEndFullScreenPresentation", Selector = "playerViewController:willEndFullScreenPresentationWithAnimationCoordinator:", ParameterType = new Type [] { typeof (AVKit.AVPlayerViewController), typeof (IUIViewControllerTransitionCoordinator) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RestoreUserInterfaceForFullScreenExit", Selector = "playerViewController:restoreUserInterfaceForFullScreenExitWithCompletionHandler:", ParameterType = new Type [] { typeof (AVKit.AVPlayerViewController), typeof (global::System.Action<bool>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V4) })]
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
		public unsafe virtual void RestoreUserInterfaceForPictureInPicture (AVPlayerViewController playerViewController, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V4))]global::System.Action<bool> completionHandler)
		{
			_RestoreUserInterfaceForPictureInPicture (this, playerViewController, completionHandler);
		}
		/// <param name="playerViewController">To be added.</param><param name="completionHandler">To be added.</param><summary>Picture In Picture playback is about to stop. Called to give the app the opportunity to provide a playback user interface by passing <see langword="true" /> to <paramref name="completionHandler" />.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RestoreUserInterfaceForPictureInPicture (IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V4))]global::System.Action<bool> completionHandler)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V4.CreateBlock (completionHandler);
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
		[Export ("playerViewController:willBeginFullScreenPresentationWithAnimationCoordinator:")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillBeginFullScreenPresentation (AVPlayerViewController playerViewController, global::UIKit.IUIViewControllerTransitionCoordinator coordinator)
		{
			_WillBeginFullScreenPresentation (this, playerViewController, coordinator);
		}
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillBeginFullScreenPresentation (IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, global::UIKit.IUIViewControllerTransitionCoordinator coordinator)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerViewController:willBeginFullScreenPresentationWithAnimationCoordinator:"), playerViewController__handle__, coordinator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
			GC.KeepAlive (coordinator);
		}
		[global::Foundation.OptionalMember]
		[Export ("playerViewController:willEndFullScreenPresentationWithAnimationCoordinator:")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEndFullScreenPresentation (AVPlayerViewController playerViewController, global::UIKit.IUIViewControllerTransitionCoordinator coordinator)
		{
			_WillEndFullScreenPresentation (this, playerViewController, coordinator);
		}
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillEndFullScreenPresentation (IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, global::UIKit.IUIViewControllerTransitionCoordinator coordinator)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerViewController:willEndFullScreenPresentationWithAnimationCoordinator:"), playerViewController__handle__, coordinator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
			GC.KeepAlive (coordinator);
		}
		[global::Foundation.OptionalMember]
		[Export ("playerViewController:restoreUserInterfaceForFullScreenExitWithCompletionHandler:")]
		[SupportedOSPlatform ("ios15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RestoreUserInterfaceForFullScreenExit (AVPlayerViewController playerViewController, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V4))]global::System.Action<bool> completionHandler)
		{
			_RestoreUserInterfaceForFullScreenExit (this, playerViewController, completionHandler);
		}
		[SupportedOSPlatform ("ios15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RestoreUserInterfaceForFullScreenExit (IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V4))]global::System.Action<bool> completionHandler)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V4.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerViewController:restoreUserInterfaceForFullScreenExitWithCompletionHandler:"), playerViewController__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
		}
		[DynamicDependencyAttribute ("DidPresentInterstitialTimeRange(AVKit.AVPlayerViewController,AVKit.AVInterstitialTimeRange)")]
		[DynamicDependencyAttribute ("DidStartPictureInPicture(AVKit.AVPlayerViewController)")]
		[DynamicDependencyAttribute ("DidStopPictureInPicture(AVKit.AVPlayerViewController)")]
		[DynamicDependencyAttribute ("FailedToStartPictureInPicture(AVKit.AVPlayerViewController,Foundation.NSError)")]
		[DynamicDependencyAttribute ("RestoreUserInterfaceForFullScreenExit(AVKit.AVPlayerViewController,System.Action{System.Boolean})")]
		[DynamicDependencyAttribute ("RestoreUserInterfaceForPictureInPicture(AVKit.AVPlayerViewController,System.Action{System.Boolean})")]
		[DynamicDependencyAttribute ("ShouldAutomaticallyDismissAtPictureInPictureStart(AVKit.AVPlayerViewController)")]
		[DynamicDependencyAttribute ("WillBeginFullScreenPresentation(AVKit.AVPlayerViewController,UIKit.IUIViewControllerTransitionCoordinator)")]
		[DynamicDependencyAttribute ("WillEndFullScreenPresentation(AVKit.AVPlayerViewController,UIKit.IUIViewControllerTransitionCoordinator)")]
		[DynamicDependencyAttribute ("WillPresentInterstitialTimeRange(AVKit.AVPlayerViewController,AVKit.AVInterstitialTimeRange)")]
		[DynamicDependencyAttribute ("WillStartPictureInPicture(AVKit.AVPlayerViewController)")]
		[DynamicDependencyAttribute ("WillStopPictureInPicture(AVKit.AVPlayerViewController)")]
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
		public unsafe static void RestoreUserInterfaceForPictureInPicture (this IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V4))]global::System.Action<bool> completionHandler)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V4.CreateBlock (completionHandler);
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
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillBeginFullScreenPresentation (this IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, global::UIKit.IUIViewControllerTransitionCoordinator coordinator)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerViewController:willBeginFullScreenPresentationWithAnimationCoordinator:"), playerViewController__handle__, coordinator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
			GC.KeepAlive (coordinator);
		}
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillEndFullScreenPresentation (this IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, global::UIKit.IUIViewControllerTransitionCoordinator coordinator)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerViewController:willEndFullScreenPresentationWithAnimationCoordinator:"), playerViewController__handle__, coordinator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
			GC.KeepAlive (coordinator);
		}
		[SupportedOSPlatform ("ios15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RestoreUserInterfaceForFullScreenExit (this IAVPlayerViewControllerDelegate This, AVPlayerViewController playerViewController, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V4))]global::System.Action<bool> completionHandler)
		{
			var playerViewController__handle__ = playerViewController!.GetNonNullHandle (nameof (playerViewController));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V4.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playerViewController:restoreUserInterfaceForFullScreenExitWithCompletionHandler:"), playerViewController__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (playerViewController);
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
	[Register("Microsoft_iOS__AVKit_AVPlayerViewControllerDelegate", false)]
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
		[Export ("playerViewController:restoreUserInterfaceForFullScreenExitWithCompletionHandler:")]
		[SupportedOSPlatform ("ios15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RestoreUserInterfaceForFullScreenExit (AVPlayerViewController playerViewController, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V4))]global::System.Action<bool> completionHandler)
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
		public unsafe virtual void RestoreUserInterfaceForPictureInPicture (AVPlayerViewController playerViewController, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V4))]global::System.Action<bool> completionHandler)
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
		[Export ("playerViewController:willBeginFullScreenPresentationWithAnimationCoordinator:")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillBeginFullScreenPresentation (AVPlayerViewController playerViewController, global::UIKit.IUIViewControllerTransitionCoordinator coordinator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("playerViewController:willEndFullScreenPresentationWithAnimationCoordinator:")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEndFullScreenPresentation (AVPlayerViewController playerViewController, global::UIKit.IUIViewControllerTransitionCoordinator coordinator)
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
	} /* class AVPlayerViewControllerDelegate */
}
