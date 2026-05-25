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
	public enum VNHumanHandPoseObservationJointName : int {
		None = 0,
		Wrist = 1,
		ThumbCmc = 2,
		ThumbMP = 3,
		ThumbIP = 4,
		ThumbTip = 5,
		IndexMcp = 6,
		IndexPip = 7,
		IndexDip = 8,
		IndexTip = 9,
		MiddleMcp = 10,
		MiddlePip = 11,
		MiddleDip = 12,
		MiddleTip = 13,
		RingMcp = 14,
		RingPip = 15,
		RingDip = 16,
		RingTip = 17,
		LittleMcp = 18,
		LittlePip = 19,
		LittleDip = 20,
		LittleTip = 21,
	}
	/// <summary>Extension methods for the <see cref="global::Vision.VNHumanHandPoseObservationJointName" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class VNHumanHandPoseObservationJointNameExtensions {
		static IntPtr[] values = new IntPtr [21];
		[Field ("VNHumanHandPoseObservationJointNameWrist", "Vision")]
		internal unsafe static IntPtr VNHumanHandPoseObservationJointNameWrist {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanHandPoseObservationJointNameWrist", storage);
			}
		}
		[Field ("VNHumanHandPoseObservationJointNameThumbCMC", "Vision")]
		internal unsafe static IntPtr VNHumanHandPoseObservationJointNameThumbCMC {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanHandPoseObservationJointNameThumbCMC", storage);
			}
		}
		[Field ("VNHumanHandPoseObservationJointNameThumbMP", "Vision")]
		internal unsafe static IntPtr VNHumanHandPoseObservationJointNameThumbMP {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanHandPoseObservationJointNameThumbMP", storage);
			}
		}
		[Field ("VNHumanHandPoseObservationJointNameThumbIP", "Vision")]
		internal unsafe static IntPtr VNHumanHandPoseObservationJointNameThumbIP {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanHandPoseObservationJointNameThumbIP", storage);
			}
		}
		[Field ("VNHumanHandPoseObservationJointNameThumbTip", "Vision")]
		internal unsafe static IntPtr VNHumanHandPoseObservationJointNameThumbTip {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanHandPoseObservationJointNameThumbTip", storage);
			}
		}
		[Field ("VNHumanHandPoseObservationJointNameIndexMCP", "Vision")]
		internal unsafe static IntPtr VNHumanHandPoseObservationJointNameIndexMCP {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanHandPoseObservationJointNameIndexMCP", storage);
			}
		}
		[Field ("VNHumanHandPoseObservationJointNameIndexPIP", "Vision")]
		internal unsafe static IntPtr VNHumanHandPoseObservationJointNameIndexPIP {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanHandPoseObservationJointNameIndexPIP", storage);
			}
		}
		[Field ("VNHumanHandPoseObservationJointNameIndexDIP", "Vision")]
		internal unsafe static IntPtr VNHumanHandPoseObservationJointNameIndexDIP {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanHandPoseObservationJointNameIndexDIP", storage);
			}
		}
		[Field ("VNHumanHandPoseObservationJointNameIndexTip", "Vision")]
		internal unsafe static IntPtr VNHumanHandPoseObservationJointNameIndexTip {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanHandPoseObservationJointNameIndexTip", storage);
			}
		}
		[Field ("VNHumanHandPoseObservationJointNameMiddleMCP", "Vision")]
		internal unsafe static IntPtr VNHumanHandPoseObservationJointNameMiddleMCP {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanHandPoseObservationJointNameMiddleMCP", storage);
			}
		}
		[Field ("VNHumanHandPoseObservationJointNameMiddlePIP", "Vision")]
		internal unsafe static IntPtr VNHumanHandPoseObservationJointNameMiddlePIP {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanHandPoseObservationJointNameMiddlePIP", storage);
			}
		}
		[Field ("VNHumanHandPoseObservationJointNameMiddleDIP", "Vision")]
		internal unsafe static IntPtr VNHumanHandPoseObservationJointNameMiddleDIP {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanHandPoseObservationJointNameMiddleDIP", storage);
			}
		}
		[Field ("VNHumanHandPoseObservationJointNameMiddleTip", "Vision")]
		internal unsafe static IntPtr VNHumanHandPoseObservationJointNameMiddleTip {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanHandPoseObservationJointNameMiddleTip", storage);
			}
		}
		[Field ("VNHumanHandPoseObservationJointNameRingMCP", "Vision")]
		internal unsafe static IntPtr VNHumanHandPoseObservationJointNameRingMCP {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanHandPoseObservationJointNameRingMCP", storage);
			}
		}
		[Field ("VNHumanHandPoseObservationJointNameRingPIP", "Vision")]
		internal unsafe static IntPtr VNHumanHandPoseObservationJointNameRingPIP {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanHandPoseObservationJointNameRingPIP", storage);
			}
		}
		[Field ("VNHumanHandPoseObservationJointNameRingDIP", "Vision")]
		internal unsafe static IntPtr VNHumanHandPoseObservationJointNameRingDIP {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanHandPoseObservationJointNameRingDIP", storage);
			}
		}
		[Field ("VNHumanHandPoseObservationJointNameRingTip", "Vision")]
		internal unsafe static IntPtr VNHumanHandPoseObservationJointNameRingTip {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanHandPoseObservationJointNameRingTip", storage);
			}
		}
		[Field ("VNHumanHandPoseObservationJointNameLittleMCP", "Vision")]
		internal unsafe static IntPtr VNHumanHandPoseObservationJointNameLittleMCP {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanHandPoseObservationJointNameLittleMCP", storage);
			}
		}
		[Field ("VNHumanHandPoseObservationJointNameLittlePIP", "Vision")]
		internal unsafe static IntPtr VNHumanHandPoseObservationJointNameLittlePIP {
			get {
				fixed (IntPtr *storage = &values [18])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanHandPoseObservationJointNameLittlePIP", storage);
			}
		}
		[Field ("VNHumanHandPoseObservationJointNameLittleDIP", "Vision")]
		internal unsafe static IntPtr VNHumanHandPoseObservationJointNameLittleDIP {
			get {
				fixed (IntPtr *storage = &values [19])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanHandPoseObservationJointNameLittleDIP", storage);
			}
		}
		[Field ("VNHumanHandPoseObservationJointNameLittleTip", "Vision")]
		internal unsafe static IntPtr VNHumanHandPoseObservationJointNameLittleTip {
			get {
				fixed (IntPtr *storage = &values [20])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNHumanHandPoseObservationJointNameLittleTip", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this VNHumanHandPoseObservationJointName self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 1: // VNHumanHandPoseObservationJointName.Wrist
				ptr = VNHumanHandPoseObservationJointNameWrist;
				break;
			case 2: // VNHumanHandPoseObservationJointName.ThumbCmc
				ptr = VNHumanHandPoseObservationJointNameThumbCMC;
				break;
			case 3: // VNHumanHandPoseObservationJointName.ThumbMP
				ptr = VNHumanHandPoseObservationJointNameThumbMP;
				break;
			case 4: // VNHumanHandPoseObservationJointName.ThumbIP
				ptr = VNHumanHandPoseObservationJointNameThumbIP;
				break;
			case 5: // VNHumanHandPoseObservationJointName.ThumbTip
				ptr = VNHumanHandPoseObservationJointNameThumbTip;
				break;
			case 6: // VNHumanHandPoseObservationJointName.IndexMcp
				ptr = VNHumanHandPoseObservationJointNameIndexMCP;
				break;
			case 7: // VNHumanHandPoseObservationJointName.IndexPip
				ptr = VNHumanHandPoseObservationJointNameIndexPIP;
				break;
			case 8: // VNHumanHandPoseObservationJointName.IndexDip
				ptr = VNHumanHandPoseObservationJointNameIndexDIP;
				break;
			case 9: // VNHumanHandPoseObservationJointName.IndexTip
				ptr = VNHumanHandPoseObservationJointNameIndexTip;
				break;
			case 10: // VNHumanHandPoseObservationJointName.MiddleMcp
				ptr = VNHumanHandPoseObservationJointNameMiddleMCP;
				break;
			case 11: // VNHumanHandPoseObservationJointName.MiddlePip
				ptr = VNHumanHandPoseObservationJointNameMiddlePIP;
				break;
			case 12: // VNHumanHandPoseObservationJointName.MiddleDip
				ptr = VNHumanHandPoseObservationJointNameMiddleDIP;
				break;
			case 13: // VNHumanHandPoseObservationJointName.MiddleTip
				ptr = VNHumanHandPoseObservationJointNameMiddleTip;
				break;
			case 14: // VNHumanHandPoseObservationJointName.RingMcp
				ptr = VNHumanHandPoseObservationJointNameRingMCP;
				break;
			case 15: // VNHumanHandPoseObservationJointName.RingPip
				ptr = VNHumanHandPoseObservationJointNameRingPIP;
				break;
			case 16: // VNHumanHandPoseObservationJointName.RingDip
				ptr = VNHumanHandPoseObservationJointNameRingDIP;
				break;
			case 17: // VNHumanHandPoseObservationJointName.RingTip
				ptr = VNHumanHandPoseObservationJointNameRingTip;
				break;
			case 18: // VNHumanHandPoseObservationJointName.LittleMcp
				ptr = VNHumanHandPoseObservationJointNameLittleMCP;
				break;
			case 19: // VNHumanHandPoseObservationJointName.LittlePip
				ptr = VNHumanHandPoseObservationJointNameLittlePIP;
				break;
			case 20: // VNHumanHandPoseObservationJointName.LittleDip
				ptr = VNHumanHandPoseObservationJointNameLittleDIP;
				break;
			case 21: // VNHumanHandPoseObservationJointName.LittleTip
				ptr = VNHumanHandPoseObservationJointNameLittleTip;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::Vision.VNHumanHandPoseObservationJointName" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static VNHumanHandPoseObservationJointName GetValue (NSString? constant)
		{
			if (constant is null)
				return VNHumanHandPoseObservationJointName.None;
			if (constant.IsEqualTo (VNHumanHandPoseObservationJointNameWrist))
				return VNHumanHandPoseObservationJointName.Wrist;
			if (constant.IsEqualTo (VNHumanHandPoseObservationJointNameThumbCMC))
				return VNHumanHandPoseObservationJointName.ThumbCmc;
			if (constant.IsEqualTo (VNHumanHandPoseObservationJointNameThumbMP))
				return VNHumanHandPoseObservationJointName.ThumbMP;
			if (constant.IsEqualTo (VNHumanHandPoseObservationJointNameThumbIP))
				return VNHumanHandPoseObservationJointName.ThumbIP;
			if (constant.IsEqualTo (VNHumanHandPoseObservationJointNameThumbTip))
				return VNHumanHandPoseObservationJointName.ThumbTip;
			if (constant.IsEqualTo (VNHumanHandPoseObservationJointNameIndexMCP))
				return VNHumanHandPoseObservationJointName.IndexMcp;
			if (constant.IsEqualTo (VNHumanHandPoseObservationJointNameIndexPIP))
				return VNHumanHandPoseObservationJointName.IndexPip;
			if (constant.IsEqualTo (VNHumanHandPoseObservationJointNameIndexDIP))
				return VNHumanHandPoseObservationJointName.IndexDip;
			if (constant.IsEqualTo (VNHumanHandPoseObservationJointNameIndexTip))
				return VNHumanHandPoseObservationJointName.IndexTip;
			if (constant.IsEqualTo (VNHumanHandPoseObservationJointNameMiddleMCP))
				return VNHumanHandPoseObservationJointName.MiddleMcp;
			if (constant.IsEqualTo (VNHumanHandPoseObservationJointNameMiddlePIP))
				return VNHumanHandPoseObservationJointName.MiddlePip;
			if (constant.IsEqualTo (VNHumanHandPoseObservationJointNameMiddleDIP))
				return VNHumanHandPoseObservationJointName.MiddleDip;
			if (constant.IsEqualTo (VNHumanHandPoseObservationJointNameMiddleTip))
				return VNHumanHandPoseObservationJointName.MiddleTip;
			if (constant.IsEqualTo (VNHumanHandPoseObservationJointNameRingMCP))
				return VNHumanHandPoseObservationJointName.RingMcp;
			if (constant.IsEqualTo (VNHumanHandPoseObservationJointNameRingPIP))
				return VNHumanHandPoseObservationJointName.RingPip;
			if (constant.IsEqualTo (VNHumanHandPoseObservationJointNameRingDIP))
				return VNHumanHandPoseObservationJointName.RingDip;
			if (constant.IsEqualTo (VNHumanHandPoseObservationJointNameRingTip))
				return VNHumanHandPoseObservationJointName.RingTip;
			if (constant.IsEqualTo (VNHumanHandPoseObservationJointNameLittleMCP))
				return VNHumanHandPoseObservationJointName.LittleMcp;
			if (constant.IsEqualTo (VNHumanHandPoseObservationJointNameLittlePIP))
				return VNHumanHandPoseObservationJointName.LittlePip;
			if (constant.IsEqualTo (VNHumanHandPoseObservationJointNameLittleDIP))
				return VNHumanHandPoseObservationJointName.LittleDip;
			if (constant.IsEqualTo (VNHumanHandPoseObservationJointNameLittleTip))
				return VNHumanHandPoseObservationJointName.LittleTip;
			return VNHumanHandPoseObservationJointName.None;
		}
		/// <summary>Retrieves the <see cref="global::Vision.VNHumanHandPoseObservationJointName" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static VNHumanHandPoseObservationJointName GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::Vision.VNHumanHandPoseObservationJointName" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static VNHumanHandPoseObservationJointName? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::Vision.VNHumanHandPoseObservationJointName" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this VNHumanHandPoseObservationJointName[]? values)
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
		internal static VNHumanHandPoseObservationJointName[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<VNHumanHandPoseObservationJointName> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
