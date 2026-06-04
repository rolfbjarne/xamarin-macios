//
// Enums.cs
//
// Authors:
//	Sebastien Pouliot  <sebastien@xamarin.com>
//
// Copyright 2013-2016, Xamarin Inc.
// Copyright 2020, Microsoft Corp.
//

namespace ImageIO {

	// untyped enum -> CGImageMetadata.h
	// note: not used in any API
	/// <summary>Enumeration of errors relating to metadata manipulation.</summary>
	[ErrorDomain ("kCFErrorDomainCGImageMetadata")]
	public enum CGImageMetadataErrors {
		/// <summary>Indicates unknown.</summary>
		Unknown = 0,
		/// <summary>Indicates unsupported format.</summary>
		UnsupportedFormat = 1,
		/// <summary>Indicates bad argument.</summary>
		BadArgument = 2,
		/// <summary>Indicates conflicting arguments.</summary>
		ConflictingArguments = 3,
		/// <summary>Indicates prefix conflict.</summary>
		PrefixConflict = 4,
	}

	// untyped enum -> CGImageMetadata.h
	/// <summary>Enumerates the type-forms of image metadata.</summary>
	public enum CGImageMetadataType {
		/// <summary>Indicates invalid.</summary>
		Invalid = -1,
		/// <summary>Indicates default.</summary>
		Default = 0,
		/// <summary>Indicates string.</summary>
		String = 1,
		/// <summary>Indicates array unordered.</summary>
		ArrayUnordered = 2,
		/// <summary>Indicates array ordered.</summary>
		ArrayOrdered = 3,
		/// <summary>Indicates alternate array.</summary>
		AlternateArray = 4,
		/// <summary>Indicates alternate text.</summary>
		AlternateText = 5,
		/// <summary>Indicates structure.</summary>
		Structure = 6,
	}

	/// <summary>Enumerates orientation values.</summary>
	public enum CGImagePropertyOrientation {
		/// <summary>Indicates up.</summary>
		Up = 1,
		/// <summary>Indicates up mirrored.</summary>
		UpMirrored,
		/// <summary>Indicates down.</summary>
		Down,
		/// <summary>Indicates down mirrored.</summary>
		DownMirrored,
		/// <summary>Indicates left mirrored.</summary>
		LeftMirrored,
		/// <summary>Indicates right.</summary>
		Right,
		/// <summary>Indicates right mirrored.</summary>
		RightMirrored,
		/// <summary>Indicates left.</summary>
		Left,
	}

	// untyped enum / #defines
	// used with kCGImagePropertyPNGCompressionFilter
	/// <summary>Enumerates the style of a PNG compression filter.</summary>
	[MacCatalyst (13, 1)]
	[Flags]
	public enum CGImagePropertyPngFilters {
		/// <summary>Indicates no.</summary>
		No = 0,
		/// <summary>Indicates none.</summary>
		None = 0x08,
		/// <summary>Indicates sub.</summary>
		Sub = 0x10,
		/// <summary>Indicates up.</summary>
		Up = 0x20,
		/// <summary>Indicates average.</summary>
		Average = 0x40,
		/// <summary>Indicates paeth.</summary>
		Paeth = 0x80,
	}

	[iOS (13, 0), TV (13, 0)]
	[MacCatalyst (13, 1)]
	public enum CGImageAnimationStatus {
		Ok = 0,
		ParameterError = -22140,
		CorruptInputImage = -22141,
		UnsupportedFormat = -22142,
		IncompleteInputImage = -22143,
		AllocationFailure = -22144,
	}

	// Yes, no [Native] here
	[iOS (14, 1), TV (14, 2)]
	[MacCatalyst (14, 1)]
	public enum CGImagePropertyTgaCompression : uint {
		None = 0,
		Rle,
	}
}
