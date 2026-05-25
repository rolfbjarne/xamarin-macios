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
namespace Vision {
	/// <summary>Enumerated supported barcode standards.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum VNBarcodeSymbology : int {
		/// <summary>Indicates the Aztec barcode format.</summary>
		Aztec = 0,
		/// <summary>Indicates the Code 39 barcode format.</summary>
		Code39 = 1,
		/// <summary>Indicates the Code 39 mod 43 barcode format.</summary>
		Code39Checksum = 2,
		/// <summary>Indicates the Full ASCII Code 39 barcode format.</summary>
		Code39FullAscii = 3,
		/// <summary>Indicates the Full ASCII Code 39 mod 43 barcode format.</summary>
		Code39FullAsciiChecksum = 4,
		/// <summary>Indicates the Code 93 barcode format.</summary>
		Code93 = 5,
		/// <summary>Indicates the Code 93 barcode format.</summary>
		Code93i = 6,
		/// <summary>Indicates the Code128 barcode format.</summary>
		Code128 = 7,
		/// <summary>Indicates the Data Matrix ECC 200 barcode format.</summary>
		DataMatrix = 8,
		/// <summary>Indicates the EAN-8 barcode format.</summary>
		Ean8 = 9,
		/// <summary>Indicates the EAN-13 barcode format.</summary>
		Ean13 = 10,
		/// <summary>Indicates the Interleaved 2 of 5 barcode format.</summary>
		I2OF5 = 11,
		/// <summary>Indicates the Interleaved 2 of 5 barcode format, with a checksum.</summary>
		I2OF5Checksum = 12,
		/// <summary>Indicates the ITF-14 barcode format.</summary>
		Itf14 = 13,
		/// <summary>Indicates the PDF417 barcode format.</summary>
		Pdf417 = 14,
		/// <summary>Indicates the QR code format.</summary>
		QR = 15,
		/// <summary>Indicates the UPC-E barcode format.</summary>
		Upce = 16,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		Codabar = 17,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		GS1DataBar = 18,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		GS1DataBarExpanded = 19,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		GS1DataBarLimited = 20,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		MicroPdf417 = 21,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		MicroQR = 22,
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		MsiPlessey = 23,
	}
	/// <summary>Extension methods for the <see cref="global::Vision.VNBarcodeSymbology" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class VNBarcodeSymbologyExtensions {
		static IntPtr[] values = new IntPtr [24];
		[Field ("VNBarcodeSymbologyAztec", "Vision")]
		internal unsafe static IntPtr VNBarcodeSymbologyAztec {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNBarcodeSymbologyAztec", storage);
			}
		}
		[Field ("VNBarcodeSymbologyCode39", "Vision")]
		internal unsafe static IntPtr VNBarcodeSymbologyCode39 {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNBarcodeSymbologyCode39", storage);
			}
		}
		[Field ("VNBarcodeSymbologyCode39Checksum", "Vision")]
		internal unsafe static IntPtr VNBarcodeSymbologyCode39Checksum {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNBarcodeSymbologyCode39Checksum", storage);
			}
		}
		[Field ("VNBarcodeSymbologyCode39FullASCII", "Vision")]
		internal unsafe static IntPtr VNBarcodeSymbologyCode39FullASCII {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNBarcodeSymbologyCode39FullASCII", storage);
			}
		}
		[Field ("VNBarcodeSymbologyCode39FullASCIIChecksum", "Vision")]
		internal unsafe static IntPtr VNBarcodeSymbologyCode39FullASCIIChecksum {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNBarcodeSymbologyCode39FullASCIIChecksum", storage);
			}
		}
		[Field ("VNBarcodeSymbologyCode93", "Vision")]
		internal unsafe static IntPtr VNBarcodeSymbologyCode93 {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNBarcodeSymbologyCode93", storage);
			}
		}
		[Field ("VNBarcodeSymbologyCode93i", "Vision")]
		internal unsafe static IntPtr VNBarcodeSymbologyCode93i {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNBarcodeSymbologyCode93i", storage);
			}
		}
		[Field ("VNBarcodeSymbologyCode128", "Vision")]
		internal unsafe static IntPtr VNBarcodeSymbologyCode128 {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNBarcodeSymbologyCode128", storage);
			}
		}
		[Field ("VNBarcodeSymbologyDataMatrix", "Vision")]
		internal unsafe static IntPtr VNBarcodeSymbologyDataMatrix {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNBarcodeSymbologyDataMatrix", storage);
			}
		}
		[Field ("VNBarcodeSymbologyEAN8", "Vision")]
		internal unsafe static IntPtr VNBarcodeSymbologyEAN8 {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNBarcodeSymbologyEAN8", storage);
			}
		}
		[Field ("VNBarcodeSymbologyEAN13", "Vision")]
		internal unsafe static IntPtr VNBarcodeSymbologyEAN13 {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNBarcodeSymbologyEAN13", storage);
			}
		}
		[Field ("VNBarcodeSymbologyI2of5", "Vision")]
		internal unsafe static IntPtr VNBarcodeSymbologyI2of5 {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNBarcodeSymbologyI2of5", storage);
			}
		}
		[Field ("VNBarcodeSymbologyI2of5Checksum", "Vision")]
		internal unsafe static IntPtr VNBarcodeSymbologyI2of5Checksum {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNBarcodeSymbologyI2of5Checksum", storage);
			}
		}
		[Field ("VNBarcodeSymbologyITF14", "Vision")]
		internal unsafe static IntPtr VNBarcodeSymbologyITF14 {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNBarcodeSymbologyITF14", storage);
			}
		}
		[Field ("VNBarcodeSymbologyPDF417", "Vision")]
		internal unsafe static IntPtr VNBarcodeSymbologyPDF417 {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNBarcodeSymbologyPDF417", storage);
			}
		}
		[Field ("VNBarcodeSymbologyQR", "Vision")]
		internal unsafe static IntPtr VNBarcodeSymbologyQR {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNBarcodeSymbologyQR", storage);
			}
		}
		[Field ("VNBarcodeSymbologyUPCE", "Vision")]
		internal unsafe static IntPtr VNBarcodeSymbologyUPCE {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNBarcodeSymbologyUPCE", storage);
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("VNBarcodeSymbologyCodabar", "Vision")]
		internal unsafe static IntPtr VNBarcodeSymbologyCodabar {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNBarcodeSymbologyCodabar", storage);
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("VNBarcodeSymbologyGS1DataBar", "Vision")]
		internal unsafe static IntPtr VNBarcodeSymbologyGS1DataBar {
			get {
				fixed (IntPtr *storage = &values [18])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNBarcodeSymbologyGS1DataBar", storage);
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("VNBarcodeSymbologyGS1DataBarExpanded", "Vision")]
		internal unsafe static IntPtr VNBarcodeSymbologyGS1DataBarExpanded {
			get {
				fixed (IntPtr *storage = &values [19])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNBarcodeSymbologyGS1DataBarExpanded", storage);
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("VNBarcodeSymbologyGS1DataBarLimited", "Vision")]
		internal unsafe static IntPtr VNBarcodeSymbologyGS1DataBarLimited {
			get {
				fixed (IntPtr *storage = &values [20])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNBarcodeSymbologyGS1DataBarLimited", storage);
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("VNBarcodeSymbologyMicroPDF417", "Vision")]
		internal unsafe static IntPtr VNBarcodeSymbologyMicroPDF417 {
			get {
				fixed (IntPtr *storage = &values [21])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNBarcodeSymbologyMicroPDF417", storage);
			}
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("VNBarcodeSymbologyMicroQR", "Vision")]
		internal unsafe static IntPtr VNBarcodeSymbologyMicroQR {
			get {
				fixed (IntPtr *storage = &values [22])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNBarcodeSymbologyMicroQR", storage);
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[Field ("VNBarcodeSymbologyMSIPlessey", "Vision")]
		internal unsafe static IntPtr VNBarcodeSymbologyMSIPlessey {
			get {
				fixed (IntPtr *storage = &values [23])
					return Dlfcn.CachePointer (Libraries.Vision.Handle, "VNBarcodeSymbologyMSIPlessey", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this VNBarcodeSymbology self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // VNBarcodeSymbology.Aztec
				ptr = VNBarcodeSymbologyAztec;
				break;
			case 1: // VNBarcodeSymbology.Code39
				ptr = VNBarcodeSymbologyCode39;
				break;
			case 2: // VNBarcodeSymbology.Code39Checksum
				ptr = VNBarcodeSymbologyCode39Checksum;
				break;
			case 3: // VNBarcodeSymbology.Code39FullAscii
				ptr = VNBarcodeSymbologyCode39FullASCII;
				break;
			case 4: // VNBarcodeSymbology.Code39FullAsciiChecksum
				ptr = VNBarcodeSymbologyCode39FullASCIIChecksum;
				break;
			case 5: // VNBarcodeSymbology.Code93
				ptr = VNBarcodeSymbologyCode93;
				break;
			case 6: // VNBarcodeSymbology.Code93i
				ptr = VNBarcodeSymbologyCode93i;
				break;
			case 7: // VNBarcodeSymbology.Code128
				ptr = VNBarcodeSymbologyCode128;
				break;
			case 8: // VNBarcodeSymbology.DataMatrix
				ptr = VNBarcodeSymbologyDataMatrix;
				break;
			case 9: // VNBarcodeSymbology.Ean8
				ptr = VNBarcodeSymbologyEAN8;
				break;
			case 10: // VNBarcodeSymbology.Ean13
				ptr = VNBarcodeSymbologyEAN13;
				break;
			case 11: // VNBarcodeSymbology.I2OF5
				ptr = VNBarcodeSymbologyI2of5;
				break;
			case 12: // VNBarcodeSymbology.I2OF5Checksum
				ptr = VNBarcodeSymbologyI2of5Checksum;
				break;
			case 13: // VNBarcodeSymbology.Itf14
				ptr = VNBarcodeSymbologyITF14;
				break;
			case 14: // VNBarcodeSymbology.Pdf417
				ptr = VNBarcodeSymbologyPDF417;
				break;
			case 15: // VNBarcodeSymbology.QR
				ptr = VNBarcodeSymbologyQR;
				break;
			case 16: // VNBarcodeSymbology.Upce
				ptr = VNBarcodeSymbologyUPCE;
				break;
			case 17: // VNBarcodeSymbology.Codabar
				ptr = VNBarcodeSymbologyCodabar;
				break;
			case 18: // VNBarcodeSymbology.GS1DataBar
				ptr = VNBarcodeSymbologyGS1DataBar;
				break;
			case 19: // VNBarcodeSymbology.GS1DataBarExpanded
				ptr = VNBarcodeSymbologyGS1DataBarExpanded;
				break;
			case 20: // VNBarcodeSymbology.GS1DataBarLimited
				ptr = VNBarcodeSymbologyGS1DataBarLimited;
				break;
			case 21: // VNBarcodeSymbology.MicroPdf417
				ptr = VNBarcodeSymbologyMicroPDF417;
				break;
			case 22: // VNBarcodeSymbology.MicroQR
				ptr = VNBarcodeSymbologyMicroQR;
				break;
			case 23: // VNBarcodeSymbology.MsiPlessey
				ptr = VNBarcodeSymbologyMSIPlessey;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::Vision.VNBarcodeSymbology" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static VNBarcodeSymbology GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (VNBarcodeSymbologyAztec))
				return VNBarcodeSymbology.Aztec;
			if (constant.IsEqualTo (VNBarcodeSymbologyCode39))
				return VNBarcodeSymbology.Code39;
			if (constant.IsEqualTo (VNBarcodeSymbologyCode39Checksum))
				return VNBarcodeSymbology.Code39Checksum;
			if (constant.IsEqualTo (VNBarcodeSymbologyCode39FullASCII))
				return VNBarcodeSymbology.Code39FullAscii;
			if (constant.IsEqualTo (VNBarcodeSymbologyCode39FullASCIIChecksum))
				return VNBarcodeSymbology.Code39FullAsciiChecksum;
			if (constant.IsEqualTo (VNBarcodeSymbologyCode93))
				return VNBarcodeSymbology.Code93;
			if (constant.IsEqualTo (VNBarcodeSymbologyCode93i))
				return VNBarcodeSymbology.Code93i;
			if (constant.IsEqualTo (VNBarcodeSymbologyCode128))
				return VNBarcodeSymbology.Code128;
			if (constant.IsEqualTo (VNBarcodeSymbologyDataMatrix))
				return VNBarcodeSymbology.DataMatrix;
			if (constant.IsEqualTo (VNBarcodeSymbologyEAN8))
				return VNBarcodeSymbology.Ean8;
			if (constant.IsEqualTo (VNBarcodeSymbologyEAN13))
				return VNBarcodeSymbology.Ean13;
			if (constant.IsEqualTo (VNBarcodeSymbologyI2of5))
				return VNBarcodeSymbology.I2OF5;
			if (constant.IsEqualTo (VNBarcodeSymbologyI2of5Checksum))
				return VNBarcodeSymbology.I2OF5Checksum;
			if (constant.IsEqualTo (VNBarcodeSymbologyITF14))
				return VNBarcodeSymbology.Itf14;
			if (constant.IsEqualTo (VNBarcodeSymbologyPDF417))
				return VNBarcodeSymbology.Pdf417;
			if (constant.IsEqualTo (VNBarcodeSymbologyQR))
				return VNBarcodeSymbology.QR;
			if (constant.IsEqualTo (VNBarcodeSymbologyUPCE))
				return VNBarcodeSymbology.Upce;
			if (constant.IsEqualTo (VNBarcodeSymbologyCodabar))
				return VNBarcodeSymbology.Codabar;
			if (constant.IsEqualTo (VNBarcodeSymbologyGS1DataBar))
				return VNBarcodeSymbology.GS1DataBar;
			if (constant.IsEqualTo (VNBarcodeSymbologyGS1DataBarExpanded))
				return VNBarcodeSymbology.GS1DataBarExpanded;
			if (constant.IsEqualTo (VNBarcodeSymbologyGS1DataBarLimited))
				return VNBarcodeSymbology.GS1DataBarLimited;
			if (constant.IsEqualTo (VNBarcodeSymbologyMicroPDF417))
				return VNBarcodeSymbology.MicroPdf417;
			if (constant.IsEqualTo (VNBarcodeSymbologyMicroQR))
				return VNBarcodeSymbology.MicroQR;
			if (constant.IsEqualTo (VNBarcodeSymbologyMSIPlessey))
				return VNBarcodeSymbology.MsiPlessey;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::Vision.VNBarcodeSymbology" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static VNBarcodeSymbology GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::Vision.VNBarcodeSymbology" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static VNBarcodeSymbology? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::Vision.VNBarcodeSymbology" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this VNBarcodeSymbology[]? values)
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
		internal static VNBarcodeSymbology[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<VNBarcodeSymbology> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
