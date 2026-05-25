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
	/// <summary>Enumerates presets for asset export sessions.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum AVAssetExportSessionPreset : int {
		/// <summary>Indicates a low quality QuickTime file.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		LowQuality = 0,
		/// <summary>Indicates a medium quality QuickTime file.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		MediumQuality = 1,
		/// <summary>Indicates the highest quality QuickTime file.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		HighestQuality = 2,
		/// <summary>Indicates 640x480 output.</summary>
		Preset640x480 = 3,
		/// <summary>Indicates 960x540 output.</summary>
		Preset960x540 = 4,
		/// <summary>Indicates 1280x720 output.</summary>
		Preset1280x720 = 5,
		/// <summary>Indicates 1920x1080 output.</summary>
		Preset1920x1080 = 6,
		/// <summary>Indicates 3840x2160 output.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Preset3840x2160 = 7,
		/// <summary>Indicates an audio-only m4a file with gapless playback data.</summary>
		AppleM4A = 8,
		/// <summary>Indicates a pass-through export, where possible.</summary>
		Passthrough = 9,
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Obsolete ("Use 'AVOutputSettingsPreset.PresetHevc1920x1080' instead if you're looking for the 'AVOutputSettingsPresetHEVC1920x1080' constant, or 'Hevc1920x1080' if you're looking for the 'AVAssetExportPresetHEVC1920x1080 constant.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		PresetHevc1920x1080 = 11,
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Obsolete ("Use 'AVOutputSettingsPreset.PresetHevc3840x2160' instead if you're looking for the 'AVOutputSettingsPresetHEVC3840x2160' constant, or 'Hevc3840x2160' if you're looking for the 'AVAssetExportPresetHEVC3840x2160' constant.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		PresetHevc3840x2160 = 12,
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		HevcHighestQuality = 13,
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Hevc3840x2160 = 14,
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Hevc1920x1080 = 15,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		AppleProRes4444Lpcm = 16,
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		Hevc1920x1080WithAlpha = 17,
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		Hevc3840x2160WithAlpha = 18,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos12.1")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		Hevc7680x4320 = 19,
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		HevcHighestQualityWithAlpha = 20,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		MvHevc960x960 = 21,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		MvHevc1440x1440 = 22,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		Hevc4320x2160 = 23,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		MvHevc4320x4320 = 24,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		MvHevc7680x7680 = 25,
	}
	/// <summary>Extension methods for the <see cref="global::AVFoundation.AVAssetExportSessionPreset" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class AVAssetExportSessionPresetExtensions {
		static IntPtr[] values = new IntPtr [25];
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVAssetExportPresetLowQuality", "AVFoundation")]
		internal unsafe static IntPtr AVAssetExportPresetLowQuality {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAssetExportPresetLowQuality", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVAssetExportPresetMediumQuality", "AVFoundation")]
		internal unsafe static IntPtr AVAssetExportPresetMediumQuality {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAssetExportPresetMediumQuality", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVAssetExportPresetHighestQuality", "AVFoundation")]
		internal unsafe static IntPtr AVAssetExportPresetHighestQuality {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAssetExportPresetHighestQuality", storage);
			}
		}
		[Field ("AVAssetExportPreset640x480", "AVFoundation")]
		internal unsafe static IntPtr AVAssetExportPreset640x480 {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAssetExportPreset640x480", storage);
			}
		}
		[Field ("AVAssetExportPreset960x540", "AVFoundation")]
		internal unsafe static IntPtr AVAssetExportPreset960x540 {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAssetExportPreset960x540", storage);
			}
		}
		[Field ("AVAssetExportPreset1280x720", "AVFoundation")]
		internal unsafe static IntPtr AVAssetExportPreset1280x720 {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAssetExportPreset1280x720", storage);
			}
		}
		[Field ("AVAssetExportPreset1920x1080", "AVFoundation")]
		internal unsafe static IntPtr AVAssetExportPreset1920x1080 {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAssetExportPreset1920x1080", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVAssetExportPreset3840x2160", "AVFoundation")]
		internal unsafe static IntPtr AVAssetExportPreset3840x2160 {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAssetExportPreset3840x2160", storage);
			}
		}
		[Field ("AVAssetExportPresetAppleM4A", "AVFoundation")]
		internal unsafe static IntPtr AVAssetExportPresetAppleM4A {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAssetExportPresetAppleM4A", storage);
			}
		}
		[Field ("AVAssetExportPresetPassthrough", "AVFoundation")]
		internal unsafe static IntPtr AVAssetExportPresetPassthrough {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAssetExportPresetPassthrough", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVOutputSettingsPresetHEVC1920x1080", "AVFoundation")]
		internal unsafe static IntPtr AVOutputSettingsPresetHEVC1920x1080 {
			get {
				fixed (IntPtr *storage = &values [10])
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
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVOutputSettingsPresetHEVC3840x2160", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVAssetExportPresetHEVCHighestQuality", "AVFoundation")]
		internal unsafe static IntPtr AVAssetExportPresetHEVCHighestQuality {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAssetExportPresetHEVCHighestQuality", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVAssetExportPresetHEVC3840x2160", "AVFoundation")]
		internal unsafe static IntPtr AVAssetExportPresetHEVC3840x2160 {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAssetExportPresetHEVC3840x2160", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVAssetExportPresetHEVC1920x1080", "AVFoundation")]
		internal unsafe static IntPtr AVAssetExportPresetHEVC1920x1080 {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAssetExportPresetHEVC1920x1080", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		[Field ("AVAssetExportPresetAppleProRes4444LPCM", "AVFoundation")]
		internal unsafe static IntPtr AVAssetExportPresetAppleProRes4444LPCM {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAssetExportPresetAppleProRes4444LPCM", storage);
			}
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("AVAssetExportPresetHEVC1920x1080WithAlpha", "AVFoundation")]
		internal unsafe static IntPtr AVAssetExportPresetHEVC1920x1080WithAlpha {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAssetExportPresetHEVC1920x1080WithAlpha", storage);
			}
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("AVAssetExportPresetHEVC3840x2160WithAlpha", "AVFoundation")]
		internal unsafe static IntPtr AVAssetExportPresetHEVC3840x2160WithAlpha {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAssetExportPresetHEVC3840x2160WithAlpha", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos12.1")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[Field ("AVAssetExportPresetHEVC7680x4320", "AVFoundation")]
		internal unsafe static IntPtr AVAssetExportPresetHEVC7680x4320 {
			get {
				fixed (IntPtr *storage = &values [18])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAssetExportPresetHEVC7680x4320", storage);
			}
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("AVAssetExportPresetHEVCHighestQualityWithAlpha", "AVFoundation")]
		internal unsafe static IntPtr AVAssetExportPresetHEVCHighestQualityWithAlpha {
			get {
				fixed (IntPtr *storage = &values [19])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAssetExportPresetHEVCHighestQualityWithAlpha", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[Field ("AVAssetExportPresetMVHEVC960x960", "AVFoundation")]
		internal unsafe static IntPtr AVAssetExportPresetMVHEVC960x960 {
			get {
				fixed (IntPtr *storage = &values [20])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAssetExportPresetMVHEVC960x960", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[Field ("AVAssetExportPresetMVHEVC1440x1440", "AVFoundation")]
		internal unsafe static IntPtr AVAssetExportPresetMVHEVC1440x1440 {
			get {
				fixed (IntPtr *storage = &values [21])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAssetExportPresetMVHEVC1440x1440", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("AVAssetExportPresetHEVC4320x2160", "AVFoundation")]
		internal unsafe static IntPtr AVAssetExportPresetHEVC4320x2160 {
			get {
				fixed (IntPtr *storage = &values [22])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAssetExportPresetHEVC4320x2160", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("AVAssetExportPresetMVHEVC4320x4320", "AVFoundation")]
		internal unsafe static IntPtr AVAssetExportPresetMVHEVC4320x4320 {
			get {
				fixed (IntPtr *storage = &values [23])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAssetExportPresetMVHEVC4320x4320", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("AVAssetExportPresetMVHEVC7680x7680", "AVFoundation")]
		internal unsafe static IntPtr AVAssetExportPresetMVHEVC7680x7680 {
			get {
				fixed (IntPtr *storage = &values [24])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAssetExportPresetMVHEVC7680x7680", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this AVAssetExportSessionPreset self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // AVAssetExportSessionPreset.LowQuality
				ptr = AVAssetExportPresetLowQuality;
				break;
			case 1: // AVAssetExportSessionPreset.MediumQuality
				ptr = AVAssetExportPresetMediumQuality;
				break;
			case 2: // AVAssetExportSessionPreset.HighestQuality
				ptr = AVAssetExportPresetHighestQuality;
				break;
			case 3: // AVAssetExportSessionPreset.Preset640x480
				ptr = AVAssetExportPreset640x480;
				break;
			case 4: // AVAssetExportSessionPreset.Preset960x540
				ptr = AVAssetExportPreset960x540;
				break;
			case 5: // AVAssetExportSessionPreset.Preset1280x720
				ptr = AVAssetExportPreset1280x720;
				break;
			case 6: // AVAssetExportSessionPreset.Preset1920x1080
				ptr = AVAssetExportPreset1920x1080;
				break;
			case 7: // AVAssetExportSessionPreset.Preset3840x2160
				ptr = AVAssetExportPreset3840x2160;
				break;
			case 8: // AVAssetExportSessionPreset.AppleM4A
				ptr = AVAssetExportPresetAppleM4A;
				break;
			case 9: // AVAssetExportSessionPreset.Passthrough
				ptr = AVAssetExportPresetPassthrough;
				break;
			case 11: // AVAssetExportSessionPreset.PresetHevc1920x1080
				ptr = AVOutputSettingsPresetHEVC1920x1080;
				break;
			case 12: // AVAssetExportSessionPreset.PresetHevc3840x2160
				ptr = AVOutputSettingsPresetHEVC3840x2160;
				break;
			case 13: // AVAssetExportSessionPreset.HevcHighestQuality
				ptr = AVAssetExportPresetHEVCHighestQuality;
				break;
			case 14: // AVAssetExportSessionPreset.Hevc3840x2160
				ptr = AVAssetExportPresetHEVC3840x2160;
				break;
			case 15: // AVAssetExportSessionPreset.Hevc1920x1080
				ptr = AVAssetExportPresetHEVC1920x1080;
				break;
			case 16: // AVAssetExportSessionPreset.AppleProRes4444Lpcm
				ptr = AVAssetExportPresetAppleProRes4444LPCM;
				break;
			case 17: // AVAssetExportSessionPreset.Hevc1920x1080WithAlpha
				ptr = AVAssetExportPresetHEVC1920x1080WithAlpha;
				break;
			case 18: // AVAssetExportSessionPreset.Hevc3840x2160WithAlpha
				ptr = AVAssetExportPresetHEVC3840x2160WithAlpha;
				break;
			case 19: // AVAssetExportSessionPreset.Hevc7680x4320
				ptr = AVAssetExportPresetHEVC7680x4320;
				break;
			case 20: // AVAssetExportSessionPreset.HevcHighestQualityWithAlpha
				ptr = AVAssetExportPresetHEVCHighestQualityWithAlpha;
				break;
			case 21: // AVAssetExportSessionPreset.MvHevc960x960
				ptr = AVAssetExportPresetMVHEVC960x960;
				break;
			case 22: // AVAssetExportSessionPreset.MvHevc1440x1440
				ptr = AVAssetExportPresetMVHEVC1440x1440;
				break;
			case 23: // AVAssetExportSessionPreset.Hevc4320x2160
				ptr = AVAssetExportPresetHEVC4320x2160;
				break;
			case 24: // AVAssetExportSessionPreset.MvHevc4320x4320
				ptr = AVAssetExportPresetMVHEVC4320x4320;
				break;
			case 25: // AVAssetExportSessionPreset.MvHevc7680x7680
				ptr = AVAssetExportPresetMVHEVC7680x7680;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVAssetExportSessionPreset" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static AVAssetExportSessionPreset GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (AVAssetExportPresetLowQuality))
				return AVAssetExportSessionPreset.LowQuality;
			if (constant.IsEqualTo (AVAssetExportPresetMediumQuality))
				return AVAssetExportSessionPreset.MediumQuality;
			if (constant.IsEqualTo (AVAssetExportPresetHighestQuality))
				return AVAssetExportSessionPreset.HighestQuality;
			if (constant.IsEqualTo (AVAssetExportPreset640x480))
				return AVAssetExportSessionPreset.Preset640x480;
			if (constant.IsEqualTo (AVAssetExportPreset960x540))
				return AVAssetExportSessionPreset.Preset960x540;
			if (constant.IsEqualTo (AVAssetExportPreset1280x720))
				return AVAssetExportSessionPreset.Preset1280x720;
			if (constant.IsEqualTo (AVAssetExportPreset1920x1080))
				return AVAssetExportSessionPreset.Preset1920x1080;
			if (constant.IsEqualTo (AVAssetExportPreset3840x2160))
				return AVAssetExportSessionPreset.Preset3840x2160;
			if (constant.IsEqualTo (AVAssetExportPresetAppleM4A))
				return AVAssetExportSessionPreset.AppleM4A;
			if (constant.IsEqualTo (AVAssetExportPresetPassthrough))
				return AVAssetExportSessionPreset.Passthrough;
			if (constant.IsEqualTo (AVOutputSettingsPresetHEVC1920x1080))
				return AVAssetExportSessionPreset.PresetHevc1920x1080;
			if (constant.IsEqualTo (AVOutputSettingsPresetHEVC3840x2160))
				return AVAssetExportSessionPreset.PresetHevc3840x2160;
			if (constant.IsEqualTo (AVAssetExportPresetHEVCHighestQuality))
				return AVAssetExportSessionPreset.HevcHighestQuality;
			if (constant.IsEqualTo (AVAssetExportPresetHEVC3840x2160))
				return AVAssetExportSessionPreset.Hevc3840x2160;
			if (constant.IsEqualTo (AVAssetExportPresetHEVC1920x1080))
				return AVAssetExportSessionPreset.Hevc1920x1080;
			if (constant.IsEqualTo (AVAssetExportPresetAppleProRes4444LPCM))
				return AVAssetExportSessionPreset.AppleProRes4444Lpcm;
			if (constant.IsEqualTo (AVAssetExportPresetHEVC1920x1080WithAlpha))
				return AVAssetExportSessionPreset.Hevc1920x1080WithAlpha;
			if (constant.IsEqualTo (AVAssetExportPresetHEVC3840x2160WithAlpha))
				return AVAssetExportSessionPreset.Hevc3840x2160WithAlpha;
			if (constant.IsEqualTo (AVAssetExportPresetHEVC7680x4320))
				return AVAssetExportSessionPreset.Hevc7680x4320;
			if (constant.IsEqualTo (AVAssetExportPresetHEVCHighestQualityWithAlpha))
				return AVAssetExportSessionPreset.HevcHighestQualityWithAlpha;
			if (constant.IsEqualTo (AVAssetExportPresetMVHEVC960x960))
				return AVAssetExportSessionPreset.MvHevc960x960;
			if (constant.IsEqualTo (AVAssetExportPresetMVHEVC1440x1440))
				return AVAssetExportSessionPreset.MvHevc1440x1440;
			if (constant.IsEqualTo (AVAssetExportPresetHEVC4320x2160))
				return AVAssetExportSessionPreset.Hevc4320x2160;
			if (constant.IsEqualTo (AVAssetExportPresetMVHEVC4320x4320))
				return AVAssetExportSessionPreset.MvHevc4320x4320;
			if (constant.IsEqualTo (AVAssetExportPresetMVHEVC7680x7680))
				return AVAssetExportSessionPreset.MvHevc7680x7680;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVAssetExportSessionPreset" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVAssetExportSessionPreset GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVAssetExportSessionPreset" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVAssetExportSessionPreset? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AVFoundation.AVAssetExportSessionPreset" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this AVAssetExportSessionPreset[]? values)
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
		internal static AVAssetExportSessionPreset[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<AVAssetExportSessionPreset> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
