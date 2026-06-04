//
// CGEnums.cs: Enumerations
//
// Author:
//   Vincent Dondain (vidondai@microsoft.com)
//
// Copyright 2018-2019 Microsoft Corporation
//

#nullable enable

namespace CoreGraphics {

	public enum MatrixOrder {
		/// <summary>Indicates prepend.</summary>
		Prepend = 0,
		/// <summary>Indicates append.</summary>
		Append = 1,
	}

	// untyped enum -> CGPath.h
	/// <summary>Join type for drawing operations.</summary>
	///     <remarks>Specifies how to join consecutive line or curve segments in a figure.</remarks>
	public enum CGLineJoin {
		/// <summary>Specifies a mitered join. This produces a sharp corner or a clipped corner.</summary>
		Miter,
		/// <summary>Specifies a circular join. This produces a circular arc between the lines.</summary>
		Round,
		/// <summary>Specifies a beveled join. This produces a diagonal corner.</summary>
		Bevel,
	}

	// untyped enum -> CGPath.h
	/// <summary>Style for line caps.</summary>
	public enum CGLineCap {
		/// <summary>Specifies a flat line cap.</summary>
		Butt,
		/// <summary>Specifies a round line cap.</summary>
		Round,
		/// <summary>Specifies a square line cap.</summary>
		Square,
	}

	// untyped enum -> CGContext.h
	/// <include file="../../docs/api/CoreGraphics/CGPathDrawingMode.xml" path="/Documentation/Docs[@DocId='T:CoreGraphics.CGPathDrawingMode']/*" />
	public enum CGPathDrawingMode {
		/// <summary>Fills the path using the non-zero winding rule.</summary>
		Fill,
		/// <summary>Fills the path using the even-odd rule.</summary>
		EOFill,
		/// <summary>Strokes the path.</summary>
		Stroke,
		/// <summary>Fills and strokes the path using the non-zero winding rule.</summary>
		FillStroke,
		/// <summary>Fills and strokes the path using the even-odd rule.</summary>
		EOFillStroke,
	}

	// untyped enum -> CGContext.h
	/// <summary>Text drawing mode used by Quartz.</summary>
	/// <remarks>These drawing modes are used with the <see cref="CGContext.SetTextDrawingMode" /> method and they specify how the glyphs that make up the text should be drawn.</remarks>
	public enum CGTextDrawingMode : uint {
		/// <summary>Perform a Fill operation on the text glyphs.</summary>
		Fill,
		/// <summary>Perform a Stroke operation on the text glyphs.</summary>
		Stroke,
		/// <summary>Perform a Fill operation followed by a Stroke operation on the text glyphs.</summary>
		FillStroke,
		/// <summary>Does not draw the text, merely updates the text position</summary>
		Invisible,
		/// <summary>Perform a Fill operation on the text glyphs followed by a clip operation using the current clip path.</summary>
		FillClip,
		/// <summary>Indicates stroke clip.</summary>
		StrokeClip,
		/// <summary>Perform a Stroke operation on the text glyphs followed by a clip operation using the current clip path.</summary>
		FillStrokeClip,
		/// <summary>Performs a clip operation using the current clip path without drawing the text.</summary>
		Clip,
	}

	// untyped enum -> CGContext.h
	/// <summary>Text encoding, this enumeration is deprecated, use CoreText APIs instead.</summary>
	[Deprecated (PlatformName.iOS, 7, 0)]
	[Deprecated (PlatformName.TvOS, 9, 0)]
	[Deprecated (PlatformName.MacOSX, 10, 9)]
	[Deprecated (PlatformName.MacCatalyst, 13, 1)]
	public enum CGTextEncoding {
		/// <summary>Built-in encoding of the font.</summary>
		FontSpecific,
		/// <summary>Mac encoding, an old ASCII-like encoding system used on MacOS.</summary>
		MacRoman,
	}

	// untyped enum -> CGContext.h
	/// <summary>Quality of interpolation for drawing images.</summary>
	public enum CGInterpolationQuality {
		/// <summary>Let the context pick the best interpolation mode.</summary>
		Default,
		/// <summary>Do not interpolate.</summary>
		None,
		/// <summary>Low interpolation quality, fast processing.</summary>
		Low,
		/// <summary>High quality, at the cost of speed.</summary>
		High,
		/// <summary>Indicates medium.</summary>
		Medium,            /* Yes, in this order, since Medium was added in 4 */
	}

