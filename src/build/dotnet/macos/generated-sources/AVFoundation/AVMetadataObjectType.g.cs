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
namespace AVFoundation {
	/// <summary>Enumerates barcode descriptions.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Flags]
	public enum AVMetadataObjectType : ulong {
		/// <summary>To be added.</summary>
		None = 0,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Face = 1,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		AztecCode = 2,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Code128Code = 4,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Code39Code = 8,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Code39Mod43Code = 16,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Code93Code = 32,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		EAN13Code = 64,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		EAN8Code = 128,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		PDF417Code = 256,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		QRCode = 512,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		UPCECode = 1024,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Interleaved2of5Code = 2048,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		ITF14Code = 4096,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		DataMatrixCode = 8192,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		CatBody = 16384,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		DogBody = 32768,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		HumanBody = 65536,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		SalientObject = 131072,
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		CodabarCode = 262144,
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		GS1DataBarCode = 524288,
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		GS1DataBarExpandedCode = 1048576,
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		GS1DataBarLimitedCode = 2097152,
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		MicroQRCode = 4194304,
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		MicroPdf417Code = 8388608,
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		HumanFullBody = 16777216,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Obsolete ("Use 'CatHead' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		AVMetadataObjectTypeCatHead = 33554432,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		CatHead = 33554432,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		DogHead = 67108864,
	}
	/// <summary>Extension methods for the <see cref="global::AVFoundation.AVMetadataObjectType" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class AVMetadataObjectTypeExtensions {
		static IntPtr[] values = new IntPtr [27];
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVMetadataObjectTypeFace", "AVFoundation")]
		internal unsafe static IntPtr AVMetadataObjectTypeFace {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMetadataObjectTypeFace", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVMetadataObjectTypeAztecCode", "AVFoundation")]
		internal unsafe static IntPtr AVMetadataObjectTypeAztecCode {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMetadataObjectTypeAztecCode", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVMetadataObjectTypeCode128Code", "AVFoundation")]
		internal unsafe static IntPtr AVMetadataObjectTypeCode128Code {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMetadataObjectTypeCode128Code", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVMetadataObjectTypeCode39Code", "AVFoundation")]
		internal unsafe static IntPtr AVMetadataObjectTypeCode39Code {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMetadataObjectTypeCode39Code", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVMetadataObjectTypeCode39Mod43Code", "AVFoundation")]
		internal unsafe static IntPtr AVMetadataObjectTypeCode39Mod43Code {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMetadataObjectTypeCode39Mod43Code", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVMetadataObjectTypeCode93Code", "AVFoundation")]
		internal unsafe static IntPtr AVMetadataObjectTypeCode93Code {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMetadataObjectTypeCode93Code", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVMetadataObjectTypeEAN13Code", "AVFoundation")]
		internal unsafe static IntPtr AVMetadataObjectTypeEAN13Code {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMetadataObjectTypeEAN13Code", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVMetadataObjectTypeEAN8Code", "AVFoundation")]
		internal unsafe static IntPtr AVMetadataObjectTypeEAN8Code {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMetadataObjectTypeEAN8Code", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVMetadataObjectTypePDF417Code", "AVFoundation")]
		internal unsafe static IntPtr AVMetadataObjectTypePDF417Code {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMetadataObjectTypePDF417Code", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVMetadataObjectTypeQRCode", "AVFoundation")]
		internal unsafe static IntPtr AVMetadataObjectTypeQRCode {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMetadataObjectTypeQRCode", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVMetadataObjectTypeUPCECode", "AVFoundation")]
		internal unsafe static IntPtr AVMetadataObjectTypeUPCECode {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMetadataObjectTypeUPCECode", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVMetadataObjectTypeInterleaved2of5Code", "AVFoundation")]
		internal unsafe static IntPtr AVMetadataObjectTypeInterleaved2of5Code {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMetadataObjectTypeInterleaved2of5Code", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVMetadataObjectTypeITF14Code", "AVFoundation")]
		internal unsafe static IntPtr AVMetadataObjectTypeITF14Code {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMetadataObjectTypeITF14Code", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("AVMetadataObjectTypeDataMatrixCode", "AVFoundation")]
		internal unsafe static IntPtr AVMetadataObjectTypeDataMatrixCode {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMetadataObjectTypeDataMatrixCode", storage);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("AVMetadataObjectTypeCatBody", "AVFoundation")]
		internal unsafe static IntPtr AVMetadataObjectTypeCatBody {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMetadataObjectTypeCatBody", storage);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("AVMetadataObjectTypeDogBody", "AVFoundation")]
		internal unsafe static IntPtr AVMetadataObjectTypeDogBody {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMetadataObjectTypeDogBody", storage);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("AVMetadataObjectTypeHumanBody", "AVFoundation")]
		internal unsafe static IntPtr AVMetadataObjectTypeHumanBody {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMetadataObjectTypeHumanBody", storage);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("AVMetadataObjectTypeSalientObject", "AVFoundation")]
		internal unsafe static IntPtr AVMetadataObjectTypeSalientObject {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMetadataObjectTypeSalientObject", storage);
			}
		}
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[Field ("AVMetadataObjectTypeCodabarCode", "AVFoundation")]
		internal unsafe static IntPtr AVMetadataObjectTypeCodabarCode {
			get {
				fixed (IntPtr *storage = &values [18])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMetadataObjectTypeCodabarCode", storage);
			}
		}
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[Field ("AVMetadataObjectTypeGS1DataBarCode", "AVFoundation")]
		internal unsafe static IntPtr AVMetadataObjectTypeGS1DataBarCode {
			get {
				fixed (IntPtr *storage = &values [19])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMetadataObjectTypeGS1DataBarCode", storage);
			}
		}
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[Field ("AVMetadataObjectTypeGS1DataBarExpandedCode", "AVFoundation")]
		internal unsafe static IntPtr AVMetadataObjectTypeGS1DataBarExpandedCode {
			get {
				fixed (IntPtr *storage = &values [20])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMetadataObjectTypeGS1DataBarExpandedCode", storage);
			}
		}
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[Field ("AVMetadataObjectTypeGS1DataBarLimitedCode", "AVFoundation")]
		internal unsafe static IntPtr AVMetadataObjectTypeGS1DataBarLimitedCode {
			get {
				fixed (IntPtr *storage = &values [21])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMetadataObjectTypeGS1DataBarLimitedCode", storage);
			}
		}
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[Field ("AVMetadataObjectTypeMicroQRCode", "AVFoundation")]
		internal unsafe static IntPtr AVMetadataObjectTypeMicroQRCode {
			get {
				fixed (IntPtr *storage = &values [22])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMetadataObjectTypeMicroQRCode", storage);
			}
		}
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[Field ("AVMetadataObjectTypeMicroPDF417Code", "AVFoundation")]
		internal unsafe static IntPtr AVMetadataObjectTypeMicroPDF417Code {
			get {
				fixed (IntPtr *storage = &values [23])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMetadataObjectTypeMicroPDF417Code", storage);
			}
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[Field ("AVMetadataObjectTypeHumanFullBody", "AVFoundation")]
		internal unsafe static IntPtr AVMetadataObjectTypeHumanFullBody {
			get {
				fixed (IntPtr *storage = &values [24])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMetadataObjectTypeHumanFullBody", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("AVMetadataObjectTypeCatHead", "AVFoundation")]
		internal unsafe static IntPtr AVMetadataObjectTypeCatHead {
			get {
				fixed (IntPtr *storage = &values [25])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMetadataObjectTypeCatHead", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("AVMetadataObjectTypeDogHead", "AVFoundation")]
		internal unsafe static IntPtr AVMetadataObjectTypeDogHead {
			get {
				fixed (IntPtr *storage = &values [26])
					return Dlfcn.CachePointer (Libraries.AVFoundation.Handle, "AVMetadataObjectTypeDogHead", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this AVMetadataObjectType self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((ulong) self) {
			case 1: // AVMetadataObjectType.Face
				ptr = AVMetadataObjectTypeFace;
				break;
			case 2: // AVMetadataObjectType.AztecCode
				ptr = AVMetadataObjectTypeAztecCode;
				break;
			case 4: // AVMetadataObjectType.Code128Code
				ptr = AVMetadataObjectTypeCode128Code;
				break;
			case 8: // AVMetadataObjectType.Code39Code
				ptr = AVMetadataObjectTypeCode39Code;
				break;
			case 16: // AVMetadataObjectType.Code39Mod43Code
				ptr = AVMetadataObjectTypeCode39Mod43Code;
				break;
			case 32: // AVMetadataObjectType.Code93Code
				ptr = AVMetadataObjectTypeCode93Code;
				break;
			case 64: // AVMetadataObjectType.EAN13Code
				ptr = AVMetadataObjectTypeEAN13Code;
				break;
			case 128: // AVMetadataObjectType.EAN8Code
				ptr = AVMetadataObjectTypeEAN8Code;
				break;
			case 256: // AVMetadataObjectType.PDF417Code
				ptr = AVMetadataObjectTypePDF417Code;
				break;
			case 512: // AVMetadataObjectType.QRCode
				ptr = AVMetadataObjectTypeQRCode;
				break;
			case 1024: // AVMetadataObjectType.UPCECode
				ptr = AVMetadataObjectTypeUPCECode;
				break;
			case 2048: // AVMetadataObjectType.Interleaved2of5Code
				ptr = AVMetadataObjectTypeInterleaved2of5Code;
				break;
			case 4096: // AVMetadataObjectType.ITF14Code
				ptr = AVMetadataObjectTypeITF14Code;
				break;
			case 8192: // AVMetadataObjectType.DataMatrixCode
				ptr = AVMetadataObjectTypeDataMatrixCode;
				break;
			case 16384: // AVMetadataObjectType.CatBody
				ptr = AVMetadataObjectTypeCatBody;
				break;
			case 32768: // AVMetadataObjectType.DogBody
				ptr = AVMetadataObjectTypeDogBody;
				break;
			case 65536: // AVMetadataObjectType.HumanBody
				ptr = AVMetadataObjectTypeHumanBody;
				break;
			case 131072: // AVMetadataObjectType.SalientObject
				ptr = AVMetadataObjectTypeSalientObject;
				break;
			case 262144: // AVMetadataObjectType.CodabarCode
				ptr = AVMetadataObjectTypeCodabarCode;
				break;
			case 524288: // AVMetadataObjectType.GS1DataBarCode
				ptr = AVMetadataObjectTypeGS1DataBarCode;
				break;
			case 1048576: // AVMetadataObjectType.GS1DataBarExpandedCode
				ptr = AVMetadataObjectTypeGS1DataBarExpandedCode;
				break;
			case 2097152: // AVMetadataObjectType.GS1DataBarLimitedCode
				ptr = AVMetadataObjectTypeGS1DataBarLimitedCode;
				break;
			case 4194304: // AVMetadataObjectType.MicroQRCode
				ptr = AVMetadataObjectTypeMicroQRCode;
				break;
			case 8388608: // AVMetadataObjectType.MicroPdf417Code
				ptr = AVMetadataObjectTypeMicroPDF417Code;
				break;
			case 16777216: // AVMetadataObjectType.HumanFullBody
				ptr = AVMetadataObjectTypeHumanFullBody;
				break;
			case 33554432: // AVMetadataObjectType.CatHead
				ptr = AVMetadataObjectTypeCatHead;
				break;
			case 67108864: // AVMetadataObjectType.DogHead
				ptr = AVMetadataObjectTypeDogHead;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVMetadataObjectType" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static AVMetadataObjectType GetValue (NSString? constant)
		{
			if (constant is null)
				return AVMetadataObjectType.None;
			if (constant.IsEqualTo (AVMetadataObjectTypeFace))
				return AVMetadataObjectType.Face;
			if (constant.IsEqualTo (AVMetadataObjectTypeAztecCode))
				return AVMetadataObjectType.AztecCode;
			if (constant.IsEqualTo (AVMetadataObjectTypeCode128Code))
				return AVMetadataObjectType.Code128Code;
			if (constant.IsEqualTo (AVMetadataObjectTypeCode39Code))
				return AVMetadataObjectType.Code39Code;
			if (constant.IsEqualTo (AVMetadataObjectTypeCode39Mod43Code))
				return AVMetadataObjectType.Code39Mod43Code;
			if (constant.IsEqualTo (AVMetadataObjectTypeCode93Code))
				return AVMetadataObjectType.Code93Code;
			if (constant.IsEqualTo (AVMetadataObjectTypeEAN13Code))
				return AVMetadataObjectType.EAN13Code;
			if (constant.IsEqualTo (AVMetadataObjectTypeEAN8Code))
				return AVMetadataObjectType.EAN8Code;
			if (constant.IsEqualTo (AVMetadataObjectTypePDF417Code))
				return AVMetadataObjectType.PDF417Code;
			if (constant.IsEqualTo (AVMetadataObjectTypeQRCode))
				return AVMetadataObjectType.QRCode;
			if (constant.IsEqualTo (AVMetadataObjectTypeUPCECode))
				return AVMetadataObjectType.UPCECode;
			if (constant.IsEqualTo (AVMetadataObjectTypeInterleaved2of5Code))
				return AVMetadataObjectType.Interleaved2of5Code;
			if (constant.IsEqualTo (AVMetadataObjectTypeITF14Code))
				return AVMetadataObjectType.ITF14Code;
			if (constant.IsEqualTo (AVMetadataObjectTypeDataMatrixCode))
				return AVMetadataObjectType.DataMatrixCode;
			if (constant.IsEqualTo (AVMetadataObjectTypeCatBody))
				return AVMetadataObjectType.CatBody;
			if (constant.IsEqualTo (AVMetadataObjectTypeDogBody))
				return AVMetadataObjectType.DogBody;
			if (constant.IsEqualTo (AVMetadataObjectTypeHumanBody))
				return AVMetadataObjectType.HumanBody;
			if (constant.IsEqualTo (AVMetadataObjectTypeSalientObject))
				return AVMetadataObjectType.SalientObject;
			if (constant.IsEqualTo (AVMetadataObjectTypeCodabarCode))
				return AVMetadataObjectType.CodabarCode;
			if (constant.IsEqualTo (AVMetadataObjectTypeGS1DataBarCode))
				return AVMetadataObjectType.GS1DataBarCode;
			if (constant.IsEqualTo (AVMetadataObjectTypeGS1DataBarExpandedCode))
				return AVMetadataObjectType.GS1DataBarExpandedCode;
			if (constant.IsEqualTo (AVMetadataObjectTypeGS1DataBarLimitedCode))
				return AVMetadataObjectType.GS1DataBarLimitedCode;
			if (constant.IsEqualTo (AVMetadataObjectTypeMicroQRCode))
				return AVMetadataObjectType.MicroQRCode;
			if (constant.IsEqualTo (AVMetadataObjectTypeMicroPDF417Code))
				return AVMetadataObjectType.MicroPdf417Code;
			if (constant.IsEqualTo (AVMetadataObjectTypeHumanFullBody))
				return AVMetadataObjectType.HumanFullBody;
			if (constant.IsEqualTo (AVMetadataObjectTypeCatHead))
				return AVMetadataObjectType.CatHead;
			if (constant.IsEqualTo (AVMetadataObjectTypeDogHead))
				return AVMetadataObjectType.DogHead;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVMetadataObjectType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVMetadataObjectType GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AVFoundation.AVMetadataObjectType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static AVMetadataObjectType? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AVFoundation.AVMetadataObjectType" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this AVMetadataObjectType[]? values)
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
		internal static AVMetadataObjectType[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<AVMetadataObjectType> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
		/// <summary>Retrieves all the <see cref="global::AVFoundation.AVMetadataObjectType" /> constants named by the flags <paramref name="value" />.</summary>
		/// <param name="value">The flags to retrieve</param>
		/// <remarks>Any flags that are not recognized will be ignored.</remarks>
		public static NSString[] ToArray (this AVMetadataObjectType value)
		{
			var rv = new global::System.Collections.Generic.List<NSString> ();
			if (value.HasFlag (AVMetadataObjectType.Face) && AVMetadataObjectTypeFace != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (AVMetadataObjectTypeFace)!);
			if (value.HasFlag (AVMetadataObjectType.AztecCode) && AVMetadataObjectTypeAztecCode != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (AVMetadataObjectTypeAztecCode)!);
			if (value.HasFlag (AVMetadataObjectType.Code128Code) && AVMetadataObjectTypeCode128Code != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (AVMetadataObjectTypeCode128Code)!);
			if (value.HasFlag (AVMetadataObjectType.Code39Code) && AVMetadataObjectTypeCode39Code != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (AVMetadataObjectTypeCode39Code)!);
			if (value.HasFlag (AVMetadataObjectType.Code39Mod43Code) && AVMetadataObjectTypeCode39Mod43Code != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (AVMetadataObjectTypeCode39Mod43Code)!);
			if (value.HasFlag (AVMetadataObjectType.Code93Code) && AVMetadataObjectTypeCode93Code != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (AVMetadataObjectTypeCode93Code)!);
			if (value.HasFlag (AVMetadataObjectType.EAN13Code) && AVMetadataObjectTypeEAN13Code != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (AVMetadataObjectTypeEAN13Code)!);
			if (value.HasFlag (AVMetadataObjectType.EAN8Code) && AVMetadataObjectTypeEAN8Code != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (AVMetadataObjectTypeEAN8Code)!);
			if (value.HasFlag (AVMetadataObjectType.PDF417Code) && AVMetadataObjectTypePDF417Code != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (AVMetadataObjectTypePDF417Code)!);
			if (value.HasFlag (AVMetadataObjectType.QRCode) && AVMetadataObjectTypeQRCode != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (AVMetadataObjectTypeQRCode)!);
			if (value.HasFlag (AVMetadataObjectType.UPCECode) && AVMetadataObjectTypeUPCECode != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (AVMetadataObjectTypeUPCECode)!);
			if (value.HasFlag (AVMetadataObjectType.Interleaved2of5Code) && AVMetadataObjectTypeInterleaved2of5Code != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (AVMetadataObjectTypeInterleaved2of5Code)!);
			if (value.HasFlag (AVMetadataObjectType.ITF14Code) && AVMetadataObjectTypeITF14Code != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (AVMetadataObjectTypeITF14Code)!);
			if (value.HasFlag (AVMetadataObjectType.DataMatrixCode) && AVMetadataObjectTypeDataMatrixCode != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (AVMetadataObjectTypeDataMatrixCode)!);
			if (value.HasFlag (AVMetadataObjectType.CatBody) && AVMetadataObjectTypeCatBody != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (AVMetadataObjectTypeCatBody)!);
			if (value.HasFlag (AVMetadataObjectType.DogBody) && AVMetadataObjectTypeDogBody != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (AVMetadataObjectTypeDogBody)!);
			if (value.HasFlag (AVMetadataObjectType.HumanBody) && AVMetadataObjectTypeHumanBody != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (AVMetadataObjectTypeHumanBody)!);
			if (value.HasFlag (AVMetadataObjectType.SalientObject) && AVMetadataObjectTypeSalientObject != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (AVMetadataObjectTypeSalientObject)!);
			if (value.HasFlag (AVMetadataObjectType.CodabarCode) && AVMetadataObjectTypeCodabarCode != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (AVMetadataObjectTypeCodabarCode)!);
			if (value.HasFlag (AVMetadataObjectType.GS1DataBarCode) && AVMetadataObjectTypeGS1DataBarCode != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (AVMetadataObjectTypeGS1DataBarCode)!);
			if (value.HasFlag (AVMetadataObjectType.GS1DataBarExpandedCode) && AVMetadataObjectTypeGS1DataBarExpandedCode != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (AVMetadataObjectTypeGS1DataBarExpandedCode)!);
			if (value.HasFlag (AVMetadataObjectType.GS1DataBarLimitedCode) && AVMetadataObjectTypeGS1DataBarLimitedCode != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (AVMetadataObjectTypeGS1DataBarLimitedCode)!);
			if (value.HasFlag (AVMetadataObjectType.MicroQRCode) && AVMetadataObjectTypeMicroQRCode != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (AVMetadataObjectTypeMicroQRCode)!);
			if (value.HasFlag (AVMetadataObjectType.MicroPdf417Code) && AVMetadataObjectTypeMicroPDF417Code != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (AVMetadataObjectTypeMicroPDF417Code)!);
			if (value.HasFlag (AVMetadataObjectType.HumanFullBody) && AVMetadataObjectTypeHumanFullBody != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (AVMetadataObjectTypeHumanFullBody)!);
			if (value.HasFlag (AVMetadataObjectType.CatHead) && AVMetadataObjectTypeCatHead != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (AVMetadataObjectTypeCatHead)!);
			if (value.HasFlag (AVMetadataObjectType.DogHead) && AVMetadataObjectTypeDogHead != IntPtr.Zero)
				rv.Add ((NSString) Runtime.GetNSObject (AVMetadataObjectTypeDogHead)!);
			// In order to be forward-compatible, any unknown values are ignored.
			return rv.ToArray ();
		}
		public static AVMetadataObjectType ToFlags (global::System.Collections.Generic.IEnumerable<NSString?>? constants)
		{
			var rv = default (AVMetadataObjectType);
			if (constants is null)
				return rv;
			foreach (var constant in constants) {
				if (constant is null)
					continue;
				else if (constant.IsEqualTo (AVMetadataObjectTypeFace))
					rv |= AVMetadataObjectType.Face;
				else if (constant.IsEqualTo (AVMetadataObjectTypeAztecCode))
					rv |= AVMetadataObjectType.AztecCode;
				else if (constant.IsEqualTo (AVMetadataObjectTypeCode128Code))
					rv |= AVMetadataObjectType.Code128Code;
				else if (constant.IsEqualTo (AVMetadataObjectTypeCode39Code))
					rv |= AVMetadataObjectType.Code39Code;
				else if (constant.IsEqualTo (AVMetadataObjectTypeCode39Mod43Code))
					rv |= AVMetadataObjectType.Code39Mod43Code;
				else if (constant.IsEqualTo (AVMetadataObjectTypeCode93Code))
					rv |= AVMetadataObjectType.Code93Code;
				else if (constant.IsEqualTo (AVMetadataObjectTypeEAN13Code))
					rv |= AVMetadataObjectType.EAN13Code;
				else if (constant.IsEqualTo (AVMetadataObjectTypeEAN8Code))
					rv |= AVMetadataObjectType.EAN8Code;
				else if (constant.IsEqualTo (AVMetadataObjectTypePDF417Code))
					rv |= AVMetadataObjectType.PDF417Code;
				else if (constant.IsEqualTo (AVMetadataObjectTypeQRCode))
					rv |= AVMetadataObjectType.QRCode;
				else if (constant.IsEqualTo (AVMetadataObjectTypeUPCECode))
					rv |= AVMetadataObjectType.UPCECode;
				else if (constant.IsEqualTo (AVMetadataObjectTypeInterleaved2of5Code))
					rv |= AVMetadataObjectType.Interleaved2of5Code;
				else if (constant.IsEqualTo (AVMetadataObjectTypeITF14Code))
					rv |= AVMetadataObjectType.ITF14Code;
				else if (constant.IsEqualTo (AVMetadataObjectTypeDataMatrixCode))
					rv |= AVMetadataObjectType.DataMatrixCode;
				else if (constant.IsEqualTo (AVMetadataObjectTypeCatBody))
					rv |= AVMetadataObjectType.CatBody;
				else if (constant.IsEqualTo (AVMetadataObjectTypeDogBody))
					rv |= AVMetadataObjectType.DogBody;
				else if (constant.IsEqualTo (AVMetadataObjectTypeHumanBody))
					rv |= AVMetadataObjectType.HumanBody;
				else if (constant.IsEqualTo (AVMetadataObjectTypeSalientObject))
					rv |= AVMetadataObjectType.SalientObject;
				else if (constant.IsEqualTo (AVMetadataObjectTypeCodabarCode))
					rv |= AVMetadataObjectType.CodabarCode;
				else if (constant.IsEqualTo (AVMetadataObjectTypeGS1DataBarCode))
					rv |= AVMetadataObjectType.GS1DataBarCode;
				else if (constant.IsEqualTo (AVMetadataObjectTypeGS1DataBarExpandedCode))
					rv |= AVMetadataObjectType.GS1DataBarExpandedCode;
				else if (constant.IsEqualTo (AVMetadataObjectTypeGS1DataBarLimitedCode))
					rv |= AVMetadataObjectType.GS1DataBarLimitedCode;
				else if (constant.IsEqualTo (AVMetadataObjectTypeMicroQRCode))
					rv |= AVMetadataObjectType.MicroQRCode;
				else if (constant.IsEqualTo (AVMetadataObjectTypeMicroPDF417Code))
					rv |= AVMetadataObjectType.MicroPdf417Code;
				else if (constant.IsEqualTo (AVMetadataObjectTypeHumanFullBody))
					rv |= AVMetadataObjectType.HumanFullBody;
				else if (constant.IsEqualTo (AVMetadataObjectTypeCatHead))
					rv |= AVMetadataObjectType.CatHead;
				else if (constant.IsEqualTo (AVMetadataObjectTypeDogHead))
					rv |= AVMetadataObjectType.DogHead;
				// In order to be forward-compatible, any unknown values are ignored.
			}
			return rv;
		}
	}
}
