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
namespace ImageIO {
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	public enum CGImagePropertyAstcBlockSize : int {
		BlockSize4x4 = 0,
		BlockSize8x8 = 1,
	}
	/// <summary>Extension methods for the <see cref="global::ImageIO.CGImagePropertyAstcBlockSize" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CGImagePropertyAstcBlockSizeExtensions {
		static IntPtr[] values = new IntPtr [2];
		[Field ("kCGImagePropertyASTCBlockSize4x4", "ImageIO")]
		internal unsafe static IntPtr kCGImagePropertyASTCBlockSize4x4 {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.ImageIO.Handle, "kCGImagePropertyASTCBlockSize4x4", storage);
			}
		}
		[Field ("kCGImagePropertyASTCBlockSize8x8", "ImageIO")]
		internal unsafe static IntPtr kCGImagePropertyASTCBlockSize8x8 {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.ImageIO.Handle, "kCGImagePropertyASTCBlockSize8x8", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CGImagePropertyAstcBlockSize self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // CGImagePropertyAstcBlockSize.BlockSize4x4
				ptr = kCGImagePropertyASTCBlockSize4x4;
				break;
			case 1: // CGImagePropertyAstcBlockSize.BlockSize8x8
				ptr = kCGImagePropertyASTCBlockSize8x8;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::ImageIO.CGImagePropertyAstcBlockSize" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CGImagePropertyAstcBlockSize GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (kCGImagePropertyASTCBlockSize4x4))
				return CGImagePropertyAstcBlockSize.BlockSize4x4;
			if (constant.IsEqualTo (kCGImagePropertyASTCBlockSize8x8))
				return CGImagePropertyAstcBlockSize.BlockSize8x8;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::ImageIO.CGImagePropertyAstcBlockSize" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CGImagePropertyAstcBlockSize GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::ImageIO.CGImagePropertyAstcBlockSize" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CGImagePropertyAstcBlockSize? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::ImageIO.CGImagePropertyAstcBlockSize" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CGImagePropertyAstcBlockSize[]? values)
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
		internal static CGImagePropertyAstcBlockSize[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CGImagePropertyAstcBlockSize> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
