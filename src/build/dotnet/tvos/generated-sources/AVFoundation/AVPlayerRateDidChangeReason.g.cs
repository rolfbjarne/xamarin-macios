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
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum AVPlayerRateDidChangeReason : int {
		SetRateCalled = 0,
		SetRateFailed = 1,
		AudioSessionInterrupted = 2,
		AppBackgrounded = 3,
		/// <summary>Indicates that the player automatically switched the playback rate to 1.0 when the playhead reached the live edge during live streaming.</summary>
		[SupportedOSPlatform ("maccatalyst26.4")]
		[SupportedOSPlatform ("tvos26.4")]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("ios26.4")]
		PlayheadReachedLiveEdge = 4,
		/// <summary>Indicates that the player automatically switched the playback rate to 1.0 when reverse playback reached the start of the seekable range.</summary>
		[SupportedOSPlatform ("maccatalyst26.4")]
		[SupportedOSPlatform ("tvos26.4")]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("ios26.4")]
		ReversePlaybackReachedStartOfSeekableRange = 5,
	}
	/// <summary>Extension methods for the <see cref="global::AVFoundation.AVPlayerRateDidChangeReason" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class AVPlayerRateDidChangeReasonExtensions {
		static IntPtr[] values = new IntPtr [6];
		[Field ("AVPlayerRateDidChangeReasonSetRateCalled", "AVFoundation")]
		internal unsafe static IntPtr AVPlayerRateDidChangeReasonSetRateCalled {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVPlayerRateDidChangeReasonSetRateCalled", storage);
			}
		}
		[Field ("AVPlayerRateDidChangeReasonSetRateFailed", "AVFoundation")]
		internal unsafe static IntPtr AVPlayerRateDidChangeReasonSetRateFailed {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVPlayerRateDidChangeReasonSetRateFailed", storage);
			}
		}
		[Field ("AVPlayerRateDidChangeReasonAudioSessionInterrupted", "AVFoundation")]
		internal unsafe static IntPtr AVPlayerRateDidChangeReasonAudioSessionInterrupted {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVPlayerRateDidChangeReasonAudioSessionInterrupted", storage);
			}
		}
		[Field ("AVPlayerRateDidChangeReasonAppBackgrounded", "AVFoundation")]
		internal unsafe static IntPtr AVPlayerRateDidChangeReasonAppBackgrounded {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVPlayerRateDidChangeReasonAppBackgrounded", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.4")]
		[SupportedOSPlatform ("tvos26.4")]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("ios26.4")]
		[Field ("AVPlayerRateDidChangeReasonPlayheadReachedLiveEdge", "AVFoundation")]
		internal unsafe static IntPtr AVPlayerRateDidChangeReasonPlayheadReachedLiveEdge {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVPlayerRateDidChangeReasonPlayheadReachedLiveEdge", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.4")]
		[SupportedOSPlatform ("tvos26.4")]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("ios26.4")]
		[Field ("AVPlayerRateDidChangeReasonReversePlaybackReachedStartOfSeekableRange", "AVFoundation")]
		internal unsafe static IntPtr AVPlayerRateDidChangeReasonReversePlaybackReachedStartOfSeekableRange {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVPlayerRateDidChangeReasonReversePlaybackReachedStartOfSeekableRange", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this AVPlayerRateDidChangeReason self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // AVPlayerRateDidChangeReason.SetRateCalled
				ptr = AVPlayerRateDidChangeReasonSetRateCalled;
				break;
			case 1: // AVPlayerRateDidChangeReason.SetRateFailed
				ptr = AVPlayerRateDidChangeReasonSetRateFailed;
				break;
			case 2: // AVPlayerRateDidChangeReason.AudioSessionInterrupted
				ptr = AVPlayerRateDidChangeReasonAudioSessionInterrupted;
				break;
			case 3: // AVPlayerRateDidChangeReason.AppBackgrounded
				ptr = AVPlayerRateDidChangeReasonAppBackgrounded;
				break;
			case 4: // AVPlayerRateDidChangeReason.PlayheadReachedLiveEdge
				ptr = AVPlayerRateDidChangeReasonPlayheadReachedLiveEdge;
				break;
			case 5: // AVPlayerRateDidChangeReason.ReversePlaybackReachedStartOfSeekableRange
				ptr = AVPlayerRateDidChangeReasonReversePlaybackReachedStartOfSeekableRange;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVPlayerRateDidChangeReason" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static AVPlayerRateDidChangeReason GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (AVPlayerRateDidChangeReasonSetRateCalled))
				return AVPlayerRateDidChangeReason.SetRateCalled;
			if (constant.IsEqualTo (AVPlayerRateDidChangeReasonSetRateFailed))
				return AVPlayerRateDidChangeReason.SetRateFailed;
			if (constant.IsEqualTo (AVPlayerRateDidChangeReasonAudioSessionInterrupted))
				return AVPlayerRateDidChangeReason.AudioSessionInterrupted;
			if (constant.IsEqualTo (AVPlayerRateDidChangeReasonAppBackgrounded))
				return AVPlayerRateDidChangeReason.AppBackgrounded;
			if (constant.IsEqualTo (AVPlayerRateDidChangeReasonPlayheadReachedLiveEdge))
				return AVPlayerRateDidChangeReason.PlayheadReachedLiveEdge;
			if (constant.IsEqualTo (AVPlayerRateDidChangeReasonReversePlaybackReachedStartOfSeekableRange))
				return AVPlayerRateDidChangeReason.ReversePlaybackReachedStartOfSeekableRange;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVPlayerRateDidChangeReason" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVPlayerRateDidChangeReason GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVPlayerRateDidChangeReason" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVPlayerRateDidChangeReason? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AVFoundation.AVPlayerRateDidChangeReason" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this AVPlayerRateDidChangeReason[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSString?> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (value.GetConstant ());
			}
			return rv.ToArray ();
		}
		/// <summary>Converts an array of <see cref="NSString" /> values into an array of their corresponding enum values.</summary>
		/// <param name="values">The array if <see cref="NSString" /> values to convert.</param>
		internal static AVPlayerRateDidChangeReason[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<AVPlayerRateDidChangeReason> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
