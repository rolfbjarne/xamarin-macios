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
namespace AVFoundation {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class AVFragmentedAsset_AVFragmentedAssetTrackInspection  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVFragmentedAsset");
		/// <param name="This">The instance on which this method operates.</param><param name="trackID">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("trackWithTrackID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVFragmentedAssetTrack? GetTrack (this AVFragmentedAsset This, int trackID)
		{
			AVFragmentedAssetTrack ret;
			ret =  Runtime.GetNSObject<AVFragmentedAssetTrack> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int (This.Handle, Selector.GetHandle ("trackWithTrackID:"), trackID), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="mediaType">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tracksWithMediaType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVFragmentedAssetTrack[] GetTracks (this AVFragmentedAsset This, string mediaType)
		{
			if (mediaType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mediaType));
			var nsmediaType = CFString.CreateNative (mediaType);
			AVFragmentedAssetTrack[]? ret;
			ret = CFArray.ArrayFromHandle<AVFragmentedAssetTrack>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("tracksWithMediaType:"), nsmediaType), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsmediaType);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="mediaType">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVFragmentedAssetTrack[] GetTracks (this AVFragmentedAsset This, AVMediaTypes mediaType)
		{
			return This.GetTracks (mediaType.GetConstant ()!);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="mediaCharacteristic">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVFragmentedAssetTrack[] GetTracks (this AVFragmentedAsset This, AVMediaCharacteristics mediaCharacteristic)
		{
			return This.GetTracksWithMediaCharacteristic (mediaCharacteristic.GetConstant ()!);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="mediaCharacteristic">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tracksWithMediaCharacteristic:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVFragmentedAssetTrack[] GetTracksWithMediaCharacteristic (this AVFragmentedAsset This, string mediaCharacteristic)
		{
			if (mediaCharacteristic is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mediaCharacteristic));
			var nsmediaCharacteristic = CFString.CreateNative (mediaCharacteristic);
			AVFragmentedAssetTrack[]? ret;
			ret = CFArray.ArrayFromHandle<AVFragmentedAssetTrack>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("tracksWithMediaCharacteristic:"), nsmediaCharacteristic), false)!;
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
		public unsafe static void LoadTrack (this AVFragmentedAsset This, int trackId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V20))]global::System.Action<AVFragmentedAssetTrack, NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V20.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_int_NativeHandle (This.Handle, Selector.GetHandle ("loadTrackWithTrackID:completionHandler:"), trackId, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<AVFragmentedAssetTrack> LoadTrackAsync (this AVFragmentedAsset This, int trackId)
		{
			var tcs = new TaskCompletionSource<AVFragmentedAssetTrack> ();
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
		public unsafe static void LoadTracksWithMediaCharacteristic (this AVFragmentedAsset This, string mediaCharacteristic, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V21))]global::System.Action<NSArray<AVFragmentedAssetTrack>, NSError> completionHandler)
		{
			if (mediaCharacteristic is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mediaCharacteristic));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsmediaCharacteristic = CFString.CreateNative (mediaCharacteristic);
			using var block_completionHandler = Trampolines.SDActionArity2V21.CreateBlock (completionHandler);
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
		public unsafe static Task<NSArray<AVFragmentedAssetTrack>> LoadTracksWithMediaCharacteristicAsync (this AVFragmentedAsset This, string mediaCharacteristic)
		{
			var tcs = new TaskCompletionSource<NSArray<AVFragmentedAssetTrack>> ();
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
		public unsafe static void LoadTracksWithMediaType (this AVFragmentedAsset This, string mediaType, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V21))]global::System.Action<NSArray<AVFragmentedAssetTrack>, NSError> completionHandler)
		{
			if (mediaType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mediaType));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsmediaType = CFString.CreateNative (mediaType);
			using var block_completionHandler = Trampolines.SDActionArity2V21.CreateBlock (completionHandler);
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
		public unsafe static Task<NSArray<AVFragmentedAssetTrack>> LoadTracksWithMediaTypeAsync (this AVFragmentedAsset This, string mediaType)
		{
			var tcs = new TaskCompletionSource<NSArray<AVFragmentedAssetTrack>> ();
			This.LoadTracksWithMediaType(mediaType, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
	} /* class AVFragmentedAsset_AVFragmentedAssetTrackInspection */
}
