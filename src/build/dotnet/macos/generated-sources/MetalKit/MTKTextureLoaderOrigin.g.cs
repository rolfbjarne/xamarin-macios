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
namespace MetalKit {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum MTKTextureLoaderOrigin : int {
		/// <summary>To be added.</summary>
		TopLeft = 0,
		/// <summary>To be added.</summary>
		BottomLeft = 1,
		/// <summary>To be added.</summary>
		FlippedVertically = 2,
	}
	/// <summary>Extension methods for the <see cref="global::MetalKit.MTKTextureLoaderOrigin" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class MTKTextureLoaderOriginExtensions {
		static IntPtr[] values = new IntPtr [3];
		[Field ("MTKTextureLoaderOriginTopLeft", "MetalKit")]
		internal unsafe static IntPtr MTKTextureLoaderOriginTopLeft {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.MetalKit.Handle, "MTKTextureLoaderOriginTopLeft", storage);
			}
		}
		[Field ("MTKTextureLoaderOriginBottomLeft", "MetalKit")]
		internal unsafe static IntPtr MTKTextureLoaderOriginBottomLeft {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.MetalKit.Handle, "MTKTextureLoaderOriginBottomLeft", storage);
			}
		}
		[Field ("MTKTextureLoaderOriginFlippedVertically", "MetalKit")]
		internal unsafe static IntPtr MTKTextureLoaderOriginFlippedVertically {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.MetalKit.Handle, "MTKTextureLoaderOriginFlippedVertically", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this MTKTextureLoaderOrigin self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // MTKTextureLoaderOrigin.TopLeft
				ptr = MTKTextureLoaderOriginTopLeft;
				break;
			case 1: // MTKTextureLoaderOrigin.BottomLeft
				ptr = MTKTextureLoaderOriginBottomLeft;
				break;
			case 2: // MTKTextureLoaderOrigin.FlippedVertically
				ptr = MTKTextureLoaderOriginFlippedVertically;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::MetalKit.MTKTextureLoaderOrigin" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static MTKTextureLoaderOrigin GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (MTKTextureLoaderOriginTopLeft))
				return MTKTextureLoaderOrigin.TopLeft;
			if (constant.IsEqualTo (MTKTextureLoaderOriginBottomLeft))
				return MTKTextureLoaderOrigin.BottomLeft;
			if (constant.IsEqualTo (MTKTextureLoaderOriginFlippedVertically))
				return MTKTextureLoaderOrigin.FlippedVertically;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::MetalKit.MTKTextureLoaderOrigin" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static MTKTextureLoaderOrigin GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::MetalKit.MTKTextureLoaderOrigin" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static MTKTextureLoaderOrigin? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::MetalKit.MTKTextureLoaderOrigin" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this MTKTextureLoaderOrigin[]? values)
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
		internal static MTKTextureLoaderOrigin[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<MTKTextureLoaderOrigin> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
