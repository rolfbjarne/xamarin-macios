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
	public enum NSPasteboardType : int {
		FileContents = 0,
		String = 1,
		Pdf = 2,
		Tiff = 3,
		Png = 4,
		Rtf = 5,
		Rtfd = 6,
		Html = 7,
		TabularText = 8,
		Font = 9,
		Ruler = 10,
		Color = 11,
		Sound = 12,
		MultipleTextSelection = 13,
		TextFinderOptions = 14,
		Url = 15,
		FileUrl = 16,
		[SupportedOSPlatform ("macos13.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		CollaborationMetadata = 17,
		FindPanelSearchOptions = 18,
	}
	/// <summary>Extension methods for the <see cref="global::AppKit.NSPasteboardType" /> enumeration.</summary>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class NSPasteboardTypeExtensions {
		static IntPtr[] values = new IntPtr [19];
		[Field ("NSFileContentsPboardType", "AppKit")]
		internal unsafe static IntPtr NSFileContentsPboardType {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSFileContentsPboardType", storage);
			}
		}
		[Field ("NSPasteboardTypeString", "AppKit")]
		internal unsafe static IntPtr NSPasteboardTypeString {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSPasteboardTypeString", storage);
			}
		}
		[Field ("NSPasteboardTypePDF", "AppKit")]
		internal unsafe static IntPtr NSPasteboardTypePDF {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSPasteboardTypePDF", storage);
			}
		}
		[Field ("NSPasteboardTypeTIFF", "AppKit")]
		internal unsafe static IntPtr NSPasteboardTypeTIFF {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSPasteboardTypeTIFF", storage);
			}
		}
		[Field ("NSPasteboardTypePNG", "AppKit")]
		internal unsafe static IntPtr NSPasteboardTypePNG {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSPasteboardTypePNG", storage);
			}
		}
		[Field ("NSPasteboardTypeRTF", "AppKit")]
		internal unsafe static IntPtr NSPasteboardTypeRTF {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSPasteboardTypeRTF", storage);
			}
		}
		[Field ("NSPasteboardTypeRTFD", "AppKit")]
		internal unsafe static IntPtr NSPasteboardTypeRTFD {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSPasteboardTypeRTFD", storage);
			}
		}
		[Field ("NSPasteboardTypeHTML", "AppKit")]
		internal unsafe static IntPtr NSPasteboardTypeHTML {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSPasteboardTypeHTML", storage);
			}
		}
		[Field ("NSPasteboardTypeTabularText", "AppKit")]
		internal unsafe static IntPtr NSPasteboardTypeTabularText {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSPasteboardTypeTabularText", storage);
			}
		}
		[Field ("NSPasteboardTypeFont", "AppKit")]
		internal unsafe static IntPtr NSPasteboardTypeFont {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSPasteboardTypeFont", storage);
			}
		}
		[Field ("NSPasteboardTypeRuler", "AppKit")]
		internal unsafe static IntPtr NSPasteboardTypeRuler {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSPasteboardTypeRuler", storage);
			}
		}
		[Field ("NSPasteboardTypeColor", "AppKit")]
		internal unsafe static IntPtr NSPasteboardTypeColor {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSPasteboardTypeColor", storage);
			}
		}
		[Field ("NSPasteboardTypeSound", "AppKit")]
		internal unsafe static IntPtr NSPasteboardTypeSound {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSPasteboardTypeSound", storage);
			}
		}
		[Field ("NSPasteboardTypeMultipleTextSelection", "AppKit")]
		internal unsafe static IntPtr NSPasteboardTypeMultipleTextSelection {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSPasteboardTypeMultipleTextSelection", storage);
			}
		}
		[Field ("NSPasteboardTypeTextFinderOptions", "AppKit")]
		internal unsafe static IntPtr NSPasteboardTypeTextFinderOptions {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSPasteboardTypeTextFinderOptions", storage);
			}
		}
		[Field ("NSPasteboardTypeURL", "AppKit")]
		internal unsafe static IntPtr NSPasteboardTypeURL {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSPasteboardTypeURL", storage);
			}
		}
		[Field ("NSPasteboardTypeFileURL", "AppKit")]
		internal unsafe static IntPtr NSPasteboardTypeFileURL {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSPasteboardTypeFileURL", storage);
			}
		}
		[SupportedOSPlatform ("macos13.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSPasteboardTypeCollaborationMetadata", "SharedWithYou")]
		internal unsafe static IntPtr NSPasteboardTypeCollaborationMetadata {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.SharedWithYou.Handle, "NSPasteboardTypeCollaborationMetadata", storage);
			}
		}
		[Field ("NSFindPanelSearchOptionsPboardType", "AppKit")]
		internal unsafe static IntPtr NSFindPanelSearchOptionsPboardType {
			get {
				fixed (IntPtr *storage = &values [18])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSFindPanelSearchOptionsPboardType", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this NSPasteboardType self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // NSPasteboardType.FileContents
				ptr = NSFileContentsPboardType;
				break;
			case 1: // NSPasteboardType.String
				ptr = NSPasteboardTypeString;
				break;
			case 2: // NSPasteboardType.Pdf
				ptr = NSPasteboardTypePDF;
				break;
			case 3: // NSPasteboardType.Tiff
				ptr = NSPasteboardTypeTIFF;
				break;
			case 4: // NSPasteboardType.Png
				ptr = NSPasteboardTypePNG;
				break;
			case 5: // NSPasteboardType.Rtf
				ptr = NSPasteboardTypeRTF;
				break;
			case 6: // NSPasteboardType.Rtfd
				ptr = NSPasteboardTypeRTFD;
				break;
			case 7: // NSPasteboardType.Html
				ptr = NSPasteboardTypeHTML;
				break;
			case 8: // NSPasteboardType.TabularText
				ptr = NSPasteboardTypeTabularText;
				break;
			case 9: // NSPasteboardType.Font
				ptr = NSPasteboardTypeFont;
				break;
			case 10: // NSPasteboardType.Ruler
				ptr = NSPasteboardTypeRuler;
				break;
			case 11: // NSPasteboardType.Color
				ptr = NSPasteboardTypeColor;
				break;
			case 12: // NSPasteboardType.Sound
				ptr = NSPasteboardTypeSound;
				break;
			case 13: // NSPasteboardType.MultipleTextSelection
				ptr = NSPasteboardTypeMultipleTextSelection;
				break;
			case 14: // NSPasteboardType.TextFinderOptions
				ptr = NSPasteboardTypeTextFinderOptions;
				break;
			case 15: // NSPasteboardType.Url
				ptr = NSPasteboardTypeURL;
				break;
			case 16: // NSPasteboardType.FileUrl
				ptr = NSPasteboardTypeFileURL;
				break;
			case 17: // NSPasteboardType.CollaborationMetadata
				ptr = NSPasteboardTypeCollaborationMetadata;
				break;
			case 18: // NSPasteboardType.FindPanelSearchOptions
				ptr = NSFindPanelSearchOptionsPboardType;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AppKit.NSPasteboardType" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static NSPasteboardType GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (NSFileContentsPboardType))
				return NSPasteboardType.FileContents;
			if (constant.IsEqualTo (NSPasteboardTypeString))
				return NSPasteboardType.String;
			if (constant.IsEqualTo (NSPasteboardTypePDF))
				return NSPasteboardType.Pdf;
			if (constant.IsEqualTo (NSPasteboardTypeTIFF))
				return NSPasteboardType.Tiff;
			if (constant.IsEqualTo (NSPasteboardTypePNG))
				return NSPasteboardType.Png;
			if (constant.IsEqualTo (NSPasteboardTypeRTF))
				return NSPasteboardType.Rtf;
			if (constant.IsEqualTo (NSPasteboardTypeRTFD))
				return NSPasteboardType.Rtfd;
			if (constant.IsEqualTo (NSPasteboardTypeHTML))
				return NSPasteboardType.Html;
			if (constant.IsEqualTo (NSPasteboardTypeTabularText))
				return NSPasteboardType.TabularText;
			if (constant.IsEqualTo (NSPasteboardTypeFont))
				return NSPasteboardType.Font;
			if (constant.IsEqualTo (NSPasteboardTypeRuler))
				return NSPasteboardType.Ruler;
			if (constant.IsEqualTo (NSPasteboardTypeColor))
				return NSPasteboardType.Color;
			if (constant.IsEqualTo (NSPasteboardTypeSound))
				return NSPasteboardType.Sound;
			if (constant.IsEqualTo (NSPasteboardTypeMultipleTextSelection))
				return NSPasteboardType.MultipleTextSelection;
			if (constant.IsEqualTo (NSPasteboardTypeTextFinderOptions))
				return NSPasteboardType.TextFinderOptions;
			if (constant.IsEqualTo (NSPasteboardTypeURL))
				return NSPasteboardType.Url;
			if (constant.IsEqualTo (NSPasteboardTypeFileURL))
				return NSPasteboardType.FileUrl;
			if (constant.IsEqualTo (NSPasteboardTypeCollaborationMetadata))
				return NSPasteboardType.CollaborationMetadata;
			if (constant.IsEqualTo (NSFindPanelSearchOptionsPboardType))
				return NSPasteboardType.FindPanelSearchOptions;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AppKit.NSPasteboardType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSPasteboardType GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AppKit.NSPasteboardType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSPasteboardType? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AppKit.NSPasteboardType" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this NSPasteboardType[]? values)
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
		internal static NSPasteboardType[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSPasteboardType> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
