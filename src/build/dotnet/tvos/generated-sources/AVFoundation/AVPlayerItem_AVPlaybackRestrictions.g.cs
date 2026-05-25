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
namespace AVFoundation {
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos13.0")]
	[UnsupportedOSPlatform ("maccatalyst")]
	public unsafe static partial class AVPlayerItem_AVPlaybackRestrictions  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVPlayerItem");
		[Export ("cancelPlaybackRestrictionsAuthorizationRequest")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CancelPlaybackRestrictionsAuthorizationRequest (this AVPlayerItem This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("cancelPlaybackRestrictionsAuthorizationRequest"));
			GC.KeepAlive (This);
		}
		[Export ("requestPlaybackRestrictionsAuthorization:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RequestPlaybackRestrictionsAuthorization (this AVPlayerItem This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V12))]global::System.Action<bool, NSError> completion)
		{
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity2V12.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("requestPlaybackRestrictionsAuthorization:"), (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<Tuple<bool,NSError>> RequestPlaybackRestrictionsAuthorizationAsync (this AVPlayerItem This)
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError>> ();
			This.RequestPlaybackRestrictionsAuthorization((arg1_, arg2_) => {
				tcs.SetResult (new Tuple<bool,NSError> (arg1_, arg2_));
			});
			return tcs.Task;
		}
	} /* class AVPlayerItem_AVPlaybackRestrictions */
}
