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
namespace PdfKit {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos18.2")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public enum PdfAnnotationSubtype : int {
		/// <summary>To be added.</summary>
		Text = 0,
		/// <summary>To be added.</summary>
		Link = 1,
		/// <summary>To be added.</summary>
		FreeText = 2,
		/// <summary>To be added.</summary>
		Line = 3,
		/// <summary>To be added.</summary>
		Square = 4,
		/// <summary>To be added.</summary>
		Circle = 5,
		/// <summary>To be added.</summary>
		Highlight = 6,
		/// <summary>To be added.</summary>
		Underline = 7,
		/// <summary>To be added.</summary>
		StrikeOut = 8,
		/// <summary>To be added.</summary>
		Ink = 9,
		/// <summary>To be added.</summary>
		Stamp = 10,
		/// <summary>To be added.</summary>
		Popup = 11,
		/// <summary>To be added.</summary>
		Widget = 12,
	}
	/// <summary>Extension methods for the <see cref="global::PdfKit.PdfAnnotationSubtype" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos18.2")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class PdfAnnotationSubtypeExtensions {
		static IntPtr[] values = new IntPtr [13];
		[Field ("PDFAnnotationSubtypeText", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationSubtypeText {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationSubtypeText", storage);
			}
		}
		[Field ("PDFAnnotationSubtypeLink", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationSubtypeLink {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationSubtypeLink", storage);
			}
		}
		[Field ("PDFAnnotationSubtypeFreeText", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationSubtypeFreeText {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationSubtypeFreeText", storage);
			}
		}
		[Field ("PDFAnnotationSubtypeLine", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationSubtypeLine {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationSubtypeLine", storage);
			}
		}
		[Field ("PDFAnnotationSubtypeSquare", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationSubtypeSquare {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationSubtypeSquare", storage);
			}
		}
		[Field ("PDFAnnotationSubtypeCircle", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationSubtypeCircle {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationSubtypeCircle", storage);
			}
		}
		[Field ("PDFAnnotationSubtypeHighlight", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationSubtypeHighlight {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationSubtypeHighlight", storage);
			}
		}
		[Field ("PDFAnnotationSubtypeUnderline", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationSubtypeUnderline {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationSubtypeUnderline", storage);
			}
		}
		[Field ("PDFAnnotationSubtypeStrikeOut", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationSubtypeStrikeOut {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationSubtypeStrikeOut", storage);
			}
		}
		[Field ("PDFAnnotationSubtypeInk", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationSubtypeInk {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationSubtypeInk", storage);
			}
		}
		[Field ("PDFAnnotationSubtypeStamp", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationSubtypeStamp {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationSubtypeStamp", storage);
			}
		}
		[Field ("PDFAnnotationSubtypePopup", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationSubtypePopup {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationSubtypePopup", storage);
			}
		}
		[Field ("PDFAnnotationSubtypeWidget", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationSubtypeWidget {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationSubtypeWidget", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this PdfAnnotationSubtype self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // PdfAnnotationSubtype.Text
				ptr = PDFAnnotationSubtypeText;
				break;
			case 1: // PdfAnnotationSubtype.Link
				ptr = PDFAnnotationSubtypeLink;
				break;
			case 2: // PdfAnnotationSubtype.FreeText
				ptr = PDFAnnotationSubtypeFreeText;
				break;
			case 3: // PdfAnnotationSubtype.Line
				ptr = PDFAnnotationSubtypeLine;
				break;
			case 4: // PdfAnnotationSubtype.Square
				ptr = PDFAnnotationSubtypeSquare;
				break;
			case 5: // PdfAnnotationSubtype.Circle
				ptr = PDFAnnotationSubtypeCircle;
				break;
			case 6: // PdfAnnotationSubtype.Highlight
				ptr = PDFAnnotationSubtypeHighlight;
				break;
			case 7: // PdfAnnotationSubtype.Underline
				ptr = PDFAnnotationSubtypeUnderline;
				break;
			case 8: // PdfAnnotationSubtype.StrikeOut
				ptr = PDFAnnotationSubtypeStrikeOut;
				break;
			case 9: // PdfAnnotationSubtype.Ink
				ptr = PDFAnnotationSubtypeInk;
				break;
			case 10: // PdfAnnotationSubtype.Stamp
				ptr = PDFAnnotationSubtypeStamp;
				break;
			case 11: // PdfAnnotationSubtype.Popup
				ptr = PDFAnnotationSubtypePopup;
				break;
			case 12: // PdfAnnotationSubtype.Widget
				ptr = PDFAnnotationSubtypeWidget;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::PdfKit.PdfAnnotationSubtype" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static PdfAnnotationSubtype GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (PDFAnnotationSubtypeText))
				return PdfAnnotationSubtype.Text;
			if (constant.IsEqualTo (PDFAnnotationSubtypeLink))
				return PdfAnnotationSubtype.Link;
			if (constant.IsEqualTo (PDFAnnotationSubtypeFreeText))
				return PdfAnnotationSubtype.FreeText;
			if (constant.IsEqualTo (PDFAnnotationSubtypeLine))
				return PdfAnnotationSubtype.Line;
			if (constant.IsEqualTo (PDFAnnotationSubtypeSquare))
				return PdfAnnotationSubtype.Square;
			if (constant.IsEqualTo (PDFAnnotationSubtypeCircle))
				return PdfAnnotationSubtype.Circle;
			if (constant.IsEqualTo (PDFAnnotationSubtypeHighlight))
				return PdfAnnotationSubtype.Highlight;
			if (constant.IsEqualTo (PDFAnnotationSubtypeUnderline))
				return PdfAnnotationSubtype.Underline;
			if (constant.IsEqualTo (PDFAnnotationSubtypeStrikeOut))
				return PdfAnnotationSubtype.StrikeOut;
			if (constant.IsEqualTo (PDFAnnotationSubtypeInk))
				return PdfAnnotationSubtype.Ink;
			if (constant.IsEqualTo (PDFAnnotationSubtypeStamp))
				return PdfAnnotationSubtype.Stamp;
			if (constant.IsEqualTo (PDFAnnotationSubtypePopup))
				return PdfAnnotationSubtype.Popup;
			if (constant.IsEqualTo (PDFAnnotationSubtypeWidget))
				return PdfAnnotationSubtype.Widget;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::PdfKit.PdfAnnotationSubtype" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static PdfAnnotationSubtype GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::PdfKit.PdfAnnotationSubtype" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static PdfAnnotationSubtype? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::PdfKit.PdfAnnotationSubtype" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this PdfAnnotationSubtype[]? values)
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
		internal static PdfAnnotationSubtype[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<PdfAnnotationSubtype> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
