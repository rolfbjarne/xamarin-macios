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
namespace AVFoundation {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class AVMutableComposition_AVMutableCompositionTrackInspection  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVMutableComposition");
		/// <param name="This">The instance on which this method operates.</param><param name="trackID">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("trackWithTrackID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVMutableCompositionTrack? GetTrack (this AVMutableComposition This, int trackID)
		{
			AVMutableCompositionTrack ret;
			ret =  Runtime.GetNSObject<AVMutableCompositionTrack> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int (This.Handle, Selector.GetHandle ("trackWithTrackID:"), trackID), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="mediaType">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tracksWithMediaType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVMutableCompositionTrack[] GetTracks (this AVMutableComposition This, string mediaType)
		{
			if (mediaType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mediaType));
			var nsmediaType = CFString.CreateNative (mediaType);
			AVMutableCompositionTrack[]? ret;
			ret = CFArray.ArrayFromHandle<AVMutableCompositionTrack>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("tracksWithMediaType:"), nsmediaType), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsmediaType);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="mediaType">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVMutableCompositionTrack[] GetTracks (this AVMutableComposition This, AVMediaTypes mediaType)
		{
			return This.GetTracks (mediaType.GetConstant ()!);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="mediaCharacteristic">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVMutableCompositionTrack[] GetTracks (this AVMutableComposition This, AVMediaCharacteristics mediaCharacteristic)
		{
			return This.GetTracksWithMediaCharacteristic (mediaCharacteristic.GetConstant ()!);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="mediaCharacteristic">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tracksWithMediaCharacteristic:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVMutableCompositionTrack[] GetTracksWithMediaCharacteristic (this AVMutableComposition This, string mediaCharacteristic)
		{
			if (mediaCharacteristic is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mediaCharacteristic));
			var nsmediaCharacteristic = CFString.CreateNative (mediaCharacteristic);
			AVMutableCompositionTrack[]? ret;
			ret = CFArray.ArrayFromHandle<AVMutableCompositionTrack>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("tracksWithMediaCharacteristic:"), nsmediaCharacteristic), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsmediaCharacteristic);
			return ret!;
		}
		[Export ("loadTrackWithTrackID:completionHandler:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LoadTrack (this AVMutableComposition This, int trackId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V15))]global::System.Action<AVMutableCompositionTrack, NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V15.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_int_NativeHandle (This.Handle, Selector.GetHandle ("loadTrackWithTrackID:completionHandler:"), trackId, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<AVMutableCompositionTrack> LoadTrackAsync (this AVMutableComposition This, int trackId)
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
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LoadTracksWithMediaCharacteristic (this AVMutableComposition This, string mediaCharacteristic, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V6))]global::System.Action<NSArray<AVMutableCompositionTrack>, NSError> completionHandler)
		{
			if (mediaCharacteristic is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mediaCharacteristic));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsmediaCharacteristic = CFString.CreateNative (mediaCharacteristic);
			using var block_completionHandler = Trampolines.SDActionArity2V6.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("loadTracksWithMediaCharacteristic:completionHandler:"), nsmediaCharacteristic, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsmediaCharacteristic);
		}
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<NSArray<AVMutableCompositionTrack>> LoadTracksWithMediaCharacteristicAsync (this AVMutableComposition This, string mediaCharacteristic)
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
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LoadTracksWithMediaType (this AVMutableComposition This, string mediaType, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V6))]global::System.Action<NSArray<AVMutableCompositionTrack>, NSError> completionHandler)
		{
			if (mediaType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mediaType));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsmediaType = CFString.CreateNative (mediaType);
			using var block_completionHandler = Trampolines.SDActionArity2V6.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("loadTracksWithMediaType:completionHandler:"), nsmediaType, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsmediaType);
		}
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<NSArray<AVMutableCompositionTrack>> LoadTracksWithMediaTypeAsync (this AVMutableComposition This, string mediaType)
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
	} /* class AVMutableComposition_AVMutableCompositionTrackInspection */
}
