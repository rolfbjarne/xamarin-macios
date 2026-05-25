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
namespace UIKit {
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	public enum UIFontDescriptorSystemDesign : int {
		Default = 0,
		Rounded = 1,
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		Serif = 2,
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		Monospaced = 3,
	}
	/// <summary>Extension methods for the <see cref="global::UIKit.UIFontDescriptorSystemDesign" /> enumeration.</summary>
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class UIFontDescriptorSystemDesignExtensions {
		static IntPtr[] values = new IntPtr [4];
		[Field ("UIFontDescriptorSystemDesignDefault", "UIKit")]
		internal unsafe static IntPtr UIFontDescriptorSystemDesignDefault {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIFontDescriptorSystemDesignDefault", storage);
			}
		}
		[Field ("UIFontDescriptorSystemDesignRounded", "UIKit")]
		internal unsafe static IntPtr UIFontDescriptorSystemDesignRounded {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIFontDescriptorSystemDesignRounded", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[Field ("UIFontDescriptorSystemDesignSerif", "UIKit")]
		internal unsafe static IntPtr UIFontDescriptorSystemDesignSerif {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIFontDescriptorSystemDesignSerif", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[Field ("UIFontDescriptorSystemDesignMonospaced", "UIKit")]
		internal unsafe static IntPtr UIFontDescriptorSystemDesignMonospaced {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIFontDescriptorSystemDesignMonospaced", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this UIFontDescriptorSystemDesign self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // UIFontDescriptorSystemDesign.Default
			default:
				ptr = UIFontDescriptorSystemDesignDefault;
				break;
			case 1: // UIFontDescriptorSystemDesign.Rounded
				ptr = UIFontDescriptorSystemDesignRounded;
				break;
			case 2: // UIFontDescriptorSystemDesign.Serif
				ptr = UIFontDescriptorSystemDesignSerif;
				break;
			case 3: // UIFontDescriptorSystemDesign.Monospaced
				ptr = UIFontDescriptorSystemDesignMonospaced;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UIFontDescriptorSystemDesign" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static UIFontDescriptorSystemDesign GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (UIFontDescriptorSystemDesignDefault))
				return UIFontDescriptorSystemDesign.Default;
			if (constant.IsEqualTo (UIFontDescriptorSystemDesignRounded))
				return UIFontDescriptorSystemDesign.Rounded;
			if (constant.IsEqualTo (UIFontDescriptorSystemDesignSerif))
				return UIFontDescriptorSystemDesign.Serif;
			if (constant.IsEqualTo (UIFontDescriptorSystemDesignMonospaced))
				return UIFontDescriptorSystemDesign.Monospaced;
			return UIFontDescriptorSystemDesign.Default;
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UIFontDescriptorSystemDesign" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static UIFontDescriptorSystemDesign GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UIFontDescriptorSystemDesign" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static UIFontDescriptorSystemDesign? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::UIKit.UIFontDescriptorSystemDesign" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this UIFontDescriptorSystemDesign[]? values)
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
		internal static UIFontDescriptorSystemDesign[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<UIFontDescriptorSystemDesign> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