	// untyped enum -> CGContext.h
	/// <include file="../../docs/api/CoreGraphics/CGBlendMode.xml" path="/Documentation/Docs[@DocId='T:CoreGraphics.CGBlendMode']/*" />
	public enum CGBlendMode {
		/// <summary>Indicates normal.</summary>
		Normal,
		/// <summary>Indicates multiply.</summary>
		Multiply,
		/// <summary>Indicates screen.</summary>
		Screen,
		/// <summary>Indicates overlay.</summary>
		Overlay,
		/// <summary>Indicates darken.</summary>
		Darken,
		/// <summary>Indicates lighten.</summary>
		Lighten,
		/// <summary>Indicates color dodge.</summary>
		ColorDodge,
		/// <summary>Indicates color burn.</summary>
		ColorBurn,
		/// <summary>Indicates soft light.</summary>
		SoftLight,
		/// <summary>Indicates hard light.</summary>
		HardLight,
		/// <summary>Indicates difference.</summary>
		Difference,
		/// <summary>Indicates exclusion.</summary>
		Exclusion,
		/// <summary>Indicates hue.</summary>
		Hue,
		/// <summary>Indicates saturation.</summary>
		Saturation,
		/// <summary>Indicates color.</summary>
		Color,
		/// <summary>Indicates luminosity.</summary>
		Luminosity,

		/// <summary>Clears the destination and makes it transparent (R=0).</summary>
		Clear,
		/// <summary>Copies the source color with alpha to the target (R=S)</summary>
		Copy,
		/// <summary>Indicates source in.</summary>
		SourceIn,
		/// <summary>Indicates source out.</summary>
		SourceOut,
		/// <summary>Indicates source atop.</summary>
		SourceAtop,
		/// <summary>Indicates destination over.</summary>
		DestinationOver,
		/// <summary>Indicates destination in.</summary>
		DestinationIn,
		/// <summary>Indicates destination out.</summary>
		DestinationOut,
		/// <summary>Indicates destination atop.</summary>
		DestinationAtop,
		/// <summary>Indicates XOR.</summary>
		XOR,
		/// <summary>Indicates plus darker.</summary>
		PlusDarker,
		/// <summary>Indicates plus lighter.</summary>
		PlusLighter,
	}

	[iOS (13, 0)]
	[MacCatalyst (13, 1)]
	public enum CGPdfTagType /* int32_t */ {
		Document = 100,
		Part,
		Art,
		Section,
		Div,
		BlockQuote,
		Caption,
		Toc,
		Toci,
		Index,
		NonStructure,
		Private,
		Paragraph = 200,
		Header,
		Header1,
		Header2,
		Header3,
		Header4,
		Header5,
		Header6,
		List = 300,
		ListItem,
		Label,
		ListBody,
		Table = 400,
		TableRow,
		TableHeaderCell,
		TableDataCell,
		TableHeader,
		TableBody,
		TableFooter,
		Span = 500,
		Quote,
		Note,
		Reference,
		Bibliography,
		Code,
		Link,
		Annotation,
		Ruby = 600,
		RubyBaseText,
		RubyAnnotationText,
		RubyPunctuation,
		Warichu,
		WarichuText,
		WarichuPunctiation,
		Figure = 700,
		Formula,
		Form,
		[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		Object = 800,
	}

	// untyped enum -> CGPDFObject.h
	/// <summary>Enumerates the various types of values that are found in a PDF document.</summary>
	public enum CGPDFObjectType {
		/// <summary>Indicates null.</summary>
		Null = 1,
		/// <summary>Indicates boolean.</summary>
		Boolean,
		/// <summary>Indicates integer.</summary>
		Integer,
		/// <summary>Indicates real.</summary>
		Real,
		/// <summary>Indicates name.</summary>
		Name,
		/// <summary>Indicates string.</summary>
		String,
		/// <summary>Indicates array.</summary>
		Array,
		/// <summary>Indicates dictionary.</summary>
		Dictionary,
		/// <summary>Indicates stream.</summary>
		Stream,
	};

	[MacCatalyst (13, 1)]
	public enum CGPDFAccessPermissions : uint {
		/// <summary>Indicates allows low quality printing.</summary>
		AllowsLowQualityPrinting = (1 << 0),
		/// <summary>Indicates allows high quality printing.</summary>
		AllowsHighQualityPrinting = (1 << 1),
		/// <summary>Indicates allows document changes.</summary>
		AllowsDocumentChanges = (1 << 2),
		/// <summary>Indicates allows document assembly.</summary>
		AllowsDocumentAssembly = (1 << 3),
		/// <summary>Indicates allows content copying.</summary>
		AllowsContentCopying = (1 << 4),
		/// <summary>Indicates allows content accessibility.</summary>
		AllowsContentAccessibility = (1 << 5),
		/// <summary>Indicates allows commenting.</summary>
		AllowsCommenting = (1 << 6),
		/// <summary>Indicates allows form field entry.</summary>
		AllowsFormFieldEntry = (1 << 7),
	}

	// uint32_t enum -> CGColorConversionInfo.h
	[MacCatalyst (13, 1)]
	public enum CGColorConversionInfoTransformType : uint {
		/// <summary>Indicates from space.</summary>
		FromSpace = 0,
		/// <summary>Indicates to space.</summary>
		ToSpace,
		/// <summary>Indicates apply space.</summary>
		ApplySpace,
	}
}
