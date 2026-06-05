//
// ImageIO.cs : Constants
//
// Authors:
//	Sebastien Pouliot  <sebastien@xamarin.com>
//
// Copyright 2012-2014, Xamarin, Inc.
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using CoreFoundation;
using CoreGraphics;

namespace ImageIO {

	/// <summary>Known properties of various metadata prefixes. Most often used with <see cref="ImageIO.CGImageMetadata.CopyTagMatchingImageProperty(Foundation.NSString,Foundation.NSString)" />.</summary>
	[Static]
	// Bad name should end with Keys
	interface CGImageProperties {
		// Format-Specific Dictionaries
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFDictionary</summary>
		[Field ("kCGImagePropertyTIFFDictionary")]
		NSString TIFFDictionary { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGIFDictionary</summary>
		[Field ("kCGImagePropertyGIFDictionary")]
		NSString GIFDictionary { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyJFIFDictionary</summary>
		[Field ("kCGImagePropertyJFIFDictionary")]
		NSString JFIFDictionary { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifDictionary</summary>
		[Field ("kCGImagePropertyExifDictionary")]
		NSString ExifDictionary { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyPNGDictionary</summary>
		[Field ("kCGImagePropertyPNGDictionary")]
		NSString PNGDictionary { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCDictionary</summary>
		[Field ("kCGImagePropertyIPTCDictionary")]
		NSString IPTCDictionary { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSDictionary</summary>
		[Field ("kCGImagePropertyGPSDictionary")]
		NSString GPSDictionary { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyRawDictionary</summary>
		[Field ("kCGImagePropertyRawDictionary")]
		NSString RawDictionary { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFDictionary</summary>
		[Field ("kCGImagePropertyCIFFDictionary")]
		NSString CIFFDictionary { get; }
		/// <summary>Represents the value associated with the constant kCGImageProperty8BIMDictionary</summary>
		[Field ("kCGImageProperty8BIMDictionary")]
		NSString EightBIMDictionary { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGDictionary</summary>
		[Field ("kCGImagePropertyDNGDictionary")]
		NSString DNGDictionary { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifAuxDictionary</summary>
		[Field ("kCGImagePropertyExifAuxDictionary")]
		NSString ExifAuxDictionary { get; }

		[iOS (13, 0)]
		[TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyHEICSDictionary")]
		NSString HeicsDictionary { get; }

		[iOS (14, 0), TV (14, 0)]
		[MacCatalyst (14, 0)]
		[Field ("kCGImagePropertyWebPDictionary")]
		NSString WebPDictionary { get; }

		[iOS (14, 1), TV (14, 2)]
		[MacCatalyst (14, 1)]
		[Field ("kCGImagePropertyTGADictionary")]
		NSString TgaDictionary { get; }

		[Mac (14, 0), iOS (17, 0), TV (17, 0), MacCatalyst (17, 0)]
		[Field ("kCGImagePropertyAVISDictionary")]
		NSString AvisDictionary { get; }

		// Camera-Maker Dictionaries
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerCanonDictionary</summary>
		[Field ("kCGImagePropertyMakerCanonDictionary")]
		NSString MakerCanonDictionary { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonDictionary</summary>
		[Field ("kCGImagePropertyMakerNikonDictionary")]
		NSString MakerNikonDictionary { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerMinoltaDictionary</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyMakerMinoltaDictionary")]
		NSString MakerMinoltaDictionary { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerFujiDictionary</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyMakerFujiDictionary")]
		NSString MakerFujiDictionary { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerOlympusDictionary</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyMakerOlympusDictionary")]
		NSString MakerOlympusDictionary { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerPentaxDictionary</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyMakerPentaxDictionary")]
		NSString MakerPentaxDictionary { get; }

		// Image Source Container Properties
		/// <summary>Represents the value associated with the constant kCGImagePropertyFileSize</summary>
		[Field ("kCGImagePropertyFileSize")]
		NSString FileSize { get; }

		// Individual Image Properties
		/// <summary>Represents the value associated with the constant kCGImagePropertyDPIHeight</summary>
		[Field ("kCGImagePropertyDPIHeight")]
		NSString DPIHeight { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyDPIWidth</summary>
		[Field ("kCGImagePropertyDPIWidth")]
		NSString DPIWidth { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyPixelWidth</summary>
		[Field ("kCGImagePropertyPixelWidth")]
		NSString PixelWidth { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyPixelHeight</summary>
		[Field ("kCGImagePropertyPixelHeight")]
		NSString PixelHeight { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyDepth</summary>
		[Field ("kCGImagePropertyDepth")]
		NSString Depth { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyOrientation</summary>
		[Field ("kCGImagePropertyOrientation")]
		NSString Orientation { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIsFloat</summary>
		[Field ("kCGImagePropertyIsFloat")]
		NSString IsFloat { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIsIndexed</summary>
		[Field ("kCGImagePropertyIsIndexed")]
		NSString IsIndexed { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyHasAlpha</summary>
		[Field ("kCGImagePropertyHasAlpha")]
		NSString HasAlpha { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyColorModel</summary>
		[Field ("kCGImagePropertyColorModel")]
		NSString ColorModel { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyProfileName</summary>
		[Field ("kCGImagePropertyProfileName")]
		NSString ProfileName { get; }

		// Color Model Values

		/// <summary>Represents the value associated with the constant kCGImagePropertyColorModelRGB</summary>
		[Field ("kCGImagePropertyColorModelRGB")]
		NSString ColorModelRGB { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyColorModelGray</summary>
		[Field ("kCGImagePropertyColorModelGray")]
		NSString ColorModelGray { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyColorModelCMYK</summary>
		[Field ("kCGImagePropertyColorModelCMYK")]
		NSString ColorModelCMYK { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyColorModelLab</summary>
		[Field ("kCGImagePropertyColorModelLab")]
		NSString ColorModelLab { get; }

		// EXIF Dictionary Keys

		/// <summary>Represents the value associated with the constant kCGImagePropertyExifExposureTime</summary>
		[Field ("kCGImagePropertyExifExposureTime")]
		NSString ExifExposureTime { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifFNumber</summary>
		[Field ("kCGImagePropertyExifFNumber")]
		NSString ExifFNumber { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifExposureProgram</summary>
		[Field ("kCGImagePropertyExifExposureProgram")]
		NSString ExifExposureProgram { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifSpectralSensitivity</summary>
		[Field ("kCGImagePropertyExifSpectralSensitivity")]
		NSString ExifSpectralSensitivity { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifISOSpeedRatings</summary>
		[Field ("kCGImagePropertyExifISOSpeedRatings")]
		NSString ExifISOSpeedRatings { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifOECF</summary>
		[Field ("kCGImagePropertyExifOECF")]
		NSString ExifOECF { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifVersion</summary>
		[Field ("kCGImagePropertyExifVersion")]
		NSString ExifVersion { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifDateTimeOriginal</summary>
		[Field ("kCGImagePropertyExifDateTimeOriginal")]
		NSString ExifDateTimeOriginal { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifDateTimeDigitized</summary>
		[Field ("kCGImagePropertyExifDateTimeDigitized")]
		NSString ExifDateTimeDigitized { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifComponentsConfiguration</summary>
		[Field ("kCGImagePropertyExifComponentsConfiguration")]
		NSString ExifComponentsConfiguration { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifCompressedBitsPerPixel</summary>
		[Field ("kCGImagePropertyExifCompressedBitsPerPixel")]
		NSString ExifCompressedBitsPerPixel { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifShutterSpeedValue</summary>
		[Field ("kCGImagePropertyExifShutterSpeedValue")]
		NSString ExifShutterSpeedValue { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifApertureValue</summary>
		[Field ("kCGImagePropertyExifApertureValue")]
		NSString ExifApertureValue { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifBrightnessValue</summary>
		[Field ("kCGImagePropertyExifBrightnessValue")]
		NSString ExifBrightnessValue { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifExposureBiasValue</summary>
		[Field ("kCGImagePropertyExifExposureBiasValue")]
		NSString ExifExposureBiasValue { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifMaxApertureValue</summary>
		[Field ("kCGImagePropertyExifMaxApertureValue")]
		NSString ExifMaxApertureValue { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifSubjectDistance</summary>
		[Field ("kCGImagePropertyExifSubjectDistance")]
		NSString ExifSubjectDistance { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifMeteringMode</summary>
		[Field ("kCGImagePropertyExifMeteringMode")]
		NSString ExifMeteringMode { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifLightSource</summary>
		[Field ("kCGImagePropertyExifLightSource")]
		NSString ExifLightSource { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifFlash</summary>
		[Field ("kCGImagePropertyExifFlash")]
		NSString ExifFlash { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifFocalLength</summary>
		[Field ("kCGImagePropertyExifFocalLength")]
		NSString ExifFocalLength { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifSubjectArea</summary>
		[Field ("kCGImagePropertyExifSubjectArea")]
		NSString ExifSubjectArea { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifMakerNote</summary>
		[Field ("kCGImagePropertyExifMakerNote")]
		NSString ExifMakerNote { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifUserComment</summary>
		[Field ("kCGImagePropertyExifUserComment")]
		NSString ExifUserComment { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifSubsecTime</summary>
		[Field ("kCGImagePropertyExifSubsecTime")]
		NSString ExifSubsecTime { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifSubsecTimeOrginal</summary>
		[Field ("kCGImagePropertyExifSubsecTimeOrginal")]
		NSString ExifSubsecTimeOrginal { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifSubsecTimeOriginal.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyExifSubsecTimeOriginal")]
		NSString ExifSubsecTimeOriginal { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifSubsecTimeDigitized</summary>
		[Field ("kCGImagePropertyExifSubsecTimeDigitized")]
		NSString ExifSubsecTimeDigitized { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifFlashPixVersion</summary>
		[Field ("kCGImagePropertyExifFlashPixVersion")]
		NSString ExifFlashPixVersion { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifColorSpace</summary>
		[Field ("kCGImagePropertyExifColorSpace")]
		NSString ExifColorSpace { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifPixelXDimension</summary>
		[Field ("kCGImagePropertyExifPixelXDimension")]
		NSString ExifPixelXDimension { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifPixelYDimension</summary>
		[Field ("kCGImagePropertyExifPixelYDimension")]
		NSString ExifPixelYDimension { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifRelatedSoundFile</summary>
		[Field ("kCGImagePropertyExifRelatedSoundFile")]
		NSString ExifRelatedSoundFile { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifFlashEnergy</summary>
		[Field ("kCGImagePropertyExifFlashEnergy")]
		NSString ExifFlashEnergy { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifSpatialFrequencyResponse</summary>
		[Field ("kCGImagePropertyExifSpatialFrequencyResponse")]
		NSString ExifSpatialFrequencyResponse { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifFocalPlaneXResolution</summary>
		[Field ("kCGImagePropertyExifFocalPlaneXResolution")]
		NSString ExifFocalPlaneXResolution { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifFocalPlaneYResolution</summary>
		[Field ("kCGImagePropertyExifFocalPlaneYResolution")]
		NSString ExifFocalPlaneYResolution { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifFocalPlaneResolutionUnit</summary>
		[Field ("kCGImagePropertyExifFocalPlaneResolutionUnit")]
		NSString ExifFocalPlaneResolutionUnit { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifSubjectLocation</summary>
		[Field ("kCGImagePropertyExifSubjectLocation")]
		NSString ExifSubjectLocation { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifExposureIndex</summary>
		[Field ("kCGImagePropertyExifExposureIndex")]
		NSString ExifExposureIndex { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifSensingMethod</summary>
		[Field ("kCGImagePropertyExifSensingMethod")]
		NSString ExifSensingMethod { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifFileSource</summary>
		[Field ("kCGImagePropertyExifFileSource")]
		NSString ExifFileSource { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifSceneType</summary>
		[Field ("kCGImagePropertyExifSceneType")]
		NSString ExifSceneType { get; }
		/// <summary>Gets the ExifCFAPattern property key.</summary>
		[Field ("kCGImagePropertyExifCFAPattern")]
		NSString ExifCFAPattern { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifCustomRendered</summary>
		[Field ("kCGImagePropertyExifCustomRendered")]
		NSString ExifCustomRendered { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifExposureMode</summary>
		[Field ("kCGImagePropertyExifExposureMode")]
		NSString ExifExposureMode { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifWhiteBalance</summary>
		[Field ("kCGImagePropertyExifWhiteBalance")]
		NSString ExifWhiteBalance { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifDigitalZoomRatio</summary>
		[Field ("kCGImagePropertyExifDigitalZoomRatio")]
		NSString ExifDigitalZoomRatio { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifFocalLenIn35mmFilm</summary>
		[Field ("kCGImagePropertyExifFocalLenIn35mmFilm")]
		NSString ExifFocalLenIn35mmFilm { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifSceneCaptureType</summary>
		[Field ("kCGImagePropertyExifSceneCaptureType")]
		NSString ExifSceneCaptureType { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifGainControl</summary>
		[Field ("kCGImagePropertyExifGainControl")]
		NSString ExifGainControl { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifContrast</summary>
		[Field ("kCGImagePropertyExifContrast")]
		NSString ExifContrast { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifSaturation</summary>
		[Field ("kCGImagePropertyExifSaturation")]
		NSString ExifSaturation { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifSharpness</summary>
		[Field ("kCGImagePropertyExifSharpness")]
		NSString ExifSharpness { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifDeviceSettingDescription</summary>
		[Field ("kCGImagePropertyExifDeviceSettingDescription")]
		NSString ExifDeviceSettingDescription { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifSubjectDistRange</summary>
		[Field ("kCGImagePropertyExifSubjectDistRange")]
		NSString ExifSubjectDistRange { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifImageUniqueID</summary>
		[Field ("kCGImagePropertyExifImageUniqueID")]
		NSString ExifImageUniqueID { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifGamma</summary>
		[Field ("kCGImagePropertyExifGamma")]
		NSString ExifGamma { get; }

		[iOS (13, 1), TV (13, 1)]
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyExifCompositeImage")]
		NSString ExifCompositeImage { get; }

		[iOS (13, 1), TV (13, 1)]
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyExifSourceImageNumberOfCompositeImage")]
		NSString ExifSourceImageNumberOfCompositeImage { get; }

		[iOS (13, 1), TV (13, 1)]
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyExifSourceExposureTimesOfCompositeImage")]
		NSString ExifSourceExposureTimesOfCompositeImage { get; }

		// misdocumented (first 4.3, then 5.0) but the constants were not present until 6.x

		/// <summary>Represents the value associated with the constant kCGImagePropertyExifCameraOwnerName</summary>
		[Field ("kCGImagePropertyExifCameraOwnerName")]
		[MacCatalyst (13, 1)]
		NSString ExifCameraOwnerName { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyExifBodySerialNumber</summary>
		[Field ("kCGImagePropertyExifBodySerialNumber")]
		[MacCatalyst (13, 1)]
		NSString ExifBodySerialNumber { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyExifLensSpecification</summary>
		[Field ("kCGImagePropertyExifLensSpecification")]
		[MacCatalyst (13, 1)]
		NSString ExifLensSpecification { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyExifLensMake</summary>
		[Field ("kCGImagePropertyExifLensMake")]
		[MacCatalyst (13, 1)]
		NSString ExifLensMake { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyExifLensModel</summary>
		[Field ("kCGImagePropertyExifLensModel")]
		[MacCatalyst (13, 1)]
		NSString ExifLensModel { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyExifLensSerialNumber</summary>
		[Field ("kCGImagePropertyExifLensSerialNumber")]
		[MacCatalyst (13, 1)]
		NSString ExifLensSerialNumber { get; }

		// EXIF Auxiliary Dictionary Keys

		/// <summary>Represents the value associated with the constant kCGImagePropertyExifAuxLensInfo</summary>
		[Field ("kCGImagePropertyExifAuxLensInfo")]
		NSString ExifAuxLensInfo { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifAuxLensModel</summary>
		[Field ("kCGImagePropertyExifAuxLensModel")]
		NSString ExifAuxLensModel { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifAuxSerialNumber</summary>
		[Field ("kCGImagePropertyExifAuxSerialNumber")]
		NSString ExifAuxSerialNumber { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifAuxLensID</summary>
		[Field ("kCGImagePropertyExifAuxLensID")]
		NSString ExifAuxLensID { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifAuxLensSerialNumber</summary>
		[Field ("kCGImagePropertyExifAuxLensSerialNumber")]
		NSString ExifAuxLensSerialNumber { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifAuxImageNumber</summary>
		[Field ("kCGImagePropertyExifAuxImageNumber")]
		NSString ExifAuxImageNumber { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifAuxFlashCompensation</summary>
		[Field ("kCGImagePropertyExifAuxFlashCompensation")]
		NSString ExifAuxFlashCompensation { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifAuxOwnerName</summary>
		[Field ("kCGImagePropertyExifAuxOwnerName")]
		NSString ExifAuxOwnerName { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifAuxFirmware</summary>
		[Field ("kCGImagePropertyExifAuxFirmware")]
		NSString ExifAuxFirmware { get; }

		// GIF Dictionary Keys

		/// <summary>Represents the value associated with the constant kCGImagePropertyGIFLoopCount</summary>
		[Field ("kCGImagePropertyGIFLoopCount")]
		NSString GIFLoopCount { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGIFDelayTime</summary>
		[Field ("kCGImagePropertyGIFDelayTime")]
		NSString GIFDelayTime { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGIFImageColorMap</summary>
		[Field ("kCGImagePropertyGIFImageColorMap")]
		NSString GIFImageColorMap { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGIFHasGlobalColorMap</summary>
		[Field ("kCGImagePropertyGIFHasGlobalColorMap")]
		NSString GIFHasGlobalColorMap { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGIFUnclampedDelayTime</summary>
		[Field ("kCGImagePropertyGIFUnclampedDelayTime")]
		NSString GIFUnclampedDelayTime { get; }

		[iOS (13, 0)]
		[TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyGIFCanvasPixelWidth")]
		NSString GifCanvasPixelWidth { get; }

		[iOS (13, 0)]
		[TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyGIFCanvasPixelHeight")]
		NSString GifCanvasPixelHeight { get; }

		[iOS (13, 0)]
		[TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyGIFFrameInfoArray")]
		NSString GifFrameInfoArray { get; }

		// GPS Dictionary Keys

		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSVersion</summary>
		[Field ("kCGImagePropertyGPSVersion")]
		NSString GPSVersion { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSLatitudeRef</summary>
		[Field ("kCGImagePropertyGPSLatitudeRef")]
		NSString GPSLatitudeRef { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSLatitude</summary>
		[Field ("kCGImagePropertyGPSLatitude")]
		NSString GPSLatitude { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSLongitudeRef</summary>
		[Field ("kCGImagePropertyGPSLongitudeRef")]
		NSString GPSLongitudeRef { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSLongitude</summary>
		[Field ("kCGImagePropertyGPSLongitude")]
		NSString GPSLongitude { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSAltitudeRef</summary>
		[Field ("kCGImagePropertyGPSAltitudeRef")]
		NSString GPSAltitudeRef { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSAltitude</summary>
		[Field ("kCGImagePropertyGPSAltitude")]
		NSString GPSAltitude { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSTimeStamp</summary>
		[Field ("kCGImagePropertyGPSTimeStamp")]
		NSString GPSTimeStamp { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSSatellites</summary>
		[Field ("kCGImagePropertyGPSSatellites")]
		NSString GPSSatellites { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSStatus</summary>
		[Field ("kCGImagePropertyGPSStatus")]
		NSString GPSStatus { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSMeasureMode</summary>
		[Field ("kCGImagePropertyGPSMeasureMode")]
		NSString GPSMeasureMode { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSDOP</summary>
		[Field ("kCGImagePropertyGPSDOP")]
		NSString GPSDOP { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSSpeedRef</summary>
		[Field ("kCGImagePropertyGPSSpeedRef")]
		NSString GPSSpeedRef { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSSpeed</summary>
		[Field ("kCGImagePropertyGPSSpeed")]
		NSString GPSSpeed { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSTrackRef</summary>
		[Field ("kCGImagePropertyGPSTrackRef")]
		NSString GPSTrackRef { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSTrack</summary>
		[Field ("kCGImagePropertyGPSTrack")]
		NSString GPSTrack { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSImgDirectionRef</summary>
		[Field ("kCGImagePropertyGPSImgDirectionRef")]
		NSString GPSImgDirectionRef { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSImgDirection</summary>
		[Field ("kCGImagePropertyGPSImgDirection")]
		NSString GPSImgDirection { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSMapDatum</summary>
		[Field ("kCGImagePropertyGPSMapDatum")]
		NSString GPSMapDatum { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSDestLatitudeRef</summary>
		[Field ("kCGImagePropertyGPSDestLatitudeRef")]
		NSString GPSDestLatitudeRef { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSDestLatitude</summary>
		[Field ("kCGImagePropertyGPSDestLatitude")]
		NSString GPSDestLatitude { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSDestLongitudeRef</summary>
		[Field ("kCGImagePropertyGPSDestLongitudeRef")]
		NSString GPSDestLongitudeRef { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSDestLongitude</summary>
		[Field ("kCGImagePropertyGPSDestLongitude")]
		NSString GPSDestLongitude { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSDestBearingRef</summary>
		[Field ("kCGImagePropertyGPSDestBearingRef")]
		NSString GPSDestBearingRef { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSDestBearing</summary>
		[Field ("kCGImagePropertyGPSDestBearing")]
		NSString GPSDestBearing { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSDestDistanceRef</summary>
		[Field ("kCGImagePropertyGPSDestDistanceRef")]
		NSString GPSDestDistanceRef { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSDestDistance</summary>
		[Field ("kCGImagePropertyGPSDestDistance")]
		NSString GPSDestDistance { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSAreaInformation</summary>
		[Field ("kCGImagePropertyGPSAreaInformation")]
		NSString GPSAreaInformation { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSDateStamp</summary>
		[Field ("kCGImagePropertyGPSDateStamp")]
		NSString GPSDateStamp { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSDifferental</summary>
		[Field ("kCGImagePropertyGPSDifferental")]
		NSString GPSDifferental { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyGPSHPositioningError</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyGPSHPositioningError")]
		NSString GPSHPositioningError { get; }

		// IPTC Dictionary Keys

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCObjectTypeReference</summary>
		[Field ("kCGImagePropertyIPTCObjectTypeReference")]
		NSString IPTCObjectTypeReference { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCObjectAttributeReference</summary>
		[Field ("kCGImagePropertyIPTCObjectAttributeReference")]
		NSString IPTCObjectAttributeReference { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCObjectName</summary>
		[Field ("kCGImagePropertyIPTCObjectName")]
		NSString IPTCObjectName { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCEditStatus</summary>
		[Field ("kCGImagePropertyIPTCEditStatus")]
		NSString IPTCEditStatus { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCEditorialUpdate</summary>
		[Field ("kCGImagePropertyIPTCEditorialUpdate")]
		NSString IPTCEditorialUpdate { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCUrgency</summary>
		[Field ("kCGImagePropertyIPTCUrgency")]
		NSString IPTCUrgency { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCSubjectReference</summary>
		[Field ("kCGImagePropertyIPTCSubjectReference")]
		NSString IPTCSubjectReference { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCCategory</summary>
		[Field ("kCGImagePropertyIPTCCategory")]
		NSString IPTCCategory { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCSupplementalCategory</summary>
		[Field ("kCGImagePropertyIPTCSupplementalCategory")]
		NSString IPTCSupplementalCategory { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCFixtureIdentifier</summary>
		[Field ("kCGImagePropertyIPTCFixtureIdentifier")]
		NSString IPTCFixtureIdentifier { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCKeywords</summary>
		[Field ("kCGImagePropertyIPTCKeywords")]
		NSString IPTCKeywords { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCContentLocationCode</summary>
		[Field ("kCGImagePropertyIPTCContentLocationCode")]
		NSString IPTCContentLocationCode { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCContentLocationName</summary>
		[Field ("kCGImagePropertyIPTCContentLocationName")]
		NSString IPTCContentLocationName { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCReleaseDate</summary>
		[Field ("kCGImagePropertyIPTCReleaseDate")]
		NSString IPTCReleaseDate { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCReleaseTime</summary>
		[Field ("kCGImagePropertyIPTCReleaseTime")]
		NSString IPTCReleaseTime { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExpirationDate</summary>
		[Field ("kCGImagePropertyIPTCExpirationDate")]
		NSString IPTCExpirationDate { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExpirationTime</summary>
		[Field ("kCGImagePropertyIPTCExpirationTime")]
		NSString IPTCExpirationTime { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCSpecialInstructions</summary>
		[Field ("kCGImagePropertyIPTCSpecialInstructions")]
		NSString IPTCSpecialInstructions { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCActionAdvised</summary>
		[Field ("kCGImagePropertyIPTCActionAdvised")]
		NSString IPTCActionAdvised { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCReferenceService</summary>
		[Field ("kCGImagePropertyIPTCReferenceService")]
		NSString IPTCReferenceService { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCReferenceDate</summary>
		[Field ("kCGImagePropertyIPTCReferenceDate")]
		NSString IPTCReferenceDate { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCReferenceNumber</summary>
		[Field ("kCGImagePropertyIPTCReferenceNumber")]
		NSString IPTCReferenceNumber { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCDateCreated</summary>
		[Field ("kCGImagePropertyIPTCDateCreated")]
		NSString IPTCDateCreated { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCTimeCreated</summary>
		[Field ("kCGImagePropertyIPTCTimeCreated")]
		NSString IPTCTimeCreated { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCDigitalCreationDate</summary>
		[Field ("kCGImagePropertyIPTCDigitalCreationDate")]
		NSString IPTCDigitalCreationDate { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCDigitalCreationTime</summary>
		[Field ("kCGImagePropertyIPTCDigitalCreationTime")]
		NSString IPTCDigitalCreationTime { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCOriginatingProgram</summary>
		[Field ("kCGImagePropertyIPTCOriginatingProgram")]
		NSString IPTCOriginatingProgram { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCProgramVersion</summary>
		[Field ("kCGImagePropertyIPTCProgramVersion")]
		NSString IPTCProgramVersion { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCObjectCycle</summary>
		[Field ("kCGImagePropertyIPTCObjectCycle")]
		NSString IPTCObjectCycle { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCByline</summary>
		[Field ("kCGImagePropertyIPTCByline")]
		NSString IPTCByline { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCBylineTitle</summary>
		[Field ("kCGImagePropertyIPTCBylineTitle")]
		NSString IPTCBylineTitle { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCCity</summary>
		[Field ("kCGImagePropertyIPTCCity")]
		NSString IPTCCity { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCSubLocation</summary>
		[Field ("kCGImagePropertyIPTCSubLocation")]
		NSString IPTCSubLocation { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCProvinceState</summary>
		[Field ("kCGImagePropertyIPTCProvinceState")]
		NSString IPTCProvinceState { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCCountryPrimaryLocationCode</summary>
		[Field ("kCGImagePropertyIPTCCountryPrimaryLocationCode")]
		NSString IPTCCountryPrimaryLocationCode { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCCountryPrimaryLocationName</summary>
		[Field ("kCGImagePropertyIPTCCountryPrimaryLocationName")]
		NSString IPTCCountryPrimaryLocationName { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCOriginalTransmissionReference</summary>
		[Field ("kCGImagePropertyIPTCOriginalTransmissionReference")]
		NSString IPTCOriginalTransmissionReference { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCHeadline</summary>
		[Field ("kCGImagePropertyIPTCHeadline")]
		NSString IPTCHeadline { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCCredit</summary>
		[Field ("kCGImagePropertyIPTCCredit")]
		NSString IPTCCredit { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCSource</summary>
		[Field ("kCGImagePropertyIPTCSource")]
		NSString IPTCSource { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCCopyrightNotice</summary>
		[Field ("kCGImagePropertyIPTCCopyrightNotice")]
		NSString IPTCCopyrightNotice { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCContact</summary>
		[Field ("kCGImagePropertyIPTCContact")]
		NSString IPTCContact { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCCaptionAbstract</summary>
		[Field ("kCGImagePropertyIPTCCaptionAbstract")]
		NSString IPTCCaptionAbstract { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCWriterEditor</summary>
		[Field ("kCGImagePropertyIPTCWriterEditor")]
		NSString IPTCWriterEditor { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCImageType</summary>
		[Field ("kCGImagePropertyIPTCImageType")]
		NSString IPTCImageType { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCImageOrientation</summary>
		[Field ("kCGImagePropertyIPTCImageOrientation")]
		NSString IPTCImageOrientation { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCLanguageIdentifier</summary>
		[Field ("kCGImagePropertyIPTCLanguageIdentifier")]
		NSString IPTCLanguageIdentifier { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCStarRating</summary>
		[Field ("kCGImagePropertyIPTCStarRating")]
		NSString IPTCStarRating { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCCreatorContactInfo</summary>
		[Field ("kCGImagePropertyIPTCCreatorContactInfo")]
		NSString IPTCCreatorContactInfo { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCRightsUsageTerms</summary>
		[Field ("kCGImagePropertyIPTCRightsUsageTerms")]
		NSString IPTCRightsUsageTerms { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCScene</summary>
		[Field ("kCGImagePropertyIPTCScene")]
		NSString IPTCScene { get; }

		// IPTC Creator Contact Info Dictionary Keys

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCContactInfoCity</summary>
		[Field ("kCGImagePropertyIPTCContactInfoCity")]
		NSString IPTCContactInfoCity { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCContactInfoCountry</summary>
		[Field ("kCGImagePropertyIPTCContactInfoCountry")]
		NSString IPTCContactInfoCountry { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCContactInfoAddress</summary>
		[Field ("kCGImagePropertyIPTCContactInfoAddress")]
		NSString IPTCContactInfoAddress { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCContactInfoPostalCode</summary>
		[Field ("kCGImagePropertyIPTCContactInfoPostalCode")]
		NSString IPTCContactInfoPostalCode { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCContactInfoStateProvince</summary>
		[Field ("kCGImagePropertyIPTCContactInfoStateProvince")]
		NSString IPTCContactInfoStateProvince { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCContactInfoEmails</summary>
		[Field ("kCGImagePropertyIPTCContactInfoEmails")]
		NSString IPTCContactInfoEmails { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCContactInfoPhones</summary>
		[Field ("kCGImagePropertyIPTCContactInfoPhones")]
		NSString IPTCContactInfoPhones { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCContactInfoWebURLs</summary>
		[Field ("kCGImagePropertyIPTCContactInfoWebURLs")]
		NSString IPTCContactInfoWebURLs { get; }

		// JFIF Dictionary Keys

		/// <summary>Represents the value associated with the constant kCGImagePropertyJFIFVersion</summary>
		[Field ("kCGImagePropertyJFIFVersion")]
		NSString JFIFVersion { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyJFIFXDensity</summary>
		[Field ("kCGImagePropertyJFIFXDensity")]
		NSString JFIFXDensity { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyJFIFYDensity</summary>
		[Field ("kCGImagePropertyJFIFYDensity")]
		NSString JFIFYDensity { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyJFIFDensityUnit</summary>
		[Field ("kCGImagePropertyJFIFDensityUnit")]
		NSString JFIFDensityUnit { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyJFIFIsProgressive</summary>
		[Field ("kCGImagePropertyJFIFIsProgressive")]
		NSString JFIFIsProgressive { get; }

		// PNG Dictionary Keys

		/// <summary>Represents the value associated with the constant kCGImagePropertyPNGGamma</summary>
		[Field ("kCGImagePropertyPNGGamma")]
		NSString PNGGamma { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyPNGInterlaceType</summary>
		[Field ("kCGImagePropertyPNGInterlaceType")]
		NSString PNGInterlaceType { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyPNGXPixelsPerMeter</summary>
		[Field ("kCGImagePropertyPNGXPixelsPerMeter")]
		NSString PNGXPixelsPerMeter { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyPNGYPixelsPerMeter</summary>
		[Field ("kCGImagePropertyPNGYPixelsPerMeter")]
		NSString PNGYPixelsPerMeter { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyPNGsRGBIntent</summary>
		[Field ("kCGImagePropertyPNGsRGBIntent")]
		NSString PNGsRGBIntent { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyPNGChromaticities</summary>
		[Field ("kCGImagePropertyPNGChromaticities")]
		NSString PNGChromaticities { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyPNGAuthor</summary>
		[Field ("kCGImagePropertyPNGAuthor")]
		NSString PNGAuthor { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyPNGCopyright</summary>
		[Field ("kCGImagePropertyPNGCopyright")]
		NSString PNGCopyright { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyPNGCreationTime</summary>
		[Field ("kCGImagePropertyPNGCreationTime")]
		NSString PNGCreationTime { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyPNGDescription</summary>
		[Field ("kCGImagePropertyPNGDescription")]
		NSString PNGDescription { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyPNGModificationTime</summary>
		[Field ("kCGImagePropertyPNGModificationTime")]
		NSString PNGModificationTime { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyPNGSoftware</summary>
		[Field ("kCGImagePropertyPNGSoftware")]
		NSString PNGSoftware { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyPNGTitle</summary>
		[Field ("kCGImagePropertyPNGTitle")]
		NSString PNGTitle { get; }
		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)]
		[Field ("kCGImagePropertyPNGPixelsAspectRatio")]
		NSString PNGPixelsAspectRatio { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyPNGCompressionFilter.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyPNGCompressionFilter")]
		NSString PNGCompressionFilter { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyAPNGLoopCount</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyAPNGLoopCount")]
		NSString PNGLoopCount { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyAPNGDelayTime</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyAPNGDelayTime")]
		NSString PNGDelayTime { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyAPNGUnclampedDelayTime</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyAPNGUnclampedDelayTime")]
		NSString PNGUnclampedDelayTime { get; }

		[iOS (13, 0)]
		[TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyAPNGFrameInfoArray")]
		NSString ApngFrameInfoArray { get; }

		[iOS (13, 0)]
		[TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyAPNGCanvasPixelWidth")]
		NSString ApngCanvasPixelWidth { get; }

		[iOS (13, 0)]
		[TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyAPNGCanvasPixelHeight")]
		NSString ApngCanvasPixelHeight { get; }

		/// <summary>Gets the PNGComment property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyPNGComment")]
		NSString PNGComment { get; }

		/// <summary>Gets the PNGDisclaimer property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyPNGDisclaimer")]
		NSString PNGDisclaimer { get; }

		/// <summary>Gets the PNGSource property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyPNGSource")]
		NSString PNGSource { get; }

		/// <summary>Gets the PNGWarning property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyPNGWarning")]
		NSString PNGWarning { get; }

		[TV (14, 5), iOS (14, 5)]
		[MacCatalyst (14, 5)]
		[Field ("kCGImagePropertyPNGTransparency")]
		NSString PNGTransparency { get; }

		// TIFF Dictionary Keys

		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFCompression</summary>
		[Field ("kCGImagePropertyTIFFCompression")]
		NSString TIFFCompression { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFPhotometricInterpretation</summary>
		[Field ("kCGImagePropertyTIFFPhotometricInterpretation")]
		NSString TIFFPhotometricInterpretation { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFDocumentName</summary>
		[Field ("kCGImagePropertyTIFFDocumentName")]
		NSString TIFFDocumentName { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFImageDescription</summary>
		[Field ("kCGImagePropertyTIFFImageDescription")]
		NSString TIFFImageDescription { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFMake</summary>
		[Field ("kCGImagePropertyTIFFMake")]
		NSString TIFFMake { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFModel</summary>
		[Field ("kCGImagePropertyTIFFModel")]
		NSString TIFFModel { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFOrientation</summary>
		[Field ("kCGImagePropertyTIFFOrientation")]
		NSString TIFFOrientation { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFXResolution</summary>
		[Field ("kCGImagePropertyTIFFXResolution")]
		NSString TIFFXResolution { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFYResolution</summary>
		[Field ("kCGImagePropertyTIFFYResolution")]
		NSString TIFFYResolution { get; }
		[Mac (14, 4), iOS (17, 4), MacCatalyst (17, 4), TV (17, 4)]
		[Field ("kCGImagePropertyTIFFXPosition")]
		NSString TIFFXPosition { get; }
		[Mac (14, 4), iOS (17, 4), MacCatalyst (17, 4), TV (17, 4)]
		[Field ("kCGImagePropertyTIFFYPosition")]
		NSString TIFFYPosition { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFResolutionUnit</summary>
		[Field ("kCGImagePropertyTIFFResolutionUnit")]
		NSString TIFFResolutionUnit { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFSoftware</summary>
		[Field ("kCGImagePropertyTIFFSoftware")]
		NSString TIFFSoftware { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFTransferFunction</summary>
		[Field ("kCGImagePropertyTIFFTransferFunction")]
		NSString TIFFTransferFunction { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFDateTime</summary>
		[Field ("kCGImagePropertyTIFFDateTime")]
		NSString TIFFDateTime { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFArtist</summary>
		[Field ("kCGImagePropertyTIFFArtist")]
		NSString TIFFArtist { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFHostComputer</summary>
		[Field ("kCGImagePropertyTIFFHostComputer")]
		NSString TIFFHostComputer { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFWhitePoint</summary>
		[Field ("kCGImagePropertyTIFFWhitePoint")]
		NSString TIFFWhitePoint { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFPrimaryChromaticities</summary>
		[Field ("kCGImagePropertyTIFFPrimaryChromaticities")]
		NSString TIFFPrimaryChromaticities { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFTileLength.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyTIFFTileLength")]
		NSString TIFFTileLength { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyTIFFTileWidth.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyTIFFTileWidth")]
		NSString TIFFTileWidth { get; }

		// DNG Dictionary Keys

		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGVersion</summary>
		[Field ("kCGImagePropertyDNGVersion")]
		NSString DNGVersion { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGBackwardVersion</summary>
		[Field ("kCGImagePropertyDNGBackwardVersion")]
		NSString DNGBackwardVersion { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGUniqueCameraModel</summary>
		[Field ("kCGImagePropertyDNGUniqueCameraModel")]
		NSString DNGUniqueCameraModel { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGLocalizedCameraModel</summary>
		[Field ("kCGImagePropertyDNGLocalizedCameraModel")]
		NSString DNGLocalizedCameraModel { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGCameraSerialNumber</summary>
		[Field ("kCGImagePropertyDNGCameraSerialNumber")]
		NSString DNGCameraSerialNumber { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGLensInfo</summary>
		[Field ("kCGImagePropertyDNGLensInfo")]
		NSString DNGLensInfo { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGBlackLevel.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGBlackLevel")]
		NSString DNGBlackLevel { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGWhiteLevel.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGWhiteLevel")]
		NSString DNGWhiteLevel { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGCalibrationIlluminant1.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGCalibrationIlluminant1")]
		NSString DNGCalibrationIlluminant1 { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGCalibrationIlluminant2.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGCalibrationIlluminant2")]
		NSString DNGCalibrationIlluminant2 { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGColorMatrix1.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGColorMatrix1")]
		NSString DNGColorMatrix1 { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGColorMatrix2.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGColorMatrix2")]
		NSString DNGColorMatrix2 { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGCameraCalibration1.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGCameraCalibration1")]
		NSString DNGCameraCalibration1 { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGCameraCalibration2.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGCameraCalibration2")]
		NSString DNGCameraCalibration2 { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGAsShotNeutral.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGAsShotNeutral")]
		NSString DNGAsShotNeutral { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGAsShotWhiteXY.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGAsShotWhiteXY")]
		NSString DNGAsShotWhiteXY { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGBaselineExposure.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGBaselineExposure")]
		NSString DNGBaselineExposure { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGBaselineNoise.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGBaselineNoise")]
		NSString DNGBaselineNoise { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGBaselineSharpness.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGBaselineSharpness")]
		NSString DNGBaselineSharpness { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGPrivateData.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGPrivateData")]
		NSString DNGPrivateData { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGCameraCalibrationSignature.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGCameraCalibrationSignature")]
		NSString DNGCameraCalibrationSignature { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGProfileCalibrationSignature.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGProfileCalibrationSignature")]
		NSString DNGProfileCalibrationSignature { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGNoiseProfile.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGNoiseProfile")]
		NSString DNGNoiseProfile { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGWarpRectilinear.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGWarpRectilinear")]
		NSString DNGWarpRectilinear { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGWarpFisheye.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGWarpFisheye")]
		NSString DNGWarpFisheye { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyDNGFixVignetteRadial.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGFixVignetteRadial")]
		NSString DNGFixVignetteRadial { get; }

		/// <summary>Gets the DNGActiveArea property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGActiveArea")]
		NSString DNGActiveArea { get; }

		/// <summary>Gets the DNGAnalogBalance property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGAnalogBalance")]
		NSString DNGAnalogBalance { get; }

		/// <summary>Gets the DNGAntiAliasStrength property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGAntiAliasStrength")]
		NSString DNGAntiAliasStrength { get; }

		/// <summary>Gets the DNGAsShotICCProfile property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGAsShotICCProfile")]
		NSString DNGAsShotICCProfile { get; }

		/// <summary>Gets the DNGAsShotPreProfileMatrix property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGAsShotPreProfileMatrix")]
		NSString DNGAsShotPreProfileMatrix { get; }

		/// <summary>Gets the DNGAsShotProfileName property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGAsShotProfileName")]
		NSString DNGAsShotProfileName { get; }

		/// <summary>Gets the DNGBaselineExposureOffset property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGBaselineExposureOffset")]
		NSString DNGBaselineExposureOffset { get; }

		/// <summary>Gets the DNGBayerGreenSplit property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGBayerGreenSplit")]
		NSString DNGBayerGreenSplit { get; }

		/// <summary>Gets the DNGBestQualityScale property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGBestQualityScale")]
		NSString DNGBestQualityScale { get; }

		/// <summary>Gets the DNGBlackLevelDeltaHorizontal property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGBlackLevelDeltaH")]
		NSString DNGBlackLevelDeltaHorizontal { get; }

		/// <summary>Gets the DNGBlackLevelDeltaVertical property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGBlackLevelDeltaV")]
		NSString DNGBlackLevelDeltaVertical { get; }

		/// <summary>Gets the DNGBlackLevelRepeatDim property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGBlackLevelRepeatDim")]
		NSString DNGBlackLevelRepeatDim { get; }

		/// <summary>Gets the DNGCfaLayout property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGCFALayout")]
		NSString DNGCfaLayout { get; }

		/// <summary>Gets the DNGCfaPlaneColor property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGCFAPlaneColor")]
		NSString DNGCfaPlaneColor { get; }

		/// <summary>Gets the DNGChromaBlurRadius property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGChromaBlurRadius")]
		NSString DNGChromaBlurRadius { get; }

		/// <summary>Gets the DNGColorimetricReference property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGColorimetricReference")]
		NSString DNGColorimetricReference { get; }

		/// <summary>Gets the DNGCurrentICCProfile property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGCurrentICCProfile")]
		NSString DNGCurrentICCProfile { get; }

		/// <summary>Gets the DNGCurrentPreProfileMatrix property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGCurrentPreProfileMatrix")]
		NSString DNGCurrentPreProfileMatrix { get; }

		/// <summary>Gets the DNGDefaultBlackRender property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGDefaultBlackRender")]
		NSString DNGDefaultBlackRender { get; }

		/// <summary>Gets the DNGDefaultCropOrigin property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGDefaultCropOrigin")]
		NSString DNGDefaultCropOrigin { get; }

		/// <summary>Gets the DNGDefaultCropSize property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGDefaultCropSize")]
		NSString DNGDefaultCropSize { get; }

		/// <summary>Gets the DNGDefaultScale property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGDefaultScale")]
		NSString DNGDefaultScale { get; }

		/// <summary>Gets the DNGDefaultUserCrop property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGDefaultUserCrop")]
		NSString DNGDefaultUserCrop { get; }

		/// <summary>Gets the DNGExtraCameraProfiles property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGExtraCameraProfiles")]
		NSString DNGExtraCameraProfiles { get; }

		/// <summary>Gets the DNGForwardMatrix1 property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGForwardMatrix1")]
		NSString DNGForwardMatrix1 { get; }

		/// <summary>Gets the DNGForwardMatrix2 property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGForwardMatrix2")]
		NSString DNGForwardMatrix2 { get; }

		/// <summary>Gets the DNGLinearizationTable property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGLinearizationTable")]
		NSString DNGLinearizationTable { get; }

		/// <summary>Gets the DNGLinearResponseLimit property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGLinearResponseLimit")]
		NSString DNGLinearResponseLimit { get; }

		/// <summary>Gets the DNGMakerNoteSafety property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGMakerNoteSafety")]
		NSString DNGMakerNoteSafety { get; }

		/// <summary>Gets the DNGMaskedAreas property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGMaskedAreas")]
		NSString DNGMaskedAreas { get; }

		/// <summary>Gets the DNGNewRawImageDigest property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGNewRawImageDigest")]
		NSString DNGNewRawImageDigest { get; }

		/// <summary>Gets the DNGNoiseReductionApplied property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGNoiseReductionApplied")]
		NSString DNGNoiseReductionApplied { get; }

		/// <summary>Gets the DNGOpcodeList1 property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGOpcodeList1")]
		NSString DNGOpcodeList1 { get; }

		/// <summary>Gets the DNGOpcodeList2 property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGOpcodeList2")]
		NSString DNGOpcodeList2 { get; }

		/// <summary>Gets the DNGOpcodeList3 property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGOpcodeList3")]
		NSString DNGOpcodeList3 { get; }

		/// <summary>Gets the DNGOriginalBestQualityFinalSize property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGOriginalBestQualityFinalSize")]
		NSString DNGOriginalBestQualityFinalSize { get; }

		/// <summary>Gets the DNGOriginalDefaultCropSize property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGOriginalDefaultCropSize")]
		NSString DNGOriginalDefaultCropSize { get; }

		/// <summary>Gets the DNGOriginalDefaultFinalSize property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGOriginalDefaultFinalSize")]
		NSString DNGOriginalDefaultFinalSize { get; }

		/// <summary>Gets the DNGOriginalRawFileData property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGOriginalRawFileData")]
		NSString DNGOriginalRawFileData { get; }

		/// <summary>Gets the DNGOriginalRawFileDigest property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGOriginalRawFileDigest")]
		NSString DNGOriginalRawFileDigest { get; }

		/// <summary>Gets the DNGOriginalRawFileName property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGOriginalRawFileName")]
		NSString DNGOriginalRawFileName { get; }

		/// <summary>Gets the DNGPreviewApplicationName property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGPreviewApplicationName")]
		NSString DNGPreviewApplicationName { get; }

		/// <summary>Gets the DNGPreviewApplicationVersion property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGPreviewApplicationVersion")]
		NSString DNGPreviewApplicationVersion { get; }

		/// <summary>Gets the DNGPreviewColorSpace property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGPreviewColorSpace")]
		NSString DNGPreviewColorSpace { get; }

		/// <summary>Gets the DNGPreviewDateTime property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGPreviewDateTime")]
		NSString DNGPreviewDateTime { get; }

		/// <summary>Gets the DNGPreviewSettingsDigest property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGPreviewSettingsDigest")]
		NSString DNGPreviewSettingsDigest { get; }

		/// <summary>Gets the DNGPreviewSettingsName property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGPreviewSettingsName")]
		NSString DNGPreviewSettingsName { get; }

		/// <summary>Gets the DNGProfileCopyright property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGProfileCopyright")]
		NSString DNGProfileCopyright { get; }

		/// <summary>Gets the DNGProfileEmbedPolicy property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGProfileEmbedPolicy")]
		NSString DNGProfileEmbedPolicy { get; }

		/// <summary>Gets the DNGProfileHueSatMapData1 property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGProfileHueSatMapData1")]
		NSString DNGProfileHueSatMapData1 { get; }

		/// <summary>Gets the DNGProfileHueSatMapData2 property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGProfileHueSatMapData2")]
		NSString DNGProfileHueSatMapData2 { get; }

		/// <summary>Gets the DNGProfileHueSatMapDims property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGProfileHueSatMapDims")]
		NSString DNGProfileHueSatMapDims { get; }

		/// <summary>Gets the DNGProfileHueSatMapEncoding property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGProfileHueSatMapEncoding")]
		NSString DNGProfileHueSatMapEncoding { get; }

		/// <summary>Gets the DNGProfileLookTableData property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGProfileLookTableData")]
		NSString DNGProfileLookTableData { get; }

		/// <summary>Gets the DNGProfileLookTableDims property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGProfileLookTableDims")]
		NSString DNGProfileLookTableDims { get; }

		/// <summary>Gets the DNGProfileLookTableEncoding property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGProfileLookTableEncoding")]
		NSString DNGProfileLookTableEncoding { get; }

		/// <summary>Gets the DNGProfileName property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGProfileName")]
		NSString DNGProfileName { get; }

		/// <summary>Gets the DNGProfileToneCurve property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGProfileToneCurve")]
		NSString DNGProfileToneCurve { get; }

		/// <summary>Gets the DNGRawDataUniqueId property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGRawDataUniqueID")]
		NSString DNGRawDataUniqueId { get; }

		/// <summary>Gets the DNGRawImageDigest property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGRawImageDigest")]
		NSString DNGRawImageDigest { get; }

		/// <summary>Gets the DNGRawToPreviewGain property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGRawToPreviewGain")]
		NSString DNGRawToPreviewGain { get; }

		/// <summary>Gets the DNGReductionMatrix1 property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGReductionMatrix1")]
		NSString DNGReductionMatrix1 { get; }

		/// <summary>Gets the DNGReductionMatrix2 property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGReductionMatrix2")]
		NSString DNGReductionMatrix2 { get; }

		/// <summary>Gets the DNGRowInterleaveFactor property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGRowInterleaveFactor")]
		NSString DNGRowInterleaveFactor { get; }

		/// <summary>Gets the DNGShadowScale property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGShadowScale")]
		NSString DNGShadowScale { get; }

		/// <summary>Gets the DNGSubTileBlockSize property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyDNGSubTileBlockSize")]
		NSString DNGSubTileBlockSize { get; }

		// 8BIM Dictionary Keys

		/// <summary>Represents the value associated with the constant kCGImageProperty8BIMLayerNames</summary>
		[Field ("kCGImageProperty8BIMLayerNames")]
		NSString EightBIMLayerNames { get; }

		// CIFF Dictionary Keys

		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFDescription</summary>
		[Field ("kCGImagePropertyCIFFDescription")]
		NSString CIFFDescription { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFFirmware</summary>
		[Field ("kCGImagePropertyCIFFFirmware")]
		NSString CIFFFirmware { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFOwnerName</summary>
		[Field ("kCGImagePropertyCIFFOwnerName")]
		NSString CIFFOwnerName { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFImageName</summary>
		[Field ("kCGImagePropertyCIFFImageName")]
		NSString CIFFImageName { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFImageFileName</summary>
		[Field ("kCGImagePropertyCIFFImageFileName")]
		NSString CIFFImageFileName { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFReleaseMethod</summary>
		[Field ("kCGImagePropertyCIFFReleaseMethod")]
		NSString CIFFReleaseMethod { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFReleaseTiming</summary>
		[Field ("kCGImagePropertyCIFFReleaseTiming")]
		NSString CIFFReleaseTiming { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFRecordID</summary>
		[Field ("kCGImagePropertyCIFFRecordID")]
		NSString CIFFRecordID { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFSelfTimingTime</summary>
		[Field ("kCGImagePropertyCIFFSelfTimingTime")]
		NSString CIFFSelfTimingTime { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFCameraSerialNumber</summary>
		[Field ("kCGImagePropertyCIFFCameraSerialNumber")]
		NSString CIFFCameraSerialNumber { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFImageSerialNumber</summary>
		[Field ("kCGImagePropertyCIFFImageSerialNumber")]
		NSString CIFFImageSerialNumber { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFContinuousDrive</summary>
		[Field ("kCGImagePropertyCIFFContinuousDrive")]
		NSString CIFFContinuousDrive { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFFocusMode</summary>
		[Field ("kCGImagePropertyCIFFFocusMode")]
		NSString CIFFFocusMode { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFMeteringMode</summary>
		[Field ("kCGImagePropertyCIFFMeteringMode")]
		NSString CIFFMeteringMode { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFShootingMode</summary>
		[Field ("kCGImagePropertyCIFFShootingMode")]
		NSString CIFFShootingMode { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFLensMaxMM</summary>
		[Field ("kCGImagePropertyCIFFLensMaxMM")]
		NSString CIFFLensMaxMM { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFLensMinMM</summary>
		[Field ("kCGImagePropertyCIFFLensMinMM")]
		NSString CIFFLensMinMM { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFLensModel</summary>
		[Field ("kCGImagePropertyCIFFLensModel")]
		NSString CIFFLensModel { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFWhiteBalanceIndex</summary>
		[Field ("kCGImagePropertyCIFFWhiteBalanceIndex")]
		NSString CIFFWhiteBalanceIndex { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFFlashExposureComp</summary>
		[Field ("kCGImagePropertyCIFFFlashExposureComp")]
		NSString CIFFFlashExposureComp { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyCIFFMeasuredEV</summary>
		[Field ("kCGImagePropertyCIFFMeasuredEV")]
		NSString CIFFMeasuredEV { get; }

		// HEICS

		[iOS (13, 0)]
		[TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyHEICSLoopCount")]
		NSString HeicsLoopCount { get; }

		[iOS (13, 0)]
		[TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyHEICSDelayTime")]
		NSString HeicsDelayTime { get; }

		[iOS (13, 0)]
		[TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyHEICSUnclampedDelayTime")]
		NSString HeicsSUnclampedDelayTime { get; }

		[iOS (13, 0)]
		[TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyHEICSCanvasPixelWidth")]
		NSString HeicsCanvasPixelWidth { get; }

		[iOS (13, 0)]
		[TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyHEICSCanvasPixelHeight")]
		NSString HeicsCanvasPixelHeight { get; }

		[iOS (13, 0)]
		[TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyHEICSFrameInfoArray")]
		NSString HeicsFrameInfoArray { get; }

		// Nikon Camera Dictionary Keys

		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonISOSetting</summary>
		[Field ("kCGImagePropertyMakerNikonISOSetting")]
		NSString MakerNikonISOSetting { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonColorMode</summary>
		[Field ("kCGImagePropertyMakerNikonColorMode")]
		NSString MakerNikonColorMode { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonQuality</summary>
		[Field ("kCGImagePropertyMakerNikonQuality")]
		NSString MakerNikonQuality { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonWhiteBalanceMode</summary>
		[Field ("kCGImagePropertyMakerNikonWhiteBalanceMode")]
		NSString MakerNikonWhiteBalanceMode { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonSharpenMode</summary>
		[Field ("kCGImagePropertyMakerNikonSharpenMode")]
		NSString MakerNikonSharpenMode { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonFocusMode</summary>
		[Field ("kCGImagePropertyMakerNikonFocusMode")]
		NSString MakerNikonFocusMode { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonFlashSetting</summary>
		[Field ("kCGImagePropertyMakerNikonFlashSetting")]
		NSString MakerNikonFlashSetting { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonISOSelection</summary>
		[Field ("kCGImagePropertyMakerNikonISOSelection")]
		NSString MakerNikonISOSelection { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonFlashExposureComp</summary>
		[Field ("kCGImagePropertyMakerNikonFlashExposureComp")]
		NSString MakerNikonFlashExposureComp { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonImageAdjustment</summary>
		[Field ("kCGImagePropertyMakerNikonImageAdjustment")]
		NSString MakerNikonImageAdjustment { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonLensAdapter</summary>
		[Field ("kCGImagePropertyMakerNikonLensAdapter")]
		NSString MakerNikonLensAdapter { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonLensType</summary>
		[Field ("kCGImagePropertyMakerNikonLensType")]
		NSString MakerNikonLensType { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonLensInfo</summary>
		[Field ("kCGImagePropertyMakerNikonLensInfo")]
		NSString MakerNikonLensInfo { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonFocusDistance</summary>
		[Field ("kCGImagePropertyMakerNikonFocusDistance")]
		NSString MakerNikonFocusDistance { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonDigitalZoom</summary>
		[Field ("kCGImagePropertyMakerNikonDigitalZoom")]
		NSString MakerNikonDigitalZoom { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonShootingMode</summary>
		[Field ("kCGImagePropertyMakerNikonShootingMode")]
		NSString MakerNikonShootingMode { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonShutterCount</summary>
		[Field ("kCGImagePropertyMakerNikonShutterCount")]
		NSString MakerNikonShutterCount { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerNikonCameraSerialNumber</summary>
		[Field ("kCGImagePropertyMakerNikonCameraSerialNumber")]
		NSString MakerNikonCameraSerialNumber { get; }

		// Canon Camera Dictionary Keys

		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerCanonOwnerName</summary>
		[Field ("kCGImagePropertyMakerCanonOwnerName")]
		NSString MakerCanonOwnerName { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerCanonCameraSerialNumber</summary>
		[Field ("kCGImagePropertyMakerCanonCameraSerialNumber")]
		NSString MakerCanonCameraSerialNumber { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerCanonImageSerialNumber</summary>
		[Field ("kCGImagePropertyMakerCanonImageSerialNumber")]
		NSString MakerCanonImageSerialNumber { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerCanonFlashExposureComp</summary>
		[Field ("kCGImagePropertyMakerCanonFlashExposureComp")]
		NSString MakerCanonFlashExposureComp { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerCanonContinuousDrive</summary>
		[Field ("kCGImagePropertyMakerCanonContinuousDrive")]
		NSString MakerCanonContinuousDrive { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerCanonLensModel</summary>
		[Field ("kCGImagePropertyMakerCanonLensModel")]
		NSString MakerCanonLensModel { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerCanonFirmware</summary>
		[Field ("kCGImagePropertyMakerCanonFirmware")]
		NSString MakerCanonFirmware { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerCanonAspectRatioInfo</summary>
		[Field ("kCGImagePropertyMakerCanonAspectRatioInfo")]
		NSString MakerCanonAspectRatioInfo { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyExifISOSpeed</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyExifISOSpeed")]
		NSString ExifISOSpeed { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifISOSpeedLatitudeyyy</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyExifISOSpeedLatitudeyyy")]
		NSString ExifISOSpeedLatitudeYyy { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifISOSpeedLatitudezzz</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyExifISOSpeedLatitudezzz")]
		NSString ExifISOSpeedLatitudeZzz { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifRecommendedExposureIndex</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyExifRecommendedExposureIndex")]
		NSString ExifRecommendedExposureIndex { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifSensitivityType</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyExifSensitivityType")]
		NSString ExifSensitivityType { get; }
		/// <summary>Represents the value associated with the constant kCGImagePropertyExifStandardOutputSensitivity</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyExifStandardOutputSensitivity")]
		NSString ExifStandardOutputSensitivity { get; }

		[iOS (13, 0)]
		[TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyExifOffsetTime")]
		NSString ExifOffsetTime { get; }

		[iOS (13, 0)]
		[TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyExifOffsetTimeOriginal")]
		NSString ExifOffsetTimeOriginal { get; }

		[iOS (13, 0)]
		[TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyExifOffsetTimeDigitized")]
		NSString ExifOffsetTimeDigitized { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyMakerAppleDictionary</summary>
		[NoMac]
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyMakerAppleDictionary")]
		NSString MakerAppleDictionary { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyImageCount</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyImageCount")]
		NSString ImageCount { get; }

		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)]
		[Field ("kCGImagePropertyImageIndex")]
		NSString ImageIndex { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyWidth</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyWidth")]
		NSString Width { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyHeight</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyHeight")]
		NSString Height { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyBytesPerRow</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyBytesPerRow")]
		NSString BytesPerRow { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyNamedColorSpace</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyNamedColorSpace")]
		NSString NamedColorSpace { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyPixelFormat</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyPixelFormat")]
		NSString PixelFormat { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyImages</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyImages")]
		NSString Images { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyThumbnailImages</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyThumbnailImages")]
		NSString ThumbnailImages { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyAuxiliaryData</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyAuxiliaryData")]
		NSString AuxiliaryData { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyAuxiliaryDataType</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyAuxiliaryDataType")]
		NSString AuxiliaryDataType { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyFileContentsDictionary</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyFileContentsDictionary")]
		NSString FileContentsDictionary { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyOpenEXRDictionary</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyOpenEXRDictionary")]
		NSString OpenExrDictionary { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtAboutCvTerm</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtAboutCvTerm")]
		NSString IPTCExtAboutCvTerm { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtAboutCvTermCvId</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtAboutCvTermCvId")]
		NSString IPTCExtAboutCvTermCvId { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtAboutCvTermId</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtAboutCvTermId")]
		NSString IPTCExtAboutCvTermId { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtAboutCvTermName</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtAboutCvTermName")]
		NSString IPTCExtAboutCvTermName { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtAboutCvTermRefinedAbout</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtAboutCvTermRefinedAbout")]
		NSString IPTCExtAboutCvTermRefinedAbout { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtAddlModelInfo</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtAddlModelInfo")]
		NSString IPTCExtAddlModelInfo { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkOrObject</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtArtworkOrObject")]
		NSString IPTCExtArtworkOrObject { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkCircaDateCreated</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtArtworkCircaDateCreated")]
		NSString IPTCExtArtworkCircaDateCreated { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkContentDescription</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtArtworkContentDescription")]
		NSString IPTCExtArtworkContentDescription { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkContributionDescription</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtArtworkContributionDescription")]
		NSString IPTCExtArtworkContributionDescription { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkCopyrightNotice</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtArtworkCopyrightNotice")]
		NSString IPTCExtArtworkCopyrightNotice { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkCreator</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtArtworkCreator")]
		NSString IPTCExtArtworkCreator { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkCreatorID</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtArtworkCreatorID")]
		NSString IPTCExtArtworkCreatorId { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkCopyrightOwnerID</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtArtworkCopyrightOwnerID")]
		NSString IPTCExtArtworkCopyrightOwnerId { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkCopyrightOwnerName</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtArtworkCopyrightOwnerName")]
		NSString IPTCExtArtworkCopyrightOwnerName { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkLicensorID</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtArtworkLicensorID")]
		NSString IPTCExtArtworkLicensorId { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkLicensorName</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtArtworkLicensorName")]
		NSString IPTCExtArtworkLicensorName { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkDateCreated</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtArtworkDateCreated")]
		NSString IPTCExtArtworkDateCreated { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkPhysicalDescription</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtArtworkPhysicalDescription")]
		NSString IPTCExtArtworkPhysicalDescription { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkSource</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtArtworkSource")]
		NSString IPTCExtArtworkSource { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkSourceInventoryNo</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtArtworkSourceInventoryNo")]
		NSString IPTCExtArtworkSourceInventoryNo { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkSourceInvURL</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtArtworkSourceInvURL")]
		NSString IPTCExtArtworkSourceInvUrl { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkStylePeriod</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtArtworkStylePeriod")]
		NSString IPTCExtArtworkStylePeriod { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtArtworkTitle</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtArtworkTitle")]
		NSString IPTCExtArtworkTitle { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtAudioBitrate</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtAudioBitrate")]
		NSString IPTCExtAudioBitrate { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtAudioBitrateMode</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtAudioBitrateMode")]
		NSString IPTCExtAudioBitrateMode { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtAudioChannelCount</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtAudioChannelCount")]
		NSString IPTCExtAudioChannelCount { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtCircaDateCreated</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtCircaDateCreated")]
		NSString IPTCExtCircaDateCreated { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtContainerFormat</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtContainerFormat")]
		NSString IPTCExtContainerFormat { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtContainerFormatIdentifier</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtContainerFormatIdentifier")]
		NSString IPTCExtContainerFormatIdentifier { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtContainerFormatName</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtContainerFormatName")]
		NSString IPTCExtContainerFormatName { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtContributor</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtContributor")]
		NSString IPTCExtContributor { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtContributorIdentifier</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtContributorIdentifier")]
		NSString IPTCExtContributorIdentifier { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtContributorName</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtContributorName")]
		NSString IPTCExtContributorName { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtContributorRole</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtContributorRole")]
		NSString IPTCExtContributorRole { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtCopyrightYear</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtCopyrightYear")]
		NSString IPTCExtCopyrightYear { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtCreator</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtCreator")]
		NSString IPTCExtCreator { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtCreatorIdentifier</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtCreatorIdentifier")]
		NSString IPTCExtCreatorIdentifier { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtCreatorName</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtCreatorName")]
		NSString IPTCExtCreatorName { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtCreatorRole</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtCreatorRole")]
		NSString IPTCExtCreatorRole { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtControlledVocabularyTerm</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtControlledVocabularyTerm")]
		NSString IPTCExtControlledVocabularyTerm { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtDataOnScreen</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtDataOnScreen")]
		NSString IPTCExtDataOnScreen { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtDataOnScreenRegion</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtDataOnScreenRegion")]
		NSString IPTCExtDataOnScreenRegion { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtDataOnScreenRegionD</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtDataOnScreenRegionD")]
		NSString IPTCExtDataOnScreenRegionD { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtDataOnScreenRegionH</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtDataOnScreenRegionH")]
		NSString IPTCExtDataOnScreenRegionH { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtDataOnScreenRegionText</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtDataOnScreenRegionText")]
		NSString IPTCExtDataOnScreenRegionText { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtDataOnScreenRegionUnit</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtDataOnScreenRegionUnit")]
		NSString IPTCExtDataOnScreenRegionUnit { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtDataOnScreenRegionW</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtDataOnScreenRegionW")]
		NSString IPTCExtDataOnScreenRegionW { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtDataOnScreenRegionX</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtDataOnScreenRegionX")]
		NSString IPTCExtDataOnScreenRegionX { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtDataOnScreenRegionY</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtDataOnScreenRegionY")]
		NSString IPTCExtDataOnScreenRegionY { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtDigitalImageGUID</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtDigitalImageGUID")]
		NSString IPTCExtDigitalImageGuid { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtDigitalSourceFileType</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtDigitalSourceFileType")]
		NSString IPTCExtDigitalSourceFileType { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtDigitalSourceType</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtDigitalSourceType")]
		NSString IPTCExtDigitalSourceType { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtDopesheet</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtDopesheet")]
		NSString IPTCExtDopesheet { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtDopesheetLink</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtDopesheetLink")]
		NSString IPTCExtDopesheetLink { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtDopesheetLinkLink</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtDopesheetLinkLink")]
		NSString IPTCExtDopesheetLinkLink { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtDopesheetLinkLinkQualifier</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtDopesheetLinkLinkQualifier")]
		NSString IPTCExtDopesheetLinkLinkQualifier { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtEmbdEncRightsExpr</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtEmbdEncRightsExpr")]
		NSString IPTCExtEmbdEncRightsExpr { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtEmbeddedEncodedRightsExpr</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtEmbeddedEncodedRightsExpr")]
		NSString IPTCExtEmbeddedEncodedRightsExpr { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtEmbeddedEncodedRightsExprType</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtEmbeddedEncodedRightsExprType")]
		NSString IPTCExtEmbeddedEncodedRightsExprType { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtEmbeddedEncodedRightsExprLangID</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtEmbeddedEncodedRightsExprLangID")]
		NSString IPTCExtEmbeddedEncodedRightsExprLangId { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtEpisode</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtEpisode")]
		NSString IPTCExtEpisode { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtEpisodeIdentifier</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtEpisodeIdentifier")]
		NSString IPTCExtEpisodeIdentifier { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtEpisodeName</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtEpisodeName")]
		NSString IPTCExtEpisodeName { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtEpisodeNumber</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtEpisodeNumber")]
		NSString IPTCExtEpisodeNumber { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtEvent</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtEvent")]
		NSString IPTCExtEvent { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtShownEvent</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtShownEvent")]
		NSString IPTCExtShownEvent { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtShownEventIdentifier</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtShownEventIdentifier")]
		NSString IPTCExtShownEventIdentifier { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtShownEventName</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtShownEventName")]
		NSString IPTCExtShownEventName { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtExternalMetadataLink</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtExternalMetadataLink")]
		NSString IPTCExtExternalMetadataLink { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtFeedIdentifier</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtFeedIdentifier")]
		NSString IPTCExtFeedIdentifier { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtGenre</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtGenre")]
		NSString IPTCExtGenre { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtGenreCvId</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtGenreCvId")]
		NSString IPTCExtGenreCvId { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtGenreCvTermId</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtGenreCvTermId")]
		NSString IPTCExtGenreCvTermId { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtGenreCvTermName</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtGenreCvTermName")]
		NSString IPTCExtGenreCvTermName { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtGenreCvTermRefinedAbout</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtGenreCvTermRefinedAbout")]
		NSString IPTCExtGenreCvTermRefinedAbout { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtHeadline</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtHeadline")]
		NSString IPTCExtHeadline { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtIPTCLastEdited</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtIPTCLastEdited")]
		NSString IPTCExtIPTCLastEdited { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLinkedEncRightsExpr</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtLinkedEncRightsExpr")]
		NSString IPTCExtLinkedEncRightsExpr { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLinkedEncodedRightsExpr</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtLinkedEncodedRightsExpr")]
		NSString IPTCExtLinkedEncodedRightsExpr { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLinkedEncodedRightsExprType</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtLinkedEncodedRightsExprType")]
		NSString IPTCExtLinkedEncodedRightsExprType { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLinkedEncodedRightsExprLangID</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtLinkedEncodedRightsExprLangID")]
		NSString IPTCExtLinkedEncodedRightsExprLangId { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLocationCreated</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtLocationCreated")]
		NSString IPTCExtLocationCreated { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLocationCity</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtLocationCity")]
		NSString IPTCExtLocationCity { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLocationCountryCode</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtLocationCountryCode")]
		NSString IPTCExtLocationCountryCode { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLocationCountryName</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtLocationCountryName")]
		NSString IPTCExtLocationCountryName { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLocationGPSAltitude</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtLocationGPSAltitude")]
		NSString IPTCExtLocationGpsAltitude { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLocationGPSLatitude</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtLocationGPSLatitude")]
		NSString IPTCExtLocationGpsLatitude { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLocationGPSLongitude</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtLocationGPSLongitude")]
		NSString IPTCExtLocationGpsLongitude { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLocationIdentifier</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtLocationIdentifier")]
		NSString IPTCExtLocationIdentifier { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLocationLocationId</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtLocationLocationId")]
		NSString IPTCExtLocationLocationId { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLocationLocationName</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtLocationLocationName")]
		NSString IPTCExtLocationLocationName { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLocationProvinceState</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtLocationProvinceState")]
		NSString IPTCExtLocationProvinceState { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLocationSublocation</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtLocationSublocation")]
		NSString IPTCExtLocationSublocation { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLocationWorldRegion</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtLocationWorldRegion")]
		NSString IPTCExtLocationWorldRegion { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtLocationShown</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtLocationShown")]
		NSString IPTCExtLocationShown { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtMaxAvailHeight</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtMaxAvailHeight")]
		NSString IPTCExtMaxAvailHeight { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtMaxAvailWidth</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtMaxAvailWidth")]
		NSString IPTCExtMaxAvailWidth { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtModelAge</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtModelAge")]
		NSString IPTCExtModelAge { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtOrganisationInImageCode</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtOrganisationInImageCode")]
		NSString IPTCExtOrganisationInImageCode { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtOrganisationInImageName</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtOrganisationInImageName")]
		NSString IPTCExtOrganisationInImageName { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPersonHeard</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtPersonHeard")]
		NSString IPTCExtPersonHeard { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPersonHeardIdentifier</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtPersonHeardIdentifier")]
		NSString IPTCExtPersonHeardIdentifier { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPersonHeardName</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtPersonHeardName")]
		NSString IPTCExtPersonHeardName { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPersonInImage</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtPersonInImage")]
		NSString IPTCExtPersonInImage { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPersonInImageWDetails</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtPersonInImageWDetails")]
		NSString IPTCExtPersonInImageWDetails { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPersonInImageCharacteristic</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtPersonInImageCharacteristic")]
		NSString IPTCExtPersonInImageCharacteristic { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPersonInImageCvTermCvId</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtPersonInImageCvTermCvId")]
		NSString IPTCExtPersonInImageCvTermCvId { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPersonInImageCvTermId</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtPersonInImageCvTermId")]
		NSString IPTCExtPersonInImageCvTermId { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPersonInImageCvTermName</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtPersonInImageCvTermName")]
		NSString IPTCExtPersonInImageCvTermName { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPersonInImageCvTermRefinedAbout</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtPersonInImageCvTermRefinedAbout")]
		NSString IPTCExtPersonInImageCvTermRefinedAbout { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPersonInImageDescription</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtPersonInImageDescription")]
		NSString IPTCExtPersonInImageDescription { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPersonInImageId</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtPersonInImageId")]
		NSString IPTCExtPersonInImageId { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPersonInImageName</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtPersonInImageName")]
		NSString IPTCExtPersonInImageName { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtProductInImage</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtProductInImage")]
		NSString IPTCExtProductInImage { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtProductInImageDescription</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtProductInImageDescription")]
		NSString IPTCExtProductInImageDescription { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtProductInImageGTIN</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtProductInImageGTIN")]
		NSString IPTCExtProductInImageGtin { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtProductInImageName</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtProductInImageName")]
		NSString IPTCExtProductInImageName { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPublicationEvent</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtPublicationEvent")]
		NSString IPTCExtPublicationEvent { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPublicationEventDate</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtPublicationEventDate")]
		NSString IPTCExtPublicationEventDate { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPublicationEventIdentifier</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtPublicationEventIdentifier")]
		NSString IPTCExtPublicationEventIdentifier { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtPublicationEventName</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtPublicationEventName")]
		NSString IPTCExtPublicationEventName { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRating</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtRating")]
		NSString IPTCExtRating { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingRatingRegion</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtRatingRatingRegion")]
		NSString IPTCExtRatingRatingRegion { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingRegionCity</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtRatingRegionCity")]
		NSString IPTCExtRatingRegionCity { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingRegionCountryCode</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtRatingRegionCountryCode")]
		NSString IPTCExtRatingRegionCountryCode { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingRegionCountryName</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtRatingRegionCountryName")]
		NSString IPTCExtRatingRegionCountryName { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingRegionGPSAltitude</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtRatingRegionGPSAltitude")]
		NSString IPTCExtRatingRegionGpsAltitude { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingRegionGPSLatitude</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtRatingRegionGPSLatitude")]
		NSString IPTCExtRatingRegionGpsLatitude { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingRegionGPSLongitude</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtRatingRegionGPSLongitude")]
		NSString IPTCExtRatingRegionGpsLongitude { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingRegionIdentifier</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtRatingRegionIdentifier")]
		NSString IPTCExtRatingRegionIdentifier { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingRegionLocationId</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtRatingRegionLocationId")]
		NSString IPTCExtRatingRegionLocationId { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingRegionLocationName</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtRatingRegionLocationName")]
		NSString IPTCExtRatingRegionLocationName { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingRegionProvinceState</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtRatingRegionProvinceState")]
		NSString IPTCExtRatingRegionProvinceState { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingRegionSublocation</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtRatingRegionSublocation")]
		NSString IPTCExtRatingRegionSublocation { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingRegionWorldRegion</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtRatingRegionWorldRegion")]
		NSString IPTCExtRatingRegionWorldRegion { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingScaleMaxValue</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtRatingScaleMaxValue")]
		NSString IPTCExtRatingScaleMaxValue { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingScaleMinValue</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtRatingScaleMinValue")]
		NSString IPTCExtRatingScaleMinValue { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingSourceLink</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtRatingSourceLink")]
		NSString IPTCExtRatingSourceLink { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingValue</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtRatingValue")]
		NSString IPTCExtRatingValue { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRatingValueLogoLink</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtRatingValueLogoLink")]
		NSString IPTCExtRatingValueLogoLink { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRegistryID</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtRegistryID")]
		NSString IPTCExtRegistryId { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRegistryEntryRole</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtRegistryEntryRole")]
		NSString IPTCExtRegistryEntryRole { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRegistryItemID</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtRegistryItemID")]
		NSString IPTCExtRegistryItemId { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtRegistryOrganisationID</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtRegistryOrganisationID")]
		NSString IPTCExtRegistryOrganisationId { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtReleaseReady</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtReleaseReady")]
		NSString IPTCExtReleaseReady { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtSeason</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtSeason")]
		NSString IPTCExtSeason { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtSeasonIdentifier</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtSeasonIdentifier")]
		NSString IPTCExtSeasonIdentifier { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtSeasonName</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtSeasonName")]
		NSString IPTCExtSeasonName { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtSeasonNumber</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtSeasonNumber")]
		NSString IPTCExtSeasonNumber { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtSeries</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtSeries")]
		NSString IPTCExtSeries { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtSeriesIdentifier</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtSeriesIdentifier")]
		NSString IPTCExtSeriesIdentifier { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtSeriesName</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtSeriesName")]
		NSString IPTCExtSeriesName { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtStorylineIdentifier</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtStorylineIdentifier")]
		NSString IPTCExtStorylineIdentifier { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtStreamReady</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtStreamReady")]
		NSString IPTCExtStreamReady { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtStylePeriod</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtStylePeriod")]
		NSString IPTCExtStylePeriod { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtSupplyChainSource</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtSupplyChainSource")]
		NSString IPTCExtSupplyChainSource { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtSupplyChainSourceIdentifier</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtSupplyChainSourceIdentifier")]
		NSString IPTCExtSupplyChainSourceIdentifier { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtSupplyChainSourceName</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtSupplyChainSourceName")]
		NSString IPTCExtSupplyChainSourceName { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtTemporalCoverage</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtTemporalCoverage")]
		NSString IPTCExtTemporalCoverage { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtTemporalCoverageFrom</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtTemporalCoverageFrom")]
		NSString IPTCExtTemporalCoverageFrom { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtTemporalCoverageTo</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtTemporalCoverageTo")]
		NSString IPTCExtTemporalCoverageTo { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtTranscript</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtTranscript")]
		NSString IPTCExtTranscript { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtTranscriptLink</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtTranscriptLink")]
		NSString IPTCExtTranscriptLink { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtTranscriptLinkLink</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtTranscriptLinkLink")]
		NSString IPTCExtTranscriptLinkLink { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtTranscriptLinkLinkQualifier</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtTranscriptLinkLinkQualifier")]
		NSString IPTCExtTranscriptLinkLinkQualifier { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtVideoBitrate</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtVideoBitrate")]
		NSString IPTCExtVideoBitrate { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtVideoBitrateMode</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtVideoBitrateMode")]
		NSString IPTCExtVideoBitrateMode { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtVideoDisplayAspectRatio</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtVideoDisplayAspectRatio")]
		NSString IPTCExtVideoDisplayAspectRatio { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtVideoEncodingProfile</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtVideoEncodingProfile")]
		NSString IPTCExtVideoEncodingProfile { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtVideoShotType</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtVideoShotType")]
		NSString IPTCExtVideoShotType { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtVideoShotTypeIdentifier</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtVideoShotTypeIdentifier")]
		NSString IPTCExtVideoShotTypeIdentifier { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtVideoShotTypeName</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtVideoShotTypeName")]
		NSString IPTCExtVideoShotTypeName { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtVideoStreamsCount</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtVideoStreamsCount")]
		NSString IPTCExtVideoStreamsCount { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtVisualColor</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtVisualColor")]
		NSString IPTCExtVisualColor { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtWorkflowTag</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtWorkflowTag")]
		NSString IPTCExtWorkflowTag { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtWorkflowTagCvId</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtWorkflowTagCvId")]
		NSString IPTCExtWorkflowTagCvId { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtWorkflowTagCvTermId</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtWorkflowTagCvTermId")]
		NSString IPTCExtWorkflowTagCvTermId { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtWorkflowTagCvTermName</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtWorkflowTagCvTermName")]
		NSString IPTCExtWorkflowTagCvTermName { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyIPTCExtWorkflowTagCvTermRefinedAbout</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyIPTCExtWorkflowTagCvTermRefinedAbout")]
		NSString IPTCExtWorkflowTagCvTermRefinedAbout { get; }

		/// <summary>Represents the value associated with the constant kCGImagePropertyOpenEXRAspectRatio</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyOpenEXRAspectRatio")]
		NSString OpenExrAspectRatio { get; }

		/// <summary>Gets the PrimaryImage property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImagePropertyPrimaryImage")]
		NSString PrimaryImage { get; }

		// WebP Dictionary Keys

		[iOS (14, 0)]
		[TV (14, 0)]
		[MacCatalyst (14, 0)]
		[Field ("kCGImagePropertyWebPLoopCount")]
		NSString WebPLoopCount { get; }

		[iOS (14, 0)]
		[TV (14, 0)]
		[MacCatalyst (14, 0)]
		[Field ("kCGImagePropertyWebPDelayTime")]
		NSString WebPDelayTime { get; }

		[iOS (14, 0)]
		[TV (14, 0)]
		[MacCatalyst (14, 0)]
		[Field ("kCGImagePropertyWebPUnclampedDelayTime")]
		NSString WebPUnclampedDelayTime { get; }

		[iOS (14, 0)]
		[TV (14, 0)]
		[MacCatalyst (14, 0)]
		[Field ("kCGImagePropertyWebPFrameInfoArray")]
		NSString WebPFrameInfoArray { get; }

		[iOS (14, 0)]
		[TV (14, 0)]
		[MacCatalyst (14, 0)]
		[Field ("kCGImagePropertyWebPCanvasPixelWidth")]
		NSString WebPCanvasPixelWidth { get; }

		[iOS (14, 0)]
		[TV (14, 0)]
		[MacCatalyst (14, 0)]
		[Field ("kCGImagePropertyWebPCanvasPixelHeight")]
		NSString WebPCanvasPixelHeight { get; }

		[iOS (14, 1), TV (14, 2)]
		[MacCatalyst (14, 1)]
		[Field ("kCGImagePropertyTGACompression")]
		NSString TgaCompression { get; }

		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)]
		[Field ("kCGImagePropertyGroupImageIndexLeft")]
		NSString GroupImageIndexLeft { get; }

		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)]
		[Field ("kCGImagePropertyGroupImageIndexRight")]
		NSString GroupImageIndexRight { get; }

		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)]
		[Field ("kCGImagePropertyGroupImageIsAlternateImage")]
		NSString GroupImageIsAlternateImage { get; }

		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)]
		[Field ("kCGImagePropertyGroupImageIsLeftImage")]
		NSString GroupImageIsLeftImage { get; }

		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)]
		[Field ("kCGImagePropertyGroupImageIsRightImage")]
		NSString GroupImageIsRightImage { get; }

		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)]
		[Field ("kCGImagePropertyGroupImagesAlternate")]
		NSString GroupImagesAlternate { get; }

		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)]
		[Field ("kCGImagePropertyGroupIndex")]
		NSString GroupIndex { get; }

		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)]
		[Field ("kCGImagePropertyGroups")]
		NSString Groups { get; }

		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)]
		[Field ("kCGImagePropertyGroupType")]
		NSString GroupType { get; }

		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)]
		[Field ("kCGImagePropertyGroupTypeStereoPair")]
		NSString GroupTypeStereoPair { get; }

		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)]
		[Field ("kCGImagePropertyGroupTypeAlternate")]
		NSString GroupTypeAlternate { get; }

		[iOS (16, 0), Mac (13, 0), TV (16, 0), MacCatalyst (16, 0)]
		[Field ("kCGImagePropertyGroupImageBaseline")]
		NSString GroupImageBaseline { get; }

		[iOS (16, 0), Mac (13, 0), TV (16, 0), MacCatalyst (16, 0)]
		[Field ("kCGImagePropertyGroupImageDisparityAdjustment")]
		NSString GroupImageDisparityAdjustment { get; }

		[iOS (16, 0), Mac (13, 0), TV (16, 0), MacCatalyst (16, 0)]
		[Field ("kCGImagePropertyHEIFDictionary")]
		NSString HeifDictionary { get; }

		[iOS (16, 4), Mac (13, 3), TV (16, 4), MacCatalyst (16, 4)]
		[Field ("kCGImagePropertyOpenEXRCompression")]
		NSString OpenExrCompression { get; }

		[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Field ("kCGImagePropertyGroupImageIndexMonoscopic")]
		NSString GroupImageIndexMonoscopic { get; }

		[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Field ("kCGImagePropertyGroupImageIsMonoscopicImage")]
		NSString GroupImageIsMonoscopicImage { get; }

		[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Field ("kCGImagePropertyGroupImageStereoAggressors")]
		NSString GroupImageStereoAggressors { get; }

		[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Field ("kCGImagePropertyGroupMonoscopicImageLocation")]
		NSString GroupMonoscopicImageLocation { get; }
	}

	/// <summary>Holds constants specifying standard metadata namespaces. Primarily used with <see cref="ImageIO.CGImageMetadataTag.Namespace" />.</summary>
	[Static]
	interface CGImageMetadataTagNamespaces {
		/// <summary>Represents the value associated with the constant kCGImageMetadataNamespaceExif</summary>
		///         <value>
		///         </value>
		[Field ("kCGImageMetadataNamespaceExif")]
		NSString Exif { get; }
		/// <summary>Represents the value associated with the constant kCGImageMetadataNamespaceExifAux</summary>
		///         <value>
		///         </value>
		[Field ("kCGImageMetadataNamespaceExifAux")]
		NSString ExifAux { get; }
		/// <summary>Represents the value associated with the constant kCGImageMetadataNamespaceExifEX</summary>
		///         <value>
		///         </value>
		[Field ("kCGImageMetadataNamespaceExifEX")]
		[MacCatalyst (13, 1)]
		NSString ExifEx { get; }
		/// <summary>Represents the value associated with the constant kCGImageMetadataNamespaceDublinCore</summary>
		///         <value>
		///         </value>
		[Field ("kCGImageMetadataNamespaceDublinCore")]
		NSString DublinCore { get; }
		/// <summary>Represents the value associated with the constant kCGImageMetadataNamespaceIPTCCore</summary>
		///         <value>
		///         </value>
		[Field ("kCGImageMetadataNamespaceIPTCCore")]
		NSString IPTCCore { get; }
		/// <summary>Represents the value associated with the constant kCGImageMetadataNamespacePhotoshop</summary>
		///         <value>
		///         </value>
		[Field ("kCGImageMetadataNamespacePhotoshop")]
		NSString Photoshop { get; }
		/// <summary>Represents the value associated with the constant kCGImageMetadataNamespaceTIFF</summary>
		///         <value>
		///         </value>
		[Field ("kCGImageMetadataNamespaceTIFF")]
		NSString TIFF { get; }
		/// <summary>Represents the value associated with the constant kCGImageMetadataNamespaceXMPBasic</summary>
		///         <value>
		///         </value>
		[Field ("kCGImageMetadataNamespaceXMPBasic")]
		NSString XMPBasic { get; }
		/// <summary>Represents the value associated with the constant kCGImageMetadataNamespaceXMPRights</summary>
		///         <value>
		///         </value>
		[Field ("kCGImageMetadataNamespaceXMPRights")]
		NSString XMPRights { get; }
		/// <summary>Gets the IPTCExtension property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImageMetadataNamespaceIPTCExtension")]
		NSString IPTCExtension { get; }
	}

	/// <summary>Constants defining standard prefixes. Primarily used with <see cref="ImageIO.CGImageMetadataTag.Prefix" />.</summary>
	[Static]
	interface CGImageMetadataTagPrefixes {
		/// <summary>Represents the value associated with the constant kCGImageMetadataPrefixExif</summary>
		///         <value>
		///         </value>
		[Field ("kCGImageMetadataPrefixExif")]
		NSString Exif { get; }
		/// <summary>Represents the value associated with the constant kCGImageMetadataPrefixExifAux</summary>
		///         <value>
		///         </value>
		[Field ("kCGImageMetadataPrefixExifAux")]
		NSString ExifAux { get; }
		/// <summary>Represents the value associated with the constant kCGImageMetadataPrefixExifEX</summary>
		///         <value>
		///         </value>
		[Field ("kCGImageMetadataPrefixExifEX")]
		[MacCatalyst (13, 1)]
		NSString ExifEx { get; }
		/// <summary>Represents the value associated with the constant kCGImageMetadataPrefixDublinCore</summary>
		///         <value>
		///         </value>
		[Field ("kCGImageMetadataPrefixDublinCore")]
		NSString DublinCore { get; }
		/// <summary>Represents the value associated with the constant kCGImageMetadataPrefixIPTCCore</summary>
		///         <value>
		///         </value>
		[Field ("kCGImageMetadataPrefixIPTCCore")]
		NSString IPTCCore { get; }
		/// <summary>Represents the value associated with the constant kCGImageMetadataPrefixPhotoshop</summary>
		///         <value>
		///         </value>
		[Field ("kCGImageMetadataPrefixPhotoshop")]
		NSString Photoshop { get; }
		/// <summary>Represents the value associated with the constant kCGImageMetadataPrefixTIFF</summary>
		///         <value>
		///         </value>
		[Field ("kCGImageMetadataPrefixTIFF")]
		NSString TIFF { get; }
		/// <summary>Represents the value associated with the constant kCGImageMetadataPrefixXMPBasic</summary>
		///         <value>
		///         </value>
		[Field ("kCGImageMetadataPrefixXMPBasic")]
		NSString XMPBasic { get; }
		/// <summary>Represents the value associated with the constant kCGImageMetadataPrefixXMPRights</summary>
		///         <value>
		///         </value>
		[Field ("kCGImageMetadataPrefixXMPRights")]
		NSString XMPRights { get; }
		/// <summary>Gets the IPTCExtension property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImageMetadataPrefixIPTCExtension")]
		NSString IPTCExtension { get; }
	}

	interface CGImageMetadata : INativeObject {
		[Field ("kCFErrorDomainCGImageMetadata")]
		NSString ErrorDomain { get; }
	}

	/// <summary>Use an instance of this class to configure the CGImageSource.</summary>
	[Partial]
	interface CGImageOptions {
		[Internal]
		[Field ("kCGImageSourceTypeIdentifierHint")]
		IntPtr kTypeIdentifierHint { get; }

		[Internal]
		[Field ("kCGImageSourceShouldCache")]
		IntPtr kShouldCache { get; }

		[MacCatalyst (13, 1)]
		[Internal]
		[Field ("kCGImageSourceShouldCacheImmediately")]
		IntPtr kShouldCacheImmediately { get; }

		[Internal]
		[Field ("kCGImageSourceShouldAllowFloat")]
		IntPtr kShouldAllowFloat { get; }
	}

	/// <summary>Configuration options used when loading thumbnails using CGImageSource.</summary>
	[Partial]
	interface CGImageThumbnailOptions {
		[Internal]
		[Field ("kCGImageSourceCreateThumbnailFromImageIfAbsent")]
		IntPtr kCreateThumbnailFromImageIfAbsent { get; }

		[Internal]
		[Field ("kCGImageSourceCreateThumbnailFromImageAlways")]
		IntPtr kCreateThumbnailFromImageAlways { get; }

		[Internal]
		[Field ("kCGImageSourceThumbnailMaxPixelSize")]
		IntPtr kThumbnailMaxPixelSize { get; }

		[Internal]
		[Field ("kCGImageSourceCreateThumbnailWithTransform")]
		IntPtr kCreateThumbnailWithTransform { get; }

		[MacCatalyst (13, 1)]
		[Internal]
		[Field ("kCGImageSourceSubsampleFactor")]
		IntPtr kCGImageSourceSubsampleFactor { get; }
	}

	[Partial]
	[TV (17, 0), Mac (14, 0), iOS (17, 0), MacCatalyst (17, 0)]
	interface CGImageDecodeOptions {
		[Internal]
		[Field ("kCGImageSourceDecodeRequest")]
		IntPtr DecodeRequest { get; }

		[Internal]
		[Field ("kCGImageSourceDecodeToHDR")]
		IntPtr DecodeToHDR { get; }

		[Internal]
		[Field ("kCGImageSourceDecodeToSDR")]
		IntPtr DecodeToSDR { get; }

		[iOS (18, 0), MacCatalyst (18, 0), TV (18, 0), Mac (15, 0)]
		[Internal]
		[Field ("kCGImageSourceGenerateImageSpecificLumaScaling")]
		IntPtr GenerateImageSpecificLumaScaling { get; }

		[Internal]
		[Field ("kCGImageSourceDecodeRequestOptions")]
		IntPtr DecodeRequestOptions { get; }

		[Internal]
		[MacCatalyst (26, 0), TV (26, 0), Mac (26, 0), iOS (26, 0)]
		[Field ("kCGComputeHDRStats")]
		IntPtr ComputeHdrStats { get; }
	}

	/// <summary>Specifies whether the callback in <see cref="ImageIO.CGImageMetadata.EnumerateTags(Foundation.NSString,ImageIO.CGImageMetadataEnumerateOptions,ImageIO.CGImageMetadataTagBlock)" /> is recursive.</summary>
	[Partial]
	interface CGImageMetadataEnumerateOptions {
		[Internal]
		[Field ("kCGImageMetadataEnumerateRecursively")]
		IntPtr kCGImageMetadataEnumerateRecursively { get; }
	}

	// Defined in CGImageProperties.cs in CoreGraphics
	interface CGImagePropertiesTiff { }
	interface CGImagePropertiesExif { }
	interface CGImagePropertiesJfif { }
	interface CGImagePropertiesPng { }
	interface CGImagePropertiesGps { }
	interface CGImagePropertiesIptc { }

	/// <summary>Use an instance of this class to configure how an image is added to a <see cref="ImageIO.CGImageDestination" />.</summary>
	///     <remarks>
	///       <para>Use this class to configure the parameters when you add an image to CGImageDestination.</para>
	///     </remarks>
	[StrongDictionary ("CGImageDestinationOptionsKeys")]
	interface CGImageDestinationOptions {

		/// <summary>The quality used to encode the image.</summary>
		///         <value>Values between 0.0 (maximum compression) and 1.0 (no compression, use lossless).</value>
		[Export ("LossyCompressionQuality")]
		float LossyCompressionQuality { get; set; }

		/// <summary />
		[MacCatalyst (13, 1)]
		[Export ("ImageMaxPixelSize")]
		int ImageMaxPixelSize { get; set; }

		/// <summary>Controls whether to embed a JPEG image thumbnail in the destination file.</summary>
		[MacCatalyst (13, 1)]
		[Export ("EmbedThumbnail")]
		bool EmbedThumbnail { get; set; }

		/// <summary>Gets or sets the OptimizeColorForSharing value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("OptimizeColorForSharing")]
		bool OptimizeColorForSharing { get; set; }

		/// <summary>Gets or sets the TiffDictionary value.</summary>
		[StrongDictionary]
		[Export ("TIFFDictionary")]
		CGImagePropertiesTiff TiffDictionary { get; set; }

		/// <summary>Gets or sets the GifDictionary value.</summary>
		[Export ("GIFDictionary")]
		NSDictionary GifDictionary { get; set; }

		/// <summary>Gets or sets the JfifDictionary value.</summary>
		[StrongDictionary]
		[Export ("JFIFDictionary")]
		CGImagePropertiesJfif JfifDictionary { get; set; }

		/// <summary>Gets or sets the ExifDictionary value.</summary>
		[StrongDictionary]
		[Export ("ExifDictionary")]
		CGImagePropertiesExif ExifDictionary { get; set; }

		/// <summary>Gets or sets the PngDictionary value.</summary>
		[StrongDictionary]
		[Export ("PNGDictionary")]
		CGImagePropertiesPng PngDictionary { get; set; }

		/// <summary>Gets or sets the IptcDictionary value.</summary>
		[StrongDictionary]
		[Export ("IPTCDictionary")]
		CGImagePropertiesIptc IptcDictionary { get; set; }

		/// <summary>Gets or sets the GpsDictionary value.</summary>
		[StrongDictionary]
		[Export ("GPSDictionary")]
		CGImagePropertiesGps GpsDictionary { get; set; }

		/// <summary>Gets or sets the RawDictionary value.</summary>
		[Export ("RawDictionary")]
		NSDictionary RawDictionary { get; set; }

		/// <summary>Gets or sets the CiffDictionary value.</summary>
		[Export ("CIFFDictionary")]
		NSDictionary CiffDictionary { get; set; }

		/// <summary>Gets or sets the EightBimDictionary value.</summary>
		[Export ("EightBIMDictionary")]
		NSDictionary EightBimDictionary { get; set; }

		/// <summary>Gets or sets the DngDictionary value.</summary>
		[Export ("DNGDictionary")]
		NSDictionary DngDictionary { get; set; }

		/// <summary>Gets or sets the ExifAuxDictionary value.</summary>
		[Export ("ExifAuxDictionary")]
		NSDictionary ExifAuxDictionary { get; set; }

		[iOS (14, 0), TV (14, 0)]
		[MacCatalyst (14, 0)]
		[Export ("WebPDictionary")]
		NSDictionary WebPDictionary { get; set; }

		[iOS (14, 1), TV (14, 2)]
		[MacCatalyst (14, 1)]
		[Export ("TgaDictionary")]
		NSDictionary TgaDictionary { get; set; }

		[Mac (14, 0), iOS (17, 0), TV (17, 0), MacCatalyst (17, 0)]
		[Export ("AvisDictionary")]
		NSDictionary AvisDictionary { get; set; }

		[iOS (14, 1)]
		[TV (14, 2)]
		[MacCatalyst (14, 1)]
		bool PreserveGainMap { get; set; }
	}

	/// <summary>Contains keys that index image destination options.</summary>
	[Static]
	interface CGImageDestinationOptionsKeys {

		/// <summary>Gets the LossyCompressionQuality property key.</summary>
		[Field ("kCGImageDestinationLossyCompressionQuality")]
		NSString LossyCompressionQuality { get; }

		/// <summary>Gets the BackgroundColor property key.</summary>
		[Field ("kCGImageDestinationBackgroundColor")]
		NSString BackgroundColor { get; }

		/// <summary>Gets the ImageMaxPixelSize property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImageDestinationImageMaxPixelSize")]
		NSString ImageMaxPixelSize { get; }

		/// <summary>Gets the EmbedThumbnail property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImageDestinationEmbedThumbnail")]
		NSString EmbedThumbnail { get; }

		/// <summary>Gets the OptimizeColorForSharing property key.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImageDestinationOptimizeColorForSharing")]
		NSString OptimizeColorForSharing { get; }

		// [Field ("kCGImagePropertyTIFFDictionary")]
		/// <summary>Gets the TIFFDictionary property key.</summary>
		[Static]
		[Wrap ("CGImageProperties.TIFFDictionary")]
		NSString TIFFDictionary { get; }

		// [Field ("kCGImagePropertyGIFDictionary")]
		/// <summary>Gets the GIFDictionary property key.</summary>
		[Static]
		[Wrap ("CGImageProperties.GIFDictionary")]
		NSString GIFDictionary { get; }

		// [Field ("kCGImagePropertyJFIFDictionary")]
		/// <summary>Gets the JFIFDictionary property key.</summary>
		[Static]
		[Wrap ("CGImageProperties.JFIFDictionary")]
		NSString JFIFDictionary { get; }

		// [Field ("kCGImagePropertyExifDictionary")]
		/// <summary>Gets the ExifDictionary property key.</summary>
		[Static]
		[Wrap ("CGImageProperties.ExifDictionary")]
		NSString ExifDictionary { get; }

		// [Field ("kCGImagePropertyPNGDictionary")]
		/// <summary>Gets the PNGDictionary property key.</summary>
		[Static]
		[Wrap ("CGImageProperties.PNGDictionary")]
		NSString PNGDictionary { get; }

		// [Field ("kCGImagePropertyIPTCDictionary")]
		/// <summary>Gets the IPTCDictionary property key.</summary>
		[Static]
		[Wrap ("CGImageProperties.IPTCDictionary")]
		NSString IPTCDictionary { get; }

		// [Field ("kCGImagePropertyGPSDictionary")]
		/// <summary>Gets the GPSDictionary property key.</summary>
		[Static]
		[Wrap ("CGImageProperties.GPSDictionary")]
		NSString GPSDictionary { get; }

		// [Field ("kCGImagePropertyRawDictionary")]
		/// <summary>Gets the RawDictionary property key.</summary>
		[Static]
		[Wrap ("CGImageProperties.RawDictionary")]
		NSString RawDictionary { get; }

		// [Field ("kCGImagePropertyCIFFDictionary")]
		/// <summary>Gets the CIFFDictionary property key.</summary>
		[Static]
		[Wrap ("CGImageProperties.CIFFDictionary")]
		NSString CIFFDictionary { get; }

		// [Field ("kCGImageProperty8BIMDictionary")]
		/// <summary>Gets the EightBIMDictionary property key.</summary>
		[Static]
		[Wrap ("CGImageProperties.EightBIMDictionary")]
		NSString EightBIMDictionary { get; }

		// [Field ("kCGImagePropertyDNGDictionary")]
		/// <summary>Gets the DNGDictionary property key.</summary>
		[Static]
		[Wrap ("CGImageProperties.DNGDictionary")]
		NSString DNGDictionary { get; }

		// [Field ("kCGImagePropertyExifAuxDictionary")]
		/// <summary>Gets the ExifAuxDictionary property key.</summary>
		[Static]
		[Wrap ("CGImageProperties.ExifAuxDictionary")]
		NSString ExifAuxDictionary { get; }

		[iOS (14, 0), TV (14, 0)]
		[MacCatalyst (14, 0)]
		[Static]
		[Wrap ("CGImageProperties.WebPDictionary")]
		NSString WebPDictionary { get; }

		[iOS (14, 1), TV (14, 2)]
		[MacCatalyst (14, 1)]
		[Static]
		[Wrap ("CGImageProperties.TgaDictionary")]
		NSString TgaDictionary { get; }

		[Mac (14, 0), iOS (17, 0), TV (17, 0)]
		[MacCatalyst (17, 0)]
		[Static]
		[Wrap ("CGImageProperties.AvisDictionary")]
		NSString AvisDictionary { get; }

		[iOS (14, 1)]
		[TV (14, 2)]
		[MacCatalyst (14, 1)]
		[Field ("kCGImageDestinationPreserveGainMap")]
		NSString PreserveGainMapKey { get; }

		[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Field ("kCGImageDestinationEncodeRequest")]
		NSString EncodeRequest { get; }

		[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Field ("kCGImageDestinationEncodeToSDR")]
		NSString EncodeToSdr { get; }

		[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Field ("kCGImageDestinationEncodeToISOHDR")]
		NSString EncodeToIsoHdr { get; }

		[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Field ("kCGImageDestinationEncodeToISOGainmap")]
		NSString EncodeToIsoGainmap { get; }

		[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Field ("kCGImageDestinationEncodeRequestOptions")]
		NSString EncodeRequestOptions { get; }

		[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Field ("kCGImageDestinationEncodeBaseIsSDR")]
		NSString EncodeBaseIsSdr { get; }

		[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Field ("kCGImageDestinationEncodeTonemapMode")]
		NSString EncodeTonemapMode { get; }

		[MacCatalyst (26, 0), TV (26, 0), Mac (26, 0), iOS (26, 0)]
		[Field ("kCGImageDestinationEncodeIsBaseImage")]
		NSString EncodeIsBaseImage { get; }

		[MacCatalyst (26, 0), TV (26, 0), Mac (26, 0), iOS (26, 0)]
		[Field ("kCGImageDestinationEncodeBaseColorSpace")]
		NSString EncodeBaseColorSpace { get; }

		[MacCatalyst (26, 0), TV (26, 0), Mac (26, 0), iOS (26, 0)]
		[Field ("kCGImageDestinationEncodeBasePixelFormatRequest")]
		NSString EncodeBasePixelFormatRequest { get; }

		[MacCatalyst (26, 0), TV (26, 0), Mac (26, 0), iOS (26, 0)]
		[Field ("kCGImageDestinationEncodeGenerateGainMapWithBaseImage")]
		NSString EncodeGenerateGainMapWithBaseImage { get; }

		[MacCatalyst (26, 0), TV (26, 0), Mac (26, 0), iOS (26, 0)]
		[Field ("kCGImageDestinationEncodeGainMapPixelFormatRequest")]
		NSString EncodeGainMapPixelFormatRequest { get; }

		[MacCatalyst (26, 0), TV (26, 0), Mac (26, 0), iOS (26, 0)]
		[Field ("kCGImageDestinationEncodeGainMapSubsampleFactor")]
		NSString EncodeGainMapSubsampleFactor { get; }

		[MacCatalyst (26, 0), TV (26, 0), Mac (26, 0), iOS (26, 0)]
		[Field ("kCGImageDestinationEncodeAlternateColorSpace")]
		NSString EncodeAlternateColorSpace { get; }
	}

	[MacCatalyst (13, 1)]
	[Static]
	[Internal]
	interface CGCopyImageSourceOptionsKeys {

		[Field ("kCGImageDestinationMetadata")]
		NSString MetadataKey { get; }

		[Field ("kCGImageDestinationMergeMetadata")]
		NSString MergeMetadataKey { get; }

		[Field ("kCGImageMetadataShouldExcludeXMP")]
		NSString ShouldExcludeXmpKey { get; }

		[Field ("kCGImageMetadataShouldExcludeGPS")]
		NSString ShouldExcludeGpsKey { get; }

		[Field ("kCGImageDestinationDateTime")]
		NSString DateTimeKey { get; }

		[Field ("kCGImageDestinationOrientation")]
		NSString OrientationKey { get; }

		[Field ("kCGImagePropertyEncoder")]
		NSString EncoderKey { get; }

		[Field ("kCGImagePropertyBCFormat")]
		NSString BCFormatKey { get; }

		[Field ("kCGImagePropertyASTCBlockSize")]
		NSString AstcBlockSizeKey { get; }
	}

	[StrongDictionary ("CGCopyImageSourceOptionsKeys")]
	interface CGCopyImageSourceOptions {
		CGImageMetadata Metadata { get; set; }

#if XAMCORE_5_0
		bool MergeMetadata { get; set; }

		bool ShouldExcludeXmp { get; set; }

		bool ShouldExcludeGps { get; set; }
#endif

#if !XAMCORE_6_0
#if XAMCORE_5_0
		[Obsolete ("Use 'MergeMetadata' instead.")]
#endif
		[Export ("MergeMetadataKey")]
		bool NullableMergeMetadata { get; set; }

#if XAMCORE_5_0
		[Obsolete ("Use 'ShouldExcludeXmp' instead.")]
#endif
		[Export ("ShouldExcludeXmpKey")]
		bool NullableShouldExcludeXmp { get; set; }

#if XAMCORE_5_0
		[Obsolete ("Use 'ShouldExcludeGps' instead.")]
#endif
		[Export ("ShouldExcludeGpsKey")]
		bool NullableShouldExcludeGps { get; set; }
#endif

		DateTime DateTime { get; set; }

		int Orientation { get; set; }

		CGImagePropertyEncoder Encoder { get; set; }

		int BCFormat { get; set; }

		[MacCatalyst (26, 0), TV (26, 0), Mac (26, 0), iOS (26, 0)]
		CGImagePropertyAstcBlockSize AstcBlockSize { get; set; }
	}

	[MacCatalyst (13, 1)]
	enum CGImageAuxiliaryDataType {
		/// <summary>The depth auxiliary data type.</summary>
		[Field ("kCGImageAuxiliaryDataTypeDepth")]
		Depth,

		/// <summary>The disparity auxiliary data type.</summary>
		[Field ("kCGImageAuxiliaryDataTypeDisparity")]
		Disparity,

		/// <summary>The portrait effects matte auxiliary data type.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCGImageAuxiliaryDataTypePortraitEffectsMatte")]
		PortraitEffectsMatte,

		[iOS (13, 0)]
		[TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kCGImageAuxiliaryDataTypeSemanticSegmentationHairMatte")]
		SemanticSegmentationHairMatte,

		[iOS (13, 0)]
		[TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kCGImageAuxiliaryDataTypeSemanticSegmentationSkinMatte")]
		SemanticSegmentationSkinMatte,

		[iOS (13, 0)]
		[TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kCGImageAuxiliaryDataTypeSemanticSegmentationTeethMatte")]
		SemanticSegmentationTeethMatte,

		[iOS (14, 1)]
		[TV (14, 2)]
		[MacCatalyst (14, 1)]
		[Field ("kCGImageAuxiliaryDataTypeSemanticSegmentationGlassesMatte")]
		SemanticSegmentationGlassesMatte,

		[iOS (14, 1)]
		[TV (14, 2)]
		[MacCatalyst (14, 1)]
		[Field ("kCGImageAuxiliaryDataTypeHDRGainMap")]
		TypeHdrGainMap,

		[iOS (14, 3)]
		[TV (14, 3)]
		[MacCatalyst (14, 3)]
		[Field ("kCGImageAuxiliaryDataTypeSemanticSegmentationSkyMatte")]
		SemanticSegmentationSkyMatte,

		[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Field ("kCGImageAuxiliaryDataTypeISOGainMap")]
		IsoGainMap,
	}

	[MacCatalyst (13, 1)]
	[Static]
	[Internal]
	interface CGImageAuxiliaryDataInfoKeys {
		[Field ("kCGImageAuxiliaryDataInfoData")]
		NSString DataKey { get; }

		[Field ("kCGImageAuxiliaryDataInfoDataDescription")]
		NSString DataDescriptionKey { get; }

		[Field ("kCGImageAuxiliaryDataInfoMetadata")]
		NSString MetadataKey { get; }

		[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Field ("kCGImageAuxiliaryDataInfoColorSpace")]
		NSString ColorSpaceKey { get; }
	}

	[MacCatalyst (13, 1)]
	[StrongDictionary ("CGImageAuxiliaryDataInfoKeys")]
	interface CGImageAuxiliaryDataInfo {

		/// <summary>Gets or sets the Data value.</summary>
		NSData Data { get; set; }
		/// <summary>Gets or sets the DataDescription value.</summary>
		NSDictionary DataDescription { get; set; }
		// Bound manually:
		// CGImageMetadata Metadata { get; set; }))
		[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		CGColorSpace ColorSpace { get; set; }
	}

	[iOS (13, 0), TV (13, 0)]
	[MacCatalyst (13, 1)]
	[Static]
	[Internal]
	interface CGImageAnimationOptionsKeys {
		[Field ("kCGImageAnimationDelayTime")]
		NSString DelayTimeKey { get; }

		[Field ("kCGImageAnimationLoopCount")]
		NSString LoopCountKey { get; }

		[Field ("kCGImageAnimationStartIndex")]
		NSString StartIndexKey { get; }
	}

	[iOS (13, 0), TV (13, 0)]
	[MacCatalyst (13, 1)]
	[StrongDictionary ("CGImageAnimationOptionsKeys")]
	interface CGImageAnimationOptions {
		double DelayTime { get; set; }

		nuint LoopCount { get; set; }

		nuint StartIndex { get; set; }
	}

	[Static]
	[iOS (16, 0), Mac (13, 0), TV (16, 0), MacCatalyst (16, 0)]
	interface IOCameraExtrinsics {
		[Field ("kIIOCameraExtrinsics_CoordinateSystemID")]
		NSString CoordinateSystemId { get; }

		[Field ("kIIOCameraExtrinsics_Position")]
		NSString Position { get; }

		[Field ("kIIOCameraExtrinsics_Rotation")]
		NSString Rotation { get; }
	}

	[Static]
	[iOS (16, 0), Mac (13, 0), TV (16, 0), MacCatalyst (16, 0)]
	interface IOCameraModel {
		[Field ("kIIOCameraModel_Intrinsics")]
		NSString Intrinsics { get; }

		[Mac (13, 0), iOS (16, 0)]
		[MacCatalyst (16, 0)]
		[Field ("kIIOCameraModel_ModelType")]
		NSString ModelType { get; }
	}

	[Static]
	[iOS (16, 0), Mac (13, 0), TV (16, 0), MacCatalyst (16, 0)]
	interface IOCameraModelType {
		[Field ("kIIOCameraModelType_SimplifiedPinhole")]
		NSString SimplifiedPinhole { get; }

		[Field ("kIIOCameraModelType_GenericPinhole")]
		NSString GenericPinhole { get; }
	}

	[Static]
	[MacCatalyst (26, 0), TV (26, 0), Mac (26, 0), iOS (26, 0)]
	interface CGImageProviderPreferredTileSize {
		[Field ("kCGImageProviderPreferredTileWidth")]
		NSString Width { get; }

		[Field ("kCGImageProviderPreferredTileHeight")]
		NSString Height { get; }
	}

	[Static]
	[iOS (16, 0), Mac (13, 0), TV (16, 0), MacCatalyst (16, 0)]
	interface IOMetadata {
		[Field ("kIIOMetadata_CameraExtrinsicsKey")]
		NSString CameraExtrinsicsKey { get; }

		[Field ("kIIOMetadata_CameraModelKey")]
		NSString CameraModelKey { get; }
	}

	[Static]
	[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	interface IOStereoAggressors {
		[Field ("kIIOStereoAggressors_Type")]
		NSString Type { get; }

		[Field ("kIIOStereoAggressors_SubTypeURI")]
		NSString SubTypeUri { get; }

		[Field ("kIIOStereoAggressors_Severity")]
		NSString Severity { get; }
	}

	[Static]
	[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	interface IOMonoscopicImageLocation {
		[Field ("kIIOMonoscopicImageLocation_Unspecified")]
		NSString Unspecified { get; }

		[Field ("kIIOMonoscopicImageLocation_Left")]
		NSString Left { get; }

		[Field ("kIIOMonoscopicImageLocation_Right")]
		NSString Right { get; }

		[Field ("kIIOMonoscopicImageLocation_Center")]
		NSString Center { get; }
	}

	enum CGImagePropertyEncoder {
		// ASTC: Adaptive Scalable Texture Compression
		[Field ("kCGImagePropertyASTCEncoder")]
		AstcEncoder,

		[Field ("kCGImagePropertyPVREncoder")]
		PvrEncoder,

		[Field ("kCGImagePropertyBCEncoder")]
		BCEncoder,
	}

	[MacCatalyst (26, 0), TV (26, 0), Mac (26, 0), iOS (26, 0)]
	enum CGImagePropertyAstcBlockSize {
		[Field ("kCGImagePropertyASTCBlockSize4x4")]
		BlockSize4x4,

		[Field ("kCGImagePropertyASTCBlockSize8x8")]
		BlockSize8x8,
	}
}
