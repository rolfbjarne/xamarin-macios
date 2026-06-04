//
// MAEnums.cs: enumarations for iOS (7+) MediaAccessibility framework
//
// Authors:
//   Aaron Bockover (abock@xamarin.com)
//
// Copyright 2013, 2015 Xamarin Inc.

using CoreFoundation;
using CoreGraphics;
using CoreText;

namespace MediaAccessibility {

	/// <summary>Enumerates values that indicate whether to use the system's or the user's caption appearance settings.</summary>
	[Native]
	[MacCatalyst (13, 1)]
	public enum MACaptionAppearanceDomain : long {
		/// <summary>Indicates default.</summary>
		Default = 0,
		/// <summary>Indicates user.</summary>
		User = 1,
	}

	/// <summary>Enumerates values that indicate whether to display captions only for translation, always, or only if an audio track language differs from the system.</summary>
	[Native]
	[MacCatalyst (13, 1)]
	public enum MACaptionAppearanceDisplayType : long {
		/// <summary>Indicates forced only.</summary>
		ForcedOnly = 0,
		/// <summary>Indicates automatic.</summary>
		Automatic = 1,
		/// <summary>Indicates always on.</summary>
		AlwaysOn = 2,
	}

	/// <summary>Enumerates values that indicate whether to override a setting with the value that is supplied by the media, if present.</summary>
	[Native]
	[MacCatalyst (13, 1)]
	public enum MACaptionAppearanceBehavior : long {
		/// <summary>Indicates use value.</summary>
		UseValue = 0,
		/// <summary>Indicates use content if available.</summary>
		UseContentIfAvailable = 1,
	}

	/// <summary>Enumerated values that control the font for the captions.</summary>
	[Native]
	[MacCatalyst (13, 1)]
	public enum MACaptionAppearanceFontStyle : long {
		/// <summary>Indicates default.</summary>
		Default = 0,
		/// <summary>Indicates monospaced with serif.</summary>
		MonospacedWithSerif = 1,
		/// <summary>Indicates proportional with serif.</summary>
		ProportionalWithSerif = 2,
		/// <summary>Indicates monospaced without serif.</summary>
		MonospacedWithoutSerif = 3,
		/// <summary>Indicates proportional without serif.</summary>
		ProportionalWithoutSerif = 4,
		/// <summary>Indicates casual.</summary>
		Casual = 5,
		/// <summary>Indicates cursive.</summary>
		Cursive = 6,
		/// <summary>Indicates small capital.</summary>
		SmallCapital = 7,
	}

	/// <summary>Enumerates values that indicate whether to raise caption text, use drop shadows on them, or etc.</summary>
	[Native]
	[MacCatalyst (13, 1)]
	public enum MACaptionAppearanceTextEdgeStyle : long {
		/// <summary>Indicates undefined.</summary>
		Undefined = 0,
		/// <summary>Indicates none.</summary>
		None = 1,
		/// <summary>Indicates raised.</summary>
		Raised = 2,
		/// <summary>Indicates depressed.</summary>
		Depressed = 3,
		/// <summary>Indicates uniform.</summary>
		Uniform = 4,
		/// <summary>Indicates drop shadow.</summary>
		DropShadow = 5,
	}
}
