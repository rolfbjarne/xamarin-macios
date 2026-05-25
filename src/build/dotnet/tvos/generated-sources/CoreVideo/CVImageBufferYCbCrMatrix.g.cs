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
namespace CoreVideo {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum CVImageBufferYCbCrMatrix : int {
		/// <summary>To be added.</summary>
		Unknown = 2,
		/// <summary>To be added.</summary>
		ItuR709_2 = 3,
		/// <summary>To be added.</summary>
		ItuR601_4 = 4,
		/// <summary>To be added.</summary>
		Smpte240M1995 = 5,
		/// <summary>To be added.</summary>
		[ObsoletedOSPlatform ("ios14.0", "This API is no longer supported.")]
		[ObsoletedOSPlatform ("tvos14.0", "This API is no longer supported.")]
		[ObsoletedOSPlatform ("macos11.0", "This API is no longer supported.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "This API is no longer supported.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		DciP3 = 6,
		/// <summary>To be added.</summary>
		[ObsoletedOSPlatform ("ios14.0", "This API is no longer supported.")]
		[ObsoletedOSPlatform ("tvos14.0", "This API is no longer supported.")]
		[ObsoletedOSPlatform ("macos11.0", "This API is no longer supported.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "This API is no longer supported.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		P3D65 = 7,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		ItuR2020 = 8,
	}
	/// <summary>Extension methods for the <see cref="global::CoreVideo.CVImageBufferYCbCrMatrix" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CVImageBufferYCbCrMatrixExtensions {
		static IntPtr[] values = new IntPtr [6];
		[Field ("kCVImageBufferYCbCrMatrix_ITU_R_709_2", "CoreVideo")]
		internal unsafe static IntPtr kCVImageBufferYCbCrMatrix_ITU_R_709_2 {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.CoreVideo.Handle, "kCVImageBufferYCbCrMatrix_ITU_R_709_2", storage);
			}
		}
		[Field ("kCVImageBufferYCbCrMatrix_ITU_R_601_4", "CoreVideo")]
		internal unsafe static IntPtr kCVImageBufferYCbCrMatrix_ITU_R_601_4 {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.CoreVideo.Handle, "kCVImageBufferYCbCrMatrix_ITU_R_601_4", storage);
			}
		}
		[Field ("kCVImageBufferYCbCrMatrix_SMPTE_240M_1995", "CoreVideo")]
		internal unsafe static IntPtr kCVImageBufferYCbCrMatrix_SMPTE_240M_1995 {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.CoreVideo.Handle, "kCVImageBufferYCbCrMatrix_SMPTE_240M_1995", storage);
			}
		}
		[ObsoletedOSPlatform ("ios14.0", "This API is no longer supported.")]
		[ObsoletedOSPlatform ("tvos14.0", "This API is no longer supported.")]
		[ObsoletedOSPlatform ("macos11.0", "This API is no longer supported.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "This API is no longer supported.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCVImageBufferYCbCrMatrix_DCI_P3", "CoreVideo")]
		internal unsafe static IntPtr kCVImageBufferYCbCrMatrix_DCI_P3 {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.CoreVideo.Handle, "kCVImageBufferYCbCrMatrix_DCI_P3", storage);
			}
		}
		[ObsoletedOSPlatform ("ios14.0", "This API is no longer supported.")]
		[ObsoletedOSPlatform ("tvos14.0", "This API is no longer supported.")]
		[ObsoletedOSPlatform ("macos11.0", "This API is no longer supported.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "This API is no longer supported.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCVImageBufferYCbCrMatrix_P3_D65", "CoreVideo")]
		internal unsafe static IntPtr kCVImageBufferYCbCrMatrix_P3_D65 {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.CoreVideo.Handle, "kCVImageBufferYCbCrMatrix_P3_D65", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCVImageBufferYCbCrMatrix_ITU_R_2020", "CoreVideo")]
		internal unsafe static IntPtr kCVImageBufferYCbCrMatrix_ITU_R_2020 {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.CoreVideo.Handle, "kCVImageBufferYCbCrMatrix_ITU_R_2020", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CVImageBufferYCbCrMatrix self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 3: // CVImageBufferYCbCrMatrix.ItuR709_2
				ptr = kCVImageBufferYCbCrMatrix_ITU_R_709_2;
				break;
			case 4: // CVImageBufferYCbCrMatrix.ItuR601_4
				ptr = kCVImageBufferYCbCrMatrix_ITU_R_601_4;
				break;
			case 5: // CVImageBufferYCbCrMatrix.Smpte240M1995
				ptr = kCVImageBufferYCbCrMatrix_SMPTE_240M_1995;
				break;
			case 6: // CVImageBufferYCbCrMatrix.DciP3
				ptr = kCVImageBufferYCbCrMatrix_DCI_P3;
				break;
			case 7: // CVImageBufferYCbCrMatrix.P3D65
				ptr = kCVImageBufferYCbCrMatrix_P3_D65;
				break;
			case 8: // CVImageBufferYCbCrMatrix.ItuR2020
				ptr = kCVImageBufferYCbCrMatrix_ITU_R_2020;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::CoreVideo.CVImageBufferYCbCrMatrix" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CVImageBufferYCbCrMatrix GetValue (NSString? constant)
		{
			if (constant is null)
				return CVImageBufferYCbCrMatrix.Unknown;
			if (constant.IsEqualTo (kCVImageBufferYCbCrMatrix_ITU_R_709_2))
				return CVImageBufferYCbCrMatrix.ItuR709_2;
			if (constant.IsEqualTo (kCVImageBufferYCbCrMatrix_ITU_R_601_4))
				return CVImageBufferYCbCrMatrix.ItuR601_4;
			if (constant.IsEqualTo (kCVImageBufferYCbCrMatrix_SMPTE_240M_1995))
				return CVImageBufferYCbCrMatrix.Smpte240M1995;
			if (constant.IsEqualTo (kCVImageBufferYCbCrMatrix_DCI_P3))
				return CVImageBufferYCbCrMatrix.DciP3;
			if (constant.IsEqualTo (kCVImageBufferYCbCrMatrix_P3_D65))
				return CVImageBufferYCbCrMatrix.P3D65;
			if (constant.IsEqualTo (kCVImageBufferYCbCrMatrix_ITU_R_2020))
				return CVImageBufferYCbCrMatrix.ItuR2020;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::CoreVideo.CVImageBufferYCbCrMatrix" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CVImageBufferYCbCrMatrix GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::CoreVideo.CVImageBufferYCbCrMatrix" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CVImageBufferYCbCrMatrix? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::CoreVideo.CVImageBufferYCbCrMatrix" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CVImageBufferYCbCrMatrix[]? values)
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
		internal static CVImageBufferYCbCrMatrix[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CVImageBufferYCbCrMatrix> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
