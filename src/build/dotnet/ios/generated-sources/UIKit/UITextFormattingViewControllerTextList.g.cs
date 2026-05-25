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
	[Flags]
	public enum UITextFormattingViewControllerTextList : int {
		Disc = 1,
		Hyphen = 2,
		Decimal = 4,
		Other = 8,
	}
	/// <summary>Extension methods for the <see cref="global::UIKit.UITextFormattingViewControllerTextList" /> enumeration.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios18.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class UITextFormattingViewControllerTextListExtensions {
		static IntPtr[] values = new IntPtr [4];
		[Field ("UITextFormattingViewControllerTextListDisc", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerTextListDisc {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerTextListDisc", storage);
			}
		}
		[Field ("UITextFormattingViewControllerTextListHyphen", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerTextListHyphen {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerTextListHyphen", storage);
			}
		}
		[Field ("UITextFormattingViewControllerTextListDecimal", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerTextListDecimal {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerTextListDecimal", storage);
			}
		}
		[Field ("UITextFormattingViewControllerTextListOther", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerTextListOther {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerTextListOther", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this UITextFormattingViewControllerTextList self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 1: // UITextFormattingViewControllerTextList.Disc
				ptr = UITextFormattingViewControllerTextListDisc;
				break;
			case 2: // UITextFormattingViewControllerTextList.Hyphen
				ptr = UITextFormattingViewControllerTextListHyphen;
				break;
			case 4: // UITextFormattingViewControllerTextList.Decimal
				ptr = UITextFormattingViewControllerTextListDecimal;
				break;
			case 8: // UITextFormattingViewControllerTextList.Other
				ptr = UITextFormattingViewControllerTextListOther;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UITextFormattingViewControllerTextList" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static UITextFormattingViewControllerTextList GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (UITextFormattingViewControllerTextListDisc))
				return UITextFormattingViewControllerTextList.Disc;
			if (constant.IsEqualTo (UITextFormattingViewControllerTextListHyphen))
				return UITextFormattingViewControllerTextList.Hyphen;
			if (constant.IsEqualTo (UITextFormattingViewControllerTextListDecimal))
				return UITextFormattingViewControllerTextList.Decimal;
			if (constant.IsEqualTo (UITextFormattingViewControllerTextListOther))
				return UITextFormattingViewControllerTextList.Other;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UITextFormattingViewControllerTextList" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static UITextFormattingViewControllerTextList GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UITextFormattingViewControllerTextList" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static UITextFormattingViewControllerTextList? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::UIKit.UITextFormattingViewControllerTextList" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this UITextFormattingViewControllerTextList[]? values)
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
		internal static UITextFormattingViewControllerTextList[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<UITextFormattingViewControllerTextList> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
		/// <summary>Retrieves all the <see cref="global::UIKit.UITextFormattingViewControllerTextList" /> constants named by the flags <paramref name="value" />.</summary>
		/// <param name="value">The flags to retrieve</param>
		/// <remarks>Any flags that are not recognized will be ignored.</remarks>
		public static NSString[] ToArray (this UITextFormattingViewControllerTextList value)
		{
			var rv = new global::System.Collections.Generic.List<NSString> ();
			if (value.HasFlag (UITextFormattingViewControllerTextList.Disc) && UITextFormattingViewControllerTextListDisc != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (UITextFormattingViewControllerTextListDisc)!);
			if (value.HasFlag (UITextFormattingViewControllerTextList.Hyphen) && UITextFormattingViewControllerTextListHyphen != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (UITextFormattingViewControllerTextListHyphen)!);
			if (value.HasFlag (UITextFormattingViewControllerTextList.Decimal) && UITextFormattingViewControllerTextListDecimal != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (UITextFormattingViewControllerTextListDecimal)!);
			if (value.HasFlag (UITextFormattingViewControllerTextList.Other) && UITextFormattingViewControllerTextListOther != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (UITextFormattingViewControllerTextListOther)!);
			// In order to be forward-compatible, any unknown values are ignored.
			return rv.ToArray ();
		}
		public static UITextFormattingViewControllerTextList ToFlags (global::System.Collections.Generic.IEnumerable<NSString> constants)
		{
			var rv = default (UITextFormattingViewControllerTextList);
			if (constants is null)
				return rv;
			foreach (var constant in constants) {
				if (constant.IsEqualTo (UITextFormattingViewControllerTextListDisc))
					rv |= UITextFormattingViewControllerTextList.Disc;
				else if (constant.IsEqualTo (UITextFormattingViewControllerTextListHyphen))
					rv |= UITextFormattingViewControllerTextList.Hyphen;
				else if (constant.IsEqualTo (UITextFormattingViewControllerTextListDecimal))
					rv |= UITextFormattingViewControllerTextList.Decimal;
				else if (constant.IsEqualTo (UITextFormattingViewControllerTextListOther))
					rv |= UITextFormattingViewControllerTextList.Other;
				// In order to be forward-compatible, any unknown values are ignored.
			}
			return rv;
		}
	}
}
