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
namespace ImageIO {
	/// <summary>Known properties of various metadata prefixes. Most often used with <see cref="ImageIO.CGImageMetadata.CopyTagMatchingImageProperty(Foundation.NSString,Foundation.NSString)" />.</summary>
	public unsafe static partial class CGImageProperties  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ApngCanvasPixelHeight;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyAPNGCanvasPixelHeight'.</summary>
		[Field ("kCGImagePropertyAPNGCanvasPixelHeight",  "ImageIO")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ApngCanvasPixelHeight {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ApngCanvasPixelHeight is null)
					_ApngCanvasPixelHeight = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyAPNGCanvasPixelHeight")!;
				return _ApngCanvasPixelHeight;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ApngCanvasPixelWidth;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyAPNGCanvasPixelWidth'.</summary>
		[Field ("kCGImagePropertyAPNGCanvasPixelWidth",  "ImageIO")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ApngCanvasPixelWidth {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ApngCanvasPixelWidth is null)
					_ApngCanvasPixelWidth = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyAPNGCanvasPixelWidth")!;
				return _ApngCanvasPixelWidth;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ApngFrameInfoArray;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyAPNGFrameInfoArray'.</summary>
		[Field ("kCGImagePropertyAPNGFrameInfoArray",  "ImageIO")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ApngFrameInfoArray {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ApngFrameInfoArray is null)
					_ApngFrameInfoArray = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyAPNGFrameInfoArray")!;
				return _ApngFrameInfoArray;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AuxiliaryData;
		/// <summary>Represents the value associated with the constant kCGImagePropertyAuxiliaryData</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyAuxiliaryData",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AuxiliaryData {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AuxiliaryData is null)
					_AuxiliaryData = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyAuxiliaryData")!;
				return _AuxiliaryData;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AuxiliaryDataType;
		/// <summary>Represents the value associated with the constant kCGImagePropertyAuxiliaryDataType</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyAuxiliaryDataType",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AuxiliaryDataType {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AuxiliaryDataType is null)
					_AuxiliaryDataType = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyAuxiliaryDataType")!;
				return _AuxiliaryDataType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AvisDictionary;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyAVISDictionary'.</summary>
		[Field ("kCGImagePropertyAVISDictionary",  "ImageIO")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public static NSString AvisDictionary {
			[SupportedOSPlatform ("macos14.0")]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				if (_AvisDictionary is null)
					_AvisDictionary = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyAVISDictionary")!;
				return _AvisDictionary;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BytesPerRow;
		/// <summary>Represents the value associated with the constant kCGImagePropertyBytesPerRow</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyBytesPerRow",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString BytesPerRow {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_BytesPerRow is null)
					_BytesPerRow = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyBytesPerRow")!;
				return _BytesPerRow;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CIFFCameraSerialNumber;
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFCameraSerialNumber</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyCIFFCameraSerialNumber",  "ImageIO")]
		public static NSString CIFFCameraSerialNumber {
			get {
				if (_CIFFCameraSerialNumber is null)
					_CIFFCameraSerialNumber = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyCIFFCameraSerialNumber")!;
				return _CIFFCameraSerialNumber;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CIFFContinuousDrive;
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFContinuousDrive</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyCIFFContinuousDrive",  "ImageIO")]
		public static NSString CIFFContinuousDrive {
			get {
				if (_CIFFContinuousDrive is null)
					_CIFFContinuousDrive = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyCIFFContinuousDrive")!;
				return _CIFFContinuousDrive;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CIFFDescription;
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFDescription</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyCIFFDescription",  "ImageIO")]
		public static NSString CIFFDescription {
			get {
				if (_CIFFDescription is null)
					_CIFFDescription = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyCIFFDescription")!;
				return _CIFFDescription;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CIFFDictionary;
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFDictionary</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyCIFFDictionary",  "ImageIO")]
		public static NSString CIFFDictionary {
			get {
				if (_CIFFDictionary is null)
					_CIFFDictionary = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyCIFFDictionary")!;
				return _CIFFDictionary;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CIFFFirmware;
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFFirmware</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyCIFFFirmware",  "ImageIO")]
		public static NSString CIFFFirmware {
			get {
				if (_CIFFFirmware is null)
					_CIFFFirmware = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyCIFFFirmware")!;
				return _CIFFFirmware;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CIFFFlashExposureComp;
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFFlashExposureComp</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyCIFFFlashExposureComp",  "ImageIO")]
		public static NSString CIFFFlashExposureComp {
			get {
				if (_CIFFFlashExposureComp is null)
					_CIFFFlashExposureComp = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyCIFFFlashExposureComp")!;
				return _CIFFFlashExposureComp;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CIFFFocusMode;
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFFocusMode</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyCIFFFocusMode",  "ImageIO")]
		public static NSString CIFFFocusMode {
			get {
				if (_CIFFFocusMode is null)
					_CIFFFocusMode = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyCIFFFocusMode")!;
				return _CIFFFocusMode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CIFFImageFileName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFImageFileName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyCIFFImageFileName",  "ImageIO")]
		public static NSString CIFFImageFileName {
			get {
				if (_CIFFImageFileName is null)
					_CIFFImageFileName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyCIFFImageFileName")!;
				return _CIFFImageFileName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CIFFImageName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFImageName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyCIFFImageName",  "ImageIO")]
		public static NSString CIFFImageName {
			get {
				if (_CIFFImageName is null)
					_CIFFImageName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyCIFFImageName")!;
				return _CIFFImageName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CIFFImageSerialNumber;
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFImageSerialNumber</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyCIFFImageSerialNumber",  "ImageIO")]
		public static NSString CIFFImageSerialNumber {
			get {
				if (_CIFFImageSerialNumber is null)
					_CIFFImageSerialNumber = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyCIFFImageSerialNumber")!;
				return _CIFFImageSerialNumber;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CIFFLensMaxMM;
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFLensMaxMM</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyCIFFLensMaxMM",  "ImageIO")]
		public static NSString CIFFLensMaxMM {
			get {
				if (_CIFFLensMaxMM is null)
					_CIFFLensMaxMM = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyCIFFLensMaxMM")!;
				return _CIFFLensMaxMM;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CIFFLensMinMM;
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFLensMinMM</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyCIFFLensMinMM",  "ImageIO")]
		public static NSString CIFFLensMinMM {
			get {
				if (_CIFFLensMinMM is null)
					_CIFFLensMinMM = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyCIFFLensMinMM")!;
				return _CIFFLensMinMM;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CIFFLensModel;
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFLensModel</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyCIFFLensModel",  "ImageIO")]
		public static NSString CIFFLensModel {
			get {
				if (_CIFFLensModel is null)
					_CIFFLensModel = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyCIFFLensModel")!;
				return _CIFFLensModel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CIFFMeasuredEV;
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFMeasuredEV</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyCIFFMeasuredEV",  "ImageIO")]
		public static NSString CIFFMeasuredEV {
			get {
				if (_CIFFMeasuredEV is null)
					_CIFFMeasuredEV = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyCIFFMeasuredEV")!;
				return _CIFFMeasuredEV;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CIFFMeteringMode;
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFMeteringMode</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyCIFFMeteringMode",  "ImageIO")]
		public static NSString CIFFMeteringMode {
			get {
				if (_CIFFMeteringMode is null)
					_CIFFMeteringMode = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyCIFFMeteringMode")!;
				return _CIFFMeteringMode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CIFFOwnerName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFOwnerName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyCIFFOwnerName",  "ImageIO")]
		public static NSString CIFFOwnerName {
			get {
				if (_CIFFOwnerName is null)
					_CIFFOwnerName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyCIFFOwnerName")!;
				return _CIFFOwnerName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CIFFRecordID;
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFRecordID</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyCIFFRecordID",  "ImageIO")]
		public static NSString CIFFRecordID {
			get {
				if (_CIFFRecordID is null)
					_CIFFRecordID = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyCIFFRecordID")!;
				return _CIFFRecordID;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CIFFReleaseMethod;
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFReleaseMethod</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyCIFFReleaseMethod",  "ImageIO")]
		public static NSString CIFFReleaseMethod {
			get {
				if (_CIFFReleaseMethod is null)
					_CIFFReleaseMethod = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyCIFFReleaseMethod")!;
				return _CIFFReleaseMethod;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CIFFReleaseTiming;
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFReleaseTiming</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyCIFFReleaseTiming",  "ImageIO")]
		public static NSString CIFFReleaseTiming {
			get {
				if (_CIFFReleaseTiming is null)
					_CIFFReleaseTiming = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyCIFFReleaseTiming")!;
				return _CIFFReleaseTiming;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CIFFSelfTimingTime;
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFSelfTimingTime</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyCIFFSelfTimingTime",  "ImageIO")]
		public static NSString CIFFSelfTimingTime {
			get {
				if (_CIFFSelfTimingTime is null)
					_CIFFSelfTimingTime = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyCIFFSelfTimingTime")!;
				return _CIFFSelfTimingTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CIFFShootingMode;
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFShootingMode</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyCIFFShootingMode",  "ImageIO")]
		public static NSString CIFFShootingMode {
			get {
				if (_CIFFShootingMode is null)
					_CIFFShootingMode = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyCIFFShootingMode")!;
				return _CIFFShootingMode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CIFFWhiteBalanceIndex;
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFWhiteBalanceIndex</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyCIFFWhiteBalanceIndex",  "ImageIO")]
		public static NSString CIFFWhiteBalanceIndex {
			get {
				if (_CIFFWhiteBalanceIndex is null)
					_CIFFWhiteBalanceIndex = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyCIFFWhiteBalanceIndex")!;
				return _CIFFWhiteBalanceIndex;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ColorModel;
		/// <summary>Represents the value associated with the constant kCGImagePropertyColorModel</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyColorModel",  "ImageIO")]
		public static NSString ColorModel {
			get {
				if (_ColorModel is null)
					_ColorModel = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyColorModel")!;
				return _ColorModel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ColorModelCMYK;
		/// <summary>Represents the value associated with the constant kCGImagePropertyColorModelCMYK</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyColorModelCMYK",  "ImageIO")]
		public static NSString ColorModelCMYK {
			get {
				if (_ColorModelCMYK is null)
					_ColorModelCMYK = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyColorModelCMYK")!;
				return _ColorModelCMYK;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ColorModelGray;
		/// <summary>Represents the value associated with the constant kCGImagePropertyColorModelGray</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyColorModelGray",  "ImageIO")]
		public static NSString ColorModelGray {
			get {
				if (_ColorModelGray is null)
					_ColorModelGray = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyColorModelGray")!;
				return _ColorModelGray;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ColorModelLab;
		/// <summary>Represents the value associated with the constant kCGImagePropertyColorModelLab</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyColorModelLab",  "ImageIO")]
		public static NSString ColorModelLab {
			get {
				if (_ColorModelLab is null)
					_ColorModelLab = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyColorModelLab")!;
				return _ColorModelLab;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ColorModelRGB;
		/// <summary>Represents the value associated with the constant kCGImagePropertyColorModelRGB</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyColorModelRGB",  "ImageIO")]
		public static NSString ColorModelRGB {
			get {
				if (_ColorModelRGB is null)
					_ColorModelRGB = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyColorModelRGB")!;
				return _ColorModelRGB;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGActiveArea;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGActiveArea",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGActiveArea {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGActiveArea is null)
					_DNGActiveArea = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGActiveArea")!;
				return _DNGActiveArea;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGAnalogBalance;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGAnalogBalance",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGAnalogBalance {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGAnalogBalance is null)
					_DNGAnalogBalance = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGAnalogBalance")!;
				return _DNGAnalogBalance;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGAntiAliasStrength;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGAntiAliasStrength",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGAntiAliasStrength {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGAntiAliasStrength is null)
					_DNGAntiAliasStrength = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGAntiAliasStrength")!;
				return _DNGAntiAliasStrength;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGAsShotICCProfile;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGAsShotICCProfile",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGAsShotICCProfile {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGAsShotICCProfile is null)
					_DNGAsShotICCProfile = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGAsShotICCProfile")!;
				return _DNGAsShotICCProfile;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGAsShotNeutral;
		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGAsShotNeutral.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGAsShotNeutral",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGAsShotNeutral {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGAsShotNeutral is null)
					_DNGAsShotNeutral = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGAsShotNeutral")!;
				return _DNGAsShotNeutral;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGAsShotPreProfileMatrix;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGAsShotPreProfileMatrix",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGAsShotPreProfileMatrix {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGAsShotPreProfileMatrix is null)
					_DNGAsShotPreProfileMatrix = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGAsShotPreProfileMatrix")!;
				return _DNGAsShotPreProfileMatrix;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGAsShotProfileName;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGAsShotProfileName",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGAsShotProfileName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGAsShotProfileName is null)
					_DNGAsShotProfileName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGAsShotProfileName")!;
				return _DNGAsShotProfileName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGAsShotWhiteXY;
		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGAsShotWhiteXY.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGAsShotWhiteXY",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGAsShotWhiteXY {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGAsShotWhiteXY is null)
					_DNGAsShotWhiteXY = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGAsShotWhiteXY")!;
				return _DNGAsShotWhiteXY;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGBackwardVersion;
		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGBackwardVersion</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGBackwardVersion",  "ImageIO")]
		public static NSString DNGBackwardVersion {
			get {
				if (_DNGBackwardVersion is null)
					_DNGBackwardVersion = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGBackwardVersion")!;
				return _DNGBackwardVersion;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGBaselineExposure;
		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGBaselineExposure.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGBaselineExposure",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGBaselineExposure {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGBaselineExposure is null)
					_DNGBaselineExposure = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGBaselineExposure")!;
				return _DNGBaselineExposure;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGBaselineExposureOffset;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGBaselineExposureOffset",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGBaselineExposureOffset {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGBaselineExposureOffset is null)
					_DNGBaselineExposureOffset = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGBaselineExposureOffset")!;
				return _DNGBaselineExposureOffset;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGBaselineNoise;
		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGBaselineNoise.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGBaselineNoise",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGBaselineNoise {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGBaselineNoise is null)
					_DNGBaselineNoise = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGBaselineNoise")!;
				return _DNGBaselineNoise;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGBaselineSharpness;
		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGBaselineSharpness.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGBaselineSharpness",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGBaselineSharpness {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGBaselineSharpness is null)
					_DNGBaselineSharpness = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGBaselineSharpness")!;
				return _DNGBaselineSharpness;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGBayerGreenSplit;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGBayerGreenSplit",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGBayerGreenSplit {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGBayerGreenSplit is null)
					_DNGBayerGreenSplit = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGBayerGreenSplit")!;
				return _DNGBayerGreenSplit;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGBestQualityScale;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGBestQualityScale",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGBestQualityScale {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGBestQualityScale is null)
					_DNGBestQualityScale = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGBestQualityScale")!;
				return _DNGBestQualityScale;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGBlackLevel;
		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGBlackLevel.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGBlackLevel",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGBlackLevel {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGBlackLevel is null)
					_DNGBlackLevel = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGBlackLevel")!;
				return _DNGBlackLevel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGBlackLevelDeltaHorizontal;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGBlackLevelDeltaH",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGBlackLevelDeltaHorizontal {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGBlackLevelDeltaHorizontal is null)
					_DNGBlackLevelDeltaHorizontal = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGBlackLevelDeltaH")!;
				return _DNGBlackLevelDeltaHorizontal;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGBlackLevelDeltaVertical;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGBlackLevelDeltaV",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGBlackLevelDeltaVertical {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGBlackLevelDeltaVertical is null)
					_DNGBlackLevelDeltaVertical = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGBlackLevelDeltaV")!;
				return _DNGBlackLevelDeltaVertical;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGBlackLevelRepeatDim;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGBlackLevelRepeatDim",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGBlackLevelRepeatDim {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGBlackLevelRepeatDim is null)
					_DNGBlackLevelRepeatDim = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGBlackLevelRepeatDim")!;
				return _DNGBlackLevelRepeatDim;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGCalibrationIlluminant1;
		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGCalibrationIlluminant1.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGCalibrationIlluminant1",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGCalibrationIlluminant1 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGCalibrationIlluminant1 is null)
					_DNGCalibrationIlluminant1 = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGCalibrationIlluminant1")!;
				return _DNGCalibrationIlluminant1;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGCalibrationIlluminant2;
		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGCalibrationIlluminant2.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGCalibrationIlluminant2",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGCalibrationIlluminant2 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGCalibrationIlluminant2 is null)
					_DNGCalibrationIlluminant2 = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGCalibrationIlluminant2")!;
				return _DNGCalibrationIlluminant2;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGCameraCalibration1;
		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGCameraCalibration1.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGCameraCalibration1",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGCameraCalibration1 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGCameraCalibration1 is null)
					_DNGCameraCalibration1 = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGCameraCalibration1")!;
				return _DNGCameraCalibration1;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGCameraCalibration2;
		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGCameraCalibration2.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGCameraCalibration2",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGCameraCalibration2 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGCameraCalibration2 is null)
					_DNGCameraCalibration2 = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGCameraCalibration2")!;
				return _DNGCameraCalibration2;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGCameraCalibrationSignature;
		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGCameraCalibrationSignature.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGCameraCalibrationSignature",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGCameraCalibrationSignature {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGCameraCalibrationSignature is null)
					_DNGCameraCalibrationSignature = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGCameraCalibrationSignature")!;
				return _DNGCameraCalibrationSignature;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGCameraSerialNumber;
		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGCameraSerialNumber</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGCameraSerialNumber",  "ImageIO")]
		public static NSString DNGCameraSerialNumber {
			get {
				if (_DNGCameraSerialNumber is null)
					_DNGCameraSerialNumber = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGCameraSerialNumber")!;
				return _DNGCameraSerialNumber;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGCfaLayout;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGCFALayout",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGCfaLayout {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGCfaLayout is null)
					_DNGCfaLayout = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGCFALayout")!;
				return _DNGCfaLayout;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGCfaPlaneColor;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGCFAPlaneColor",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGCfaPlaneColor {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGCfaPlaneColor is null)
					_DNGCfaPlaneColor = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGCFAPlaneColor")!;
				return _DNGCfaPlaneColor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGChromaBlurRadius;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGChromaBlurRadius",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGChromaBlurRadius {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGChromaBlurRadius is null)
					_DNGChromaBlurRadius = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGChromaBlurRadius")!;
				return _DNGChromaBlurRadius;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGColorMatrix1;
		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGColorMatrix1.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGColorMatrix1",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGColorMatrix1 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGColorMatrix1 is null)
					_DNGColorMatrix1 = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGColorMatrix1")!;
				return _DNGColorMatrix1;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGColorMatrix2;
		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGColorMatrix2.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGColorMatrix2",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGColorMatrix2 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGColorMatrix2 is null)
					_DNGColorMatrix2 = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGColorMatrix2")!;
				return _DNGColorMatrix2;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGColorimetricReference;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGColorimetricReference",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGColorimetricReference {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGColorimetricReference is null)
					_DNGColorimetricReference = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGColorimetricReference")!;
				return _DNGColorimetricReference;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGCurrentICCProfile;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGCurrentICCProfile",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGCurrentICCProfile {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGCurrentICCProfile is null)
					_DNGCurrentICCProfile = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGCurrentICCProfile")!;
				return _DNGCurrentICCProfile;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGCurrentPreProfileMatrix;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGCurrentPreProfileMatrix",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGCurrentPreProfileMatrix {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGCurrentPreProfileMatrix is null)
					_DNGCurrentPreProfileMatrix = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGCurrentPreProfileMatrix")!;
				return _DNGCurrentPreProfileMatrix;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGDefaultBlackRender;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGDefaultBlackRender",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGDefaultBlackRender {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGDefaultBlackRender is null)
					_DNGDefaultBlackRender = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGDefaultBlackRender")!;
				return _DNGDefaultBlackRender;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGDefaultCropOrigin;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGDefaultCropOrigin",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGDefaultCropOrigin {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGDefaultCropOrigin is null)
					_DNGDefaultCropOrigin = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGDefaultCropOrigin")!;
				return _DNGDefaultCropOrigin;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGDefaultCropSize;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGDefaultCropSize",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGDefaultCropSize {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGDefaultCropSize is null)
					_DNGDefaultCropSize = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGDefaultCropSize")!;
				return _DNGDefaultCropSize;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGDefaultScale;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGDefaultScale",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGDefaultScale {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGDefaultScale is null)
					_DNGDefaultScale = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGDefaultScale")!;
				return _DNGDefaultScale;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGDefaultUserCrop;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGDefaultUserCrop",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGDefaultUserCrop {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGDefaultUserCrop is null)
					_DNGDefaultUserCrop = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGDefaultUserCrop")!;
				return _DNGDefaultUserCrop;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGDictionary;
		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGDictionary</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGDictionary",  "ImageIO")]
		public static NSString DNGDictionary {
			get {
				if (_DNGDictionary is null)
					_DNGDictionary = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGDictionary")!;
				return _DNGDictionary;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGExtraCameraProfiles;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGExtraCameraProfiles",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGExtraCameraProfiles {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGExtraCameraProfiles is null)
					_DNGExtraCameraProfiles = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGExtraCameraProfiles")!;
				return _DNGExtraCameraProfiles;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGFixVignetteRadial;
		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGFixVignetteRadial.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGFixVignetteRadial",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGFixVignetteRadial {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGFixVignetteRadial is null)
					_DNGFixVignetteRadial = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGFixVignetteRadial")!;
				return _DNGFixVignetteRadial;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGForwardMatrix1;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGForwardMatrix1",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGForwardMatrix1 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGForwardMatrix1 is null)
					_DNGForwardMatrix1 = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGForwardMatrix1")!;
				return _DNGForwardMatrix1;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGForwardMatrix2;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGForwardMatrix2",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGForwardMatrix2 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGForwardMatrix2 is null)
					_DNGForwardMatrix2 = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGForwardMatrix2")!;
				return _DNGForwardMatrix2;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGLensInfo;
		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGLensInfo</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGLensInfo",  "ImageIO")]
		public static NSString DNGLensInfo {
			get {
				if (_DNGLensInfo is null)
					_DNGLensInfo = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGLensInfo")!;
				return _DNGLensInfo;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGLinearResponseLimit;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGLinearResponseLimit",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGLinearResponseLimit {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGLinearResponseLimit is null)
					_DNGLinearResponseLimit = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGLinearResponseLimit")!;
				return _DNGLinearResponseLimit;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGLinearizationTable;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGLinearizationTable",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGLinearizationTable {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGLinearizationTable is null)
					_DNGLinearizationTable = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGLinearizationTable")!;
				return _DNGLinearizationTable;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGLocalizedCameraModel;
		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGLocalizedCameraModel</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGLocalizedCameraModel",  "ImageIO")]
		public static NSString DNGLocalizedCameraModel {
			get {
				if (_DNGLocalizedCameraModel is null)
					_DNGLocalizedCameraModel = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGLocalizedCameraModel")!;
				return _DNGLocalizedCameraModel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGMakerNoteSafety;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGMakerNoteSafety",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGMakerNoteSafety {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGMakerNoteSafety is null)
					_DNGMakerNoteSafety = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGMakerNoteSafety")!;
				return _DNGMakerNoteSafety;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGMaskedAreas;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGMaskedAreas",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGMaskedAreas {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGMaskedAreas is null)
					_DNGMaskedAreas = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGMaskedAreas")!;
				return _DNGMaskedAreas;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGNewRawImageDigest;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGNewRawImageDigest",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGNewRawImageDigest {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGNewRawImageDigest is null)
					_DNGNewRawImageDigest = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGNewRawImageDigest")!;
				return _DNGNewRawImageDigest;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGNoiseProfile;
		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGNoiseProfile.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGNoiseProfile",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGNoiseProfile {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGNoiseProfile is null)
					_DNGNoiseProfile = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGNoiseProfile")!;
				return _DNGNoiseProfile;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGNoiseReductionApplied;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGNoiseReductionApplied",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGNoiseReductionApplied {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGNoiseReductionApplied is null)
					_DNGNoiseReductionApplied = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGNoiseReductionApplied")!;
				return _DNGNoiseReductionApplied;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGOpcodeList1;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGOpcodeList1",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGOpcodeList1 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGOpcodeList1 is null)
					_DNGOpcodeList1 = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGOpcodeList1")!;
				return _DNGOpcodeList1;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGOpcodeList2;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGOpcodeList2",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGOpcodeList2 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGOpcodeList2 is null)
					_DNGOpcodeList2 = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGOpcodeList2")!;
				return _DNGOpcodeList2;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGOpcodeList3;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGOpcodeList3",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGOpcodeList3 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGOpcodeList3 is null)
					_DNGOpcodeList3 = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGOpcodeList3")!;
				return _DNGOpcodeList3;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGOriginalBestQualityFinalSize;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGOriginalBestQualityFinalSize",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGOriginalBestQualityFinalSize {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGOriginalBestQualityFinalSize is null)
					_DNGOriginalBestQualityFinalSize = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGOriginalBestQualityFinalSize")!;
				return _DNGOriginalBestQualityFinalSize;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGOriginalDefaultCropSize;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGOriginalDefaultCropSize",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGOriginalDefaultCropSize {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGOriginalDefaultCropSize is null)
					_DNGOriginalDefaultCropSize = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGOriginalDefaultCropSize")!;
				return _DNGOriginalDefaultCropSize;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGOriginalDefaultFinalSize;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGOriginalDefaultFinalSize",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGOriginalDefaultFinalSize {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGOriginalDefaultFinalSize is null)
					_DNGOriginalDefaultFinalSize = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGOriginalDefaultFinalSize")!;
				return _DNGOriginalDefaultFinalSize;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGOriginalRawFileData;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGOriginalRawFileData",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGOriginalRawFileData {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGOriginalRawFileData is null)
					_DNGOriginalRawFileData = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGOriginalRawFileData")!;
				return _DNGOriginalRawFileData;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGOriginalRawFileDigest;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGOriginalRawFileDigest",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGOriginalRawFileDigest {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGOriginalRawFileDigest is null)
					_DNGOriginalRawFileDigest = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGOriginalRawFileDigest")!;
				return _DNGOriginalRawFileDigest;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGOriginalRawFileName;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGOriginalRawFileName",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGOriginalRawFileName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGOriginalRawFileName is null)
					_DNGOriginalRawFileName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGOriginalRawFileName")!;
				return _DNGOriginalRawFileName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGPreviewApplicationName;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGPreviewApplicationName",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGPreviewApplicationName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGPreviewApplicationName is null)
					_DNGPreviewApplicationName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGPreviewApplicationName")!;
				return _DNGPreviewApplicationName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGPreviewApplicationVersion;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGPreviewApplicationVersion",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGPreviewApplicationVersion {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGPreviewApplicationVersion is null)
					_DNGPreviewApplicationVersion = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGPreviewApplicationVersion")!;
				return _DNGPreviewApplicationVersion;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGPreviewColorSpace;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGPreviewColorSpace",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGPreviewColorSpace {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGPreviewColorSpace is null)
					_DNGPreviewColorSpace = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGPreviewColorSpace")!;
				return _DNGPreviewColorSpace;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGPreviewDateTime;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGPreviewDateTime",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGPreviewDateTime {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGPreviewDateTime is null)
					_DNGPreviewDateTime = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGPreviewDateTime")!;
				return _DNGPreviewDateTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGPreviewSettingsDigest;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGPreviewSettingsDigest",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGPreviewSettingsDigest {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGPreviewSettingsDigest is null)
					_DNGPreviewSettingsDigest = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGPreviewSettingsDigest")!;
				return _DNGPreviewSettingsDigest;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGPreviewSettingsName;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGPreviewSettingsName",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGPreviewSettingsName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGPreviewSettingsName is null)
					_DNGPreviewSettingsName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGPreviewSettingsName")!;
				return _DNGPreviewSettingsName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGPrivateData;
		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGPrivateData.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGPrivateData",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGPrivateData {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGPrivateData is null)
					_DNGPrivateData = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGPrivateData")!;
				return _DNGPrivateData;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGProfileCalibrationSignature;
		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGProfileCalibrationSignature.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGProfileCalibrationSignature",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGProfileCalibrationSignature {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGProfileCalibrationSignature is null)
					_DNGProfileCalibrationSignature = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGProfileCalibrationSignature")!;
				return _DNGProfileCalibrationSignature;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGProfileCopyright;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGProfileCopyright",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGProfileCopyright {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGProfileCopyright is null)
					_DNGProfileCopyright = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGProfileCopyright")!;
				return _DNGProfileCopyright;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGProfileEmbedPolicy;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGProfileEmbedPolicy",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGProfileEmbedPolicy {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGProfileEmbedPolicy is null)
					_DNGProfileEmbedPolicy = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGProfileEmbedPolicy")!;
				return _DNGProfileEmbedPolicy;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGProfileHueSatMapData1;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGProfileHueSatMapData1",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGProfileHueSatMapData1 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGProfileHueSatMapData1 is null)
					_DNGProfileHueSatMapData1 = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGProfileHueSatMapData1")!;
				return _DNGProfileHueSatMapData1;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGProfileHueSatMapData2;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGProfileHueSatMapData2",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGProfileHueSatMapData2 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGProfileHueSatMapData2 is null)
					_DNGProfileHueSatMapData2 = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGProfileHueSatMapData2")!;
				return _DNGProfileHueSatMapData2;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGProfileHueSatMapDims;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGProfileHueSatMapDims",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGProfileHueSatMapDims {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGProfileHueSatMapDims is null)
					_DNGProfileHueSatMapDims = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGProfileHueSatMapDims")!;
				return _DNGProfileHueSatMapDims;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGProfileHueSatMapEncoding;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGProfileHueSatMapEncoding",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGProfileHueSatMapEncoding {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGProfileHueSatMapEncoding is null)
					_DNGProfileHueSatMapEncoding = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGProfileHueSatMapEncoding")!;
				return _DNGProfileHueSatMapEncoding;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGProfileLookTableData;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGProfileLookTableData",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGProfileLookTableData {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGProfileLookTableData is null)
					_DNGProfileLookTableData = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGProfileLookTableData")!;
				return _DNGProfileLookTableData;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGProfileLookTableDims;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGProfileLookTableDims",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGProfileLookTableDims {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGProfileLookTableDims is null)
					_DNGProfileLookTableDims = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGProfileLookTableDims")!;
				return _DNGProfileLookTableDims;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGProfileLookTableEncoding;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGProfileLookTableEncoding",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGProfileLookTableEncoding {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGProfileLookTableEncoding is null)
					_DNGProfileLookTableEncoding = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGProfileLookTableEncoding")!;
				return _DNGProfileLookTableEncoding;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGProfileName;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGProfileName",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGProfileName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGProfileName is null)
					_DNGProfileName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGProfileName")!;
				return _DNGProfileName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGProfileToneCurve;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGProfileToneCurve",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGProfileToneCurve {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGProfileToneCurve is null)
					_DNGProfileToneCurve = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGProfileToneCurve")!;
				return _DNGProfileToneCurve;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGRawDataUniqueId;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGRawDataUniqueID",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGRawDataUniqueId {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGRawDataUniqueId is null)
					_DNGRawDataUniqueId = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGRawDataUniqueID")!;
				return _DNGRawDataUniqueId;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGRawImageDigest;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGRawImageDigest",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGRawImageDigest {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGRawImageDigest is null)
					_DNGRawImageDigest = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGRawImageDigest")!;
				return _DNGRawImageDigest;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGRawToPreviewGain;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGRawToPreviewGain",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGRawToPreviewGain {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGRawToPreviewGain is null)
					_DNGRawToPreviewGain = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGRawToPreviewGain")!;
				return _DNGRawToPreviewGain;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGReductionMatrix1;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGReductionMatrix1",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGReductionMatrix1 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGReductionMatrix1 is null)
					_DNGReductionMatrix1 = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGReductionMatrix1")!;
				return _DNGReductionMatrix1;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGReductionMatrix2;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGReductionMatrix2",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGReductionMatrix2 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGReductionMatrix2 is null)
					_DNGReductionMatrix2 = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGReductionMatrix2")!;
				return _DNGReductionMatrix2;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGRowInterleaveFactor;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGRowInterleaveFactor",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGRowInterleaveFactor {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGRowInterleaveFactor is null)
					_DNGRowInterleaveFactor = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGRowInterleaveFactor")!;
				return _DNGRowInterleaveFactor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGShadowScale;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGShadowScale",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGShadowScale {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGShadowScale is null)
					_DNGShadowScale = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGShadowScale")!;
				return _DNGShadowScale;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGSubTileBlockSize;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGSubTileBlockSize",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGSubTileBlockSize {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGSubTileBlockSize is null)
					_DNGSubTileBlockSize = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGSubTileBlockSize")!;
				return _DNGSubTileBlockSize;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGUniqueCameraModel;
		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGUniqueCameraModel</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGUniqueCameraModel",  "ImageIO")]
		public static NSString DNGUniqueCameraModel {
			get {
				if (_DNGUniqueCameraModel is null)
					_DNGUniqueCameraModel = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGUniqueCameraModel")!;
				return _DNGUniqueCameraModel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGVersion;
		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGVersion</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGVersion",  "ImageIO")]
		public static NSString DNGVersion {
			get {
				if (_DNGVersion is null)
					_DNGVersion = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGVersion")!;
				return _DNGVersion;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGWarpFisheye;
		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGWarpFisheye.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGWarpFisheye",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGWarpFisheye {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGWarpFisheye is null)
					_DNGWarpFisheye = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGWarpFisheye")!;
				return _DNGWarpFisheye;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGWarpRectilinear;
		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGWarpRectilinear.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGWarpRectilinear",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGWarpRectilinear {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGWarpRectilinear is null)
					_DNGWarpRectilinear = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGWarpRectilinear")!;
				return _DNGWarpRectilinear;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DNGWhiteLevel;
		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGWhiteLevel.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDNGWhiteLevel",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DNGWhiteLevel {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DNGWhiteLevel is null)
					_DNGWhiteLevel = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDNGWhiteLevel")!;
				return _DNGWhiteLevel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DPIHeight;
		/// <summary>Represents the value associated with the constant kCGImagePropertyDPIHeight</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDPIHeight",  "ImageIO")]
		public static NSString DPIHeight {
			get {
				if (_DPIHeight is null)
					_DPIHeight = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDPIHeight")!;
				return _DPIHeight;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DPIWidth;
		/// <summary>Represents the value associated with the constant kCGImagePropertyDPIWidth</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDPIWidth",  "ImageIO")]
		public static NSString DPIWidth {
			get {
				if (_DPIWidth is null)
					_DPIWidth = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDPIWidth")!;
				return _DPIWidth;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Depth;
		/// <summary>Represents the value associated with the constant kCGImagePropertyDepth</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyDepth",  "ImageIO")]
		public static NSString Depth {
			get {
				if (_Depth is null)
					_Depth = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyDepth")!;
				return _Depth;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EightBIMDictionary;
		/// <summary>Represents the value associated with the constant kCGImageProperty8BIMDictionary</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImageProperty8BIMDictionary",  "ImageIO")]
		public static NSString EightBIMDictionary {
			get {
				if (_EightBIMDictionary is null)
					_EightBIMDictionary = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageProperty8BIMDictionary")!;
				return _EightBIMDictionary;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EightBIMLayerNames;
		/// <summary>Represents the value associated with the constant kCGImageProperty8BIMLayerNames</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImageProperty8BIMLayerNames",  "ImageIO")]
		public static NSString EightBIMLayerNames {
			get {
				if (_EightBIMLayerNames is null)
					_EightBIMLayerNames = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageProperty8BIMLayerNames")!;
				return _EightBIMLayerNames;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifApertureValue;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifApertureValue</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifApertureValue",  "ImageIO")]
		public static NSString ExifApertureValue {
			get {
				if (_ExifApertureValue is null)
					_ExifApertureValue = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifApertureValue")!;
				return _ExifApertureValue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifAuxDictionary;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifAuxDictionary</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifAuxDictionary",  "ImageIO")]
		public static NSString ExifAuxDictionary {
			get {
				if (_ExifAuxDictionary is null)
					_ExifAuxDictionary = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifAuxDictionary")!;
				return _ExifAuxDictionary;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifAuxFirmware;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifAuxFirmware</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifAuxFirmware",  "ImageIO")]
		public static NSString ExifAuxFirmware {
			get {
				if (_ExifAuxFirmware is null)
					_ExifAuxFirmware = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifAuxFirmware")!;
				return _ExifAuxFirmware;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifAuxFlashCompensation;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifAuxFlashCompensation</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifAuxFlashCompensation",  "ImageIO")]
		public static NSString ExifAuxFlashCompensation {
			get {
				if (_ExifAuxFlashCompensation is null)
					_ExifAuxFlashCompensation = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifAuxFlashCompensation")!;
				return _ExifAuxFlashCompensation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifAuxImageNumber;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifAuxImageNumber</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifAuxImageNumber",  "ImageIO")]
		public static NSString ExifAuxImageNumber {
			get {
				if (_ExifAuxImageNumber is null)
					_ExifAuxImageNumber = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifAuxImageNumber")!;
				return _ExifAuxImageNumber;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifAuxLensID;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifAuxLensID</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifAuxLensID",  "ImageIO")]
		public static NSString ExifAuxLensID {
			get {
				if (_ExifAuxLensID is null)
					_ExifAuxLensID = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifAuxLensID")!;
				return _ExifAuxLensID;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifAuxLensInfo;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifAuxLensInfo</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifAuxLensInfo",  "ImageIO")]
		public static NSString ExifAuxLensInfo {
			get {
				if (_ExifAuxLensInfo is null)
					_ExifAuxLensInfo = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifAuxLensInfo")!;
				return _ExifAuxLensInfo;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifAuxLensModel;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifAuxLensModel</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifAuxLensModel",  "ImageIO")]
		public static NSString ExifAuxLensModel {
			get {
				if (_ExifAuxLensModel is null)
					_ExifAuxLensModel = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifAuxLensModel")!;
				return _ExifAuxLensModel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifAuxLensSerialNumber;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifAuxLensSerialNumber</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifAuxLensSerialNumber",  "ImageIO")]
		public static NSString ExifAuxLensSerialNumber {
			get {
				if (_ExifAuxLensSerialNumber is null)
					_ExifAuxLensSerialNumber = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifAuxLensSerialNumber")!;
				return _ExifAuxLensSerialNumber;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifAuxOwnerName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifAuxOwnerName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifAuxOwnerName",  "ImageIO")]
		public static NSString ExifAuxOwnerName {
			get {
				if (_ExifAuxOwnerName is null)
					_ExifAuxOwnerName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifAuxOwnerName")!;
				return _ExifAuxOwnerName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifAuxSerialNumber;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifAuxSerialNumber</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifAuxSerialNumber",  "ImageIO")]
		public static NSString ExifAuxSerialNumber {
			get {
				if (_ExifAuxSerialNumber is null)
					_ExifAuxSerialNumber = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifAuxSerialNumber")!;
				return _ExifAuxSerialNumber;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifBodySerialNumber;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifBodySerialNumber</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifBodySerialNumber",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ExifBodySerialNumber {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ExifBodySerialNumber is null)
					_ExifBodySerialNumber = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifBodySerialNumber")!;
				return _ExifBodySerialNumber;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifBrightnessValue;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifBrightnessValue</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifBrightnessValue",  "ImageIO")]
		public static NSString ExifBrightnessValue {
			get {
				if (_ExifBrightnessValue is null)
					_ExifBrightnessValue = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifBrightnessValue")!;
				return _ExifBrightnessValue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifCFAPattern;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifCFAPattern",  "ImageIO")]
		public static NSString ExifCFAPattern {
			get {
				if (_ExifCFAPattern is null)
					_ExifCFAPattern = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifCFAPattern")!;
				return _ExifCFAPattern;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifCameraOwnerName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifCameraOwnerName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifCameraOwnerName",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ExifCameraOwnerName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ExifCameraOwnerName is null)
					_ExifCameraOwnerName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifCameraOwnerName")!;
				return _ExifCameraOwnerName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifColorSpace;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifColorSpace</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifColorSpace",  "ImageIO")]
		public static NSString ExifColorSpace {
			get {
				if (_ExifColorSpace is null)
					_ExifColorSpace = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifColorSpace")!;
				return _ExifColorSpace;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifComponentsConfiguration;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifComponentsConfiguration</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifComponentsConfiguration",  "ImageIO")]
		public static NSString ExifComponentsConfiguration {
			get {
				if (_ExifComponentsConfiguration is null)
					_ExifComponentsConfiguration = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifComponentsConfiguration")!;
				return _ExifComponentsConfiguration;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifCompositeImage;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyExifCompositeImage'.</summary>
		[Field ("kCGImagePropertyExifCompositeImage",  "ImageIO")]
		[SupportedOSPlatform ("ios13.1")]
		[SupportedOSPlatform ("tvos13.1")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ExifCompositeImage {
			[SupportedOSPlatform ("ios13.1")]
			[SupportedOSPlatform ("tvos13.1")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ExifCompositeImage is null)
					_ExifCompositeImage = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifCompositeImage")!;
				return _ExifCompositeImage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifCompressedBitsPerPixel;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifCompressedBitsPerPixel</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifCompressedBitsPerPixel",  "ImageIO")]
		public static NSString ExifCompressedBitsPerPixel {
			get {
				if (_ExifCompressedBitsPerPixel is null)
					_ExifCompressedBitsPerPixel = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifCompressedBitsPerPixel")!;
				return _ExifCompressedBitsPerPixel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifContrast;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifContrast</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifContrast",  "ImageIO")]
		public static NSString ExifContrast {
			get {
				if (_ExifContrast is null)
					_ExifContrast = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifContrast")!;
				return _ExifContrast;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifCustomRendered;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifCustomRendered</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifCustomRendered",  "ImageIO")]
		public static NSString ExifCustomRendered {
			get {
				if (_ExifCustomRendered is null)
					_ExifCustomRendered = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifCustomRendered")!;
				return _ExifCustomRendered;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifDateTimeDigitized;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifDateTimeDigitized</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifDateTimeDigitized",  "ImageIO")]
		public static NSString ExifDateTimeDigitized {
			get {
				if (_ExifDateTimeDigitized is null)
					_ExifDateTimeDigitized = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifDateTimeDigitized")!;
				return _ExifDateTimeDigitized;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifDateTimeOriginal;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifDateTimeOriginal</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifDateTimeOriginal",  "ImageIO")]
		public static NSString ExifDateTimeOriginal {
			get {
				if (_ExifDateTimeOriginal is null)
					_ExifDateTimeOriginal = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifDateTimeOriginal")!;
				return _ExifDateTimeOriginal;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifDeviceSettingDescription;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifDeviceSettingDescription</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifDeviceSettingDescription",  "ImageIO")]
		public static NSString ExifDeviceSettingDescription {
			get {
				if (_ExifDeviceSettingDescription is null)
					_ExifDeviceSettingDescription = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifDeviceSettingDescription")!;
				return _ExifDeviceSettingDescription;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifDictionary;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifDictionary</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifDictionary",  "ImageIO")]
		public static NSString ExifDictionary {
			get {
				if (_ExifDictionary is null)
					_ExifDictionary = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifDictionary")!;
				return _ExifDictionary;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifDigitalZoomRatio;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifDigitalZoomRatio</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifDigitalZoomRatio",  "ImageIO")]
		public static NSString ExifDigitalZoomRatio {
			get {
				if (_ExifDigitalZoomRatio is null)
					_ExifDigitalZoomRatio = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifDigitalZoomRatio")!;
				return _ExifDigitalZoomRatio;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifExposureBiasValue;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifExposureBiasValue</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifExposureBiasValue",  "ImageIO")]
		public static NSString ExifExposureBiasValue {
			get {
				if (_ExifExposureBiasValue is null)
					_ExifExposureBiasValue = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifExposureBiasValue")!;
				return _ExifExposureBiasValue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifExposureIndex;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifExposureIndex</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifExposureIndex",  "ImageIO")]
		public static NSString ExifExposureIndex {
			get {
				if (_ExifExposureIndex is null)
					_ExifExposureIndex = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifExposureIndex")!;
				return _ExifExposureIndex;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifExposureMode;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifExposureMode</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifExposureMode",  "ImageIO")]
		public static NSString ExifExposureMode {
			get {
				if (_ExifExposureMode is null)
					_ExifExposureMode = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifExposureMode")!;
				return _ExifExposureMode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifExposureProgram;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifExposureProgram</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifExposureProgram",  "ImageIO")]
		public static NSString ExifExposureProgram {
			get {
				if (_ExifExposureProgram is null)
					_ExifExposureProgram = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifExposureProgram")!;
				return _ExifExposureProgram;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifExposureTime;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifExposureTime</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifExposureTime",  "ImageIO")]
		public static NSString ExifExposureTime {
			get {
				if (_ExifExposureTime is null)
					_ExifExposureTime = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifExposureTime")!;
				return _ExifExposureTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifFNumber;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifFNumber</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifFNumber",  "ImageIO")]
		public static NSString ExifFNumber {
			get {
				if (_ExifFNumber is null)
					_ExifFNumber = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifFNumber")!;
				return _ExifFNumber;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifFileSource;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifFileSource</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifFileSource",  "ImageIO")]
		public static NSString ExifFileSource {
			get {
				if (_ExifFileSource is null)
					_ExifFileSource = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifFileSource")!;
				return _ExifFileSource;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifFlash;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifFlash</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifFlash",  "ImageIO")]
		public static NSString ExifFlash {
			get {
				if (_ExifFlash is null)
					_ExifFlash = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifFlash")!;
				return _ExifFlash;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifFlashEnergy;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifFlashEnergy</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifFlashEnergy",  "ImageIO")]
		public static NSString ExifFlashEnergy {
			get {
				if (_ExifFlashEnergy is null)
					_ExifFlashEnergy = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifFlashEnergy")!;
				return _ExifFlashEnergy;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifFlashPixVersion;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifFlashPixVersion</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifFlashPixVersion",  "ImageIO")]
		public static NSString ExifFlashPixVersion {
			get {
				if (_ExifFlashPixVersion is null)
					_ExifFlashPixVersion = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifFlashPixVersion")!;
				return _ExifFlashPixVersion;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifFocalLenIn35mmFilm;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifFocalLenIn35mmFilm</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifFocalLenIn35mmFilm",  "ImageIO")]
		public static NSString ExifFocalLenIn35mmFilm {
			get {
				if (_ExifFocalLenIn35mmFilm is null)
					_ExifFocalLenIn35mmFilm = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifFocalLenIn35mmFilm")!;
				return _ExifFocalLenIn35mmFilm;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifFocalLength;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifFocalLength</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifFocalLength",  "ImageIO")]
		public static NSString ExifFocalLength {
			get {
				if (_ExifFocalLength is null)
					_ExifFocalLength = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifFocalLength")!;
				return _ExifFocalLength;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifFocalPlaneResolutionUnit;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifFocalPlaneResolutionUnit</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifFocalPlaneResolutionUnit",  "ImageIO")]
		public static NSString ExifFocalPlaneResolutionUnit {
			get {
				if (_ExifFocalPlaneResolutionUnit is null)
					_ExifFocalPlaneResolutionUnit = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifFocalPlaneResolutionUnit")!;
				return _ExifFocalPlaneResolutionUnit;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifFocalPlaneXResolution;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifFocalPlaneXResolution</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifFocalPlaneXResolution",  "ImageIO")]
		public static NSString ExifFocalPlaneXResolution {
			get {
				if (_ExifFocalPlaneXResolution is null)
					_ExifFocalPlaneXResolution = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifFocalPlaneXResolution")!;
				return _ExifFocalPlaneXResolution;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifFocalPlaneYResolution;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifFocalPlaneYResolution</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifFocalPlaneYResolution",  "ImageIO")]
		public static NSString ExifFocalPlaneYResolution {
			get {
				if (_ExifFocalPlaneYResolution is null)
					_ExifFocalPlaneYResolution = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifFocalPlaneYResolution")!;
				return _ExifFocalPlaneYResolution;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifGainControl;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifGainControl</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifGainControl",  "ImageIO")]
		public static NSString ExifGainControl {
			get {
				if (_ExifGainControl is null)
					_ExifGainControl = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifGainControl")!;
				return _ExifGainControl;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifGamma;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifGamma</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifGamma",  "ImageIO")]
		public static NSString ExifGamma {
			get {
				if (_ExifGamma is null)
					_ExifGamma = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifGamma")!;
				return _ExifGamma;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifISOSpeed;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifISOSpeed</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifISOSpeed",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ExifISOSpeed {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ExifISOSpeed is null)
					_ExifISOSpeed = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifISOSpeed")!;
				return _ExifISOSpeed;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifISOSpeedLatitudeYyy;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifISOSpeedLatitudeyyy</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifISOSpeedLatitudeyyy",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ExifISOSpeedLatitudeYyy {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ExifISOSpeedLatitudeYyy is null)
					_ExifISOSpeedLatitudeYyy = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifISOSpeedLatitudeyyy")!;
				return _ExifISOSpeedLatitudeYyy;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifISOSpeedLatitudeZzz;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifISOSpeedLatitudezzz</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifISOSpeedLatitudezzz",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ExifISOSpeedLatitudeZzz {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ExifISOSpeedLatitudeZzz is null)
					_ExifISOSpeedLatitudeZzz = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifISOSpeedLatitudezzz")!;
				return _ExifISOSpeedLatitudeZzz;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifISOSpeedRatings;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifISOSpeedRatings</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifISOSpeedRatings",  "ImageIO")]
		public static NSString ExifISOSpeedRatings {
			get {
				if (_ExifISOSpeedRatings is null)
					_ExifISOSpeedRatings = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifISOSpeedRatings")!;
				return _ExifISOSpeedRatings;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifImageUniqueID;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifImageUniqueID</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifImageUniqueID",  "ImageIO")]
		public static NSString ExifImageUniqueID {
			get {
				if (_ExifImageUniqueID is null)
					_ExifImageUniqueID = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifImageUniqueID")!;
				return _ExifImageUniqueID;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifLensMake;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifLensMake</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifLensMake",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ExifLensMake {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ExifLensMake is null)
					_ExifLensMake = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifLensMake")!;
				return _ExifLensMake;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifLensModel;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifLensModel</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifLensModel",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ExifLensModel {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ExifLensModel is null)
					_ExifLensModel = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifLensModel")!;
				return _ExifLensModel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifLensSerialNumber;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifLensSerialNumber</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifLensSerialNumber",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ExifLensSerialNumber {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ExifLensSerialNumber is null)
					_ExifLensSerialNumber = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifLensSerialNumber")!;
				return _ExifLensSerialNumber;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifLensSpecification;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifLensSpecification</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifLensSpecification",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ExifLensSpecification {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ExifLensSpecification is null)
					_ExifLensSpecification = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifLensSpecification")!;
				return _ExifLensSpecification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifLightSource;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifLightSource</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifLightSource",  "ImageIO")]
		public static NSString ExifLightSource {
			get {
				if (_ExifLightSource is null)
					_ExifLightSource = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifLightSource")!;
				return _ExifLightSource;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifMakerNote;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifMakerNote</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifMakerNote",  "ImageIO")]
		public static NSString ExifMakerNote {
			get {
				if (_ExifMakerNote is null)
					_ExifMakerNote = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifMakerNote")!;
				return _ExifMakerNote;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifMaxApertureValue;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifMaxApertureValue</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifMaxApertureValue",  "ImageIO")]
		public static NSString ExifMaxApertureValue {
			get {
				if (_ExifMaxApertureValue is null)
					_ExifMaxApertureValue = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifMaxApertureValue")!;
				return _ExifMaxApertureValue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifMeteringMode;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifMeteringMode</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifMeteringMode",  "ImageIO")]
		public static NSString ExifMeteringMode {
			get {
				if (_ExifMeteringMode is null)
					_ExifMeteringMode = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifMeteringMode")!;
				return _ExifMeteringMode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifOECF;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifOECF</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifOECF",  "ImageIO")]
		public static NSString ExifOECF {
			get {
				if (_ExifOECF is null)
					_ExifOECF = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifOECF")!;
				return _ExifOECF;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifOffsetTime;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyExifOffsetTime'.</summary>
		[Field ("kCGImagePropertyExifOffsetTime",  "ImageIO")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ExifOffsetTime {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ExifOffsetTime is null)
					_ExifOffsetTime = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifOffsetTime")!;
				return _ExifOffsetTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifOffsetTimeDigitized;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyExifOffsetTimeDigitized'.</summary>
		[Field ("kCGImagePropertyExifOffsetTimeDigitized",  "ImageIO")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ExifOffsetTimeDigitized {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ExifOffsetTimeDigitized is null)
					_ExifOffsetTimeDigitized = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifOffsetTimeDigitized")!;
				return _ExifOffsetTimeDigitized;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifOffsetTimeOriginal;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyExifOffsetTimeOriginal'.</summary>
		[Field ("kCGImagePropertyExifOffsetTimeOriginal",  "ImageIO")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ExifOffsetTimeOriginal {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ExifOffsetTimeOriginal is null)
					_ExifOffsetTimeOriginal = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifOffsetTimeOriginal")!;
				return _ExifOffsetTimeOriginal;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifPixelXDimension;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifPixelXDimension</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifPixelXDimension",  "ImageIO")]
		public static NSString ExifPixelXDimension {
			get {
				if (_ExifPixelXDimension is null)
					_ExifPixelXDimension = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifPixelXDimension")!;
				return _ExifPixelXDimension;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifPixelYDimension;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifPixelYDimension</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifPixelYDimension",  "ImageIO")]
		public static NSString ExifPixelYDimension {
			get {
				if (_ExifPixelYDimension is null)
					_ExifPixelYDimension = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifPixelYDimension")!;
				return _ExifPixelYDimension;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifRecommendedExposureIndex;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifRecommendedExposureIndex</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifRecommendedExposureIndex",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ExifRecommendedExposureIndex {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ExifRecommendedExposureIndex is null)
					_ExifRecommendedExposureIndex = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifRecommendedExposureIndex")!;
				return _ExifRecommendedExposureIndex;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifRelatedSoundFile;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifRelatedSoundFile</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifRelatedSoundFile",  "ImageIO")]
		public static NSString ExifRelatedSoundFile {
			get {
				if (_ExifRelatedSoundFile is null)
					_ExifRelatedSoundFile = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifRelatedSoundFile")!;
				return _ExifRelatedSoundFile;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifSaturation;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifSaturation</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifSaturation",  "ImageIO")]
		public static NSString ExifSaturation {
			get {
				if (_ExifSaturation is null)
					_ExifSaturation = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifSaturation")!;
				return _ExifSaturation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifSceneCaptureType;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifSceneCaptureType</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifSceneCaptureType",  "ImageIO")]
		public static NSString ExifSceneCaptureType {
			get {
				if (_ExifSceneCaptureType is null)
					_ExifSceneCaptureType = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifSceneCaptureType")!;
				return _ExifSceneCaptureType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifSceneType;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifSceneType</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifSceneType",  "ImageIO")]
		public static NSString ExifSceneType {
			get {
				if (_ExifSceneType is null)
					_ExifSceneType = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifSceneType")!;
				return _ExifSceneType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifSensingMethod;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifSensingMethod</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifSensingMethod",  "ImageIO")]
		public static NSString ExifSensingMethod {
			get {
				if (_ExifSensingMethod is null)
					_ExifSensingMethod = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifSensingMethod")!;
				return _ExifSensingMethod;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifSensitivityType;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifSensitivityType</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifSensitivityType",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ExifSensitivityType {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ExifSensitivityType is null)
					_ExifSensitivityType = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifSensitivityType")!;
				return _ExifSensitivityType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifSharpness;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifSharpness</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifSharpness",  "ImageIO")]
		public static NSString ExifSharpness {
			get {
				if (_ExifSharpness is null)
					_ExifSharpness = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifSharpness")!;
				return _ExifSharpness;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifShutterSpeedValue;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifShutterSpeedValue</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifShutterSpeedValue",  "ImageIO")]
		public static NSString ExifShutterSpeedValue {
			get {
				if (_ExifShutterSpeedValue is null)
					_ExifShutterSpeedValue = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifShutterSpeedValue")!;
				return _ExifShutterSpeedValue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifSourceExposureTimesOfCompositeImage;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyExifSourceExposureTimesOfCompositeImage'.</summary>
		[Field ("kCGImagePropertyExifSourceExposureTimesOfCompositeImage",  "ImageIO")]
		[SupportedOSPlatform ("ios13.1")]
		[SupportedOSPlatform ("tvos13.1")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ExifSourceExposureTimesOfCompositeImage {
			[SupportedOSPlatform ("ios13.1")]
			[SupportedOSPlatform ("tvos13.1")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ExifSourceExposureTimesOfCompositeImage is null)
					_ExifSourceExposureTimesOfCompositeImage = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifSourceExposureTimesOfCompositeImage")!;
				return _ExifSourceExposureTimesOfCompositeImage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifSourceImageNumberOfCompositeImage;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyExifSourceImageNumberOfCompositeImage'.</summary>
		[Field ("kCGImagePropertyExifSourceImageNumberOfCompositeImage",  "ImageIO")]
		[SupportedOSPlatform ("ios13.1")]
		[SupportedOSPlatform ("tvos13.1")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ExifSourceImageNumberOfCompositeImage {
			[SupportedOSPlatform ("ios13.1")]
			[SupportedOSPlatform ("tvos13.1")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ExifSourceImageNumberOfCompositeImage is null)
					_ExifSourceImageNumberOfCompositeImage = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifSourceImageNumberOfCompositeImage")!;
				return _ExifSourceImageNumberOfCompositeImage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifSpatialFrequencyResponse;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifSpatialFrequencyResponse</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifSpatialFrequencyResponse",  "ImageIO")]
		public static NSString ExifSpatialFrequencyResponse {
			get {
				if (_ExifSpatialFrequencyResponse is null)
					_ExifSpatialFrequencyResponse = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifSpatialFrequencyResponse")!;
				return _ExifSpatialFrequencyResponse;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifSpectralSensitivity;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifSpectralSensitivity</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifSpectralSensitivity",  "ImageIO")]
		public static NSString ExifSpectralSensitivity {
			get {
				if (_ExifSpectralSensitivity is null)
					_ExifSpectralSensitivity = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifSpectralSensitivity")!;
				return _ExifSpectralSensitivity;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifStandardOutputSensitivity;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifStandardOutputSensitivity</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifStandardOutputSensitivity",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ExifStandardOutputSensitivity {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ExifStandardOutputSensitivity is null)
					_ExifStandardOutputSensitivity = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifStandardOutputSensitivity")!;
				return _ExifStandardOutputSensitivity;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifSubjectArea;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifSubjectArea</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifSubjectArea",  "ImageIO")]
		public static NSString ExifSubjectArea {
			get {
				if (_ExifSubjectArea is null)
					_ExifSubjectArea = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifSubjectArea")!;
				return _ExifSubjectArea;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifSubjectDistRange;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifSubjectDistRange</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifSubjectDistRange",  "ImageIO")]
		public static NSString ExifSubjectDistRange {
			get {
				if (_ExifSubjectDistRange is null)
					_ExifSubjectDistRange = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifSubjectDistRange")!;
				return _ExifSubjectDistRange;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifSubjectDistance;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifSubjectDistance</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifSubjectDistance",  "ImageIO")]
		public static NSString ExifSubjectDistance {
			get {
				if (_ExifSubjectDistance is null)
					_ExifSubjectDistance = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifSubjectDistance")!;
				return _ExifSubjectDistance;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifSubjectLocation;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifSubjectLocation</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifSubjectLocation",  "ImageIO")]
		public static NSString ExifSubjectLocation {
			get {
				if (_ExifSubjectLocation is null)
					_ExifSubjectLocation = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifSubjectLocation")!;
				return _ExifSubjectLocation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifSubsecTime;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifSubsecTime</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifSubsecTime",  "ImageIO")]
		public static NSString ExifSubsecTime {
			get {
				if (_ExifSubsecTime is null)
					_ExifSubsecTime = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifSubsecTime")!;
				return _ExifSubsecTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifSubsecTimeDigitized;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifSubsecTimeDigitized</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifSubsecTimeDigitized",  "ImageIO")]
		public static NSString ExifSubsecTimeDigitized {
			get {
				if (_ExifSubsecTimeDigitized is null)
					_ExifSubsecTimeDigitized = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifSubsecTimeDigitized")!;
				return _ExifSubsecTimeDigitized;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifSubsecTimeOrginal;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifSubsecTimeOrginal</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifSubsecTimeOrginal",  "ImageIO")]
		public static NSString ExifSubsecTimeOrginal {
			get {
				if (_ExifSubsecTimeOrginal is null)
					_ExifSubsecTimeOrginal = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifSubsecTimeOrginal")!;
				return _ExifSubsecTimeOrginal;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifSubsecTimeOriginal;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifSubsecTimeOriginal.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifSubsecTimeOriginal",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ExifSubsecTimeOriginal {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ExifSubsecTimeOriginal is null)
					_ExifSubsecTimeOriginal = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifSubsecTimeOriginal")!;
				return _ExifSubsecTimeOriginal;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifUserComment;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifUserComment</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifUserComment",  "ImageIO")]
		public static NSString ExifUserComment {
			get {
				if (_ExifUserComment is null)
					_ExifUserComment = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifUserComment")!;
				return _ExifUserComment;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifVersion;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifVersion</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifVersion",  "ImageIO")]
		public static NSString ExifVersion {
			get {
				if (_ExifVersion is null)
					_ExifVersion = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifVersion")!;
				return _ExifVersion;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExifWhiteBalance;
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifWhiteBalance</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyExifWhiteBalance",  "ImageIO")]
		public static NSString ExifWhiteBalance {
			get {
				if (_ExifWhiteBalance is null)
					_ExifWhiteBalance = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyExifWhiteBalance")!;
				return _ExifWhiteBalance;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileContentsDictionary;
		/// <summary>Represents the value associated with the constant kCGImagePropertyFileContentsDictionary</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyFileContentsDictionary",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString FileContentsDictionary {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_FileContentsDictionary is null)
					_FileContentsDictionary = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyFileContentsDictionary")!;
				return _FileContentsDictionary;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileSize;
		/// <summary>Represents the value associated with the constant kCGImagePropertyFileSize</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyFileSize",  "ImageIO")]
		public static NSString FileSize {
			get {
				if (_FileSize is null)
					_FileSize = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyFileSize")!;
				return _FileSize;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GIFDelayTime;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGIFDelayTime</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGIFDelayTime",  "ImageIO")]
		public static NSString GIFDelayTime {
			get {
				if (_GIFDelayTime is null)
					_GIFDelayTime = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGIFDelayTime")!;
				return _GIFDelayTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GIFDictionary;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGIFDictionary</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGIFDictionary",  "ImageIO")]
		public static NSString GIFDictionary {
			get {
				if (_GIFDictionary is null)
					_GIFDictionary = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGIFDictionary")!;
				return _GIFDictionary;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GIFHasGlobalColorMap;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGIFHasGlobalColorMap</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGIFHasGlobalColorMap",  "ImageIO")]
		public static NSString GIFHasGlobalColorMap {
			get {
				if (_GIFHasGlobalColorMap is null)
					_GIFHasGlobalColorMap = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGIFHasGlobalColorMap")!;
				return _GIFHasGlobalColorMap;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GIFImageColorMap;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGIFImageColorMap</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGIFImageColorMap",  "ImageIO")]
		public static NSString GIFImageColorMap {
			get {
				if (_GIFImageColorMap is null)
					_GIFImageColorMap = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGIFImageColorMap")!;
				return _GIFImageColorMap;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GIFLoopCount;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGIFLoopCount</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGIFLoopCount",  "ImageIO")]
		public static NSString GIFLoopCount {
			get {
				if (_GIFLoopCount is null)
					_GIFLoopCount = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGIFLoopCount")!;
				return _GIFLoopCount;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GIFUnclampedDelayTime;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGIFUnclampedDelayTime</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGIFUnclampedDelayTime",  "ImageIO")]
		public static NSString GIFUnclampedDelayTime {
			get {
				if (_GIFUnclampedDelayTime is null)
					_GIFUnclampedDelayTime = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGIFUnclampedDelayTime")!;
				return _GIFUnclampedDelayTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GPSAltitude;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSAltitude</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGPSAltitude",  "ImageIO")]
		public static NSString GPSAltitude {
			get {
				if (_GPSAltitude is null)
					_GPSAltitude = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGPSAltitude")!;
				return _GPSAltitude;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GPSAltitudeRef;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSAltitudeRef</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGPSAltitudeRef",  "ImageIO")]
		public static NSString GPSAltitudeRef {
			get {
				if (_GPSAltitudeRef is null)
					_GPSAltitudeRef = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGPSAltitudeRef")!;
				return _GPSAltitudeRef;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GPSAreaInformation;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSAreaInformation</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGPSAreaInformation",  "ImageIO")]
		public static NSString GPSAreaInformation {
			get {
				if (_GPSAreaInformation is null)
					_GPSAreaInformation = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGPSAreaInformation")!;
				return _GPSAreaInformation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GPSDOP;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSDOP</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGPSDOP",  "ImageIO")]
		public static NSString GPSDOP {
			get {
				if (_GPSDOP is null)
					_GPSDOP = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGPSDOP")!;
				return _GPSDOP;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GPSDateStamp;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSDateStamp</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGPSDateStamp",  "ImageIO")]
		public static NSString GPSDateStamp {
			get {
				if (_GPSDateStamp is null)
					_GPSDateStamp = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGPSDateStamp")!;
				return _GPSDateStamp;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GPSDestBearing;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSDestBearing</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGPSDestBearing",  "ImageIO")]
		public static NSString GPSDestBearing {
			get {
				if (_GPSDestBearing is null)
					_GPSDestBearing = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGPSDestBearing")!;
				return _GPSDestBearing;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GPSDestBearingRef;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSDestBearingRef</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGPSDestBearingRef",  "ImageIO")]
		public static NSString GPSDestBearingRef {
			get {
				if (_GPSDestBearingRef is null)
					_GPSDestBearingRef = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGPSDestBearingRef")!;
				return _GPSDestBearingRef;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GPSDestDistance;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSDestDistance</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGPSDestDistance",  "ImageIO")]
		public static NSString GPSDestDistance {
			get {
				if (_GPSDestDistance is null)
					_GPSDestDistance = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGPSDestDistance")!;
				return _GPSDestDistance;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GPSDestDistanceRef;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSDestDistanceRef</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGPSDestDistanceRef",  "ImageIO")]
		public static NSString GPSDestDistanceRef {
			get {
				if (_GPSDestDistanceRef is null)
					_GPSDestDistanceRef = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGPSDestDistanceRef")!;
				return _GPSDestDistanceRef;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GPSDestLatitude;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSDestLatitude</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGPSDestLatitude",  "ImageIO")]
		public static NSString GPSDestLatitude {
			get {
				if (_GPSDestLatitude is null)
					_GPSDestLatitude = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGPSDestLatitude")!;
				return _GPSDestLatitude;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GPSDestLatitudeRef;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSDestLatitudeRef</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGPSDestLatitudeRef",  "ImageIO")]
		public static NSString GPSDestLatitudeRef {
			get {
				if (_GPSDestLatitudeRef is null)
					_GPSDestLatitudeRef = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGPSDestLatitudeRef")!;
				return _GPSDestLatitudeRef;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GPSDestLongitude;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSDestLongitude</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGPSDestLongitude",  "ImageIO")]
		public static NSString GPSDestLongitude {
			get {
				if (_GPSDestLongitude is null)
					_GPSDestLongitude = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGPSDestLongitude")!;
				return _GPSDestLongitude;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GPSDestLongitudeRef;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSDestLongitudeRef</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGPSDestLongitudeRef",  "ImageIO")]
		public static NSString GPSDestLongitudeRef {
			get {
				if (_GPSDestLongitudeRef is null)
					_GPSDestLongitudeRef = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGPSDestLongitudeRef")!;
				return _GPSDestLongitudeRef;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GPSDictionary;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSDictionary</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGPSDictionary",  "ImageIO")]
		public static NSString GPSDictionary {
			get {
				if (_GPSDictionary is null)
					_GPSDictionary = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGPSDictionary")!;
				return _GPSDictionary;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GPSDifferental;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSDifferental</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGPSDifferental",  "ImageIO")]
		public static NSString GPSDifferental {
			get {
				if (_GPSDifferental is null)
					_GPSDifferental = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGPSDifferental")!;
				return _GPSDifferental;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GPSHPositioningError;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSHPositioningError</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGPSHPositioningError",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString GPSHPositioningError {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_GPSHPositioningError is null)
					_GPSHPositioningError = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGPSHPositioningError")!;
				return _GPSHPositioningError;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GPSImgDirection;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSImgDirection</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGPSImgDirection",  "ImageIO")]
		public static NSString GPSImgDirection {
			get {
				if (_GPSImgDirection is null)
					_GPSImgDirection = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGPSImgDirection")!;
				return _GPSImgDirection;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GPSImgDirectionRef;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSImgDirectionRef</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGPSImgDirectionRef",  "ImageIO")]
		public static NSString GPSImgDirectionRef {
			get {
				if (_GPSImgDirectionRef is null)
					_GPSImgDirectionRef = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGPSImgDirectionRef")!;
				return _GPSImgDirectionRef;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GPSLatitude;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSLatitude</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGPSLatitude",  "ImageIO")]
		public static NSString GPSLatitude {
			get {
				if (_GPSLatitude is null)
					_GPSLatitude = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGPSLatitude")!;
				return _GPSLatitude;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GPSLatitudeRef;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSLatitudeRef</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGPSLatitudeRef",  "ImageIO")]
		public static NSString GPSLatitudeRef {
			get {
				if (_GPSLatitudeRef is null)
					_GPSLatitudeRef = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGPSLatitudeRef")!;
				return _GPSLatitudeRef;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GPSLongitude;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSLongitude</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGPSLongitude",  "ImageIO")]
		public static NSString GPSLongitude {
			get {
				if (_GPSLongitude is null)
					_GPSLongitude = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGPSLongitude")!;
				return _GPSLongitude;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GPSLongitudeRef;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSLongitudeRef</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGPSLongitudeRef",  "ImageIO")]
		public static NSString GPSLongitudeRef {
			get {
				if (_GPSLongitudeRef is null)
					_GPSLongitudeRef = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGPSLongitudeRef")!;
				return _GPSLongitudeRef;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GPSMapDatum;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSMapDatum</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGPSMapDatum",  "ImageIO")]
		public static NSString GPSMapDatum {
			get {
				if (_GPSMapDatum is null)
					_GPSMapDatum = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGPSMapDatum")!;
				return _GPSMapDatum;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GPSMeasureMode;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSMeasureMode</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGPSMeasureMode",  "ImageIO")]
		public static NSString GPSMeasureMode {
			get {
				if (_GPSMeasureMode is null)
					_GPSMeasureMode = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGPSMeasureMode")!;
				return _GPSMeasureMode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GPSSatellites;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSSatellites</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGPSSatellites",  "ImageIO")]
		public static NSString GPSSatellites {
			get {
				if (_GPSSatellites is null)
					_GPSSatellites = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGPSSatellites")!;
				return _GPSSatellites;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GPSSpeed;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSSpeed</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGPSSpeed",  "ImageIO")]
		public static NSString GPSSpeed {
			get {
				if (_GPSSpeed is null)
					_GPSSpeed = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGPSSpeed")!;
				return _GPSSpeed;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GPSSpeedRef;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSSpeedRef</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGPSSpeedRef",  "ImageIO")]
		public static NSString GPSSpeedRef {
			get {
				if (_GPSSpeedRef is null)
					_GPSSpeedRef = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGPSSpeedRef")!;
				return _GPSSpeedRef;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GPSStatus;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSStatus</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGPSStatus",  "ImageIO")]
		public static NSString GPSStatus {
			get {
				if (_GPSStatus is null)
					_GPSStatus = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGPSStatus")!;
				return _GPSStatus;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GPSTimeStamp;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSTimeStamp</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGPSTimeStamp",  "ImageIO")]
		public static NSString GPSTimeStamp {
			get {
				if (_GPSTimeStamp is null)
					_GPSTimeStamp = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGPSTimeStamp")!;
				return _GPSTimeStamp;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GPSTrack;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSTrack</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGPSTrack",  "ImageIO")]
		public static NSString GPSTrack {
			get {
				if (_GPSTrack is null)
					_GPSTrack = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGPSTrack")!;
				return _GPSTrack;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GPSTrackRef;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSTrackRef</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGPSTrackRef",  "ImageIO")]
		public static NSString GPSTrackRef {
			get {
				if (_GPSTrackRef is null)
					_GPSTrackRef = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGPSTrackRef")!;
				return _GPSTrackRef;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GPSVersion;
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSVersion</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyGPSVersion",  "ImageIO")]
		public static NSString GPSVersion {
			get {
				if (_GPSVersion is null)
					_GPSVersion = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGPSVersion")!;
				return _GPSVersion;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GifCanvasPixelHeight;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyGIFCanvasPixelHeight'.</summary>
		[Field ("kCGImagePropertyGIFCanvasPixelHeight",  "ImageIO")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GifCanvasPixelHeight {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GifCanvasPixelHeight is null)
					_GifCanvasPixelHeight = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGIFCanvasPixelHeight")!;
				return _GifCanvasPixelHeight;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GifCanvasPixelWidth;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyGIFCanvasPixelWidth'.</summary>
		[Field ("kCGImagePropertyGIFCanvasPixelWidth",  "ImageIO")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GifCanvasPixelWidth {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GifCanvasPixelWidth is null)
					_GifCanvasPixelWidth = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGIFCanvasPixelWidth")!;
				return _GifCanvasPixelWidth;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GifFrameInfoArray;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyGIFFrameInfoArray'.</summary>
		[Field ("kCGImagePropertyGIFFrameInfoArray",  "ImageIO")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GifFrameInfoArray {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GifFrameInfoArray is null)
					_GifFrameInfoArray = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGIFFrameInfoArray")!;
				return _GifFrameInfoArray;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GroupImageBaseline;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyGroupImageBaseline'.</summary>
		[Field ("kCGImagePropertyGroupImageBaseline",  "ImageIO")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public static NSString GroupImageBaseline {
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				if (_GroupImageBaseline is null)
					_GroupImageBaseline = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGroupImageBaseline")!;
				return _GroupImageBaseline;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GroupImageDisparityAdjustment;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyGroupImageDisparityAdjustment'.</summary>
		[Field ("kCGImagePropertyGroupImageDisparityAdjustment",  "ImageIO")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public static NSString GroupImageDisparityAdjustment {
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				if (_GroupImageDisparityAdjustment is null)
					_GroupImageDisparityAdjustment = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGroupImageDisparityAdjustment")!;
				return _GroupImageDisparityAdjustment;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GroupImageIndexLeft;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyGroupImageIndexLeft'.</summary>
		[Field ("kCGImagePropertyGroupImageIndexLeft",  "ImageIO")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GroupImageIndexLeft {
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GroupImageIndexLeft is null)
					_GroupImageIndexLeft = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGroupImageIndexLeft")!;
				return _GroupImageIndexLeft;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GroupImageIndexMonoscopic;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyGroupImageIndexMonoscopic'.</summary>
		[Field ("kCGImagePropertyGroupImageIndexMonoscopic",  "ImageIO")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static NSString GroupImageIndexMonoscopic {
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				if (_GroupImageIndexMonoscopic is null)
					_GroupImageIndexMonoscopic = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGroupImageIndexMonoscopic")!;
				return _GroupImageIndexMonoscopic;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GroupImageIndexRight;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyGroupImageIndexRight'.</summary>
		[Field ("kCGImagePropertyGroupImageIndexRight",  "ImageIO")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GroupImageIndexRight {
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GroupImageIndexRight is null)
					_GroupImageIndexRight = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGroupImageIndexRight")!;
				return _GroupImageIndexRight;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GroupImageIsAlternateImage;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyGroupImageIsAlternateImage'.</summary>
		[Field ("kCGImagePropertyGroupImageIsAlternateImage",  "ImageIO")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GroupImageIsAlternateImage {
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GroupImageIsAlternateImage is null)
					_GroupImageIsAlternateImage = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGroupImageIsAlternateImage")!;
				return _GroupImageIsAlternateImage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GroupImageIsLeftImage;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyGroupImageIsLeftImage'.</summary>
		[Field ("kCGImagePropertyGroupImageIsLeftImage",  "ImageIO")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GroupImageIsLeftImage {
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GroupImageIsLeftImage is null)
					_GroupImageIsLeftImage = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGroupImageIsLeftImage")!;
				return _GroupImageIsLeftImage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GroupImageIsMonoscopicImage;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyGroupImageIsMonoscopicImage'.</summary>
		[Field ("kCGImagePropertyGroupImageIsMonoscopicImage",  "ImageIO")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static NSString GroupImageIsMonoscopicImage {
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				if (_GroupImageIsMonoscopicImage is null)
					_GroupImageIsMonoscopicImage = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGroupImageIsMonoscopicImage")!;
				return _GroupImageIsMonoscopicImage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GroupImageIsRightImage;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyGroupImageIsRightImage'.</summary>
		[Field ("kCGImagePropertyGroupImageIsRightImage",  "ImageIO")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GroupImageIsRightImage {
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GroupImageIsRightImage is null)
					_GroupImageIsRightImage = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGroupImageIsRightImage")!;
				return _GroupImageIsRightImage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GroupImageStereoAggressors;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyGroupImageStereoAggressors'.</summary>
		[Field ("kCGImagePropertyGroupImageStereoAggressors",  "ImageIO")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static NSString GroupImageStereoAggressors {
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				if (_GroupImageStereoAggressors is null)
					_GroupImageStereoAggressors = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGroupImageStereoAggressors")!;
				return _GroupImageStereoAggressors;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GroupImagesAlternate;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyGroupImagesAlternate'.</summary>
		[Field ("kCGImagePropertyGroupImagesAlternate",  "ImageIO")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GroupImagesAlternate {
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GroupImagesAlternate is null)
					_GroupImagesAlternate = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGroupImagesAlternate")!;
				return _GroupImagesAlternate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GroupIndex;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyGroupIndex'.</summary>
		[Field ("kCGImagePropertyGroupIndex",  "ImageIO")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GroupIndex {
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GroupIndex is null)
					_GroupIndex = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGroupIndex")!;
				return _GroupIndex;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GroupMonoscopicImageLocation;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyGroupMonoscopicImageLocation'.</summary>
		[Field ("kCGImagePropertyGroupMonoscopicImageLocation",  "ImageIO")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static NSString GroupMonoscopicImageLocation {
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				if (_GroupMonoscopicImageLocation is null)
					_GroupMonoscopicImageLocation = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGroupMonoscopicImageLocation")!;
				return _GroupMonoscopicImageLocation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GroupType;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyGroupType'.</summary>
		[Field ("kCGImagePropertyGroupType",  "ImageIO")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GroupType {
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GroupType is null)
					_GroupType = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGroupType")!;
				return _GroupType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GroupTypeAlternate;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyGroupTypeAlternate'.</summary>
		[Field ("kCGImagePropertyGroupTypeAlternate",  "ImageIO")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GroupTypeAlternate {
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GroupTypeAlternate is null)
					_GroupTypeAlternate = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGroupTypeAlternate")!;
				return _GroupTypeAlternate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GroupTypeStereoPair;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyGroupTypeStereoPair'.</summary>
		[Field ("kCGImagePropertyGroupTypeStereoPair",  "ImageIO")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GroupTypeStereoPair {
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GroupTypeStereoPair is null)
					_GroupTypeStereoPair = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGroupTypeStereoPair")!;
				return _GroupTypeStereoPair;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Groups;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyGroups'.</summary>
		[Field ("kCGImagePropertyGroups",  "ImageIO")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Groups {
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Groups is null)
					_Groups = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyGroups")!;
				return _Groups;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HasAlpha;
		/// <summary>Represents the value associated with the constant kCGImagePropertyHasAlpha</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyHasAlpha",  "ImageIO")]
		public static NSString HasAlpha {
			get {
				if (_HasAlpha is null)
					_HasAlpha = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyHasAlpha")!;
				return _HasAlpha;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeicsCanvasPixelHeight;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyHEICSCanvasPixelHeight'.</summary>
		[Field ("kCGImagePropertyHEICSCanvasPixelHeight",  "ImageIO")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString HeicsCanvasPixelHeight {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_HeicsCanvasPixelHeight is null)
					_HeicsCanvasPixelHeight = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyHEICSCanvasPixelHeight")!;
				return _HeicsCanvasPixelHeight;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeicsCanvasPixelWidth;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyHEICSCanvasPixelWidth'.</summary>
		[Field ("kCGImagePropertyHEICSCanvasPixelWidth",  "ImageIO")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString HeicsCanvasPixelWidth {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_HeicsCanvasPixelWidth is null)
					_HeicsCanvasPixelWidth = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyHEICSCanvasPixelWidth")!;
				return _HeicsCanvasPixelWidth;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeicsDelayTime;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyHEICSDelayTime'.</summary>
		[Field ("kCGImagePropertyHEICSDelayTime",  "ImageIO")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString HeicsDelayTime {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_HeicsDelayTime is null)
					_HeicsDelayTime = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyHEICSDelayTime")!;
				return _HeicsDelayTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeicsDictionary;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyHEICSDictionary'.</summary>
		[Field ("kCGImagePropertyHEICSDictionary",  "ImageIO")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString HeicsDictionary {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_HeicsDictionary is null)
					_HeicsDictionary = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyHEICSDictionary")!;
				return _HeicsDictionary;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeicsFrameInfoArray;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyHEICSFrameInfoArray'.</summary>
		[Field ("kCGImagePropertyHEICSFrameInfoArray",  "ImageIO")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString HeicsFrameInfoArray {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_HeicsFrameInfoArray is null)
					_HeicsFrameInfoArray = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyHEICSFrameInfoArray")!;
				return _HeicsFrameInfoArray;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeicsLoopCount;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyHEICSLoopCount'.</summary>
		[Field ("kCGImagePropertyHEICSLoopCount",  "ImageIO")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString HeicsLoopCount {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_HeicsLoopCount is null)
					_HeicsLoopCount = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyHEICSLoopCount")!;
				return _HeicsLoopCount;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeicsSUnclampedDelayTime;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyHEICSUnclampedDelayTime'.</summary>
		[Field ("kCGImagePropertyHEICSUnclampedDelayTime",  "ImageIO")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString HeicsSUnclampedDelayTime {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_HeicsSUnclampedDelayTime is null)
					_HeicsSUnclampedDelayTime = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyHEICSUnclampedDelayTime")!;
				return _HeicsSUnclampedDelayTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeifDictionary;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyHEIFDictionary'.</summary>
		[Field ("kCGImagePropertyHEIFDictionary",  "ImageIO")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public static NSString HeifDictionary {
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				if (_HeifDictionary is null)
					_HeifDictionary = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyHEIFDictionary")!;
				return _HeifDictionary;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Height;
		/// <summary>Represents the value associated with the constant kCGImagePropertyHeight</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyHeight",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Height {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Height is null)
					_Height = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyHeight")!;
				return _Height;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCActionAdvised;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCActionAdvised</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCActionAdvised",  "ImageIO")]
		public static NSString IPTCActionAdvised {
			get {
				if (_IPTCActionAdvised is null)
					_IPTCActionAdvised = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCActionAdvised")!;
				return _IPTCActionAdvised;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCByline;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCByline</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCByline",  "ImageIO")]
		public static NSString IPTCByline {
			get {
				if (_IPTCByline is null)
					_IPTCByline = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCByline")!;
				return _IPTCByline;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCBylineTitle;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCBylineTitle</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCBylineTitle",  "ImageIO")]
		public static NSString IPTCBylineTitle {
			get {
				if (_IPTCBylineTitle is null)
					_IPTCBylineTitle = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCBylineTitle")!;
				return _IPTCBylineTitle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCCaptionAbstract;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCCaptionAbstract</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCCaptionAbstract",  "ImageIO")]
		public static NSString IPTCCaptionAbstract {
			get {
				if (_IPTCCaptionAbstract is null)
					_IPTCCaptionAbstract = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCCaptionAbstract")!;
				return _IPTCCaptionAbstract;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCCategory;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCCategory</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCCategory",  "ImageIO")]
		public static NSString IPTCCategory {
			get {
				if (_IPTCCategory is null)
					_IPTCCategory = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCCategory")!;
				return _IPTCCategory;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCCity;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCCity</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCCity",  "ImageIO")]
		public static NSString IPTCCity {
			get {
				if (_IPTCCity is null)
					_IPTCCity = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCCity")!;
				return _IPTCCity;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCContact;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCContact</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCContact",  "ImageIO")]
		public static NSString IPTCContact {
			get {
				if (_IPTCContact is null)
					_IPTCContact = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCContact")!;
				return _IPTCContact;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCContactInfoAddress;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCContactInfoAddress</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCContactInfoAddress",  "ImageIO")]
		public static NSString IPTCContactInfoAddress {
			get {
				if (_IPTCContactInfoAddress is null)
					_IPTCContactInfoAddress = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCContactInfoAddress")!;
				return _IPTCContactInfoAddress;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCContactInfoCity;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCContactInfoCity</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCContactInfoCity",  "ImageIO")]
		public static NSString IPTCContactInfoCity {
			get {
				if (_IPTCContactInfoCity is null)
					_IPTCContactInfoCity = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCContactInfoCity")!;
				return _IPTCContactInfoCity;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCContactInfoCountry;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCContactInfoCountry</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCContactInfoCountry",  "ImageIO")]
		public static NSString IPTCContactInfoCountry {
			get {
				if (_IPTCContactInfoCountry is null)
					_IPTCContactInfoCountry = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCContactInfoCountry")!;
				return _IPTCContactInfoCountry;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCContactInfoEmails;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCContactInfoEmails</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCContactInfoEmails",  "ImageIO")]
		public static NSString IPTCContactInfoEmails {
			get {
				if (_IPTCContactInfoEmails is null)
					_IPTCContactInfoEmails = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCContactInfoEmails")!;
				return _IPTCContactInfoEmails;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCContactInfoPhones;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCContactInfoPhones</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCContactInfoPhones",  "ImageIO")]
		public static NSString IPTCContactInfoPhones {
			get {
				if (_IPTCContactInfoPhones is null)
					_IPTCContactInfoPhones = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCContactInfoPhones")!;
				return _IPTCContactInfoPhones;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCContactInfoPostalCode;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCContactInfoPostalCode</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCContactInfoPostalCode",  "ImageIO")]
		public static NSString IPTCContactInfoPostalCode {
			get {
				if (_IPTCContactInfoPostalCode is null)
					_IPTCContactInfoPostalCode = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCContactInfoPostalCode")!;
				return _IPTCContactInfoPostalCode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCContactInfoStateProvince;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCContactInfoStateProvince</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCContactInfoStateProvince",  "ImageIO")]
		public static NSString IPTCContactInfoStateProvince {
			get {
				if (_IPTCContactInfoStateProvince is null)
					_IPTCContactInfoStateProvince = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCContactInfoStateProvince")!;
				return _IPTCContactInfoStateProvince;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCContactInfoWebURLs;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCContactInfoWebURLs</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCContactInfoWebURLs",  "ImageIO")]
		public static NSString IPTCContactInfoWebURLs {
			get {
				if (_IPTCContactInfoWebURLs is null)
					_IPTCContactInfoWebURLs = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCContactInfoWebURLs")!;
				return _IPTCContactInfoWebURLs;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCContentLocationCode;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCContentLocationCode</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCContentLocationCode",  "ImageIO")]
		public static NSString IPTCContentLocationCode {
			get {
				if (_IPTCContentLocationCode is null)
					_IPTCContentLocationCode = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCContentLocationCode")!;
				return _IPTCContentLocationCode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCContentLocationName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCContentLocationName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCContentLocationName",  "ImageIO")]
		public static NSString IPTCContentLocationName {
			get {
				if (_IPTCContentLocationName is null)
					_IPTCContentLocationName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCContentLocationName")!;
				return _IPTCContentLocationName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCCopyrightNotice;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCCopyrightNotice</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCCopyrightNotice",  "ImageIO")]
		public static NSString IPTCCopyrightNotice {
			get {
				if (_IPTCCopyrightNotice is null)
					_IPTCCopyrightNotice = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCCopyrightNotice")!;
				return _IPTCCopyrightNotice;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCCountryPrimaryLocationCode;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCCountryPrimaryLocationCode</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCCountryPrimaryLocationCode",  "ImageIO")]
		public static NSString IPTCCountryPrimaryLocationCode {
			get {
				if (_IPTCCountryPrimaryLocationCode is null)
					_IPTCCountryPrimaryLocationCode = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCCountryPrimaryLocationCode")!;
				return _IPTCCountryPrimaryLocationCode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCCountryPrimaryLocationName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCCountryPrimaryLocationName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCCountryPrimaryLocationName",  "ImageIO")]
		public static NSString IPTCCountryPrimaryLocationName {
			get {
				if (_IPTCCountryPrimaryLocationName is null)
					_IPTCCountryPrimaryLocationName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCCountryPrimaryLocationName")!;
				return _IPTCCountryPrimaryLocationName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCCreatorContactInfo;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCCreatorContactInfo</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCCreatorContactInfo",  "ImageIO")]
		public static NSString IPTCCreatorContactInfo {
			get {
				if (_IPTCCreatorContactInfo is null)
					_IPTCCreatorContactInfo = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCCreatorContactInfo")!;
				return _IPTCCreatorContactInfo;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCCredit;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCCredit</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCCredit",  "ImageIO")]
		public static NSString IPTCCredit {
			get {
				if (_IPTCCredit is null)
					_IPTCCredit = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCCredit")!;
				return _IPTCCredit;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCDateCreated;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCDateCreated</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCDateCreated",  "ImageIO")]
		public static NSString IPTCDateCreated {
			get {
				if (_IPTCDateCreated is null)
					_IPTCDateCreated = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCDateCreated")!;
				return _IPTCDateCreated;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCDictionary;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCDictionary</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCDictionary",  "ImageIO")]
		public static NSString IPTCDictionary {
			get {
				if (_IPTCDictionary is null)
					_IPTCDictionary = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCDictionary")!;
				return _IPTCDictionary;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCDigitalCreationDate;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCDigitalCreationDate</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCDigitalCreationDate",  "ImageIO")]
		public static NSString IPTCDigitalCreationDate {
			get {
				if (_IPTCDigitalCreationDate is null)
					_IPTCDigitalCreationDate = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCDigitalCreationDate")!;
				return _IPTCDigitalCreationDate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCDigitalCreationTime;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCDigitalCreationTime</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCDigitalCreationTime",  "ImageIO")]
		public static NSString IPTCDigitalCreationTime {
			get {
				if (_IPTCDigitalCreationTime is null)
					_IPTCDigitalCreationTime = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCDigitalCreationTime")!;
				return _IPTCDigitalCreationTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCEditStatus;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCEditStatus</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCEditStatus",  "ImageIO")]
		public static NSString IPTCEditStatus {
			get {
				if (_IPTCEditStatus is null)
					_IPTCEditStatus = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCEditStatus")!;
				return _IPTCEditStatus;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCEditorialUpdate;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCEditorialUpdate</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCEditorialUpdate",  "ImageIO")]
		public static NSString IPTCEditorialUpdate {
			get {
				if (_IPTCEditorialUpdate is null)
					_IPTCEditorialUpdate = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCEditorialUpdate")!;
				return _IPTCEditorialUpdate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExpirationDate;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExpirationDate</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExpirationDate",  "ImageIO")]
		public static NSString IPTCExpirationDate {
			get {
				if (_IPTCExpirationDate is null)
					_IPTCExpirationDate = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExpirationDate")!;
				return _IPTCExpirationDate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExpirationTime;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExpirationTime</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExpirationTime",  "ImageIO")]
		public static NSString IPTCExpirationTime {
			get {
				if (_IPTCExpirationTime is null)
					_IPTCExpirationTime = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExpirationTime")!;
				return _IPTCExpirationTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtAboutCvTerm;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtAboutCvTerm</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtAboutCvTerm",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtAboutCvTerm {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtAboutCvTerm is null)
					_IPTCExtAboutCvTerm = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtAboutCvTerm")!;
				return _IPTCExtAboutCvTerm;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtAboutCvTermCvId;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtAboutCvTermCvId</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtAboutCvTermCvId",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtAboutCvTermCvId {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtAboutCvTermCvId is null)
					_IPTCExtAboutCvTermCvId = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtAboutCvTermCvId")!;
				return _IPTCExtAboutCvTermCvId;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtAboutCvTermId;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtAboutCvTermId</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtAboutCvTermId",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtAboutCvTermId {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtAboutCvTermId is null)
					_IPTCExtAboutCvTermId = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtAboutCvTermId")!;
				return _IPTCExtAboutCvTermId;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtAboutCvTermName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtAboutCvTermName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtAboutCvTermName",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtAboutCvTermName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtAboutCvTermName is null)
					_IPTCExtAboutCvTermName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtAboutCvTermName")!;
				return _IPTCExtAboutCvTermName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtAboutCvTermRefinedAbout;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtAboutCvTermRefinedAbout</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtAboutCvTermRefinedAbout",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtAboutCvTermRefinedAbout {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtAboutCvTermRefinedAbout is null)
					_IPTCExtAboutCvTermRefinedAbout = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtAboutCvTermRefinedAbout")!;
				return _IPTCExtAboutCvTermRefinedAbout;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtAddlModelInfo;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtAddlModelInfo</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtAddlModelInfo",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtAddlModelInfo {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtAddlModelInfo is null)
					_IPTCExtAddlModelInfo = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtAddlModelInfo")!;
				return _IPTCExtAddlModelInfo;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtArtworkCircaDateCreated;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkCircaDateCreated</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtArtworkCircaDateCreated",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtArtworkCircaDateCreated {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtArtworkCircaDateCreated is null)
					_IPTCExtArtworkCircaDateCreated = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkCircaDateCreated")!;
				return _IPTCExtArtworkCircaDateCreated;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtArtworkContentDescription;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkContentDescription</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtArtworkContentDescription",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtArtworkContentDescription {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtArtworkContentDescription is null)
					_IPTCExtArtworkContentDescription = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkContentDescription")!;
				return _IPTCExtArtworkContentDescription;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtArtworkContributionDescription;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkContributionDescription</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtArtworkContributionDescription",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtArtworkContributionDescription {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtArtworkContributionDescription is null)
					_IPTCExtArtworkContributionDescription = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkContributionDescription")!;
				return _IPTCExtArtworkContributionDescription;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtArtworkCopyrightNotice;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkCopyrightNotice</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtArtworkCopyrightNotice",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtArtworkCopyrightNotice {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtArtworkCopyrightNotice is null)
					_IPTCExtArtworkCopyrightNotice = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkCopyrightNotice")!;
				return _IPTCExtArtworkCopyrightNotice;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtArtworkCopyrightOwnerId;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkCopyrightOwnerID</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtArtworkCopyrightOwnerID",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtArtworkCopyrightOwnerId {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtArtworkCopyrightOwnerId is null)
					_IPTCExtArtworkCopyrightOwnerId = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkCopyrightOwnerID")!;
				return _IPTCExtArtworkCopyrightOwnerId;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtArtworkCopyrightOwnerName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkCopyrightOwnerName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtArtworkCopyrightOwnerName",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtArtworkCopyrightOwnerName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtArtworkCopyrightOwnerName is null)
					_IPTCExtArtworkCopyrightOwnerName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkCopyrightOwnerName")!;
				return _IPTCExtArtworkCopyrightOwnerName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtArtworkCreator;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkCreator</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtArtworkCreator",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtArtworkCreator {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtArtworkCreator is null)
					_IPTCExtArtworkCreator = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkCreator")!;
				return _IPTCExtArtworkCreator;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtArtworkCreatorId;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkCreatorID</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtArtworkCreatorID",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtArtworkCreatorId {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtArtworkCreatorId is null)
					_IPTCExtArtworkCreatorId = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkCreatorID")!;
				return _IPTCExtArtworkCreatorId;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtArtworkDateCreated;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkDateCreated</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtArtworkDateCreated",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtArtworkDateCreated {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtArtworkDateCreated is null)
					_IPTCExtArtworkDateCreated = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkDateCreated")!;
				return _IPTCExtArtworkDateCreated;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtArtworkLicensorId;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkLicensorID</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtArtworkLicensorID",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtArtworkLicensorId {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtArtworkLicensorId is null)
					_IPTCExtArtworkLicensorId = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkLicensorID")!;
				return _IPTCExtArtworkLicensorId;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtArtworkLicensorName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkLicensorName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtArtworkLicensorName",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtArtworkLicensorName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtArtworkLicensorName is null)
					_IPTCExtArtworkLicensorName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkLicensorName")!;
				return _IPTCExtArtworkLicensorName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtArtworkOrObject;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkOrObject</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtArtworkOrObject",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtArtworkOrObject {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtArtworkOrObject is null)
					_IPTCExtArtworkOrObject = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkOrObject")!;
				return _IPTCExtArtworkOrObject;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtArtworkPhysicalDescription;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkPhysicalDescription</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtArtworkPhysicalDescription",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtArtworkPhysicalDescription {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtArtworkPhysicalDescription is null)
					_IPTCExtArtworkPhysicalDescription = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkPhysicalDescription")!;
				return _IPTCExtArtworkPhysicalDescription;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtArtworkSource;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkSource</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtArtworkSource",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtArtworkSource {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtArtworkSource is null)
					_IPTCExtArtworkSource = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkSource")!;
				return _IPTCExtArtworkSource;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtArtworkSourceInvUrl;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkSourceInvURL</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtArtworkSourceInvURL",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtArtworkSourceInvUrl {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtArtworkSourceInvUrl is null)
					_IPTCExtArtworkSourceInvUrl = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkSourceInvURL")!;
				return _IPTCExtArtworkSourceInvUrl;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtArtworkSourceInventoryNo;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkSourceInventoryNo</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtArtworkSourceInventoryNo",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtArtworkSourceInventoryNo {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtArtworkSourceInventoryNo is null)
					_IPTCExtArtworkSourceInventoryNo = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkSourceInventoryNo")!;
				return _IPTCExtArtworkSourceInventoryNo;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtArtworkStylePeriod;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkStylePeriod</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtArtworkStylePeriod",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtArtworkStylePeriod {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtArtworkStylePeriod is null)
					_IPTCExtArtworkStylePeriod = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkStylePeriod")!;
				return _IPTCExtArtworkStylePeriod;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtArtworkTitle;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkTitle</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtArtworkTitle",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtArtworkTitle {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtArtworkTitle is null)
					_IPTCExtArtworkTitle = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkTitle")!;
				return _IPTCExtArtworkTitle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtAudioBitrate;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtAudioBitrate</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtAudioBitrate",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtAudioBitrate {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtAudioBitrate is null)
					_IPTCExtAudioBitrate = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtAudioBitrate")!;
				return _IPTCExtAudioBitrate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtAudioBitrateMode;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtAudioBitrateMode</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtAudioBitrateMode",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtAudioBitrateMode {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtAudioBitrateMode is null)
					_IPTCExtAudioBitrateMode = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtAudioBitrateMode")!;
				return _IPTCExtAudioBitrateMode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtAudioChannelCount;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtAudioChannelCount</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtAudioChannelCount",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtAudioChannelCount {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtAudioChannelCount is null)
					_IPTCExtAudioChannelCount = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtAudioChannelCount")!;
				return _IPTCExtAudioChannelCount;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtCircaDateCreated;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtCircaDateCreated</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtCircaDateCreated",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtCircaDateCreated {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtCircaDateCreated is null)
					_IPTCExtCircaDateCreated = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtCircaDateCreated")!;
				return _IPTCExtCircaDateCreated;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtContainerFormat;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtContainerFormat</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtContainerFormat",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtContainerFormat {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtContainerFormat is null)
					_IPTCExtContainerFormat = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtContainerFormat")!;
				return _IPTCExtContainerFormat;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtContainerFormatIdentifier;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtContainerFormatIdentifier</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtContainerFormatIdentifier",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtContainerFormatIdentifier {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtContainerFormatIdentifier is null)
					_IPTCExtContainerFormatIdentifier = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtContainerFormatIdentifier")!;
				return _IPTCExtContainerFormatIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtContainerFormatName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtContainerFormatName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtContainerFormatName",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtContainerFormatName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtContainerFormatName is null)
					_IPTCExtContainerFormatName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtContainerFormatName")!;
				return _IPTCExtContainerFormatName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtContributor;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtContributor</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtContributor",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtContributor {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtContributor is null)
					_IPTCExtContributor = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtContributor")!;
				return _IPTCExtContributor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtContributorIdentifier;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtContributorIdentifier</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtContributorIdentifier",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtContributorIdentifier {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtContributorIdentifier is null)
					_IPTCExtContributorIdentifier = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtContributorIdentifier")!;
				return _IPTCExtContributorIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtContributorName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtContributorName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtContributorName",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtContributorName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtContributorName is null)
					_IPTCExtContributorName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtContributorName")!;
				return _IPTCExtContributorName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtContributorRole;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtContributorRole</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtContributorRole",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtContributorRole {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtContributorRole is null)
					_IPTCExtContributorRole = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtContributorRole")!;
				return _IPTCExtContributorRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtControlledVocabularyTerm;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtControlledVocabularyTerm</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtControlledVocabularyTerm",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtControlledVocabularyTerm {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtControlledVocabularyTerm is null)
					_IPTCExtControlledVocabularyTerm = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtControlledVocabularyTerm")!;
				return _IPTCExtControlledVocabularyTerm;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtCopyrightYear;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtCopyrightYear</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtCopyrightYear",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtCopyrightYear {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtCopyrightYear is null)
					_IPTCExtCopyrightYear = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtCopyrightYear")!;
				return _IPTCExtCopyrightYear;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtCreator;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtCreator</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtCreator",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtCreator {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtCreator is null)
					_IPTCExtCreator = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtCreator")!;
				return _IPTCExtCreator;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtCreatorIdentifier;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtCreatorIdentifier</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtCreatorIdentifier",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtCreatorIdentifier {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtCreatorIdentifier is null)
					_IPTCExtCreatorIdentifier = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtCreatorIdentifier")!;
				return _IPTCExtCreatorIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtCreatorName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtCreatorName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtCreatorName",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtCreatorName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtCreatorName is null)
					_IPTCExtCreatorName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtCreatorName")!;
				return _IPTCExtCreatorName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtCreatorRole;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtCreatorRole</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtCreatorRole",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtCreatorRole {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtCreatorRole is null)
					_IPTCExtCreatorRole = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtCreatorRole")!;
				return _IPTCExtCreatorRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtDataOnScreen;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtDataOnScreen</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtDataOnScreen",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtDataOnScreen {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtDataOnScreen is null)
					_IPTCExtDataOnScreen = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtDataOnScreen")!;
				return _IPTCExtDataOnScreen;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtDataOnScreenRegion;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtDataOnScreenRegion</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtDataOnScreenRegion",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtDataOnScreenRegion {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtDataOnScreenRegion is null)
					_IPTCExtDataOnScreenRegion = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtDataOnScreenRegion")!;
				return _IPTCExtDataOnScreenRegion;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtDataOnScreenRegionD;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtDataOnScreenRegionD</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtDataOnScreenRegionD",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtDataOnScreenRegionD {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtDataOnScreenRegionD is null)
					_IPTCExtDataOnScreenRegionD = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtDataOnScreenRegionD")!;
				return _IPTCExtDataOnScreenRegionD;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtDataOnScreenRegionH;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtDataOnScreenRegionH</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtDataOnScreenRegionH",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtDataOnScreenRegionH {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtDataOnScreenRegionH is null)
					_IPTCExtDataOnScreenRegionH = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtDataOnScreenRegionH")!;
				return _IPTCExtDataOnScreenRegionH;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtDataOnScreenRegionText;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtDataOnScreenRegionText</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtDataOnScreenRegionText",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtDataOnScreenRegionText {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtDataOnScreenRegionText is null)
					_IPTCExtDataOnScreenRegionText = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtDataOnScreenRegionText")!;
				return _IPTCExtDataOnScreenRegionText;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtDataOnScreenRegionUnit;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtDataOnScreenRegionUnit</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtDataOnScreenRegionUnit",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtDataOnScreenRegionUnit {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtDataOnScreenRegionUnit is null)
					_IPTCExtDataOnScreenRegionUnit = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtDataOnScreenRegionUnit")!;
				return _IPTCExtDataOnScreenRegionUnit;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtDataOnScreenRegionW;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtDataOnScreenRegionW</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtDataOnScreenRegionW",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtDataOnScreenRegionW {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtDataOnScreenRegionW is null)
					_IPTCExtDataOnScreenRegionW = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtDataOnScreenRegionW")!;
				return _IPTCExtDataOnScreenRegionW;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtDataOnScreenRegionX;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtDataOnScreenRegionX</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtDataOnScreenRegionX",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtDataOnScreenRegionX {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtDataOnScreenRegionX is null)
					_IPTCExtDataOnScreenRegionX = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtDataOnScreenRegionX")!;
				return _IPTCExtDataOnScreenRegionX;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtDataOnScreenRegionY;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtDataOnScreenRegionY</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtDataOnScreenRegionY",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtDataOnScreenRegionY {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtDataOnScreenRegionY is null)
					_IPTCExtDataOnScreenRegionY = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtDataOnScreenRegionY")!;
				return _IPTCExtDataOnScreenRegionY;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtDigitalImageGuid;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtDigitalImageGUID</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtDigitalImageGUID",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtDigitalImageGuid {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtDigitalImageGuid is null)
					_IPTCExtDigitalImageGuid = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtDigitalImageGUID")!;
				return _IPTCExtDigitalImageGuid;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtDigitalSourceFileType;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtDigitalSourceFileType</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtDigitalSourceFileType",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtDigitalSourceFileType {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtDigitalSourceFileType is null)
					_IPTCExtDigitalSourceFileType = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtDigitalSourceFileType")!;
				return _IPTCExtDigitalSourceFileType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtDigitalSourceType;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtDigitalSourceType</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtDigitalSourceType",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtDigitalSourceType {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtDigitalSourceType is null)
					_IPTCExtDigitalSourceType = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtDigitalSourceType")!;
				return _IPTCExtDigitalSourceType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtDopesheet;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtDopesheet</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtDopesheet",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtDopesheet {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtDopesheet is null)
					_IPTCExtDopesheet = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtDopesheet")!;
				return _IPTCExtDopesheet;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtDopesheetLink;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtDopesheetLink</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtDopesheetLink",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtDopesheetLink {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtDopesheetLink is null)
					_IPTCExtDopesheetLink = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtDopesheetLink")!;
				return _IPTCExtDopesheetLink;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtDopesheetLinkLink;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtDopesheetLinkLink</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtDopesheetLinkLink",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtDopesheetLinkLink {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtDopesheetLinkLink is null)
					_IPTCExtDopesheetLinkLink = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtDopesheetLinkLink")!;
				return _IPTCExtDopesheetLinkLink;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtDopesheetLinkLinkQualifier;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtDopesheetLinkLinkQualifier</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtDopesheetLinkLinkQualifier",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtDopesheetLinkLinkQualifier {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtDopesheetLinkLinkQualifier is null)
					_IPTCExtDopesheetLinkLinkQualifier = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtDopesheetLinkLinkQualifier")!;
				return _IPTCExtDopesheetLinkLinkQualifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtEmbdEncRightsExpr;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtEmbdEncRightsExpr</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtEmbdEncRightsExpr",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtEmbdEncRightsExpr {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtEmbdEncRightsExpr is null)
					_IPTCExtEmbdEncRightsExpr = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtEmbdEncRightsExpr")!;
				return _IPTCExtEmbdEncRightsExpr;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtEmbeddedEncodedRightsExpr;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtEmbeddedEncodedRightsExpr</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtEmbeddedEncodedRightsExpr",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtEmbeddedEncodedRightsExpr {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtEmbeddedEncodedRightsExpr is null)
					_IPTCExtEmbeddedEncodedRightsExpr = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtEmbeddedEncodedRightsExpr")!;
				return _IPTCExtEmbeddedEncodedRightsExpr;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtEmbeddedEncodedRightsExprLangId;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtEmbeddedEncodedRightsExprLangID</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtEmbeddedEncodedRightsExprLangID",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtEmbeddedEncodedRightsExprLangId {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtEmbeddedEncodedRightsExprLangId is null)
					_IPTCExtEmbeddedEncodedRightsExprLangId = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtEmbeddedEncodedRightsExprLangID")!;
				return _IPTCExtEmbeddedEncodedRightsExprLangId;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtEmbeddedEncodedRightsExprType;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtEmbeddedEncodedRightsExprType</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtEmbeddedEncodedRightsExprType",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtEmbeddedEncodedRightsExprType {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtEmbeddedEncodedRightsExprType is null)
					_IPTCExtEmbeddedEncodedRightsExprType = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtEmbeddedEncodedRightsExprType")!;
				return _IPTCExtEmbeddedEncodedRightsExprType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtEpisode;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtEpisode</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtEpisode",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtEpisode {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtEpisode is null)
					_IPTCExtEpisode = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtEpisode")!;
				return _IPTCExtEpisode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtEpisodeIdentifier;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtEpisodeIdentifier</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtEpisodeIdentifier",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtEpisodeIdentifier {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtEpisodeIdentifier is null)
					_IPTCExtEpisodeIdentifier = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtEpisodeIdentifier")!;
				return _IPTCExtEpisodeIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtEpisodeName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtEpisodeName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtEpisodeName",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtEpisodeName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtEpisodeName is null)
					_IPTCExtEpisodeName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtEpisodeName")!;
				return _IPTCExtEpisodeName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtEpisodeNumber;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtEpisodeNumber</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtEpisodeNumber",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtEpisodeNumber {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtEpisodeNumber is null)
					_IPTCExtEpisodeNumber = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtEpisodeNumber")!;
				return _IPTCExtEpisodeNumber;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtEvent;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtEvent</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtEvent",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtEvent {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtEvent is null)
					_IPTCExtEvent = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtEvent")!;
				return _IPTCExtEvent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtExternalMetadataLink;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtExternalMetadataLink</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtExternalMetadataLink",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtExternalMetadataLink {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtExternalMetadataLink is null)
					_IPTCExtExternalMetadataLink = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtExternalMetadataLink")!;
				return _IPTCExtExternalMetadataLink;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtFeedIdentifier;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtFeedIdentifier</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtFeedIdentifier",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtFeedIdentifier {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtFeedIdentifier is null)
					_IPTCExtFeedIdentifier = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtFeedIdentifier")!;
				return _IPTCExtFeedIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtGenre;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtGenre</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtGenre",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtGenre {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtGenre is null)
					_IPTCExtGenre = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtGenre")!;
				return _IPTCExtGenre;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtGenreCvId;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtGenreCvId</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtGenreCvId",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtGenreCvId {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtGenreCvId is null)
					_IPTCExtGenreCvId = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtGenreCvId")!;
				return _IPTCExtGenreCvId;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtGenreCvTermId;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtGenreCvTermId</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtGenreCvTermId",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtGenreCvTermId {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtGenreCvTermId is null)
					_IPTCExtGenreCvTermId = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtGenreCvTermId")!;
				return _IPTCExtGenreCvTermId;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtGenreCvTermName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtGenreCvTermName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtGenreCvTermName",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtGenreCvTermName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtGenreCvTermName is null)
					_IPTCExtGenreCvTermName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtGenreCvTermName")!;
				return _IPTCExtGenreCvTermName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtGenreCvTermRefinedAbout;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtGenreCvTermRefinedAbout</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtGenreCvTermRefinedAbout",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtGenreCvTermRefinedAbout {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtGenreCvTermRefinedAbout is null)
					_IPTCExtGenreCvTermRefinedAbout = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtGenreCvTermRefinedAbout")!;
				return _IPTCExtGenreCvTermRefinedAbout;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtHeadline;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtHeadline</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtHeadline",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtHeadline {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtHeadline is null)
					_IPTCExtHeadline = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtHeadline")!;
				return _IPTCExtHeadline;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtIPTCLastEdited;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtIPTCLastEdited</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtIPTCLastEdited",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtIPTCLastEdited {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtIPTCLastEdited is null)
					_IPTCExtIPTCLastEdited = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtIPTCLastEdited")!;
				return _IPTCExtIPTCLastEdited;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtLinkedEncRightsExpr;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLinkedEncRightsExpr</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtLinkedEncRightsExpr",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtLinkedEncRightsExpr {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtLinkedEncRightsExpr is null)
					_IPTCExtLinkedEncRightsExpr = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLinkedEncRightsExpr")!;
				return _IPTCExtLinkedEncRightsExpr;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtLinkedEncodedRightsExpr;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLinkedEncodedRightsExpr</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtLinkedEncodedRightsExpr",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtLinkedEncodedRightsExpr {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtLinkedEncodedRightsExpr is null)
					_IPTCExtLinkedEncodedRightsExpr = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLinkedEncodedRightsExpr")!;
				return _IPTCExtLinkedEncodedRightsExpr;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtLinkedEncodedRightsExprLangId;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLinkedEncodedRightsExprLangID</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtLinkedEncodedRightsExprLangID",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtLinkedEncodedRightsExprLangId {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtLinkedEncodedRightsExprLangId is null)
					_IPTCExtLinkedEncodedRightsExprLangId = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLinkedEncodedRightsExprLangID")!;
				return _IPTCExtLinkedEncodedRightsExprLangId;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtLinkedEncodedRightsExprType;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLinkedEncodedRightsExprType</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtLinkedEncodedRightsExprType",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtLinkedEncodedRightsExprType {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtLinkedEncodedRightsExprType is null)
					_IPTCExtLinkedEncodedRightsExprType = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLinkedEncodedRightsExprType")!;
				return _IPTCExtLinkedEncodedRightsExprType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtLocationCity;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLocationCity</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtLocationCity",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtLocationCity {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtLocationCity is null)
					_IPTCExtLocationCity = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLocationCity")!;
				return _IPTCExtLocationCity;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtLocationCountryCode;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLocationCountryCode</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtLocationCountryCode",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtLocationCountryCode {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtLocationCountryCode is null)
					_IPTCExtLocationCountryCode = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLocationCountryCode")!;
				return _IPTCExtLocationCountryCode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtLocationCountryName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLocationCountryName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtLocationCountryName",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtLocationCountryName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtLocationCountryName is null)
					_IPTCExtLocationCountryName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLocationCountryName")!;
				return _IPTCExtLocationCountryName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtLocationCreated;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLocationCreated</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtLocationCreated",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtLocationCreated {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtLocationCreated is null)
					_IPTCExtLocationCreated = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLocationCreated")!;
				return _IPTCExtLocationCreated;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtLocationGpsAltitude;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLocationGPSAltitude</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtLocationGPSAltitude",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtLocationGpsAltitude {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtLocationGpsAltitude is null)
					_IPTCExtLocationGpsAltitude = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLocationGPSAltitude")!;
				return _IPTCExtLocationGpsAltitude;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtLocationGpsLatitude;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLocationGPSLatitude</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtLocationGPSLatitude",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtLocationGpsLatitude {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtLocationGpsLatitude is null)
					_IPTCExtLocationGpsLatitude = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLocationGPSLatitude")!;
				return _IPTCExtLocationGpsLatitude;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtLocationGpsLongitude;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLocationGPSLongitude</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtLocationGPSLongitude",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtLocationGpsLongitude {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtLocationGpsLongitude is null)
					_IPTCExtLocationGpsLongitude = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLocationGPSLongitude")!;
				return _IPTCExtLocationGpsLongitude;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtLocationIdentifier;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLocationIdentifier</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtLocationIdentifier",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtLocationIdentifier {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtLocationIdentifier is null)
					_IPTCExtLocationIdentifier = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLocationIdentifier")!;
				return _IPTCExtLocationIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtLocationLocationId;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLocationLocationId</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtLocationLocationId",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtLocationLocationId {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtLocationLocationId is null)
					_IPTCExtLocationLocationId = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLocationLocationId")!;
				return _IPTCExtLocationLocationId;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtLocationLocationName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLocationLocationName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtLocationLocationName",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtLocationLocationName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtLocationLocationName is null)
					_IPTCExtLocationLocationName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLocationLocationName")!;
				return _IPTCExtLocationLocationName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtLocationProvinceState;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLocationProvinceState</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtLocationProvinceState",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtLocationProvinceState {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtLocationProvinceState is null)
					_IPTCExtLocationProvinceState = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLocationProvinceState")!;
				return _IPTCExtLocationProvinceState;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtLocationShown;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLocationShown</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtLocationShown",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtLocationShown {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtLocationShown is null)
					_IPTCExtLocationShown = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLocationShown")!;
				return _IPTCExtLocationShown;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtLocationSublocation;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLocationSublocation</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtLocationSublocation",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtLocationSublocation {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtLocationSublocation is null)
					_IPTCExtLocationSublocation = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLocationSublocation")!;
				return _IPTCExtLocationSublocation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtLocationWorldRegion;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLocationWorldRegion</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtLocationWorldRegion",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtLocationWorldRegion {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtLocationWorldRegion is null)
					_IPTCExtLocationWorldRegion = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLocationWorldRegion")!;
				return _IPTCExtLocationWorldRegion;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtMaxAvailHeight;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtMaxAvailHeight</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtMaxAvailHeight",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtMaxAvailHeight {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtMaxAvailHeight is null)
					_IPTCExtMaxAvailHeight = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtMaxAvailHeight")!;
				return _IPTCExtMaxAvailHeight;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtMaxAvailWidth;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtMaxAvailWidth</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtMaxAvailWidth",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtMaxAvailWidth {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtMaxAvailWidth is null)
					_IPTCExtMaxAvailWidth = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtMaxAvailWidth")!;
				return _IPTCExtMaxAvailWidth;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtModelAge;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtModelAge</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtModelAge",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtModelAge {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtModelAge is null)
					_IPTCExtModelAge = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtModelAge")!;
				return _IPTCExtModelAge;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtOrganisationInImageCode;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtOrganisationInImageCode</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtOrganisationInImageCode",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtOrganisationInImageCode {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtOrganisationInImageCode is null)
					_IPTCExtOrganisationInImageCode = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtOrganisationInImageCode")!;
				return _IPTCExtOrganisationInImageCode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtOrganisationInImageName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtOrganisationInImageName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtOrganisationInImageName",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtOrganisationInImageName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtOrganisationInImageName is null)
					_IPTCExtOrganisationInImageName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtOrganisationInImageName")!;
				return _IPTCExtOrganisationInImageName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtPersonHeard;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPersonHeard</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtPersonHeard",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtPersonHeard {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtPersonHeard is null)
					_IPTCExtPersonHeard = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPersonHeard")!;
				return _IPTCExtPersonHeard;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtPersonHeardIdentifier;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPersonHeardIdentifier</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtPersonHeardIdentifier",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtPersonHeardIdentifier {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtPersonHeardIdentifier is null)
					_IPTCExtPersonHeardIdentifier = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPersonHeardIdentifier")!;
				return _IPTCExtPersonHeardIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtPersonHeardName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPersonHeardName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtPersonHeardName",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtPersonHeardName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtPersonHeardName is null)
					_IPTCExtPersonHeardName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPersonHeardName")!;
				return _IPTCExtPersonHeardName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtPersonInImage;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPersonInImage</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtPersonInImage",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtPersonInImage {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtPersonInImage is null)
					_IPTCExtPersonInImage = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPersonInImage")!;
				return _IPTCExtPersonInImage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtPersonInImageCharacteristic;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPersonInImageCharacteristic</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtPersonInImageCharacteristic",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtPersonInImageCharacteristic {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtPersonInImageCharacteristic is null)
					_IPTCExtPersonInImageCharacteristic = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPersonInImageCharacteristic")!;
				return _IPTCExtPersonInImageCharacteristic;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtPersonInImageCvTermCvId;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPersonInImageCvTermCvId</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtPersonInImageCvTermCvId",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtPersonInImageCvTermCvId {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtPersonInImageCvTermCvId is null)
					_IPTCExtPersonInImageCvTermCvId = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPersonInImageCvTermCvId")!;
				return _IPTCExtPersonInImageCvTermCvId;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtPersonInImageCvTermId;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPersonInImageCvTermId</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtPersonInImageCvTermId",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtPersonInImageCvTermId {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtPersonInImageCvTermId is null)
					_IPTCExtPersonInImageCvTermId = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPersonInImageCvTermId")!;
				return _IPTCExtPersonInImageCvTermId;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtPersonInImageCvTermName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPersonInImageCvTermName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtPersonInImageCvTermName",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtPersonInImageCvTermName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtPersonInImageCvTermName is null)
					_IPTCExtPersonInImageCvTermName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPersonInImageCvTermName")!;
				return _IPTCExtPersonInImageCvTermName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtPersonInImageCvTermRefinedAbout;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPersonInImageCvTermRefinedAbout</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtPersonInImageCvTermRefinedAbout",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtPersonInImageCvTermRefinedAbout {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtPersonInImageCvTermRefinedAbout is null)
					_IPTCExtPersonInImageCvTermRefinedAbout = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPersonInImageCvTermRefinedAbout")!;
				return _IPTCExtPersonInImageCvTermRefinedAbout;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtPersonInImageDescription;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPersonInImageDescription</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtPersonInImageDescription",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtPersonInImageDescription {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtPersonInImageDescription is null)
					_IPTCExtPersonInImageDescription = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPersonInImageDescription")!;
				return _IPTCExtPersonInImageDescription;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtPersonInImageId;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPersonInImageId</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtPersonInImageId",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtPersonInImageId {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtPersonInImageId is null)
					_IPTCExtPersonInImageId = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPersonInImageId")!;
				return _IPTCExtPersonInImageId;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtPersonInImageName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPersonInImageName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtPersonInImageName",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtPersonInImageName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtPersonInImageName is null)
					_IPTCExtPersonInImageName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPersonInImageName")!;
				return _IPTCExtPersonInImageName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtPersonInImageWDetails;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPersonInImageWDetails</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtPersonInImageWDetails",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtPersonInImageWDetails {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtPersonInImageWDetails is null)
					_IPTCExtPersonInImageWDetails = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPersonInImageWDetails")!;
				return _IPTCExtPersonInImageWDetails;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtProductInImage;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtProductInImage</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtProductInImage",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtProductInImage {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtProductInImage is null)
					_IPTCExtProductInImage = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtProductInImage")!;
				return _IPTCExtProductInImage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtProductInImageDescription;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtProductInImageDescription</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtProductInImageDescription",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtProductInImageDescription {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtProductInImageDescription is null)
					_IPTCExtProductInImageDescription = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtProductInImageDescription")!;
				return _IPTCExtProductInImageDescription;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtProductInImageGtin;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtProductInImageGTIN</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtProductInImageGTIN",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtProductInImageGtin {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtProductInImageGtin is null)
					_IPTCExtProductInImageGtin = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtProductInImageGTIN")!;
				return _IPTCExtProductInImageGtin;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtProductInImageName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtProductInImageName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtProductInImageName",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtProductInImageName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtProductInImageName is null)
					_IPTCExtProductInImageName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtProductInImageName")!;
				return _IPTCExtProductInImageName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtPublicationEvent;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPublicationEvent</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtPublicationEvent",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtPublicationEvent {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtPublicationEvent is null)
					_IPTCExtPublicationEvent = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPublicationEvent")!;
				return _IPTCExtPublicationEvent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtPublicationEventDate;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPublicationEventDate</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtPublicationEventDate",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtPublicationEventDate {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtPublicationEventDate is null)
					_IPTCExtPublicationEventDate = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPublicationEventDate")!;
				return _IPTCExtPublicationEventDate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtPublicationEventIdentifier;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPublicationEventIdentifier</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtPublicationEventIdentifier",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtPublicationEventIdentifier {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtPublicationEventIdentifier is null)
					_IPTCExtPublicationEventIdentifier = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPublicationEventIdentifier")!;
				return _IPTCExtPublicationEventIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtPublicationEventName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPublicationEventName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtPublicationEventName",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtPublicationEventName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtPublicationEventName is null)
					_IPTCExtPublicationEventName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPublicationEventName")!;
				return _IPTCExtPublicationEventName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtRating;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRating</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtRating",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtRating {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtRating is null)
					_IPTCExtRating = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRating")!;
				return _IPTCExtRating;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtRatingRatingRegion;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingRatingRegion</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtRatingRatingRegion",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtRatingRatingRegion {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtRatingRatingRegion is null)
					_IPTCExtRatingRatingRegion = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingRatingRegion")!;
				return _IPTCExtRatingRatingRegion;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtRatingRegionCity;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingRegionCity</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtRatingRegionCity",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtRatingRegionCity {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtRatingRegionCity is null)
					_IPTCExtRatingRegionCity = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingRegionCity")!;
				return _IPTCExtRatingRegionCity;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtRatingRegionCountryCode;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingRegionCountryCode</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtRatingRegionCountryCode",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtRatingRegionCountryCode {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtRatingRegionCountryCode is null)
					_IPTCExtRatingRegionCountryCode = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingRegionCountryCode")!;
				return _IPTCExtRatingRegionCountryCode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtRatingRegionCountryName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingRegionCountryName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtRatingRegionCountryName",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtRatingRegionCountryName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtRatingRegionCountryName is null)
					_IPTCExtRatingRegionCountryName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingRegionCountryName")!;
				return _IPTCExtRatingRegionCountryName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtRatingRegionGpsAltitude;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingRegionGPSAltitude</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtRatingRegionGPSAltitude",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtRatingRegionGpsAltitude {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtRatingRegionGpsAltitude is null)
					_IPTCExtRatingRegionGpsAltitude = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingRegionGPSAltitude")!;
				return _IPTCExtRatingRegionGpsAltitude;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtRatingRegionGpsLatitude;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingRegionGPSLatitude</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtRatingRegionGPSLatitude",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtRatingRegionGpsLatitude {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtRatingRegionGpsLatitude is null)
					_IPTCExtRatingRegionGpsLatitude = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingRegionGPSLatitude")!;
				return _IPTCExtRatingRegionGpsLatitude;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtRatingRegionGpsLongitude;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingRegionGPSLongitude</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtRatingRegionGPSLongitude",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtRatingRegionGpsLongitude {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtRatingRegionGpsLongitude is null)
					_IPTCExtRatingRegionGpsLongitude = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingRegionGPSLongitude")!;
				return _IPTCExtRatingRegionGpsLongitude;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtRatingRegionIdentifier;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingRegionIdentifier</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtRatingRegionIdentifier",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtRatingRegionIdentifier {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtRatingRegionIdentifier is null)
					_IPTCExtRatingRegionIdentifier = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingRegionIdentifier")!;
				return _IPTCExtRatingRegionIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtRatingRegionLocationId;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingRegionLocationId</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtRatingRegionLocationId",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtRatingRegionLocationId {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtRatingRegionLocationId is null)
					_IPTCExtRatingRegionLocationId = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingRegionLocationId")!;
				return _IPTCExtRatingRegionLocationId;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtRatingRegionLocationName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingRegionLocationName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtRatingRegionLocationName",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtRatingRegionLocationName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtRatingRegionLocationName is null)
					_IPTCExtRatingRegionLocationName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingRegionLocationName")!;
				return _IPTCExtRatingRegionLocationName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtRatingRegionProvinceState;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingRegionProvinceState</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtRatingRegionProvinceState",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtRatingRegionProvinceState {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtRatingRegionProvinceState is null)
					_IPTCExtRatingRegionProvinceState = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingRegionProvinceState")!;
				return _IPTCExtRatingRegionProvinceState;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtRatingRegionSublocation;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingRegionSublocation</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtRatingRegionSublocation",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtRatingRegionSublocation {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtRatingRegionSublocation is null)
					_IPTCExtRatingRegionSublocation = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingRegionSublocation")!;
				return _IPTCExtRatingRegionSublocation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtRatingRegionWorldRegion;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingRegionWorldRegion</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtRatingRegionWorldRegion",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtRatingRegionWorldRegion {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtRatingRegionWorldRegion is null)
					_IPTCExtRatingRegionWorldRegion = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingRegionWorldRegion")!;
				return _IPTCExtRatingRegionWorldRegion;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtRatingScaleMaxValue;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingScaleMaxValue</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtRatingScaleMaxValue",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtRatingScaleMaxValue {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtRatingScaleMaxValue is null)
					_IPTCExtRatingScaleMaxValue = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingScaleMaxValue")!;
				return _IPTCExtRatingScaleMaxValue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtRatingScaleMinValue;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingScaleMinValue</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtRatingScaleMinValue",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtRatingScaleMinValue {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtRatingScaleMinValue is null)
					_IPTCExtRatingScaleMinValue = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingScaleMinValue")!;
				return _IPTCExtRatingScaleMinValue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtRatingSourceLink;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingSourceLink</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtRatingSourceLink",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtRatingSourceLink {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtRatingSourceLink is null)
					_IPTCExtRatingSourceLink = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingSourceLink")!;
				return _IPTCExtRatingSourceLink;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtRatingValue;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingValue</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtRatingValue",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtRatingValue {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtRatingValue is null)
					_IPTCExtRatingValue = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingValue")!;
				return _IPTCExtRatingValue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtRatingValueLogoLink;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingValueLogoLink</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtRatingValueLogoLink",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtRatingValueLogoLink {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtRatingValueLogoLink is null)
					_IPTCExtRatingValueLogoLink = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingValueLogoLink")!;
				return _IPTCExtRatingValueLogoLink;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtRegistryEntryRole;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRegistryEntryRole</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtRegistryEntryRole",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtRegistryEntryRole {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtRegistryEntryRole is null)
					_IPTCExtRegistryEntryRole = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRegistryEntryRole")!;
				return _IPTCExtRegistryEntryRole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtRegistryId;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRegistryID</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtRegistryID",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtRegistryId {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtRegistryId is null)
					_IPTCExtRegistryId = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRegistryID")!;
				return _IPTCExtRegistryId;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtRegistryItemId;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRegistryItemID</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtRegistryItemID",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtRegistryItemId {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtRegistryItemId is null)
					_IPTCExtRegistryItemId = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRegistryItemID")!;
				return _IPTCExtRegistryItemId;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtRegistryOrganisationId;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRegistryOrganisationID</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtRegistryOrganisationID",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtRegistryOrganisationId {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtRegistryOrganisationId is null)
					_IPTCExtRegistryOrganisationId = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRegistryOrganisationID")!;
				return _IPTCExtRegistryOrganisationId;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtReleaseReady;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtReleaseReady</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtReleaseReady",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtReleaseReady {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtReleaseReady is null)
					_IPTCExtReleaseReady = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtReleaseReady")!;
				return _IPTCExtReleaseReady;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtSeason;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtSeason</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtSeason",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtSeason {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtSeason is null)
					_IPTCExtSeason = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtSeason")!;
				return _IPTCExtSeason;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtSeasonIdentifier;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtSeasonIdentifier</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtSeasonIdentifier",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtSeasonIdentifier {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtSeasonIdentifier is null)
					_IPTCExtSeasonIdentifier = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtSeasonIdentifier")!;
				return _IPTCExtSeasonIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtSeasonName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtSeasonName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtSeasonName",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtSeasonName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtSeasonName is null)
					_IPTCExtSeasonName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtSeasonName")!;
				return _IPTCExtSeasonName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtSeasonNumber;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtSeasonNumber</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtSeasonNumber",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtSeasonNumber {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtSeasonNumber is null)
					_IPTCExtSeasonNumber = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtSeasonNumber")!;
				return _IPTCExtSeasonNumber;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtSeries;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtSeries</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtSeries",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtSeries {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtSeries is null)
					_IPTCExtSeries = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtSeries")!;
				return _IPTCExtSeries;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtSeriesIdentifier;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtSeriesIdentifier</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtSeriesIdentifier",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtSeriesIdentifier {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtSeriesIdentifier is null)
					_IPTCExtSeriesIdentifier = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtSeriesIdentifier")!;
				return _IPTCExtSeriesIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtSeriesName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtSeriesName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtSeriesName",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtSeriesName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtSeriesName is null)
					_IPTCExtSeriesName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtSeriesName")!;
				return _IPTCExtSeriesName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtShownEvent;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtShownEvent</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtShownEvent",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtShownEvent {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtShownEvent is null)
					_IPTCExtShownEvent = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtShownEvent")!;
				return _IPTCExtShownEvent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtShownEventIdentifier;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtShownEventIdentifier</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtShownEventIdentifier",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtShownEventIdentifier {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtShownEventIdentifier is null)
					_IPTCExtShownEventIdentifier = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtShownEventIdentifier")!;
				return _IPTCExtShownEventIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtShownEventName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtShownEventName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtShownEventName",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtShownEventName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtShownEventName is null)
					_IPTCExtShownEventName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtShownEventName")!;
				return _IPTCExtShownEventName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtStorylineIdentifier;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtStorylineIdentifier</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtStorylineIdentifier",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtStorylineIdentifier {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtStorylineIdentifier is null)
					_IPTCExtStorylineIdentifier = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtStorylineIdentifier")!;
				return _IPTCExtStorylineIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtStreamReady;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtStreamReady</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtStreamReady",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtStreamReady {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtStreamReady is null)
					_IPTCExtStreamReady = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtStreamReady")!;
				return _IPTCExtStreamReady;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtStylePeriod;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtStylePeriod</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtStylePeriod",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtStylePeriod {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtStylePeriod is null)
					_IPTCExtStylePeriod = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtStylePeriod")!;
				return _IPTCExtStylePeriod;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtSupplyChainSource;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtSupplyChainSource</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtSupplyChainSource",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtSupplyChainSource {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtSupplyChainSource is null)
					_IPTCExtSupplyChainSource = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtSupplyChainSource")!;
				return _IPTCExtSupplyChainSource;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtSupplyChainSourceIdentifier;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtSupplyChainSourceIdentifier</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtSupplyChainSourceIdentifier",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtSupplyChainSourceIdentifier {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtSupplyChainSourceIdentifier is null)
					_IPTCExtSupplyChainSourceIdentifier = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtSupplyChainSourceIdentifier")!;
				return _IPTCExtSupplyChainSourceIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtSupplyChainSourceName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtSupplyChainSourceName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtSupplyChainSourceName",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtSupplyChainSourceName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtSupplyChainSourceName is null)
					_IPTCExtSupplyChainSourceName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtSupplyChainSourceName")!;
				return _IPTCExtSupplyChainSourceName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtTemporalCoverage;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtTemporalCoverage</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtTemporalCoverage",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtTemporalCoverage {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtTemporalCoverage is null)
					_IPTCExtTemporalCoverage = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtTemporalCoverage")!;
				return _IPTCExtTemporalCoverage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtTemporalCoverageFrom;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtTemporalCoverageFrom</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtTemporalCoverageFrom",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtTemporalCoverageFrom {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtTemporalCoverageFrom is null)
					_IPTCExtTemporalCoverageFrom = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtTemporalCoverageFrom")!;
				return _IPTCExtTemporalCoverageFrom;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtTemporalCoverageTo;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtTemporalCoverageTo</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtTemporalCoverageTo",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtTemporalCoverageTo {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtTemporalCoverageTo is null)
					_IPTCExtTemporalCoverageTo = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtTemporalCoverageTo")!;
				return _IPTCExtTemporalCoverageTo;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtTranscript;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtTranscript</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtTranscript",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtTranscript {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtTranscript is null)
					_IPTCExtTranscript = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtTranscript")!;
				return _IPTCExtTranscript;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtTranscriptLink;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtTranscriptLink</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtTranscriptLink",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtTranscriptLink {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtTranscriptLink is null)
					_IPTCExtTranscriptLink = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtTranscriptLink")!;
				return _IPTCExtTranscriptLink;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtTranscriptLinkLink;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtTranscriptLinkLink</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtTranscriptLinkLink",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtTranscriptLinkLink {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtTranscriptLinkLink is null)
					_IPTCExtTranscriptLinkLink = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtTranscriptLinkLink")!;
				return _IPTCExtTranscriptLinkLink;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtTranscriptLinkLinkQualifier;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtTranscriptLinkLinkQualifier</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtTranscriptLinkLinkQualifier",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtTranscriptLinkLinkQualifier {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtTranscriptLinkLinkQualifier is null)
					_IPTCExtTranscriptLinkLinkQualifier = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtTranscriptLinkLinkQualifier")!;
				return _IPTCExtTranscriptLinkLinkQualifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtVideoBitrate;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtVideoBitrate</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtVideoBitrate",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtVideoBitrate {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtVideoBitrate is null)
					_IPTCExtVideoBitrate = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtVideoBitrate")!;
				return _IPTCExtVideoBitrate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtVideoBitrateMode;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtVideoBitrateMode</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtVideoBitrateMode",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtVideoBitrateMode {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtVideoBitrateMode is null)
					_IPTCExtVideoBitrateMode = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtVideoBitrateMode")!;
				return _IPTCExtVideoBitrateMode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtVideoDisplayAspectRatio;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtVideoDisplayAspectRatio</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtVideoDisplayAspectRatio",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtVideoDisplayAspectRatio {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtVideoDisplayAspectRatio is null)
					_IPTCExtVideoDisplayAspectRatio = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtVideoDisplayAspectRatio")!;
				return _IPTCExtVideoDisplayAspectRatio;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtVideoEncodingProfile;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtVideoEncodingProfile</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtVideoEncodingProfile",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtVideoEncodingProfile {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtVideoEncodingProfile is null)
					_IPTCExtVideoEncodingProfile = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtVideoEncodingProfile")!;
				return _IPTCExtVideoEncodingProfile;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtVideoShotType;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtVideoShotType</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtVideoShotType",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtVideoShotType {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtVideoShotType is null)
					_IPTCExtVideoShotType = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtVideoShotType")!;
				return _IPTCExtVideoShotType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtVideoShotTypeIdentifier;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtVideoShotTypeIdentifier</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtVideoShotTypeIdentifier",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtVideoShotTypeIdentifier {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtVideoShotTypeIdentifier is null)
					_IPTCExtVideoShotTypeIdentifier = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtVideoShotTypeIdentifier")!;
				return _IPTCExtVideoShotTypeIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtVideoShotTypeName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtVideoShotTypeName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtVideoShotTypeName",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtVideoShotTypeName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtVideoShotTypeName is null)
					_IPTCExtVideoShotTypeName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtVideoShotTypeName")!;
				return _IPTCExtVideoShotTypeName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtVideoStreamsCount;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtVideoStreamsCount</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtVideoStreamsCount",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtVideoStreamsCount {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtVideoStreamsCount is null)
					_IPTCExtVideoStreamsCount = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtVideoStreamsCount")!;
				return _IPTCExtVideoStreamsCount;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtVisualColor;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtVisualColor</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtVisualColor",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtVisualColor {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtVisualColor is null)
					_IPTCExtVisualColor = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtVisualColor")!;
				return _IPTCExtVisualColor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtWorkflowTag;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtWorkflowTag</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtWorkflowTag",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtWorkflowTag {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtWorkflowTag is null)
					_IPTCExtWorkflowTag = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtWorkflowTag")!;
				return _IPTCExtWorkflowTag;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtWorkflowTagCvId;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtWorkflowTagCvId</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtWorkflowTagCvId",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtWorkflowTagCvId {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtWorkflowTagCvId is null)
					_IPTCExtWorkflowTagCvId = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtWorkflowTagCvId")!;
				return _IPTCExtWorkflowTagCvId;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtWorkflowTagCvTermId;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtWorkflowTagCvTermId</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtWorkflowTagCvTermId",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtWorkflowTagCvTermId {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtWorkflowTagCvTermId is null)
					_IPTCExtWorkflowTagCvTermId = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtWorkflowTagCvTermId")!;
				return _IPTCExtWorkflowTagCvTermId;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtWorkflowTagCvTermName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtWorkflowTagCvTermName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtWorkflowTagCvTermName",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtWorkflowTagCvTermName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtWorkflowTagCvTermName is null)
					_IPTCExtWorkflowTagCvTermName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtWorkflowTagCvTermName")!;
				return _IPTCExtWorkflowTagCvTermName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCExtWorkflowTagCvTermRefinedAbout;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtWorkflowTagCvTermRefinedAbout</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCExtWorkflowTagCvTermRefinedAbout",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString IPTCExtWorkflowTagCvTermRefinedAbout {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_IPTCExtWorkflowTagCvTermRefinedAbout is null)
					_IPTCExtWorkflowTagCvTermRefinedAbout = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtWorkflowTagCvTermRefinedAbout")!;
				return _IPTCExtWorkflowTagCvTermRefinedAbout;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCFixtureIdentifier;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCFixtureIdentifier</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCFixtureIdentifier",  "ImageIO")]
		public static NSString IPTCFixtureIdentifier {
			get {
				if (_IPTCFixtureIdentifier is null)
					_IPTCFixtureIdentifier = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCFixtureIdentifier")!;
				return _IPTCFixtureIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCHeadline;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCHeadline</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCHeadline",  "ImageIO")]
		public static NSString IPTCHeadline {
			get {
				if (_IPTCHeadline is null)
					_IPTCHeadline = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCHeadline")!;
				return _IPTCHeadline;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCImageOrientation;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCImageOrientation</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCImageOrientation",  "ImageIO")]
		public static NSString IPTCImageOrientation {
			get {
				if (_IPTCImageOrientation is null)
					_IPTCImageOrientation = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCImageOrientation")!;
				return _IPTCImageOrientation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCImageType;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCImageType</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCImageType",  "ImageIO")]
		public static NSString IPTCImageType {
			get {
				if (_IPTCImageType is null)
					_IPTCImageType = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCImageType")!;
				return _IPTCImageType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCKeywords;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCKeywords</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCKeywords",  "ImageIO")]
		public static NSString IPTCKeywords {
			get {
				if (_IPTCKeywords is null)
					_IPTCKeywords = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCKeywords")!;
				return _IPTCKeywords;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCLanguageIdentifier;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCLanguageIdentifier</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCLanguageIdentifier",  "ImageIO")]
		public static NSString IPTCLanguageIdentifier {
			get {
				if (_IPTCLanguageIdentifier is null)
					_IPTCLanguageIdentifier = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCLanguageIdentifier")!;
				return _IPTCLanguageIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCObjectAttributeReference;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCObjectAttributeReference</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCObjectAttributeReference",  "ImageIO")]
		public static NSString IPTCObjectAttributeReference {
			get {
				if (_IPTCObjectAttributeReference is null)
					_IPTCObjectAttributeReference = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCObjectAttributeReference")!;
				return _IPTCObjectAttributeReference;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCObjectCycle;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCObjectCycle</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCObjectCycle",  "ImageIO")]
		public static NSString IPTCObjectCycle {
			get {
				if (_IPTCObjectCycle is null)
					_IPTCObjectCycle = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCObjectCycle")!;
				return _IPTCObjectCycle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCObjectName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCObjectName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCObjectName",  "ImageIO")]
		public static NSString IPTCObjectName {
			get {
				if (_IPTCObjectName is null)
					_IPTCObjectName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCObjectName")!;
				return _IPTCObjectName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCObjectTypeReference;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCObjectTypeReference</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCObjectTypeReference",  "ImageIO")]
		public static NSString IPTCObjectTypeReference {
			get {
				if (_IPTCObjectTypeReference is null)
					_IPTCObjectTypeReference = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCObjectTypeReference")!;
				return _IPTCObjectTypeReference;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCOriginalTransmissionReference;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCOriginalTransmissionReference</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCOriginalTransmissionReference",  "ImageIO")]
		public static NSString IPTCOriginalTransmissionReference {
			get {
				if (_IPTCOriginalTransmissionReference is null)
					_IPTCOriginalTransmissionReference = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCOriginalTransmissionReference")!;
				return _IPTCOriginalTransmissionReference;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCOriginatingProgram;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCOriginatingProgram</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCOriginatingProgram",  "ImageIO")]
		public static NSString IPTCOriginatingProgram {
			get {
				if (_IPTCOriginatingProgram is null)
					_IPTCOriginatingProgram = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCOriginatingProgram")!;
				return _IPTCOriginatingProgram;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCProgramVersion;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCProgramVersion</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCProgramVersion",  "ImageIO")]
		public static NSString IPTCProgramVersion {
			get {
				if (_IPTCProgramVersion is null)
					_IPTCProgramVersion = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCProgramVersion")!;
				return _IPTCProgramVersion;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCProvinceState;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCProvinceState</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCProvinceState",  "ImageIO")]
		public static NSString IPTCProvinceState {
			get {
				if (_IPTCProvinceState is null)
					_IPTCProvinceState = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCProvinceState")!;
				return _IPTCProvinceState;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCReferenceDate;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCReferenceDate</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCReferenceDate",  "ImageIO")]
		public static NSString IPTCReferenceDate {
			get {
				if (_IPTCReferenceDate is null)
					_IPTCReferenceDate = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCReferenceDate")!;
				return _IPTCReferenceDate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCReferenceNumber;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCReferenceNumber</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCReferenceNumber",  "ImageIO")]
		public static NSString IPTCReferenceNumber {
			get {
				if (_IPTCReferenceNumber is null)
					_IPTCReferenceNumber = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCReferenceNumber")!;
				return _IPTCReferenceNumber;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCReferenceService;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCReferenceService</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCReferenceService",  "ImageIO")]
		public static NSString IPTCReferenceService {
			get {
				if (_IPTCReferenceService is null)
					_IPTCReferenceService = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCReferenceService")!;
				return _IPTCReferenceService;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCReleaseDate;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCReleaseDate</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCReleaseDate",  "ImageIO")]
		public static NSString IPTCReleaseDate {
			get {
				if (_IPTCReleaseDate is null)
					_IPTCReleaseDate = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCReleaseDate")!;
				return _IPTCReleaseDate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCReleaseTime;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCReleaseTime</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCReleaseTime",  "ImageIO")]
		public static NSString IPTCReleaseTime {
			get {
				if (_IPTCReleaseTime is null)
					_IPTCReleaseTime = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCReleaseTime")!;
				return _IPTCReleaseTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCRightsUsageTerms;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCRightsUsageTerms</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCRightsUsageTerms",  "ImageIO")]
		public static NSString IPTCRightsUsageTerms {
			get {
				if (_IPTCRightsUsageTerms is null)
					_IPTCRightsUsageTerms = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCRightsUsageTerms")!;
				return _IPTCRightsUsageTerms;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCScene;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCScene</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCScene",  "ImageIO")]
		public static NSString IPTCScene {
			get {
				if (_IPTCScene is null)
					_IPTCScene = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCScene")!;
				return _IPTCScene;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCSource;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCSource</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCSource",  "ImageIO")]
		public static NSString IPTCSource {
			get {
				if (_IPTCSource is null)
					_IPTCSource = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCSource")!;
				return _IPTCSource;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCSpecialInstructions;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCSpecialInstructions</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCSpecialInstructions",  "ImageIO")]
		public static NSString IPTCSpecialInstructions {
			get {
				if (_IPTCSpecialInstructions is null)
					_IPTCSpecialInstructions = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCSpecialInstructions")!;
				return _IPTCSpecialInstructions;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCStarRating;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCStarRating</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCStarRating",  "ImageIO")]
		public static NSString IPTCStarRating {
			get {
				if (_IPTCStarRating is null)
					_IPTCStarRating = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCStarRating")!;
				return _IPTCStarRating;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCSubLocation;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCSubLocation</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCSubLocation",  "ImageIO")]
		public static NSString IPTCSubLocation {
			get {
				if (_IPTCSubLocation is null)
					_IPTCSubLocation = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCSubLocation")!;
				return _IPTCSubLocation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCSubjectReference;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCSubjectReference</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCSubjectReference",  "ImageIO")]
		public static NSString IPTCSubjectReference {
			get {
				if (_IPTCSubjectReference is null)
					_IPTCSubjectReference = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCSubjectReference")!;
				return _IPTCSubjectReference;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCSupplementalCategory;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCSupplementalCategory</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCSupplementalCategory",  "ImageIO")]
		public static NSString IPTCSupplementalCategory {
			get {
				if (_IPTCSupplementalCategory is null)
					_IPTCSupplementalCategory = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCSupplementalCategory")!;
				return _IPTCSupplementalCategory;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCTimeCreated;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCTimeCreated</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCTimeCreated",  "ImageIO")]
		public static NSString IPTCTimeCreated {
			get {
				if (_IPTCTimeCreated is null)
					_IPTCTimeCreated = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCTimeCreated")!;
				return _IPTCTimeCreated;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCUrgency;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCUrgency</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCUrgency",  "ImageIO")]
		public static NSString IPTCUrgency {
			get {
				if (_IPTCUrgency is null)
					_IPTCUrgency = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCUrgency")!;
				return _IPTCUrgency;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IPTCWriterEditor;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCWriterEditor</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIPTCWriterEditor",  "ImageIO")]
		public static NSString IPTCWriterEditor {
			get {
				if (_IPTCWriterEditor is null)
					_IPTCWriterEditor = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIPTCWriterEditor")!;
				return _IPTCWriterEditor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ImageCount;
		/// <summary>Represents the value associated with the constant kCGImagePropertyImageCount</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyImageCount",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ImageCount {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ImageCount is null)
					_ImageCount = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyImageCount")!;
				return _ImageCount;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ImageIndex;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyImageIndex'.</summary>
		[Field ("kCGImagePropertyImageIndex",  "ImageIO")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ImageIndex {
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ImageIndex is null)
					_ImageIndex = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyImageIndex")!;
				return _ImageIndex;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Images;
		/// <summary>Represents the value associated with the constant kCGImagePropertyImages</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyImages",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Images {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Images is null)
					_Images = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyImages")!;
				return _Images;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsFloat;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIsFloat</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIsFloat",  "ImageIO")]
		public static NSString IsFloat {
			get {
				if (_IsFloat is null)
					_IsFloat = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIsFloat")!;
				return _IsFloat;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsIndexed;
		/// <summary>Represents the value associated with the constant kCGImagePropertyIsIndexed</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyIsIndexed",  "ImageIO")]
		public static NSString IsIndexed {
			get {
				if (_IsIndexed is null)
					_IsIndexed = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyIsIndexed")!;
				return _IsIndexed;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _JFIFDensityUnit;
		/// <summary>Represents the value associated with the constant kCGImagePropertyJFIFDensityUnit</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyJFIFDensityUnit",  "ImageIO")]
		public static NSString JFIFDensityUnit {
			get {
				if (_JFIFDensityUnit is null)
					_JFIFDensityUnit = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyJFIFDensityUnit")!;
				return _JFIFDensityUnit;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _JFIFDictionary;
		/// <summary>Represents the value associated with the constant kCGImagePropertyJFIFDictionary</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyJFIFDictionary",  "ImageIO")]
		public static NSString JFIFDictionary {
			get {
				if (_JFIFDictionary is null)
					_JFIFDictionary = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyJFIFDictionary")!;
				return _JFIFDictionary;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _JFIFIsProgressive;
		/// <summary>Represents the value associated with the constant kCGImagePropertyJFIFIsProgressive</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyJFIFIsProgressive",  "ImageIO")]
		public static NSString JFIFIsProgressive {
			get {
				if (_JFIFIsProgressive is null)
					_JFIFIsProgressive = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyJFIFIsProgressive")!;
				return _JFIFIsProgressive;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _JFIFVersion;
		/// <summary>Represents the value associated with the constant kCGImagePropertyJFIFVersion</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyJFIFVersion",  "ImageIO")]
		public static NSString JFIFVersion {
			get {
				if (_JFIFVersion is null)
					_JFIFVersion = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyJFIFVersion")!;
				return _JFIFVersion;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _JFIFXDensity;
		/// <summary>Represents the value associated with the constant kCGImagePropertyJFIFXDensity</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyJFIFXDensity",  "ImageIO")]
		public static NSString JFIFXDensity {
			get {
				if (_JFIFXDensity is null)
					_JFIFXDensity = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyJFIFXDensity")!;
				return _JFIFXDensity;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _JFIFYDensity;
		/// <summary>Represents the value associated with the constant kCGImagePropertyJFIFYDensity</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyJFIFYDensity",  "ImageIO")]
		public static NSString JFIFYDensity {
			get {
				if (_JFIFYDensity is null)
					_JFIFYDensity = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyJFIFYDensity")!;
				return _JFIFYDensity;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MakerAppleDictionary;
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerAppleDictionary</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyMakerAppleDictionary",  "ImageIO")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString MakerAppleDictionary {
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_MakerAppleDictionary is null)
					_MakerAppleDictionary = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyMakerAppleDictionary")!;
				return _MakerAppleDictionary;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MakerCanonAspectRatioInfo;
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerCanonAspectRatioInfo</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyMakerCanonAspectRatioInfo",  "ImageIO")]
		public static NSString MakerCanonAspectRatioInfo {
			get {
				if (_MakerCanonAspectRatioInfo is null)
					_MakerCanonAspectRatioInfo = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyMakerCanonAspectRatioInfo")!;
				return _MakerCanonAspectRatioInfo;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MakerCanonCameraSerialNumber;
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerCanonCameraSerialNumber</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyMakerCanonCameraSerialNumber",  "ImageIO")]
		public static NSString MakerCanonCameraSerialNumber {
			get {
				if (_MakerCanonCameraSerialNumber is null)
					_MakerCanonCameraSerialNumber = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyMakerCanonCameraSerialNumber")!;
				return _MakerCanonCameraSerialNumber;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MakerCanonContinuousDrive;
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerCanonContinuousDrive</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyMakerCanonContinuousDrive",  "ImageIO")]
		public static NSString MakerCanonContinuousDrive {
			get {
				if (_MakerCanonContinuousDrive is null)
					_MakerCanonContinuousDrive = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyMakerCanonContinuousDrive")!;
				return _MakerCanonContinuousDrive;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MakerCanonDictionary;
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerCanonDictionary</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyMakerCanonDictionary",  "ImageIO")]
		public static NSString MakerCanonDictionary {
			get {
				if (_MakerCanonDictionary is null)
					_MakerCanonDictionary = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyMakerCanonDictionary")!;
				return _MakerCanonDictionary;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MakerCanonFirmware;
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerCanonFirmware</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyMakerCanonFirmware",  "ImageIO")]
		public static NSString MakerCanonFirmware {
			get {
				if (_MakerCanonFirmware is null)
					_MakerCanonFirmware = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyMakerCanonFirmware")!;
				return _MakerCanonFirmware;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MakerCanonFlashExposureComp;
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerCanonFlashExposureComp</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyMakerCanonFlashExposureComp",  "ImageIO")]
		public static NSString MakerCanonFlashExposureComp {
			get {
				if (_MakerCanonFlashExposureComp is null)
					_MakerCanonFlashExposureComp = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyMakerCanonFlashExposureComp")!;
				return _MakerCanonFlashExposureComp;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MakerCanonImageSerialNumber;
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerCanonImageSerialNumber</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyMakerCanonImageSerialNumber",  "ImageIO")]
		public static NSString MakerCanonImageSerialNumber {
			get {
				if (_MakerCanonImageSerialNumber is null)
					_MakerCanonImageSerialNumber = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyMakerCanonImageSerialNumber")!;
				return _MakerCanonImageSerialNumber;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MakerCanonLensModel;
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerCanonLensModel</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyMakerCanonLensModel",  "ImageIO")]
		public static NSString MakerCanonLensModel {
			get {
				if (_MakerCanonLensModel is null)
					_MakerCanonLensModel = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyMakerCanonLensModel")!;
				return _MakerCanonLensModel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MakerCanonOwnerName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerCanonOwnerName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyMakerCanonOwnerName",  "ImageIO")]
		public static NSString MakerCanonOwnerName {
			get {
				if (_MakerCanonOwnerName is null)
					_MakerCanonOwnerName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyMakerCanonOwnerName")!;
				return _MakerCanonOwnerName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MakerFujiDictionary;
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerFujiDictionary</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyMakerFujiDictionary",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString MakerFujiDictionary {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_MakerFujiDictionary is null)
					_MakerFujiDictionary = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyMakerFujiDictionary")!;
				return _MakerFujiDictionary;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MakerMinoltaDictionary;
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerMinoltaDictionary</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyMakerMinoltaDictionary",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString MakerMinoltaDictionary {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_MakerMinoltaDictionary is null)
					_MakerMinoltaDictionary = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyMakerMinoltaDictionary")!;
				return _MakerMinoltaDictionary;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MakerNikonCameraSerialNumber;
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonCameraSerialNumber</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyMakerNikonCameraSerialNumber",  "ImageIO")]
		public static NSString MakerNikonCameraSerialNumber {
			get {
				if (_MakerNikonCameraSerialNumber is null)
					_MakerNikonCameraSerialNumber = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonCameraSerialNumber")!;
				return _MakerNikonCameraSerialNumber;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MakerNikonColorMode;
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonColorMode</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyMakerNikonColorMode",  "ImageIO")]
		public static NSString MakerNikonColorMode {
			get {
				if (_MakerNikonColorMode is null)
					_MakerNikonColorMode = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonColorMode")!;
				return _MakerNikonColorMode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MakerNikonDictionary;
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonDictionary</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyMakerNikonDictionary",  "ImageIO")]
		public static NSString MakerNikonDictionary {
			get {
				if (_MakerNikonDictionary is null)
					_MakerNikonDictionary = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonDictionary")!;
				return _MakerNikonDictionary;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MakerNikonDigitalZoom;
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonDigitalZoom</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyMakerNikonDigitalZoom",  "ImageIO")]
		public static NSString MakerNikonDigitalZoom {
			get {
				if (_MakerNikonDigitalZoom is null)
					_MakerNikonDigitalZoom = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonDigitalZoom")!;
				return _MakerNikonDigitalZoom;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MakerNikonFlashExposureComp;
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonFlashExposureComp</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyMakerNikonFlashExposureComp",  "ImageIO")]
		public static NSString MakerNikonFlashExposureComp {
			get {
				if (_MakerNikonFlashExposureComp is null)
					_MakerNikonFlashExposureComp = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonFlashExposureComp")!;
				return _MakerNikonFlashExposureComp;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MakerNikonFlashSetting;
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonFlashSetting</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyMakerNikonFlashSetting",  "ImageIO")]
		public static NSString MakerNikonFlashSetting {
			get {
				if (_MakerNikonFlashSetting is null)
					_MakerNikonFlashSetting = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonFlashSetting")!;
				return _MakerNikonFlashSetting;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MakerNikonFocusDistance;
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonFocusDistance</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyMakerNikonFocusDistance",  "ImageIO")]
		public static NSString MakerNikonFocusDistance {
			get {
				if (_MakerNikonFocusDistance is null)
					_MakerNikonFocusDistance = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonFocusDistance")!;
				return _MakerNikonFocusDistance;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MakerNikonFocusMode;
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonFocusMode</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyMakerNikonFocusMode",  "ImageIO")]
		public static NSString MakerNikonFocusMode {
			get {
				if (_MakerNikonFocusMode is null)
					_MakerNikonFocusMode = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonFocusMode")!;
				return _MakerNikonFocusMode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MakerNikonISOSelection;
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonISOSelection</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyMakerNikonISOSelection",  "ImageIO")]
		public static NSString MakerNikonISOSelection {
			get {
				if (_MakerNikonISOSelection is null)
					_MakerNikonISOSelection = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonISOSelection")!;
				return _MakerNikonISOSelection;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MakerNikonISOSetting;
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonISOSetting</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyMakerNikonISOSetting",  "ImageIO")]
		public static NSString MakerNikonISOSetting {
			get {
				if (_MakerNikonISOSetting is null)
					_MakerNikonISOSetting = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonISOSetting")!;
				return _MakerNikonISOSetting;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MakerNikonImageAdjustment;
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonImageAdjustment</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyMakerNikonImageAdjustment",  "ImageIO")]
		public static NSString MakerNikonImageAdjustment {
			get {
				if (_MakerNikonImageAdjustment is null)
					_MakerNikonImageAdjustment = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonImageAdjustment")!;
				return _MakerNikonImageAdjustment;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MakerNikonLensAdapter;
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonLensAdapter</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyMakerNikonLensAdapter",  "ImageIO")]
		public static NSString MakerNikonLensAdapter {
			get {
				if (_MakerNikonLensAdapter is null)
					_MakerNikonLensAdapter = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonLensAdapter")!;
				return _MakerNikonLensAdapter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MakerNikonLensInfo;
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonLensInfo</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyMakerNikonLensInfo",  "ImageIO")]
		public static NSString MakerNikonLensInfo {
			get {
				if (_MakerNikonLensInfo is null)
					_MakerNikonLensInfo = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonLensInfo")!;
				return _MakerNikonLensInfo;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MakerNikonLensType;
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonLensType</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyMakerNikonLensType",  "ImageIO")]
		public static NSString MakerNikonLensType {
			get {
				if (_MakerNikonLensType is null)
					_MakerNikonLensType = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonLensType")!;
				return _MakerNikonLensType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MakerNikonQuality;
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonQuality</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyMakerNikonQuality",  "ImageIO")]
		public static NSString MakerNikonQuality {
			get {
				if (_MakerNikonQuality is null)
					_MakerNikonQuality = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonQuality")!;
				return _MakerNikonQuality;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MakerNikonSharpenMode;
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonSharpenMode</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyMakerNikonSharpenMode",  "ImageIO")]
		public static NSString MakerNikonSharpenMode {
			get {
				if (_MakerNikonSharpenMode is null)
					_MakerNikonSharpenMode = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonSharpenMode")!;
				return _MakerNikonSharpenMode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MakerNikonShootingMode;
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonShootingMode</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyMakerNikonShootingMode",  "ImageIO")]
		public static NSString MakerNikonShootingMode {
			get {
				if (_MakerNikonShootingMode is null)
					_MakerNikonShootingMode = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonShootingMode")!;
				return _MakerNikonShootingMode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MakerNikonShutterCount;
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonShutterCount</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyMakerNikonShutterCount",  "ImageIO")]
		public static NSString MakerNikonShutterCount {
			get {
				if (_MakerNikonShutterCount is null)
					_MakerNikonShutterCount = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonShutterCount")!;
				return _MakerNikonShutterCount;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MakerNikonWhiteBalanceMode;
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonWhiteBalanceMode</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyMakerNikonWhiteBalanceMode",  "ImageIO")]
		public static NSString MakerNikonWhiteBalanceMode {
			get {
				if (_MakerNikonWhiteBalanceMode is null)
					_MakerNikonWhiteBalanceMode = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonWhiteBalanceMode")!;
				return _MakerNikonWhiteBalanceMode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MakerOlympusDictionary;
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerOlympusDictionary</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyMakerOlympusDictionary",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString MakerOlympusDictionary {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_MakerOlympusDictionary is null)
					_MakerOlympusDictionary = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyMakerOlympusDictionary")!;
				return _MakerOlympusDictionary;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MakerPentaxDictionary;
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerPentaxDictionary</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyMakerPentaxDictionary",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString MakerPentaxDictionary {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_MakerPentaxDictionary is null)
					_MakerPentaxDictionary = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyMakerPentaxDictionary")!;
				return _MakerPentaxDictionary;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NamedColorSpace;
		/// <summary>Represents the value associated with the constant kCGImagePropertyNamedColorSpace</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyNamedColorSpace",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString NamedColorSpace {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_NamedColorSpace is null)
					_NamedColorSpace = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyNamedColorSpace")!;
				return _NamedColorSpace;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OpenExrAspectRatio;
		/// <summary>Represents the value associated with the constant kCGImagePropertyOpenEXRAspectRatio</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyOpenEXRAspectRatio",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString OpenExrAspectRatio {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_OpenExrAspectRatio is null)
					_OpenExrAspectRatio = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyOpenEXRAspectRatio")!;
				return _OpenExrAspectRatio;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OpenExrCompression;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyOpenEXRCompression'.</summary>
		[Field ("kCGImagePropertyOpenEXRCompression",  "ImageIO")]
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("macos13.3")]
		[SupportedOSPlatform ("tvos16.4")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		public static NSString OpenExrCompression {
			[SupportedOSPlatform ("ios16.4")]
			[SupportedOSPlatform ("macos13.3")]
			[SupportedOSPlatform ("tvos16.4")]
			[SupportedOSPlatform ("maccatalyst16.4")]
			get {
				if (_OpenExrCompression is null)
					_OpenExrCompression = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyOpenEXRCompression")!;
				return _OpenExrCompression;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OpenExrDictionary;
		/// <summary>Represents the value associated with the constant kCGImagePropertyOpenEXRDictionary</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyOpenEXRDictionary",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString OpenExrDictionary {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_OpenExrDictionary is null)
					_OpenExrDictionary = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyOpenEXRDictionary")!;
				return _OpenExrDictionary;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Orientation;
		/// <summary>Represents the value associated with the constant kCGImagePropertyOrientation</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyOrientation",  "ImageIO")]
		public static NSString Orientation {
			get {
				if (_Orientation is null)
					_Orientation = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyOrientation")!;
				return _Orientation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PNGAuthor;
		/// <summary>Represents the value associated with the constant kCGImagePropertyPNGAuthor</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyPNGAuthor",  "ImageIO")]
		public static NSString PNGAuthor {
			get {
				if (_PNGAuthor is null)
					_PNGAuthor = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyPNGAuthor")!;
				return _PNGAuthor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PNGChromaticities;
		/// <summary>Represents the value associated with the constant kCGImagePropertyPNGChromaticities</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyPNGChromaticities",  "ImageIO")]
		public static NSString PNGChromaticities {
			get {
				if (_PNGChromaticities is null)
					_PNGChromaticities = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyPNGChromaticities")!;
				return _PNGChromaticities;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PNGComment;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyPNGComment",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString PNGComment {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_PNGComment is null)
					_PNGComment = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyPNGComment")!;
				return _PNGComment;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PNGCompressionFilter;
		/// <summary>Represents the value associated with the constant kCGImagePropertyPNGCompressionFilter.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyPNGCompressionFilter",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString PNGCompressionFilter {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_PNGCompressionFilter is null)
					_PNGCompressionFilter = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyPNGCompressionFilter")!;
				return _PNGCompressionFilter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PNGCopyright;
		/// <summary>Represents the value associated with the constant kCGImagePropertyPNGCopyright</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyPNGCopyright",  "ImageIO")]
		public static NSString PNGCopyright {
			get {
				if (_PNGCopyright is null)
					_PNGCopyright = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyPNGCopyright")!;
				return _PNGCopyright;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PNGCreationTime;
		/// <summary>Represents the value associated with the constant kCGImagePropertyPNGCreationTime</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyPNGCreationTime",  "ImageIO")]
		public static NSString PNGCreationTime {
			get {
				if (_PNGCreationTime is null)
					_PNGCreationTime = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyPNGCreationTime")!;
				return _PNGCreationTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PNGDelayTime;
		/// <summary>Represents the value associated with the constant kCGImagePropertyAPNGDelayTime</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyAPNGDelayTime",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString PNGDelayTime {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_PNGDelayTime is null)
					_PNGDelayTime = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyAPNGDelayTime")!;
				return _PNGDelayTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PNGDescription;
		/// <summary>Represents the value associated with the constant kCGImagePropertyPNGDescription</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyPNGDescription",  "ImageIO")]
		public static NSString PNGDescription {
			get {
				if (_PNGDescription is null)
					_PNGDescription = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyPNGDescription")!;
				return _PNGDescription;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PNGDictionary;
		/// <summary>Represents the value associated with the constant kCGImagePropertyPNGDictionary</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyPNGDictionary",  "ImageIO")]
		public static NSString PNGDictionary {
			get {
				if (_PNGDictionary is null)
					_PNGDictionary = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyPNGDictionary")!;
				return _PNGDictionary;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PNGDisclaimer;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyPNGDisclaimer",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString PNGDisclaimer {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_PNGDisclaimer is null)
					_PNGDisclaimer = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyPNGDisclaimer")!;
				return _PNGDisclaimer;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PNGGamma;
		/// <summary>Represents the value associated with the constant kCGImagePropertyPNGGamma</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyPNGGamma",  "ImageIO")]
		public static NSString PNGGamma {
			get {
				if (_PNGGamma is null)
					_PNGGamma = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyPNGGamma")!;
				return _PNGGamma;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PNGInterlaceType;
		/// <summary>Represents the value associated with the constant kCGImagePropertyPNGInterlaceType</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyPNGInterlaceType",  "ImageIO")]
		public static NSString PNGInterlaceType {
			get {
				if (_PNGInterlaceType is null)
					_PNGInterlaceType = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyPNGInterlaceType")!;
				return _PNGInterlaceType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PNGLoopCount;
		/// <summary>Represents the value associated with the constant kCGImagePropertyAPNGLoopCount</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyAPNGLoopCount",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString PNGLoopCount {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_PNGLoopCount is null)
					_PNGLoopCount = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyAPNGLoopCount")!;
				return _PNGLoopCount;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PNGModificationTime;
		/// <summary>Represents the value associated with the constant kCGImagePropertyPNGModificationTime</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyPNGModificationTime",  "ImageIO")]
		public static NSString PNGModificationTime {
			get {
				if (_PNGModificationTime is null)
					_PNGModificationTime = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyPNGModificationTime")!;
				return _PNGModificationTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PNGPixelsAspectRatio;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyPNGPixelsAspectRatio'.</summary>
		[Field ("kCGImagePropertyPNGPixelsAspectRatio",  "ImageIO")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString PNGPixelsAspectRatio {
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_PNGPixelsAspectRatio is null)
					_PNGPixelsAspectRatio = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyPNGPixelsAspectRatio")!;
				return _PNGPixelsAspectRatio;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PNGSoftware;
		/// <summary>Represents the value associated with the constant kCGImagePropertyPNGSoftware</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyPNGSoftware",  "ImageIO")]
		public static NSString PNGSoftware {
			get {
				if (_PNGSoftware is null)
					_PNGSoftware = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyPNGSoftware")!;
				return _PNGSoftware;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PNGSource;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyPNGSource",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString PNGSource {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_PNGSource is null)
					_PNGSource = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyPNGSource")!;
				return _PNGSource;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PNGTitle;
		/// <summary>Represents the value associated with the constant kCGImagePropertyPNGTitle</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyPNGTitle",  "ImageIO")]
		public static NSString PNGTitle {
			get {
				if (_PNGTitle is null)
					_PNGTitle = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyPNGTitle")!;
				return _PNGTitle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PNGTransparency;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyPNGTransparency'.</summary>
		[Field ("kCGImagePropertyPNGTransparency",  "ImageIO")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString PNGTransparency {
			[SupportedOSPlatform ("tvos14.5")]
			[SupportedOSPlatform ("ios14.5")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_PNGTransparency is null)
					_PNGTransparency = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyPNGTransparency")!;
				return _PNGTransparency;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PNGUnclampedDelayTime;
		/// <summary>Represents the value associated with the constant kCGImagePropertyAPNGUnclampedDelayTime</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyAPNGUnclampedDelayTime",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString PNGUnclampedDelayTime {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_PNGUnclampedDelayTime is null)
					_PNGUnclampedDelayTime = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyAPNGUnclampedDelayTime")!;
				return _PNGUnclampedDelayTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PNGWarning;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyPNGWarning",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString PNGWarning {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_PNGWarning is null)
					_PNGWarning = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyPNGWarning")!;
				return _PNGWarning;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PNGXPixelsPerMeter;
		/// <summary>Represents the value associated with the constant kCGImagePropertyPNGXPixelsPerMeter</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyPNGXPixelsPerMeter",  "ImageIO")]
		public static NSString PNGXPixelsPerMeter {
			get {
				if (_PNGXPixelsPerMeter is null)
					_PNGXPixelsPerMeter = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyPNGXPixelsPerMeter")!;
				return _PNGXPixelsPerMeter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PNGYPixelsPerMeter;
		/// <summary>Represents the value associated with the constant kCGImagePropertyPNGYPixelsPerMeter</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyPNGYPixelsPerMeter",  "ImageIO")]
		public static NSString PNGYPixelsPerMeter {
			get {
				if (_PNGYPixelsPerMeter is null)
					_PNGYPixelsPerMeter = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyPNGYPixelsPerMeter")!;
				return _PNGYPixelsPerMeter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PNGsRGBIntent;
		/// <summary>Represents the value associated with the constant kCGImagePropertyPNGsRGBIntent</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyPNGsRGBIntent",  "ImageIO")]
		public static NSString PNGsRGBIntent {
			get {
				if (_PNGsRGBIntent is null)
					_PNGsRGBIntent = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyPNGsRGBIntent")!;
				return _PNGsRGBIntent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PixelFormat;
		/// <summary>Represents the value associated with the constant kCGImagePropertyPixelFormat</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyPixelFormat",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString PixelFormat {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_PixelFormat is null)
					_PixelFormat = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyPixelFormat")!;
				return _PixelFormat;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PixelHeight;
		/// <summary>Represents the value associated with the constant kCGImagePropertyPixelHeight</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyPixelHeight",  "ImageIO")]
		public static NSString PixelHeight {
			get {
				if (_PixelHeight is null)
					_PixelHeight = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyPixelHeight")!;
				return _PixelHeight;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PixelWidth;
		/// <summary>Represents the value associated with the constant kCGImagePropertyPixelWidth</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyPixelWidth",  "ImageIO")]
		public static NSString PixelWidth {
			get {
				if (_PixelWidth is null)
					_PixelWidth = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyPixelWidth")!;
				return _PixelWidth;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PrimaryImage;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyPrimaryImage",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString PrimaryImage {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_PrimaryImage is null)
					_PrimaryImage = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyPrimaryImage")!;
				return _PrimaryImage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProfileName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyProfileName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyProfileName",  "ImageIO")]
		public static NSString ProfileName {
			get {
				if (_ProfileName is null)
					_ProfileName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyProfileName")!;
				return _ProfileName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RawDictionary;
		/// <summary>Represents the value associated with the constant kCGImagePropertyRawDictionary</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyRawDictionary",  "ImageIO")]
		public static NSString RawDictionary {
			get {
				if (_RawDictionary is null)
					_RawDictionary = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyRawDictionary")!;
				return _RawDictionary;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TIFFArtist;
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFArtist</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyTIFFArtist",  "ImageIO")]
		public static NSString TIFFArtist {
			get {
				if (_TIFFArtist is null)
					_TIFFArtist = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyTIFFArtist")!;
				return _TIFFArtist;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TIFFCompression;
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFCompression</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyTIFFCompression",  "ImageIO")]
		public static NSString TIFFCompression {
			get {
				if (_TIFFCompression is null)
					_TIFFCompression = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyTIFFCompression")!;
				return _TIFFCompression;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TIFFDateTime;
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFDateTime</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyTIFFDateTime",  "ImageIO")]
		public static NSString TIFFDateTime {
			get {
				if (_TIFFDateTime is null)
					_TIFFDateTime = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyTIFFDateTime")!;
				return _TIFFDateTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TIFFDictionary;
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFDictionary</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyTIFFDictionary",  "ImageIO")]
		public static NSString TIFFDictionary {
			get {
				if (_TIFFDictionary is null)
					_TIFFDictionary = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyTIFFDictionary")!;
				return _TIFFDictionary;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TIFFDocumentName;
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFDocumentName</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyTIFFDocumentName",  "ImageIO")]
		public static NSString TIFFDocumentName {
			get {
				if (_TIFFDocumentName is null)
					_TIFFDocumentName = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyTIFFDocumentName")!;
				return _TIFFDocumentName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TIFFHostComputer;
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFHostComputer</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyTIFFHostComputer",  "ImageIO")]
		public static NSString TIFFHostComputer {
			get {
				if (_TIFFHostComputer is null)
					_TIFFHostComputer = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyTIFFHostComputer")!;
				return _TIFFHostComputer;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TIFFImageDescription;
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFImageDescription</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyTIFFImageDescription",  "ImageIO")]
		public static NSString TIFFImageDescription {
			get {
				if (_TIFFImageDescription is null)
					_TIFFImageDescription = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyTIFFImageDescription")!;
				return _TIFFImageDescription;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TIFFMake;
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFMake</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyTIFFMake",  "ImageIO")]
		public static NSString TIFFMake {
			get {
				if (_TIFFMake is null)
					_TIFFMake = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyTIFFMake")!;
				return _TIFFMake;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TIFFModel;
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFModel</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyTIFFModel",  "ImageIO")]
		public static NSString TIFFModel {
			get {
				if (_TIFFModel is null)
					_TIFFModel = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyTIFFModel")!;
				return _TIFFModel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TIFFOrientation;
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFOrientation</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyTIFFOrientation",  "ImageIO")]
		public static NSString TIFFOrientation {
			get {
				if (_TIFFOrientation is null)
					_TIFFOrientation = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyTIFFOrientation")!;
				return _TIFFOrientation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TIFFPhotometricInterpretation;
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFPhotometricInterpretation</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyTIFFPhotometricInterpretation",  "ImageIO")]
		public static NSString TIFFPhotometricInterpretation {
			get {
				if (_TIFFPhotometricInterpretation is null)
					_TIFFPhotometricInterpretation = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyTIFFPhotometricInterpretation")!;
				return _TIFFPhotometricInterpretation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TIFFPrimaryChromaticities;
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFPrimaryChromaticities</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyTIFFPrimaryChromaticities",  "ImageIO")]
		public static NSString TIFFPrimaryChromaticities {
			get {
				if (_TIFFPrimaryChromaticities is null)
					_TIFFPrimaryChromaticities = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyTIFFPrimaryChromaticities")!;
				return _TIFFPrimaryChromaticities;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TIFFResolutionUnit;
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFResolutionUnit</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyTIFFResolutionUnit",  "ImageIO")]
		public static NSString TIFFResolutionUnit {
			get {
				if (_TIFFResolutionUnit is null)
					_TIFFResolutionUnit = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyTIFFResolutionUnit")!;
				return _TIFFResolutionUnit;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TIFFSoftware;
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFSoftware</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyTIFFSoftware",  "ImageIO")]
		public static NSString TIFFSoftware {
			get {
				if (_TIFFSoftware is null)
					_TIFFSoftware = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyTIFFSoftware")!;
				return _TIFFSoftware;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TIFFTileLength;
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFTileLength.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyTIFFTileLength",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString TIFFTileLength {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_TIFFTileLength is null)
					_TIFFTileLength = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyTIFFTileLength")!;
				return _TIFFTileLength;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TIFFTileWidth;
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFTileWidth.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyTIFFTileWidth",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString TIFFTileWidth {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_TIFFTileWidth is null)
					_TIFFTileWidth = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyTIFFTileWidth")!;
				return _TIFFTileWidth;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TIFFTransferFunction;
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFTransferFunction</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyTIFFTransferFunction",  "ImageIO")]
		public static NSString TIFFTransferFunction {
			get {
				if (_TIFFTransferFunction is null)
					_TIFFTransferFunction = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyTIFFTransferFunction")!;
				return _TIFFTransferFunction;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TIFFWhitePoint;
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFWhitePoint</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyTIFFWhitePoint",  "ImageIO")]
		public static NSString TIFFWhitePoint {
			get {
				if (_TIFFWhitePoint is null)
					_TIFFWhitePoint = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyTIFFWhitePoint")!;
				return _TIFFWhitePoint;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TIFFXPosition;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyTIFFXPosition'.</summary>
		[Field ("kCGImagePropertyTIFFXPosition",  "ImageIO")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[SupportedOSPlatform ("tvos17.4")]
		public static NSString TIFFXPosition {
			[SupportedOSPlatform ("macos14.4")]
			[SupportedOSPlatform ("ios17.4")]
			[SupportedOSPlatform ("maccatalyst17.4")]
			[SupportedOSPlatform ("tvos17.4")]
			get {
				if (_TIFFXPosition is null)
					_TIFFXPosition = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyTIFFXPosition")!;
				return _TIFFXPosition;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TIFFXResolution;
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFXResolution</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyTIFFXResolution",  "ImageIO")]
		public static NSString TIFFXResolution {
			get {
				if (_TIFFXResolution is null)
					_TIFFXResolution = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyTIFFXResolution")!;
				return _TIFFXResolution;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TIFFYPosition;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyTIFFYPosition'.</summary>
		[Field ("kCGImagePropertyTIFFYPosition",  "ImageIO")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[SupportedOSPlatform ("tvos17.4")]
		public static NSString TIFFYPosition {
			[SupportedOSPlatform ("macos14.4")]
			[SupportedOSPlatform ("ios17.4")]
			[SupportedOSPlatform ("maccatalyst17.4")]
			[SupportedOSPlatform ("tvos17.4")]
			get {
				if (_TIFFYPosition is null)
					_TIFFYPosition = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyTIFFYPosition")!;
				return _TIFFYPosition;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TIFFYResolution;
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFYResolution</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyTIFFYResolution",  "ImageIO")]
		public static NSString TIFFYResolution {
			get {
				if (_TIFFYResolution is null)
					_TIFFYResolution = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyTIFFYResolution")!;
				return _TIFFYResolution;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TgaCompression;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyTGACompression'.</summary>
		[Field ("kCGImagePropertyTGACompression",  "ImageIO")]
		[SupportedOSPlatform ("ios14.1")]
		[SupportedOSPlatform ("tvos14.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString TgaCompression {
			[SupportedOSPlatform ("ios14.1")]
			[SupportedOSPlatform ("tvos14.2")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_TgaCompression is null)
					_TgaCompression = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyTGACompression")!;
				return _TgaCompression;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TgaDictionary;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyTGADictionary'.</summary>
		[Field ("kCGImagePropertyTGADictionary",  "ImageIO")]
		[SupportedOSPlatform ("ios14.1")]
		[SupportedOSPlatform ("tvos14.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString TgaDictionary {
			[SupportedOSPlatform ("ios14.1")]
			[SupportedOSPlatform ("tvos14.2")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_TgaDictionary is null)
					_TgaDictionary = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyTGADictionary")!;
				return _TgaDictionary;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ThumbnailImages;
		/// <summary>Represents the value associated with the constant kCGImagePropertyThumbnailImages</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyThumbnailImages",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ThumbnailImages {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ThumbnailImages is null)
					_ThumbnailImages = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyThumbnailImages")!;
				return _ThumbnailImages;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WebPCanvasPixelHeight;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyWebPCanvasPixelHeight'.</summary>
		[Field ("kCGImagePropertyWebPCanvasPixelHeight",  "ImageIO")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString WebPCanvasPixelHeight {
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_WebPCanvasPixelHeight is null)
					_WebPCanvasPixelHeight = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyWebPCanvasPixelHeight")!;
				return _WebPCanvasPixelHeight;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WebPCanvasPixelWidth;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyWebPCanvasPixelWidth'.</summary>
		[Field ("kCGImagePropertyWebPCanvasPixelWidth",  "ImageIO")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString WebPCanvasPixelWidth {
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_WebPCanvasPixelWidth is null)
					_WebPCanvasPixelWidth = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyWebPCanvasPixelWidth")!;
				return _WebPCanvasPixelWidth;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WebPDelayTime;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyWebPDelayTime'.</summary>
		[Field ("kCGImagePropertyWebPDelayTime",  "ImageIO")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString WebPDelayTime {
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_WebPDelayTime is null)
					_WebPDelayTime = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyWebPDelayTime")!;
				return _WebPDelayTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WebPDictionary;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyWebPDictionary'.</summary>
		[Field ("kCGImagePropertyWebPDictionary",  "ImageIO")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString WebPDictionary {
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_WebPDictionary is null)
					_WebPDictionary = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyWebPDictionary")!;
				return _WebPDictionary;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WebPFrameInfoArray;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyWebPFrameInfoArray'.</summary>
		[Field ("kCGImagePropertyWebPFrameInfoArray",  "ImageIO")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString WebPFrameInfoArray {
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_WebPFrameInfoArray is null)
					_WebPFrameInfoArray = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyWebPFrameInfoArray")!;
				return _WebPFrameInfoArray;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WebPLoopCount;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyWebPLoopCount'.</summary>
		[Field ("kCGImagePropertyWebPLoopCount",  "ImageIO")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString WebPLoopCount {
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_WebPLoopCount is null)
					_WebPLoopCount = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyWebPLoopCount")!;
				return _WebPLoopCount;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WebPUnclampedDelayTime;
		/// <summary>Represents the value associated with the constant 'kCGImagePropertyWebPUnclampedDelayTime'.</summary>
		[Field ("kCGImagePropertyWebPUnclampedDelayTime",  "ImageIO")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString WebPUnclampedDelayTime {
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_WebPUnclampedDelayTime is null)
					_WebPUnclampedDelayTime = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyWebPUnclampedDelayTime")!;
				return _WebPUnclampedDelayTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Width;
		/// <summary>Represents the value associated with the constant kCGImagePropertyWidth</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGImagePropertyWidth",  "ImageIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Width {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Width is null)
					_Width = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImagePropertyWidth")!;
				return _Width;
			}
		}
	} /* class CGImageProperties */
}
