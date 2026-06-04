//
// Enums.cs: enums for AppKit
//
// Authors:
//   Aaron Bockover (abock@xamarin.com)
//
// Copyright 2012 Xamarin Inc

#nullable enable

namespace AppKit {

	[NoMacCatalyst]
	[Native]
	public enum NSPrintRenderingQuality : long {
		/// <summary>Indicates best.</summary>
		Best,
		/// <summary>Indicates responsive.</summary>
		Responsive,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSCorrectionIndicatorType : long {
		/// <summary>Indicates default.</summary>
		Default = 0,
		/// <summary>Indicates reversion.</summary>
		Reversion,
		/// <summary>Indicates guesses.</summary>
		Guesses,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSCorrectionResponse : long {
		/// <summary>Indicates none.</summary>
		None,
		/// <summary>Indicates accepted.</summary>
		Accepted,
		/// <summary>Indicates rejected.</summary>
		Rejected,
		/// <summary>Indicates ignored.</summary>
		Ignored,
		/// <summary>Indicates edited.</summary>
		Edited,
		/// <summary>Indicates reverted.</summary>
		Reverted,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSTextFinderMatchingType : long {
		/// <summary>Indicates contains.</summary>
		Contains = 0,
		/// <summary>Indicates starts with.</summary>
		StartsWith = 1,
		/// <summary>Indicates full word.</summary>
		FullWord = 2,
		/// <summary>Indicates ends with.</summary>
		EndsWith = 3,
	}

	[NoMacCatalyst]
	[Native]
	public enum NSCharacterCollection : ulong {
		/// <summary>Identity mapping (CID == NSGlyph)</summary>
		IdentityMapping = 0,

		/// <summary>Adobe-CNS1</summary>
		AdobeCns1 = 1,

		/// <summary>Adobe-GB1</summary>
		AdobeGb1 = 2,

		/// <summary>Adobe-Japan1</summary>
		AdobeJapan1 = 3,

		/// <summary>Adobe-Japan2</summary>
		AdobeJapan2 = 4,

		/// <summary>Adobe-Korea1</summary>
		AdobeKorea1 = 5,
	}

	[NoMacCatalyst]
	[Flags]
	[Native]
	public enum NSSpellingState : long {
		/// <summary>Indicates none.</summary>
		None = 0x0,
		/// <summary>Indicates spelling.</summary>
		Spelling = 0x1,
		/// <summary>Indicates grammar.</summary>
		Grammar = 0x2,
	}
}
