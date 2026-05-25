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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace CoreMedia {
	public enum CMFormatDescriptionTransferFunction : int {
		ITU_R_709_2 = 0,
		SMPTE_240M_1995 = 1,
		UseGamma = 2,
		ITU_R_2020 = 3,
		SMPTE_ST_428_1 = 4,
		SMPTE_ST_2084_PQ = 5,
		ITU_R_2100_HLG = 6,
		Linear = 7,
		SRGB = 8,
	}
	/// <summary>Extension methods for the <see cref="global::CoreMedia.CMFormatDescriptionTransferFunction" /> enumeration.</summary>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CMFormatDescriptionTransferFunctionExtensions {
		static IntPtr[] values = new IntPtr [9];
		[Field ("kCMFormatDescriptionTransferFunction_ITU_R_709_2", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionTransferFunction_ITU_R_709_2 {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionTransferFunction_ITU_R_709_2", storage);
			}
		}
		[Field ("kCMFormatDescriptionTransferFunction_SMPTE_240M_1995", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionTransferFunction_SMPTE_240M_1995 {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionTransferFunction_SMPTE_240M_1995", storage);
			}
		}
		[Field ("kCMFormatDescriptionTransferFunction_UseGamma", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionTransferFunction_UseGamma {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionTransferFunction_UseGamma", storage);
			}
		}
		[Field ("kCMFormatDescriptionTransferFunction_ITU_R_2020", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionTransferFunction_ITU_R_2020 {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionTransferFunction_ITU_R_2020", storage);
			}
		}
		[Field ("kCMFormatDescriptionTransferFunction_SMPTE_ST_428_1", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionTransferFunction_SMPTE_ST_428_1 {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionTransferFunction_SMPTE_ST_428_1", storage);
			}
		}
		[Field ("kCMFormatDescriptionTransferFunction_SMPTE_ST_2084_PQ", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionTransferFunction_SMPTE_ST_2084_PQ {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionTransferFunction_SMPTE_ST_2084_PQ", storage);
			}
		}
		[Field ("kCMFormatDescriptionTransferFunction_ITU_R_2100_HLG", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionTransferFunction_ITU_R_2100_HLG {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionTransferFunction_ITU_R_2100_HLG", storage);
			}
		}
		[Field ("kCMFormatDescriptionTransferFunction_Linear", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionTransferFunction_Linear {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionTransferFunction_Linear", storage);
			}
		}
		[Field ("kCMFormatDescriptionTransferFunction_sRGB", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionTransferFunction_sRGB {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionTransferFunction_sRGB", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CMFormatDescriptionTransferFunction self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // CMFormatDescriptionTransferFunction.ITU_R_709_2
				ptr = kCMFormatDescriptionTransferFunction_ITU_R_709_2;
				break;
			case 1: // CMFormatDescriptionTransferFunction.SMPTE_240M_1995
				ptr = kCMFormatDescriptionTransferFunction_SMPTE_240M_1995;
				break;
			case 2: // CMFormatDescriptionTransferFunction.UseGamma
				ptr = kCMFormatDescriptionTransferFunction_UseGamma;
				break;
			case 3: // CMFormatDescriptionTransferFunction.ITU_R_2020
				ptr = kCMFormatDescriptionTransferFunction_ITU_R_2020;
				break;
			case 4: // CMFormatDescriptionTransferFunction.SMPTE_ST_428_1
				ptr = kCMFormatDescriptionTransferFunction_SMPTE_ST_428_1;
				break;
			case 5: // CMFormatDescriptionTransferFunction.SMPTE_ST_2084_PQ
				ptr = kCMFormatDescriptionTransferFunction_SMPTE_ST_2084_PQ;
				break;
			case 6: // CMFormatDescriptionTransferFunction.ITU_R_2100_HLG
				ptr = kCMFormatDescriptionTransferFunction_ITU_R_2100_HLG;
				break;
			case 7: // CMFormatDescriptionTransferFunction.Linear
				ptr = kCMFormatDescriptionTransferFunction_Linear;
				break;
			case 8: // CMFormatDescriptionTransferFunction.SRGB
				ptr = kCMFormatDescriptionTransferFunction_sRGB;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMFormatDescriptionTransferFunction" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CMFormatDescriptionTransferFunction GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (kCMFormatDescriptionTransferFunction_ITU_R_709_2))
				return CMFormatDescriptionTransferFunction.ITU_R_709_2;
			if (constant.IsEqualTo (kCMFormatDescriptionTransferFunction_SMPTE_240M_1995))
				return CMFormatDescriptionTransferFunction.SMPTE_240M_1995;
			if (constant.IsEqualTo (kCMFormatDescriptionTransferFunction_UseGamma))
				return CMFormatDescriptionTransferFunction.UseGamma;
			if (constant.IsEqualTo (kCMFormatDescriptionTransferFunction_ITU_R_2020))
				return CMFormatDescriptionTransferFunction.ITU_R_2020;
			if (constant.IsEqualTo (kCMFormatDescriptionTransferFunction_SMPTE_ST_428_1))
				return CMFormatDescriptionTransferFunction.SMPTE_ST_428_1;
			if (constant.IsEqualTo (kCMFormatDescriptionTransferFunction_SMPTE_ST_2084_PQ))
				return CMFormatDescriptionTransferFunction.SMPTE_ST_2084_PQ;
			if (constant.IsEqualTo (kCMFormatDescriptionTransferFunction_ITU_R_2100_HLG))
				return CMFormatDescriptionTransferFunction.ITU_R_2100_HLG;
			if (constant.IsEqualTo (kCMFormatDescriptionTransferFunction_Linear))
				return CMFormatDescriptionTransferFunction.Linear;
			if (constant.IsEqualTo (kCMFormatDescriptionTransferFunction_sRGB))
				return CMFormatDescriptionTransferFunction.SRGB;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMFormatDescriptionTransferFunction" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CMFormatDescriptionTransferFunction GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMFormatDescriptionTransferFunction" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CMFormatDescriptionTransferFunction? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::CoreMedia.CMFormatDescriptionTransferFunction" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CMFormatDescriptionTransferFunction[]? values)
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
		internal static CMFormatDescriptionTransferFunction[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CMFormatDescriptionTransferFunction> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
