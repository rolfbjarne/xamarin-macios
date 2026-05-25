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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AppKit {
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum NSFontTextStyle : int {
		LargeTitle = 0,
		Title1 = 1,
		Title2 = 2,
		Title3 = 3,
		Headline = 4,
		Subheadline = 5,
		Body = 6,
		Callout = 7,
		Footnote = 8,
		Caption1 = 9,
		Caption2 = 10,
	}
	/// <summary>Extension methods for the <see cref="global::AppKit.NSFontTextStyle" /> enumeration.</summary>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class NSFontTextStyleExtensions {
		static IntPtr[] values = new IntPtr [11];
		[Field ("NSFontTextStyleLargeTitle", "AppKit")]
		internal unsafe static IntPtr NSFontTextStyleLargeTitle {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSFontTextStyleLargeTitle", storage);
			}
		}
		[Field ("NSFontTextStyleTitle1", "AppKit")]
		internal unsafe static IntPtr NSFontTextStyleTitle1 {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSFontTextStyleTitle1", storage);
			}
		}
		[Field ("NSFontTextStyleTitle2", "AppKit")]
		internal unsafe static IntPtr NSFontTextStyleTitle2 {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSFontTextStyleTitle2", storage);
			}
		}
		[Field ("NSFontTextStyleTitle3", "AppKit")]
		internal unsafe static IntPtr NSFontTextStyleTitle3 {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSFontTextStyleTitle3", storage);
			}
		}
		[Field ("NSFontTextStyleHeadline", "AppKit")]
		internal unsafe static IntPtr NSFontTextStyleHeadline {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSFontTextStyleHeadline", storage);
			}
		}
		[Field ("NSFontTextStyleSubheadline", "AppKit")]
		internal unsafe static IntPtr NSFontTextStyleSubheadline {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSFontTextStyleSubheadline", storage);
			}
		}
		[Field ("NSFontTextStyleBody", "AppKit")]
		internal unsafe static IntPtr NSFontTextStyleBody {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSFontTextStyleBody", storage);
			}
		}
		[Field ("NSFontTextStyleCallout", "AppKit")]
		internal unsafe static IntPtr NSFontTextStyleCallout {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSFontTextStyleCallout", storage);
			}
		}
		[Field ("NSFontTextStyleFootnote", "AppKit")]
		internal unsafe static IntPtr NSFontTextStyleFootnote {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSFontTextStyleFootnote", storage);
			}
		}
		[Field ("NSFontTextStyleCaption1", "AppKit")]
		internal unsafe static IntPtr NSFontTextStyleCaption1 {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSFontTextStyleCaption1", storage);
			}
		}
		[Field ("NSFontTextStyleCaption2", "AppKit")]
		internal unsafe static IntPtr NSFontTextStyleCaption2 {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSFontTextStyleCaption2", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this NSFontTextStyle self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // NSFontTextStyle.LargeTitle
				ptr = NSFontTextStyleLargeTitle;
				break;
			case 1: // NSFontTextStyle.Title1
				ptr = NSFontTextStyleTitle1;
				break;
			case 2: // NSFontTextStyle.Title2
				ptr = NSFontTextStyleTitle2;
				break;
			case 3: // NSFontTextStyle.Title3
				ptr = NSFontTextStyleTitle3;
				break;
			case 4: // NSFontTextStyle.Headline
				ptr = NSFontTextStyleHeadline;
				break;
			case 5: // NSFontTextStyle.Subheadline
				ptr = NSFontTextStyleSubheadline;
				break;
			case 6: // NSFontTextStyle.Body
				ptr = NSFontTextStyleBody;
				break;
			case 7: // NSFontTextStyle.Callout
				ptr = NSFontTextStyleCallout;
				break;
			case 8: // NSFontTextStyle.Footnote
				ptr = NSFontTextStyleFootnote;
				break;
			case 9: // NSFontTextStyle.Caption1
				ptr = NSFontTextStyleCaption1;
				break;
			case 10: // NSFontTextStyle.Caption2
				ptr = NSFontTextStyleCaption2;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AppKit.NSFontTextStyle" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static NSFontTextStyle GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (NSFontTextStyleLargeTitle))
				return NSFontTextStyle.LargeTitle;
			if (constant.IsEqualTo (NSFontTextStyleTitle1))
				return NSFontTextStyle.Title1;
			if (constant.IsEqualTo (NSFontTextStyleTitle2))
				return NSFontTextStyle.Title2;
			if (constant.IsEqualTo (NSFontTextStyleTitle3))
				return NSFontTextStyle.Title3;
			if (constant.IsEqualTo (NSFontTextStyleHeadline))
				return NSFontTextStyle.Headline;
			if (constant.IsEqualTo (NSFontTextStyleSubheadline))
				return NSFontTextStyle.Subheadline;
			if (constant.IsEqualTo (NSFontTextStyleBody))
				return NSFontTextStyle.Body;
			if (constant.IsEqualTo (NSFontTextStyleCallout))
				return NSFontTextStyle.Callout;
			if (constant.IsEqualTo (NSFontTextStyleFootnote))
				return NSFontTextStyle.Footnote;
			if (constant.IsEqualTo (NSFontTextStyleCaption1))
				return NSFontTextStyle.Caption1;
			if (constant.IsEqualTo (NSFontTextStyleCaption2))
				return NSFontTextStyle.Caption2;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AppKit.NSFontTextStyle" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSFontTextStyle GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AppKit.NSFontTextStyle" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSFontTextStyle? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AppKit.NSFontTextStyle" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this NSFontTextStyle[]? values)
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
		internal static NSFontTextStyle[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSFontTextStyle> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
