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
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum VNHumanBodyPoseObservationJointName : int {
		None = 0,
		Nose = 1,
		LeftEye = 2,
		RightEye = 3,
		LeftEar = 4,
		RightEar = 5,
		LeftShoulder = 6,
		RightShoulder = 7,
		Neck = 8,
		LeftElbow = 9,
		RightElbow = 10,
		LeftWrist = 11,
		RightWrist = 12,
		LeftHip = 13,
		RightHip = 14,
		Root = 15,
		LeftKnee = 16,
		RightKnee = 17,
		LeftAnkle = 18,
		RightAnkle = 19,
	}
	/// <summary>Extension methods for the <see cref="global::Vision.VNHumanBodyPoseObservationJointName" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class VNHumanBodyPoseObservationJointNameExtensions {
		static IntPtr[] values = new IntPtr [19];
		[Field ("VNHumanBodyPoseObservationJointNameNose", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPoseObservationJointNameNose {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPoseObservationJointNameNose", storage);
			}
		}
		[Field ("VNHumanBodyPoseObservationJointNameLeftEye", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPoseObservationJointNameLeftEye {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPoseObservationJointNameLeftEye", storage);
			}
		}
		[Field ("VNHumanBodyPoseObservationJointNameRightEye", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPoseObservationJointNameRightEye {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPoseObservationJointNameRightEye", storage);
			}
		}
		[Field ("VNHumanBodyPoseObservationJointNameLeftEar", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPoseObservationJointNameLeftEar {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPoseObservationJointNameLeftEar", storage);
			}
		}
		[Field ("VNHumanBodyPoseObservationJointNameRightEar", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPoseObservationJointNameRightEar {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPoseObservationJointNameRightEar", storage);
			}
		}
		[Field ("VNHumanBodyPoseObservationJointNameLeftShoulder", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPoseObservationJointNameLeftShoulder {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPoseObservationJointNameLeftShoulder", storage);
			}
		}
		[Field ("VNHumanBodyPoseObservationJointNameRightShoulder", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPoseObservationJointNameRightShoulder {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPoseObservationJointNameRightShoulder", storage);
			}
		}
		[Field ("VNHumanBodyPoseObservationJointNameNeck", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPoseObservationJointNameNeck {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPoseObservationJointNameNeck", storage);
			}
		}
		[Field ("VNHumanBodyPoseObservationJointNameLeftElbow", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPoseObservationJointNameLeftElbow {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPoseObservationJointNameLeftElbow", storage);
			}
		}
		[Field ("VNHumanBodyPoseObservationJointNameRightElbow", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPoseObservationJointNameRightElbow {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPoseObservationJointNameRightElbow", storage);
			}
		}
		[Field ("VNHumanBodyPoseObservationJointNameLeftWrist", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPoseObservationJointNameLeftWrist {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPoseObservationJointNameLeftWrist", storage);
			}
		}
		[Field ("VNHumanBodyPoseObservationJointNameRightWrist", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPoseObservationJointNameRightWrist {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPoseObservationJointNameRightWrist", storage);
			}
		}
		[Field ("VNHumanBodyPoseObservationJointNameLeftHip", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPoseObservationJointNameLeftHip {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPoseObservationJointNameLeftHip", storage);
			}
		}
		[Field ("VNHumanBodyPoseObservationJointNameRightHip", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPoseObservationJointNameRightHip {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPoseObservationJointNameRightHip", storage);
			}
		}
		[Field ("VNHumanBodyPoseObservationJointNameRoot", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPoseObservationJointNameRoot {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPoseObservationJointNameRoot", storage);
			}
		}
		[Field ("VNHumanBodyPoseObservationJointNameLeftKnee", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPoseObservationJointNameLeftKnee {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPoseObservationJointNameLeftKnee", storage);
			}
		}
		[Field ("VNHumanBodyPoseObservationJointNameRightKnee", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPoseObservationJointNameRightKnee {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPoseObservationJointNameRightKnee", storage);
			}
		}
		[Field ("VNHumanBodyPoseObservationJointNameLeftAnkle", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPoseObservationJointNameLeftAnkle {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPoseObservationJointNameLeftAnkle", storage);
			}
		}
		[Field ("VNHumanBodyPoseObservationJointNameRightAnkle", "Vision")]
		internal unsafe static IntPtr VNHumanBodyPoseObservationJointNameRightAnkle {
			get {
				fixed (IntPtr *storage = &values [18])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanBodyPoseObservationJointNameRightAnkle", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this VNHumanBodyPoseObservationJointName self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 1: // VNHumanBodyPoseObservationJointName.Nose
				ptr = VNHumanBodyPoseObservationJointNameNose;
				break;
			case 2: // VNHumanBodyPoseObservationJointName.LeftEye
				ptr = VNHumanBodyPoseObservationJointNameLeftEye;
				break;
			case 3: // VNHumanBodyPoseObservationJointName.RightEye
				ptr = VNHumanBodyPoseObservationJointNameRightEye;
				break;
			case 4: // VNHumanBodyPoseObservationJointName.LeftEar
				ptr = VNHumanBodyPoseObservationJointNameLeftEar;
				break;
			case 5: // VNHumanBodyPoseObservationJointName.RightEar
				ptr = VNHumanBodyPoseObservationJointNameRightEar;
				break;
			case 6: // VNHumanBodyPoseObservationJointName.LeftShoulder
				ptr = VNHumanBodyPoseObservationJointNameLeftShoulder;
				break;
			case 7: // VNHumanBodyPoseObservationJointName.RightShoulder
				ptr = VNHumanBodyPoseObservationJointNameRightShoulder;
				break;
			case 8: // VNHumanBodyPoseObservationJointName.Neck
				ptr = VNHumanBodyPoseObservationJointNameNeck;
				break;
			case 9: // VNHumanBodyPoseObservationJointName.LeftElbow
				ptr = VNHumanBodyPoseObservationJointNameLeftElbow;
				break;
			case 10: // VNHumanBodyPoseObservationJointName.RightElbow
				ptr = VNHumanBodyPoseObservationJointNameRightElbow;
				break;
			case 11: // VNHumanBodyPoseObservationJointName.LeftWrist
				ptr = VNHumanBodyPoseObservationJointNameLeftWrist;
				break;
			case 12: // VNHumanBodyPoseObservationJointName.RightWrist
				ptr = VNHumanBodyPoseObservationJointNameRightWrist;
				break;
			case 13: // VNHumanBodyPoseObservationJointName.LeftHip
				ptr = VNHumanBodyPoseObservationJointNameLeftHip;
				break;
			case 14: // VNHumanBodyPoseObservationJointName.RightHip
				ptr = VNHumanBodyPoseObservationJointNameRightHip;
				break;
			case 15: // VNHumanBodyPoseObservationJointName.Root
				ptr = VNHumanBodyPoseObservationJointNameRoot;
				break;
			case 16: // VNHumanBodyPoseObservationJointName.LeftKnee
				ptr = VNHumanBodyPoseObservationJointNameLeftKnee;
				break;
			case 17: // VNHumanBodyPoseObservationJointName.RightKnee
				ptr = VNHumanBodyPoseObservationJointNameRightKnee;
				break;
			case 18: // VNHumanBodyPoseObservationJointName.LeftAnkle
				ptr = VNHumanBodyPoseObservationJointNameLeftAnkle;
				break;
			case 19: // VNHumanBodyPoseObservationJointName.RightAnkle
				ptr = VNHumanBodyPoseObservationJointNameRightAnkle;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::Vision.VNHumanBodyPoseObservationJointName" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static VNHumanBodyPoseObservationJointName GetValue (NSString? constant)
		{
			if (constant is null)
				return VNHumanBodyPoseObservationJointName.None;
			if (constant.IsEqualTo (VNHumanBodyPoseObservationJointNameNose))
				return VNHumanBodyPoseObservationJointName.Nose;
			if (constant.IsEqualTo (VNHumanBodyPoseObservationJointNameLeftEye))
				return VNHumanBodyPoseObservationJointName.LeftEye;
			if (constant.IsEqualTo (VNHumanBodyPoseObservationJointNameRightEye))
				return VNHumanBodyPoseObservationJointName.RightEye;
			if (constant.IsEqualTo (VNHumanBodyPoseObservationJointNameLeftEar))
				return VNHumanBodyPoseObservationJointName.LeftEar;
			if (constant.IsEqualTo (VNHumanBodyPoseObservationJointNameRightEar))
				return VNHumanBodyPoseObservationJointName.RightEar;
			if (constant.IsEqualTo (VNHumanBodyPoseObservationJointNameLeftShoulder))
				return VNHumanBodyPoseObservationJointName.LeftShoulder;
			if (constant.IsEqualTo (VNHumanBodyPoseObservationJointNameRightShoulder))
				return VNHumanBodyPoseObservationJointName.RightShoulder;
			if (constant.IsEqualTo (VNHumanBodyPoseObservationJointNameNeck))
				return VNHumanBodyPoseObservationJointName.Neck;
			if (constant.IsEqualTo (VNHumanBodyPoseObservationJointNameLeftElbow))
				return VNHumanBodyPoseObservationJointName.LeftElbow;
			if (constant.IsEqualTo (VNHumanBodyPoseObservationJointNameRightElbow))
				return VNHumanBodyPoseObservationJointName.RightElbow;
			if (constant.IsEqualTo (VNHumanBodyPoseObservationJointNameLeftWrist))
				return VNHumanBodyPoseObservationJointName.LeftWrist;
			if (constant.IsEqualTo (VNHumanBodyPoseObservationJointNameRightWrist))
				return VNHumanBodyPoseObservationJointName.RightWrist;
			if (constant.IsEqualTo (VNHumanBodyPoseObservationJointNameLeftHip))
				return VNHumanBodyPoseObservationJointName.LeftHip;
			if (constant.IsEqualTo (VNHumanBodyPoseObservationJointNameRightHip))
				return VNHumanBodyPoseObservationJointName.RightHip;
			if (constant.IsEqualTo (VNHumanBodyPoseObservationJointNameRoot))
				return VNHumanBodyPoseObservationJointName.Root;
			if (constant.IsEqualTo (VNHumanBodyPoseObservationJointNameLeftKnee))
				return VNHumanBodyPoseObservationJointName.LeftKnee;
			if (constant.IsEqualTo (VNHumanBodyPoseObservationJointNameRightKnee))
				return VNHumanBodyPoseObservationJointName.RightKnee;
			if (constant.IsEqualTo (VNHumanBodyPoseObservationJointNameLeftAnkle))
				return VNHumanBodyPoseObservationJointName.LeftAnkle;
			if (constant.IsEqualTo (VNHumanBodyPoseObservationJointNameRightAnkle))
				return VNHumanBodyPoseObservationJointName.RightAnkle;
			return VNHumanBodyPoseObservationJointName.None;
		}
		/// <summary>Retrieves the <see cref="global::Vision.VNHumanBodyPoseObservationJointName" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static VNHumanBodyPoseObservationJointName GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::Vision.VNHumanBodyPoseObservationJointName" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static VNHumanBodyPoseObservationJointName? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::Vision.VNHumanBodyPoseObservationJointName" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this VNHumanBodyPoseObservationJointName[]? values)
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
		internal static VNHumanBodyPoseObservationJointName[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<VNHumanBodyPoseObservationJointName> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
