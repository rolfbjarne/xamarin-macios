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
namespace CoreMedia {
	public enum CMFormatDescriptionYCbCrMatrix : int {
		ITU_R_709_2 = 0,
		ITU_R_601_4 = 1,
		SMPTE_240M_1995 = 2,
		ITU_R_2020 = 3,
	}
	/// <summary>Extension methods for the <see cref="global::CoreMedia.CMFormatDescriptionYCbCrMatrix" /> enumeration.</summary>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CMFormatDescriptionYCbCrMatrixExtensions {
		static IntPtr[] values = new IntPtr [4];
		[Field ("kCMFormatDescriptionYCbCrMatrix_ITU_R_709_2", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionYCbCrMatrix_ITU_R_709_2 {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionYCbCrMatrix_ITU_R_709_2", storage);
			}
		}
		[Field ("kCMFormatDescriptionYCbCrMatrix_ITU_R_601_4", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionYCbCrMatrix_ITU_R_601_4 {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionYCbCrMatrix_ITU_R_601_4", storage);
			}
		}
		[Field ("kCMFormatDescriptionYCbCrMatrix_SMPTE_240M_1995", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionYCbCrMatrix_SMPTE_240M_1995 {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionYCbCrMatrix_SMPTE_240M_1995", storage);
			}
		}
		[Field ("kCMFormatDescriptionYCbCrMatrix_ITU_R_2020", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionYCbCrMatrix_ITU_R_2020 {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionYCbCrMatrix_ITU_R_2020", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CMFormatDescriptionYCbCrMatrix self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // CMFormatDescriptionYCbCrMatrix.ITU_R_709_2
				ptr = kCMFormatDescriptionYCbCrMatrix_ITU_R_709_2;
				break;
			case 1: // CMFormatDescriptionYCbCrMatrix.ITU_R_601_4
				ptr = kCMFormatDescriptionYCbCrMatrix_ITU_R_601_4;
				break;
			case 2: // CMFormatDescriptionYCbCrMatrix.SMPTE_240M_1995
				ptr = kCMFormatDescriptionYCbCrMatrix_SMPTE_240M_1995;
				break;
			case 3: // CMFormatDescriptionYCbCrMatrix.ITU_R_2020
				ptr = kCMFormatDescriptionYCbCrMatrix_ITU_R_2020;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMFormatDescriptionYCbCrMatrix" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CMFormatDescriptionYCbCrMatrix GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (kCMFormatDescriptionYCbCrMatrix_ITU_R_709_2))
				return CMFormatDescriptionYCbCrMatrix.ITU_R_709_2;
			if (constant.IsEqualTo (kCMFormatDescriptionYCbCrMatrix_ITU_R_601_4))
				return CMFormatDescriptionYCbCrMatrix.ITU_R_601_4;
			if (constant.IsEqualTo (kCMFormatDescriptionYCbCrMatrix_SMPTE_240M_1995))
				return CMFormatDescriptionYCbCrMatrix.SMPTE_240M_1995;
			if (constant.IsEqualTo (kCMFormatDescriptionYCbCrMatrix_ITU_R_2020))
				return CMFormatDescriptionYCbCrMatrix.ITU_R_2020;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMFormatDescriptionYCbCrMatrix" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CMFormatDescriptionYCbCrMatrix GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMFormatDescriptionYCbCrMatrix" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CMFormatDescriptionYCbCrMatrix? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::CoreMedia.CMFormatDescriptionYCbCrMatrix" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CMFormatDescriptionYCbCrMatrix[]? values)
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
		internal static CMFormatDescriptionYCbCrMatrix[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CMFormatDescriptionYCbCrMatrix> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
