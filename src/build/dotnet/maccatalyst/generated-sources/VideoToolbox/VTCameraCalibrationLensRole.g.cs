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
namespace VideoToolbox {
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	public enum VTCameraCalibrationLensRole : int {
		Mono = 0,
		Left = 1,
		Right = 2,
	}
	/// <summary>Extension methods for the <see cref="global::VideoToolbox.VTCameraCalibrationLensRole" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class VTCameraCalibrationLensRoleExtensions {
		static IntPtr[] values = new IntPtr [3];
		[Field ("kVTCameraCalibrationLensRole_Mono", "VideoToolbox")]
		internal unsafe static IntPtr kVTCameraCalibrationLensRole_Mono {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.VideoToolbox.Handle, "kVTCameraCalibrationLensRole_Mono", storage);
			}
		}
		[Field ("kVTCameraCalibrationLensRole_Left", "VideoToolbox")]
		internal unsafe static IntPtr kVTCameraCalibrationLensRole_Left {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.VideoToolbox.Handle, "kVTCameraCalibrationLensRole_Left", storage);
			}
		}
		[Field ("kVTCameraCalibrationLensRole_Right", "VideoToolbox")]
		internal unsafe static IntPtr kVTCameraCalibrationLensRole_Right {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.VideoToolbox.Handle, "kVTCameraCalibrationLensRole_Right", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this VTCameraCalibrationLensRole self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // VTCameraCalibrationLensRole.Mono
				ptr = kVTCameraCalibrationLensRole_Mono;
				break;
			case 1: // VTCameraCalibrationLensRole.Left
				ptr = kVTCameraCalibrationLensRole_Left;
				break;
			case 2: // VTCameraCalibrationLensRole.Right
				ptr = kVTCameraCalibrationLensRole_Right;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::VideoToolbox.VTCameraCalibrationLensRole" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static VTCameraCalibrationLensRole GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (kVTCameraCalibrationLensRole_Mono))
				return VTCameraCalibrationLensRole.Mono;
			if (constant.IsEqualTo (kVTCameraCalibrationLensRole_Left))
				return VTCameraCalibrationLensRole.Left;
			if (constant.IsEqualTo (kVTCameraCalibrationLensRole_Right))
				return VTCameraCalibrationLensRole.Right;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::VideoToolbox.VTCameraCalibrationLensRole" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static VTCameraCalibrationLensRole GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::VideoToolbox.VTCameraCalibrationLensRole" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static VTCameraCalibrationLensRole? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::VideoToolbox.VTCameraCalibrationLensRole" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this VTCameraCalibrationLensRole[]? values)
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
		internal static VTCameraCalibrationLensRole[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<VTCameraCalibrationLensRole> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
