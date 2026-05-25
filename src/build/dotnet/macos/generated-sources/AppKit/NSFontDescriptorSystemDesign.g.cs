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
namespace AppKit {
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum NSFontDescriptorSystemDesign : int {
		Default = 0,
		Serif = 1,
		Monospaced = 2,
		Rounded = 3,
	}
	/// <summary>Extension methods for the <see cref="global::AppKit.NSFontDescriptorSystemDesign" /> enumeration.</summary>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class NSFontDescriptorSystemDesignExtensions {
		static IntPtr[] values = new IntPtr [4];
		[Field ("NSFontDescriptorSystemDesignDefault", "AppKit")]
		internal unsafe static IntPtr NSFontDescriptorSystemDesignDefault {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSFontDescriptorSystemDesignDefault", storage);
			}
		}
		[Field ("NSFontDescriptorSystemDesignSerif", "AppKit")]
		internal unsafe static IntPtr NSFontDescriptorSystemDesignSerif {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSFontDescriptorSystemDesignSerif", storage);
			}
		}
		[Field ("NSFontDescriptorSystemDesignMonospaced", "AppKit")]
		internal unsafe static IntPtr NSFontDescriptorSystemDesignMonospaced {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSFontDescriptorSystemDesignMonospaced", storage);
			}
		}
		[Field ("NSFontDescriptorSystemDesignRounded", "AppKit")]
		internal unsafe static IntPtr NSFontDescriptorSystemDesignRounded {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSFontDescriptorSystemDesignRounded", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this NSFontDescriptorSystemDesign self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // NSFontDescriptorSystemDesign.Default
				ptr = NSFontDescriptorSystemDesignDefault;
				break;
			case 1: // NSFontDescriptorSystemDesign.Serif
				ptr = NSFontDescriptorSystemDesignSerif;
				break;
			case 2: // NSFontDescriptorSystemDesign.Monospaced
				ptr = NSFontDescriptorSystemDesignMonospaced;
				break;
			case 3: // NSFontDescriptorSystemDesign.Rounded
				ptr = NSFontDescriptorSystemDesignRounded;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AppKit.NSFontDescriptorSystemDesign" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static NSFontDescriptorSystemDesign GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (NSFontDescriptorSystemDesignDefault))
				return NSFontDescriptorSystemDesign.Default;
			if (constant.IsEqualTo (NSFontDescriptorSystemDesignSerif))
				return NSFontDescriptorSystemDesign.Serif;
			if (constant.IsEqualTo (NSFontDescriptorSystemDesignMonospaced))
				return NSFontDescriptorSystemDesign.Monospaced;
			if (constant.IsEqualTo (NSFontDescriptorSystemDesignRounded))
				return NSFontDescriptorSystemDesign.Rounded;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AppKit.NSFontDescriptorSystemDesign" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSFontDescriptorSystemDesign GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AppKit.NSFontDescriptorSystemDesign" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSFontDescriptorSystemDesign? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AppKit.NSFontDescriptorSystemDesign" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this NSFontDescriptorSystemDesign[]? values)
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
		internal static NSFontDescriptorSystemDesign[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSFontDescriptorSystemDesign> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
