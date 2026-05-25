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
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	public enum UIActionIdentifier : int {
		None = -1,
		Paste = 0,
		PasteAndMatchStyle = 1,
		PasteAndGo = 2,
		PasteAndSearch = 3,
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		NewFromPasteboard = 4,
	}
	/// <summary>Extension methods for the <see cref="global::UIKit.UIActionIdentifier" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class UIActionIdentifierExtensions {
		static IntPtr[] values = new IntPtr [5];
		[Field ("UIActionPaste", "UIKit")]
		internal unsafe static IntPtr UIActionPaste {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIActionPaste", storage);
			}
		}
		[Field ("UIActionPasteAndMatchStyle", "UIKit")]
		internal unsafe static IntPtr UIActionPasteAndMatchStyle {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIActionPasteAndMatchStyle", storage);
			}
		}
		[Field ("UIActionPasteAndGo", "UIKit")]
		internal unsafe static IntPtr UIActionPasteAndGo {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIActionPasteAndGo", storage);
			}
		}
		[Field ("UIActionPasteAndSearch", "UIKit")]
		internal unsafe static IntPtr UIActionPasteAndSearch {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIActionPasteAndSearch", storage);
			}
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[Field ("UIActionNewFromPasteboard", "UIKit")]
		internal unsafe static IntPtr UIActionNewFromPasteboard {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIActionNewFromPasteboard", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this UIActionIdentifier self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // UIActionIdentifier.Paste
				ptr = UIActionPaste;
				break;
			case 1: // UIActionIdentifier.PasteAndMatchStyle
				ptr = UIActionPasteAndMatchStyle;
				break;
			case 2: // UIActionIdentifier.PasteAndGo
				ptr = UIActionPasteAndGo;
				break;
			case 3: // UIActionIdentifier.PasteAndSearch
				ptr = UIActionPasteAndSearch;
				break;
			case 4: // UIActionIdentifier.NewFromPasteboard
				ptr = UIActionNewFromPasteboard;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UIActionIdentifier" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static UIActionIdentifier GetValue (NSString? constant)
		{
			if (constant is null)
				return UIActionIdentifier.None;
			if (constant.IsEqualTo (UIActionPaste))
				return UIActionIdentifier.Paste;
			if (constant.IsEqualTo (UIActionPasteAndMatchStyle))
				return UIActionIdentifier.PasteAndMatchStyle;
			if (constant.IsEqualTo (UIActionPasteAndGo))
				return UIActionIdentifier.PasteAndGo;
			if (constant.IsEqualTo (UIActionPasteAndSearch))
				return UIActionIdentifier.PasteAndSearch;
			if (constant.IsEqualTo (UIActionNewFromPasteboard))
				return UIActionIdentifier.NewFromPasteboard;
			return UIActionIdentifier.None;
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UIActionIdentifier" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static UIActionIdentifier GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UIActionIdentifier" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static UIActionIdentifier? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::UIKit.UIActionIdentifier" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this UIActionIdentifier[]? values)
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
		internal static UIActionIdentifier[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<UIActionIdentifier> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
