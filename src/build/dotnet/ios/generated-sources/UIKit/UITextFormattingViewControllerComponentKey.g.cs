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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace UIKit {
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios18.0")]
	public enum UITextFormattingViewControllerComponentKey : int {
		FormattingStyles = 0,
		FontAttributes = 1,
		FontPicker = 2,
		FontSize = 3,
		FontPointSize = 4,
		TextAlignment = 5,
		TextAlignmentAndJustification = 6,
		TextIndentation = 7,
		LineHeight = 8,
		ListStyles = 9,
		TextColor = 10,
		Highlight = 11,
		HighlightPicker = 12,
	}
	/// <summary>Extension methods for the <see cref="global::UIKit.UITextFormattingViewControllerComponentKey" /> enumeration.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios18.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class UITextFormattingViewControllerComponentKeyExtensions {
		static IntPtr[] values = new IntPtr [13];
		[Field ("UITextFormattingViewControllerFormattingStylesComponentKey", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerFormattingStylesComponentKey {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerFormattingStylesComponentKey", storage);
			}
		}
		[Field ("UITextFormattingViewControllerFontAttributesComponentKey", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerFontAttributesComponentKey {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerFontAttributesComponentKey", storage);
			}
		}
		[Field ("UITextFormattingViewControllerFontPickerComponentKey", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerFontPickerComponentKey {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerFontPickerComponentKey", storage);
			}
		}
		[Field ("UITextFormattingViewControllerFontSizeComponentKey", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerFontSizeComponentKey {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerFontSizeComponentKey", storage);
			}
		}
		[Field ("UITextFormattingViewControllerFontPointSizeComponentKey", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerFontPointSizeComponentKey {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerFontPointSizeComponentKey", storage);
			}
		}
		[Field ("UITextFormattingViewControllerTextAlignmentComponentKey", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerTextAlignmentComponentKey {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerTextAlignmentComponentKey", storage);
			}
		}
		[Field ("UITextFormattingViewControllerTextAlignmentAndJustificationComponentKey", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerTextAlignmentAndJustificationComponentKey {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerTextAlignmentAndJustificationComponentKey", storage);
			}
		}
		[Field ("UITextFormattingViewControllerTextIndentationComponentKey", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerTextIndentationComponentKey {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerTextIndentationComponentKey", storage);
			}
		}
		[Field ("UITextFormattingViewControllerLineHeightComponentKey", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerLineHeightComponentKey {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerLineHeightComponentKey", storage);
			}
		}
		[Field ("UITextFormattingViewControllerListStylesComponentKey", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerListStylesComponentKey {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerListStylesComponentKey", storage);
			}
		}
		[Field ("UITextFormattingViewControllerTextColorComponentKey", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerTextColorComponentKey {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerTextColorComponentKey", storage);
			}
		}
		[Field ("UITextFormattingViewControllerHighlightComponentKey", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerHighlightComponentKey {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerHighlightComponentKey", storage);
			}
		}
		[Field ("UITextFormattingViewControllerHighlightPickerComponentKey", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerHighlightPickerComponentKey {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerHighlightPickerComponentKey", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this UITextFormattingViewControllerComponentKey self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // UITextFormattingViewControllerComponentKey.FormattingStyles
				ptr = UITextFormattingViewControllerFormattingStylesComponentKey;
				break;
			case 1: // UITextFormattingViewControllerComponentKey.FontAttributes
				ptr = UITextFormattingViewControllerFontAttributesComponentKey;
				break;
			case 2: // UITextFormattingViewControllerComponentKey.FontPicker
				ptr = UITextFormattingViewControllerFontPickerComponentKey;
				break;
			case 3: // UITextFormattingViewControllerComponentKey.FontSize
				ptr = UITextFormattingViewControllerFontSizeComponentKey;
				break;
			case 4: // UITextFormattingViewControllerComponentKey.FontPointSize
				ptr = UITextFormattingViewControllerFontPointSizeComponentKey;
				break;
			case 5: // UITextFormattingViewControllerComponentKey.TextAlignment
				ptr = UITextFormattingViewControllerTextAlignmentComponentKey;
				break;
			case 6: // UITextFormattingViewControllerComponentKey.TextAlignmentAndJustification
				ptr = UITextFormattingViewControllerTextAlignmentAndJustificationComponentKey;
				break;
			case 7: // UITextFormattingViewControllerComponentKey.TextIndentation
				ptr = UITextFormattingViewControllerTextIndentationComponentKey;
				break;
			case 8: // UITextFormattingViewControllerComponentKey.LineHeight
				ptr = UITextFormattingViewControllerLineHeightComponentKey;
				break;
			case 9: // UITextFormattingViewControllerComponentKey.ListStyles
				ptr = UITextFormattingViewControllerListStylesComponentKey;
				break;
			case 10: // UITextFormattingViewControllerComponentKey.TextColor
				ptr = UITextFormattingViewControllerTextColorComponentKey;
				break;
			case 11: // UITextFormattingViewControllerComponentKey.Highlight
				ptr = UITextFormattingViewControllerHighlightComponentKey;
				break;
			case 12: // UITextFormattingViewControllerComponentKey.HighlightPicker
				ptr = UITextFormattingViewControllerHighlightPickerComponentKey;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UITextFormattingViewControllerComponentKey" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static UITextFormattingViewControllerComponentKey GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (UITextFormattingViewControllerFormattingStylesComponentKey))
				return UITextFormattingViewControllerComponentKey.FormattingStyles;
			if (constant.IsEqualTo (UITextFormattingViewControllerFontAttributesComponentKey))
				return UITextFormattingViewControllerComponentKey.FontAttributes;
			if (constant.IsEqualTo (UITextFormattingViewControllerFontPickerComponentKey))
				return UITextFormattingViewControllerComponentKey.FontPicker;
			if (constant.IsEqualTo (UITextFormattingViewControllerFontSizeComponentKey))
				return UITextFormattingViewControllerComponentKey.FontSize;
			if (constant.IsEqualTo (UITextFormattingViewControllerFontPointSizeComponentKey))
				return UITextFormattingViewControllerComponentKey.FontPointSize;
			if (constant.IsEqualTo (UITextFormattingViewControllerTextAlignmentComponentKey))
				return UITextFormattingViewControllerComponentKey.TextAlignment;
			if (constant.IsEqualTo (UITextFormattingViewControllerTextAlignmentAndJustificationComponentKey))
				return UITextFormattingViewControllerComponentKey.TextAlignmentAndJustification;
			if (constant.IsEqualTo (UITextFormattingViewControllerTextIndentationComponentKey))
				return UITextFormattingViewControllerComponentKey.TextIndentation;
			if (constant.IsEqualTo (UITextFormattingViewControllerLineHeightComponentKey))
				return UITextFormattingViewControllerComponentKey.LineHeight;
			if (constant.IsEqualTo (UITextFormattingViewControllerListStylesComponentKey))
				return UITextFormattingViewControllerComponentKey.ListStyles;
			if (constant.IsEqualTo (UITextFormattingViewControllerTextColorComponentKey))
				return UITextFormattingViewControllerComponentKey.TextColor;
			if (constant.IsEqualTo (UITextFormattingViewControllerHighlightComponentKey))
				return UITextFormattingViewControllerComponentKey.Highlight;
			if (constant.IsEqualTo (UITextFormattingViewControllerHighlightPickerComponentKey))
				return UITextFormattingViewControllerComponentKey.HighlightPicker;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UITextFormattingViewControllerComponentKey" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static UITextFormattingViewControllerComponentKey GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UITextFormattingViewControllerComponentKey" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static UITextFormattingViewControllerComponentKey? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::UIKit.UITextFormattingViewControllerComponentKey" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this UITextFormattingViewControllerComponentKey[]? values)
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
		internal static UITextFormattingViewControllerComponentKey[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<UITextFormattingViewControllerComponentKey> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
