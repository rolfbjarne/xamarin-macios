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
	public enum NSPasteboardName : int {
		General = 0,
		Font = 1,
		Ruler = 2,
		Find = 3,
		Drag = 4,
	}
	/// <summary>Extension methods for the <see cref="global::AppKit.NSPasteboardName" /> enumeration.</summary>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class NSPasteboardNameExtensions {
		static IntPtr[] values = new IntPtr [5];
		[Field ("NSPasteboardNameGeneral", "AppKit")]
		internal unsafe static IntPtr NSPasteboardNameGeneral {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSPasteboardNameGeneral", storage);
			}
		}
		[Field ("NSPasteboardNameFont", "AppKit")]
		internal unsafe static IntPtr NSPasteboardNameFont {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSPasteboardNameFont", storage);
			}
		}
		[Field ("NSPasteboardNameRuler", "AppKit")]
		internal unsafe static IntPtr NSPasteboardNameRuler {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSPasteboardNameRuler", storage);
			}
		}
		[Field ("NSPasteboardNameFind", "AppKit")]
		internal unsafe static IntPtr NSPasteboardNameFind {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSPasteboardNameFind", storage);
			}
		}
		[Field ("NSPasteboardNameDrag", "AppKit")]
		internal unsafe static IntPtr NSPasteboardNameDrag {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSPasteboardNameDrag", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this NSPasteboardName self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // NSPasteboardName.General
				ptr = NSPasteboardNameGeneral;
				break;
			case 1: // NSPasteboardName.Font
				ptr = NSPasteboardNameFont;
				break;
			case 2: // NSPasteboardName.Ruler
				ptr = NSPasteboardNameRuler;
				break;
			case 3: // NSPasteboardName.Find
				ptr = NSPasteboardNameFind;
				break;
			case 4: // NSPasteboardName.Drag
				ptr = NSPasteboardNameDrag;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AppKit.NSPasteboardName" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static NSPasteboardName GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (NSPasteboardNameGeneral))
				return NSPasteboardName.General;
			if (constant.IsEqualTo (NSPasteboardNameFont))
				return NSPasteboardName.Font;
			if (constant.IsEqualTo (NSPasteboardNameRuler))
				return NSPasteboardName.Ruler;
			if (constant.IsEqualTo (NSPasteboardNameFind))
				return NSPasteboardName.Find;
			if (constant.IsEqualTo (NSPasteboardNameDrag))
				return NSPasteboardName.Drag;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AppKit.NSPasteboardName" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSPasteboardName GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AppKit.NSPasteboardName" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSPasteboardName? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AppKit.NSPasteboardName" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this NSPasteboardName[]? values)
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
		internal static NSPasteboardName[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSPasteboardName> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
