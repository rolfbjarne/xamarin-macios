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
namespace VideoToolbox {
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	public enum VTProjectionKind : int {
		Rectilinear = 0,
		Equirectangular = 1,
		HalfEquirectangular = 2,
		ParametricImmersive = 3,
	}
	/// <summary>Extension methods for the <see cref="global::VideoToolbox.VTProjectionKind" /> enumeration.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class VTProjectionKindExtensions {
		static IntPtr[] values = new IntPtr [4];
		[Field ("kVTProjectionKind_Rectilinear", "VideoToolbox")]
		internal unsafe static IntPtr kVTProjectionKind_Rectilinear {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.VideoToolbox.Handle, "kVTProjectionKind_Rectilinear", storage);
			}
		}
		[Field ("kVTProjectionKind_Equirectangular", "VideoToolbox")]
		internal unsafe static IntPtr kVTProjectionKind_Equirectangular {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.VideoToolbox.Handle, "kVTProjectionKind_Equirectangular", storage);
			}
		}
		[Field ("kVTProjectionKind_HalfEquirectangular", "VideoToolbox")]
		internal unsafe static IntPtr kVTProjectionKind_HalfEquirectangular {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.VideoToolbox.Handle, "kVTProjectionKind_HalfEquirectangular", storage);
			}
		}
		[Field ("kVTProjectionKind_ParametricImmersive", "VideoToolbox")]
		internal unsafe static IntPtr kVTProjectionKind_ParametricImmersive {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.VideoToolbox.Handle, "kVTProjectionKind_ParametricImmersive", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this VTProjectionKind self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // VTProjectionKind.Rectilinear
				ptr = kVTProjectionKind_Rectilinear;
				break;
			case 1: // VTProjectionKind.Equirectangular
				ptr = kVTProjectionKind_Equirectangular;
				break;
			case 2: // VTProjectionKind.HalfEquirectangular
				ptr = kVTProjectionKind_HalfEquirectangular;
				break;
			case 3: // VTProjectionKind.ParametricImmersive
				ptr = kVTProjectionKind_ParametricImmersive;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::VideoToolbox.VTProjectionKind" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static VTProjectionKind GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (kVTProjectionKind_Rectilinear))
				return VTProjectionKind.Rectilinear;
			if (constant.IsEqualTo (kVTProjectionKind_Equirectangular))
				return VTProjectionKind.Equirectangular;
			if (constant.IsEqualTo (kVTProjectionKind_HalfEquirectangular))
				return VTProjectionKind.HalfEquirectangular;
			if (constant.IsEqualTo (kVTProjectionKind_ParametricImmersive))
				return VTProjectionKind.ParametricImmersive;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::VideoToolbox.VTProjectionKind" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static VTProjectionKind GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::VideoToolbox.VTProjectionKind" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static VTProjectionKind? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::VideoToolbox.VTProjectionKind" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this VTProjectionKind[]? values)
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
		internal static VTProjectionKind[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<VTProjectionKind> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
