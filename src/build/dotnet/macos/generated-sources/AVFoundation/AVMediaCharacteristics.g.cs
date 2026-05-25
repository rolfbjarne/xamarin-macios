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
	/// <summary>Enumerates media characteristics.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum AVMediaCharacteristics : int {
		/// <summary>Indicates visual media.</summary>
		Visual = 0,
		/// <summary>Indicates audible media.</summary>
		Audible = 1,
		/// <summary>Indicates readable media.</summary>
		Legible = 2,
		/// <summary>Indicates frame-based media.</summary>
		FrameBased = 3,
		/// <summary>Indicates wide color content.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		UsesWideGamutColorSpace = 4,
		/// <summary>Indicates primary content.</summary>
		IsMainProgramContent = 5,
		/// <summary>Indicates auxiliary content.</summary>
		IsAuxiliaryContent = 6,
		/// <summary>Indicates forced subtitles, only.</summary>
		ContainsOnlyForcedSubtitles = 7,
		/// <summary>Indicates that spoken dialog is transcribed for accessibility reasons.</summary>
		TranscribesSpokenDialogForAccessibility = 8,
		/// <summary>Indicates music and sound accessibility descriptions.</summary>
		DescribesMusicAndSoundForAccessibility = 9,
		/// <summary>Indicates video accessibility descriptions.</summary>
		DescribesVideoForAccessibility = 10,
		/// <summary>Indicates content prepared to be easy to read in the target locale.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		EasyToRead = 11,
		/// <summary>Indicates language translation content.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		LanguageTranslation = 12,
		/// <summary>Indicates content dubbed for translation purposes.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		DubbedTranslation = 13,
		/// <summary>Indicates voice-over translation</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		VoiceOverTranslation = 14,
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		IsOriginalContent = 15,
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		ContainsHdrVideo = 16,
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		ContainsAlphaChannel = 17,
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		CarriesVideoStereoMetadata = 18,
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		ContainsStereoMultiviewVideo = 19,
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		EnhancesSpeechIntelligibility = 20,
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		IndicatesHorizontalFieldOfView = 21,
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		TactileMinimal = 22,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		IndicatesNonRectilinearProjection = 23,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		MachineGenerated = 24,
	}
	/// <summary>Extension methods for the <see cref="global::AVFoundation.AVMediaCharacteristics" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class AVMediaCharacteristicsExtensions {
		static IntPtr[] values = new IntPtr [25];
		[Field ("AVMediaCharacteristicVisual", "AVFoundation")]
		internal unsafe static IntPtr AVMediaCharacteristicVisual {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaCharacteristicVisual", storage);
			}
		}
		[Field ("AVMediaCharacteristicAudible", "AVFoundation")]
		internal unsafe static IntPtr AVMediaCharacteristicAudible {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaCharacteristicAudible", storage);
			}
		}
		[Field ("AVMediaCharacteristicLegible", "AVFoundation")]
		internal unsafe static IntPtr AVMediaCharacteristicLegible {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaCharacteristicLegible", storage);
			}
		}
		[Field ("AVMediaCharacteristicFrameBased", "AVFoundation")]
		internal unsafe static IntPtr AVMediaCharacteristicFrameBased {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaCharacteristicFrameBased", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVMediaCharacteristicUsesWideGamutColorSpace", "AVFoundation")]
		internal unsafe static IntPtr AVMediaCharacteristicUsesWideGamutColorSpace {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaCharacteristicUsesWideGamutColorSpace", storage);
			}
		}
		[Field ("AVMediaCharacteristicIsMainProgramContent", "AVFoundation")]
		internal unsafe static IntPtr AVMediaCharacteristicIsMainProgramContent {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaCharacteristicIsMainProgramContent", storage);
			}
		}
		[Field ("AVMediaCharacteristicIsAuxiliaryContent", "AVFoundation")]
		internal unsafe static IntPtr AVMediaCharacteristicIsAuxiliaryContent {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaCharacteristicIsAuxiliaryContent", storage);
			}
		}
		[Field ("AVMediaCharacteristicContainsOnlyForcedSubtitles", "AVFoundation")]
		internal unsafe static IntPtr AVMediaCharacteristicContainsOnlyForcedSubtitles {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaCharacteristicContainsOnlyForcedSubtitles", storage);
			}
		}
		[Field ("AVMediaCharacteristicTranscribesSpokenDialogForAccessibility", "AVFoundation")]
		internal unsafe static IntPtr AVMediaCharacteristicTranscribesSpokenDialogForAccessibility {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaCharacteristicTranscribesSpokenDialogForAccessibility", storage);
			}
		}
		[Field ("AVMediaCharacteristicDescribesMusicAndSoundForAccessibility", "AVFoundation")]
		internal unsafe static IntPtr AVMediaCharacteristicDescribesMusicAndSoundForAccessibility {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaCharacteristicDescribesMusicAndSoundForAccessibility", storage);
			}
		}
		[Field ("AVMediaCharacteristicDescribesVideoForAccessibility", "AVFoundation")]
		internal unsafe static IntPtr AVMediaCharacteristicDescribesVideoForAccessibility {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaCharacteristicDescribesVideoForAccessibility", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVMediaCharacteristicEasyToRead", "AVFoundation")]
		internal unsafe static IntPtr AVMediaCharacteristicEasyToRead {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaCharacteristicEasyToRead", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVMediaCharacteristicLanguageTranslation", "AVFoundation")]
		internal unsafe static IntPtr AVMediaCharacteristicLanguageTranslation {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaCharacteristicLanguageTranslation", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVMediaCharacteristicDubbedTranslation", "AVFoundation")]
		internal unsafe static IntPtr AVMediaCharacteristicDubbedTranslation {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaCharacteristicDubbedTranslation", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVMediaCharacteristicVoiceOverTranslation", "AVFoundation")]
		internal unsafe static IntPtr AVMediaCharacteristicVoiceOverTranslation {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaCharacteristicVoiceOverTranslation", storage);
			}
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("AVMediaCharacteristicIsOriginalContent", "AVFoundation")]
		internal unsafe static IntPtr AVMediaCharacteristicIsOriginalContent {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaCharacteristicIsOriginalContent", storage);
			}
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("AVMediaCharacteristicContainsHDRVideo", "AVFoundation")]
		internal unsafe static IntPtr AVMediaCharacteristicContainsHDRVideo {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaCharacteristicContainsHDRVideo", storage);
			}
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("AVMediaCharacteristicContainsAlphaChannel", "AVFoundation")]
		internal unsafe static IntPtr AVMediaCharacteristicContainsAlphaChannel {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaCharacteristicContainsAlphaChannel", storage);
			}
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[Field ("AVMediaCharacteristicCarriesVideoStereoMetadata", "AVFoundation")]
		internal unsafe static IntPtr AVMediaCharacteristicCarriesVideoStereoMetadata {
			get {
				fixed (IntPtr *storage = &values [18])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaCharacteristicCarriesVideoStereoMetadata", storage);
			}
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[Field ("AVMediaCharacteristicContainsStereoMultiviewVideo", "AVFoundation")]
		internal unsafe static IntPtr AVMediaCharacteristicContainsStereoMultiviewVideo {
			get {
				fixed (IntPtr *storage = &values [19])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaCharacteristicContainsStereoMultiviewVideo", storage);
			}
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[Field ("AVMediaCharacteristicEnhancesSpeechIntelligibility", "AVFoundation")]
		internal unsafe static IntPtr AVMediaCharacteristicEnhancesSpeechIntelligibility {
			get {
				fixed (IntPtr *storage = &values [20])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaCharacteristicEnhancesSpeechIntelligibility", storage);
			}
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[Field ("AVMediaCharacteristicIndicatesHorizontalFieldOfView", "AVFoundation")]
		internal unsafe static IntPtr AVMediaCharacteristicIndicatesHorizontalFieldOfView {
			get {
				fixed (IntPtr *storage = &values [21])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaCharacteristicIndicatesHorizontalFieldOfView", storage);
			}
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[Field ("AVMediaCharacteristicTactileMinimal", "AVFoundation")]
		internal unsafe static IntPtr AVMediaCharacteristicTactileMinimal {
			get {
				fixed (IntPtr *storage = &values [22])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaCharacteristicTactileMinimal", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("AVMediaCharacteristicIndicatesNonRectilinearProjection", "AVFoundation")]
		internal unsafe static IntPtr AVMediaCharacteristicIndicatesNonRectilinearProjection {
			get {
				fixed (IntPtr *storage = &values [23])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaCharacteristicIndicatesNonRectilinearProjection", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("AVMediaCharacteristicMachineGenerated", "AVFoundation")]
		internal unsafe static IntPtr AVMediaCharacteristicMachineGenerated {
			get {
				fixed (IntPtr *storage = &values [24])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMediaCharacteristicMachineGenerated", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this AVMediaCharacteristics self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // AVMediaCharacteristics.Visual
				ptr = AVMediaCharacteristicVisual;
				break;
			case 1: // AVMediaCharacteristics.Audible
				ptr = AVMediaCharacteristicAudible;
				break;
			case 2: // AVMediaCharacteristics.Legible
				ptr = AVMediaCharacteristicLegible;
				break;
			case 3: // AVMediaCharacteristics.FrameBased
				ptr = AVMediaCharacteristicFrameBased;
				break;
			case 4: // AVMediaCharacteristics.UsesWideGamutColorSpace
				ptr = AVMediaCharacteristicUsesWideGamutColorSpace;
				break;
			case 5: // AVMediaCharacteristics.IsMainProgramContent
				ptr = AVMediaCharacteristicIsMainProgramContent;
				break;
			case 6: // AVMediaCharacteristics.IsAuxiliaryContent
				ptr = AVMediaCharacteristicIsAuxiliaryContent;
				break;
			case 7: // AVMediaCharacteristics.ContainsOnlyForcedSubtitles
				ptr = AVMediaCharacteristicContainsOnlyForcedSubtitles;
				break;
			case 8: // AVMediaCharacteristics.TranscribesSpokenDialogForAccessibility
				ptr = AVMediaCharacteristicTranscribesSpokenDialogForAccessibility;
				break;
			case 9: // AVMediaCharacteristics.DescribesMusicAndSoundForAccessibility
				ptr = AVMediaCharacteristicDescribesMusicAndSoundForAccessibility;
				break;
			case 10: // AVMediaCharacteristics.DescribesVideoForAccessibility
				ptr = AVMediaCharacteristicDescribesVideoForAccessibility;
				break;
			case 11: // AVMediaCharacteristics.EasyToRead
				ptr = AVMediaCharacteristicEasyToRead;
				break;
			case 12: // AVMediaCharacteristics.LanguageTranslation
				ptr = AVMediaCharacteristicLanguageTranslation;
				break;
			case 13: // AVMediaCharacteristics.DubbedTranslation
				ptr = AVMediaCharacteristicDubbedTranslation;
				break;
			case 14: // AVMediaCharacteristics.VoiceOverTranslation
				ptr = AVMediaCharacteristicVoiceOverTranslation;
				break;
			case 15: // AVMediaCharacteristics.IsOriginalContent
				ptr = AVMediaCharacteristicIsOriginalContent;
				break;
			case 16: // AVMediaCharacteristics.ContainsHdrVideo
				ptr = AVMediaCharacteristicContainsHDRVideo;
				break;
			case 17: // AVMediaCharacteristics.ContainsAlphaChannel
				ptr = AVMediaCharacteristicContainsAlphaChannel;
				break;
			case 18: // AVMediaCharacteristics.CarriesVideoStereoMetadata
				ptr = AVMediaCharacteristicCarriesVideoStereoMetadata;
				break;
			case 19: // AVMediaCharacteristics.ContainsStereoMultiviewVideo
				ptr = AVMediaCharacteristicContainsStereoMultiviewVideo;
				break;
			case 20: // AVMediaCharacteristics.EnhancesSpeechIntelligibility
				ptr = AVMediaCharacteristicEnhancesSpeechIntelligibility;
				break;
			case 21: // AVMediaCharacteristics.IndicatesHorizontalFieldOfView
				ptr = AVMediaCharacteristicIndicatesHorizontalFieldOfView;
				break;
			case 22: // AVMediaCharacteristics.TactileMinimal
				ptr = AVMediaCharacteristicTactileMinimal;
				break;
			case 23: // AVMediaCharacteristics.IndicatesNonRectilinearProjection
				ptr = AVMediaCharacteristicIndicatesNonRectilinearProjection;
				break;
			case 24: // AVMediaCharacteristics.MachineGenerated
				ptr = AVMediaCharacteristicMachineGenerated;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVMediaCharacteristics" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static AVMediaCharacteristics GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (AVMediaCharacteristicVisual))
				return AVMediaCharacteristics.Visual;
			if (constant.IsEqualTo (AVMediaCharacteristicAudible))
				return AVMediaCharacteristics.Audible;
			if (constant.IsEqualTo (AVMediaCharacteristicLegible))
				return AVMediaCharacteristics.Legible;
			if (constant.IsEqualTo (AVMediaCharacteristicFrameBased))
				return AVMediaCharacteristics.FrameBased;
			if (constant.IsEqualTo (AVMediaCharacteristicUsesWideGamutColorSpace))
				return AVMediaCharacteristics.UsesWideGamutColorSpace;
			if (constant.IsEqualTo (AVMediaCharacteristicIsMainProgramContent))
				return AVMediaCharacteristics.IsMainProgramContent;
			if (constant.IsEqualTo (AVMediaCharacteristicIsAuxiliaryContent))
				return AVMediaCharacteristics.IsAuxiliaryContent;
			if (constant.IsEqualTo (AVMediaCharacteristicContainsOnlyForcedSubtitles))
				return AVMediaCharacteristics.ContainsOnlyForcedSubtitles;
			if (constant.IsEqualTo (AVMediaCharacteristicTranscribesSpokenDialogForAccessibility))
				return AVMediaCharacteristics.TranscribesSpokenDialogForAccessibility;
			if (constant.IsEqualTo (AVMediaCharacteristicDescribesMusicAndSoundForAccessibility))
				return AVMediaCharacteristics.DescribesMusicAndSoundForAccessibility;
			if (constant.IsEqualTo (AVMediaCharacteristicDescribesVideoForAccessibility))
				return AVMediaCharacteristics.DescribesVideoForAccessibility;
			if (constant.IsEqualTo (AVMediaCharacteristicEasyToRead))
				return AVMediaCharacteristics.EasyToRead;
			if (constant.IsEqualTo (AVMediaCharacteristicLanguageTranslation))
				return AVMediaCharacteristics.LanguageTranslation;
			if (constant.IsEqualTo (AVMediaCharacteristicDubbedTranslation))
				return AVMediaCharacteristics.DubbedTranslation;
			if (constant.IsEqualTo (AVMediaCharacteristicVoiceOverTranslation))
				return AVMediaCharacteristics.VoiceOverTranslation;
			if (constant.IsEqualTo (AVMediaCharacteristicIsOriginalContent))
				return AVMediaCharacteristics.IsOriginalContent;
			if (constant.IsEqualTo (AVMediaCharacteristicContainsHDRVideo))
				return AVMediaCharacteristics.ContainsHdrVideo;
			if (constant.IsEqualTo (AVMediaCharacteristicContainsAlphaChannel))
				return AVMediaCharacteristics.ContainsAlphaChannel;
			if (constant.IsEqualTo (AVMediaCharacteristicCarriesVideoStereoMetadata))
				return AVMediaCharacteristics.CarriesVideoStereoMetadata;
			if (constant.IsEqualTo (AVMediaCharacteristicContainsStereoMultiviewVideo))
				return AVMediaCharacteristics.ContainsStereoMultiviewVideo;
			if (constant.IsEqualTo (AVMediaCharacteristicEnhancesSpeechIntelligibility))
				return AVMediaCharacteristics.EnhancesSpeechIntelligibility;
			if (constant.IsEqualTo (AVMediaCharacteristicIndicatesHorizontalFieldOfView))
				return AVMediaCharacteristics.IndicatesHorizontalFieldOfView;
			if (constant.IsEqualTo (AVMediaCharacteristicTactileMinimal))
				return AVMediaCharacteristics.TactileMinimal;
			if (constant.IsEqualTo (AVMediaCharacteristicIndicatesNonRectilinearProjection))
				return AVMediaCharacteristics.IndicatesNonRectilinearProjection;
			if (constant.IsEqualTo (AVMediaCharacteristicMachineGenerated))
				return AVMediaCharacteristics.MachineGenerated;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVMediaCharacteristics" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVMediaCharacteristics GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVMediaCharacteristics" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVMediaCharacteristics? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AVFoundation.AVMediaCharacteristics" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this AVMediaCharacteristics[]? values)
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
		internal static AVMediaCharacteristics[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<AVMediaCharacteristics> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
