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
	public unsafe static partial class AVMutableMovie_AVMutableMovieMovieLevelEditing  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVMutableMovie");
		/// <param name="This">The instance on which this method operates.</param><param name="timeRange">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("insertEmptyTimeRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void InsertEmptyTimeRange (this AVMutableMovie This, global::CoreMedia.CMTimeRange timeRange)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CMTimeRange (This.Handle, Selector.GetHandle ("insertEmptyTimeRange:"), timeRange);
			GC.KeepAlive (This);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="timeRange">To be added.</param><param name="asset">To be added.</param><param name="startTime">To be added.</param><param name="copySampleData">To be added.</param><param name="outError">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("insertTimeRange:ofAsset:atTime:copySampleData:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool InsertTimeRange (this AVMutableMovie This, global::CoreMedia.CMTimeRange timeRange, AVAsset asset, global::CoreMedia.CMTime startTime, bool copySampleData, out NSError? outError)
		{
			var asset__handle__ = asset!.GetNonNullHandle (nameof (asset));
			NativeHandle outErrorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_CMTimeRange_NativeHandle_CMTime_bool_ref_NativeHandle (This.Handle, Selector.GetHandle ("insertTimeRange:ofAsset:atTime:copySampleData:error:"), timeRange, asset__handle__, startTime, copySampleData ? (byte) 1 : (byte) 0, &outErrorValue);
			GC.KeepAlive (This);
			GC.KeepAlive (asset);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="timeRange">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("removeTimeRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoveTimeRange (this AVMutableMovie This, global::CoreMedia.CMTimeRange timeRange)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CMTimeRange (This.Handle, Selector.GetHandle ("removeTimeRange:"), timeRange);
			GC.KeepAlive (This);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="timeRange">To be added.</param><param name="duration">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("scaleTimeRange:toDuration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ScaleTimeRange (this AVMutableMovie This, global::CoreMedia.CMTimeRange timeRange, global::CoreMedia.CMTime duration)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CMTimeRange_CMTime (This.Handle, Selector.GetHandle ("scaleTimeRange:toDuration:"), timeRange, duration);
			GC.KeepAlive (This);
		}
	} /* class AVMutableMovie_AVMutableMovieMovieLevelEditing */
}
