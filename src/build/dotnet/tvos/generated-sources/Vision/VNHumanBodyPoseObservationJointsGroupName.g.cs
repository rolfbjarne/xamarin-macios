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
namespace Vision {
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum VNHumanBodyPoseObservationJointsGroupName : int {
		None = 0,
		Face = 1,
		Torso = 2,
		LeftArm = 3,
		RightArm = 4,
		LeftLeg = 5,
		RightLeg = 6,
		All = 7,
	}
	/// <summary>Extension methods for the <see cref="global::Vision.VNHumanBodyPoseObservationJointsGroupName" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class VNHumanBodyPoseObservationJointsGroupNameExtensions {
		static IntPtr[] values = new IntPtr [7];
		[Field ("VNHumanBodyPoseObservationJointsGroupNameFace", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPoseObservationJointsGroupNameFace {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPoseObservationJointsGroupNameFace", storage);
			}
		}
		[Field ("VNHumanBodyPoseObservationJointsGroupNameTorso", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPoseObservationJointsGroupNameTorso {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPoseObservationJointsGroupNameTorso", storage);
			}
		}
		[Field ("VNHumanBodyPoseObservationJointsGroupNameLeftArm", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPoseObservationJointsGroupNameLeftArm {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPoseObservationJointsGroupNameLeftArm", storage);
			}
		}
		[Field ("VNHumanBodyPoseObservationJointsGroupNameRightArm", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPoseObservationJointsGroupNameRightArm {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPoseObservationJointsGroupNameRightArm", storage);
			}
		}
		[Field ("VNHumanBodyPoseObservationJointsGroupNameLeftLeg", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPoseObservationJointsGroupNameLeftLeg {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPoseObservationJointsGroupNameLeftLeg", storage);
			}
		}
		[Field ("VNHumanBodyPoseObservationJointsGroupNameRightLeg", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPoseObservationJointsGroupNameRightLeg {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPoseObservationJointsGroupNameRightLeg", storage);
			}
		}
		[Field ("VNHumanBodyPoseObservationJointsGroupNameAll", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPoseObservationJointsGroupNameAll {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPoseObservationJointsGroupNameAll", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this VNHumanBodyPoseObservationJointsGroupName self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 1: // VNHumanBodyPoseObservationJointsGroupName.Face
				ptr = VNHumanBodyPoseObservationJointsGroupNameFace;
				break;
			case 2: // VNHumanBodyPoseObservationJointsGroupName.Torso
				ptr = VNHumanBodyPoseObservationJointsGroupNameTorso;
				break;
			case 3: // VNHumanBodyPoseObservationJointsGroupName.LeftArm
				ptr = VNHumanBodyPoseObservationJointsGroupNameLeftArm;
				break;
			case 4: // VNHumanBodyPoseObservationJointsGroupName.RightArm
				ptr = VNHumanBodyPoseObservationJointsGroupNameRightArm;
				break;
			case 5: // VNHumanBodyPoseObservationJointsGroupName.LeftLeg
				ptr = VNHumanBodyPoseObservationJointsGroupNameLeftLeg;
				break;
			case 6: // VNHumanBodyPoseObservationJointsGroupName.RightLeg
				ptr = VNHumanBodyPoseObservationJointsGroupNameRightLeg;
				break;
			case 7: // VNHumanBodyPoseObservationJointsGroupName.All
				ptr = VNHumanBodyPoseObservationJointsGroupNameAll;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::Vision.VNHumanBodyPoseObservationJointsGroupName" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static VNHumanBodyPoseObservationJointsGroupName GetValue (NSString? constant)
		{
			if (constant is null)
				return VNHumanBodyPoseObservationJointsGroupName.None;
			if (constant.IsEqualTo (VNHumanBodyPoseObservationJointsGroupNameFace))
				return VNHumanBodyPoseObservationJointsGroupName.Face;
			if (constant.IsEqualTo (VNHumanBodyPoseObservationJointsGroupNameTorso))
				return VNHumanBodyPoseObservationJointsGroupName.Torso;
			if (constant.IsEqualTo (VNHumanBodyPoseObservationJointsGroupNameLeftArm))
				return VNHumanBodyPoseObservationJointsGroupName.LeftArm;
			if (constant.IsEqualTo (VNHumanBodyPoseObservationJointsGroupNameRightArm))
				return VNHumanBodyPoseObservationJointsGroupName.RightArm;
			if (constant.IsEqualTo (VNHumanBodyPoseObservationJointsGroupNameLeftLeg))
				return VNHumanBodyPoseObservationJointsGroupName.LeftLeg;
			if (constant.IsEqualTo (VNHumanBodyPoseObservationJointsGroupNameRightLeg))
				return VNHumanBodyPoseObservationJointsGroupName.RightLeg;
			if (constant.IsEqualTo (VNHumanBodyPoseObservationJointsGroupNameAll))
				return VNHumanBodyPoseObservationJointsGroupName.All;
			return VNHumanBodyPoseObservationJointsGroupName.None;
		}
		/// <summary>Retrieves the <see cref="global::Vision.VNHumanBodyPoseObservationJointsGroupName" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static VNHumanBodyPoseObservationJointsGroupName GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::Vision.VNHumanBodyPoseObservationJointsGroupName" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static VNHumanBodyPoseObservationJointsGroupName? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::Vision.VNHumanBodyPoseObservationJointsGroupName" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this VNHumanBodyPoseObservationJointsGroupName[]? values)
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
		internal static VNHumanBodyPoseObservationJointsGroupName[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<VNHumanBodyPoseObservationJointsGroupName> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
