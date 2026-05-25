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
namespace CoreHaptics {
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum CHHapticDynamicParameterId : int {
		HapticIntensityControl = 0,
		HapticSharpnessControl = 1,
		HapticAttackTimeControl = 2,
		HapticDecayTimeControl = 3,
		HapticReleaseTimeControl = 4,
		AudioVolumeControl = 5,
		AudioPanControl = 6,
		AudioBrightnessControl = 7,
		AudioPitchControl = 8,
		AudioAttackTimeControl = 9,
		AudioDecayTimeControl = 10,
		AudioReleaseTimeControl = 11,
	}
	/// <summary>Extension methods for the <see cref="global::CoreHaptics.CHHapticDynamicParameterId" /> enumeration.</summary>
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CHHapticDynamicParameterIdExtensions {
		static IntPtr[] values = new IntPtr [12];
		[Field ("CHHapticDynamicParameterIDHapticIntensityControl", "CoreHaptics")]
		internal unsafe static IntPtr CHHapticDynamicParameterIDHapticIntensityControl {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.CoreHaptics.Handle, "CHHapticDynamicParameterIDHapticIntensityControl", storage);
			}
		}
		[Field ("CHHapticDynamicParameterIDHapticSharpnessControl", "CoreHaptics")]
		internal unsafe static IntPtr CHHapticDynamicParameterIDHapticSharpnessControl {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.CoreHaptics.Handle, "CHHapticDynamicParameterIDHapticSharpnessControl", storage);
			}
		}
		[Field ("CHHapticDynamicParameterIDHapticAttackTimeControl", "CoreHaptics")]
		internal unsafe static IntPtr CHHapticDynamicParameterIDHapticAttackTimeControl {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.CoreHaptics.Handle, "CHHapticDynamicParameterIDHapticAttackTimeControl", storage);
			}
		}
		[Field ("CHHapticDynamicParameterIDHapticDecayTimeControl", "CoreHaptics")]
		internal unsafe static IntPtr CHHapticDynamicParameterIDHapticDecayTimeControl {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.CoreHaptics.Handle, "CHHapticDynamicParameterIDHapticDecayTimeControl", storage);
			}
		}
		[Field ("CHHapticDynamicParameterIDHapticReleaseTimeControl", "CoreHaptics")]
		internal unsafe static IntPtr CHHapticDynamicParameterIDHapticReleaseTimeControl {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.CoreHaptics.Handle, "CHHapticDynamicParameterIDHapticReleaseTimeControl", storage);
			}
		}
		[Field ("CHHapticDynamicParameterIDAudioVolumeControl", "CoreHaptics")]
		internal unsafe static IntPtr CHHapticDynamicParameterIDAudioVolumeControl {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.CoreHaptics.Handle, "CHHapticDynamicParameterIDAudioVolumeControl", storage);
			}
		}
		[Field ("CHHapticDynamicParameterIDAudioPanControl", "CoreHaptics")]
		internal unsafe static IntPtr CHHapticDynamicParameterIDAudioPanControl {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.CoreHaptics.Handle, "CHHapticDynamicParameterIDAudioPanControl", storage);
			}
		}
		[Field ("CHHapticDynamicParameterIDAudioBrightnessControl", "CoreHaptics")]
		internal unsafe static IntPtr CHHapticDynamicParameterIDAudioBrightnessControl {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.CoreHaptics.Handle, "CHHapticDynamicParameterIDAudioBrightnessControl", storage);
			}
		}
		[Field ("CHHapticDynamicParameterIDAudioPitchControl", "CoreHaptics")]
		internal unsafe static IntPtr CHHapticDynamicParameterIDAudioPitchControl {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.CoreHaptics.Handle, "CHHapticDynamicParameterIDAudioPitchControl", storage);
			}
		}
		[Field ("CHHapticDynamicParameterIDAudioAttackTimeControl", "CoreHaptics")]
		internal unsafe static IntPtr CHHapticDynamicParameterIDAudioAttackTimeControl {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.CoreHaptics.Handle, "CHHapticDynamicParameterIDAudioAttackTimeControl", storage);
			}
		}
		[Field ("CHHapticDynamicParameterIDAudioDecayTimeControl", "CoreHaptics")]
		internal unsafe static IntPtr CHHapticDynamicParameterIDAudioDecayTimeControl {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.CoreHaptics.Handle, "CHHapticDynamicParameterIDAudioDecayTimeControl", storage);
			}
		}
		[Field ("CHHapticDynamicParameterIDAudioReleaseTimeControl", "CoreHaptics")]
		internal unsafe static IntPtr CHHapticDynamicParameterIDAudioReleaseTimeControl {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.CoreHaptics.Handle, "CHHapticDynamicParameterIDAudioReleaseTimeControl", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CHHapticDynamicParameterId self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // CHHapticDynamicParameterId.HapticIntensityControl
				ptr = CHHapticDynamicParameterIDHapticIntensityControl;
				break;
			case 1: // CHHapticDynamicParameterId.HapticSharpnessControl
				ptr = CHHapticDynamicParameterIDHapticSharpnessControl;
				break;
			case 2: // CHHapticDynamicParameterId.HapticAttackTimeControl
				ptr = CHHapticDynamicParameterIDHapticAttackTimeControl;
				break;
			case 3: // CHHapticDynamicParameterId.HapticDecayTimeControl
				ptr = CHHapticDynamicParameterIDHapticDecayTimeControl;
				break;
			case 4: // CHHapticDynamicParameterId.HapticReleaseTimeControl
				ptr = CHHapticDynamicParameterIDHapticReleaseTimeControl;
				break;
			case 5: // CHHapticDynamicParameterId.AudioVolumeControl
				ptr = CHHapticDynamicParameterIDAudioVolumeControl;
				break;
			case 6: // CHHapticDynamicParameterId.AudioPanControl
				ptr = CHHapticDynamicParameterIDAudioPanControl;
				break;
			case 7: // CHHapticDynamicParameterId.AudioBrightnessControl
				ptr = CHHapticDynamicParameterIDAudioBrightnessControl;
				break;
			case 8: // CHHapticDynamicParameterId.AudioPitchControl
				ptr = CHHapticDynamicParameterIDAudioPitchControl;
				break;
			case 9: // CHHapticDynamicParameterId.AudioAttackTimeControl
				ptr = CHHapticDynamicParameterIDAudioAttackTimeControl;
				break;
			case 10: // CHHapticDynamicParameterId.AudioDecayTimeControl
				ptr = CHHapticDynamicParameterIDAudioDecayTimeControl;
				break;
			case 11: // CHHapticDynamicParameterId.AudioReleaseTimeControl
				ptr = CHHapticDynamicParameterIDAudioReleaseTimeControl;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::CoreHaptics.CHHapticDynamicParameterId" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CHHapticDynamicParameterId GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (CHHapticDynamicParameterIDHapticIntensityControl))
				return CHHapticDynamicParameterId.HapticIntensityControl;
			if (constant.IsEqualTo (CHHapticDynamicParameterIDHapticSharpnessControl))
				return CHHapticDynamicParameterId.HapticSharpnessControl;
			if (constant.IsEqualTo (CHHapticDynamicParameterIDHapticAttackTimeControl))
				return CHHapticDynamicParameterId.HapticAttackTimeControl;
			if (constant.IsEqualTo (CHHapticDynamicParameterIDHapticDecayTimeControl))
				return CHHapticDynamicParameterId.HapticDecayTimeControl;
			if (constant.IsEqualTo (CHHapticDynamicParameterIDHapticReleaseTimeControl))
				return CHHapticDynamicParameterId.HapticReleaseTimeControl;
			if (constant.IsEqualTo (CHHapticDynamicParameterIDAudioVolumeControl))
				return CHHapticDynamicParameterId.AudioVolumeControl;
			if (constant.IsEqualTo (CHHapticDynamicParameterIDAudioPanControl))
				return CHHapticDynamicParameterId.AudioPanControl;
			if (constant.IsEqualTo (CHHapticDynamicParameterIDAudioBrightnessControl))
				return CHHapticDynamicParameterId.AudioBrightnessControl;
			if (constant.IsEqualTo (CHHapticDynamicParameterIDAudioPitchControl))
				return CHHapticDynamicParameterId.AudioPitchControl;
			if (constant.IsEqualTo (CHHapticDynamicParameterIDAudioAttackTimeControl))
				return CHHapticDynamicParameterId.AudioAttackTimeControl;
			if (constant.IsEqualTo (CHHapticDynamicParameterIDAudioDecayTimeControl))
				return CHHapticDynamicParameterId.AudioDecayTimeControl;
			if (constant.IsEqualTo (CHHapticDynamicParameterIDAudioReleaseTimeControl))
				return CHHapticDynamicParameterId.AudioReleaseTimeControl;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::CoreHaptics.CHHapticDynamicParameterId" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CHHapticDynamicParameterId GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::CoreHaptics.CHHapticDynamicParameterId" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CHHapticDynamicParameterId? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::CoreHaptics.CHHapticDynamicParameterId" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CHHapticDynamicParameterId[]? values)
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
		internal static CHHapticDynamicParameterId[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CHHapticDynamicParameterId> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
