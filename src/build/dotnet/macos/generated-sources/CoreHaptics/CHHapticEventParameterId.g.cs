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
namespace CoreHaptics {
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum CHHapticEventParameterId : int {
		HapticIntensity = 0,
		HapticSharpness = 1,
		AttackTime = 2,
		DecayTime = 3,
		ReleaseTime = 4,
		Sustained = 5,
		AudioVolume = 6,
		AudioPitch = 7,
		AudioPan = 8,
		AudioBrightness = 9,
	}
	/// <summary>Extension methods for the <see cref="global::CoreHaptics.CHHapticEventParameterId" /> enumeration.</summary>
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CHHapticEventParameterIdExtensions {
		static IntPtr[] values = new IntPtr [10];
		[Field ("CHHapticEventParameterIDHapticIntensity", "CoreHaptics")]
		internal unsafe static IntPtr CHHapticEventParameterIDHapticIntensity {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.CoreHaptics.Handle, "CHHapticEventParameterIDHapticIntensity", storage);
			}
		}
		[Field ("CHHapticEventParameterIDHapticSharpness", "CoreHaptics")]
		internal unsafe static IntPtr CHHapticEventParameterIDHapticSharpness {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.CoreHaptics.Handle, "CHHapticEventParameterIDHapticSharpness", storage);
			}
		}
		[Field ("CHHapticEventParameterIDAttackTime", "CoreHaptics")]
		internal unsafe static IntPtr CHHapticEventParameterIDAttackTime {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.CoreHaptics.Handle, "CHHapticEventParameterIDAttackTime", storage);
			}
		}
		[Field ("CHHapticEventParameterIDDecayTime", "CoreHaptics")]
		internal unsafe static IntPtr CHHapticEventParameterIDDecayTime {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.CoreHaptics.Handle, "CHHapticEventParameterIDDecayTime", storage);
			}
		}
		[Field ("CHHapticEventParameterIDReleaseTime", "CoreHaptics")]
		internal unsafe static IntPtr CHHapticEventParameterIDReleaseTime {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.CoreHaptics.Handle, "CHHapticEventParameterIDReleaseTime", storage);
			}
		}
		[Field ("CHHapticEventParameterIDSustained", "CoreHaptics")]
		internal unsafe static IntPtr CHHapticEventParameterIDSustained {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.CoreHaptics.Handle, "CHHapticEventParameterIDSustained", storage);
			}
		}
		[Field ("CHHapticEventParameterIDAudioVolume", "CoreHaptics")]
		internal unsafe static IntPtr CHHapticEventParameterIDAudioVolume {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.CoreHaptics.Handle, "CHHapticEventParameterIDAudioVolume", storage);
			}
		}
		[Field ("CHHapticEventParameterIDAudioPitch", "CoreHaptics")]
		internal unsafe static IntPtr CHHapticEventParameterIDAudioPitch {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.CoreHaptics.Handle, "CHHapticEventParameterIDAudioPitch", storage);
			}
		}
		[Field ("CHHapticEventParameterIDAudioPan", "CoreHaptics")]
		internal unsafe static IntPtr CHHapticEventParameterIDAudioPan {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.CoreHaptics.Handle, "CHHapticEventParameterIDAudioPan", storage);
			}
		}
		[Field ("CHHapticEventParameterIDAudioBrightness", "CoreHaptics")]
		internal unsafe static IntPtr CHHapticEventParameterIDAudioBrightness {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.CoreHaptics.Handle, "CHHapticEventParameterIDAudioBrightness", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CHHapticEventParameterId self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // CHHapticEventParameterId.HapticIntensity
				ptr = CHHapticEventParameterIDHapticIntensity;
				break;
			case 1: // CHHapticEventParameterId.HapticSharpness
				ptr = CHHapticEventParameterIDHapticSharpness;
				break;
			case 2: // CHHapticEventParameterId.AttackTime
				ptr = CHHapticEventParameterIDAttackTime;
				break;
			case 3: // CHHapticEventParameterId.DecayTime
				ptr = CHHapticEventParameterIDDecayTime;
				break;
			case 4: // CHHapticEventParameterId.ReleaseTime
				ptr = CHHapticEventParameterIDReleaseTime;
				break;
			case 5: // CHHapticEventParameterId.Sustained
				ptr = CHHapticEventParameterIDSustained;
				break;
			case 6: // CHHapticEventParameterId.AudioVolume
				ptr = CHHapticEventParameterIDAudioVolume;
				break;
			case 7: // CHHapticEventParameterId.AudioPitch
				ptr = CHHapticEventParameterIDAudioPitch;
				break;
			case 8: // CHHapticEventParameterId.AudioPan
				ptr = CHHapticEventParameterIDAudioPan;
				break;
			case 9: // CHHapticEventParameterId.AudioBrightness
				ptr = CHHapticEventParameterIDAudioBrightness;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::CoreHaptics.CHHapticEventParameterId" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CHHapticEventParameterId GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (CHHapticEventParameterIDHapticIntensity))
				return CHHapticEventParameterId.HapticIntensity;
			if (constant.IsEqualTo (CHHapticEventParameterIDHapticSharpness))
				return CHHapticEventParameterId.HapticSharpness;
			if (constant.IsEqualTo (CHHapticEventParameterIDAttackTime))
				return CHHapticEventParameterId.AttackTime;
			if (constant.IsEqualTo (CHHapticEventParameterIDDecayTime))
				return CHHapticEventParameterId.DecayTime;
			if (constant.IsEqualTo (CHHapticEventParameterIDReleaseTime))
				return CHHapticEventParameterId.ReleaseTime;
			if (constant.IsEqualTo (CHHapticEventParameterIDSustained))
				return CHHapticEventParameterId.Sustained;
			if (constant.IsEqualTo (CHHapticEventParameterIDAudioVolume))
				return CHHapticEventParameterId.AudioVolume;
			if (constant.IsEqualTo (CHHapticEventParameterIDAudioPitch))
				return CHHapticEventParameterId.AudioPitch;
			if (constant.IsEqualTo (CHHapticEventParameterIDAudioPan))
				return CHHapticEventParameterId.AudioPan;
			if (constant.IsEqualTo (CHHapticEventParameterIDAudioBrightness))
				return CHHapticEventParameterId.AudioBrightness;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::CoreHaptics.CHHapticEventParameterId" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CHHapticEventParameterId GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::CoreHaptics.CHHapticEventParameterId" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CHHapticEventParameterId? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::CoreHaptics.CHHapticEventParameterId" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CHHapticEventParameterId[]? values)
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
		internal static CHHapticEventParameterId[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CHHapticEventParameterId> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
