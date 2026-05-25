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
	public enum AVOutputSettingsPreset : int {
		Preset640x480 = 0,
		Preset960x540 = 1,
		Preset1280x720 = 2,
		Preset1920x1080 = 3,
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Preset3840x2160 = 4,
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		PresetHevc1920x1080 = 11,
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		PresetHevc3840x2160 = 12,
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		PresetHevc1920x1080WithAlpha = 13,
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		PresetHevc3840x2160WithAlpha = 14,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos12.1")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		PresetHevc7680x4320 = 15,
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		PresetMvHevc960x960 = 16,
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		PresetMvHevc1440x1440 = 17,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		Hevc4320x2160 = 18,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		MvHevc4320x4320 = 19,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		MvHevc7680x7680 = 20,
	}
	/// <summary>Extension methods for the <see cref="global::AVFoundation.AVOutputSettingsPreset" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class AVOutputSettingsPresetExtensions {
		static IntPtr[] values = new IntPtr [15];
		[Field ("AVOutputSettingsPreset640x480", "AVFoundation")]
		internal unsafe static IntPtr AVOutputSettingsPreset640x480 {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVOutputSettingsPreset640x480", storage);
			}
		}
		[Field ("AVOutputSettingsPreset960x540", "AVFoundation")]
		internal unsafe static IntPtr AVOutputSettingsPreset960x540 {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVOutputSettingsPreset960x540", storage);
			}
		}
		[Field ("AVOutputSettingsPreset1280x720", "AVFoundation")]
		internal unsafe static IntPtr AVOutputSettingsPreset1280x720 {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVOutputSettingsPreset1280x720", storage);
			}
		}
		[Field ("AVOutputSettingsPreset1920x1080", "AVFoundation")]
		internal unsafe static IntPtr AVOutputSettingsPreset1920x1080 {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVOutputSettingsPreset1920x1080", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVOutputSettingsPreset3840x2160", "AVFoundation")]
		internal unsafe static IntPtr AVOutputSettingsPreset3840x2160 {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVOutputSettingsPreset3840x2160", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVOutputSettingsPresetHEVC1920x1080", "AVFoundation")]
		internal unsafe static IntPtr AVOutputSettingsPresetHEVC1920x1080 {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVOutputSettingsPresetHEVC1920x1080", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVOutputSettingsPresetHEVC3840x2160", "AVFoundation")]
		internal unsafe static IntPtr AVOutputSettingsPresetHEVC3840x2160 {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVOutputSettingsPresetHEVC3840x2160", storage);
			}
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("AVOutputSettingsPresetHEVC1920x1080WithAlpha", "AVFoundation")]
		internal unsafe static IntPtr AVOutputSettingsPresetHEVC1920x1080WithAlpha {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVOutputSettingsPresetHEVC1920x1080WithAlpha", storage);
			}
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("AVOutputSettingsPresetHEVC3840x2160WithAlpha", "AVFoundation")]
		internal unsafe static IntPtr AVOutputSettingsPresetHEVC3840x2160WithAlpha {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVOutputSettingsPresetHEVC3840x2160WithAlpha", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos12.1")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[Field ("AVOutputSettingsPresetHEVC7680x4320", "AVFoundation")]
		internal unsafe static IntPtr AVOutputSettingsPresetHEVC7680x4320 {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVOutputSettingsPresetHEVC7680x4320", storage);
			}
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[Field ("AVOutputSettingsPresetMVHEVC960x960", "AVFoundation")]
		internal unsafe static IntPtr AVOutputSettingsPresetMVHEVC960x960 {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVOutputSettingsPresetMVHEVC960x960", storage);
			}
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[Field ("AVOutputSettingsPresetMVHEVC1440x1440", "AVFoundation")]
		internal unsafe static IntPtr AVOutputSettingsPresetMVHEVC1440x1440 {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVOutputSettingsPresetMVHEVC1440x1440", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("AVOutputSettingsPresetHEVC4320x2160", "AVFoundation")]
		internal unsafe static IntPtr AVOutputSettingsPresetHEVC4320x2160 {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVOutputSettingsPresetHEVC4320x2160", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("AVOutputSettingsPresetMVHEVC4320x4320", "AVFoundation")]
		internal unsafe static IntPtr AVOutputSettingsPresetMVHEVC4320x4320 {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVOutputSettingsPresetMVHEVC4320x4320", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("AVOutputSettingsPresetMVHEVC7680x7680", "AVFoundation")]
		internal unsafe static IntPtr AVOutputSettingsPresetMVHEVC7680x7680 {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVOutputSettingsPresetMVHEVC7680x7680", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this AVOutputSettingsPreset self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // AVOutputSettingsPreset.Preset640x480
				ptr = AVOutputSettingsPreset640x480;
				break;
			case 1: // AVOutputSettingsPreset.Preset960x540
				ptr = AVOutputSettingsPreset960x540;
				break;
			case 2: // AVOutputSettingsPreset.Preset1280x720
				ptr = AVOutputSettingsPreset1280x720;
				break;
			case 3: // AVOutputSettingsPreset.Preset1920x1080
				ptr = AVOutputSettingsPreset1920x1080;
				break;
			case 4: // AVOutputSettingsPreset.Preset3840x2160
				ptr = AVOutputSettingsPreset3840x2160;
				break;
			case 11: // AVOutputSettingsPreset.PresetHevc1920x1080
				ptr = AVOutputSettingsPresetHEVC1920x1080;
				break;
			case 12: // AVOutputSettingsPreset.PresetHevc3840x2160
				ptr = AVOutputSettingsPresetHEVC3840x2160;
				break;
			case 13: // AVOutputSettingsPreset.PresetHevc1920x1080WithAlpha
				ptr = AVOutputSettingsPresetHEVC1920x1080WithAlpha;
				break;
			case 14: // AVOutputSettingsPreset.PresetHevc3840x2160WithAlpha
				ptr = AVOutputSettingsPresetHEVC3840x2160WithAlpha;
				break;
			case 15: // AVOutputSettingsPreset.PresetHevc7680x4320
				ptr = AVOutputSettingsPresetHEVC7680x4320;
				break;
			case 16: // AVOutputSettingsPreset.PresetMvHevc960x960
				ptr = AVOutputSettingsPresetMVHEVC960x960;
				break;
			case 17: // AVOutputSettingsPreset.PresetMvHevc1440x1440
				ptr = AVOutputSettingsPresetMVHEVC1440x1440;
				break;
			case 18: // AVOutputSettingsPreset.Hevc4320x2160
				ptr = AVOutputSettingsPresetHEVC4320x2160;
				break;
			case 19: // AVOutputSettingsPreset.MvHevc4320x4320
				ptr = AVOutputSettingsPresetMVHEVC4320x4320;
				break;
			case 20: // AVOutputSettingsPreset.MvHevc7680x7680
				ptr = AVOutputSettingsPresetMVHEVC7680x7680;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVOutputSettingsPreset" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static AVOutputSettingsPreset GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (AVOutputSettingsPreset640x480))
				return AVOutputSettingsPreset.Preset640x480;
			if (constant.IsEqualTo (AVOutputSettingsPreset960x540))
				return AVOutputSettingsPreset.Preset960x540;
			if (constant.IsEqualTo (AVOutputSettingsPreset1280x720))
				return AVOutputSettingsPreset.Preset1280x720;
			if (constant.IsEqualTo (AVOutputSettingsPreset1920x1080))
				return AVOutputSettingsPreset.Preset1920x1080;
			if (constant.IsEqualTo (AVOutputSettingsPreset3840x2160))
				return AVOutputSettingsPreset.Preset3840x2160;
			if (constant.IsEqualTo (AVOutputSettingsPresetHEVC1920x1080))
				return AVOutputSettingsPreset.PresetHevc1920x1080;
			if (constant.IsEqualTo (AVOutputSettingsPresetHEVC3840x2160))
				return AVOutputSettingsPreset.PresetHevc3840x2160;
			if (constant.IsEqualTo (AVOutputSettingsPresetHEVC1920x1080WithAlpha))
				return AVOutputSettingsPreset.PresetHevc1920x1080WithAlpha;
			if (constant.IsEqualTo (AVOutputSettingsPresetHEVC3840x2160WithAlpha))
				return AVOutputSettingsPreset.PresetHevc3840x2160WithAlpha;
			if (constant.IsEqualTo (AVOutputSettingsPresetHEVC7680x4320))
				return AVOutputSettingsPreset.PresetHevc7680x4320;
			if (constant.IsEqualTo (AVOutputSettingsPresetMVHEVC960x960))
				return AVOutputSettingsPreset.PresetMvHevc960x960;
			if (constant.IsEqualTo (AVOutputSettingsPresetMVHEVC1440x1440))
				return AVOutputSettingsPreset.PresetMvHevc1440x1440;
			if (constant.IsEqualTo (AVOutputSettingsPresetHEVC4320x2160))
				return AVOutputSettingsPreset.Hevc4320x2160;
			if (constant.IsEqualTo (AVOutputSettingsPresetMVHEVC4320x4320))
				return AVOutputSettingsPreset.MvHevc4320x4320;
			if (constant.IsEqualTo (AVOutputSettingsPresetMVHEVC7680x7680))
				return AVOutputSettingsPreset.MvHevc7680x7680;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVOutputSettingsPreset" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVOutputSettingsPreset GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVOutputSettingsPreset" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVOutputSettingsPreset? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AVFoundation.AVOutputSettingsPreset" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this AVOutputSettingsPreset[]? values)
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
		internal static AVOutputSettingsPreset[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<AVOutputSettingsPreset> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
