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
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	public unsafe static partial class AVAudioSession_AVPlaybackRouteSelecting  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVAudioSession");
		[Export ("prepareRouteSelectionForPlaybackWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PrepareRouteSelectionForPlayback (this global::AVFoundation.AVAudioSession This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V25))]global::System.Action<bool, AVAudioSessionRouteSelection> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V25.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("prepareRouteSelectionForPlaybackWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<PreparingRouteSelectionForPlayback> PrepareRouteSelectionForPlaybackAsync (this global::AVFoundation.AVAudioSession This)
		{
			var tcs = new TaskCompletionSource<PreparingRouteSelectionForPlayback> ();
			This.PrepareRouteSelectionForPlayback((arg1_, arg2_) => {
				tcs.SetResult (new PreparingRouteSelectionForPlayback (arg1_!, arg2_!));
			});
			return tcs.Task;
		}
	} /* class AVAudioSession_AVPlaybackRouteSelecting */
	//
	// Async result classes
	//
	/// <summary>This class holds the return values for an asynchronous operation.</summary>
	public partial class PreparingRouteSelectionForPlayback {
		/// <summary>The result value from the asynchronous operation.</summary>
		public bool Arg1 { get; set; }
		/// <summary>The result value from the asynchronous operation.</summary>
		public AVAudioSessionRouteSelection Arg2 { get; set; }
		partial void Initialize ();
		/// <summary>Creates a new instance of this class.</summary>
		/// <param name="arg1">Result value from an asynchronous operation.</param>
		/// <param name="arg2">Result value from an asynchronous operation.</param>
		public PreparingRouteSelectionForPlayback (bool arg1, AVAudioSessionRouteSelection arg2) {
			this.Arg1 = arg1;
			this.Arg2 = arg2;
			Initialize ();
		}
	}
}
