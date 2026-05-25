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
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios26.0")]
	public enum AVCaptureAspectRatio : int {
		OneByOne1x1 = 0,
		SixteenByNine16x9 = 1,
		NineBySixteen9x16 = 2,
		FourByThree4x3 = 3,
		ThreeByFour3x4 = 4,
	}
	/// <summary>Extension methods for the <see cref="global::AVFoundation.AVCaptureAspectRatio" /> enumeration.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios26.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class AVCaptureAspectRatioExtensions {
		static IntPtr[] values = new IntPtr [5];
		[Field ("AVCaptureAspectRatio1x1", "AVFoundation")]
		internal unsafe static IntPtr AVCaptureAspectRatio1x1 {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureAspectRatio1x1", storage);
			}
		}
		[Field ("AVCaptureAspectRatio16x9", "AVFoundation")]
		internal unsafe static IntPtr AVCaptureAspectRatio16x9 {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureAspectRatio16x9", storage);
			}
		}
		[Field ("AVCaptureAspectRatio9x16", "AVFoundation")]
		internal unsafe static IntPtr AVCaptureAspectRatio9x16 {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureAspectRatio9x16", storage);
			}
		}
		[Field ("AVCaptureAspectRatio4x3", "AVFoundation")]
		internal unsafe static IntPtr AVCaptureAspectRatio4x3 {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureAspectRatio4x3", storage);
			}
		}
		[Field ("AVCaptureAspectRatio3x4", "AVFoundation")]
		internal unsafe static IntPtr AVCaptureAspectRatio3x4 {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureAspectRatio3x4", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this AVCaptureAspectRatio self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // AVCaptureAspectRatio.OneByOne1x1
				ptr = AVCaptureAspectRatio1x1;
				break;
			case 1: // AVCaptureAspectRatio.SixteenByNine16x9
				ptr = AVCaptureAspectRatio16x9;
				break;
			case 2: // AVCaptureAspectRatio.NineBySixteen9x16
				ptr = AVCaptureAspectRatio9x16;
				break;
			case 3: // AVCaptureAspectRatio.FourByThree4x3
				ptr = AVCaptureAspectRatio4x3;
				break;
			case 4: // AVCaptureAspectRatio.ThreeByFour3x4
				ptr = AVCaptureAspectRatio3x4;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVCaptureAspectRatio" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static AVCaptureAspectRatio GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (AVCaptureAspectRatio1x1))
				return AVCaptureAspectRatio.OneByOne1x1;
			if (constant.IsEqualTo (AVCaptureAspectRatio16x9))
				return AVCaptureAspectRatio.SixteenByNine16x9;
			if (constant.IsEqualTo (AVCaptureAspectRatio9x16))
				return AVCaptureAspectRatio.NineBySixteen9x16;
			if (constant.IsEqualTo (AVCaptureAspectRatio4x3))
				return AVCaptureAspectRatio.FourByThree4x3;
			if (constant.IsEqualTo (AVCaptureAspectRatio3x4))
				return AVCaptureAspectRatio.ThreeByFour3x4;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVCaptureAspectRatio" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVCaptureAspectRatio GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVCaptureAspectRatio" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVCaptureAspectRatio? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AVFoundation.AVCaptureAspectRatio" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this AVCaptureAspectRatio[]? values)
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
		internal static AVCaptureAspectRatio[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<AVCaptureAspectRatio> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
