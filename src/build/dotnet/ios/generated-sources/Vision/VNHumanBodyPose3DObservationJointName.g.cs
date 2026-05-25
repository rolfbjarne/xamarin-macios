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
namespace Vision {
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	public enum VNHumanBodyPose3DObservationJointName : int {
		None = 0,
		Root = 1,
		RightHip = 2,
		RightKnee = 3,
		RightAnkle = 4,
		RightShoulder = 5,
		LeftHip = 6,
		LeftKnee = 7,
		LeftAnkle = 8,
		Spine = 9,
		CenterShoulder = 10,
		CenterHead = 11,
		TopHead = 12,
		LeftShoulder = 13,
		LeftElbow = 14,
		LeftWrist = 15,
		RightElbow = 16,
		RightWrist = 17,
	}
	/// <summary>Extension methods for the <see cref="global::Vision.VNHumanBodyPose3DObservationJointName" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class VNHumanBodyPose3DObservationJointNameExtensions {
		static IntPtr[] values = new IntPtr [17];
		[Field ("VNHumanBodyPose3DObservationJointNameRoot", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPose3DObservationJointNameRoot {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPose3DObservationJointNameRoot", storage);
			}
		}
		[Field ("VNHumanBodyPose3DObservationJointNameRightHip", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPose3DObservationJointNameRightHip {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPose3DObservationJointNameRightHip", storage);
			}
		}
		[Field ("VNHumanBodyPose3DObservationJointNameRightKnee", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPose3DObservationJointNameRightKnee {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPose3DObservationJointNameRightKnee", storage);
			}
		}
		[Field ("VNHumanBodyPose3DObservationJointNameRightAnkle", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPose3DObservationJointNameRightAnkle {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPose3DObservationJointNameRightAnkle", storage);
			}
		}
		[Field ("VNHumanBodyPose3DObservationJointNameRightShoulder", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPose3DObservationJointNameRightShoulder {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPose3DObservationJointNameRightShoulder", storage);
			}
		}
		[Field ("VNHumanBodyPose3DObservationJointNameLeftHip", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPose3DObservationJointNameLeftHip {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPose3DObservationJointNameLeftHip", storage);
			}
		}
		[Field ("VNHumanBodyPose3DObservationJointNameLeftKnee", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPose3DObservationJointNameLeftKnee {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPose3DObservationJointNameLeftKnee", storage);
			}
		}
		[Field ("VNHumanBodyPose3DObservationJointNameLeftAnkle", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPose3DObservationJointNameLeftAnkle {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPose3DObservationJointNameLeftAnkle", storage);
			}
		}
		[Field ("VNHumanBodyPose3DObservationJointNameSpine", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPose3DObservationJointNameSpine {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPose3DObservationJointNameSpine", storage);
			}
		}
		[Field ("VNHumanBodyPose3DObservationJointNameCenterShoulder", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPose3DObservationJointNameCenterShoulder {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPose3DObservationJointNameCenterShoulder", storage);
			}
		}
		[Field ("VNHumanBodyPose3DObservationJointNameCenterHead", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPose3DObservationJointNameCenterHead {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPose3DObservationJointNameCenterHead", storage);
			}
		}
		[Field ("VNHumanBodyPose3DObservationJointNameTopHead", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPose3DObservationJointNameTopHead {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPose3DObservationJointNameTopHead", storage);
			}
		}
		[Field ("VNHumanBodyPose3DObservationJointNameLeftShoulder", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPose3DObservationJointNameLeftShoulder {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPose3DObservationJointNameLeftShoulder", storage);
			}
		}
		[Field ("VNHumanBodyPose3DObservationJointNameLeftElbow", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPose3DObservationJointNameLeftElbow {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPose3DObservationJointNameLeftElbow", storage);
			}
		}
		[Field ("VNHumanBodyPose3DObservationJointNameLeftWrist", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPose3DObservationJointNameLeftWrist {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPose3DObservationJointNameLeftWrist", storage);
			}
		}
		[Field ("VNHumanBodyPose3DObservationJointNameRightElbow", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPose3DObservationJointNameRightElbow {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPose3DObservationJointNameRightElbow", storage);
			}
		}
		[Field ("VNHumanBodyPose3DObservationJointNameRightWrist", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPose3DObservationJointNameRightWrist {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPose3DObservationJointNameRightWrist", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this VNHumanBodyPose3DObservationJointName self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 1: // VNHumanBodyPose3DObservationJointName.Root
				ptr = VNHumanBodyPose3DObservationJointNameRoot;
				break;
			case 2: // VNHumanBodyPose3DObservationJointName.RightHip
				ptr = VNHumanBodyPose3DObservationJointNameRightHip;
				break;
			case 3: // VNHumanBodyPose3DObservationJointName.RightKnee
				ptr = VNHumanBodyPose3DObservationJointNameRightKnee;
				break;
			case 4: // VNHumanBodyPose3DObservationJointName.RightAnkle
				ptr = VNHumanBodyPose3DObservationJointNameRightAnkle;
				break;
			case 5: // VNHumanBodyPose3DObservationJointName.RightShoulder
				ptr = VNHumanBodyPose3DObservationJointNameRightShoulder;
				break;
			case 6: // VNHumanBodyPose3DObservationJointName.LeftHip
				ptr = VNHumanBodyPose3DObservationJointNameLeftHip;
				break;
			case 7: // VNHumanBodyPose3DObservationJointName.LeftKnee
				ptr = VNHumanBodyPose3DObservationJointNameLeftKnee;
				break;
			case 8: // VNHumanBodyPose3DObservationJointName.LeftAnkle
				ptr = VNHumanBodyPose3DObservationJointNameLeftAnkle;
				break;
			case 9: // VNHumanBodyPose3DObservationJointName.Spine
				ptr = VNHumanBodyPose3DObservationJointNameSpine;
				break;
			case 10: // VNHumanBodyPose3DObservationJointName.CenterShoulder
				ptr = VNHumanBodyPose3DObservationJointNameCenterShoulder;
				break;
			case 11: // VNHumanBodyPose3DObservationJointName.CenterHead
				ptr = VNHumanBodyPose3DObservationJointNameCenterHead;
				break;
			case 12: // VNHumanBodyPose3DObservationJointName.TopHead
				ptr = VNHumanBodyPose3DObservationJointNameTopHead;
				break;
			case 13: // VNHumanBodyPose3DObservationJointName.LeftShoulder
				ptr = VNHumanBodyPose3DObservationJointNameLeftShoulder;
				break;
			case 14: // VNHumanBodyPose3DObservationJointName.LeftElbow
				ptr = VNHumanBodyPose3DObservationJointNameLeftElbow;
				break;
			case 15: // VNHumanBodyPose3DObservationJointName.LeftWrist
				ptr = VNHumanBodyPose3DObservationJointNameLeftWrist;
				break;
			case 16: // VNHumanBodyPose3DObservationJointName.RightElbow
				ptr = VNHumanBodyPose3DObservationJointNameRightElbow;
				break;
			case 17: // VNHumanBodyPose3DObservationJointName.RightWrist
				ptr = VNHumanBodyPose3DObservationJointNameRightWrist;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::Vision.VNHumanBodyPose3DObservationJointName" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static VNHumanBodyPose3DObservationJointName GetValue (NSString? constant)
		{
			if (constant is null)
				return VNHumanBodyPose3DObservationJointName.None;
			if (constant.IsEqualTo (VNHumanBodyPose3DObservationJointNameRoot))
				return VNHumanBodyPose3DObservationJointName.Root;
			if (constant.IsEqualTo (VNHumanBodyPose3DObservationJointNameRightHip))
				return VNHumanBodyPose3DObservationJointName.RightHip;
			if (constant.IsEqualTo (VNHumanBodyPose3DObservationJointNameRightKnee))
				return VNHumanBodyPose3DObservationJointName.RightKnee;
			if (constant.IsEqualTo (VNHumanBodyPose3DObservationJointNameRightAnkle))
				return VNHumanBodyPose3DObservationJointName.RightAnkle;
			if (constant.IsEqualTo (VNHumanBodyPose3DObservationJointNameRightShoulder))
				return VNHumanBodyPose3DObservationJointName.RightShoulder;
			if (constant.IsEqualTo (VNHumanBodyPose3DObservationJointNameLeftHip))
				return VNHumanBodyPose3DObservationJointName.LeftHip;
			if (constant.IsEqualTo (VNHumanBodyPose3DObservationJointNameLeftKnee))
				return VNHumanBodyPose3DObservationJointName.LeftKnee;
			if (constant.IsEqualTo (VNHumanBodyPose3DObservationJointNameLeftAnkle))
				return VNHumanBodyPose3DObservationJointName.LeftAnkle;
			if (constant.IsEqualTo (VNHumanBodyPose3DObservationJointNameSpine))
				return VNHumanBodyPose3DObservationJointName.Spine;
			if (constant.IsEqualTo (VNHumanBodyPose3DObservationJointNameCenterShoulder))
				return VNHumanBodyPose3DObservationJointName.CenterShoulder;
			if (constant.IsEqualTo (VNHumanBodyPose3DObservationJointNameCenterHead))
				return VNHumanBodyPose3DObservationJointName.CenterHead;
			if (constant.IsEqualTo (VNHumanBodyPose3DObservationJointNameTopHead))
				return VNHumanBodyPose3DObservationJointName.TopHead;
			if (constant.IsEqualTo (VNHumanBodyPose3DObservationJointNameLeftShoulder))
				return VNHumanBodyPose3DObservationJointName.LeftShoulder;
			if (constant.IsEqualTo (VNHumanBodyPose3DObservationJointNameLeftElbow))
				return VNHumanBodyPose3DObservationJointName.LeftElbow;
			if (constant.IsEqualTo (VNHumanBodyPose3DObservationJointNameLeftWrist))
				return VNHumanBodyPose3DObservationJointName.LeftWrist;
			if (constant.IsEqualTo (VNHumanBodyPose3DObservationJointNameRightElbow))
				return VNHumanBodyPose3DObservationJointName.RightElbow;
			if (constant.IsEqualTo (VNHumanBodyPose3DObservationJointNameRightWrist))
				return VNHumanBodyPose3DObservationJointName.RightWrist;
			return VNHumanBodyPose3DObservationJointName.None;
		}
		/// <summary>Retrieves the <see cref="global::Vision.VNHumanBodyPose3DObservationJointName" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static VNHumanBodyPose3DObservationJointName GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::Vision.VNHumanBodyPose3DObservationJointName" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static VNHumanBodyPose3DObservationJointName? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::Vision.VNHumanBodyPose3DObservationJointName" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this VNHumanBodyPose3DObservationJointName[]? values)
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
		internal static VNHumanBodyPose3DObservationJointName[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<VNHumanBodyPose3DObservationJointName> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
