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
	[SupportedOSPlatform ("tvos16.0")]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	public enum AVAssetPlaybackConfigurationOption : int {
		StereoVideo = 0,
		StereoMultiviewVideo = 1,
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		SpatialVideo = 2,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		NonRectilinearProjection = 3,
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("ios")]
		AppleImmersiveVideo = 4,
	}
	/// <summary>Extension methods for the <see cref="global::AVFoundation.AVAssetPlaybackConfigurationOption" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos16.0")]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class AVAssetPlaybackConfigurationOptionExtensions {
		static IntPtr[] values = new IntPtr [4];
		[Field ("AVAssetPlaybackConfigurationOptionStereoVideo", "AVFoundation")]
		internal unsafe static IntPtr AVAssetPlaybackConfigurationOptionStereoVideo {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAssetPlaybackConfigurationOptionStereoVideo", storage);
			}
		}
		[Field ("AVAssetPlaybackConfigurationOptionStereoMultiviewVideo", "AVFoundation")]
		internal unsafe static IntPtr AVAssetPlaybackConfigurationOptionStereoMultiviewVideo {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAssetPlaybackConfigurationOptionStereoMultiviewVideo", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[Field ("AVAssetPlaybackConfigurationOptionSpatialVideo", "AVFoundation")]
		internal unsafe static IntPtr AVAssetPlaybackConfigurationOptionSpatialVideo {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAssetPlaybackConfigurationOptionSpatialVideo", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("AVAssetPlaybackConfigurationOptionNonRectilinearProjection", "AVFoundation")]
		internal unsafe static IntPtr AVAssetPlaybackConfigurationOptionNonRectilinearProjection {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVAssetPlaybackConfigurationOptionNonRectilinearProjection", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this AVAssetPlaybackConfigurationOption self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // AVAssetPlaybackConfigurationOption.StereoVideo
				ptr = AVAssetPlaybackConfigurationOptionStereoVideo;
				break;
			case 1: // AVAssetPlaybackConfigurationOption.StereoMultiviewVideo
				ptr = AVAssetPlaybackConfigurationOptionStereoMultiviewVideo;
				break;
			case 2: // AVAssetPlaybackConfigurationOption.SpatialVideo
				ptr = AVAssetPlaybackConfigurationOptionSpatialVideo;
				break;
			case 3: // AVAssetPlaybackConfigurationOption.NonRectilinearProjection
				ptr = AVAssetPlaybackConfigurationOptionNonRectilinearProjection;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVAssetPlaybackConfigurationOption" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static AVAssetPlaybackConfigurationOption GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (AVAssetPlaybackConfigurationOptionStereoVideo))
				return AVAssetPlaybackConfigurationOption.StereoVideo;
			if (constant.IsEqualTo (AVAssetPlaybackConfigurationOptionStereoMultiviewVideo))
				return AVAssetPlaybackConfigurationOption.StereoMultiviewVideo;
			if (constant.IsEqualTo (AVAssetPlaybackConfigurationOptionSpatialVideo))
				return AVAssetPlaybackConfigurationOption.SpatialVideo;
			if (constant.IsEqualTo (AVAssetPlaybackConfigurationOptionNonRectilinearProjection))
				return AVAssetPlaybackConfigurationOption.NonRectilinearProjection;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVAssetPlaybackConfigurationOption" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVAssetPlaybackConfigurationOption GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVAssetPlaybackConfigurationOption" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVAssetPlaybackConfigurationOption? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AVFoundation.AVAssetPlaybackConfigurationOption" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this AVAssetPlaybackConfigurationOption[]? values)
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
		internal static AVAssetPlaybackConfigurationOption[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<AVAssetPlaybackConfigurationOption> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
