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
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	public enum VNAnimalBodyPoseObservationJointName : int {
		None = 0,
		LeftEarTop = 1,
		RightEarTop = 2,
		LeftEarMiddle = 3,
		RightEarMiddle = 4,
		LeftEarBottom = 5,
		RightEarBottom = 6,
		LeftEye = 7,
		RightEye = 8,
		Nose = 9,
		Neck = 10,
		LeftFrontElbow = 11,
		RightFrontElbow = 12,
		LeftFrontKnee = 13,
		RightFrontKnee = 14,
		LeftFrontPaw = 15,
		RightFrontPaw = 16,
		LeftBackElbow = 17,
		RightBackElbow = 18,
		LeftBackKnee = 19,
		RightBackKnee = 20,
		LeftBackPaw = 21,
		RightBackPaw = 22,
		TailTop = 23,
		TailMiddle = 24,
		TailBottom = 25,
	}
	/// <summary>Extension methods for the <see cref="global::Vision.VNAnimalBodyPoseObservationJointName" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class VNAnimalBodyPoseObservationJointNameExtensions {
		static IntPtr[] values = new IntPtr [25];
		[Field ("VNAnimalBodyPoseObservationJointNameLeftEarTop", "Vision")]
		internal unsafe static IntPtr VNAnimalBodyPoseObservationJointNameLeftEarTop {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNAnimalBodyPoseObservationJointNameLeftEarTop", storage);
			}
		}
		[Field ("VNAnimalBodyPoseObservationJointNameRightEarTop", "Vision")]
		internal unsafe static IntPtr VNAnimalBodyPoseObservationJointNameRightEarTop {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNAnimalBodyPoseObservationJointNameRightEarTop", storage);
			}
		}
		[Field ("VNAnimalBodyPoseObservationJointNameLeftEarMiddle", "Vision")]
		internal unsafe static IntPtr VNAnimalBodyPoseObservationJointNameLeftEarMiddle {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNAnimalBodyPoseObservationJointNameLeftEarMiddle", storage);
			}
		}
		[Field ("VNAnimalBodyPoseObservationJointNameRightEarMiddle", "Vision")]
		internal unsafe static IntPtr VNAnimalBodyPoseObservationJointNameRightEarMiddle {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNAnimalBodyPoseObservationJointNameRightEarMiddle", storage);
			}
		}
		[Field ("VNAnimalBodyPoseObservationJointNameLeftEarBottom", "Vision")]
		internal unsafe static IntPtr VNAnimalBodyPoseObservationJointNameLeftEarBottom {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNAnimalBodyPoseObservationJointNameLeftEarBottom", storage);
			}
		}
		[Field ("VNAnimalBodyPoseObservationJointNameRightEarBottom", "Vision")]
		internal unsafe static IntPtr VNAnimalBodyPoseObservationJointNameRightEarBottom {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNAnimalBodyPoseObservationJointNameRightEarBottom", storage);
			}
		}
		[Field ("VNAnimalBodyPoseObservationJointNameLeftEye", "Vision")]
		internal unsafe static IntPtr VNAnimalBodyPoseObservationJointNameLeftEye {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNAnimalBodyPoseObservationJointNameLeftEye", storage);
			}
		}
		[Field ("VNAnimalBodyPoseObservationJointNameRightEye", "Vision")]
		internal unsafe static IntPtr VNAnimalBodyPoseObservationJointNameRightEye {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNAnimalBodyPoseObservationJointNameRightEye", storage);
			}
		}
		[Field ("VNAnimalBodyPoseObservationJointNameNose", "Vision")]
		internal unsafe static IntPtr VNAnimalBodyPoseObservationJointNameNose {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNAnimalBodyPoseObservationJointNameNose", storage);
			}
		}
		[Field ("VNAnimalBodyPoseObservationJointNameNeck", "Vision")]
		internal unsafe static IntPtr VNAnimalBodyPoseObservationJointNameNeck {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNAnimalBodyPoseObservationJointNameNeck", storage);
			}
		}
		[Field ("VNAnimalBodyPoseObservationJointNameLeftFrontElbow", "Vision")]
		internal unsafe static IntPtr VNAnimalBodyPoseObservationJointNameLeftFrontElbow {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNAnimalBodyPoseObservationJointNameLeftFrontElbow", storage);
			}
		}
		[Field ("VNAnimalBodyPoseObservationJointNameRightFrontElbow", "Vision")]
		internal unsafe static IntPtr VNAnimalBodyPoseObservationJointNameRightFrontElbow {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNAnimalBodyPoseObservationJointNameRightFrontElbow", storage);
			}
		}
		[Field ("VNAnimalBodyPoseObservationJointNameLeftFrontKnee", "Vision")]
		internal unsafe static IntPtr VNAnimalBodyPoseObservationJointNameLeftFrontKnee {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNAnimalBodyPoseObservationJointNameLeftFrontKnee", storage);
			}
		}
		[Field ("VNAnimalBodyPoseObservationJointNameRightFrontKnee", "Vision")]
		internal unsafe static IntPtr VNAnimalBodyPoseObservationJointNameRightFrontKnee {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNAnimalBodyPoseObservationJointNameRightFrontKnee", storage);
			}
		}
		[Field ("VNAnimalBodyPoseObservationJointNameLeftFrontPaw", "Vision")]
		internal unsafe static IntPtr VNAnimalBodyPoseObservationJointNameLeftFrontPaw {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNAnimalBodyPoseObservationJointNameLeftFrontPaw", storage);
			}
		}
		[Field ("VNAnimalBodyPoseObservationJointNameRightFrontPaw", "Vision")]
		internal unsafe static IntPtr VNAnimalBodyPoseObservationJointNameRightFrontPaw {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNAnimalBodyPoseObservationJointNameRightFrontPaw", storage);
			}
		}
		[Field ("VNAnimalBodyPoseObservationJointNameLeftBackElbow", "Vision")]
		internal unsafe static IntPtr VNAnimalBodyPoseObservationJointNameLeftBackElbow {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNAnimalBodyPoseObservationJointNameLeftBackElbow", storage);
			}
		}
		[Field ("VNAnimalBodyPoseObservationJointNameRightBackElbow", "Vision")]
		internal unsafe static IntPtr VNAnimalBodyPoseObservationJointNameRightBackElbow {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNAnimalBodyPoseObservationJointNameRightBackElbow", storage);
			}
		}
		[Field ("VNAnimalBodyPoseObservationJointNameLeftBackKnee", "Vision")]
		internal unsafe static IntPtr VNAnimalBodyPoseObservationJointNameLeftBackKnee {
			get {
				fixed (IntPtr *storage = &values [18])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNAnimalBodyPoseObservationJointNameLeftBackKnee", storage);
			}
		}
		[Field ("VNAnimalBodyPoseObservationJointNameRightBackKnee", "Vision")]
		internal unsafe static IntPtr VNAnimalBodyPoseObservationJointNameRightBackKnee {
			get {
				fixed (IntPtr *storage = &values [19])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNAnimalBodyPoseObservationJointNameRightBackKnee", storage);
			}
		}
		[Field ("VNAnimalBodyPoseObservationJointNameLeftBackPaw", "Vision")]
		internal unsafe static IntPtr VNAnimalBodyPoseObservationJointNameLeftBackPaw {
			get {
				fixed (IntPtr *storage = &values [20])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNAnimalBodyPoseObservationJointNameLeftBackPaw", storage);
			}
		}
		[Field ("VNAnimalBodyPoseObservationJointNameRightBackPaw", "Vision")]
		internal unsafe static IntPtr VNAnimalBodyPoseObservationJointNameRightBackPaw {
			get {
				fixed (IntPtr *storage = &values [21])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNAnimalBodyPoseObservationJointNameRightBackPaw", storage);
			}
		}
		[Field ("VNAnimalBodyPoseObservationJointNameTailTop", "Vision")]
		internal unsafe static IntPtr VNAnimalBodyPoseObservationJointNameTailTop {
			get {
				fixed (IntPtr *storage = &values [22])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNAnimalBodyPoseObservationJointNameTailTop", storage);
			}
		}
		[Field ("VNAnimalBodyPoseObservationJointNameTailMiddle", "Vision")]
		internal unsafe static IntPtr VNAnimalBodyPoseObservationJointNameTailMiddle {
			get {
				fixed (IntPtr *storage = &values [23])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNAnimalBodyPoseObservationJointNameTailMiddle", storage);
			}
		}
		[Field ("VNAnimalBodyPoseObservationJointNameTailBottom", "Vision")]
		internal unsafe static IntPtr VNAnimalBodyPoseObservationJointNameTailBottom {
			get {
				fixed (IntPtr *storage = &values [24])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNAnimalBodyPoseObservationJointNameTailBottom", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this VNAnimalBodyPoseObservationJointName self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 1: // VNAnimalBodyPoseObservationJointName.LeftEarTop
				ptr = VNAnimalBodyPoseObservationJointNameLeftEarTop;
				break;
			case 2: // VNAnimalBodyPoseObservationJointName.RightEarTop
				ptr = VNAnimalBodyPoseObservationJointNameRightEarTop;
				break;
			case 3: // VNAnimalBodyPoseObservationJointName.LeftEarMiddle
				ptr = VNAnimalBodyPoseObservationJointNameLeftEarMiddle;
				break;
			case 4: // VNAnimalBodyPoseObservationJointName.RightEarMiddle
				ptr = VNAnimalBodyPoseObservationJointNameRightEarMiddle;
				break;
			case 5: // VNAnimalBodyPoseObservationJointName.LeftEarBottom
				ptr = VNAnimalBodyPoseObservationJointNameLeftEarBottom;
				break;
			case 6: // VNAnimalBodyPoseObservationJointName.RightEarBottom
				ptr = VNAnimalBodyPoseObservationJointNameRightEarBottom;
				break;
			case 7: // VNAnimalBodyPoseObservationJointName.LeftEye
				ptr = VNAnimalBodyPoseObservationJointNameLeftEye;
				break;
			case 8: // VNAnimalBodyPoseObservationJointName.RightEye
				ptr = VNAnimalBodyPoseObservationJointNameRightEye;
				break;
			case 9: // VNAnimalBodyPoseObservationJointName.Nose
				ptr = VNAnimalBodyPoseObservationJointNameNose;
				break;
			case 10: // VNAnimalBodyPoseObservationJointName.Neck
				ptr = VNAnimalBodyPoseObservationJointNameNeck;
				break;
			case 11: // VNAnimalBodyPoseObservationJointName.LeftFrontElbow
				ptr = VNAnimalBodyPoseObservationJointNameLeftFrontElbow;
				break;
			case 12: // VNAnimalBodyPoseObservationJointName.RightFrontElbow
				ptr = VNAnimalBodyPoseObservationJointNameRightFrontElbow;
				break;
			case 13: // VNAnimalBodyPoseObservationJointName.LeftFrontKnee
				ptr = VNAnimalBodyPoseObservationJointNameLeftFrontKnee;
				break;
			case 14: // VNAnimalBodyPoseObservationJointName.RightFrontKnee
				ptr = VNAnimalBodyPoseObservationJointNameRightFrontKnee;
				break;
			case 15: // VNAnimalBodyPoseObservationJointName.LeftFrontPaw
				ptr = VNAnimalBodyPoseObservationJointNameLeftFrontPaw;
				break;
			case 16: // VNAnimalBodyPoseObservationJointName.RightFrontPaw
				ptr = VNAnimalBodyPoseObservationJointNameRightFrontPaw;
				break;
			case 17: // VNAnimalBodyPoseObservationJointName.LeftBackElbow
				ptr = VNAnimalBodyPoseObservationJointNameLeftBackElbow;
				break;
			case 18: // VNAnimalBodyPoseObservationJointName.RightBackElbow
				ptr = VNAnimalBodyPoseObservationJointNameRightBackElbow;
				break;
			case 19: // VNAnimalBodyPoseObservationJointName.LeftBackKnee
				ptr = VNAnimalBodyPoseObservationJointNameLeftBackKnee;
				break;
			case 20: // VNAnimalBodyPoseObservationJointName.RightBackKnee
				ptr = VNAnimalBodyPoseObservationJointNameRightBackKnee;
				break;
			case 21: // VNAnimalBodyPoseObservationJointName.LeftBackPaw
				ptr = VNAnimalBodyPoseObservationJointNameLeftBackPaw;
				break;
			case 22: // VNAnimalBodyPoseObservationJointName.RightBackPaw
				ptr = VNAnimalBodyPoseObservationJointNameRightBackPaw;
				break;
			case 23: // VNAnimalBodyPoseObservationJointName.TailTop
				ptr = VNAnimalBodyPoseObservationJointNameTailTop;
				break;
			case 24: // VNAnimalBodyPoseObservationJointName.TailMiddle
				ptr = VNAnimalBodyPoseObservationJointNameTailMiddle;
				break;
			case 25: // VNAnimalBodyPoseObservationJointName.TailBottom
				ptr = VNAnimalBodyPoseObservationJointNameTailBottom;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::Vision.VNAnimalBodyPoseObservationJointName" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static VNAnimalBodyPoseObservationJointName GetValue (NSString? constant)
		{
			if (constant is null)
				return VNAnimalBodyPoseObservationJointName.None;
			if (constant.IsEqualTo (VNAnimalBodyPoseObservationJointNameLeftEarTop))
				return VNAnimalBodyPoseObservationJointName.LeftEarTop;
			if (constant.IsEqualTo (VNAnimalBodyPoseObservationJointNameRightEarTop))
				return VNAnimalBodyPoseObservationJointName.RightEarTop;
			if (constant.IsEqualTo (VNAnimalBodyPoseObservationJointNameLeftEarMiddle))
				return VNAnimalBodyPoseObservationJointName.LeftEarMiddle;
			if (constant.IsEqualTo (VNAnimalBodyPoseObservationJointNameRightEarMiddle))
				return VNAnimalBodyPoseObservationJointName.RightEarMiddle;
			if (constant.IsEqualTo (VNAnimalBodyPoseObservationJointNameLeftEarBottom))
				return VNAnimalBodyPoseObservationJointName.LeftEarBottom;
			if (constant.IsEqualTo (VNAnimalBodyPoseObservationJointNameRightEarBottom))
				return VNAnimalBodyPoseObservationJointName.RightEarBottom;
			if (constant.IsEqualTo (VNAnimalBodyPoseObservationJointNameLeftEye))
				return VNAnimalBodyPoseObservationJointName.LeftEye;
			if (constant.IsEqualTo (VNAnimalBodyPoseObservationJointNameRightEye))
				return VNAnimalBodyPoseObservationJointName.RightEye;
			if (constant.IsEqualTo (VNAnimalBodyPoseObservationJointNameNose))
				return VNAnimalBodyPoseObservationJointName.Nose;
			if (constant.IsEqualTo (VNAnimalBodyPoseObservationJointNameNeck))
				return VNAnimalBodyPoseObservationJointName.Neck;
			if (constant.IsEqualTo (VNAnimalBodyPoseObservationJointNameLeftFrontElbow))
				return VNAnimalBodyPoseObservationJointName.LeftFrontElbow;
			if (constant.IsEqualTo (VNAnimalBodyPoseObservationJointNameRightFrontElbow))
				return VNAnimalBodyPoseObservationJointName.RightFrontElbow;
			if (constant.IsEqualTo (VNAnimalBodyPoseObservationJointNameLeftFrontKnee))
				return VNAnimalBodyPoseObservationJointName.LeftFrontKnee;
			if (constant.IsEqualTo (VNAnimalBodyPoseObservationJointNameRightFrontKnee))
				return VNAnimalBodyPoseObservationJointName.RightFrontKnee;
			if (constant.IsEqualTo (VNAnimalBodyPoseObservationJointNameLeftFrontPaw))
				return VNAnimalBodyPoseObservationJointName.LeftFrontPaw;
			if (constant.IsEqualTo (VNAnimalBodyPoseObservationJointNameRightFrontPaw))
				return VNAnimalBodyPoseObservationJointName.RightFrontPaw;
			if (constant.IsEqualTo (VNAnimalBodyPoseObservationJointNameLeftBackElbow))
				return VNAnimalBodyPoseObservationJointName.LeftBackElbow;
			if (constant.IsEqualTo (VNAnimalBodyPoseObservationJointNameRightBackElbow))
				return VNAnimalBodyPoseObservationJointName.RightBackElbow;
			if (constant.IsEqualTo (VNAnimalBodyPoseObservationJointNameLeftBackKnee))
				return VNAnimalBodyPoseObservationJointName.LeftBackKnee;
			if (constant.IsEqualTo (VNAnimalBodyPoseObservationJointNameRightBackKnee))
				return VNAnimalBodyPoseObservationJointName.RightBackKnee;
			if (constant.IsEqualTo (VNAnimalBodyPoseObservationJointNameLeftBackPaw))
				return VNAnimalBodyPoseObservationJointName.LeftBackPaw;
			if (constant.IsEqualTo (VNAnimalBodyPoseObservationJointNameRightBackPaw))
				return VNAnimalBodyPoseObservationJointName.RightBackPaw;
			if (constant.IsEqualTo (VNAnimalBodyPoseObservationJointNameTailTop))
				return VNAnimalBodyPoseObservationJointName.TailTop;
			if (constant.IsEqualTo (VNAnimalBodyPoseObservationJointNameTailMiddle))
				return VNAnimalBodyPoseObservationJointName.TailMiddle;
			if (constant.IsEqualTo (VNAnimalBodyPoseObservationJointNameTailBottom))
				return VNAnimalBodyPoseObservationJointName.TailBottom;
			return VNAnimalBodyPoseObservationJointName.None;
		}
		/// <summary>Retrieves the <see cref="global::Vision.VNAnimalBodyPoseObservationJointName" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static VNAnimalBodyPoseObservationJointName GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::Vision.VNAnimalBodyPoseObservationJointName" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static VNAnimalBodyPoseObservationJointName? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::Vision.VNAnimalBodyPoseObservationJointName" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this VNAnimalBodyPoseObservationJointName[]? values)
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
		internal static VNAnimalBodyPoseObservationJointName[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<VNAnimalBodyPoseObservationJointName> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
