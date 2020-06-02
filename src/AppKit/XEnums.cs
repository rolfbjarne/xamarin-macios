//
// Enums.cs: enums for AppKit
//
// Authors:
//   Aaron Bockover (abock@xamarin.com)
//
// Copyright 2012 Xamarin Inc

using System;
using ObjCRuntime;

namespace AppKit {

	[Native]
	public enum NSTextLayoutOrientation : long {
		Horizontal,
		Vertical
	}

	[Native]
	public enum NSPrintRenderingQuality : long {
		Best,
		Responsive
	}

	[Native]
	public enum NSCorrectionIndicatorType : long {
		Default = 0,
		Reversion,
		Guesses
	}

	[Native]
	public enum NSCorrectionResponse : long {
		None,
		Accepted,
		Rejected,
		Ignored,
		Edited,
		Reverted
	}

	[Native]
	public enum NSTextFinderMatchingType : long {
		Contains = 0,
		StartsWith = 1,
		FullWord = 2,
		EndsWith = 3
	}

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
		AdobeKorea1 = 5
	}

	// Untyped enum (NSAttributedString.h). Only used as a convience enum in our API.
	[Flags]
	public enum NSSpellingState :
#if XAMCORE_4_0
		nint
#else
		int
#endif
	{
		None = 0x0,
		Spelling = 0x1,
		Grammar = 0x2
	}
}

