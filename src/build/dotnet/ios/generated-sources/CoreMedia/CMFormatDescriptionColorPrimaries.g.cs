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
namespace CoreMedia {
	public enum CMFormatDescriptionColorPrimaries : int {
		ITU_R_709_2 = 0,
		EBU_3213 = 1,
		SMPTE_C = 2,
		DCI_P3 = 3,
		P3_D65 = 4,
		ITU_R_2020 = 5,
		P22 = 6,
	}
	/// <summary>Extension methods for the <see cref="global::CoreMedia.CMFormatDescriptionColorPrimaries" /> enumeration.</summary>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CMFormatDescriptionColorPrimariesExtensions {
		static IntPtr[] values = new IntPtr [7];
		[Field ("kCMFormatDescriptionColorPrimaries_ITU_R_709_2", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionColorPrimaries_ITU_R_709_2 {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionColorPrimaries_ITU_R_709_2", storage);
			}
		}
		[Field ("kCMFormatDescriptionColorPrimaries_EBU_3213", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionColorPrimaries_EBU_3213 {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionColorPrimaries_EBU_3213", storage);
			}
		}
		[Field ("kCMFormatDescriptionColorPrimaries_SMPTE_C", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionColorPrimaries_SMPTE_C {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionColorPrimaries_SMPTE_C", storage);
			}
		}
		[Field ("kCMFormatDescriptionColorPrimaries_DCI_P3", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionColorPrimaries_DCI_P3 {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionColorPrimaries_DCI_P3", storage);
			}
		}
		[Field ("kCMFormatDescriptionColorPrimaries_P3_D65", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionColorPrimaries_P3_D65 {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionColorPrimaries_P3_D65", storage);
			}
		}
		[Field ("kCMFormatDescriptionColorPrimaries_ITU_R_2020", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionColorPrimaries_ITU_R_2020 {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionColorPrimaries_ITU_R_2020", storage);
			}
		}
		[Field ("kCMFormatDescriptionColorPrimaries_P22", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionColorPrimaries_P22 {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionColorPrimaries_P22", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CMFormatDescriptionColorPrimaries self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // CMFormatDescriptionColorPrimaries.ITU_R_709_2
				ptr = kCMFormatDescriptionColorPrimaries_ITU_R_709_2;
				break;
			case 1: // CMFormatDescriptionColorPrimaries.EBU_3213
				ptr = kCMFormatDescriptionColorPrimaries_EBU_3213;
				break;
			case 2: // CMFormatDescriptionColorPrimaries.SMPTE_C
				ptr = kCMFormatDescriptionColorPrimaries_SMPTE_C;
				break;
			case 3: // CMFormatDescriptionColorPrimaries.DCI_P3
				ptr = kCMFormatDescriptionColorPrimaries_DCI_P3;
				break;
			case 4: // CMFormatDescriptionColorPrimaries.P3_D65
				ptr = kCMFormatDescriptionColorPrimaries_P3_D65;
				break;
			case 5: // CMFormatDescriptionColorPrimaries.ITU_R_2020
				ptr = kCMFormatDescriptionColorPrimaries_ITU_R_2020;
				break;
			case 6: // CMFormatDescriptionColorPrimaries.P22
				ptr = kCMFormatDescriptionColorPrimaries_P22;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMFormatDescriptionColorPrimaries" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CMFormatDescriptionColorPrimaries GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (kCMFormatDescriptionColorPrimaries_ITU_R_709_2))
				return CMFormatDescriptionColorPrimaries.ITU_R_709_2;
			if (constant.IsEqualTo (kCMFormatDescriptionColorPrimaries_EBU_3213))
				return CMFormatDescriptionColorPrimaries.EBU_3213;
			if (constant.IsEqualTo (kCMFormatDescriptionColorPrimaries_SMPTE_C))
				return CMFormatDescriptionColorPrimaries.SMPTE_C;
			if (constant.IsEqualTo (kCMFormatDescriptionColorPrimaries_DCI_P3))
				return CMFormatDescriptionColorPrimaries.DCI_P3;
			if (constant.IsEqualTo (kCMFormatDescriptionColorPrimaries_P3_D65))
				return CMFormatDescriptionColorPrimaries.P3_D65;
			if (constant.IsEqualTo (kCMFormatDescriptionColorPrimaries_ITU_R_2020))
				return CMFormatDescriptionColorPrimaries.ITU_R_2020;
			if (constant.IsEqualTo (kCMFormatDescriptionColorPrimaries_P22))
				return CMFormatDescriptionColorPrimaries.P22;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMFormatDescriptionColorPrimaries" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CMFormatDescriptionColorPrimaries GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMFormatDescriptionColorPrimaries" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CMFormatDescriptionColorPrimaries? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::CoreMedia.CMFormatDescriptionColorPrimaries" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CMFormatDescriptionColorPrimaries[]? values)
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
		internal static CMFormatDescriptionColorPrimaries[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CMFormatDescriptionColorPrimaries> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
