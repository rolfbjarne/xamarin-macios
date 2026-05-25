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
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum AVPlayerWaitingReason : int {
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		WaitingToMinimizeStalls = 0,
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		WaitingWhileEvaluatingBufferingRate = 1,
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		WaitingWithNoItemToPlay = 2,
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		WaitingDuringInterstitialEvent = 3,
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		WaitingForCoordinatedPlayback = 4,
	}
	/// <summary>Extension methods for the <see cref="global::AVFoundation.AVPlayerWaitingReason" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class AVPlayerWaitingReasonExtensions {
		static IntPtr[] values = new IntPtr [5];
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVPlayerWaitingToMinimizeStallsReason", "AVFoundation")]
		internal unsafe static IntPtr AVPlayerWaitingToMinimizeStallsReason {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVPlayerWaitingToMinimizeStallsReason", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVPlayerWaitingWhileEvaluatingBufferingRateReason", "AVFoundation")]
		internal unsafe static IntPtr AVPlayerWaitingWhileEvaluatingBufferingRateReason {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVPlayerWaitingWhileEvaluatingBufferingRateReason", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVPlayerWaitingWithNoItemToPlayReason", "AVFoundation")]
		internal unsafe static IntPtr AVPlayerWaitingWithNoItemToPlayReason {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVPlayerWaitingWithNoItemToPlayReason", storage);
			}
		}
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("AVPlayerWaitingDuringInterstitialEventReason", "AVFoundation")]
		internal unsafe static IntPtr AVPlayerWaitingDuringInterstitialEventReason {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVPlayerWaitingDuringInterstitialEventReason", storage);
			}
		}
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("AVPlayerWaitingForCoordinatedPlaybackReason", "AVFoundation")]
		internal unsafe static IntPtr AVPlayerWaitingForCoordinatedPlaybackReason {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVPlayerWaitingForCoordinatedPlaybackReason", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this AVPlayerWaitingReason self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // AVPlayerWaitingReason.WaitingToMinimizeStalls
				ptr = AVPlayerWaitingToMinimizeStallsReason;
				break;
			case 1: // AVPlayerWaitingReason.WaitingWhileEvaluatingBufferingRate
				ptr = AVPlayerWaitingWhileEvaluatingBufferingRateReason;
				break;
			case 2: // AVPlayerWaitingReason.WaitingWithNoItemToPlay
				ptr = AVPlayerWaitingWithNoItemToPlayReason;
				break;
			case 3: // AVPlayerWaitingReason.WaitingDuringInterstitialEvent
				ptr = AVPlayerWaitingDuringInterstitialEventReason;
				break;
			case 4: // AVPlayerWaitingReason.WaitingForCoordinatedPlayback
				ptr = AVPlayerWaitingForCoordinatedPlaybackReason;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVPlayerWaitingReason" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static AVPlayerWaitingReason GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (AVPlayerWaitingToMinimizeStallsReason))
				return AVPlayerWaitingReason.WaitingToMinimizeStalls;
			if (constant.IsEqualTo (AVPlayerWaitingWhileEvaluatingBufferingRateReason))
				return AVPlayerWaitingReason.WaitingWhileEvaluatingBufferingRate;
			if (constant.IsEqualTo (AVPlayerWaitingWithNoItemToPlayReason))
				return AVPlayerWaitingReason.WaitingWithNoItemToPlay;
			if (constant.IsEqualTo (AVPlayerWaitingDuringInterstitialEventReason))
				return AVPlayerWaitingReason.WaitingDuringInterstitialEvent;
			if (constant.IsEqualTo (AVPlayerWaitingForCoordinatedPlaybackReason))
				return AVPlayerWaitingReason.WaitingForCoordinatedPlayback;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVPlayerWaitingReason" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVPlayerWaitingReason GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVPlayerWaitingReason" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVPlayerWaitingReason? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AVFoundation.AVPlayerWaitingReason" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this AVPlayerWaitingReason[]? values)
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
		internal static AVPlayerWaitingReason[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<AVPlayerWaitingReason> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
