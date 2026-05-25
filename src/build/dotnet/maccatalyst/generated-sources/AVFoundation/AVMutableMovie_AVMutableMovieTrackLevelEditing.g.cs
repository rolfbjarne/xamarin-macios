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
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class AVMutableMovie_AVMutableMovieTrackLevelEditing  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVMutableMovie");
		/// <param name="This">The instance on which this method operates.</param><param name="mediaType">To be added.</param><param name="track">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("addMutableTrackWithMediaType:copySettingsFromTrack:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVMutableMovieTrack? AddMutableTrack (this AVMutableMovie This, string mediaType, AVAssetTrack? track, NSDictionary<NSString, NSObject>? options)
		{
			if (mediaType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mediaType));
			var track__handle__ = track.GetHandle ();
			var options__handle__ = options.GetHandle ();
			var nsmediaType = CFString.CreateNative (mediaType);
			AVMutableMovieTrack? ret;
			ret =  Runtime.GetNSObject<AVMutableMovieTrack> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("addMutableTrackWithMediaType:copySettingsFromTrack:options:"), nsmediaType, track__handle__, options__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (track);
			GC.KeepAlive (options);
			CFString.ReleaseNative (nsmediaType);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="existingTracks">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("addMutableTracksCopyingSettingsFromTracks:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVMutableMovieTrack[] AddMutableTracks (this AVMutableMovie This, AVAssetTrack[] existingTracks, NSDictionary<NSString, NSObject>? options)
		{
			if (existingTracks is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (existingTracks));
			var options__handle__ = options.GetHandle ();
			using var nsa_existingTracks = NSArray.FromNSObjects (existingTracks);
			AVMutableMovieTrack[]? ret;
			ret = CFArray.ArrayFromHandle<AVMutableMovieTrack>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("addMutableTracksCopyingSettingsFromTracks:options:"), nsa_existingTracks.Handle, options__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="track">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("mutableTrackCompatibleWithTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVMutableMovieTrack? GetMutableTrack (this AVMutableMovie This, AVAssetTrack track)
		{
			var track__handle__ = track!.GetNonNullHandle (nameof (track));
			AVMutableMovieTrack? ret;
			ret =  Runtime.GetNSObject<AVMutableMovieTrack> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mutableTrackCompatibleWithTrack:"), track__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (track);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="track">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("removeTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoveTrack (this AVMutableMovie This, AVMovieTrack track)
		{
			var track__handle__ = track!.GetNonNullHandle (nameof (track));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("removeTrack:"), track__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (track);
		}
	} /* class AVMutableMovie_AVMutableMovieTrackLevelEditing */
}
