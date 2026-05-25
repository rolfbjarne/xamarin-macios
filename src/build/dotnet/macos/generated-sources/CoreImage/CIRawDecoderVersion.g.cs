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
namespace CoreImage {
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("macos")]
	[NativeName ("CIRAWDecoderVersion")]
	public enum CIRawDecoderVersion : long {
		VersionNone = 0,
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		Version9 = 7,
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		Version9Dng = 8,
		Version8 = 1,
		Version8Dng = 2,
		Version7 = 3,
		Version7Dng = 4,
		Version6 = 5,
		Version6Dng = 6,
	}
	/// <summary>Extension methods for the <see cref="global::CoreImage.CIRawDecoderVersion" /> enumeration.</summary>
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CIRawDecoderVersionExtensions {
		static IntPtr[] values = new IntPtr [9];
		[Field ("CIRAWDecoderVersionNone", "CoreImage")]
		internal unsafe static IntPtr CIRAWDecoderVersionNone {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.CoreImage.Handle, "CIRAWDecoderVersionNone", storage);
			}
		}
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[Field ("CIRAWDecoderVersion9", "CoreImage")]
		internal unsafe static IntPtr CIRAWDecoderVersion9 {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.CoreImage.Handle, "CIRAWDecoderVersion9", storage);
			}
		}
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[Field ("CIRAWDecoderVersion9DNG", "CoreImage")]
		internal unsafe static IntPtr CIRAWDecoderVersion9DNG {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.CoreImage.Handle, "CIRAWDecoderVersion9DNG", storage);
			}
		}
		[Field ("CIRAWDecoderVersion8", "CoreImage")]
		internal unsafe static IntPtr CIRAWDecoderVersion8 {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.CoreImage.Handle, "CIRAWDecoderVersion8", storage);
			}
		}
		[Field ("CIRAWDecoderVersion8DNG", "CoreImage")]
		internal unsafe static IntPtr CIRAWDecoderVersion8DNG {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.CoreImage.Handle, "CIRAWDecoderVersion8DNG", storage);
			}
		}
		[Field ("CIRAWDecoderVersion7", "CoreImage")]
		internal unsafe static IntPtr CIRAWDecoderVersion7 {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.CoreImage.Handle, "CIRAWDecoderVersion7", storage);
			}
		}
		[Field ("CIRAWDecoderVersion7DNG", "CoreImage")]
		internal unsafe static IntPtr CIRAWDecoderVersion7DNG {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.CoreImage.Handle, "CIRAWDecoderVersion7DNG", storage);
			}
		}
		[Field ("CIRAWDecoderVersion6", "CoreImage")]
		internal unsafe static IntPtr CIRAWDecoderVersion6 {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.CoreImage.Handle, "CIRAWDecoderVersion6", storage);
			}
		}
		[Field ("CIRAWDecoderVersion6DNG", "CoreImage")]
		internal unsafe static IntPtr CIRAWDecoderVersion6DNG {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.CoreImage.Handle, "CIRAWDecoderVersion6DNG", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CIRawDecoderVersion self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((long) self) {
			case 0: // CIRawDecoderVersion.VersionNone
				ptr = CIRAWDecoderVersionNone;
				break;
			case 7: // CIRawDecoderVersion.Version9
				ptr = CIRAWDecoderVersion9;
				break;
			case 8: // CIRawDecoderVersion.Version9Dng
				ptr = CIRAWDecoderVersion9DNG;
				break;
			case 1: // CIRawDecoderVersion.Version8
				ptr = CIRAWDecoderVersion8;
				break;
			case 2: // CIRawDecoderVersion.Version8Dng
				ptr = CIRAWDecoderVersion8DNG;
				break;
			case 3: // CIRawDecoderVersion.Version7
				ptr = CIRAWDecoderVersion7;
				break;
			case 4: // CIRawDecoderVersion.Version7Dng
				ptr = CIRAWDecoderVersion7DNG;
				break;
			case 5: // CIRawDecoderVersion.Version6
				ptr = CIRAWDecoderVersion6;
				break;
			case 6: // CIRawDecoderVersion.Version6Dng
				ptr = CIRAWDecoderVersion6DNG;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::CoreImage.CIRawDecoderVersion" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CIRawDecoderVersion GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (CIRAWDecoderVersionNone))
				return CIRawDecoderVersion.VersionNone;
			if (constant.IsEqualTo (CIRAWDecoderVersion9))
				return CIRawDecoderVersion.Version9;
			if (constant.IsEqualTo (CIRAWDecoderVersion9DNG))
				return CIRawDecoderVersion.Version9Dng;
			if (constant.IsEqualTo (CIRAWDecoderVersion8))
				return CIRawDecoderVersion.Version8;
			if (constant.IsEqualTo (CIRAWDecoderVersion8DNG))
				return CIRawDecoderVersion.Version8Dng;
			if (constant.IsEqualTo (CIRAWDecoderVersion7))
				return CIRawDecoderVersion.Version7;
			if (constant.IsEqualTo (CIRAWDecoderVersion7DNG))
				return CIRawDecoderVersion.Version7Dng;
			if (constant.IsEqualTo (CIRAWDecoderVersion6))
				return CIRawDecoderVersion.Version6;
			if (constant.IsEqualTo (CIRAWDecoderVersion6DNG))
				return CIRawDecoderVersion.Version6Dng;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::CoreImage.CIRawDecoderVersion" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CIRawDecoderVersion GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::CoreImage.CIRawDecoderVersion" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CIRawDecoderVersion? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::CoreImage.CIRawDecoderVersion" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CIRawDecoderVersion[]? values)
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
		internal static CIRawDecoderVersion[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CIRawDecoderVersion> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
