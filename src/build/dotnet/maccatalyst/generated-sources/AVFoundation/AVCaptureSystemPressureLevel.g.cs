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
namespace AVFoundation {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos17.0")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	public enum AVCaptureSystemPressureLevel : int {
		/// <summary>To be added.</summary>
		Nominal = 0,
		/// <summary>To be added.</summary>
		Fair = 1,
		/// <summary>To be added.</summary>
		Serious = 2,
		/// <summary>To be added.</summary>
		Critical = 3,
		/// <summary>To be added.</summary>
		Shutdown = 4,
	}
	/// <summary>Extension methods for the <see cref="global::AVFoundation.AVCaptureSystemPressureLevel" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos17.0")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class AVCaptureSystemPressureLevelExtensions {
		static IntPtr[] values = new IntPtr [5];
		[Field ("AVCaptureSystemPressureLevelNominal", "AVFoundation")]
		internal unsafe static IntPtr AVCaptureSystemPressureLevelNominal {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureSystemPressureLevelNominal", storage);
			}
		}
		[Field ("AVCaptureSystemPressureLevelFair", "AVFoundation")]
		internal unsafe static IntPtr AVCaptureSystemPressureLevelFair {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureSystemPressureLevelFair", storage);
			}
		}
		[Field ("AVCaptureSystemPressureLevelSerious", "AVFoundation")]
		internal unsafe static IntPtr AVCaptureSystemPressureLevelSerious {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureSystemPressureLevelSerious", storage);
			}
		}
		[Field ("AVCaptureSystemPressureLevelCritical", "AVFoundation")]
		internal unsafe static IntPtr AVCaptureSystemPressureLevelCritical {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureSystemPressureLevelCritical", storage);
			}
		}
		[Field ("AVCaptureSystemPressureLevelShutdown", "AVFoundation")]
		internal unsafe static IntPtr AVCaptureSystemPressureLevelShutdown {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureSystemPressureLevelShutdown", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this AVCaptureSystemPressureLevel self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // AVCaptureSystemPressureLevel.Nominal
				ptr = AVCaptureSystemPressureLevelNominal;
				break;
			case 1: // AVCaptureSystemPressureLevel.Fair
				ptr = AVCaptureSystemPressureLevelFair;
				break;
			case 2: // AVCaptureSystemPressureLevel.Serious
				ptr = AVCaptureSystemPressureLevelSerious;
				break;
			case 3: // AVCaptureSystemPressureLevel.Critical
				ptr = AVCaptureSystemPressureLevelCritical;
				break;
			case 4: // AVCaptureSystemPressureLevel.Shutdown
				ptr = AVCaptureSystemPressureLevelShutdown;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVCaptureSystemPressureLevel" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static AVCaptureSystemPressureLevel GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (AVCaptureSystemPressureLevelNominal))
				return AVCaptureSystemPressureLevel.Nominal;
			if (constant.IsEqualTo (AVCaptureSystemPressureLevelFair))
				return AVCaptureSystemPressureLevel.Fair;
			if (constant.IsEqualTo (AVCaptureSystemPressureLevelSerious))
				return AVCaptureSystemPressureLevel.Serious;
			if (constant.IsEqualTo (AVCaptureSystemPressureLevelCritical))
				return AVCaptureSystemPressureLevel.Critical;
			if (constant.IsEqualTo (AVCaptureSystemPressureLevelShutdown))
				return AVCaptureSystemPressureLevel.Shutdown;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVCaptureSystemPressureLevel" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVCaptureSystemPressureLevel GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVCaptureSystemPressureLevel" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVCaptureSystemPressureLevel? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AVFoundation.AVCaptureSystemPressureLevel" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this AVCaptureSystemPressureLevel[]? values)
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
		internal static AVCaptureSystemPressureLevel[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<AVCaptureSystemPressureLevel> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
