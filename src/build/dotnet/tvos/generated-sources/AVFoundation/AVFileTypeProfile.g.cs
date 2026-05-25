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
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum AVFileTypeProfile : int {
		None = 0,
		Mpeg4AppleHls = 1,
		Mpeg4CmafCompliant = 2,
	}
	/// <summary>Extension methods for the <see cref="global::AVFoundation.AVFileTypeProfile" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class AVFileTypeProfileExtensions {
		static IntPtr[] values = new IntPtr [2];
		[Field ("AVFileTypeProfileMPEG4AppleHLS", "AVFoundation")]
		internal unsafe static IntPtr AVFileTypeProfileMPEG4AppleHLS {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVFileTypeProfileMPEG4AppleHLS", storage);
			}
		}
		[Field ("AVFileTypeProfileMPEG4CMAFCompliant", "AVFoundation")]
		internal unsafe static IntPtr AVFileTypeProfileMPEG4CMAFCompliant {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVFileTypeProfileMPEG4CMAFCompliant", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this AVFileTypeProfile self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 1: // AVFileTypeProfile.Mpeg4AppleHls
				ptr = AVFileTypeProfileMPEG4AppleHLS;
				break;
			case 2: // AVFileTypeProfile.Mpeg4CmafCompliant
				ptr = AVFileTypeProfileMPEG4CMAFCompliant;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVFileTypeProfile" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static AVFileTypeProfile GetValue (NSString? constant)
		{
			if (constant is null)
				return AVFileTypeProfile.None;
			if (constant.IsEqualTo (AVFileTypeProfileMPEG4AppleHLS))
				return AVFileTypeProfile.Mpeg4AppleHls;
			if (constant.IsEqualTo (AVFileTypeProfileMPEG4CMAFCompliant))
				return AVFileTypeProfile.Mpeg4CmafCompliant;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVFileTypeProfile" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVFileTypeProfile GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVFileTypeProfile" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVFileTypeProfile? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AVFoundation.AVFileTypeProfile" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this AVFileTypeProfile[]? values)
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
		internal static AVFileTypeProfile[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<AVFileTypeProfile> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
