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
	public enum UITextFormattingViewControllerHighlight : int {
		Default = 1,
		Purple = 2,
		Pink = 4,
		Orange = 8,
		Mint = 16,
		Blue = 32,
	}
	/// <summary>Extension methods for the <see cref="global::UIKit.UITextFormattingViewControllerHighlight" /> enumeration.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios18.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class UITextFormattingViewControllerHighlightExtensions {
		static IntPtr[] values = new IntPtr [6];
		[Field ("UITextFormattingViewControllerHighlightDefault", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerHighlightDefault {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerHighlightDefault", storage);
			}
		}
		[Field ("UITextFormattingViewControllerHighlightPurple", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerHighlightPurple {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerHighlightPurple", storage);
			}
		}
		[Field ("UITextFormattingViewControllerHighlightPink", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerHighlightPink {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerHighlightPink", storage);
			}
		}
		[Field ("UITextFormattingViewControllerHighlightOrange", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerHighlightOrange {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerHighlightOrange", storage);
			}
		}
		[Field ("UITextFormattingViewControllerHighlightMint", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerHighlightMint {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerHighlightMint", storage);
			}
		}
		[Field ("UITextFormattingViewControllerHighlightBlue", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerHighlightBlue {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerHighlightBlue", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this UITextFormattingViewControllerHighlight self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 1: // UITextFormattingViewControllerHighlight.Default
			default:
				ptr = UITextFormattingViewControllerHighlightDefault;
				break;
			case 2: // UITextFormattingViewControllerHighlight.Purple
				ptr = UITextFormattingViewControllerHighlightPurple;
				break;
			case 4: // UITextFormattingViewControllerHighlight.Pink
				ptr = UITextFormattingViewControllerHighlightPink;
				break;
			case 8: // UITextFormattingViewControllerHighlight.Orange
				ptr = UITextFormattingViewControllerHighlightOrange;
				break;
			case 16: // UITextFormattingViewControllerHighlight.Mint
				ptr = UITextFormattingViewControllerHighlightMint;
				break;
			case 32: // UITextFormattingViewControllerHighlight.Blue
				ptr = UITextFormattingViewControllerHighlightBlue;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UITextFormattingViewControllerHighlight" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static UITextFormattingViewControllerHighlight GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (UITextFormattingViewControllerHighlightDefault))
				return UITextFormattingViewControllerHighlight.Default;
			if (constant.IsEqualTo (UITextFormattingViewControllerHighlightPurple))
				return UITextFormattingViewControllerHighlight.Purple;
			if (constant.IsEqualTo (UITextFormattingViewControllerHighlightPink))
				return UITextFormattingViewControllerHighlight.Pink;
			if (constant.IsEqualTo (UITextFormattingViewControllerHighlightOrange))
				return UITextFormattingViewControllerHighlight.Orange;
			if (constant.IsEqualTo (UITextFormattingViewControllerHighlightMint))
				return UITextFormattingViewControllerHighlight.Mint;
			if (constant.IsEqualTo (UITextFormattingViewControllerHighlightBlue))
				return UITextFormattingViewControllerHighlight.Blue;
			return UITextFormattingViewControllerHighlight.Default;
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UITextFormattingViewControllerHighlight" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static UITextFormattingViewControllerHighlight GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UITextFormattingViewControllerHighlight" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static UITextFormattingViewControllerHighlight? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::UIKit.UITextFormattingViewControllerHighlight" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this UITextFormattingViewControllerHighlight[]? values)
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
		internal static UITextFormattingViewControllerHighlight[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<UITextFormattingViewControllerHighlight> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
		/// <summary>Retrieves all the <see cref="global::UIKit.UITextFormattingViewControllerHighlight" /> constants named by the flags <paramref name="value" />.</summary>
		/// <param name="value">The flags to retrieve</param>
		/// <remarks>Any flags that are not recognized will be ignored.</remarks>
		public static NSString[] ToArray (this UITextFormattingViewControllerHighlight value)
		{
			var rv = new global::System.Collections.Generic.List<NSString> ();
			if (value.HasFlag (UITextFormattingViewControllerHighlight.Default) && UITextFormattingViewControllerHighlightDefault != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (UITextFormattingViewControllerHighlightDefault)!);
			if (value.HasFlag (UITextFormattingViewControllerHighlight.Purple) && UITextFormattingViewControllerHighlightPurple != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (UITextFormattingViewControllerHighlightPurple)!);
			if (value.HasFlag (UITextFormattingViewControllerHighlight.Pink) && UITextFormattingViewControllerHighlightPink != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (UITextFormattingViewControllerHighlightPink)!);
			if (value.HasFlag (UITextFormattingViewControllerHighlight.Orange) && UITextFormattingViewControllerHighlightOrange != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (UITextFormattingViewControllerHighlightOrange)!);
			if (value.HasFlag (UITextFormattingViewControllerHighlight.Mint) && UITextFormattingViewControllerHighlightMint != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (UITextFormattingViewControllerHighlightMint)!);
			if (value.HasFlag (UITextFormattingViewControllerHighlight.Blue) && UITextFormattingViewControllerHighlightBlue != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (UITextFormattingViewControllerHighlightBlue)!);
			// In order to be forward-compatible, any unknown values are ignored.
			return rv.ToArray ();
		}
		public static UITextFormattingViewControllerHighlight ToFlags (global::System.Collections.Generic.IEnumerable<NSString> constants)
		{
			var rv = default (UITextFormattingViewControllerHighlight);
			if (constants is null)
				return rv;
			foreach (var constant in constants) {
				if (constant.IsEqualTo (UITextFormattingViewControllerHighlightDefault))
					rv |= UITextFormattingViewControllerHighlight.Default;
				else if (constant.IsEqualTo (UITextFormattingViewControllerHighlightPurple))
					rv |= UITextFormattingViewControllerHighlight.Purple;
				else if (constant.IsEqualTo (UITextFormattingViewControllerHighlightPink))
					rv |= UITextFormattingViewControllerHighlight.Pink;
				else if (constant.IsEqualTo (UITextFormattingViewControllerHighlightOrange))
					rv |= UITextFormattingViewControllerHighlight.Orange;
				else if (constant.IsEqualTo (UITextFormattingViewControllerHighlightMint))
					rv |= UITextFormattingViewControllerHighlight.Mint;
				else if (constant.IsEqualTo (UITextFormattingViewControllerHighlightBlue))
					rv |= UITextFormattingViewControllerHighlight.Blue;
				// In order to be forward-compatible, any unknown values are ignored.
			}
			return rv;
		}
	}
}
