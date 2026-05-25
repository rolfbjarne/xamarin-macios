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
namespace Vision {
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum VNHumanHandPoseObservationJointsGroupName : int {
		None = 0,
		Thumb = 1,
		IndexFinger = 2,
		MiddleFinger = 3,
		RingFinger = 4,
		LittleFinger = 5,
		All = 6,
	}
	/// <summary>Extension methods for the <see cref="global::Vision.VNHumanHandPoseObservationJointsGroupName" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class VNHumanHandPoseObservationJointsGroupNameExtensions {
		static IntPtr[] values = new IntPtr [6];
		[Field ("VNHumanHandPoseObservationJointsGroupNameThumb", "Vision")]
		internal unsafe static IntPtr VNHumanHandPoseObservationJointsGroupNameThumb {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanHandPoseObservationJointsGroupNameThumb", storage);
			}
		}
		[Field ("VNHumanHandPoseObservationJointsGroupNameIndexFinger", "Vision")]
		internal unsafe static IntPtr VNHumanHandPoseObservationJointsGroupNameIndexFinger {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanHandPoseObservationJointsGroupNameIndexFinger", storage);
			}
		}
		[Field ("VNHumanHandPoseObservationJointsGroupNameMiddleFinger", "Vision")]
		internal unsafe static IntPtr VNHumanHandPoseObservationJointsGroupNameMiddleFinger {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanHandPoseObservationJointsGroupNameMiddleFinger", storage);
			}
		}
		[Field ("VNHumanHandPoseObservationJointsGroupNameRingFinger", "Vision")]
		internal unsafe static IntPtr VNHumanHandPoseObservationJointsGroupNameRingFinger {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanHandPoseObservationJointsGroupNameRingFinger", storage);
			}
		}
		[Field ("VNHumanHandPoseObservationJointsGroupNameLittleFinger", "Vision")]
		internal unsafe static IntPtr VNHumanHandPoseObservationJointsGroupNameLittleFinger {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanHandPoseObservationJointsGroupNameLittleFinger", storage);
			}
		}
		[Field ("VNHumanHandPoseObservationJointsGroupNameAll", "Vision")]
		internal unsafe static IntPtr VNHumanHandPoseObservationJointsGroupNameAll {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanHandPoseObservationJointsGroupNameAll", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this VNHumanHandPoseObservationJointsGroupName self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 1: // VNHumanHandPoseObservationJointsGroupName.Thumb
				ptr = VNHumanHandPoseObservationJointsGroupNameThumb;
				break;
			case 2: // VNHumanHandPoseObservationJointsGroupName.IndexFinger
				ptr = VNHumanHandPoseObservationJointsGroupNameIndexFinger;
				break;
			case 3: // VNHumanHandPoseObservationJointsGroupName.MiddleFinger
				ptr = VNHumanHandPoseObservationJointsGroupNameMiddleFinger;
				break;
			case 4: // VNHumanHandPoseObservationJointsGroupName.RingFinger
				ptr = VNHumanHandPoseObservationJointsGroupNameRingFinger;
				break;
			case 5: // VNHumanHandPoseObservationJointsGroupName.LittleFinger
				ptr = VNHumanHandPoseObservationJointsGroupNameLittleFinger;
				break;
			case 6: // VNHumanHandPoseObservationJointsGroupName.All
				ptr = VNHumanHandPoseObservationJointsGroupNameAll;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::Vision.VNHumanHandPoseObservationJointsGroupName" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static VNHumanHandPoseObservationJointsGroupName GetValue (NSString? constant)
		{
			if (constant is null)
				return VNHumanHandPoseObservationJointsGroupName.None;
			if (constant.IsEqualTo (VNHumanHandPoseObservationJointsGroupNameThumb))
				return VNHumanHandPoseObservationJointsGroupName.Thumb;
			if (constant.IsEqualTo (VNHumanHandPoseObservationJointsGroupNameIndexFinger))
				return VNHumanHandPoseObservationJointsGroupName.IndexFinger;
			if (constant.IsEqualTo (VNHumanHandPoseObservationJointsGroupNameMiddleFinger))
				return VNHumanHandPoseObservationJointsGroupName.MiddleFinger;
			if (constant.IsEqualTo (VNHumanHandPoseObservationJointsGroupNameRingFinger))
				return VNHumanHandPoseObservationJointsGroupName.RingFinger;
			if (constant.IsEqualTo (VNHumanHandPoseObservationJointsGroupNameLittleFinger))
				return VNHumanHandPoseObservationJointsGroupName.LittleFinger;
			if (constant.IsEqualTo (VNHumanHandPoseObservationJointsGroupNameAll))
				return VNHumanHandPoseObservationJointsGroupName.All;
			return VNHumanHandPoseObservationJointsGroupName.None;
		}
		/// <summary>Retrieves the <see cref="global::Vision.VNHumanHandPoseObservationJointsGroupName" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static VNHumanHandPoseObservationJointsGroupName GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::Vision.VNHumanHandPoseObservationJointsGroupName" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static VNHumanHandPoseObservationJointsGroupName? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::Vision.VNHumanHandPoseObservationJointsGroupName" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this VNHumanHandPoseObservationJointsGroupName[]? values)
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
		internal static VNHumanHandPoseObservationJointsGroupName[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<VNHumanHandPoseObservationJointsGroupName> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
