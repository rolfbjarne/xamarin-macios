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
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class AVMutableMovie_AVMutableMovieTrackInspection  {
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
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVMutableMovie");
		/// <param name="This">The instance on which this method operates.</param><param name="trackID">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("trackWithTrackID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVMutableMovieTrack? GetTrack (this AVMutableMovie This, int trackID)
		{
			AVMutableMovieTrack ret;
			ret =  Runtime.GetNSObject<AVMutableMovieTrack> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int (This.Handle, selTrackWithTrackID_XHandle, trackID), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="mediaType">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tracksWithMediaType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVMutableMovieTrack[] GetTracks (this AVMutableMovie This, string mediaType)
		{
			if (mediaType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mediaType));
			var nsmediaType = CFString.CreateNative (mediaType);
			AVMutableMovieTrack[]? ret;
			ret = CFArray.ArrayFromHandle<AVMutableMovieTrack>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, selTracksWithMediaType_XHandle, nsmediaType), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsmediaType);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="mediaType">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVMutableMovieTrack[] GetTracks (this AVMutableMovie This, AVMediaTypes mediaType)
		{
			return This.GetTracks (mediaType.GetConstant ()!);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="mediaCharacteristic">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVMutableMovieTrack[] GetTracks (this AVMutableMovie This, AVMediaCharacteristics mediaCharacteristic)
		{
			return This.GetTracksWithMediaCharacteristic (mediaCharacteristic.GetConstant ()!);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="mediaCharacteristic">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tracksWithMediaCharacteristic:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVMutableMovieTrack[] GetTracksWithMediaCharacteristic (this AVMutableMovie This, string mediaCharacteristic)
		{
			if (mediaCharacteristic is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mediaCharacteristic));
			var nsmediaCharacteristic = CFString.CreateNative (mediaCharacteristic);
			AVMutableMovieTrack[]? ret;
			ret = CFArray.ArrayFromHandle<AVMutableMovieTrack>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, selTracksWithMediaCharacteristic_XHandle, nsmediaCharacteristic), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsmediaCharacteristic);
			return ret!;
		}
	} /* class AVMutableMovie_AVMutableMovieTrackInspection */
}
