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
namespace CoreVideo {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum CVImageBufferTransferFunction : int {
		/// <summary>To be added.</summary>
		Unknown = 2,
		/// <summary>To be added.</summary>
		ItuR709_2 = 3,
		/// <summary>To be added.</summary>
		Smpte240M1995 = 4,
		/// <summary>To be added.</summary>
		UseGamma = 5,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		ItuR2020 = 6,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		SmpteST428_1 = 7,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		SRgb = 8,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		SmpteST2084PQ = 9,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		ItuR2100Hlg = 10,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Linear = 11,
	}
	/// <summary>Extension methods for the <see cref="global::CoreVideo.CVImageBufferTransferFunction" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CVImageBufferTransferFunctionExtensions {
		static IntPtr[] values = new IntPtr [9];
		[Field ("kCVImageBufferTransferFunction_ITU_R_709_2", "CoreVideo")]
		internal unsafe static IntPtr kCVImageBufferTransferFunction_ITU_R_709_2 {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.CoreVideo.Handle, "kCVImageBufferTransferFunction_ITU_R_709_2", storage);
			}
		}
		[Field ("kCVImageBufferTransferFunction_SMPTE_240M_1995", "CoreVideo")]
		internal unsafe static IntPtr kCVImageBufferTransferFunction_SMPTE_240M_1995 {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.CoreVideo.Handle, "kCVImageBufferTransferFunction_SMPTE_240M_1995", storage);
			}
		}
		[Field ("kCVImageBufferTransferFunction_UseGamma", "CoreVideo")]
		internal unsafe static IntPtr kCVImageBufferTransferFunction_UseGamma {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.CoreVideo.Handle, "kCVImageBufferTransferFunction_UseGamma", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCVImageBufferTransferFunction_ITU_R_2020", "CoreVideo")]
		internal unsafe static IntPtr kCVImageBufferTransferFunction_ITU_R_2020 {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.CoreVideo.Handle, "kCVImageBufferTransferFunction_ITU_R_2020", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCVImageBufferTransferFunction_SMPTE_ST_428_1", "CoreVideo")]
		internal unsafe static IntPtr kCVImageBufferTransferFunction_SMPTE_ST_428_1 {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.CoreVideo.Handle, "kCVImageBufferTransferFunction_SMPTE_ST_428_1", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCVImageBufferTransferFunction_sRGB", "CoreVideo")]
		internal unsafe static IntPtr kCVImageBufferTransferFunction_sRGB {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.CoreVideo.Handle, "kCVImageBufferTransferFunction_sRGB", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCVImageBufferTransferFunction_SMPTE_ST_2084_PQ", "CoreVideo")]
		internal unsafe static IntPtr kCVImageBufferTransferFunction_SMPTE_ST_2084_PQ {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.CoreVideo.Handle, "kCVImageBufferTransferFunction_SMPTE_ST_2084_PQ", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCVImageBufferTransferFunction_ITU_R_2100_HLG", "CoreVideo")]
		internal unsafe static IntPtr kCVImageBufferTransferFunction_ITU_R_2100_HLG {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.CoreVideo.Handle, "kCVImageBufferTransferFunction_ITU_R_2100_HLG", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCVImageBufferTransferFunction_Linear", "CoreVideo")]
		internal unsafe static IntPtr kCVImageBufferTransferFunction_Linear {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.CoreVideo.Handle, "kCVImageBufferTransferFunction_Linear", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CVImageBufferTransferFunction self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 3: // CVImageBufferTransferFunction.ItuR709_2
				ptr = kCVImageBufferTransferFunction_ITU_R_709_2;
				break;
			case 4: // CVImageBufferTransferFunction.Smpte240M1995
				ptr = kCVImageBufferTransferFunction_SMPTE_240M_1995;
				break;
			case 5: // CVImageBufferTransferFunction.UseGamma
				ptr = kCVImageBufferTransferFunction_UseGamma;
				break;
			case 6: // CVImageBufferTransferFunction.ItuR2020
				ptr = kCVImageBufferTransferFunction_ITU_R_2020;
				break;
			case 7: // CVImageBufferTransferFunction.SmpteST428_1
				ptr = kCVImageBufferTransferFunction_SMPTE_ST_428_1;
				break;
			case 8: // CVImageBufferTransferFunction.SRgb
				ptr = kCVImageBufferTransferFunction_sRGB;
				break;
			case 9: // CVImageBufferTransferFunction.SmpteST2084PQ
				ptr = kCVImageBufferTransferFunction_SMPTE_ST_2084_PQ;
				break;
			case 10: // CVImageBufferTransferFunction.ItuR2100Hlg
				ptr = kCVImageBufferTransferFunction_ITU_R_2100_HLG;
				break;
			case 11: // CVImageBufferTransferFunction.Linear
				ptr = kCVImageBufferTransferFunction_Linear;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::CoreVideo.CVImageBufferTransferFunction" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CVImageBufferTransferFunction GetValue (NSString? constant)
		{
			if (constant is null)
				return CVImageBufferTransferFunction.Unknown;
			if (constant.IsEqualTo (kCVImageBufferTransferFunction_ITU_R_709_2))
				return CVImageBufferTransferFunction.ItuR709_2;
			if (constant.IsEqualTo (kCVImageBufferTransferFunction_SMPTE_240M_1995))
				return CVImageBufferTransferFunction.Smpte240M1995;
			if (constant.IsEqualTo (kCVImageBufferTransferFunction_UseGamma))
				return CVImageBufferTransferFunction.UseGamma;
			if (constant.IsEqualTo (kCVImageBufferTransferFunction_ITU_R_2020))
				return CVImageBufferTransferFunction.ItuR2020;
			if (constant.IsEqualTo (kCVImageBufferTransferFunction_SMPTE_ST_428_1))
				return CVImageBufferTransferFunction.SmpteST428_1;
			if (constant.IsEqualTo (kCVImageBufferTransferFunction_sRGB))
				return CVImageBufferTransferFunction.SRgb;
			if (constant.IsEqualTo (kCVImageBufferTransferFunction_SMPTE_ST_2084_PQ))
				return CVImageBufferTransferFunction.SmpteST2084PQ;
			if (constant.IsEqualTo (kCVImageBufferTransferFunction_ITU_R_2100_HLG))
				return CVImageBufferTransferFunction.ItuR2100Hlg;
			if (constant.IsEqualTo (kCVImageBufferTransferFunction_Linear))
				return CVImageBufferTransferFunction.Linear;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::CoreVideo.CVImageBufferTransferFunction" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CVImageBufferTransferFunction GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::CoreVideo.CVImageBufferTransferFunction" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CVImageBufferTransferFunction? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::CoreVideo.CVImageBufferTransferFunction" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CVImageBufferTransferFunction[]? values)
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
		internal static CVImageBufferTransferFunction[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CVImageBufferTransferFunction> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
