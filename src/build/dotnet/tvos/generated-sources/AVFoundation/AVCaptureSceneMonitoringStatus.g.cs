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
namespace AVFoundation {
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[Flags]
	public enum AVCaptureSceneMonitoringStatus : int {
		NotEnoughLight = 1,
	}
	/// <summary>Extension methods for the <see cref="global::AVFoundation.AVCaptureSceneMonitoringStatus" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class AVCaptureSceneMonitoringStatusExtensions {
		static IntPtr[] values = new IntPtr [1];
		[Field ("AVCaptureSceneMonitoringStatusNotEnoughLight", "AVFoundation")]
		internal unsafe static IntPtr AVCaptureSceneMonitoringStatusNotEnoughLight {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVCaptureSceneMonitoringStatusNotEnoughLight", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this AVCaptureSceneMonitoringStatus self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 1: // AVCaptureSceneMonitoringStatus.NotEnoughLight
				ptr = AVCaptureSceneMonitoringStatusNotEnoughLight;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVCaptureSceneMonitoringStatus" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static AVCaptureSceneMonitoringStatus GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (AVCaptureSceneMonitoringStatusNotEnoughLight))
				return AVCaptureSceneMonitoringStatus.NotEnoughLight;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVCaptureSceneMonitoringStatus" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVCaptureSceneMonitoringStatus GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVCaptureSceneMonitoringStatus" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVCaptureSceneMonitoringStatus? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AVFoundation.AVCaptureSceneMonitoringStatus" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this AVCaptureSceneMonitoringStatus[]? values)
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
		internal static AVCaptureSceneMonitoringStatus[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<AVCaptureSceneMonitoringStatus> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
		/// <summary>Retrieves all the <see cref="global::AVFoundation.AVCaptureSceneMonitoringStatus" /> constants named by the flags <paramref name="value" />.</summary>
		/// <param name="value">The flags to retrieve</param>
		/// <remarks>Any flags that are not recognized will be ignored.</remarks>
		public static NSString[] ToArray (this AVCaptureSceneMonitoringStatus value)
		{
			var rv = new global::System.Collections.Generic.List<NSString> ();
			if (value.HasFlag (AVCaptureSceneMonitoringStatus.NotEnoughLight) && AVCaptureSceneMonitoringStatusNotEnoughLight != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (AVCaptureSceneMonitoringStatusNotEnoughLight)!);
			// In order to be forward-compatible, any unknown values are ignored.
			return rv.ToArray ();
		}
		public static AVCaptureSceneMonitoringStatus ToFlags (global::System.Collections.Generic.IEnumerable<NSString> constants)
		{
			var rv = default (AVCaptureSceneMonitoringStatus);
			if (constants is null)
				return rv;
			foreach (var constant in constants) {
				if (constant.IsEqualTo (AVCaptureSceneMonitoringStatusNotEnoughLight))
					rv |= AVCaptureSceneMonitoringStatus.NotEnoughLight;
				// In order to be forward-compatible, any unknown values are ignored.
			}
			return rv;
		}
	}
}
