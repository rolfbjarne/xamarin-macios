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
	public enum PdfAnnotationTextIconType : int {
		/// <summary>To be added.</summary>
		Comment = 0,
		/// <summary>To be added.</summary>
		Key = 1,
		/// <summary>To be added.</summary>
		Note = 2,
		/// <summary>To be added.</summary>
		Help = 3,
		/// <summary>To be added.</summary>
		NewParagraph = 4,
		/// <summary>To be added.</summary>
		Paragraph = 5,
		/// <summary>To be added.</summary>
		Insert = 6,
	}
	/// <summary>Extension methods for the <see cref="global::PdfKit.PdfAnnotationTextIconType" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos18.2")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class PdfAnnotationTextIconTypeExtensions {
		static IntPtr[] values = new IntPtr [7];
		[Field ("PDFAnnotationTextIconTypeComment", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationTextIconTypeComment {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationTextIconTypeComment", storage);
			}
		}
		[Field ("PDFAnnotationTextIconTypeKey", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationTextIconTypeKey {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationTextIconTypeKey", storage);
			}
		}
		[Field ("PDFAnnotationTextIconTypeNote", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationTextIconTypeNote {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationTextIconTypeNote", storage);
			}
		}
		[Field ("PDFAnnotationTextIconTypeHelp", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationTextIconTypeHelp {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationTextIconTypeHelp", storage);
			}
		}
		[Field ("PDFAnnotationTextIconTypeNewParagraph", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationTextIconTypeNewParagraph {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationTextIconTypeNewParagraph", storage);
			}
		}
		[Field ("PDFAnnotationTextIconTypeParagraph", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationTextIconTypeParagraph {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationTextIconTypeParagraph", storage);
			}
		}
		[Field ("PDFAnnotationTextIconTypeInsert", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationTextIconTypeInsert {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationTextIconTypeInsert", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this PdfAnnotationTextIconType self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // PdfAnnotationTextIconType.Comment
				ptr = PDFAnnotationTextIconTypeComment;
				break;
			case 1: // PdfAnnotationTextIconType.Key
				ptr = PDFAnnotationTextIconTypeKey;
				break;
			case 2: // PdfAnnotationTextIconType.Note
				ptr = PDFAnnotationTextIconTypeNote;
				break;
			case 3: // PdfAnnotationTextIconType.Help
				ptr = PDFAnnotationTextIconTypeHelp;
				break;
			case 4: // PdfAnnotationTextIconType.NewParagraph
				ptr = PDFAnnotationTextIconTypeNewParagraph;
				break;
			case 5: // PdfAnnotationTextIconType.Paragraph
				ptr = PDFAnnotationTextIconTypeParagraph;
				break;
			case 6: // PdfAnnotationTextIconType.Insert
				ptr = PDFAnnotationTextIconTypeInsert;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::PdfKit.PdfAnnotationTextIconType" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static PdfAnnotationTextIconType GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (PDFAnnotationTextIconTypeComment))
				return PdfAnnotationTextIconType.Comment;
			if (constant.IsEqualTo (PDFAnnotationTextIconTypeKey))
				return PdfAnnotationTextIconType.Key;
			if (constant.IsEqualTo (PDFAnnotationTextIconTypeNote))
				return PdfAnnotationTextIconType.Note;
			if (constant.IsEqualTo (PDFAnnotationTextIconTypeHelp))
				return PdfAnnotationTextIconType.Help;
			if (constant.IsEqualTo (PDFAnnotationTextIconTypeNewParagraph))
				return PdfAnnotationTextIconType.NewParagraph;
			if (constant.IsEqualTo (PDFAnnotationTextIconTypeParagraph))
				return PdfAnnotationTextIconType.Paragraph;
			if (constant.IsEqualTo (PDFAnnotationTextIconTypeInsert))
				return PdfAnnotationTextIconType.Insert;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::PdfKit.PdfAnnotationTextIconType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static PdfAnnotationTextIconType GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::PdfKit.PdfAnnotationTextIconType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static PdfAnnotationTextIconType? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::PdfKit.PdfAnnotationTextIconType" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this PdfAnnotationTextIconType[]? values)
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
		internal static PdfAnnotationTextIconType[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<PdfAnnotationTextIconType> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
