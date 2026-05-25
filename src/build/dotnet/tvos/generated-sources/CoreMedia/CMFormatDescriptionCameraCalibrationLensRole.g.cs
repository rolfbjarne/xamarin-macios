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
namespace CoreMedia {
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	public enum CMFormatDescriptionCameraCalibrationLensRole : int {
		Mono = 0,
		Left = 1,
		Right = 2,
	}
	/// <summary>Extension methods for the <see cref="global::CoreMedia.CMFormatDescriptionCameraCalibrationLensRole" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CMFormatDescriptionCameraCalibrationLensRoleExtensions {
		static IntPtr[] values = new IntPtr [3];
		[Field ("kCMFormatDescriptionCameraCalibrationLensRole_Mono", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionCameraCalibrationLensRole_Mono {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionCameraCalibrationLensRole_Mono", storage);
			}
		}
		[Field ("kCMFormatDescriptionCameraCalibrationLensRole_Left", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionCameraCalibrationLensRole_Left {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionCameraCalibrationLensRole_Left", storage);
			}
		}
		[Field ("kCMFormatDescriptionCameraCalibrationLensRole_Right", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionCameraCalibrationLensRole_Right {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionCameraCalibrationLensRole_Right", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CMFormatDescriptionCameraCalibrationLensRole self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // CMFormatDescriptionCameraCalibrationLensRole.Mono
				ptr = kCMFormatDescriptionCameraCalibrationLensRole_Mono;
				break;
			case 1: // CMFormatDescriptionCameraCalibrationLensRole.Left
				ptr = kCMFormatDescriptionCameraCalibrationLensRole_Left;
				break;
			case 2: // CMFormatDescriptionCameraCalibrationLensRole.Right
				ptr = kCMFormatDescriptionCameraCalibrationLensRole_Right;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMFormatDescriptionCameraCalibrationLensRole" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CMFormatDescriptionCameraCalibrationLensRole GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (kCMFormatDescriptionCameraCalibrationLensRole_Mono))
				return CMFormatDescriptionCameraCalibrationLensRole.Mono;
			if (constant.IsEqualTo (kCMFormatDescriptionCameraCalibrationLensRole_Left))
				return CMFormatDescriptionCameraCalibrationLensRole.Left;
			if (constant.IsEqualTo (kCMFormatDescriptionCameraCalibrationLensRole_Right))
				return CMFormatDescriptionCameraCalibrationLensRole.Right;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMFormatDescriptionCameraCalibrationLensRole" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CMFormatDescriptionCameraCalibrationLensRole GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMFormatDescriptionCameraCalibrationLensRole" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CMFormatDescriptionCameraCalibrationLensRole? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::CoreMedia.CMFormatDescriptionCameraCalibrationLensRole" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CMFormatDescriptionCameraCalibrationLensRole[]? values)
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
		internal static CMFormatDescriptionCameraCalibrationLensRole[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CMFormatDescriptionCameraCalibrationLensRole> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
