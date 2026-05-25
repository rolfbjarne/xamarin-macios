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
namespace UIKit {
	[SupportedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	[UnsupportedOSPlatform ("macos")]
	public enum NSTextHighlightColorScheme : int {
		Default = 0,
		Purple = 1,
		Pink = 2,
		Orange = 3,
		Mint = 4,
		Blue = 5,
	}
	/// <summary>Extension methods for the <see cref="global::UIKit.NSTextHighlightColorScheme" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	[UnsupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class NSTextHighlightColorSchemeExtensions {
		static IntPtr[] values = new IntPtr [6];
		[Field ("NSTextHighlightColorSchemeDefault", "UIKit")]
		internal unsafe static IntPtr NSTextHighlightColorSchemeDefault {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "NSTextHighlightColorSchemeDefault", storage);
			}
		}
		[Field ("NSTextHighlightColorSchemePurple", "UIKit")]
		internal unsafe static IntPtr NSTextHighlightColorSchemePurple {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "NSTextHighlightColorSchemePurple", storage);
			}
		}
		[Field ("NSTextHighlightColorSchemePink", "UIKit")]
		internal unsafe static IntPtr NSTextHighlightColorSchemePink {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "NSTextHighlightColorSchemePink", storage);
			}
		}
		[Field ("NSTextHighlightColorSchemeOrange", "UIKit")]
		internal unsafe static IntPtr NSTextHighlightColorSchemeOrange {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "NSTextHighlightColorSchemeOrange", storage);
			}
		}
		[Field ("NSTextHighlightColorSchemeMint", "UIKit")]
		internal unsafe static IntPtr NSTextHighlightColorSchemeMint {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "NSTextHighlightColorSchemeMint", storage);
			}
		}
		[Field ("NSTextHighlightColorSchemeBlue", "UIKit")]
		internal unsafe static IntPtr NSTextHighlightColorSchemeBlue {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "NSTextHighlightColorSchemeBlue", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this NSTextHighlightColorScheme self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // NSTextHighlightColorScheme.Default
			default:
				ptr = NSTextHighlightColorSchemeDefault;
				break;
			case 1: // NSTextHighlightColorScheme.Purple
				ptr = NSTextHighlightColorSchemePurple;
				break;
			case 2: // NSTextHighlightColorScheme.Pink
				ptr = NSTextHighlightColorSchemePink;
				break;
			case 3: // NSTextHighlightColorScheme.Orange
				ptr = NSTextHighlightColorSchemeOrange;
				break;
			case 4: // NSTextHighlightColorScheme.Mint
				ptr = NSTextHighlightColorSchemeMint;
				break;
			case 5: // NSTextHighlightColorScheme.Blue
				ptr = NSTextHighlightColorSchemeBlue;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.NSTextHighlightColorScheme" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static NSTextHighlightColorScheme GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (NSTextHighlightColorSchemeDefault))
				return NSTextHighlightColorScheme.Default;
			if (constant.IsEqualTo (NSTextHighlightColorSchemePurple))
				return NSTextHighlightColorScheme.Purple;
			if (constant.IsEqualTo (NSTextHighlightColorSchemePink))
				return NSTextHighlightColorScheme.Pink;
			if (constant.IsEqualTo (NSTextHighlightColorSchemeOrange))
				return NSTextHighlightColorScheme.Orange;
			if (constant.IsEqualTo (NSTextHighlightColorSchemeMint))
				return NSTextHighlightColorScheme.Mint;
			if (constant.IsEqualTo (NSTextHighlightColorSchemeBlue))
				return NSTextHighlightColorScheme.Blue;
			return NSTextHighlightColorScheme.Default;
		}
		/// <summary>Retrieves the <see cref="global::UIKit.NSTextHighlightColorScheme" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSTextHighlightColorScheme GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.NSTextHighlightColorScheme" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSTextHighlightColorScheme? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::UIKit.NSTextHighlightColorScheme" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this NSTextHighlightColorScheme[]? values)
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
		internal static NSTextHighlightColorScheme[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSTextHighlightColorScheme> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
