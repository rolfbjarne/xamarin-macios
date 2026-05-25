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
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	public enum UIAccessibilityTextualContext : int {
		WordProcessing = 0,
		Narrative = 1,
		Messaging = 2,
		Spreadsheet = 3,
		FileSystem = 4,
		SourceCode = 5,
		Console = 6,
	}
	/// <summary>Extension methods for the <see cref="global::UIKit.UIAccessibilityTextualContext" /> enumeration.</summary>
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class UIAccessibilityTextualContextExtensions {
		static IntPtr[] values = new IntPtr [7];
		[Field ("UIAccessibilityTextualContextWordProcessing", "UIKit")]
		internal unsafe static IntPtr UIAccessibilityTextualContextWordProcessing {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIAccessibilityTextualContextWordProcessing", storage);
			}
		}
		[Field ("UIAccessibilityTextualContextNarrative", "UIKit")]
		internal unsafe static IntPtr UIAccessibilityTextualContextNarrative {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIAccessibilityTextualContextNarrative", storage);
			}
		}
		[Field ("UIAccessibilityTextualContextMessaging", "UIKit")]
		internal unsafe static IntPtr UIAccessibilityTextualContextMessaging {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIAccessibilityTextualContextMessaging", storage);
			}
		}
		[Field ("UIAccessibilityTextualContextSpreadsheet", "UIKit")]
		internal unsafe static IntPtr UIAccessibilityTextualContextSpreadsheet {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIAccessibilityTextualContextSpreadsheet", storage);
			}
		}
		[Field ("UIAccessibilityTextualContextFileSystem", "UIKit")]
		internal unsafe static IntPtr UIAccessibilityTextualContextFileSystem {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIAccessibilityTextualContextFileSystem", storage);
			}
		}
		[Field ("UIAccessibilityTextualContextSourceCode", "UIKit")]
		internal unsafe static IntPtr UIAccessibilityTextualContextSourceCode {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIAccessibilityTextualContextSourceCode", storage);
			}
		}
		[Field ("UIAccessibilityTextualContextConsole", "UIKit")]
		internal unsafe static IntPtr UIAccessibilityTextualContextConsole {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.UIKit.Handle, "UIAccessibilityTextualContextConsole", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this UIAccessibilityTextualContext self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // UIAccessibilityTextualContext.WordProcessing
				ptr = UIAccessibilityTextualContextWordProcessing;
				break;
			case 1: // UIAccessibilityTextualContext.Narrative
				ptr = UIAccessibilityTextualContextNarrative;
				break;
			case 2: // UIAccessibilityTextualContext.Messaging
				ptr = UIAccessibilityTextualContextMessaging;
				break;
			case 3: // UIAccessibilityTextualContext.Spreadsheet
				ptr = UIAccessibilityTextualContextSpreadsheet;
				break;
			case 4: // UIAccessibilityTextualContext.FileSystem
				ptr = UIAccessibilityTextualContextFileSystem;
				break;
			case 5: // UIAccessibilityTextualContext.SourceCode
				ptr = UIAccessibilityTextualContextSourceCode;
				break;
			case 6: // UIAccessibilityTextualContext.Console
				ptr = UIAccessibilityTextualContextConsole;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UIAccessibilityTextualContext" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static UIAccessibilityTextualContext GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (UIAccessibilityTextualContextWordProcessing))
				return UIAccessibilityTextualContext.WordProcessing;
			if (constant.IsEqualTo (UIAccessibilityTextualContextNarrative))
				return UIAccessibilityTextualContext.Narrative;
			if (constant.IsEqualTo (UIAccessibilityTextualContextMessaging))
				return UIAccessibilityTextualContext.Messaging;
			if (constant.IsEqualTo (UIAccessibilityTextualContextSpreadsheet))
				return UIAccessibilityTextualContext.Spreadsheet;
			if (constant.IsEqualTo (UIAccessibilityTextualContextFileSystem))
				return UIAccessibilityTextualContext.FileSystem;
			if (constant.IsEqualTo (UIAccessibilityTextualContextSourceCode))
				return UIAccessibilityTextualContext.SourceCode;
			if (constant.IsEqualTo (UIAccessibilityTextualContextConsole))
				return UIAccessibilityTextualContext.Console;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UIAccessibilityTextualContext" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static UIAccessibilityTextualContext GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::UIKit.UIAccessibilityTextualContext" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static UIAccessibilityTextualContext? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::UIKit.UIAccessibilityTextualContext" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this UIAccessibilityTextualContext[]? values)
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
		internal static UIAccessibilityTextualContext[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<UIAccessibilityTextualContext> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
