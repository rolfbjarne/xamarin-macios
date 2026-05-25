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
namespace PdfKit {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos18.2")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public enum PdfAnnotationLineEndingStyle : int {
		/// <summary>To be added.</summary>
		None = 0,
		/// <summary>To be added.</summary>
		Square = 1,
		/// <summary>To be added.</summary>
		Circle = 2,
		/// <summary>To be added.</summary>
		Diamond = 3,
		/// <summary>To be added.</summary>
		OpenArrow = 4,
		/// <summary>To be added.</summary>
		ClosedArrow = 5,
	}
	/// <summary>Extension methods for the <see cref="global::PdfKit.PdfAnnotationLineEndingStyle" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos18.2")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class PdfAnnotationLineEndingStyleExtensions {
		static IntPtr[] values = new IntPtr [6];
		[Field ("PDFAnnotationLineEndingStyleNone", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationLineEndingStyleNone {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationLineEndingStyleNone", storage);
			}
		}
		[Field ("PDFAnnotationLineEndingStyleSquare", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationLineEndingStyleSquare {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationLineEndingStyleSquare", storage);
			}
		}
		[Field ("PDFAnnotationLineEndingStyleCircle", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationLineEndingStyleCircle {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationLineEndingStyleCircle", storage);
			}
		}
		[Field ("PDFAnnotationLineEndingStyleDiamond", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationLineEndingStyleDiamond {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationLineEndingStyleDiamond", storage);
			}
		}
		[Field ("PDFAnnotationLineEndingStyleOpenArrow", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationLineEndingStyleOpenArrow {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationLineEndingStyleOpenArrow", storage);
			}
		}
		[Field ("PDFAnnotationLineEndingStyleClosedArrow", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationLineEndingStyleClosedArrow {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationLineEndingStyleClosedArrow", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this PdfAnnotationLineEndingStyle self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // PdfAnnotationLineEndingStyle.None
				ptr = PDFAnnotationLineEndingStyleNone;
				break;
			case 1: // PdfAnnotationLineEndingStyle.Square
				ptr = PDFAnnotationLineEndingStyleSquare;
				break;
			case 2: // PdfAnnotationLineEndingStyle.Circle
				ptr = PDFAnnotationLineEndingStyleCircle;
				break;
			case 3: // PdfAnnotationLineEndingStyle.Diamond
				ptr = PDFAnnotationLineEndingStyleDiamond;
				break;
			case 4: // PdfAnnotationLineEndingStyle.OpenArrow
				ptr = PDFAnnotationLineEndingStyleOpenArrow;
				break;
			case 5: // PdfAnnotationLineEndingStyle.ClosedArrow
				ptr = PDFAnnotationLineEndingStyleClosedArrow;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::PdfKit.PdfAnnotationLineEndingStyle" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static PdfAnnotationLineEndingStyle GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (PDFAnnotationLineEndingStyleNone))
				return PdfAnnotationLineEndingStyle.None;
			if (constant.IsEqualTo (PDFAnnotationLineEndingStyleSquare))
				return PdfAnnotationLineEndingStyle.Square;
			if (constant.IsEqualTo (PDFAnnotationLineEndingStyleCircle))
				return PdfAnnotationLineEndingStyle.Circle;
			if (constant.IsEqualTo (PDFAnnotationLineEndingStyleDiamond))
				return PdfAnnotationLineEndingStyle.Diamond;
			if (constant.IsEqualTo (PDFAnnotationLineEndingStyleOpenArrow))
				return PdfAnnotationLineEndingStyle.OpenArrow;
			if (constant.IsEqualTo (PDFAnnotationLineEndingStyleClosedArrow))
				return PdfAnnotationLineEndingStyle.ClosedArrow;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::PdfKit.PdfAnnotationLineEndingStyle" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static PdfAnnotationLineEndingStyle GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::PdfKit.PdfAnnotationLineEndingStyle" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static PdfAnnotationLineEndingStyle? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::PdfKit.PdfAnnotationLineEndingStyle" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this PdfAnnotationLineEndingStyle[]? values)
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
		internal static PdfAnnotationLineEndingStyle[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<PdfAnnotationLineEndingStyle> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
