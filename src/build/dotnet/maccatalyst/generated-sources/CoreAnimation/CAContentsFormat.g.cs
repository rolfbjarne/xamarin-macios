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
namespace CoreAnimation {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum CAContentsFormat : int {
		/// <summary>To be added.</summary>
		Gray8Uint = 0,
		/// <summary>To be added.</summary>
		Rgba8Uint = 1,
		/// <summary>To be added.</summary>
		Rgba16Float = 2,
		Automatic = 3,
	}
	/// <summary>Extension methods for the <see cref="global::CoreAnimation.CAContentsFormat" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CAContentsFormatExtensions {
		static IntPtr[] values = new IntPtr [4];
		[Field ("kCAContentsFormatGray8Uint", "CoreAnimation")]
		internal unsafe static IntPtr kCAContentsFormatGray8Uint {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.CoreAnimation.Handle, "kCAContentsFormatGray8Uint", storage);
			}
		}
		[Field ("kCAContentsFormatRGBA8Uint", "CoreAnimation")]
		internal unsafe static IntPtr kCAContentsFormatRGBA8Uint {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.CoreAnimation.Handle, "kCAContentsFormatRGBA8Uint", storage);
			}
		}
		[Field ("kCAContentsFormatRGBA16Float", "CoreAnimation")]
		internal unsafe static IntPtr kCAContentsFormatRGBA16Float {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.CoreAnimation.Handle, "kCAContentsFormatRGBA16Float", storage);
			}
		}
		[Field ("kCAContentsFormatAutomatic", "CoreAnimation")]
		internal unsafe static IntPtr kCAContentsFormatAutomatic {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.CoreAnimation.Handle, "kCAContentsFormatAutomatic", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this CAContentsFormat self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // CAContentsFormat.Gray8Uint
				ptr = kCAContentsFormatGray8Uint;
				break;
			case 1: // CAContentsFormat.Rgba8Uint
				ptr = kCAContentsFormatRGBA8Uint;
				break;
			case 2: // CAContentsFormat.Rgba16Float
				ptr = kCAContentsFormatRGBA16Float;
				break;
			case 3: // CAContentsFormat.Automatic
				ptr = kCAContentsFormatAutomatic;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::CoreAnimation.CAContentsFormat" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static CAContentsFormat GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (kCAContentsFormatGray8Uint))
				return CAContentsFormat.Gray8Uint;
			if (constant.IsEqualTo (kCAContentsFormatRGBA8Uint))
				return CAContentsFormat.Rgba8Uint;
			if (constant.IsEqualTo (kCAContentsFormatRGBA16Float))
				return CAContentsFormat.Rgba16Float;
			if (constant.IsEqualTo (kCAContentsFormatAutomatic))
				return CAContentsFormat.Automatic;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::CoreAnimation.CAContentsFormat" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CAContentsFormat GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::CoreAnimation.CAContentsFormat" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static CAContentsFormat? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::CoreAnimation.CAContentsFormat" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this CAContentsFormat[]? values)
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
		internal static CAContentsFormat[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<CAContentsFormat> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
