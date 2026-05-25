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
	public enum UITextFormattingViewControllerChangeType : int {
		Undefined = 0,
		SetBold = 1,
		RemoveBold = 2,
		SetItalic = 3,
		RemoveItalic = 4,
		SetUnderline = 5,
		RemoveUnderline = 6,
		SetStrikethrough = 7,
		RemoveStrikethrough = 8,
		Font = 9,
		FontSize = 10,
		IncreaseFontSize = 11,
		DecreaseFontSize = 12,
		TextColor = 13,
		LineHeightPointSize = 14,
		IncreaseIndentation = 15,
		DecreaseIndentation = 16,
		FormattingStyle = 17,
		TextList = 18,
		TextAlignment = 19,
		Highlight = 20,
	}
	/// <summary>Extension methods for the <see cref="global::UIKit.UITextFormattingViewControllerChangeType" /> enumeration.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios18.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class UITextFormattingViewControllerChangeTypeExtensions {
		static IntPtr[] values = new IntPtr [21];
		[Field ("UITextFormattingViewControllerUndefinedChangeType", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerUndefinedChangeType {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerUndefinedChangeType", storage);
			}
		}
		[Field ("UITextFormattingViewControllerSetBoldChangeType", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerSetBoldChangeType {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerSetBoldChangeType", storage);
			}
		}
		[Field ("UITextFormattingViewControllerRemoveBoldChangeType", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerRemoveBoldChangeType {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerRemoveBoldChangeType", storage);
			}
		}
		[Field ("UITextFormattingViewControllerSetItalicChangeType", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerSetItalicChangeType {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerSetItalicChangeType", storage);
			}
		}
		[Field ("UITextFormattingViewControllerRemoveItalicChangeType", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerRemoveItalicChangeType {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerRemoveItalicChangeType", storage);
			}
		}
		[Field ("UITextFormattingViewControllerSetUnderlineChangeType", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerSetUnderlineChangeType {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerSetUnderlineChangeType", storage);
			}
		}
		[Field ("UITextFormattingViewControllerRemoveUnderlineChangeType", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerRemoveUnderlineChangeType {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerRemoveUnderlineChangeType", storage);
			}
		}
		[Field ("UITextFormattingViewControllerSetStrikethroughChangeType", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerSetStrikethroughChangeType {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerSetStrikethroughChangeType", storage);
			}
		}
		[Field ("UITextFormattingViewControllerRemoveStrikethroughChangeType", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerRemoveStrikethroughChangeType {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerRemoveStrikethroughChangeType", storage);
			}
		}
		[Field ("UITextFormattingViewControllerFontChangeType", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerFontChangeType {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerFontChangeType", storage);
			}
		}
		[Field ("UITextFormattingViewControllerFontSizeChangeType", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerFontSizeChangeType {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerFontSizeChangeType", storage);
			}
		}
		[Field ("UITextFormattingViewControllerIncreaseFontSizeChangeType", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerIncreaseFontSizeChangeType {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerIncreaseFontSizeChangeType", storage);
			}
		}
		[Field ("UITextFormattingViewControllerDecreaseFontSizeChangeType", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerDecreaseFontSizeChangeType {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerDecreaseFontSizeChangeType", storage);
			}
		}
		[Field ("UITextFormattingViewControllerTextColorChangeType", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerTextColorChangeType {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerTextColorChangeType", storage);
			}
		}
		[Field ("UITextFormattingViewControllerLineHeightPointSizeChangeType", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerLineHeightPointSizeChangeType {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerLineHeightPointSizeChangeType", storage);
			}
		}
		[Field ("UITextFormattingViewControllerIncreaseIndentationChangeType", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerIncreaseIndentationChangeType {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerIncreaseIndentationChangeType", storage);
			}
		}
		[Field ("UITextFormattingViewControllerDecreaseIndentationChangeType", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerDecreaseIndentationChangeType {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerDecreaseIndentationChangeType", storage);
			}
		}
		[Field ("UITextFormattingViewControllerFormattingStyleChangeType", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerFormattingStyleChangeType {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerFormattingStyleChangeType", storage);
			}
		}
		[Field ("UITextFormattingViewControllerTextListChangeType", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerTextListChangeType {
			get {
				fixed (IntPtr *storage = &values [18])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerTextListChangeType", storage);
			}
		}
		[Field ("UITextFormattingViewControllerTextAlignmentChangeType", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerTextAlignmentChangeType {
			get {
				fixed (IntPtr *storage = &values [19])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerTextAlignmentChangeType", storage);
			}
		}
		[Field ("UITextFormattingViewControllerHighlightChangeType", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerHighlightChangeType {
			get {
				fixed (IntPtr *storage = &values [20])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerHighlightChangeType", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this UITextFormattingViewControllerChangeType self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // UITextFormattingViewControllerChangeType.Undefined
			default:
				ptr = UITextFormattingViewControllerUndefinedChangeType;
				break;
			case 1: // UITextFormattingViewControllerChangeType.SetBold
				ptr = UITextFormattingViewControllerSetBoldChangeType;
				break;
			case 2: // UITextFormattingViewControllerChangeType.RemoveBold
				ptr = UITextFormattingViewControllerRemoveBoldChangeType;
				break;
			case 3: // UITextFormattingViewControllerChangeType.SetItalic
				ptr = UITextFormattingViewControllerSetItalicChangeType;
				break;
			case 4: // UITextFormattingViewControllerChangeType.RemoveItalic
				ptr = UITextFormattingViewControllerRemoveItalicChangeType;
				break;
			case 5: // UITextFormattingViewControllerChangeType.SetUnderline
				ptr = UITextFormattingViewControllerSetUnderlineChangeType;
				break;
			case 6: // UITextFormattingViewControllerChangeType.RemoveUnderline
				ptr = UITextFormattingViewControllerRemoveUnderlineChangeType;
				break;
			case 7: // UITextFormattingViewControllerChangeType.SetStrikethrough
				ptr = UITextFormattingViewControllerSetStrikethroughChangeType;
				break;
			case 8: // UITextFormattingViewControllerChangeType.RemoveStrikethrough
				ptr = UITextFormattingViewControllerRemoveStrikethroughChangeType;
				break;
			case 9: // UITextFormattingViewControllerChangeType.Font
				ptr = UITextFormattingViewControllerFontChangeType;
				break;
			case 10: // UITextFormattingViewControllerChangeType.FontSize
				ptr = UITextFormattingViewControllerFontSizeChangeType;
				break;
			case 11: // UITextFormattingViewControllerChangeType.IncreaseFontSize
				ptr = UITextFormattingViewControllerIncreaseFontSizeChangeType;
				break;
			case 12: // UITextFormattingViewControllerChangeType.DecreaseFontSize
				ptr = UITextFormattingViewControllerDecreaseFontSizeChangeType;
				break;
			case 13: // UITextFormattingViewControllerChangeType.TextColor
				ptr = UITextFormattingViewControllerTextColorChangeType;
				break;
			case 14: // UITextFormattingViewControllerChangeType.LineHeightPointSize
				ptr = UITextFormattingViewControllerLineHeightPointSizeChangeType;
				break;
			case 15: // UITextFormattingViewControllerChangeType.IncreaseIndentation
				ptr = UITextFormattingViewControllerIncreaseIndentationChangeType;
				break;
			case 16: // UITextFormattingViewControllerChangeType.DecreaseIndentation
				ptr = UITextFormattingViewControllerDecreaseIndentationChangeType;
				break;
			case 17: // UITextFormattingViewControllerChangeType.FormattingStyle
				ptr = UITextFormattingViewControllerFormattingStyleChangeType;
				break;
			case 18: // UITextFormattingViewControllerChangeType.TextList
				ptr = UITextFormattingViewControllerTextListChangeType;
				break;
			case 19: // UITextFormattingViewControllerChangeType.TextAlignment
				ptr = UITextFormattingViewControllerTextAlignmentChangeType;
				break;
			case 20: // UITextFormattingViewControllerChangeType.Highlight
				ptr = UITextFormattingViewControllerHighlightChangeType;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UITextFormattingViewControllerChangeType" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static UITextFormattingViewControllerChangeType GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (UITextFormattingViewControllerUndefinedChangeType))
				return UITextFormattingViewControllerChangeType.Undefined;
			if (constant.IsEqualTo (UITextFormattingViewControllerSetBoldChangeType))
				return UITextFormattingViewControllerChangeType.SetBold;
			if (constant.IsEqualTo (UITextFormattingViewControllerRemoveBoldChangeType))
				return UITextFormattingViewControllerChangeType.RemoveBold;
			if (constant.IsEqualTo (UITextFormattingViewControllerSetItalicChangeType))
				return UITextFormattingViewControllerChangeType.SetItalic;
			if (constant.IsEqualTo (UITextFormattingViewControllerRemoveItalicChangeType))
				return UITextFormattingViewControllerChangeType.RemoveItalic;
			if (constant.IsEqualTo (UITextFormattingViewControllerSetUnderlineChangeType))
				return UITextFormattingViewControllerChangeType.SetUnderline;
			if (constant.IsEqualTo (UITextFormattingViewControllerRemoveUnderlineChangeType))
				return UITextFormattingViewControllerChangeType.RemoveUnderline;
			if (constant.IsEqualTo (UITextFormattingViewControllerSetStrikethroughChangeType))
				return UITextFormattingViewControllerChangeType.SetStrikethrough;
			if (constant.IsEqualTo (UITextFormattingViewControllerRemoveStrikethroughChangeType))
				return UITextFormattingViewControllerChangeType.RemoveStrikethrough;
			if (constant.IsEqualTo (UITextFormattingViewControllerFontChangeType))
				return UITextFormattingViewControllerChangeType.Font;
			if (constant.IsEqualTo (UITextFormattingViewControllerFontSizeChangeType))
				return UITextFormattingViewControllerChangeType.FontSize;
			if (constant.IsEqualTo (UITextFormattingViewControllerIncreaseFontSizeChangeType))
				return UITextFormattingViewControllerChangeType.IncreaseFontSize;
			if (constant.IsEqualTo (UITextFormattingViewControllerDecreaseFontSizeChangeType))
				return UITextFormattingViewControllerChangeType.DecreaseFontSize;
			if (constant.IsEqualTo (UITextFormattingViewControllerTextColorChangeType))
				return UITextFormattingViewControllerChangeType.TextColor;
			if (constant.IsEqualTo (UITextFormattingViewControllerLineHeightPointSizeChangeType))
				return UITextFormattingViewControllerChangeType.LineHeightPointSize;
			if (constant.IsEqualTo (UITextFormattingViewControllerIncreaseIndentationChangeType))
				return UITextFormattingViewControllerChangeType.IncreaseIndentation;
			if (constant.IsEqualTo (UITextFormattingViewControllerDecreaseIndentationChangeType))
				return UITextFormattingViewControllerChangeType.DecreaseIndentation;
			if (constant.IsEqualTo (UITextFormattingViewControllerFormattingStyleChangeType))
				return UITextFormattingViewControllerChangeType.FormattingStyle;
			if (constant.IsEqualTo (UITextFormattingViewControllerTextListChangeType))
				return UITextFormattingViewControllerChangeType.TextList;
			if (constant.IsEqualTo (UITextFormattingViewControllerTextAlignmentChangeType))
				return UITextFormattingViewControllerChangeType.TextAlignment;
			if (constant.IsEqualTo (UITextFormattingViewControllerHighlightChangeType))
				return UITextFormattingViewControllerChangeType.Highlight;
			return UITextFormattingViewControllerChangeType.Undefined;
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UITextFormattingViewControllerChangeType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static UITextFormattingViewControllerChangeType GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UITextFormattingViewControllerChangeType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static UITextFormattingViewControllerChangeType? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::UIKit.UITextFormattingViewControllerChangeType" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this UITextFormattingViewControllerChangeType[]? values)
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
		internal static UITextFormattingViewControllerChangeType[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<UITextFormattingViewControllerChangeType> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
