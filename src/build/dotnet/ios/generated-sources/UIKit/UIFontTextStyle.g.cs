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
	/// <summary>Enumerates font styles for parts of a document.</summary><remarks>To be added.</remarks>
	public enum UIFontTextStyle : int {
		/// <summary>Indicated headline text.</summary>
		Headline = 0,
		/// <summary>Indicates body text.</summary>
		Body = 1,
		/// <summary>Indicates a subheading.</summary>
		Subheadline = 2,
		/// <summary>Indicates footnote text.</summary>
		Footnote = 3,
		/// <summary>Indicates primary captions.</summary>
		Caption1 = 4,
		/// <summary>Indicates alternate captions.</summary>
		Caption2 = 5,
		/// <summary>Indicates a first level heading.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		Title1 = 6,
		/// <summary>Indicates a second level heading.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		Title2 = 7,
		/// <summary>Indicates a third level heading.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		Title3 = 8,
		/// <summary>Indicates callout text.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		Callout = 9,
		/// <summary>Indicates a large title.</summary>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		LargeTitle = 10,
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		ExtraLargeTitle = 11,
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		ExtraLargeTitle2 = 12,
	}
	/// <summary>Extension methods for the <see cref="global::UIKit.UIFontTextStyle" /> enumeration.</summary>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class UIFontTextStyleExtensions {
		static IntPtr[] values = new IntPtr [13];
		[Field ("UIFontTextStyleHeadline", "UIKit")]
		internal unsafe static IntPtr UIFontTextStyleHeadline {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIFontTextStyleHeadline", storage);
			}
		}
		[Field ("UIFontTextStyleBody", "UIKit")]
		internal unsafe static IntPtr UIFontTextStyleBody {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIFontTextStyleBody", storage);
			}
		}
		[Field ("UIFontTextStyleSubheadline", "UIKit")]
		internal unsafe static IntPtr UIFontTextStyleSubheadline {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIFontTextStyleSubheadline", storage);
			}
		}
		[Field ("UIFontTextStyleFootnote", "UIKit")]
		internal unsafe static IntPtr UIFontTextStyleFootnote {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIFontTextStyleFootnote", storage);
			}
		}
		[Field ("UIFontTextStyleCaption1", "UIKit")]
		internal unsafe static IntPtr UIFontTextStyleCaption1 {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIFontTextStyleCaption1", storage);
			}
		}
		[Field ("UIFontTextStyleCaption2", "UIKit")]
		internal unsafe static IntPtr UIFontTextStyleCaption2 {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIFontTextStyleCaption2", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("UIFontTextStyleTitle1", "UIKit")]
		internal unsafe static IntPtr UIFontTextStyleTitle1 {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIFontTextStyleTitle1", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("UIFontTextStyleTitle2", "UIKit")]
		internal unsafe static IntPtr UIFontTextStyleTitle2 {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIFontTextStyleTitle2", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("UIFontTextStyleTitle3", "UIKit")]
		internal unsafe static IntPtr UIFontTextStyleTitle3 {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIFontTextStyleTitle3", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("UIFontTextStyleCallout", "UIKit")]
		internal unsafe static IntPtr UIFontTextStyleCallout {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIFontTextStyleCallout", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[Field ("UIFontTextStyleLargeTitle", "UIKit")]
		internal unsafe static IntPtr UIFontTextStyleLargeTitle {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIFontTextStyleLargeTitle", storage);
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[Field ("UIFontTextStyleExtraLargeTitle", "UIKit")]
		internal unsafe static IntPtr UIFontTextStyleExtraLargeTitle {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIFontTextStyleExtraLargeTitle", storage);
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[Field ("UIFontTextStyleExtraLargeTitle2", "UIKit")]
		internal unsafe static IntPtr UIFontTextStyleExtraLargeTitle2 {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIFontTextStyleExtraLargeTitle2", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this UIFontTextStyle self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // UIFontTextStyle.Headline
				ptr = UIFontTextStyleHeadline;
				break;
			case 1: // UIFontTextStyle.Body
				ptr = UIFontTextStyleBody;
				break;
			case 2: // UIFontTextStyle.Subheadline
				ptr = UIFontTextStyleSubheadline;
				break;
			case 3: // UIFontTextStyle.Footnote
				ptr = UIFontTextStyleFootnote;
				break;
			case 4: // UIFontTextStyle.Caption1
				ptr = UIFontTextStyleCaption1;
				break;
			case 5: // UIFontTextStyle.Caption2
				ptr = UIFontTextStyleCaption2;
				break;
			case 6: // UIFontTextStyle.Title1
				ptr = UIFontTextStyleTitle1;
				break;
			case 7: // UIFontTextStyle.Title2
				ptr = UIFontTextStyleTitle2;
				break;
			case 8: // UIFontTextStyle.Title3
				ptr = UIFontTextStyleTitle3;
				break;
			case 9: // UIFontTextStyle.Callout
				ptr = UIFontTextStyleCallout;
				break;
			case 10: // UIFontTextStyle.LargeTitle
				ptr = UIFontTextStyleLargeTitle;
				break;
			case 11: // UIFontTextStyle.ExtraLargeTitle
				ptr = UIFontTextStyleExtraLargeTitle;
				break;
			case 12: // UIFontTextStyle.ExtraLargeTitle2
				ptr = UIFontTextStyleExtraLargeTitle2;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UIFontTextStyle" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static UIFontTextStyle GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (UIFontTextStyleHeadline))
				return UIFontTextStyle.Headline;
			if (constant.IsEqualTo (UIFontTextStyleBody))
				return UIFontTextStyle.Body;
			if (constant.IsEqualTo (UIFontTextStyleSubheadline))
				return UIFontTextStyle.Subheadline;
			if (constant.IsEqualTo (UIFontTextStyleFootnote))
				return UIFontTextStyle.Footnote;
			if (constant.IsEqualTo (UIFontTextStyleCaption1))
				return UIFontTextStyle.Caption1;
			if (constant.IsEqualTo (UIFontTextStyleCaption2))
				return UIFontTextStyle.Caption2;
			if (constant.IsEqualTo (UIFontTextStyleTitle1))
				return UIFontTextStyle.Title1;
			if (constant.IsEqualTo (UIFontTextStyleTitle2))
				return UIFontTextStyle.Title2;
			if (constant.IsEqualTo (UIFontTextStyleTitle3))
				return UIFontTextStyle.Title3;
			if (constant.IsEqualTo (UIFontTextStyleCallout))
				return UIFontTextStyle.Callout;
			if (constant.IsEqualTo (UIFontTextStyleLargeTitle))
				return UIFontTextStyle.LargeTitle;
			if (constant.IsEqualTo (UIFontTextStyleExtraLargeTitle))
				return UIFontTextStyle.ExtraLargeTitle;
			if (constant.IsEqualTo (UIFontTextStyleExtraLargeTitle2))
				return UIFontTextStyle.ExtraLargeTitle2;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UIFontTextStyle" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static UIFontTextStyle GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UIFontTextStyle" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static UIFontTextStyle? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::UIKit.UIFontTextStyle" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this UIFontTextStyle[]? values)
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
		internal static UIFontTextStyle[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<UIFontTextStyle> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
