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
	/// <summary>An enumeration whose values specify the various dynamic type sizes that can be chosen by the application user.</summary><remarks><para>
	/// After the application user has set the "Text Size Property" in Settings, the application will receive a notification
	/// via <see cref="UIKit.UIApplication.Notifications.ObserveContentSizeCategoryChanged(EventHandler{UIContentSizeCategoryChangedEventArgs})" />.
	/// It is the application developer's responsibility, at that point, to invalidate the layout in all view elements that implement
	/// Dynamic Type. The simplest way to do that is to have a method that re-sets the font in all components that support Dynamic Type:
	/// </para><example><code lang="csharp lang-csharp"><![CDATA[
	/// UIApplication.Notifications.ObserveContentSizeCategoryChanged((s,e) => {
	/// 	SetDynamicTypeFonts();
	/// });
	/// 
	/// //Call this when initializing, and also in response to ObserveContentSizeCategoryChanged notifications
	/// private void SetDynamicTypeFonts()
	/// {
	/// 	headlineLabel.Font = UIFont.PreferredFontForTextStyle(UIFontTextStyle.Headline);
	/// 	bodyText.Font = UIFont.PreferredFontForTextStyle(UIFontTextStyle.Body);
	/// //...etc...
	/// }
	/// ]]></code></example></remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public enum UIContentSizeCategory : int {
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		Unspecified = 0,
		/// <summary>Quite small.</summary>
		ExtraSmall = 1,
		/// <summary>A small font.</summary>
		Small = 2,
		/// <summary>A medium-sized font.</summary>
		Medium = 3,
		/// <summary>A large font.</summary>
		Large = 4,
		/// <summary>An extra-large font.</summary>
		ExtraLarge = 5,
		/// <summary>A font that's larger than ExtraLarge.</summary>
		ExtraExtraLarge = 6,
		/// <summary>A font that's larger than ExtraExtraLarge.</summary>
		ExtraExtraExtraLarge = 7,
		/// <summary>A medium font reflecting the current accessibility settings.</summary>
		AccessibilityMedium = 8,
		/// <summary>A medium font reflecting the current accessibility settings.</summary>
		AccessibilityLarge = 9,
		/// <summary>A medium font reflecting the current accessibility settings.</summary>
		AccessibilityExtraLarge = 10,
		/// <summary>A medium font reflecting the current accessibility settings.</summary>
		AccessibilityExtraExtraLarge = 11,
		/// <summary>A medium font reflecting the current accessibility settings.</summary>
		AccessibilityExtraExtraExtraLarge = 12,
	}
	/// <summary>Extension methods for the <see cref="global::UIKit.UIContentSizeCategory" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class UIContentSizeCategoryExtensions {
		static IntPtr[] values = new IntPtr [13];
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[Field ("UIContentSizeCategoryUnspecified", "UIKit")]
		internal unsafe static IntPtr UIContentSizeCategoryUnspecified {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIContentSizeCategoryUnspecified", storage);
			}
		}
		[Field ("UIContentSizeCategoryExtraSmall", "UIKit")]
		internal unsafe static IntPtr UIContentSizeCategoryExtraSmall {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIContentSizeCategoryExtraSmall", storage);
			}
		}
		[Field ("UIContentSizeCategorySmall", "UIKit")]
		internal unsafe static IntPtr UIContentSizeCategorySmall {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIContentSizeCategorySmall", storage);
			}
		}
		[Field ("UIContentSizeCategoryMedium", "UIKit")]
		internal unsafe static IntPtr UIContentSizeCategoryMedium {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIContentSizeCategoryMedium", storage);
			}
		}
		[Field ("UIContentSizeCategoryLarge", "UIKit")]
		internal unsafe static IntPtr UIContentSizeCategoryLarge {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIContentSizeCategoryLarge", storage);
			}
		}
		[Field ("UIContentSizeCategoryExtraLarge", "UIKit")]
		internal unsafe static IntPtr UIContentSizeCategoryExtraLarge {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIContentSizeCategoryExtraLarge", storage);
			}
		}
		[Field ("UIContentSizeCategoryExtraExtraLarge", "UIKit")]
		internal unsafe static IntPtr UIContentSizeCategoryExtraExtraLarge {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIContentSizeCategoryExtraExtraLarge", storage);
			}
		}
		[Field ("UIContentSizeCategoryExtraExtraExtraLarge", "UIKit")]
		internal unsafe static IntPtr UIContentSizeCategoryExtraExtraExtraLarge {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIContentSizeCategoryExtraExtraExtraLarge", storage);
			}
		}
		[Field ("UIContentSizeCategoryAccessibilityMedium", "UIKit")]
		internal unsafe static IntPtr UIContentSizeCategoryAccessibilityMedium {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIContentSizeCategoryAccessibilityMedium", storage);
			}
		}
		[Field ("UIContentSizeCategoryAccessibilityLarge", "UIKit")]
		internal unsafe static IntPtr UIContentSizeCategoryAccessibilityLarge {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIContentSizeCategoryAccessibilityLarge", storage);
			}
		}
		[Field ("UIContentSizeCategoryAccessibilityExtraLarge", "UIKit")]
		internal unsafe static IntPtr UIContentSizeCategoryAccessibilityExtraLarge {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIContentSizeCategoryAccessibilityExtraLarge", storage);
			}
		}
		[Field ("UIContentSizeCategoryAccessibilityExtraExtraLarge", "UIKit")]
		internal unsafe static IntPtr UIContentSizeCategoryAccessibilityExtraExtraLarge {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIContentSizeCategoryAccessibilityExtraExtraLarge", storage);
			}
		}
		[Field ("UIContentSizeCategoryAccessibilityExtraExtraExtraLarge", "UIKit")]
		internal unsafe static IntPtr UIContentSizeCategoryAccessibilityExtraExtraExtraLarge {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIContentSizeCategoryAccessibilityExtraExtraExtraLarge", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this UIContentSizeCategory self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // UIContentSizeCategory.Unspecified
				ptr = UIContentSizeCategoryUnspecified;
				break;
			case 1: // UIContentSizeCategory.ExtraSmall
				ptr = UIContentSizeCategoryExtraSmall;
				break;
			case 2: // UIContentSizeCategory.Small
				ptr = UIContentSizeCategorySmall;
				break;
			case 3: // UIContentSizeCategory.Medium
				ptr = UIContentSizeCategoryMedium;
				break;
			case 4: // UIContentSizeCategory.Large
				ptr = UIContentSizeCategoryLarge;
				break;
			case 5: // UIContentSizeCategory.ExtraLarge
				ptr = UIContentSizeCategoryExtraLarge;
				break;
			case 6: // UIContentSizeCategory.ExtraExtraLarge
				ptr = UIContentSizeCategoryExtraExtraLarge;
				break;
			case 7: // UIContentSizeCategory.ExtraExtraExtraLarge
				ptr = UIContentSizeCategoryExtraExtraExtraLarge;
				break;
			case 8: // UIContentSizeCategory.AccessibilityMedium
				ptr = UIContentSizeCategoryAccessibilityMedium;
				break;
			case 9: // UIContentSizeCategory.AccessibilityLarge
				ptr = UIContentSizeCategoryAccessibilityLarge;
				break;
			case 10: // UIContentSizeCategory.AccessibilityExtraLarge
				ptr = UIContentSizeCategoryAccessibilityExtraLarge;
				break;
			case 11: // UIContentSizeCategory.AccessibilityExtraExtraLarge
				ptr = UIContentSizeCategoryAccessibilityExtraExtraLarge;
				break;
			case 12: // UIContentSizeCategory.AccessibilityExtraExtraExtraLarge
				ptr = UIContentSizeCategoryAccessibilityExtraExtraExtraLarge;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UIContentSizeCategory" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static UIContentSizeCategory GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (UIContentSizeCategoryUnspecified))
				return UIContentSizeCategory.Unspecified;
			if (constant.IsEqualTo (UIContentSizeCategoryExtraSmall))
				return UIContentSizeCategory.ExtraSmall;
			if (constant.IsEqualTo (UIContentSizeCategorySmall))
				return UIContentSizeCategory.Small;
			if (constant.IsEqualTo (UIContentSizeCategoryMedium))
				return UIContentSizeCategory.Medium;
			if (constant.IsEqualTo (UIContentSizeCategoryLarge))
				return UIContentSizeCategory.Large;
			if (constant.IsEqualTo (UIContentSizeCategoryExtraLarge))
				return UIContentSizeCategory.ExtraLarge;
			if (constant.IsEqualTo (UIContentSizeCategoryExtraExtraLarge))
				return UIContentSizeCategory.ExtraExtraLarge;
			if (constant.IsEqualTo (UIContentSizeCategoryExtraExtraExtraLarge))
				return UIContentSizeCategory.ExtraExtraExtraLarge;
			if (constant.IsEqualTo (UIContentSizeCategoryAccessibilityMedium))
				return UIContentSizeCategory.AccessibilityMedium;
			if (constant.IsEqualTo (UIContentSizeCategoryAccessibilityLarge))
				return UIContentSizeCategory.AccessibilityLarge;
			if (constant.IsEqualTo (UIContentSizeCategoryAccessibilityExtraLarge))
				return UIContentSizeCategory.AccessibilityExtraLarge;
			if (constant.IsEqualTo (UIContentSizeCategoryAccessibilityExtraExtraLarge))
				return UIContentSizeCategory.AccessibilityExtraExtraLarge;
			if (constant.IsEqualTo (UIContentSizeCategoryAccessibilityExtraExtraExtraLarge))
				return UIContentSizeCategory.AccessibilityExtraExtraExtraLarge;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UIContentSizeCategory" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static UIContentSizeCategory GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UIContentSizeCategory" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static UIContentSizeCategory? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::UIKit.UIContentSizeCategory" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this UIContentSizeCategory[]? values)
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
		internal static UIContentSizeCategory[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<UIContentSizeCategory> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
