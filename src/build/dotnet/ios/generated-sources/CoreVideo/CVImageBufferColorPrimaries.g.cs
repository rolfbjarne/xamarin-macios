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
namespace CoreVideo {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum CVImageBufferColorPrimaries : int {
		/// <summary>To be added.</summary>
		Unknown = 2,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		DciP3 = 3,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		ItuR2020 = 4,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		P3D65 = 5,
		/// <summary>To be added.</summary>
		ItuR709_2 = 6,
		/// <summary>To be added.</summary>
		Ebu3213 = 7,
		/// <summary>To be added.</summary>
		SmpteC = 8,
		/// <summary>To be added.</summary>
		P22 = 9,
	}
	/// <summary>Extension methods for the <see cref="global::CoreVideo.CVImageBufferColorPrimaries" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CVImageBufferColorPrimariesExtensions {
		static IntPtr[] values = new IntPtr [7];
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCVImageBufferColorPrimaries_DCI_P3", "CoreVideo")]
		internal unsafe static IntPtr kCVImageBufferColorPrimaries_DCI_P3 {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.CoreVideo.Handle, "kCVImageBufferColorPrimaries_DCI_P3", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCVImageBufferColorPrimaries_ITU_R_2020", "CoreVideo")]
		internal unsafe static IntPtr kCVImageBufferColorPrimaries_ITU_R_2020 {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.CoreVideo.Handle, "kCVImageBufferColorPrimaries_ITU_R_2020", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("kCVImageBufferColorPrimaries_P3_D65", "CoreVideo")]
		internal unsafe static IntPtr kCVImageBufferColorPrimaries_P3_D65 {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.CoreVideo.Handle, "kCVImageBufferColorPrimaries_P3_D65", storage);
			}
		}
		[Field ("kCVImageBufferColorPrimaries_ITU_R_709_2", "CoreVideo")]
		internal unsafe static IntPtr kCVImageBufferColorPrimaries_ITU_R_709_2 {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.CoreVideo.Handle, "kCVImageBufferColorPrimaries_ITU_R_709_2", storage);
			}
		}
		[Field ("kCVImageBufferColorPrimaries_EBU_3213", "CoreVideo")]
		internal unsafe static IntPtr kCVImageBufferColorPrimaries_EBU_3213 {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.CoreVideo.Handle, "kCVImageBufferColorPrimaries_EBU_3213", storage);
			}
		}
		[Field ("kCVImageBufferColorPrimaries_SMPTE_C", "CoreVideo")]
		internal unsafe static IntPtr kCVImageBufferColorPrimaries_SMPTE_C {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.CoreVideo.Handle, "kCVImageBufferColorPrimaries_SMPTE_C", storage);
			}
		}
		[Field ("kCVImageBufferColorPrimaries_P22", "CoreVideo")]
		internal unsafe static IntPtr kCVImageBufferColorPrimaries_P22 {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.CoreVideo.Handle, "kCVImageBufferColorPrimaries_P22", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CVImageBufferColorPrimaries self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 3: // CVImageBufferColorPrimaries.DciP3
				ptr = kCVImageBufferColorPrimaries_DCI_P3;
				break;
			case 4: // CVImageBufferColorPrimaries.ItuR2020
				ptr = kCVImageBufferColorPrimaries_ITU_R_2020;
				break;
			case 5: // CVImageBufferColorPrimaries.P3D65
				ptr = kCVImageBufferColorPrimaries_P3_D65;
				break;
			case 6: // CVImageBufferColorPrimaries.ItuR709_2
				ptr = kCVImageBufferColorPrimaries_ITU_R_709_2;
				break;
			case 7: // CVImageBufferColorPrimaries.Ebu3213
				ptr = kCVImageBufferColorPrimaries_EBU_3213;
				break;
			case 8: // CVImageBufferColorPrimaries.SmpteC
				ptr = kCVImageBufferColorPrimaries_SMPTE_C;
				break;
			case 9: // CVImageBufferColorPrimaries.P22
				ptr = kCVImageBufferColorPrimaries_P22;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::CoreVideo.CVImageBufferColorPrimaries" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CVImageBufferColorPrimaries GetValue (NSString? constant)
		{
			if (constant is null)
				return CVImageBufferColorPrimaries.Unknown;
			if (constant.IsEqualTo (kCVImageBufferColorPrimaries_DCI_P3))
				return CVImageBufferColorPrimaries.DciP3;
			if (constant.IsEqualTo (kCVImageBufferColorPrimaries_ITU_R_2020))
				return CVImageBufferColorPrimaries.ItuR2020;
			if (constant.IsEqualTo (kCVImageBufferColorPrimaries_P3_D65))
				return CVImageBufferColorPrimaries.P3D65;
			if (constant.IsEqualTo (kCVImageBufferColorPrimaries_ITU_R_709_2))
				return CVImageBufferColorPrimaries.ItuR709_2;
			if (constant.IsEqualTo (kCVImageBufferColorPrimaries_EBU_3213))
				return CVImageBufferColorPrimaries.Ebu3213;
			if (constant.IsEqualTo (kCVImageBufferColorPrimaries_SMPTE_C))
				return CVImageBufferColorPrimaries.SmpteC;
			if (constant.IsEqualTo (kCVImageBufferColorPrimaries_P22))
				return CVImageBufferColorPrimaries.P22;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::CoreVideo.CVImageBufferColorPrimaries" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CVImageBufferColorPrimaries GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::CoreVideo.CVImageBufferColorPrimaries" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CVImageBufferColorPrimaries? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::CoreVideo.CVImageBufferColorPrimaries" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CVImageBufferColorPrimaries[]? values)
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
		internal static CVImageBufferColorPrimaries[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CVImageBufferColorPrimaries> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
