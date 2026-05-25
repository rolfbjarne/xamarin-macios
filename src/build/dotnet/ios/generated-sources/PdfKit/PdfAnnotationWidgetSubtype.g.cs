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
	public enum PdfAnnotationWidgetSubtype : int {
		/// <summary>To be added.</summary>
		Button = 0,
		/// <summary>To be added.</summary>
		Choice = 1,
		/// <summary>To be added.</summary>
		Signature = 2,
		/// <summary>To be added.</summary>
		Text = 3,
	}
	/// <summary>Extension methods for the <see cref="global::PdfKit.PdfAnnotationWidgetSubtype" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos18.2")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class PdfAnnotationWidgetSubtypeExtensions {
		static IntPtr[] values = new IntPtr [4];
		[Field ("PDFAnnotationWidgetSubtypeButton", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationWidgetSubtypeButton {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationWidgetSubtypeButton", storage);
			}
		}
		[Field ("PDFAnnotationWidgetSubtypeChoice", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationWidgetSubtypeChoice {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationWidgetSubtypeChoice", storage);
			}
		}
		[Field ("PDFAnnotationWidgetSubtypeSignature", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationWidgetSubtypeSignature {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationWidgetSubtypeSignature", storage);
			}
		}
		[Field ("PDFAnnotationWidgetSubtypeText", "PDFKit")]
		internal unsafe static IntPtr PDFAnnotationWidgetSubtypeText {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.PdfKit.Handle, "PDFAnnotationWidgetSubtypeText", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this PdfAnnotationWidgetSubtype self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // PdfAnnotationWidgetSubtype.Button
				ptr = PDFAnnotationWidgetSubtypeButton;
				break;
			case 1: // PdfAnnotationWidgetSubtype.Choice
				ptr = PDFAnnotationWidgetSubtypeChoice;
				break;
			case 2: // PdfAnnotationWidgetSubtype.Signature
				ptr = PDFAnnotationWidgetSubtypeSignature;
				break;
			case 3: // PdfAnnotationWidgetSubtype.Text
				ptr = PDFAnnotationWidgetSubtypeText;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::PdfKit.PdfAnnotationWidgetSubtype" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static PdfAnnotationWidgetSubtype GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (PDFAnnotationWidgetSubtypeButton))
				return PdfAnnotationWidgetSubtype.Button;
			if (constant.IsEqualTo (PDFAnnotationWidgetSubtypeChoice))
				return PdfAnnotationWidgetSubtype.Choice;
			if (constant.IsEqualTo (PDFAnnotationWidgetSubtypeSignature))
				return PdfAnnotationWidgetSubtype.Signature;
			if (constant.IsEqualTo (PDFAnnotationWidgetSubtypeText))
				return PdfAnnotationWidgetSubtype.Text;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::PdfKit.PdfAnnotationWidgetSubtype" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static PdfAnnotationWidgetSubtype GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::PdfKit.PdfAnnotationWidgetSubtype" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static PdfAnnotationWidgetSubtype? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::PdfKit.PdfAnnotationWidgetSubtype" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this PdfAnnotationWidgetSubtype[]? values)
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
		internal static PdfAnnotationWidgetSubtype[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<PdfAnnotationWidgetSubtype> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
