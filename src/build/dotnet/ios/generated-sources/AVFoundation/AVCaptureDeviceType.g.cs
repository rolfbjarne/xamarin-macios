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
namespace AVFoundation {
	/// <summary>Enumerates the types of device that can capture audiovisual data.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public enum AVCaptureDeviceType : int {
		/// <summary>The device's standard microphone.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		BuiltInMicrophone = 0,
		/// <summary>A camera with a general-purpose focal length.</summary>
		BuiltInWideAngleCamera = 1,
		/// <summary>A camera whose focal length is longer than <see cref="F:AVFoundation.AVCaptureDeviceType.BuiltInWideAngleCamera" />.</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos17.0")]
		BuiltInTelephotoCamera = 2,
		/// <summary>Developers should not use this deprecated field. Developers should use 'BuiltInDualCamera' instead.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios10.2", "Use 'BuiltInDualCamera' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'BuiltInDualCamera' instead.")]
		[SupportedOSPlatform ("ios")]
		BuiltInDuoCamera = 3,
		/// <summary>A camera that has both a telephoto and wide-angle lens that work together to capture images.</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos17.0")]
		BuiltInDualCamera = 4,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos17.0")]
		BuiltInTrueDepthCamera = 5,
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos17.0")]
		BuiltInUltraWideCamera = 6,
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos17.0")]
		BuiltInTripleCamera = 7,
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos17.0")]
		BuiltInDualWideCamera = 8,
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		ExternalUnknown = 9,
		[SupportedOSPlatform ("tvos17.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[SupportedOSPlatform ("ios15.4")]
		BuiltInLiDarDepthCamera = 10,
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		External = 11,
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		Microphone = 12,
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		ContinuityCamera = 13,
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		DeskViewCamera = 14,
	}
	/// <summary>Extension methods for the <see cref="global::AVFoundation.AVCaptureDeviceType" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class AVCaptureDeviceTypeExtensions {
		static IntPtr[] values = new IntPtr [13];
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("AVCaptureDeviceTypeBuiltInMicrophone", "AVFoundation")]
		internal unsafe static IntPtr AVCaptureDeviceTypeBuiltInMicrophone {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureDeviceTypeBuiltInMicrophone", storage);
			}
		}
		[Field ("AVCaptureDeviceTypeBuiltInWideAngleCamera", "AVFoundation")]
		internal unsafe static IntPtr AVCaptureDeviceTypeBuiltInWideAngleCamera {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureDeviceTypeBuiltInWideAngleCamera", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos17.0")]
		[Field ("AVCaptureDeviceTypeBuiltInTelephotoCamera", "AVFoundation")]
		internal unsafe static IntPtr AVCaptureDeviceTypeBuiltInTelephotoCamera {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureDeviceTypeBuiltInTelephotoCamera", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios10.2", "Use 'BuiltInDualCamera' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'BuiltInDualCamera' instead.")]
		[SupportedOSPlatform ("ios")]
		[Field ("AVCaptureDeviceTypeBuiltInDuoCamera", "AVFoundation")]
		internal unsafe static IntPtr AVCaptureDeviceTypeBuiltInDuoCamera {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureDeviceTypeBuiltInDuoCamera", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos17.0")]
		[Field ("AVCaptureDeviceTypeBuiltInDualCamera", "AVFoundation")]
		internal unsafe static IntPtr AVCaptureDeviceTypeBuiltInDualCamera {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureDeviceTypeBuiltInDualCamera", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos17.0")]
		[Field ("AVCaptureDeviceTypeBuiltInTrueDepthCamera", "AVFoundation")]
		internal unsafe static IntPtr AVCaptureDeviceTypeBuiltInTrueDepthCamera {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureDeviceTypeBuiltInTrueDepthCamera", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos17.0")]
		[Field ("AVCaptureDeviceTypeBuiltInUltraWideCamera", "AVFoundation")]
		internal unsafe static IntPtr AVCaptureDeviceTypeBuiltInUltraWideCamera {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureDeviceTypeBuiltInUltraWideCamera", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos17.0")]
		[Field ("AVCaptureDeviceTypeBuiltInTripleCamera", "AVFoundation")]
		internal unsafe static IntPtr AVCaptureDeviceTypeBuiltInTripleCamera {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureDeviceTypeBuiltInTripleCamera", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos17.0")]
		[Field ("AVCaptureDeviceTypeBuiltInDualWideCamera", "AVFoundation")]
		internal unsafe static IntPtr AVCaptureDeviceTypeBuiltInDualWideCamera {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureDeviceTypeBuiltInDualWideCamera", storage);
			}
		}
		[SupportedOSPlatform ("tvos17.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[SupportedOSPlatform ("ios15.4")]
		[Field ("AVCaptureDeviceTypeBuiltInLiDARDepthCamera", "AVFoundation")]
		internal unsafe static IntPtr AVCaptureDeviceTypeBuiltInLiDARDepthCamera {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureDeviceTypeBuiltInLiDARDepthCamera", storage);
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[Field ("AVCaptureDeviceTypeExternal", "AVFoundation")]
		internal unsafe static IntPtr AVCaptureDeviceTypeExternal {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureDeviceTypeExternal", storage);
			}
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[Field ("AVCaptureDeviceTypeMicrophone", "AVFoundation")]
		internal unsafe static IntPtr AVCaptureDeviceTypeMicrophone {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureDeviceTypeMicrophone", storage);
			}
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[Field ("AVCaptureDeviceTypeContinuityCamera", "AVFoundation")]
		internal unsafe static IntPtr AVCaptureDeviceTypeContinuityCamera {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureDeviceTypeContinuityCamera", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this AVCaptureDeviceType self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // AVCaptureDeviceType.BuiltInMicrophone
				ptr = AVCaptureDeviceTypeBuiltInMicrophone;
				break;
			case 1: // AVCaptureDeviceType.BuiltInWideAngleCamera
				ptr = AVCaptureDeviceTypeBuiltInWideAngleCamera;
				break;
			case 2: // AVCaptureDeviceType.BuiltInTelephotoCamera
				ptr = AVCaptureDeviceTypeBuiltInTelephotoCamera;
				break;
			case 3: // AVCaptureDeviceType.BuiltInDuoCamera
				ptr = AVCaptureDeviceTypeBuiltInDuoCamera;
				break;
			case 4: // AVCaptureDeviceType.BuiltInDualCamera
				ptr = AVCaptureDeviceTypeBuiltInDualCamera;
				break;
			case 5: // AVCaptureDeviceType.BuiltInTrueDepthCamera
				ptr = AVCaptureDeviceTypeBuiltInTrueDepthCamera;
				break;
			case 6: // AVCaptureDeviceType.BuiltInUltraWideCamera
				ptr = AVCaptureDeviceTypeBuiltInUltraWideCamera;
				break;
			case 7: // AVCaptureDeviceType.BuiltInTripleCamera
				ptr = AVCaptureDeviceTypeBuiltInTripleCamera;
				break;
			case 8: // AVCaptureDeviceType.BuiltInDualWideCamera
				ptr = AVCaptureDeviceTypeBuiltInDualWideCamera;
				break;
			case 10: // AVCaptureDeviceType.BuiltInLiDarDepthCamera
				ptr = AVCaptureDeviceTypeBuiltInLiDARDepthCamera;
				break;
			case 11: // AVCaptureDeviceType.External
				ptr = AVCaptureDeviceTypeExternal;
				break;
			case 12: // AVCaptureDeviceType.Microphone
				ptr = AVCaptureDeviceTypeMicrophone;
				break;
			case 13: // AVCaptureDeviceType.ContinuityCamera
				ptr = AVCaptureDeviceTypeContinuityCamera;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVCaptureDeviceType" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static AVCaptureDeviceType GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (AVCaptureDeviceTypeBuiltInMicrophone))
				return AVCaptureDeviceType.BuiltInMicrophone;
			if (constant.IsEqualTo (AVCaptureDeviceTypeBuiltInWideAngleCamera))
				return AVCaptureDeviceType.BuiltInWideAngleCamera;
			if (constant.IsEqualTo (AVCaptureDeviceTypeBuiltInTelephotoCamera))
				return AVCaptureDeviceType.BuiltInTelephotoCamera;
			if (constant.IsEqualTo (AVCaptureDeviceTypeBuiltInDuoCamera))
				return AVCaptureDeviceType.BuiltInDuoCamera;
			if (constant.IsEqualTo (AVCaptureDeviceTypeBuiltInDualCamera))
				return AVCaptureDeviceType.BuiltInDualCamera;
			if (constant.IsEqualTo (AVCaptureDeviceTypeBuiltInTrueDepthCamera))
				return AVCaptureDeviceType.BuiltInTrueDepthCamera;
			if (constant.IsEqualTo (AVCaptureDeviceTypeBuiltInUltraWideCamera))
				return AVCaptureDeviceType.BuiltInUltraWideCamera;
			if (constant.IsEqualTo (AVCaptureDeviceTypeBuiltInTripleCamera))
				return AVCaptureDeviceType.BuiltInTripleCamera;
			if (constant.IsEqualTo (AVCaptureDeviceTypeBuiltInDualWideCamera))
				return AVCaptureDeviceType.BuiltInDualWideCamera;
			if (constant.IsEqualTo (AVCaptureDeviceTypeBuiltInLiDARDepthCamera))
				return AVCaptureDeviceType.BuiltInLiDarDepthCamera;
			if (constant.IsEqualTo (AVCaptureDeviceTypeExternal))
				return AVCaptureDeviceType.External;
			if (constant.IsEqualTo (AVCaptureDeviceTypeMicrophone))
				return AVCaptureDeviceType.Microphone;
			if (constant.IsEqualTo (AVCaptureDeviceTypeContinuityCamera))
				return AVCaptureDeviceType.ContinuityCamera;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVCaptureDeviceType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVCaptureDeviceType GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVCaptureDeviceType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVCaptureDeviceType? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AVFoundation.AVCaptureDeviceType" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this AVCaptureDeviceType[]? values)
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
		internal static AVCaptureDeviceType[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<AVCaptureDeviceType> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
