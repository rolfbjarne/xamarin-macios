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
namespace CoreMedia {
	[SupportedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	public enum CMFormatDescriptionProjectionKind : int {
		Rectilinear = 0,
		Equirectangular = 1,
		HalfEquirectangular = 2,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		ParametricImmersive = 3,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		AppleImmersiveVideo = 4,
	}
	/// <summary>Extension methods for the <see cref="global::CoreMedia.CMFormatDescriptionProjectionKind" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CMFormatDescriptionProjectionKindExtensions {
		static IntPtr[] values = new IntPtr [5];
		[Field ("kCMFormatDescriptionProjectionKind_Rectilinear", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionProjectionKind_Rectilinear {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionProjectionKind_Rectilinear", storage);
			}
		}
		[Field ("kCMFormatDescriptionProjectionKind_Equirectangular", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionProjectionKind_Equirectangular {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionProjectionKind_Equirectangular", storage);
			}
		}
		[Field ("kCMFormatDescriptionProjectionKind_HalfEquirectangular", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionProjectionKind_HalfEquirectangular {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionProjectionKind_HalfEquirectangular", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("kCMFormatDescriptionProjectionKind_ParametricImmersive", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionProjectionKind_ParametricImmersive {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionProjectionKind_ParametricImmersive", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("kCMFormatDescriptionProjectionKind_AppleImmersiveVideo", "CoreMedia")]
		internal unsafe static IntPtr kCMFormatDescriptionProjectionKind_AppleImmersiveVideo {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.CoreMedia.Handle, "kCMFormatDescriptionProjectionKind_AppleImmersiveVideo", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CMFormatDescriptionProjectionKind self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // CMFormatDescriptionProjectionKind.Rectilinear
				ptr = kCMFormatDescriptionProjectionKind_Rectilinear;
				break;
			case 1: // CMFormatDescriptionProjectionKind.Equirectangular
				ptr = kCMFormatDescriptionProjectionKind_Equirectangular;
				break;
			case 2: // CMFormatDescriptionProjectionKind.HalfEquirectangular
				ptr = kCMFormatDescriptionProjectionKind_HalfEquirectangular;
				break;
			case 3: // CMFormatDescriptionProjectionKind.ParametricImmersive
				ptr = kCMFormatDescriptionProjectionKind_ParametricImmersive;
				break;
			case 4: // CMFormatDescriptionProjectionKind.AppleImmersiveVideo
				ptr = kCMFormatDescriptionProjectionKind_AppleImmersiveVideo;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMFormatDescriptionProjectionKind" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CMFormatDescriptionProjectionKind GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (kCMFormatDescriptionProjectionKind_Rectilinear))
				return CMFormatDescriptionProjectionKind.Rectilinear;
			if (constant.IsEqualTo (kCMFormatDescriptionProjectionKind_Equirectangular))
				return CMFormatDescriptionProjectionKind.Equirectangular;
			if (constant.IsEqualTo (kCMFormatDescriptionProjectionKind_HalfEquirectangular))
				return CMFormatDescriptionProjectionKind.HalfEquirectangular;
			if (constant.IsEqualTo (kCMFormatDescriptionProjectionKind_ParametricImmersive))
				return CMFormatDescriptionProjectionKind.ParametricImmersive;
			if (constant.IsEqualTo (kCMFormatDescriptionProjectionKind_AppleImmersiveVideo))
				return CMFormatDescriptionProjectionKind.AppleImmersiveVideo;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMFormatDescriptionProjectionKind" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CMFormatDescriptionProjectionKind GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::CoreMedia.CMFormatDescriptionProjectionKind" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CMFormatDescriptionProjectionKind? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::CoreMedia.CMFormatDescriptionProjectionKind" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CMFormatDescriptionProjectionKind[]? values)
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
		internal static CMFormatDescriptionProjectionKind[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CMFormatDescriptionProjectionKind> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
