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
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	public enum AVAudioSessionMode : int {
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		Default = 0,
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		VoiceChat = 1,
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		VideoRecording = 2,
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		Measurement = 3,
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		GameChat = 4,
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		MoviePlayback = 5,
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		VideoChat = 6,
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		SpokenAudio = 7,
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		VoicePrompt = 8,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios26.0")]
		ShortFormVideo = 9,
		[SupportedOSPlatform ("maccatalyst26.2")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios26.2")]
		DualRoute = 10,
	}
	/// <summary>Extension methods for the <see cref="global::AVFoundation.AVAudioSessionMode" /> enumeration.</summary>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class AVAudioSessionModeExtensions {
		static IntPtr[] values = new IntPtr [11];
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVAudioSessionModeDefault", "AVFoundation")]
		internal unsafe static IntPtr AVAudioSessionModeDefault {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAudioSessionModeDefault", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVAudioSessionModeVoiceChat", "AVFoundation")]
		internal unsafe static IntPtr AVAudioSessionModeVoiceChat {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAudioSessionModeVoiceChat", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVAudioSessionModeVideoRecording", "AVFoundation")]
		internal unsafe static IntPtr AVAudioSessionModeVideoRecording {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAudioSessionModeVideoRecording", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVAudioSessionModeMeasurement", "AVFoundation")]
		internal unsafe static IntPtr AVAudioSessionModeMeasurement {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAudioSessionModeMeasurement", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVAudioSessionModeGameChat", "AVFoundation")]
		internal unsafe static IntPtr AVAudioSessionModeGameChat {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAudioSessionModeGameChat", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVAudioSessionModeMoviePlayback", "AVFoundation")]
		internal unsafe static IntPtr AVAudioSessionModeMoviePlayback {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAudioSessionModeMoviePlayback", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVAudioSessionModeVideoChat", "AVFoundation")]
		internal unsafe static IntPtr AVAudioSessionModeVideoChat {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAudioSessionModeVideoChat", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVAudioSessionModeSpokenAudio", "AVFoundation")]
		internal unsafe static IntPtr AVAudioSessionModeSpokenAudio {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAudioSessionModeSpokenAudio", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVAudioSessionModeVoicePrompt", "AVFoundation")]
		internal unsafe static IntPtr AVAudioSessionModeVoicePrompt {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAudioSessionModeVoicePrompt", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("AVAudioSessionModeShortFormVideo", "AVFoundation")]
		internal unsafe static IntPtr AVAudioSessionModeShortFormVideo {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAudioSessionModeShortFormVideo", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.2")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios26.2")]
		[Field ("AVAudioSessionModeDualRoute", "AVFoundation")]
		internal unsafe static IntPtr AVAudioSessionModeDualRoute {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAudioSessionModeDualRoute", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this AVAudioSessionMode self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // AVAudioSessionMode.Default
				ptr = AVAudioSessionModeDefault;
				break;
			case 1: // AVAudioSessionMode.VoiceChat
				ptr = AVAudioSessionModeVoiceChat;
				break;
			case 2: // AVAudioSessionMode.VideoRecording
				ptr = AVAudioSessionModeVideoRecording;
				break;
			case 3: // AVAudioSessionMode.Measurement
				ptr = AVAudioSessionModeMeasurement;
				break;
			case 4: // AVAudioSessionMode.GameChat
				ptr = AVAudioSessionModeGameChat;
				break;
			case 5: // AVAudioSessionMode.MoviePlayback
				ptr = AVAudioSessionModeMoviePlayback;
				break;
			case 6: // AVAudioSessionMode.VideoChat
				ptr = AVAudioSessionModeVideoChat;
				break;
			case 7: // AVAudioSessionMode.SpokenAudio
				ptr = AVAudioSessionModeSpokenAudio;
				break;
			case 8: // AVAudioSessionMode.VoicePrompt
				ptr = AVAudioSessionModeVoicePrompt;
				break;
			case 9: // AVAudioSessionMode.ShortFormVideo
				ptr = AVAudioSessionModeShortFormVideo;
				break;
			case 10: // AVAudioSessionMode.DualRoute
				ptr = AVAudioSessionModeDualRoute;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVAudioSessionMode" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static AVAudioSessionMode GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (AVAudioSessionModeDefault))
				return AVAudioSessionMode.Default;
			if (constant.IsEqualTo (AVAudioSessionModeVoiceChat))
				return AVAudioSessionMode.VoiceChat;
			if (constant.IsEqualTo (AVAudioSessionModeVideoRecording))
				return AVAudioSessionMode.VideoRecording;
			if (constant.IsEqualTo (AVAudioSessionModeMeasurement))
				return AVAudioSessionMode.Measurement;
			if (constant.IsEqualTo (AVAudioSessionModeGameChat))
				return AVAudioSessionMode.GameChat;
			if (constant.IsEqualTo (AVAudioSessionModeMoviePlayback))
				return AVAudioSessionMode.MoviePlayback;
			if (constant.IsEqualTo (AVAudioSessionModeVideoChat))
				return AVAudioSessionMode.VideoChat;
			if (constant.IsEqualTo (AVAudioSessionModeSpokenAudio))
				return AVAudioSessionMode.SpokenAudio;
			if (constant.IsEqualTo (AVAudioSessionModeVoicePrompt))
				return AVAudioSessionMode.VoicePrompt;
			if (constant.IsEqualTo (AVAudioSessionModeShortFormVideo))
				return AVAudioSessionMode.ShortFormVideo;
			if (constant.IsEqualTo (AVAudioSessionModeDualRoute))
				return AVAudioSessionMode.DualRoute;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVAudioSessionMode" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVAudioSessionMode GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVAudioSessionMode" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVAudioSessionMode? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AVFoundation.AVAudioSessionMode" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this AVAudioSessionMode[]? values)
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
		internal static AVAudioSessionMode[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<AVAudioSessionMode> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
