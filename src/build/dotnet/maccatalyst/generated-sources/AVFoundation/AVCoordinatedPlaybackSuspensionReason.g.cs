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
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum AVCoordinatedPlaybackSuspensionReason : int {
		AudioSessionInterrupted = 0,
		StallRecovery = 1,
		PlayingInterstitial = 2,
		CoordinatedPlaybackNotPossible = 3,
		UserActionRequired = 4,
		UserIsChangingCurrentTime = 5,
	}
	/// <summary>Extension methods for the <see cref="global::AVFoundation.AVCoordinatedPlaybackSuspensionReason" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class AVCoordinatedPlaybackSuspensionReasonExtensions {
		static IntPtr[] values = new IntPtr [6];
		[Field ("AVCoordinatedPlaybackSuspensionReasonAudioSessionInterrupted", "AVFoundation")]
		internal unsafe static IntPtr AVCoordinatedPlaybackSuspensionReasonAudioSessionInterrupted {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCoordinatedPlaybackSuspensionReasonAudioSessionInterrupted", storage);
			}
		}
		[Field ("AVCoordinatedPlaybackSuspensionReasonStallRecovery", "AVFoundation")]
		internal unsafe static IntPtr AVCoordinatedPlaybackSuspensionReasonStallRecovery {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCoordinatedPlaybackSuspensionReasonStallRecovery", storage);
			}
		}
		[Field ("AVCoordinatedPlaybackSuspensionReasonPlayingInterstitial", "AVFoundation")]
		internal unsafe static IntPtr AVCoordinatedPlaybackSuspensionReasonPlayingInterstitial {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCoordinatedPlaybackSuspensionReasonPlayingInterstitial", storage);
			}
		}
		[Field ("AVCoordinatedPlaybackSuspensionReasonCoordinatedPlaybackNotPossible", "AVFoundation")]
		internal unsafe static IntPtr AVCoordinatedPlaybackSuspensionReasonCoordinatedPlaybackNotPossible {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCoordinatedPlaybackSuspensionReasonCoordinatedPlaybackNotPossible", storage);
			}
		}
		[Field ("AVCoordinatedPlaybackSuspensionReasonUserActionRequired", "AVFoundation")]
		internal unsafe static IntPtr AVCoordinatedPlaybackSuspensionReasonUserActionRequired {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCoordinatedPlaybackSuspensionReasonUserActionRequired", storage);
			}
		}
		[Field ("AVCoordinatedPlaybackSuspensionReasonUserIsChangingCurrentTime", "AVFoundation")]
		internal unsafe static IntPtr AVCoordinatedPlaybackSuspensionReasonUserIsChangingCurrentTime {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCoordinatedPlaybackSuspensionReasonUserIsChangingCurrentTime", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this AVCoordinatedPlaybackSuspensionReason self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // AVCoordinatedPlaybackSuspensionReason.AudioSessionInterrupted
				ptr = AVCoordinatedPlaybackSuspensionReasonAudioSessionInterrupted;
				break;
			case 1: // AVCoordinatedPlaybackSuspensionReason.StallRecovery
				ptr = AVCoordinatedPlaybackSuspensionReasonStallRecovery;
				break;
			case 2: // AVCoordinatedPlaybackSuspensionReason.PlayingInterstitial
				ptr = AVCoordinatedPlaybackSuspensionReasonPlayingInterstitial;
				break;
			case 3: // AVCoordinatedPlaybackSuspensionReason.CoordinatedPlaybackNotPossible
				ptr = AVCoordinatedPlaybackSuspensionReasonCoordinatedPlaybackNotPossible;
				break;
			case 4: // AVCoordinatedPlaybackSuspensionReason.UserActionRequired
				ptr = AVCoordinatedPlaybackSuspensionReasonUserActionRequired;
				break;
			case 5: // AVCoordinatedPlaybackSuspensionReason.UserIsChangingCurrentTime
				ptr = AVCoordinatedPlaybackSuspensionReasonUserIsChangingCurrentTime;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVCoordinatedPlaybackSuspensionReason" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static AVCoordinatedPlaybackSuspensionReason GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (AVCoordinatedPlaybackSuspensionReasonAudioSessionInterrupted))
				return AVCoordinatedPlaybackSuspensionReason.AudioSessionInterrupted;
			if (constant.IsEqualTo (AVCoordinatedPlaybackSuspensionReasonStallRecovery))
				return AVCoordinatedPlaybackSuspensionReason.StallRecovery;
			if (constant.IsEqualTo (AVCoordinatedPlaybackSuspensionReasonPlayingInterstitial))
				return AVCoordinatedPlaybackSuspensionReason.PlayingInterstitial;
			if (constant.IsEqualTo (AVCoordinatedPlaybackSuspensionReasonCoordinatedPlaybackNotPossible))
				return AVCoordinatedPlaybackSuspensionReason.CoordinatedPlaybackNotPossible;
			if (constant.IsEqualTo (AVCoordinatedPlaybackSuspensionReasonUserActionRequired))
				return AVCoordinatedPlaybackSuspensionReason.UserActionRequired;
			if (constant.IsEqualTo (AVCoordinatedPlaybackSuspensionReasonUserIsChangingCurrentTime))
				return AVCoordinatedPlaybackSuspensionReason.UserIsChangingCurrentTime;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVCoordinatedPlaybackSuspensionReason" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVCoordinatedPlaybackSuspensionReason GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVCoordinatedPlaybackSuspensionReason" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVCoordinatedPlaybackSuspensionReason? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AVFoundation.AVCoordinatedPlaybackSuspensionReason" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this AVCoordinatedPlaybackSuspensionReason[]? values)
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
		internal static AVCoordinatedPlaybackSuspensionReason[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<AVCoordinatedPlaybackSuspensionReason> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
