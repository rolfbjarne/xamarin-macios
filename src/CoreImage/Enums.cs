//
// Copyright 2011-2014, Xamarin Inc.
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

namespace CoreImage {

	// convenience enum for values used with kCGImagePropertyOrientation (key) as NSNumber
	// values are part of the header file (CGImageProperties.h) as comments (not constants or fields)
	/// <summary>An enumeration whose values specify the origin of the <see cref="CoreImage.CIImage" />.</summary>
	///     <remarks>
	///       <para>The enumeration values are equal to those of the EXIF and TIFF specifications.</para>
	///     </remarks>
	public enum CIImageOrientation {
		/// <summary>Standard position.</summary>
		TopLeft = 1,
		/// <summary>Mirror image of standard position.</summary>
		TopRight = 2,
		/// <summary>Rotated 180 degrees from standard position.</summary>
		BottomRight = 3,
		/// <summary>Mirror image taken after the standard position image has been rotated 180 degrees.</summary>
		BottomLeft = 4,
		/// <summary>Mirror image taken after the standard position image has been rotated 90 degrees clockwise.</summary>
		LeftTop = 5,
		/// <summary>Rotated 90 degrees counterclockwise from standard position.</summary>
		RightTop = 6,
		/// <summary>Mirror image taken after the standard position image has been rotated 90 degrees counterclockwise.</summary>
		RightBottom = 7,
		/// <summary>Rotated 90 degrees clockwise from standard position.</summary>
		LeftBottom = 8,
	}

	/// <summary>Enumerates the error correction levels for QR codes.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum CIQRCodeErrorCorrectionLevel : long {
		/// <summary>Indicates l.</summary>
		L = 76,
		/// <summary>Indicates m.</summary>
		M = 77,
		/// <summary>Indicates q.</summary>
		Q = 81,
		/// <summary>Indicates h.</summary>
		H = 72,
	}

	/// <summary>Enumerates the ECC versions for the Data Matrix barcode scheme.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum CIDataMatrixCodeEccVersion : long {
		/// <summary>Indicates v000.</summary>
		V000 = 0,
		/// <summary>Indicates v050.</summary>
		V050 = 50,
		/// <summary>Indicates v080.</summary>
		V080 = 80,
		/// <summary>Indicates v100.</summary>
		V100 = 100,
		/// <summary>Indicates v140.</summary>
		V140 = 140,
		/// <summary>Indicates v200.</summary>
		V200 = 200,
	}

	[MacCatalyst (13, 1)]
	[Native]
	public enum CIRenderDestinationAlphaMode : ulong {
		/// <summary>Indicates none.</summary>
		None = 0,
		/// <summary>Indicates premultiplied.</summary>
		Premultiplied = 1,
		/// <summary>Indicates unpremultiplied.</summary>
		Unpremultiplied = 2,
	}
}
