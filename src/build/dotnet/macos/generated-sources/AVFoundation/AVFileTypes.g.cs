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
	/// <summary>Enumerates universal type information for AVFoundation file types.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum AVFileTypes : int {
		/// <summary>Indicates the Apple QuickTime Movie format</summary>
		QuickTimeMovie = 0,
		/// <summary>Indicates the MPEG-4 format.</summary>
		Mpeg4 = 1,
		/// <summary>Indicates the iTunes video format.</summary>
		AppleM4V = 2,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		ThreeGpp = 3,
		/// <summary>Indicates the Apple m4a format.</summary>
		AppleM4a = 4,
		/// <summary>Indicates the CoreAudio format.</summary>
		CoreAudioFormat = 5,
		/// <summary>Indicates the WAVE format.</summary>
		Wave = 6,
		/// <summary>Indicates the AIFF format.</summary>
		Aiff = 7,
		/// <summary>Indicates the AIFC format.</summary>
		Aifc = 8,
		/// <summary>Indicates the AMR format.</summary>
		Amr = 9,
		/// <summary>Indicates the 3GPP2 format.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		ThreeGpp2 = 10,
		/// <summary>Indicates the MPEG layer 3 format.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		MpegLayer3 = 11,
		/// <summary>Indicates the Sun/Next format.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		SunAU = 12,
		/// <summary>Indicates the AC-3 format.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		AC3 = 13,
		/// <summary>Indicates the Dolby Digital Plus format.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		EnhancedAC3 = 14,
		/// <summary>Indicates the JPEG format.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Jpeg = 15,
		/// <summary>Indicates the Digital Negative format.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Dng = 16,
		/// <summary>Indicates the High Efficiency Image Format</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Heic = 17,
		/// <summary>Indicates the AVC-Intra format</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Avci = 18,
		/// <summary>Indicates the High Efficiency Image File format.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Heif = 19,
		/// <summary>Indicates the TIFF format.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Tiff = 20,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		AppleiTT = 21,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		Scc = 22,
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		Ahap = 23,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		Dicom = 24,
		[SupportedOSPlatform ("maccatalyst26.1")]
		[SupportedOSPlatform ("tvos26.1")]
		[SupportedOSPlatform ("macos26.1")]
		[SupportedOSPlatform ("ios26.1")]
		QuickTimeAudio = 25,
	}
	/// <summary>Extension methods for the <see cref="global::AVFoundation.AVFileTypes" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class AVFileTypesExtensions {
		static IntPtr[] values = new IntPtr [26];
		[Field ("AVFileTypeQuickTimeMovie", "AVFoundation")]
		internal unsafe static IntPtr AVFileTypeQuickTimeMovie {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVFileTypeQuickTimeMovie", storage);
			}
		}
		[Field ("AVFileTypeMPEG4", "AVFoundation")]
		internal unsafe static IntPtr AVFileTypeMPEG4 {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVFileTypeMPEG4", storage);
			}
		}
		[Field ("AVFileTypeAppleM4V", "AVFoundation")]
		internal unsafe static IntPtr AVFileTypeAppleM4V {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVFileTypeAppleM4V", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVFileType3GPP", "AVFoundation")]
		internal unsafe static IntPtr AVFileType3GPP {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVFileType3GPP", storage);
			}
		}
		[Field ("AVFileTypeAppleM4A", "AVFoundation")]
		internal unsafe static IntPtr AVFileTypeAppleM4A {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVFileTypeAppleM4A", storage);
			}
		}
		[Field ("AVFileTypeCoreAudioFormat", "AVFoundation")]
		internal unsafe static IntPtr AVFileTypeCoreAudioFormat {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVFileTypeCoreAudioFormat", storage);
			}
		}
		[Field ("AVFileTypeWAVE", "AVFoundation")]
		internal unsafe static IntPtr AVFileTypeWAVE {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVFileTypeWAVE", storage);
			}
		}
		[Field ("AVFileTypeAIFF", "AVFoundation")]
		internal unsafe static IntPtr AVFileTypeAIFF {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVFileTypeAIFF", storage);
			}
		}
		[Field ("AVFileTypeAIFC", "AVFoundation")]
		internal unsafe static IntPtr AVFileTypeAIFC {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVFileTypeAIFC", storage);
			}
		}
		[Field ("AVFileTypeAMR", "AVFoundation")]
		internal unsafe static IntPtr AVFileTypeAMR {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVFileTypeAMR", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVFileType3GPP2", "AVFoundation")]
		internal unsafe static IntPtr AVFileType3GPP2 {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVFileType3GPP2", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVFileTypeMPEGLayer3", "AVFoundation")]
		internal unsafe static IntPtr AVFileTypeMPEGLayer3 {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVFileTypeMPEGLayer3", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVFileTypeSunAU", "AVFoundation")]
		internal unsafe static IntPtr AVFileTypeSunAU {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVFileTypeSunAU", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVFileTypeAC3", "AVFoundation")]
		internal unsafe static IntPtr AVFileTypeAC3 {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVFileTypeAC3", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVFileTypeEnhancedAC3", "AVFoundation")]
		internal unsafe static IntPtr AVFileTypeEnhancedAC3 {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVFileTypeEnhancedAC3", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVFileTypeJPEG", "AVFoundation")]
		internal unsafe static IntPtr AVFileTypeJPEG {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVFileTypeJPEG", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVFileTypeDNG", "AVFoundation")]
		internal unsafe static IntPtr AVFileTypeDNG {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVFileTypeDNG", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVFileTypeHEIC", "AVFoundation")]
		internal unsafe static IntPtr AVFileTypeHEIC {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVFileTypeHEIC", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVFileTypeAVCI", "AVFoundation")]
		internal unsafe static IntPtr AVFileTypeAVCI {
			get {
				fixed (IntPtr *storage = &values [18])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVFileTypeAVCI", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVFileTypeHEIF", "AVFoundation")]
		internal unsafe static IntPtr AVFileTypeHEIF {
			get {
				fixed (IntPtr *storage = &values [19])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVFileTypeHEIF", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVFileTypeTIFF", "AVFoundation")]
		internal unsafe static IntPtr AVFileTypeTIFF {
			get {
				fixed (IntPtr *storage = &values [20])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVFileTypeTIFF", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("AVFileTypeAppleiTT", "AVFoundation")]
		internal unsafe static IntPtr AVFileTypeAppleiTT {
			get {
				fixed (IntPtr *storage = &values [21])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVFileTypeAppleiTT", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("AVFileTypeSCC", "AVFoundation")]
		internal unsafe static IntPtr AVFileTypeSCC {
			get {
				fixed (IntPtr *storage = &values [22])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVFileTypeSCC", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[Field ("AVFileTypeAHAP", "AVFoundation")]
		internal unsafe static IntPtr AVFileTypeAHAP {
			get {
				fixed (IntPtr *storage = &values [23])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVFileTypeAHAP", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("AVFileTypeDICOM", "AVFoundation")]
		internal unsafe static IntPtr AVFileTypeDICOM {
			get {
				fixed (IntPtr *storage = &values [24])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVFileTypeDICOM", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.1")]
		[SupportedOSPlatform ("tvos26.1")]
		[SupportedOSPlatform ("macos26.1")]
		[SupportedOSPlatform ("ios26.1")]
		[Field ("AVFileTypeQuickTimeAudio", "AVFoundation")]
		internal unsafe static IntPtr AVFileTypeQuickTimeAudio {
			get {
				fixed (IntPtr *storage = &values [25])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVFileTypeQuickTimeAudio", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this AVFileTypes self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // AVFileTypes.QuickTimeMovie
				ptr = AVFileTypeQuickTimeMovie;
				break;
			case 1: // AVFileTypes.Mpeg4
				ptr = AVFileTypeMPEG4;
				break;
			case 2: // AVFileTypes.AppleM4V
				ptr = AVFileTypeAppleM4V;
				break;
			case 3: // AVFileTypes.ThreeGpp
				ptr = AVFileType3GPP;
				break;
			case 4: // AVFileTypes.AppleM4a
				ptr = AVFileTypeAppleM4A;
				break;
			case 5: // AVFileTypes.CoreAudioFormat
				ptr = AVFileTypeCoreAudioFormat;
				break;
			case 6: // AVFileTypes.Wave
				ptr = AVFileTypeWAVE;
				break;
			case 7: // AVFileTypes.Aiff
				ptr = AVFileTypeAIFF;
				break;
			case 8: // AVFileTypes.Aifc
				ptr = AVFileTypeAIFC;
				break;
			case 9: // AVFileTypes.Amr
				ptr = AVFileTypeAMR;
				break;
			case 10: // AVFileTypes.ThreeGpp2
				ptr = AVFileType3GPP2;
				break;
			case 11: // AVFileTypes.MpegLayer3
				ptr = AVFileTypeMPEGLayer3;
				break;
			case 12: // AVFileTypes.SunAU
				ptr = AVFileTypeSunAU;
				break;
			case 13: // AVFileTypes.AC3
				ptr = AVFileTypeAC3;
				break;
			case 14: // AVFileTypes.EnhancedAC3
				ptr = AVFileTypeEnhancedAC3;
				break;
			case 15: // AVFileTypes.Jpeg
				ptr = AVFileTypeJPEG;
				break;
			case 16: // AVFileTypes.Dng
				ptr = AVFileTypeDNG;
				break;
			case 17: // AVFileTypes.Heic
				ptr = AVFileTypeHEIC;
				break;
			case 18: // AVFileTypes.Avci
				ptr = AVFileTypeAVCI;
				break;
			case 19: // AVFileTypes.Heif
				ptr = AVFileTypeHEIF;
				break;
			case 20: // AVFileTypes.Tiff
				ptr = AVFileTypeTIFF;
				break;
			case 21: // AVFileTypes.AppleiTT
				ptr = AVFileTypeAppleiTT;
				break;
			case 22: // AVFileTypes.Scc
				ptr = AVFileTypeSCC;
				break;
			case 23: // AVFileTypes.Ahap
				ptr = AVFileTypeAHAP;
				break;
			case 24: // AVFileTypes.Dicom
				ptr = AVFileTypeDICOM;
				break;
			case 25: // AVFileTypes.QuickTimeAudio
				ptr = AVFileTypeQuickTimeAudio;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVFileTypes" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static AVFileTypes GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (AVFileTypeQuickTimeMovie))
				return AVFileTypes.QuickTimeMovie;
			if (constant.IsEqualTo (AVFileTypeMPEG4))
				return AVFileTypes.Mpeg4;
			if (constant.IsEqualTo (AVFileTypeAppleM4V))
				return AVFileTypes.AppleM4V;
			if (constant.IsEqualTo (AVFileType3GPP))
				return AVFileTypes.ThreeGpp;
			if (constant.IsEqualTo (AVFileTypeAppleM4A))
				return AVFileTypes.AppleM4a;
			if (constant.IsEqualTo (AVFileTypeCoreAudioFormat))
				return AVFileTypes.CoreAudioFormat;
			if (constant.IsEqualTo (AVFileTypeWAVE))
				return AVFileTypes.Wave;
			if (constant.IsEqualTo (AVFileTypeAIFF))
				return AVFileTypes.Aiff;
			if (constant.IsEqualTo (AVFileTypeAIFC))
				return AVFileTypes.Aifc;
			if (constant.IsEqualTo (AVFileTypeAMR))
				return AVFileTypes.Amr;
			if (constant.IsEqualTo (AVFileType3GPP2))
				return AVFileTypes.ThreeGpp2;
			if (constant.IsEqualTo (AVFileTypeMPEGLayer3))
				return AVFileTypes.MpegLayer3;
			if (constant.IsEqualTo (AVFileTypeSunAU))
				return AVFileTypes.SunAU;
			if (constant.IsEqualTo (AVFileTypeAC3))
				return AVFileTypes.AC3;
			if (constant.IsEqualTo (AVFileTypeEnhancedAC3))
				return AVFileTypes.EnhancedAC3;
			if (constant.IsEqualTo (AVFileTypeJPEG))
				return AVFileTypes.Jpeg;
			if (constant.IsEqualTo (AVFileTypeDNG))
				return AVFileTypes.Dng;
			if (constant.IsEqualTo (AVFileTypeHEIC))
				return AVFileTypes.Heic;
			if (constant.IsEqualTo (AVFileTypeAVCI))
				return AVFileTypes.Avci;
			if (constant.IsEqualTo (AVFileTypeHEIF))
				return AVFileTypes.Heif;
			if (constant.IsEqualTo (AVFileTypeTIFF))
				return AVFileTypes.Tiff;
			if (constant.IsEqualTo (AVFileTypeAppleiTT))
				return AVFileTypes.AppleiTT;
			if (constant.IsEqualTo (AVFileTypeSCC))
				return AVFileTypes.Scc;
			if (constant.IsEqualTo (AVFileTypeAHAP))
				return AVFileTypes.Ahap;
			if (constant.IsEqualTo (AVFileTypeDICOM))
				return AVFileTypes.Dicom;
			if (constant.IsEqualTo (AVFileTypeQuickTimeAudio))
				return AVFileTypes.QuickTimeAudio;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVFileTypes" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVFileTypes GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVFileTypes" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVFileTypes? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AVFoundation.AVFileTypes" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this AVFileTypes[]? values)
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
		internal static AVFileTypes[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<AVFileTypes> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
