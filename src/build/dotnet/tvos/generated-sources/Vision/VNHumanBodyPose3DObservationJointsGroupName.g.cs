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
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	public enum VNHumanBodyPose3DObservationJointsGroupName : int {
		None = 0,
		Head = 1,
		Torso = 2,
		LeftArm = 3,
		RightArm = 4,
		LeftLeg = 5,
		RightLeg = 6,
		All = 7,
	}
	/// <summary>Extension methods for the <see cref="global::Vision.VNHumanBodyPose3DObservationJointsGroupName" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class VNHumanBodyPose3DObservationJointsGroupNameExtensions {
		static IntPtr[] values = new IntPtr [7];
		[Field ("VNHumanBodyPose3DObservationJointsGroupNameHead", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPose3DObservationJointsGroupNameHead {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPose3DObservationJointsGroupNameHead", storage);
			}
		}
		[Field ("VNHumanBodyPose3DObservationJointsGroupNameTorso", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPose3DObservationJointsGroupNameTorso {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPose3DObservationJointsGroupNameTorso", storage);
			}
		}
		[Field ("VNHumanBodyPose3DObservationJointsGroupNameLeftArm", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPose3DObservationJointsGroupNameLeftArm {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPose3DObservationJointsGroupNameLeftArm", storage);
			}
		}
		[Field ("VNHumanBodyPose3DObservationJointsGroupNameRightArm", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPose3DObservationJointsGroupNameRightArm {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPose3DObservationJointsGroupNameRightArm", storage);
			}
		}
		[Field ("VNHumanBodyPose3DObservationJointsGroupNameLeftLeg", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPose3DObservationJointsGroupNameLeftLeg {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPose3DObservationJointsGroupNameLeftLeg", storage);
			}
		}
		[Field ("VNHumanBodyPose3DObservationJointsGroupNameRightLeg", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPose3DObservationJointsGroupNameRightLeg {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPose3DObservationJointsGroupNameRightLeg", storage);
			}
		}
		[Field ("VNHumanBodyPose3DObservationJointsGroupNameAll", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPose3DObservationJointsGroupNameAll {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPose3DObservationJointsGroupNameAll", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this VNHumanBodyPose3DObservationJointsGroupName self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 1: // VNHumanBodyPose3DObservationJointsGroupName.Head
				ptr = VNHumanBodyPose3DObservationJointsGroupNameHead;
				break;
			case 2: // VNHumanBodyPose3DObservationJointsGroupName.Torso
				ptr = VNHumanBodyPose3DObservationJointsGroupNameTorso;
				break;
			case 3: // VNHumanBodyPose3DObservationJointsGroupName.LeftArm
				ptr = VNHumanBodyPose3DObservationJointsGroupNameLeftArm;
				break;
			case 4: // VNHumanBodyPose3DObservationJointsGroupName.RightArm
				ptr = VNHumanBodyPose3DObservationJointsGroupNameRightArm;
				break;
			case 5: // VNHumanBodyPose3DObservationJointsGroupName.LeftLeg
				ptr = VNHumanBodyPose3DObservationJointsGroupNameLeftLeg;
				break;
			case 6: // VNHumanBodyPose3DObservationJointsGroupName.RightLeg
				ptr = VNHumanBodyPose3DObservationJointsGroupNameRightLeg;
				break;
			case 7: // VNHumanBodyPose3DObservationJointsGroupName.All
				ptr = VNHumanBodyPose3DObservationJointsGroupNameAll;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::Vision.VNHumanBodyPose3DObservationJointsGroupName" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static VNHumanBodyPose3DObservationJointsGroupName GetValue (NSString? constant)
		{
			if (constant is null)
				return VNHumanBodyPose3DObservationJointsGroupName.None;
			if (constant.IsEqualTo (VNHumanBodyPose3DObservationJointsGroupNameHead))
				return VNHumanBodyPose3DObservationJointsGroupName.Head;
			if (constant.IsEqualTo (VNHumanBodyPose3DObservationJointsGroupNameTorso))
				return VNHumanBodyPose3DObservationJointsGroupName.Torso;
			if (constant.IsEqualTo (VNHumanBodyPose3DObservationJointsGroupNameLeftArm))
				return VNHumanBodyPose3DObservationJointsGroupName.LeftArm;
			if (constant.IsEqualTo (VNHumanBodyPose3DObservationJointsGroupNameRightArm))
				return VNHumanBodyPose3DObservationJointsGroupName.RightArm;
			if (constant.IsEqualTo (VNHumanBodyPose3DObservationJointsGroupNameLeftLeg))
				return VNHumanBodyPose3DObservationJointsGroupName.LeftLeg;
			if (constant.IsEqualTo (VNHumanBodyPose3DObservationJointsGroupNameRightLeg))
				return VNHumanBodyPose3DObservationJointsGroupName.RightLeg;
			if (constant.IsEqualTo (VNHumanBodyPose3DObservationJointsGroupNameAll))
				return VNHumanBodyPose3DObservationJointsGroupName.All;
			return VNHumanBodyPose3DObservationJointsGroupName.None;
		}
		/// <summary>Retrieves the <see cref="global::Vision.VNHumanBodyPose3DObservationJointsGroupName" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static VNHumanBodyPose3DObservationJointsGroupName GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::Vision.VNHumanBodyPose3DObservationJointsGroupName" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static VNHumanBodyPose3DObservationJointsGroupName? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::Vision.VNHumanBodyPose3DObservationJointsGroupName" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this VNHumanBodyPose3DObservationJointsGroupName[]? values)
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
		internal static VNHumanBodyPose3DObservationJointsGroupName[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<VNHumanBodyPose3DObservationJointsGroupName> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
