// 
// CGImageProperties.cs: Accessors to various kCGImageProperty values
//
// Authors: Marek Safar (marek.safar@gmail.com)
//     
// Copyright 2012-2014, Xamarin Inc.
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

#nullable enable

using CoreFoundation;
using CoreImage;
#if !COREBUILD
using Keys = ImageIO.CGImageProperties;
#endif

namespace CoreGraphics {

	// convenience enum mapped to kCGImagePropertyColorModelXXX fields (see imageio.cs)
	/// <summary>An enumeration of valid color models.</summary>
	public enum CGImageColorModel {
		/// <summary>R G B.</summary>
		RGB,
		/// <summary>Gray.</summary>
		Gray,
		/// <summary>C M Y K.</summary>
		CMYK,
		/// <summary>Lab.</summary>
		Lab,
	}

	/// <summary>Properties of bitmap images.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CGImageProperties : DictionaryContainer {
#if !COREBUILD

		/// <summary>Creates a new CGImageProperties instance.</summary>
		public CGImageProperties ()
			: base (new NSMutableDictionary ())
		{
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>Creates a CGImageProperties from a dictionary.</summary>
		public CGImageProperties (NSDictionary? dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets or sets whether an image has an alpha channel.</summary>
		public bool? Alpha {
			get {
				return GetBoolValue (Keys.HasAlpha);
			}
			set {
				SetBooleanValue (Keys.HasAlpha, value);
			}
		}

		/// <summary>Gets or sets the color model for an image, as a <see cref="CoreGraphics.CGImageColorModel" /> object.</summary>
		public CGImageColorModel? ColorModel {
			get {
				var v = GetNSStringValue (Keys.ColorModel);
				if (v == Keys.ColorModelRGB)
					return CGImageColorModel.RGB;
				if (v == Keys.ColorModelGray)
					return CGImageColorModel.Gray;
				if (v == Keys.ColorModelCMYK)
					return CGImageColorModel.CMYK;
				if (v == Keys.ColorModelLab)
					return CGImageColorModel.Lab;
				return null;
			}
			set {
				NSString key;
				switch (value) {
				case CGImageColorModel.RGB:
					key = Keys.ColorModelRGB;
					break;
				case CGImageColorModel.Gray:
					key = Keys.ColorModelGray;
					break;
				case CGImageColorModel.CMYK:
					key = Keys.ColorModelCMYK;
					break;
				case CGImageColorModel.Lab:
					key = Keys.ColorModelLab;
					break;
				default:
					throw new ArgumentOutOfRangeException ("value");
				}

				SetNativeValue (Keys.ColorModel, key);
			}
		}

		/// <summary>Gets or sets the number of bits in the color sample of each pixel for an image.</summary>
		public int? Depth {
			get {
				return GetInt32Value (Keys.Depth);
			}
			set {
				SetNumberValue (Keys.Depth, value);
			}
		}

		/// <summary>Gets or sets the resolution, in dots per inch, of an image for the x axis.</summary>
		public float? DPIHeightF {
			get {
				return GetFloatValue (Keys.DPIHeight);
			}
			set {
				SetNumberValue (Keys.DPIHeight, value);
			}
		}

		/// <summary>Gets or sets the resolution, in dots per inch, of an image for the y axis.</summary>
		public float? DPIWidthF {
			get {
				return GetFloatValue (Keys.DPIWidth);
			}
			set {
				SetNumberValue (Keys.DPIWidth, value);
			}
		}

		/// <summary>Gets or sets the size of the image file, in bytes.</summary>
		public int? FileSize {
			get {
				return GetInt32Value (Keys.FileSize);
			}
			set {
				SetNumberValue (Keys.FileSize, value);
			}
		}

		/// <summary>Gets or sets whether an image contains floating-point pixel samples.</summary>
		public bool? IsFloat {
			get {
				return GetBoolValue (Keys.IsFloat);
			}
			set {
				SetBooleanValue (Keys.IsFloat, value);
			}
		}

		/// <summary>Gets or sets whether an image contains indexed pixel samples.</summary>
		public bool? IsIndexed {
			get {
				return GetBoolValue (Keys.IsIndexed);
			}
			set {
				SetBooleanValue (Keys.IsIndexed, value);
			}
		}

		/// <summary>Gets or sets the orientation of an image, as a <see cref="CoreImage.CIImageOrientation" /> object.</summary>
		public CIImageOrientation? Orientation {
			get {
				return (CIImageOrientation?) GetInt32Value (Keys.Orientation);
			}
			set {
				SetNumberValue (Keys.Orientation, (int?) value);
			}
		}

		/// <summary>Gets or sets the number of pixels in an image for the y axis.</summary>
		public int? PixelHeight {
			get {
				return GetInt32Value (Keys.PixelHeight);
			}
			set {
				SetNumberValue (Keys.PixelHeight, value);
			}
		}

		/// <summary>Gets or sets the number of pixels in an image for the x axis.</summary>
		public int? PixelWidth {
			get {
				return GetInt32Value (Keys.PixelWidth);
			}
			set {
				SetNumberValue (Keys.PixelWidth, value);
			}
		}

		/// <summary>Gets or sets name of the ICC profile for an image.</summary>
		public string? ProfileName {
			get {
				return GetStringValue (Keys.ProfileName);
			}
			set {
				SetStringValue (Keys.ProfileName, value);
			}
		}

		/// <summary>Gets the EXIF properties.</summary>
		public CGImagePropertiesExif? Exif {
			get {
				var dict = GetNSDictionary (Keys.ExifDictionary);
				return dict is null ? null : new CGImagePropertiesExif (dict);
			}
		}

		/// <summary>Gets the GPS properties.</summary>
		public CGImagePropertiesGps? Gps {
			get {
				var dict = GetNSDictionary (Keys.GPSDictionary);
				return dict is null ? null : new CGImagePropertiesGps (dict);
			}
		}

		/// <summary>Gets the IPTC properties.</summary>
		public CGImagePropertiesIptc? Iptc {
			get {
				var dict = GetNSDictionary (Keys.IPTCDictionary);
				return dict is null ? null : new CGImagePropertiesIptc (dict);
			}
		}

		/// <summary>Gets the PNG properties.</summary>
		public CGImagePropertiesPng? Png {
			get {
				var dict = GetNSDictionary (Keys.PNGDictionary);
				return dict is null ? null : new CGImagePropertiesPng (dict);
			}
		}

		/// <summary>Gets the JFIF properties.</summary>
		public CGImagePropertiesJfif? Jfif {
			get {
				var dict = GetNSDictionary (Keys.JFIFDictionary);
				return dict is null ? null : new CGImagePropertiesJfif (dict);
			}
		}

		/// <summary>Gets the TIFF properties.</summary>
		public CGImagePropertiesTiff? Tiff {
			get {
				var dict = GetNSDictionary (Keys.TIFFDictionary);
				return dict is null ? null : new CGImagePropertiesTiff (dict);
			}
		}

#endif
	}

#if !COREBUILD
	/// <summary>Standard Exif metadata of an image. </summary>
	///     <altmember cref="CoreGraphics.CGImageProperties" />
	///     <altmember cref="CoreGraphics.CGImagePropertiesIptc" />
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CGImagePropertiesExif : DictionaryContainer {
		/// <summary>Creates a new CGImagePropertiesExif instance.</summary>
		public CGImagePropertiesExif ()
			: base (new NSMutableDictionary ())
		{
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>Creates a CGImagePropertiesExif from a dictionary.</summary>
		public CGImagePropertiesExif (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets or sets the aperture.</summary>
		public float? Aperture {
			get {
				return GetFloatValue (Keys.ExifApertureValue);
			}
			set {
				SetNumberValue (Keys.ExifApertureValue, value);
			}
		}

		/// <summary>Gets or sets the brightness.</summary>
		public float? Brightness {
			get {
				return GetFloatValue (Keys.ExifBrightnessValue);
			}
			set {
				SetNumberValue (Keys.ExifBrightnessValue, value);
			}
		}

		/// <summary>Gets or sets the compressed bits per pixel.</summary>
		public float? CompressedBitsPerPixel {
			get {
				return GetFloatValue (Keys.ExifCompressedBitsPerPixel);
			}
			set {
				SetNumberValue (Keys.ExifCompressedBitsPerPixel, value);
			}
		}

		/// <summary>Gets or sets the digital zoom ratio.</summary>
		public float? DigitalZoomRatio {
			get {
				return GetFloatValue (Keys.ExifDigitalZoomRatio);
			}
			set {
				SetNumberValue (Keys.ExifDigitalZoomRatio, value);
			}
		}

		/// <summary>Gets or sets the exposure bias.</summary>
		public float? ExposureBias {
			get {
				return GetFloatValue (Keys.ExifExposureBiasValue);
			}
			set {
				SetNumberValue (Keys.ExifExposureBiasValue, value);
			}
		}

		/// <summary>Gets or sets the exposure index.</summary>
		public float? ExposureIndex {
			get {
				return GetFloatValue (Keys.ExifExposureIndex);
			}
			set {
				SetNumberValue (Keys.ExifExposureIndex, value);
			}
		}

		/// <summary>Gets or sets the exposure time.</summary>
		public float? ExposureTime {
			get {
				return GetFloatValue (Keys.ExifExposureTime);
			}
			set {
				SetNumberValue (Keys.ExifExposureTime, value);
			}
		}

		/// <summary>Gets or sets the exposure program.</summary>
		public int? ExposureProgram {
			get {
				return GetInt32Value (Keys.ExifExposureProgram);
			}
			set {
				SetNumberValue (Keys.ExifExposureProgram, value);
			}
		}

		/// <summary>Gets or sets the flash.</summary>
		public bool? Flash {
			get {
				return GetBoolValue (Keys.ExifFlash);
			}
			set {
				SetBooleanValue (Keys.ExifFlash, value);
			}
		}

		/// <summary>Gets or sets the flash energy.</summary>
		public float? FlashEnergy {
			get {
				return GetFloatValue (Keys.ExifFlashEnergy);
			}
			set {
				SetNumberValue (Keys.ExifFlashEnergy, value);
			}
		}

		/// <summary>Gets or sets the focal plane x resolution.</summary>
		public float? FocalPlaneXResolution {
			get {
				return GetFloatValue (Keys.ExifFocalPlaneXResolution);
			}
			set {
				SetNumberValue (Keys.ExifFocalPlaneXResolution, value);
			}
		}

		/// <summary>Gets or sets the focal plane y resolution.</summary>
		public float? FocalPlaneYResolution {
			get {
				return GetFloatValue (Keys.ExifFocalPlaneYResolution);
			}
			set {
				SetNumberValue (Keys.ExifFocalPlaneYResolution, value);
			}
		}

		/// <summary>Gets or sets the gain control.</summary>
		public float? GainControl {
			get {
				return GetFloatValue (Keys.ExifGainControl);
			}
			set {
				SetNumberValue (Keys.ExifGainControl, value);
			}
		}

		/// <summary>Gets or sets the i s o speed ratings.</summary>
		public int []? ISOSpeedRatings {
			get {
				return GetArray (Keys.ExifISOSpeedRatings, l => new NSNumber (l).Int32Value);
			}
		}

		/// <summary>Gets or sets the maximum lens aperture.</summary>
		public float? MaximumLensAperture {
			get {
				return GetFloatValue (Keys.ExifMaxApertureValue);
			}
			set {
				SetNumberValue (Keys.ExifMaxApertureValue, value);
			}
		}

		/// <summary>Gets or sets the pixel x dimension.</summary>
		public int? PixelXDimension {
			get {
				return GetInt32Value (Keys.ExifPixelXDimension);
			}
			set {
				SetNumberValue (Keys.ExifPixelXDimension, value);
			}
		}

		/// <summary>Gets or sets the pixel y dimension.</summary>
		public int? PixelYDimension {
			get {
				return GetInt32Value (Keys.ExifPixelYDimension);
			}
			set {
				SetNumberValue (Keys.ExifPixelYDimension, value);
			}
		}

		/// <summary>Gets or sets the subject distance.</summary>
		public float? SubjectDistance {
			get {
				return GetFloatValue (Keys.ExifSubjectDistance);
			}
			set {
				SetNumberValue (Keys.ExifSubjectDistance, value);
			}
		}

		/// <summary>Gets or sets the shutter speed.</summary>
		public float? ShutterSpeed {
			get {
				return GetFloatValue (Keys.ExifShutterSpeedValue);
			}
			set {
				SetNumberValue (Keys.ExifShutterSpeedValue, value);
			}
		}

		// TODO: Many more available but underlying types need to be investigated
	}

	/// <summary>Properties associated with TIFF images.</summary>
	///     <altmember cref="CoreGraphics.CGImageProperties" />
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CGImagePropertiesTiff : DictionaryContainer {
		/// <summary>Creates a new CGImagePropertiesTiff instance.</summary>
		public CGImagePropertiesTiff ()
			: base (new NSMutableDictionary ())
		{
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>Creates a CGImagePropertiesTiff from a dictionary.</summary>
		public CGImagePropertiesTiff (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets or sets the orientation.</summary>
		public CIImageOrientation? Orientation {
			get {
				return (CIImageOrientation?) GetInt32Value (Keys.TIFFOrientation);
			}
			set {
				SetNumberValue (Keys.TIFFOrientation, (int?) value);
			}
		}

		/// <summary>Gets or sets the x resolution.</summary>
		public int? XResolution {
			get {
				return GetInt32Value (Keys.TIFFXResolution);
			}
			set {
				SetNumberValue (Keys.TIFFXResolution, value);
			}
		}

		/// <summary>Gets or sets the y resolution.</summary>
		public int? YResolution {
			get {
				return GetInt32Value (Keys.TIFFYResolution);
			}
			set {
				SetNumberValue (Keys.TIFFYResolution, value);
			}
		}

		/// <summary>Gets or sets the software.</summary>
		public string? Software {
			get {
				return GetStringValue (Keys.TIFFSoftware);
			}
			set {
				SetStringValue (Keys.TIFFSoftware, value);
			}
		}

		// TODO: Many more available but underlying types need to be investigated
	}

	/// <summary>Properties associated with JFIF bitmap images.</summary>
	///     <altmember cref="CoreGraphics.CGImageProperties" />
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CGImagePropertiesJfif : DictionaryContainer {
		/// <summary>Creates a new CGImagePropertiesJfif instance.</summary>
		public CGImagePropertiesJfif ()
			: base (new NSMutableDictionary ())
		{
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>Creates a CGImagePropertiesJfif from a dictionary.</summary>
		public CGImagePropertiesJfif (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets or sets the x density.</summary>
		public int? XDensity {
			get {
				return GetInt32Value (Keys.JFIFXDensity);
			}
			set {
				SetNumberValue (Keys.JFIFXDensity, value);
			}
		}

		/// <summary>Gets or sets the y density.</summary>
		public int? YDensity {
			get {
				return GetInt32Value (Keys.JFIFYDensity);
			}
			set {
				SetNumberValue (Keys.JFIFYDensity, value);
			}
		}

		// TODO: Many more available but underlying types need to be investigated
	}

	/// <summary>Properties associated with PNG bitmap images.</summary>
	///     <altmember cref="CoreGraphics.CGImageProperties" />
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CGImagePropertiesPng : DictionaryContainer {
		/// <summary>Creates a new CGImagePropertiesPng instance.</summary>
		public CGImagePropertiesPng ()
			: base (new NSMutableDictionary ())
		{
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>Creates a CGImagePropertiesPng from a dictionary.</summary>
		public CGImagePropertiesPng (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets or sets the author.</summary>
		public string? Author {
			get {
				return GetStringValue (Keys.PNGAuthor);
			}
			set {
				SetStringValue (Keys.PNGAuthor, value);
			}
		}

		/// <summary>Gets or sets the description.</summary>
		public string? Description {
			get {
				return GetStringValue (Keys.PNGDescription);
			}
			set {
				SetStringValue (Keys.PNGDescription, value);
			}
		}

		/// <summary>Gets or sets the gamma.</summary>
		public float? Gamma {
			get {
				return GetFloatValue (Keys.PNGGamma);
			}
			set {
				SetNumberValue (Keys.PNGGamma, value);
			}
		}

		/// <summary>Gets or sets the software.</summary>
		public string? Software {
			get {
				return GetStringValue (Keys.PNGSoftware);
			}
			set {
				SetStringValue (Keys.PNGSoftware, value);
			}
		}

		/// <summary>Gets or sets the x pixels per meter.</summary>
		public int? XPixelsPerMeter {
			get {
				return GetInt32Value (Keys.PNGXPixelsPerMeter);
			}
			set {
				SetNumberValue (Keys.PNGXPixelsPerMeter, value);
			}
		}

		/// <summary>Gets or sets the y pixels per meter.</summary>
		public int? YPixelsPerMeter {
			get {
				return GetInt32Value (Keys.PNGYPixelsPerMeter);
			}
			set {
				SetNumberValue (Keys.PNGYPixelsPerMeter, value);
			}
		}

		/// <summary>Gets or sets the title.</summary>
		public string? Title {
			get {
				return GetStringValue (Keys.PNGTitle);
			}
			set {
				SetStringValue (Keys.PNGTitle, value);
			}
		}

		// TODO: Many more available but underlying types need to be investigated
	}

	/// <summary>Location properties associated with an image.</summary>
	///     <altmember cref="CoreGraphics.CGImageProperties" />
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CGImagePropertiesGps : DictionaryContainer {
		/// <summary>Creates a new CGImagePropertiesGps instance.</summary>
		public CGImagePropertiesGps ()
			: base (new NSMutableDictionary ())
		{
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>Creates a CGImagePropertiesGps from a dictionary.</summary>
		public CGImagePropertiesGps (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets or sets the altitude.</summary>
		public int? Altitude {
			get {
				return GetInt32Value (Keys.GPSAltitude);
			}
			set {
				SetNumberValue (Keys.GPSAltitude, value);
			}
		}

		/// <summary>Gets or sets the latitude.</summary>
		public float? Latitude {
			get {
				return GetFloatValue (Keys.GPSLatitude);
			}
			set {
				SetNumberValue (Keys.GPSLatitude, value);
			}
		}

		public string? LatitudeRef {
			get {
				return GetStringValue (Keys.GPSLatitudeRef);
			}
			set {
				SetStringValue (Keys.GPSLatitudeRef, value);
			}
		}

		/// <summary>Gets or sets the longitude.</summary>
		public float? Longitude {
			get {
				return GetFloatValue (Keys.GPSLongitude);
			}
			set {
				SetNumberValue (Keys.GPSLongitude, value);
			}
		}

		public string? LongitudeRef {
			get {
				return GetStringValue (Keys.GPSLongitudeRef);
			}
			set {
				SetStringValue (Keys.GPSLongitudeRef, value);
			}
		}

		// TODO: Many more available but underlying types need to be investigated
	}

	/// <summary>Properties with IPTC metadata in an image.</summary>
	///     <altmember cref="CoreGraphics.CGImageProperties" />
	///     <altmember cref="CoreGraphics.CGImagePropertiesExif" />
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CGImagePropertiesIptc : DictionaryContainer {
		/// <summary>Creates a new CGImagePropertiesIptc instance.</summary>
		public CGImagePropertiesIptc ()
			: base (new NSMutableDictionary ())
		{
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>Creates a CGImagePropertiesIptc from a dictionary.</summary>
		public CGImagePropertiesIptc (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets or sets the byline.</summary>
		public string? Byline {
			get {
				return GetStringValue (Keys.IPTCByline);
			}
			set {
				SetStringValue (Keys.IPTCByline, value);
			}
		}

		/// <summary>Gets or sets the byline title.</summary>
		public string? BylineTitle {
			get {
				return GetStringValue (Keys.IPTCBylineTitle);
			}
			set {
				SetStringValue (Keys.IPTCBylineTitle, value);
			}
		}

		/// <summary>Gets or sets the caption abstract.</summary>
		public string? CaptionAbstract {
			get {
				return GetStringValue (Keys.IPTCCaptionAbstract);
			}
			set {
				SetStringValue (Keys.IPTCCaptionAbstract, value);
			}
		}

		/// <summary>Gets or sets the city.</summary>
		public string? City {
			get {
				return GetStringValue (Keys.IPTCCity);
			}
			set {
				SetStringValue (Keys.IPTCCity, value);
			}
		}

		/// <summary>Gets or sets the content location name.</summary>
		public string? ContentLocationName {
			get {
				return GetStringValue (Keys.IPTCContentLocationName);
			}
			set {
				SetStringValue (Keys.IPTCContentLocationName, value);
			}
		}

		/// <summary>Gets or sets the country primary location name.</summary>
		public string? CountryPrimaryLocationName {
			get {
				return GetStringValue (Keys.IPTCCountryPrimaryLocationName);
			}
			set {
				SetStringValue (Keys.IPTCCountryPrimaryLocationName, value);
			}
		}

		/// <summary>Gets or sets the copyright notice.</summary>
		public string? CopyrightNotice {
			get {
				return GetStringValue (Keys.IPTCCopyrightNotice);
			}
			set {
				SetStringValue (Keys.IPTCCopyrightNotice, value);
			}
		}

		/// <summary>Gets or sets the credit.</summary>
		public string? Credit {
			get {
				return GetStringValue (Keys.IPTCCredit);
			}
			set {
				SetStringValue (Keys.IPTCCredit, value);
			}
		}

		/// <summary>Gets or sets the source.</summary>
		public string? Source {
			get {
				return GetStringValue (Keys.IPTCSource);
			}
			set {
				SetStringValue (Keys.IPTCSource, value);
			}
		}

		/// <summary>Gets or sets the writer editor.</summary>
		public string? WriterEditor {
			get {
				return GetStringValue (Keys.IPTCWriterEditor);
			}
			set {
				SetStringValue (Keys.IPTCWriterEditor, value);
			}
		}

		// TODO: Many more available but underlying types need to be investigated
	}


#endif
}
