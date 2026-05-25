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
	[SupportedOSPlatform ("ios13.0")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class AVMovie_AVMovieTrackInspection  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadTrackWithTrackID_CompletionHandler_X = "loadTrackWithTrackID:completionHandler:";
		static readonly NativeHandle selLoadTrackWithTrackID_CompletionHandler_XHandle = Selector.GetHandle ("loadTrackWithTrackID:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadTracksWithMediaCharacteristic_CompletionHandler_X = "loadTracksWithMediaCharacteristic:completionHandler:";
		static readonly NativeHandle selLoadTracksWithMediaCharacteristic_CompletionHandler_XHandle = Selector.GetHandle ("loadTracksWithMediaCharacteristic:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadTracksWithMediaType_CompletionHandler_X = "loadTracksWithMediaType:completionHandler:";
		static readonly NativeHandle selLoadTracksWithMediaType_CompletionHandler_XHandle = Selector.GetHandle ("loadTracksWithMediaType:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTrackWithTrackID_X = "trackWithTrackID:";
		static readonly NativeHandle selTrackWithTrackID_XHandle = Selector.GetHandle ("trackWithTrackID:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTracksWithMediaCharacteristic_X = "tracksWithMediaCharacteristic:";
		static readonly NativeHandle selTracksWithMediaCharacteristic_XHandle = Selector.GetHandle ("tracksWithMediaCharacteristic:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTracksWithMediaType_X = "tracksWithMediaType:";
		static readonly NativeHandle selTracksWithMediaType_XHandle = Selector.GetHandle ("tracksWithMediaType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVMovie");
		/// <param name="This">The instance on which this method operates.</param><param name="trackID">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("trackWithTrackID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVMovieTrack? GetTrack (this AVMovie This, int trackID)
		{
			AVMovieTrack ret;
			ret =  Runtime.GetNSObject<AVMovieTrack> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int (This.Handle, selTrackWithTrackID_XHandle, trackID), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="mediaType">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tracksWithMediaType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVMovieTrack[] GetTracks (this AVMovie This, string mediaType)
		{
			if (mediaType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mediaType));
			var nsmediaType = CFString.CreateNative (mediaType);
			AVMovieTrack[]? ret;
			ret = CFArray.ArrayFromHandle<AVMovieTrack>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, selTracksWithMediaType_XHandle, nsmediaType), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsmediaType);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="mediaType">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVMovieTrack[] GetTracks (this AVMovie This, AVMediaTypes mediaType)
		{
			return This.GetTracks (mediaType.GetConstant ()!);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="mediaCharacteristic">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVMovieTrack[] GetTracks (this AVMovie This, AVMediaCharacteristics mediaCharacteristic)
		{
			return This.GetTracksWithMediaCharacteristic (mediaCharacteristic.GetConstant ()!);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="mediaCharacteristic">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tracksWithMediaCharacteristic:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVMovieTrack[] GetTracksWithMediaCharacteristic (this AVMovie This, string mediaCharacteristic)
		{
			if (mediaCharacteristic is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mediaCharacteristic));
			var nsmediaCharacteristic = CFString.CreateNative (mediaCharacteristic);
			AVMovieTrack[]? ret;
			ret = CFArray.ArrayFromHandle<AVMovieTrack>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, selTracksWithMediaCharacteristic_XHandle, nsmediaCharacteristic), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsmediaCharacteristic);
			return ret!;
		}
		[Export ("loadTrackWithTrackID:completionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LoadTrack (this AVMovie This, int trackId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V15))]global::System.Action<AVMutableCompositionTrack, NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V15.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_int_NativeHandle (This.Handle, selLoadTrackWithTrackID_CompletionHandler_XHandle, trackId, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<AVMutableCompositionTrack> LoadTrackAsync (this AVMovie This, int trackId)
		{
			var tcs = new TaskCompletionSource<AVMutableCompositionTrack> ();
			This.LoadTrack(trackId, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("loadTracksWithMediaCharacteristic:completionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LoadTracksWithMediaCharacteristic (this AVMovie This, string mediaCharacteristic, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V6))]global::System.Action<NSArray<AVMutableCompositionTrack>, NSError> completionHandler)
		{
			if (mediaCharacteristic is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mediaCharacteristic));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsmediaCharacteristic = CFString.CreateNative (mediaCharacteristic);
			using var block_completionHandler = Trampolines.SDActionArity2V6.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selLoadTracksWithMediaCharacteristic_CompletionHandler_XHandle, nsmediaCharacteristic, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsmediaCharacteristic);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<NSArray<AVMutableCompositionTrack>> LoadTracksWithMediaCharacteristicAsync (this AVMovie This, string mediaCharacteristic)
		{
			var tcs = new TaskCompletionSource<NSArray<AVMutableCompositionTrack>> ();
			This.LoadTracksWithMediaCharacteristic(mediaCharacteristic, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("loadTracksWithMediaType:completionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LoadTracksWithMediaType (this AVMovie This, string mediaType, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V6))]global::System.Action<NSArray<AVMutableCompositionTrack>, NSError> completionHandler)
		{
			if (mediaType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mediaType));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsmediaType = CFString.CreateNative (mediaType);
			using var block_completionHandler = Trampolines.SDActionArity2V6.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selLoadTracksWithMediaType_CompletionHandler_XHandle, nsmediaType, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsmediaType);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<NSArray<AVMutableCompositionTrack>> LoadTracksWithMediaTypeAsync (this AVMovie This, string mediaType)
		{
			var tcs = new TaskCompletionSource<NSArray<AVMutableCompositionTrack>> ();
			This.LoadTracksWithMediaType(mediaType, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
	} /* class AVMovie_AVMovieTrackInspection */
}
