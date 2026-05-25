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
namespace ImageIO {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum CGImageAuxiliaryDataType : int {
		/// <summary>To be added.</summary>
		Depth = 0,
		/// <summary>To be added.</summary>
		Disparity = 1,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		PortraitEffectsMatte = 2,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		SemanticSegmentationHairMatte = 3,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		SemanticSegmentationSkinMatte = 4,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		SemanticSegmentationTeethMatte = 5,
		[SupportedOSPlatform ("ios14.1")]
		[SupportedOSPlatform ("tvos14.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		SemanticSegmentationGlassesMatte = 6,
		[SupportedOSPlatform ("ios14.1")]
		[SupportedOSPlatform ("tvos14.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		TypeHdrGainMap = 7,
		[SupportedOSPlatform ("ios14.3")]
		[SupportedOSPlatform ("tvos14.3")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		SemanticSegmentationSkyMatte = 8,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		IsoGainMap = 9,
	}
	/// <summary>Extension methods for the <see cref="global::ImageIO.CGImageAuxiliaryDataType" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CGImageAuxiliaryDataTypeExtensions {
		static IntPtr[] values = new IntPtr [10];
		[Field ("kCGImageAuxiliaryDataTypeDepth", "ImageIO")]
		internal unsafe static IntPtr kCGImageAuxiliaryDataTypeDepth {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.ImageIO.Handle, "kCGImageAuxiliaryDataTypeDepth", storage);
			}
		}
		[Field ("kCGImageAuxiliaryDataTypeDisparity", "ImageIO")]
		internal unsafe static IntPtr kCGImageAuxiliaryDataTypeDisparity {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.ImageIO.Handle, "kCGImageAuxiliaryDataTypeDisparity", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCGImageAuxiliaryDataTypePortraitEffectsMatte", "ImageIO")]
		internal unsafe static IntPtr kCGImageAuxiliaryDataTypePortraitEffectsMatte {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.ImageIO.Handle, "kCGImageAuxiliaryDataTypePortraitEffectsMatte", storage);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("kCGImageAuxiliaryDataTypeSemanticSegmentationHairMatte", "ImageIO")]
		internal unsafe static IntPtr kCGImageAuxiliaryDataTypeSemanticSegmentationHairMatte {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.ImageIO.Handle, "kCGImageAuxiliaryDataTypeSemanticSegmentationHairMatte", storage);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("kCGImageAuxiliaryDataTypeSemanticSegmentationSkinMatte", "ImageIO")]
		internal unsafe static IntPtr kCGImageAuxiliaryDataTypeSemanticSegmentationSkinMatte {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.ImageIO.Handle, "kCGImageAuxiliaryDataTypeSemanticSegmentationSkinMatte", storage);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("kCGImageAuxiliaryDataTypeSemanticSegmentationTeethMatte", "ImageIO")]
		internal unsafe static IntPtr kCGImageAuxiliaryDataTypeSemanticSegmentationTeethMatte {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.ImageIO.Handle, "kCGImageAuxiliaryDataTypeSemanticSegmentationTeethMatte", storage);
			}
		}
		[SupportedOSPlatform ("ios14.1")]
		[SupportedOSPlatform ("tvos14.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("kCGImageAuxiliaryDataTypeSemanticSegmentationGlassesMatte", "ImageIO")]
		internal unsafe static IntPtr kCGImageAuxiliaryDataTypeSemanticSegmentationGlassesMatte {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.ImageIO.Handle, "kCGImageAuxiliaryDataTypeSemanticSegmentationGlassesMatte", storage);
			}
		}
		[SupportedOSPlatform ("ios14.1")]
		[SupportedOSPlatform ("tvos14.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("kCGImageAuxiliaryDataTypeHDRGainMap", "ImageIO")]
		internal unsafe static IntPtr kCGImageAuxiliaryDataTypeHDRGainMap {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.ImageIO.Handle, "kCGImageAuxiliaryDataTypeHDRGainMap", storage);
			}
		}
		[SupportedOSPlatform ("ios14.3")]
		[SupportedOSPlatform ("tvos14.3")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("kCGImageAuxiliaryDataTypeSemanticSegmentationSkyMatte", "ImageIO")]
		internal unsafe static IntPtr kCGImageAuxiliaryDataTypeSemanticSegmentationSkyMatte {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.ImageIO.Handle, "kCGImageAuxiliaryDataTypeSemanticSegmentationSkyMatte", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("kCGImageAuxiliaryDataTypeISOGainMap", "ImageIO")]
		internal unsafe static IntPtr kCGImageAuxiliaryDataTypeISOGainMap {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.ImageIO.Handle, "kCGImageAuxiliaryDataTypeISOGainMap", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CGImageAuxiliaryDataType self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // CGImageAuxiliaryDataType.Depth
				ptr = kCGImageAuxiliaryDataTypeDepth;
				break;
			case 1: // CGImageAuxiliaryDataType.Disparity
				ptr = kCGImageAuxiliaryDataTypeDisparity;
				break;
			case 2: // CGImageAuxiliaryDataType.PortraitEffectsMatte
				ptr = kCGImageAuxiliaryDataTypePortraitEffectsMatte;
				break;
			case 3: // CGImageAuxiliaryDataType.SemanticSegmentationHairMatte
				ptr = kCGImageAuxiliaryDataTypeSemanticSegmentationHairMatte;
				break;
			case 4: // CGImageAuxiliaryDataType.SemanticSegmentationSkinMatte
				ptr = kCGImageAuxiliaryDataTypeSemanticSegmentationSkinMatte;
				break;
			case 5: // CGImageAuxiliaryDataType.SemanticSegmentationTeethMatte
				ptr = kCGImageAuxiliaryDataTypeSemanticSegmentationTeethMatte;
				break;
			case 6: // CGImageAuxiliaryDataType.SemanticSegmentationGlassesMatte
				ptr = kCGImageAuxiliaryDataTypeSemanticSegmentationGlassesMatte;
				break;
			case 7: // CGImageAuxiliaryDataType.TypeHdrGainMap
				ptr = kCGImageAuxiliaryDataTypeHDRGainMap;
				break;
			case 8: // CGImageAuxiliaryDataType.SemanticSegmentationSkyMatte
				ptr = kCGImageAuxiliaryDataTypeSemanticSegmentationSkyMatte;
				break;
			case 9: // CGImageAuxiliaryDataType.IsoGainMap
				ptr = kCGImageAuxiliaryDataTypeISOGainMap;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::ImageIO.CGImageAuxiliaryDataType" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CGImageAuxiliaryDataType GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (kCGImageAuxiliaryDataTypeDepth))
				return CGImageAuxiliaryDataType.Depth;
			if (constant.IsEqualTo (kCGImageAuxiliaryDataTypeDisparity))
				return CGImageAuxiliaryDataType.Disparity;
			if (constant.IsEqualTo (kCGImageAuxiliaryDataTypePortraitEffectsMatte))
				return CGImageAuxiliaryDataType.PortraitEffectsMatte;
			if (constant.IsEqualTo (kCGImageAuxiliaryDataTypeSemanticSegmentationHairMatte))
				return CGImageAuxiliaryDataType.SemanticSegmentationHairMatte;
			if (constant.IsEqualTo (kCGImageAuxiliaryDataTypeSemanticSegmentationSkinMatte))
				return CGImageAuxiliaryDataType.SemanticSegmentationSkinMatte;
			if (constant.IsEqualTo (kCGImageAuxiliaryDataTypeSemanticSegmentationTeethMatte))
				return CGImageAuxiliaryDataType.SemanticSegmentationTeethMatte;
			if (constant.IsEqualTo (kCGImageAuxiliaryDataTypeSemanticSegmentationGlassesMatte))
				return CGImageAuxiliaryDataType.SemanticSegmentationGlassesMatte;
			if (constant.IsEqualTo (kCGImageAuxiliaryDataTypeHDRGainMap))
				return CGImageAuxiliaryDataType.TypeHdrGainMap;
			if (constant.IsEqualTo (kCGImageAuxiliaryDataTypeSemanticSegmentationSkyMatte))
				return CGImageAuxiliaryDataType.SemanticSegmentationSkyMatte;
			if (constant.IsEqualTo (kCGImageAuxiliaryDataTypeISOGainMap))
				return CGImageAuxiliaryDataType.IsoGainMap;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::ImageIO.CGImageAuxiliaryDataType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CGImageAuxiliaryDataType GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::ImageIO.CGImageAuxiliaryDataType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CGImageAuxiliaryDataType? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::ImageIO.CGImageAuxiliaryDataType" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CGImageAuxiliaryDataType[]? values)
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
		internal static CGImageAuxiliaryDataType[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CGImageAuxiliaryDataType> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
