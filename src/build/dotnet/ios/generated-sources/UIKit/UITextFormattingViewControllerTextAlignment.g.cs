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
	public enum UITextFormattingViewControllerTextAlignment : int {
		Left = 1,
		Center = 2,
		Right = 4,
		Justified = 8,
		Natural = 16,
	}
	/// <summary>Extension methods for the <see cref="global::UIKit.UITextFormattingViewControllerTextAlignment" /> enumeration.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios18.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class UITextFormattingViewControllerTextAlignmentExtensions {
		static IntPtr[] values = new IntPtr [5];
		[Field ("UITextFormattingViewControllerTextAlignmentLeft", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerTextAlignmentLeft {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerTextAlignmentLeft", storage);
			}
		}
		[Field ("UITextFormattingViewControllerTextAlignmentCenter", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerTextAlignmentCenter {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerTextAlignmentCenter", storage);
			}
		}
		[Field ("UITextFormattingViewControllerTextAlignmentRight", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerTextAlignmentRight {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerTextAlignmentRight", storage);
			}
		}
		[Field ("UITextFormattingViewControllerTextAlignmentJustified", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerTextAlignmentJustified {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerTextAlignmentJustified", storage);
			}
		}
		[Field ("UITextFormattingViewControllerTextAlignmentNatural", "UIKit")]
		internal unsafe static IntPtr UITextFormattingViewControllerTextAlignmentNatural {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UITextFormattingViewControllerTextAlignmentNatural", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this UITextFormattingViewControllerTextAlignment self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 1: // UITextFormattingViewControllerTextAlignment.Left
				ptr = UITextFormattingViewControllerTextAlignmentLeft;
				break;
			case 2: // UITextFormattingViewControllerTextAlignment.Center
				ptr = UITextFormattingViewControllerTextAlignmentCenter;
				break;
			case 4: // UITextFormattingViewControllerTextAlignment.Right
				ptr = UITextFormattingViewControllerTextAlignmentRight;
				break;
			case 8: // UITextFormattingViewControllerTextAlignment.Justified
				ptr = UITextFormattingViewControllerTextAlignmentJustified;
				break;
			case 16: // UITextFormattingViewControllerTextAlignment.Natural
				ptr = UITextFormattingViewControllerTextAlignmentNatural;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UITextFormattingViewControllerTextAlignment" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static UITextFormattingViewControllerTextAlignment GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (UITextFormattingViewControllerTextAlignmentLeft))
				return UITextFormattingViewControllerTextAlignment.Left;
			if (constant.IsEqualTo (UITextFormattingViewControllerTextAlignmentCenter))
				return UITextFormattingViewControllerTextAlignment.Center;
			if (constant.IsEqualTo (UITextFormattingViewControllerTextAlignmentRight))
				return UITextFormattingViewControllerTextAlignment.Right;
			if (constant.IsEqualTo (UITextFormattingViewControllerTextAlignmentJustified))
				return UITextFormattingViewControllerTextAlignment.Justified;
			if (constant.IsEqualTo (UITextFormattingViewControllerTextAlignmentNatural))
				return UITextFormattingViewControllerTextAlignment.Natural;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UITextFormattingViewControllerTextAlignment" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static UITextFormattingViewControllerTextAlignment GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UITextFormattingViewControllerTextAlignment" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static UITextFormattingViewControllerTextAlignment? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::UIKit.UITextFormattingViewControllerTextAlignment" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this UITextFormattingViewControllerTextAlignment[]? values)
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
		internal static UITextFormattingViewControllerTextAlignment[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<UITextFormattingViewControllerTextAlignment> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
		/// <summary>Retrieves all the <see cref="global::UIKit.UITextFormattingViewControllerTextAlignment" /> constants named by the flags <paramref name="value" />.</summary>
		/// <param name="value">The flags to retrieve</param>
		/// <remarks>Any flags that are not recognized will be ignored.</remarks>
		public static NSString[] ToArray (this UITextFormattingViewControllerTextAlignment value)
		{
			var rv = new global::System.Collections.Generic.List<NSString> ();
			if (value.HasFlag (UITextFormattingViewControllerTextAlignment.Left) && UITextFormattingViewControllerTextAlignmentLeft != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (UITextFormattingViewControllerTextAlignmentLeft)!);
			if (value.HasFlag (UITextFormattingViewControllerTextAlignment.Center) && UITextFormattingViewControllerTextAlignmentCenter != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (UITextFormattingViewControllerTextAlignmentCenter)!);
			if (value.HasFlag (UITextFormattingViewControllerTextAlignment.Right) && UITextFormattingViewControllerTextAlignmentRight != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (UITextFormattingViewControllerTextAlignmentRight)!);
			if (value.HasFlag (UITextFormattingViewControllerTextAlignment.Justified) && UITextFormattingViewControllerTextAlignmentJustified != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (UITextFormattingViewControllerTextAlignmentJustified)!);
			if (value.HasFlag (UITextFormattingViewControllerTextAlignment.Natural) && UITextFormattingViewControllerTextAlignmentNatural != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (UITextFormattingViewControllerTextAlignmentNatural)!);
			// In order to be forward-compatible, any unknown values are ignored.
			return rv.ToArray ();
		}
		public static UITextFormattingViewControllerTextAlignment ToFlags (global::System.Collections.Generic.IEnumerable<NSString> constants)
		{
			var rv = default (UITextFormattingViewControllerTextAlignment);
			if (constants is null)
				return rv;
			foreach (var constant in constants) {
				if (constant.IsEqualTo (UITextFormattingViewControllerTextAlignmentLeft))
					rv |= UITextFormattingViewControllerTextAlignment.Left;
				else if (constant.IsEqualTo (UITextFormattingViewControllerTextAlignmentCenter))
					rv |= UITextFormattingViewControllerTextAlignment.Center;
				else if (constant.IsEqualTo (UITextFormattingViewControllerTextAlignmentRight))
					rv |= UITextFormattingViewControllerTextAlignment.Right;
				else if (constant.IsEqualTo (UITextFormattingViewControllerTextAlignmentJustified))
					rv |= UITextFormattingViewControllerTextAlignment.Justified;
				else if (constant.IsEqualTo (UITextFormattingViewControllerTextAlignmentNatural))
					rv |= UITextFormattingViewControllerTextAlignment.Natural;
				// In order to be forward-compatible, any unknown values are ignored.
			}
			return rv;
		}
	}
}
