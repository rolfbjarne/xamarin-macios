// 
// CTFont.cs: Implements the managed CTFont
//
// Authors: Mono Team
//          Marek Safar (marek.safar@gmail.com)
//          Rolf Bjarne Kvinge <rolf@xamarin.com>
//     
// Copyright 2010 Novell, Inc
// Copyright 2011 - 2014 Xamarin Inc
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

using System.Collections.Generic;
using System.Runtime.CompilerServices;

using CoreFoundation;
using CoreGraphics;

using CGGlyph = System.UInt16;

namespace CoreText {

	/// <summary>Options used when creating new instances of the <see cref="CoreText.CTFont" /> class.</summary>
	///     <remarks>
	///     </remarks>
	[Flags]
	[Native]
	// defined as CFOptionFlags (unsigned long [long] = nuint) - /System/Library/Frameworks/CoreText.framework/Headers/CTFont.h
	public enum CTFontOptions : ulong {
		/// <summary>Use default options.</summary>
		Default = 0,
		/// <summary>Prevents font activation.</summary>
		PreventAutoActivation = 1 << 0,
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		PreventAutoDownload = 1 << 1,
		/// <summary>Give preferences to Apple/System fonts.</summary>
		PreferSystemFont = 1 << 2,
	}

	// defined as uint32_t - /System/Library/Frameworks/CoreText.framework/Headers/CTFont.h
	/// <summary>An enumeration whose values specify the intended use of a font. Used with <see cref="CTFont.CTFont(CTFontUIFontType, nfloat, System.String)" /></summary>
	public enum CTFontUIFontType : uint {
		/// <summary>None.</summary>
		None = unchecked((uint) (-1)),
		/// <summary>User.</summary>
		User = 0,
		/// <summary>User Fixed Pitch.</summary>
		UserFixedPitch = 1,
		/// <summary>System.</summary>
		System = 2,
		/// <summary>Emphasized System.</summary>
		EmphasizedSystem = 3,
		/// <summary>Small System.</summary>
		SmallSystem = 4,
		/// <summary>Small Emphasized System.</summary>
		SmallEmphasizedSystem = 5,
		/// <summary>Mini System.</summary>
		MiniSystem = 6,
		/// <summary>Mini Emphasized System.</summary>
		MiniEmphasizedSystem = 7,
		/// <summary>Views.</summary>
		Views = 8,
		/// <summary>Application.</summary>
		Application = 9,
		/// <summary>Label.</summary>
		Label = 10,
		/// <summary>Menu Title.</summary>
		MenuTitle = 11,
		/// <summary>Menu Item.</summary>
		MenuItem = 12,
		/// <summary>Menu Item Mark.</summary>
		MenuItemMark = 13,
		/// <summary>Menu Item Cmd Key.</summary>
		MenuItemCmdKey = 14,
		/// <summary>Window Title.</summary>
		WindowTitle = 15,
		/// <summary>Push Button.</summary>
		PushButton = 16,
		/// <summary>Utility Window Title.</summary>
		UtilityWindowTitle = 17,
		/// <summary>Alert Header.</summary>
		AlertHeader = 18,
		/// <summary>System Detail.</summary>
		SystemDetail = 19,
		/// <summary>Emphasized System Detail.</summary>
		EmphasizedSystemDetail = 20,
		/// <summary>Toolbar.</summary>
		Toolbar = 21,
		/// <summary>Small Toolbar.</summary>
		SmallToolbar = 22,
		/// <summary>Message.</summary>
		Message = 23,
		/// <summary>Palette.</summary>
		Palette = 24,
		/// <summary>Tool Tip.</summary>
		ToolTip = 25,
		/// <summary>Control Content.</summary>
		ControlContent = 26,
	}

	// defined as uint32_t - /System/Library/Frameworks/CoreText.framework/Headers/CTFont.h
	/// <summary>An enumeration whose values represent tags for accessing font-table data.</summary>
	public enum CTFontTable : uint {
		/// <summary>Baseline B A S E.</summary>
		BaselineBASE = 0x42415345,  // 'BASE'
		/// <summary>Color Bitmap Data.</summary>
		ColorBitmapData = 0x43424454,  // 'CBDT'
		/// <summary>Color Bitmap Location Data.</summary>
		ColorBitmapLocationData = 0x43424c43,  // 'CBLC'
		/// <summary>Postscript Font Program.</summary>
		PostscriptFontProgram = 0x43464620,  // 'CFF '
		/// <summary>Compact Font Format2.</summary>
		CompactFontFormat2 = 0x43464632,  // 'CFF2'
		/// <summary>Color Table.</summary>
		ColorTable = 0x434f4c52,  // 'COLR'
		/// <summary>Color Palette Table.</summary>
		ColorPaletteTable = 0x4350414c,  // 'CPAL'
		/// <summary>Digital Signature.</summary>
		DigitalSignature = 0x44534947,  // 'DSIG'
		/// <summary>Embedded Bitmap.</summary>
		EmbeddedBitmap = 0x45424454,  // 'EBDT'
		/// <summary>Embedded Bitmap Location.</summary>
		EmbeddedBitmapLocation = 0x45424c43,  // 'EBLC'
		/// <summary>Embedded Bitmap Scaling.</summary>
		EmbeddedBitmapScaling = 0x45425343,  // 'EBSC'
		/// <summary>Glyph Definition.</summary>
		GlyphDefinition = 0x47444546,  // 'GDEF'
		/// <summary>Glyph Positioning.</summary>
		GlyphPositioning = 0x47504f53,  // 'GPOS'
		/// <summary>Glyph Substitution.</summary>
		GlyphSubstitution = 0x47535542,  // 'GSUB'
		/// <summary>Horizontal Metrics Variations.</summary>
		HorizontalMetricsVariations = 0x48564152,  // 'HVAR'
		/// <summary>Justification J S T F.</summary>
		JustificationJSTF = 0x4a535446,  // 'JSTF'
		/// <summary>Linear Threshold.</summary>
		LinearThreshold = 0x4c545348,  // 'LTSH'
		/// <summary>Math Layout Data.</summary>
		MathLayoutData = 0x4d415448,  // 'MATH'
		/// <summary>Merge.</summary>
		Merge = 0x4d455247,  // 'MERG'
		/// <summary>Metrics Variations.</summary>
		MetricsVariations = 0x4d564152,  // 'MVAR'
		/// <summary>Windows Specific Metrics.</summary>
		WindowsSpecificMetrics = 0x4f532f32,  // 'OS2 '
		/// <summary>Pcl5 Data.</summary>
		Pcl5Data = 0x50434c54,  // 'PCLT'
		/// <summary>Vertical Device Metrics.</summary>
		VerticalDeviceMetrics = 0x56444d58,  // 'VDMX'
		/// <summary>Style Attributes.</summary>
		StyleAttributes = 0x53544154,  // 'STAT'
		/// <summary>Scalable Vector Graphics.</summary>
		ScalableVectorGraphics = 0x53564720,  // 'SVG '
		/// <summary>Vertical Origin.</summary>
		VerticalOrigin = 0x564f5247,  // 'VORG'
		/// <summary>Vertical Metrics Variations.</summary>
		VerticalMetricsVariations = 0x56564152,  // 'VVAR'
		/// <summary>Glyph Reference.</summary>
		GlyphReference = 0x5a617066,  // 'Zapf'
		/// <summary>Accent Attachment.</summary>
		AccentAttachment = 0x61636e74,  // 'Acnt'
		/// <summary>Anchor Points.</summary>
		AnchorPoints = 0x616e6b72,  // 'ankr'
		/// <summary>Axis Variation.</summary>
		AxisVariation = 0x61766172,  // 'Avar'
		/// <summary>Bitmap Data.</summary>
		BitmapData = 0x62646174,  // 'Bdat'
		/// <summary>Bitmap Font Header.</summary>
		BitmapFontHeader = 0x62686564,  // 'Bhed'
		/// <summary>Bitmap Location.</summary>
		BitmapLocation = 0x626c6f63,  // 'Bloc'
		/// <summary>Baseline Bsln.</summary>
		BaselineBsln = 0x62736c6e,  // 'Bsln'
		/// <summary>Character To Glyph Mapping.</summary>
		CharacterToGlyphMapping = 0x636d6170,  // 'Cmap'
		/// <summary>Control Value Table Variation.</summary>
		ControlValueTableVariation = 0x63766172,  // 'Cvar'
		/// <summary>Control Value Table.</summary>
		ControlValueTable = 0x63767420,  // 'Cvt '
		/// <summary>Font Descriptor.</summary>
		FontDescriptor = 0x66647363,  // 'Fdsc'
		/// <summary>Layout Feature.</summary>
		LayoutFeature = 0x66656174,  // 'Feat'
		/// <summary>Font Metrics.</summary>
		FontMetrics = 0x666d7478,  // 'Fmtx'
		/// <summary>Fond And Nfnt Data.</summary>
		FondAndNfntData = 0x666f6e64,  // 'fond'
		/// <summary>Font Program.</summary>
		FontProgram = 0x6670676d,  // 'Fpgm'
		/// <summary>Font Variation.</summary>
		FontVariation = 0x66766172,  // 'Fvar'
		/// <summary>Grid Fitting.</summary>
		GridFitting = 0x67617370,  // 'Gasp'
		/// <summary>Glyph Data.</summary>
		GlyphData = 0x676c7966,  // 'Glyf'
		/// <summary>Glyph Variation.</summary>
		GlyphVariation = 0x67766172,  // 'Gvar'
		/// <summary>Horizontal Device Metrics.</summary>
		HorizontalDeviceMetrics = 0x68646d78,  // 'Hdmx'
		/// <summary>Font Header.</summary>
		FontHeader = 0x68656164,  // 'Head'
		/// <summary>Horizontal Header.</summary>
		HorizontalHeader = 0x68686561,  // 'Hhea'
		/// <summary>Horizontal Metrics.</summary>
		HorizontalMetrics = 0x686d7478,  // 'Hmtx'
		/// <summary>Horizontal Style.</summary>
		HorizontalStyle = 0x68737479,  // 'Hsty'
		/// <summary>Justification Just.</summary>
		JustificationJust = 0x6a757374,  // 'Just'
		/// <summary>Kerning.</summary>
		Kerning = 0x6b65726e,  // 'Kern'
		/// <summary>Extended Kerning.</summary>
		ExtendedKerning = 0x6b657278,  // 'Kerx'
		/// <summary>Ligature Caret.</summary>
		LigatureCaret = 0x6c636172,  // 'Lcar'
		/// <summary>Index To Location.</summary>
		IndexToLocation = 0x6c6f6361,  // 'Loca'
		/// <summary>Language Tags.</summary>
		LanguageTags = 0x6c746167,  // 'ltag'
		/// <summary>Maximum Profile.</summary>
		MaximumProfile = 0x6d617870,  // 'Maxp'
		/// <summary>Metadata.</summary>
		Metadata = 0x6d657461,  // 'meta'
		/// <summary>Morph.</summary>
		Morph = 0x6d6f7274,  // 'Mort'
		/// <summary>Extended Morph.</summary>
		ExtendedMorph = 0x6d6f7278,  // 'Morx'
		/// <summary>Name.</summary>
		Name = 0x6e616d65,  // 'Name'
		/// <summary>Optical Bounds.</summary>
		OpticalBounds = 0x6f706264,  // 'Opbd'
		/// <summary>Post Script Information.</summary>
		PostScriptInformation = 0x706f7374,  // 'Post'
		/// <summary>Control Value Table Program.</summary>
		ControlValueTableProgram = 0x70726570,  // 'Prep'
		/// <summary>Properties.</summary>
		Properties = 0x70726f70,  // 'Prop'
		/// <summary>S Bitmap Data.</summary>
		SBitmapData = 0x73626974,  // 'sbit'
		/// <summary>S Extended Bitmap Data.</summary>
		SExtendedBitmapData = 0x73626978,  // 'sbix'
		/// <summary>Tracking.</summary>
		Tracking = 0x7472616b,  // 'Trak'
		/// <summary>Vertical Header.</summary>
		VerticalHeader = 0x76686561,  // 'Vhea'
		/// <summary>Vertical Metrics.</summary>
		VerticalMetrics = 0x766d7478,  // 'Vmtx'
		/// <summary>Cross Reference.</summary>
		CrossReference = 0x78726566,  // 'xref'
	}

	/// <summary>An enumeration whose values can be used as flags for options relating to font tables.</summary>
	[Flags]
	// defined as uint32_t - /System/Library/Frameworks/CoreText.framework/Headers/CTFont.h
	public enum CTFontTableOptions : uint {
		/// <summary>None.</summary>
		None = 0,
		/// <summary>Exclude Synthetic.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios6.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[ObsoletedOSPlatform ("macos10.8")]
		[UnsupportedOSPlatform ("tvos")]
		ExcludeSynthetic = (1 << 0),
	}

	// anonymous and typeless native enum - /System/Library/Frameworks/CoreText.framework/Headers/SFNTLayoutTypes.h
	/// <summary>An enumeration whose values specify various types of font features.</summary>
	///     <altmember cref="CoreText.CTFontFeatures.FeatureGroup" />
	///     <altmember cref="CoreText.CTFontFeatureSettings.FeatureGroup" />
	public enum FontFeatureGroup {
		/// <summary>All Typographic Features.</summary>
		AllTypographicFeatures = 0,
		/// <summary>Ligatures.</summary>
		Ligatures = 1,
		/// <summary>Cursive Connection.</summary>
		CursiveConnection = 2,
		/// <summary>Developers should not use this deprecated field. </summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("macos10.7")]
		[ObsoletedOSPlatform ("ios6.0")]
		[ObsoletedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("maccatalyst")]
		LetterCase = 3,
		/// <summary>Vertical Substitution.</summary>
		VerticalSubstitution = 4,
		/// <summary>Linguistic Rearrangement.</summary>
		LinguisticRearrangement = 5,
		/// <summary>Number Spacing.</summary>
		NumberSpacing = 6,
		/// <summary>Smart Swash.</summary>
		SmartSwash = 8,
		/// <summary>Diacritics.</summary>
		Diacritics = 9,
		/// <summary>Vertical Position.</summary>
		VerticalPosition = 10,
		/// <summary>Fractions.</summary>
		Fractions = 11,
		/// <summary>Overlapping Characters.</summary>
		OverlappingCharacters = 13,
		/// <summary>Typographic Extras.</summary>
		TypographicExtras = 14,
		/// <summary>Mathematical Extras.</summary>
		MathematicalExtras = 15,
		/// <summary>Ornament Sets.</summary>
		OrnamentSets = 16,
		/// <summary>Character Alternatives.</summary>
		CharacterAlternatives = 17,
		/// <summary>Design Complexity.</summary>
		DesignComplexity = 18,
		/// <summary>Style Options.</summary>
		StyleOptions = 19,
		/// <summary>Character Shape.</summary>
		CharacterShape = 20,
		/// <summary>Number Case.</summary>
		NumberCase = 21,
		/// <summary>Text Spacing.</summary>
		TextSpacing = 22,
		/// <summary>Transliteration.</summary>
		Transliteration = 23,
		/// <summary>Annotation.</summary>
		Annotation = 24,
		/// <summary>Kana Spacing.</summary>
		KanaSpacing = 25,
		/// <summary>Ideographic Spacing.</summary>
		IdeographicSpacing = 26,
		/// <summary>Unicode Decomposition.</summary>
		UnicodeDecomposition = 27,
		/// <summary>Ruby Kana.</summary>
		RubyKana = 28,
		/// <summary>C J K Symbol Alternatives.</summary>
		CJKSymbolAlternatives = 29,
		/// <summary>Ideographic Alternatives.</summary>
		IdeographicAlternatives = 30,
		/// <summary>C J K Vertical Roman Placement.</summary>
		CJKVerticalRomanPlacement = 31,
		/// <summary>Italic C J K Roman.</summary>
		ItalicCJKRoman = 32,
		/// <summary>Case Sensitive Layout.</summary>
		CaseSensitiveLayout = 33,
		/// <summary>Alternate Kana.</summary>
		AlternateKana = 34,
		/// <summary>Stylistic Alternatives.</summary>
		StylisticAlternatives = 35,
		/// <summary>Contextual Alternates.</summary>
		ContextualAlternates = 36,
		/// <summary>Lower Case.</summary>
		LowerCase = 37,
		/// <summary>Upper Case.</summary>
		UpperCase = 38,
		/// <summary>C J K Roman Spacing.</summary>
		CJKRomanSpacing = 103,
	}

	/// <summary>Encapsulates the features of a <see cref="CoreText.CTFont" />.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatures {

		/// <summary>C T Font Features.</summary>
		public CTFontFeatures ()
			: this (new NSMutableDictionary ())
		{
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Features.</summary>
		public CTFontFeatures (NSDictionary dictionary)
		{
			if (dictionary is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dictionary));
			Dictionary = dictionary;
		}

		/// <summary>The NSDictionary that reflects the current values in the strongly typed CTFontFeatures.</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		public NSDictionary Dictionary { get; private set; }

		/// <summary>Gets the name.</summary>
		public string? Name {
			get { return Adapter.GetStringValue (Dictionary, CTFontFeatureKey.Name); }
			set { Adapter.SetValue (Dictionary, CTFontFeatureKey.Name, value); }
		}

		/// <summary>Gets the feature group.</summary>
		public FontFeatureGroup FeatureGroup {
			get {
				var number = (NSNumber?) Dictionary [CTFontFeatureKey.Identifier];
				if (number is null)
					return default;
				return (FontFeatureGroup) (int) number;
			}
		}

		/// <summary>Gets the exclusive.</summary>
		public bool Exclusive {
			get {
				return CFDictionary.GetBooleanValue (Dictionary.Handle,
						CTFontFeatureKey.Exclusive.Handle);
			}
			set {
				CFMutableDictionary.SetValue (Dictionary.Handle,
						CTFontFeatureKey.Exclusive.Handle,
						value);
			}
		}

		/// <summary>Gets the selectors.</summary>
		public IEnumerable<CTFontFeatureSelectors>? Selectors {
			get {
				return Adapter.GetNativeArray (Dictionary, CTFontFeatureKey.Selectors,
						d => CTFontFeatureSelectors.Create (FeatureGroup, Runtime.GetNSObject<NSDictionary> (d)!));
			}
			set {
				List<CTFontFeatureSelectors> v;
				if (value is null || (v = new List<CTFontFeatureSelectors> (value)).Count == 0) {
					Adapter.SetValue (Dictionary, CTFontFeatureKey.Selectors, (NSObject?) null);
					return;
				}
				Adapter.SetValue (Dictionary, CTFontFeatureKey.Selectors,
						NSArray.FromNSObjects ((IList<NSObject>) v.ConvertAll (e => (NSObject) e.Dictionary)));
			}
		}
	}

	/// <summary>Encapsulates a font feature-dictionary. </summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureSelectors {

		/// <summary>C T Font Feature Selectors.</summary>
		public CTFontFeatureSelectors ()
			: this (new NSMutableDictionary ())
		{
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Selectors.</summary>
		public CTFontFeatureSelectors (NSDictionary dictionary)
		{
			if (dictionary is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dictionary));
			Dictionary = dictionary;
		}

		internal static CTFontFeatureSelectors Create (FontFeatureGroup featureGroup, NSDictionary dictionary)
		{
			switch (featureGroup) {
			case FontFeatureGroup.AllTypographicFeatures:
				return new CTFontFeatureAllTypographicFeatures (dictionary);
			case FontFeatureGroup.Ligatures:
				return new CTFontFeatureLigatures (dictionary);
			case FontFeatureGroup.CursiveConnection:
				return new CTFontFeatureCursiveConnection (dictionary);
#pragma warning disable 618
#pragma warning disable CA1422 // This call site is reachable on: 'ios' 12.2 and later, 'maccatalyst' 12.2 and later, 'macOS/OSX' 12.0 and later, 'tvos' 12.2 and later. 'CTFontFeatureLetterCase' is obsoleted on: 'ios' 6.0 and later, 'maccatalyst' 6.0 and later, 'macOS/OSX' 10.7 and later.
			case FontFeatureGroup.LetterCase:
				return new CTFontFeatureLetterCase (dictionary);
#pragma warning restore CA1422
#pragma warning restore 618
			case FontFeatureGroup.VerticalSubstitution:
				return new CTFontFeatureVerticalSubstitutionConnection (dictionary);
			case FontFeatureGroup.LinguisticRearrangement:
				return new CTFontFeatureLinguisticRearrangementConnection (dictionary);
			case FontFeatureGroup.NumberSpacing:
				return new CTFontFeatureNumberSpacing (dictionary);
			case FontFeatureGroup.SmartSwash:
				return new CTFontFeatureSmartSwash (dictionary);
			case FontFeatureGroup.Diacritics:
				return new CTFontFeatureDiacritics (dictionary);
			case FontFeatureGroup.VerticalPosition:
				return new CTFontFeatureVerticalPosition (dictionary);
			case FontFeatureGroup.Fractions:
				return new CTFontFeatureFractions (dictionary);
			case FontFeatureGroup.OverlappingCharacters:
				return new CTFontFeatureOverlappingCharacters (dictionary);
			case FontFeatureGroup.TypographicExtras:
				return new CTFontFeatureTypographicExtras (dictionary);
			case FontFeatureGroup.MathematicalExtras:
				return new CTFontFeatureMathematicalExtras (dictionary);
			case FontFeatureGroup.OrnamentSets:
				return new CTFontFeatureOrnamentSets (dictionary);
			case FontFeatureGroup.CharacterAlternatives:
				return new CTFontFeatureCharacterAlternatives (dictionary);
			case FontFeatureGroup.DesignComplexity:
				return new CTFontFeatureDesignComplexity (dictionary);
			case FontFeatureGroup.StyleOptions:
				return new CTFontFeatureStyleOptions (dictionary);
			case FontFeatureGroup.CharacterShape:
				return new CTFontFeatureCharacterShape (dictionary);
			case FontFeatureGroup.NumberCase:
				return new CTFontFeatureNumberCase (dictionary);
			case FontFeatureGroup.TextSpacing:
				return new CTFontFeatureTextSpacing (dictionary);
			case FontFeatureGroup.Transliteration:
				return new CTFontFeatureTransliteration (dictionary);
			case FontFeatureGroup.Annotation:
				return new CTFontFeatureAnnotation (dictionary);
			case FontFeatureGroup.KanaSpacing:
				return new CTFontFeatureKanaSpacing (dictionary);
			case FontFeatureGroup.IdeographicSpacing:
				return new CTFontFeatureIdeographicSpacing (dictionary);
			case FontFeatureGroup.UnicodeDecomposition:
				return new CTFontFeatureUnicodeDecomposition (dictionary);
			case FontFeatureGroup.RubyKana:
				return new CTFontFeatureRubyKana (dictionary);
			case FontFeatureGroup.CJKSymbolAlternatives:
				return new CTFontFeatureCJKSymbolAlternatives (dictionary);
			case FontFeatureGroup.IdeographicAlternatives:
				return new CTFontFeatureIdeographicAlternatives (dictionary);
			case FontFeatureGroup.CJKVerticalRomanPlacement:
				return new CTFontFeatureCJKVerticalRomanPlacement (dictionary);
			case FontFeatureGroup.ItalicCJKRoman:
				return new CTFontFeatureItalicCJKRoman (dictionary);
			case FontFeatureGroup.CaseSensitiveLayout:
				return new CTFontFeatureCaseSensitiveLayout (dictionary);
			case FontFeatureGroup.AlternateKana:
				return new CTFontFeatureAlternateKana (dictionary);
			case FontFeatureGroup.StylisticAlternatives:
				return new CTFontFeatureStylisticAlternatives (dictionary);
			case FontFeatureGroup.ContextualAlternates:
				return new CTFontFeatureContextualAlternates (dictionary);
			case FontFeatureGroup.LowerCase:
				return new CTFontFeatureLowerCase (dictionary);
			case FontFeatureGroup.UpperCase:
				return new CTFontFeatureUpperCase (dictionary);
			case FontFeatureGroup.CJKRomanSpacing:
				return new CTFontFeatureCJKRomanSpacing (dictionary);
			default:
				return new CTFontFeatureSelectors (dictionary);
			}
		}

		/// <summary>Gets the dictionary.</summary>
		public NSDictionary Dictionary { get; private set; }

		/// <summary>protected int  Feature Weak {.</summary>
		protected int FeatureWeak {
			get {
				var number = (NSNumber?) Dictionary [CTFontFeatureSelectorKey.Identifier];
				if (number is null)
					return default;
				return (int) number;
			}
		}

		/// <summary>Gets the name.</summary>
		public string? Name {
			get { return Adapter.GetStringValue (Dictionary, CTFontFeatureSelectorKey.Name); }
			set { Adapter.SetValue (Dictionary, CTFontFeatureSelectorKey.Name, value); }
		}

		/// <summary>Gets the default.</summary>
		public bool Default {
			get {
				return CFDictionary.GetBooleanValue (Dictionary.Handle,
						CTFontFeatureSelectorKey.Default.Handle);
			}
			set {
				CFMutableDictionary.SetValue (Dictionary.Handle,
						CTFontFeatureSelectorKey.Default.Handle,
						value);
			}
		}

		/// <summary>Gets the setting.</summary>
		public bool Setting {
			get {
				return CFDictionary.GetBooleanValue (Dictionary.Handle,
						CTFontFeatureSelectorKey.Setting.Handle);
			}
			set {
				CFMutableDictionary.SetValue (Dictionary.Handle,
						CTFontFeatureSelectorKey.Setting.Handle,
						value);
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that represents all type features.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureAllTypographicFeatures : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values can be used as arguments for <see cref="CoreText.CTFontDescriptor.WithFeature(CoreText.CTFontFeatureVerticalSubstitutionConnection.Selector)" />.</summary>
		public enum Selector {
			/// <summary>All Type Features On.</summary>
			AllTypeFeaturesOn = 0,
			/// <summary>All Type Features Off.</summary>
			AllTypeFeaturesOff = 1,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature All Typographic Features.</summary>
		public CTFontFeatureAllTypographicFeatures (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe whether ligature features are on or off.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureLigatures : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureLigatures.Feature" />.</summary>
		public enum Selector {
			/// <summary>Required Ligatures On.</summary>
			RequiredLigaturesOn = 0,
			/// <summary>Required Ligatures Off.</summary>
			RequiredLigaturesOff = 1,
			/// <summary>Common Ligatures On.</summary>
			CommonLigaturesOn = 2,
			/// <summary>Common Ligatures Off.</summary>
			CommonLigaturesOff = 3,
			/// <summary>Rare Ligatures On.</summary>
			RareLigaturesOn = 4,
			/// <summary>Rare Ligatures Off.</summary>
			RareLigaturesOff = 5,
			/// <summary>Logos On.</summary>
			LogosOn = 6,
			/// <summary>Logos Off.</summary>
			LogosOff = 7,
			/// <summary>Rebus Pictures On.</summary>
			RebusPicturesOn = 8,
			/// <summary>Rebus Pictures Off.</summary>
			RebusPicturesOff = 9,
			/// <summary>Diphthong Ligatures On.</summary>
			DiphthongLigaturesOn = 10,
			/// <summary>Diphthong Ligatures Off.</summary>
			DiphthongLigaturesOff = 11,
			/// <summary>Squared Ligatures On.</summary>
			SquaredLigaturesOn = 12,
			/// <summary>Squared Ligatures Off.</summary>
			SquaredLigaturesOff = 13,
			/// <summary>Abbrev Squared Ligatures On.</summary>
			AbbrevSquaredLigaturesOn = 14,
			/// <summary>Abbrev Squared Ligatures Off.</summary>
			AbbrevSquaredLigaturesOff = 15,
			/// <summary>Symbol Ligatures On.</summary>
			SymbolLigaturesOn = 16,
			/// <summary>Symbol Ligatures Off.</summary>
			SymbolLigaturesOff = 17,
			/// <summary>Contextual Ligatures On.</summary>
			ContextualLigaturesOn = 18,
			/// <summary>Contextual Ligatures Off.</summary>
			ContextualLigaturesOff = 19,
			/// <summary>Historical Ligatures On.</summary>
			HistoricalLigaturesOn = 20,
			/// <summary>Historical Ligatures Off.</summary>
			HistoricalLigaturesOff = 21,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Ligatures.</summary>
		public CTFontFeatureLigatures (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe features related to capitalization options such as initial capitalization.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[ObsoletedOSPlatform ("macos10.7")]
	[ObsoletedOSPlatform ("ios6.0")]
	[ObsoletedOSPlatform ("tvos")]
	[ObsoletedOSPlatform ("maccatalyst")]
	public class CTFontFeatureLetterCase : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureLetterCase.Feature" />.</summary>
		public enum Selector {
			/// <summary>Upper And Lower Case.</summary>
			UpperAndLowerCase = 0,
			/// <summary>All Caps.</summary>
			AllCaps = 1,
			/// <summary>All Lower Case.</summary>
			AllLowerCase = 2,
			/// <summary>Small Caps.</summary>
			SmallCaps = 3,
			/// <summary>Initial Caps.</summary>
			InitialCaps = 4,
			/// <summary>Initial Caps And Small Caps.</summary>
			InitialCapsAndSmallCaps = 5,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Letter Case.</summary>
		public CTFontFeatureLetterCase (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe features related to the connection of cursive letters.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureCursiveConnection : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureCursiveConnection.Feature" />.</summary>
		public enum Selector {
			/// <summary>Unconnected.</summary>
			Unconnected = 0,
			/// <summary>Partially Connected.</summary>
			PartiallyConnected = 1,
			/// <summary>Cursive.</summary>
			Cursive = 2,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Cursive Connection.</summary>
		public CTFontFeatureCursiveConnection (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe features related to vertical substitution.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureVerticalSubstitutionConnection : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureVerticalSubstitutionConnection.Feature" />.</summary>
		public enum Selector {
			/// <summary>Substitute Vertical Forms On.</summary>
			SubstituteVerticalFormsOn = 0,
			/// <summary>Substitute Vertical Forms Off.</summary>
			SubstituteVerticalFormsOff = 1,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Vertical Substitution Connection.</summary>
		public CTFontFeatureVerticalSubstitutionConnection (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe whether linguistic rearrangement is on or off.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureLinguisticRearrangementConnection : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureLinguisticRearrangementConnection.Feature" />.</summary>
		public enum Selector {
			/// <summary>Linguistic Rearrangement On.</summary>
			LinguisticRearrangementOn = 0,
			/// <summary>Linguistic Rearrangement Off.</summary>
			LinguisticRearrangementOff = 1,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Linguistic Rearrangement Connection.</summary>
		public CTFontFeatureLinguisticRearrangementConnection (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe features related to spacing of numbers.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureNumberSpacing : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureNumberSpacing.Feature" />.</summary>
		public enum Selector {
			/// <summary>Monospaced Numbers.</summary>
			MonospacedNumbers = 0,
			/// <summary>Proportional Numbers.</summary>
			ProportionalNumbers = 1,
			/// <summary>Third Width Numbers.</summary>
			ThirdWidthNumbers = 2,
			/// <summary>Quarter Width Numbers.</summary>
			QuarterWidthNumbers = 3,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Number Spacing.</summary>
		public CTFontFeatureNumberSpacing (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe features related to smart swashes.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureSmartSwash : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureSmartSwash.Feature" />.</summary>
		public enum Selector {
			/// <summary>Word Initial Swashes On.</summary>
			WordInitialSwashesOn = 0,
			/// <summary>Word Initial Swashes Off.</summary>
			WordInitialSwashesOff = 1,
			/// <summary>Word Final Swashes On.</summary>
			WordFinalSwashesOn = 2,
			/// <summary>Word Final Swashes Off.</summary>
			WordFinalSwashesOff = 3,
			/// <summary>Line Initial Swashes On.</summary>
			LineInitialSwashesOn = 4,
			/// <summary>Line Initial Swashes Off.</summary>
			LineInitialSwashesOff = 5,
			/// <summary>Line Final Swashes On.</summary>
			LineFinalSwashesOn = 6,
			/// <summary>Line Final Swashes Off.</summary>
			LineFinalSwashesOff = 7,
			/// <summary>Non Final Swashes On.</summary>
			NonFinalSwashesOn = 8,
			/// <summary>Non Final Swashes Off.</summary>
			NonFinalSwashesOff = 9,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Smart Swash.</summary>
		public CTFontFeatureSmartSwash (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe features related to the visibility and composition of diacritical marks.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureDiacritics : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureDiacritics.Feature" />.</summary>
		public enum Selector {
			/// <summary>Show Diacritics.</summary>
			ShowDiacritics = 0,
			/// <summary>Hide Diacritics.</summary>
			HideDiacritics = 1,
			/// <summary>Decompose Diacritics.</summary>
			DecomposeDiacritics = 2,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Diacritics.</summary>
		public CTFontFeatureDiacritics (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe features related to vertical positioning.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureVerticalPosition : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureVerticalPosition.Feature" />.</summary>
		public enum Selector {
			/// <summary>Normal Position.</summary>
			NormalPosition = 0,
			/// <summary>Superiors.</summary>
			Superiors = 1,
			/// <summary>Inferiors.</summary>
			Inferiors = 2,
			/// <summary>Ordinals.</summary>
			Ordinals = 3,
			/// <summary>Scientific Inferiors.</summary>
			ScientificInferiors = 4,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Vertical Position.</summary>
		public CTFontFeatureVerticalPosition (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe features related to how fractions should be displayed.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureFractions : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureFractions.Feature" />.</summary>
		public enum Selector {
			/// <summary>No Fractions.</summary>
			NoFractions = 0,
			/// <summary>Vertical Fractions.</summary>
			VerticalFractions = 1,
			/// <summary>Diagonal Fractions.</summary>
			DiagonalFractions = 2,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Fractions.</summary>
		public CTFontFeatureFractions (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that allow or disallow characters to overlap.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureOverlappingCharacters : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureOverlappingCharacters.Feature" />.</summary>
		public enum Selector {
			/// <summary>Prevent Overlap On.</summary>
			PreventOverlapOn = 0,
			/// <summary>Prevent Overlap Off.</summary>
			PreventOverlapOff = 1,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Overlapping Characters.</summary>
		public CTFontFeatureOverlappingCharacters (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe features related to typographic extras such as interrobangs, conversion of dashes to em- or en-dashes, etc..</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureTypographicExtras : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureTypographicExtras.Feature" />.</summary>
		public enum Selector {
			/// <summary>Hyphens To Em Dash On.</summary>
			HyphensToEmDashOn = 0,
			/// <summary>Hyphens To Em Dash Off.</summary>
			HyphensToEmDashOff = 1,
			/// <summary>Hyphen To En Dash On.</summary>
			HyphenToEnDashOn = 2,
			/// <summary>Hyphen To En Dash Off.</summary>
			HyphenToEnDashOff = 3,
			/// <summary>Slashed Zero On.</summary>
			SlashedZeroOn = 4,
			/// <summary>Slashed Zero Off.</summary>
			SlashedZeroOff = 5,
			/// <summary>Form Interrobang On.</summary>
			FormInterrobangOn = 6,
			/// <summary>Form Interrobang Off.</summary>
			FormInterrobangOff = 7,
			/// <summary>Smart Quotes On.</summary>
			SmartQuotesOn = 8,
			/// <summary>Smart Quotes Off.</summary>
			SmartQuotesOff = 9,
			/// <summary>Periods To Ellipsis On.</summary>
			PeriodsToEllipsisOn = 10,
			/// <summary>Periods To Ellipsis Off.</summary>
			PeriodsToEllipsisOff = 11,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Typographic Extras.</summary>
		public CTFontFeatureTypographicExtras (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe features related to mathematical formulae.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureMathematicalExtras : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureMathematicalExtras.Feature" />.</summary>
		public enum Selector {
			/// <summary>Hyphen To Minus On.</summary>
			HyphenToMinusOn = 0,
			/// <summary>Hyphen To Minus Off.</summary>
			HyphenToMinusOff = 1,
			/// <summary>Asterisk To Multiply On.</summary>
			AsteriskToMultiplyOn = 2,
			/// <summary>Asterisk To Multiply Off.</summary>
			AsteriskToMultiplyOff = 3,
			/// <summary>Slash To Divide On.</summary>
			SlashToDivideOn = 4,
			/// <summary>Slash To Divide Off.</summary>
			SlashToDivideOff = 5,
			/// <summary>Inequality Ligatures On.</summary>
			InequalityLigaturesOn = 6,
			/// <summary>Inequality Ligatures Off.</summary>
			InequalityLigaturesOff = 7,
			/// <summary>Exponents On.</summary>
			ExponentsOn = 8,
			/// <summary>Exponents Off.</summary>
			ExponentsOff = 9,
			/// <summary>Mathematical Greek On.</summary>
			MathematicalGreekOn = 10,
			/// <summary>Mathematical Greek Off.</summary>
			MathematicalGreekOff = 11,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Mathematical Extras.</summary>
		public CTFontFeatureMathematicalExtras (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe features related to case-sensitive spacing or layout.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureOrnamentSets : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureOrnamentSets.Feature" />.</summary>
		public enum Selector {
			/// <summary>No Ornaments.</summary>
			NoOrnaments = 0,
			/// <summary>Dingbats.</summary>
			Dingbats = 1,
			/// <summary>Pi Characters.</summary>
			PiCharacters = 2,
			/// <summary>Fleurons.</summary>
			Fleurons = 3,
			/// <summary>Decorative Borders.</summary>
			DecorativeBorders = 4,
			/// <summary>International Symbols.</summary>
			InternationalSymbols = 5,
			/// <summary>Math Symbols.</summary>
			MathSymbols = 6,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Ornament Sets.</summary>
		public CTFontFeatureOrnamentSets (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe a feature allowing character alternatives.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureCharacterAlternatives : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureCharacterAlternatives.Feature" />.</summary>
		public enum Selector {
			/// <summary>No Alternates.</summary>
			NoAlternates = 0,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Character Alternatives.</summary>
		public CTFontFeatureCharacterAlternatives (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe features related to design-level complexity.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureDesignComplexity : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureDesignComplexity.Feature" />.</summary>
		public enum Selector {
			/// <summary>Design Level1.</summary>
			DesignLevel1 = 0,
			/// <summary>Design Level2.</summary>
			DesignLevel2 = 1,
			/// <summary>Design Level3.</summary>
			DesignLevel3 = 2,
			/// <summary>Design Level4.</summary>
			DesignLevel4 = 3,
			/// <summary>Design Level5.</summary>
			DesignLevel5 = 4,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Design Complexity.</summary>
		public CTFontFeatureDesignComplexity (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe features related to font features such as illuminated capitals and engraved text.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureStyleOptions : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureStyleOptions.Feature" />.</summary>
		public enum Selector {
			/// <summary>No Style Options.</summary>
			NoStyleOptions = 0,
			/// <summary>Display Text.</summary>
			DisplayText = 1,
			/// <summary>Engraved Text.</summary>
			EngravedText = 2,
			/// <summary>Illuminated Caps.</summary>
			IlluminatedCaps = 3,
			/// <summary>Titling Caps.</summary>
			TitlingCaps = 4,
			/// <summary>Tall Caps.</summary>
			TallCaps = 5,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Style Options.</summary>
		public CTFontFeatureStyleOptions (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe features related to character shapes such as Hojo Kanji forms, JIS 78 Forms, etc..</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureCharacterShape : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureCharacterShape.Feature" />.</summary>
		public enum Selector {
			/// <summary>Traditional Characters.</summary>
			TraditionalCharacters = 0,
			/// <summary>Simplified Characters.</summary>
			SimplifiedCharacters = 1,
			/// <summary>J I S1978 Characters.</summary>
			JIS1978Characters = 2,
			/// <summary>J I S1983 Characters.</summary>
			JIS1983Characters = 3,
			/// <summary>J I S1990 Characters.</summary>
			JIS1990Characters = 4,
			/// <summary>Traditional Alt One.</summary>
			TraditionalAltOne = 5,
			/// <summary>Traditional Alt Two.</summary>
			TraditionalAltTwo = 6,
			/// <summary>Traditional Alt Three.</summary>
			TraditionalAltThree = 7,
			/// <summary>Traditional Alt Four.</summary>
			TraditionalAltFour = 8,
			/// <summary>Traditional Alt Five.</summary>
			TraditionalAltFive = 9,
			/// <summary>Expert Characters.</summary>
			ExpertCharacters = 10,
			/// <summary>J I S2004 Characters.</summary>
			JIS2004Characters = 11,
			/// <summary>Hojo Characters.</summary>
			HojoCharacters = 12,
			/// <summary>N L C Characters.</summary>
			NLCCharacters = 13,
			/// <summary>Traditional Names Characters.</summary>
			TraditionalNamesCharacters = 14,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Character Shape.</summary>
		public CTFontFeatureCharacterShape (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe features related to the display of capital numbers.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureNumberCase : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureNumberCase.Feature" />.</summary>
		public enum Selector {
			/// <summary>Lower Case Numbers.</summary>
			LowerCaseNumbers = 0,
			/// <summary>Upper Case Numbers.</summary>
			UpperCaseNumbers = 1,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Number Case.</summary>
		public CTFontFeatureNumberCase (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe features related to text spacing.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureTextSpacing : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureTextSpacing.Feature" />.</summary>
		public enum Selector {
			/// <summary>Proportional Text.</summary>
			ProportionalText = 0,
			/// <summary>Monospaced Text.</summary>
			MonospacedText = 1,
			/// <summary>Half Width Text.</summary>
			HalfWidthText = 2,
			/// <summary>Third Width Text.</summary>
			ThirdWidthText = 3,
			/// <summary>Quarter Width Text.</summary>
			QuarterWidthText = 4,
			/// <summary>Alt Proportional Text.</summary>
			AltProportionalText = 5,
			/// <summary>Alt Half Width Text.</summary>
			AltHalfWidthText = 6,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Text Spacing.</summary>
		public CTFontFeatureTextSpacing (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe features related to transliteration.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureTransliteration : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureTransliteration.Feature" />.</summary>
		public enum Selector {
			/// <summary>No Transliteration.</summary>
			NoTransliteration = 0,
			/// <summary>Hanja To Hangul.</summary>
			HanjaToHangul = 1,
			/// <summary>Hiragana To Katakana.</summary>
			HiraganaToKatakana = 2,
			/// <summary>Katakana To Hiragana.</summary>
			KatakanaToHiragana = 3,
			/// <summary>Kana To Romanization.</summary>
			KanaToRomanization = 4,
			/// <summary>Romanization To Hiragana.</summary>
			RomanizationToHiragana = 5,
			/// <summary>Romanization To Katakana.</summary>
			RomanizationToKatakana = 6,
			/// <summary>Hanja To Hangul Alt One.</summary>
			HanjaToHangulAltOne = 7,
			/// <summary>Hanja To Hangul Alt Two.</summary>
			HanjaToHangulAltTwo = 8,
			/// <summary>Hanja To Hangul Alt Three.</summary>
			HanjaToHangulAltThree = 9,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Transliteration.</summary>
		public CTFontFeatureTransliteration (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe feature annotations.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureAnnotation : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureAnnotation.Feature" />.</summary>
		public enum Selector {
			/// <summary>No Annotation.</summary>
			NoAnnotation = 0,
			/// <summary>Box Annotation.</summary>
			BoxAnnotation = 1,
			/// <summary>Rounded Box Annotation.</summary>
			RoundedBoxAnnotation = 2,
			/// <summary>Circle Annotation.</summary>
			CircleAnnotation = 3,
			/// <summary>Inverted Circle Annotation.</summary>
			InvertedCircleAnnotation = 4,
			/// <summary>Parenthesis Annotation.</summary>
			ParenthesisAnnotation = 5,
			/// <summary>Period Annotation.</summary>
			PeriodAnnotation = 6,
			/// <summary>Roman Numeral Annotation.</summary>
			RomanNumeralAnnotation = 7,
			/// <summary>Diamond Annotation.</summary>
			DiamondAnnotation = 8,
			/// <summary>Inverted Box Annotation.</summary>
			InvertedBoxAnnotation = 9,
			/// <summary>Inverted Rounded Box Annotation.</summary>
			InvertedRoundedBoxAnnotation = 10,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Annotation.</summary>
		public CTFontFeatureAnnotation (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe features related to Kana spacing.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureKanaSpacing : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureCaseSensitiveLayout.Feature" />.</summary>
		public enum Selector {
			/// <summary>Full Width Kana.</summary>
			FullWidthKana = 0,
			/// <summary>Proportional Kana.</summary>
			ProportionalKana = 1,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Kana Spacing.</summary>
		public CTFontFeatureKanaSpacing (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe features related to ideographic spacing.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureIdeographicSpacing : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureIdeographicSpacing.Feature" />.</summary>
		public enum Selector {
			/// <summary>Full Width Ideographs.</summary>
			FullWidthIdeographs = 0,
			/// <summary>Proportional Ideographs.</summary>
			ProportionalIdeographs = 1,
			/// <summary>Half Width Ideographs.</summary>
			HalfWidthIdeographs = 2,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Ideographic Spacing.</summary>
		public CTFontFeatureIdeographicSpacing (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe features related to how Unicode is decomposed.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureUnicodeDecomposition : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureUnicodeDecomposition.Feature" />.</summary>
		public enum Selector {
			/// <summary>Canonical Composition On.</summary>
			CanonicalCompositionOn = 0,
			/// <summary>Canonical Composition Off.</summary>
			CanonicalCompositionOff = 1,
			/// <summary>Compatibility Composition On.</summary>
			CompatibilityCompositionOn = 2,
			/// <summary>Compatibility Composition Off.</summary>
			CompatibilityCompositionOff = 3,
			/// <summary>Transcoding Composition On.</summary>
			TranscodingCompositionOn = 4,
			/// <summary>Transcoding Composition Off.</summary>
			TranscodingCompositionOff = 5,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Unicode Decomposition.</summary>
		public CTFontFeatureUnicodeDecomposition (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe features related to applications of rubies to Kana.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureRubyKana : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureRubyKana.Feature" />.</summary>
		public enum Selector {
			/// <summary>Developers should not use this deprecated field. </summary>
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("macos10.8")]
			[ObsoletedOSPlatform ("ios5.1")]
			NoRubyKana = 0,
			/// <summary>Ruby Kana.</summary>
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("macos10.8")]
			[ObsoletedOSPlatform ("ios5.1")]
			RubyKana = 1,
			/// <summary>Ruby Kana On.</summary>
			RubyKanaOn = 2,
			/// <summary>Ruby Kana Off.</summary>
			RubyKanaOff = 3,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Ruby Kana.</summary>
		public CTFontFeatureRubyKana (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe features related to Chines, Japanese, and Korean typography.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureCJKSymbolAlternatives : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureCJKSymbolAlternatives.Feature" />.</summary>
		public enum Selector {
			/// <summary>No C J K Symbol Alternatives.</summary>
			NoCJKSymbolAlternatives = 0,
			/// <summary>C J K Symbol Alt One.</summary>
			CJKSymbolAltOne = 1,
			/// <summary>C J K Symbol Alt Two.</summary>
			CJKSymbolAltTwo = 2,
			/// <summary>C J K Symbol Alt Three.</summary>
			CJKSymbolAltThree = 3,
			/// <summary>C J K Symbol Alt Four.</summary>
			CJKSymbolAltFour = 4,
			/// <summary>C J K Symbol Alt Five.</summary>
			CJKSymbolAltFive = 5,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature C J K Symbol Alternatives.</summary>
		public CTFontFeatureCJKSymbolAlternatives (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe features related to ideographic alternatives.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureIdeographicAlternatives : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureIdeographicAlternatives.Feature" />.</summary>
		public enum Selector {
			/// <summary>No Ideographic Alternatives.</summary>
			NoIdeographicAlternatives = 0,
			/// <summary>Ideographic Alt One.</summary>
			IdeographicAltOne = 1,
			/// <summary>Ideographic Alt Two.</summary>
			IdeographicAltTwo = 2,
			/// <summary>Ideographic Alt Three.</summary>
			IdeographicAltThree = 3,
			/// <summary>Ideographic Alt Four.</summary>
			IdeographicAltFour = 4,
			/// <summary>Ideographic Alt Five.</summary>
			IdeographicAltFive = 5,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Ideographic Alternatives.</summary>
		public CTFontFeatureIdeographicAlternatives (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe features related to Chines, Japanese, and Korean typography.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureCJKVerticalRomanPlacement : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureCJKVerticalRomanPlacement.Feature" />.</summary>
		public enum Selector {
			/// <summary>C J K Vertical Roman Centered.</summary>
			CJKVerticalRomanCentered = 0,
			/// <summary>C J K Vertical Roman H Baseline.</summary>
			CJKVerticalRomanHBaseline = 1,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature C J K Vertical Roman Placement.</summary>
		public CTFontFeatureCJKVerticalRomanPlacement (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe features related to Chines, Japanese, and Korean italicized text.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureItalicCJKRoman : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureItalicCJKRoman.Feature" />.</summary>
		public enum Selector {
			/// <summary>No C J K Italic Roman.</summary>
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("macos10.8")]
			[ObsoletedOSPlatform ("ios5.1")]
			NoCJKItalicRoman = 0,
			/// <summary>Developers should not use this deprecated field. </summary>
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("macos10.8")]
			[ObsoletedOSPlatform ("ios5.1")]
			CJKItalicRoman = 1,
			/// <summary>C J K Italic Roman On.</summary>
			CJKItalicRomanOn = 2,
			/// <summary>C J K Italic Roman Off.</summary>
			CJKItalicRomanOff = 3,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Italic C J K Roman.</summary>
		public CTFontFeatureItalicCJKRoman (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe features related to case-sensitive spacing or layout.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureCaseSensitiveLayout : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureCaseSensitiveLayout.Feature" />.</summary>
		public enum Selector {
			/// <summary>Case Sensitive Layout On.</summary>
			CaseSensitiveLayoutOn = 0,
			/// <summary>Case Sensitive Layout Off.</summary>
			CaseSensitiveLayoutOff = 1,
			/// <summary>Case Sensitive Spacing On.</summary>
			CaseSensitiveSpacingOn = 2,
			/// <summary>Case Sensitive Spacing Off.</summary>
			CaseSensitiveSpacingOff = 3,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Case Sensitive Layout.</summary>
		public CTFontFeatureCaseSensitiveLayout (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> for alternate kana.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureAlternateKana : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureAlternateKana.Feature" />.</summary>
		public enum Selector {
			/// <summary>Alternate Horiz Kana On.</summary>
			AlternateHorizKanaOn = 0,
			/// <summary>Alternate Horiz Kana Off.</summary>
			AlternateHorizKanaOff = 1,
			/// <summary>Alternate Vert Kana On.</summary>
			AlternateVertKanaOn = 2,
			/// <summary>Alternate Vert Kana Off.</summary>
			AlternateVertKanaOff = 3,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Alternate Kana.</summary>
		public CTFontFeatureAlternateKana (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe features related to alternative styles.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureStylisticAlternatives : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureCaseSensitiveLayout.Feature" />.</summary>
		public enum Selector {
			/// <summary>No Stylistic Alternates.</summary>
			NoStylisticAlternates = 0,
			/// <summary>Stylistic Alt One On.</summary>
			StylisticAltOneOn = 2,
			/// <summary>Stylistic Alt One Off.</summary>
			StylisticAltOneOff = 3,
			/// <summary>Stylistic Alt Two On.</summary>
			StylisticAltTwoOn = 4,
			/// <summary>Stylistic Alt Two Off.</summary>
			StylisticAltTwoOff = 5,
			/// <summary>Stylistic Alt Three On.</summary>
			StylisticAltThreeOn = 6,
			/// <summary>Stylistic Alt Three Off.</summary>
			StylisticAltThreeOff = 7,
			/// <summary>Stylistic Alt Four On.</summary>
			StylisticAltFourOn = 8,
			/// <summary>Stylistic Alt Four Off.</summary>
			StylisticAltFourOff = 9,
			/// <summary>Stylistic Alt Five On.</summary>
			StylisticAltFiveOn = 10,
			/// <summary>Stylistic Alt Five Off.</summary>
			StylisticAltFiveOff = 11,
			/// <summary>Stylistic Alt Six On.</summary>
			StylisticAltSixOn = 12,
			/// <summary>Stylistic Alt Six Off.</summary>
			StylisticAltSixOff = 13,
			/// <summary>Stylistic Alt Seven On.</summary>
			StylisticAltSevenOn = 14,
			/// <summary>Stylistic Alt Seven Off.</summary>
			StylisticAltSevenOff = 15,
			/// <summary>Stylistic Alt Eight On.</summary>
			StylisticAltEightOn = 16,
			/// <summary>Stylistic Alt Eight Off.</summary>
			StylisticAltEightOff = 17,
			/// <summary>Stylistic Alt Nine On.</summary>
			StylisticAltNineOn = 18,
			/// <summary>Stylistic Alt Nine Off.</summary>
			StylisticAltNineOff = 19,
			/// <summary>Stylistic Alt Ten On.</summary>
			StylisticAltTenOn = 20,
			/// <summary>Stylistic Alt Ten Off.</summary>
			StylisticAltTenOff = 21,
			/// <summary>Stylistic Alt Eleven On.</summary>
			StylisticAltElevenOn = 22,
			/// <summary>Stylistic Alt Eleven Off.</summary>
			StylisticAltElevenOff = 23,
			/// <summary>Stylistic Alt Twelve On.</summary>
			StylisticAltTwelveOn = 24,
			/// <summary>Stylistic Alt Twelve Off.</summary>
			StylisticAltTwelveOff = 25,
			/// <summary>Stylistic Alt Thirteen On.</summary>
			StylisticAltThirteenOn = 26,
			/// <summary>Stylistic Alt Thirteen Off.</summary>
			StylisticAltThirteenOff = 27,
			/// <summary>Stylistic Alt Fourteen On.</summary>
			StylisticAltFourteenOn = 28,
			/// <summary>Stylistic Alt Fourteen Off.</summary>
			StylisticAltFourteenOff = 29,
			/// <summary>Stylistic Alt Fifteen On.</summary>
			StylisticAltFifteenOn = 30,
			/// <summary>Stylistic Alt Fifteen Off.</summary>
			StylisticAltFifteenOff = 31,
			/// <summary>Stylistic Alt Sixteen On.</summary>
			StylisticAltSixteenOn = 32,
			/// <summary>Stylistic Alt Sixteen Off.</summary>
			StylisticAltSixteenOff = 33,
			/// <summary>Stylistic Alt Seventeen On.</summary>
			StylisticAltSeventeenOn = 34,
			/// <summary>Stylistic Alt Seventeen Off.</summary>
			StylisticAltSeventeenOff = 35,
			/// <summary>Stylistic Alt Eighteen On.</summary>
			StylisticAltEighteenOn = 36,
			/// <summary>Stylistic Alt Eighteen Off.</summary>
			StylisticAltEighteenOff = 37,
			/// <summary>Stylistic Alt Nineteen On.</summary>
			StylisticAltNineteenOn = 38,
			/// <summary>Stylistic Alt Nineteen Off.</summary>
			StylisticAltNineteenOff = 39,
			/// <summary>Stylistic Alt Twenty On.</summary>
			StylisticAltTwentyOn = 40,
			/// <summary>Stylistic Alt Twenty Off.</summary>
			StylisticAltTwentyOff = 41,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Stylistic Alternatives.</summary>
		public CTFontFeatureStylisticAlternatives (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe features related to swash alternatives.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureContextualAlternates : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureContextualAlternates.Feature" />.</summary>
		public enum Selector {
			/// <summary>Contextual Alternates On.</summary>
			ContextualAlternatesOn = 0,
			/// <summary>Contextual Alternates Off.</summary>
			ContextualAlternatesOff = 1,
			/// <summary>Swash Alternates On.</summary>
			SwashAlternatesOn = 2,
			/// <summary>Swash Alternates Off.</summary>
			SwashAlternatesOff = 3,
			/// <summary>Contextual Swash Alternates On.</summary>
			ContextualSwashAlternatesOn = 4,
			/// <summary>Contextual Swash Alternates Off.</summary>
			ContextualSwashAlternatesOff = 5,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Contextual Alternates.</summary>
		public CTFontFeatureContextualAlternates (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe features related to how lower-case letters are rendered.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureLowerCase : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureLowerCase.Feature" />.</summary>
		public enum Selector {
			/// <summary>Default Lower Case.</summary>
			DefaultLowerCase = 0,
			/// <summary>Lower Case Small Caps.</summary>
			LowerCaseSmallCaps = 1,
			/// <summary>Lower Case Petite Caps.</summary>
			LowerCasePetiteCaps = 2,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Lower Case.</summary>
		public CTFontFeatureLowerCase (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe features related to how upper-case letters should be displayed.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureUpperCase : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureUpperCase.Feature" />.</summary>
		public enum Selector {
			/// <summary>Default Upper Case.</summary>
			DefaultUpperCase = 0,
			/// <summary>Upper Case Small Caps.</summary>
			UpperCaseSmallCaps = 1,
			/// <summary>Upper Case Petite Caps.</summary>
			UpperCasePetiteCaps = 2,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature Upper Case.</summary>
		public CTFontFeatureUpperCase (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>A <see cref="CoreText.CTFontFeatureSelectors" /> that describe features related to Chines, Japanese, and Korean typography.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureCJKRomanSpacing : CTFontFeatureSelectors {
		/// <summary>An enumeration whose values are returned by <see cref="CoreText.CTFontFeatureCJKRomanSpacing.Feature" />.</summary>
		public enum Selector {
			/// <summary>Half Width C J K Roman.</summary>
			HalfWidthCJKRoman = 0,
			/// <summary>Proportional C J K Roman.</summary>
			ProportionalCJKRoman = 1,
			/// <summary>Default C J K Roman.</summary>
			DefaultCJKRoman = 2,
			/// <summary>Full Width C J K Roman.</summary>
			FullWidthCJKRoman = 3,
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Feature C J K Roman Spacing.</summary>
		public CTFontFeatureCJKRomanSpacing (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		/// <summary>Gets the feature.</summary>
		public Selector Feature {
			get {
				return (Selector) FeatureWeak;
			}
		}
	}

	/// <summary>The feature settings of a <see cref="CoreText.CTFont" /> or <see cref="CoreText.CTFontDescriptorAttributes" />.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontFeatureSettings {

		internal CTFontFeatureSettings (NSDictionary dictionary)
		{
			if (dictionary is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dictionary));
			Dictionary = dictionary;
		}

		/// <summary>Gets the dictionary.</summary>
		public NSDictionary Dictionary { get; private set; }

		/// <summary>Gets the feature group.</summary>
		public FontFeatureGroup FeatureGroup {
			get {
				var number = (NSNumber?) Dictionary [CTFontFeatureKey.Identifier];
				if (number is null)
					return default;
				return (FontFeatureGroup) (int) number;
			}
		}

		/// <summary>Gets the feature weak.</summary>
		public int FeatureWeak {
			get {
				var number = (NSNumber?) Dictionary [CTFontFeatureSelectorKey.Identifier];
				if (number is null)
					return default;
				return (int) number;
			}
		}
	}

	/// <summary>Encapsulates a font-variation-axis dictionary.</summary>
	///     <altmember cref="CoreText.CTFontVariationAxisKey" />
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontVariationAxes {

		/// <summary>C T Font Variation Axes.</summary>
		public CTFontVariationAxes ()
			: this (new NSMutableDictionary ())
		{
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Variation Axes.</summary>
		public CTFontVariationAxes (NSDictionary dictionary)
		{
			if (dictionary is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dictionary));
			Dictionary = dictionary;
		}

		/// <summary>Gets the dictionary.</summary>
		public NSDictionary Dictionary { get; private set; }

		/// <summary>Gets the identifier.</summary>
		public NSNumber? Identifier {
			get { return (NSNumber?) Dictionary [CTFontVariationAxisKey.Identifier]; }
			set { Adapter.SetValue (Dictionary, CTFontVariationAxisKey.Identifier, value); }
		}

		/// <summary>Gets the minimum value.</summary>
		public NSNumber? MinimumValue {
			get { return (NSNumber?) Dictionary [CTFontVariationAxisKey.MinimumValue]; }
			set { Adapter.SetValue (Dictionary, CTFontVariationAxisKey.MinimumValue, value); }
		}

		/// <summary>Gets the maximum value.</summary>
		public NSNumber? MaximumValue {
			get { return (NSNumber?) Dictionary [CTFontVariationAxisKey.MaximumValue]; }
			set { Adapter.SetValue (Dictionary, CTFontVariationAxisKey.MaximumValue, value); }
		}

		/// <summary>Gets the default value.</summary>
		public NSNumber? DefaultValue {
			get { return (NSNumber?) Dictionary [CTFontVariationAxisKey.DefaultValue]; }
			set { Adapter.SetValue (Dictionary, CTFontVariationAxisKey.DefaultValue, value); }
		}

		/// <summary>Gets the name.</summary>
		public string? Name {
			get { return Adapter.GetStringValue (Dictionary, CTFontVariationAxisKey.Name); }
			set { Adapter.SetValue (Dictionary, CTFontVariationAxisKey.Name, value); }
		}

		/// <summary>Gets the hidden.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public bool? Hidden {
			get { return Adapter.GetBoolValue (Dictionary, CTFontVariationAxisKey.Hidden); }
			set { Adapter.SetValue (Dictionary, CTFontVariationAxisKey.Hidden, value); }
		}
	}

	/// <summary>Encapsulates a font-variation dictionary.</summary>
	///     <altmember cref="CoreText.CTFont.GetVariation" />
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFontVariation {

		/// <summary>C T Font Variation.</summary>
		public CTFontVariation ()
			: this (new NSMutableDictionary ())
		{
		}

		/// <param name="dictionary">The dictionary.</param>
		/// <summary>C T Font Variation.</summary>
		public CTFontVariation (NSDictionary dictionary)
		{
			if (dictionary is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dictionary));
			Dictionary = dictionary;
		}

		/// <summary>Gets the dictionary.</summary>
		public NSDictionary Dictionary { get; private set; }
	}

	/// <summary>Represents a CoreText Font.</summary>
	///     <remarks>
	///       <para>
	/// 	CoreText does not synthesize font styles (italic and bold).
	/// 	This means that if you pick a font that has neither a Bolded
	/// 	or Italicized versions available, CoreText will not create a
	/// 	dynamic font that is merely a slanted version of the font for
	/// 	italic, or a boldened version from the original font.  In
	/// 	those cases, if you want to synthesize the font, you could
	/// 	apply a Matrix transformation to slant the font (it will still
	/// 	be wrong, but will look slanted).  For bolding, you could
	/// 	stroke the font twice, or manually extend the glyph path.
	///
	///       </para>
	///     </remarks>
	///     <related type="sample" href="https://github.com/xamarin/ios-samples/tree/master/SimpleTextInput/">SimpleTextInput</related>
	public partial class CTFont : NativeObject {
		[Preserve (Conditional = true)]
		internal CTFont (NativeHandle handle, bool owns)
			: base (handle, owns, true)
		{
		}

		#region Font Creation
		static IntPtr Create (string name, nfloat size)
		{
			var n = CFString.CreateNative (name);
			try {
				IntPtr handle;
				unsafe {
					handle = CTFontCreateWithName (n, size, null);
				}
				if (handle == IntPtr.Zero)
					throw ConstructorError.Unknown (typeof (CTFont));
				return handle;
			} finally {
				CFString.ReleaseNative (n);
			}
		}

		public CTFont (string name, nfloat size)
			: base (Create (name, size), true)
		{
		}

		[DllImport (Constants.CoreTextLibrary)]
		unsafe static extern IntPtr CTFontCreateWithName (IntPtr name, nfloat size, CGAffineTransform* matrix);

		static IntPtr Create (string name, nfloat size, ref CGAffineTransform matrix)
		{
			var n = CFString.CreateNative (name);
			try {
				IntPtr handle;
				unsafe {
					fixed (CGAffineTransform* matrixPtr = &matrix)
						handle = CTFontCreateWithName (n, size, matrixPtr);
				}
				if (handle == IntPtr.Zero)
					throw ConstructorError.Unknown (typeof (CTFont));
				return handle;
			} finally {
				CFString.ReleaseNative (n);
			}
		}

		public CTFont (string name, nfloat size, ref CGAffineTransform matrix)
			: base (Create (name, size, ref matrix), true)
		{
		}

		static IntPtr Create (CTFontDescriptor descriptor, nfloat size)
		{
			if (descriptor is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (descriptor));
			IntPtr handle;
			unsafe {
				handle = CTFontCreateWithFontDescriptor (descriptor.Handle, size, null);
				GC.KeepAlive (descriptor);
			}
			if (handle == IntPtr.Zero)
				throw ConstructorError.Unknown (typeof (CTFont));
			return handle;
		}

		public CTFont (CTFontDescriptor descriptor, nfloat size)
			: base (Create (descriptor, size), true)
		{
		}

		[DllImport (Constants.CoreTextLibrary)]
		unsafe static extern IntPtr CTFontCreateWithFontDescriptor (IntPtr descriptor, nfloat size, CGAffineTransform* matrix);

		static IntPtr Create (CTFontDescriptor descriptor, nfloat size, ref CGAffineTransform matrix)
		{
			if (descriptor is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (descriptor));
			IntPtr handle;
			unsafe {
				fixed (CGAffineTransform* matrixPtr = &matrix) {
					handle = CTFontCreateWithFontDescriptor (descriptor.Handle, size, matrixPtr);
					GC.KeepAlive (descriptor);
				}
			}
			if (handle == IntPtr.Zero)
				throw ConstructorError.Unknown (typeof (CTFont));
			return handle;
		}

		public CTFont (CTFontDescriptor descriptor, nfloat size, ref CGAffineTransform matrix)
			: base (Create (descriptor, size, ref matrix), true)
		{
		}

		static IntPtr Create (string name, nfloat size, CTFontOptions options)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var n = CFString.CreateNative (name);
			try {
				IntPtr handle;
				unsafe {
					handle = CTFontCreateWithNameAndOptions (n, size, null, (nuint) (ulong) options);
				}
				if (handle == IntPtr.Zero)
					throw ConstructorError.Unknown (typeof (CTFont));
				return handle;
			} finally {
				CFString.ReleaseNative (n);
			}
		}

		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public CTFont (string name, nfloat size, CTFontOptions options)
			: base (Create (name, size, options), true)
		{
		}

		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[DllImport (Constants.CoreTextLibrary)]
		unsafe static extern IntPtr CTFontCreateWithNameAndOptions (IntPtr name, nfloat size, CGAffineTransform* matrix, nuint options);

		static IntPtr Create (string name, nfloat size, ref CGAffineTransform matrix, CTFontOptions options)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var n = CFString.CreateNative (name);
			try {
				IntPtr handle;
				unsafe {
					fixed (CGAffineTransform* matrixPtr = &matrix) {
						handle = CTFontCreateWithNameAndOptions (n, size, matrixPtr, (nuint) (ulong) options);
					}
				}
				if (handle == IntPtr.Zero)
					throw ConstructorError.Unknown (typeof (CTFont));
				return handle;
			} finally {
				CFString.ReleaseNative (n);
			}
		}

		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public CTFont (string name, nfloat size, ref CGAffineTransform matrix, CTFontOptions options)
			: base (Create (name, size, ref matrix, options), true)
		{
		}

		static IntPtr Create (CTFontDescriptor descriptor, nfloat size, CTFontOptions options)
		{
			if (descriptor is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (descriptor));
			IntPtr handle;
			unsafe {
				handle = CTFontCreateWithFontDescriptorAndOptions (descriptor.Handle, size, null, (nuint) (ulong) options);
				GC.KeepAlive (descriptor);
			}
			if (handle == IntPtr.Zero)
				throw ConstructorError.Unknown (typeof (CTFont));
			return handle;
		}

		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public CTFont (CTFontDescriptor descriptor, nfloat size, CTFontOptions options)
			: base (Create (descriptor, size, options), true)
		{
		}

		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[DllImport (Constants.CoreTextLibrary)]
		unsafe static extern IntPtr CTFontCreateWithFontDescriptorAndOptions (IntPtr descriptor, nfloat size, CGAffineTransform* matrix, nuint options);

		static IntPtr Create (CTFontDescriptor descriptor, nfloat size, CTFontOptions options, ref CGAffineTransform matrix)
		{
			if (descriptor is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (descriptor));
			IntPtr handle;
			unsafe {
				fixed (CGAffineTransform* matrixPtr = &matrix) {
					handle = CTFontCreateWithFontDescriptorAndOptions (descriptor.Handle, size, matrixPtr, (nuint) (ulong) options);
					GC.KeepAlive (descriptor);
				}
			}
			if (handle == IntPtr.Zero)
				throw ConstructorError.Unknown (typeof (CTFont));
			return handle;
		}

		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public CTFont (CTFontDescriptor descriptor, nfloat size, CTFontOptions options, ref CGAffineTransform matrix)
			: base (Create (descriptor, size, options, ref matrix), true)
		{
		}

		[DllImport (Constants.CoreTextLibrary)]
		unsafe static extern /* CTFontRef __nonnull */ IntPtr CTFontCreateWithGraphicsFont (
			/* CGFontRef __nonnull */ IntPtr cgfontRef, nfloat size,
			/* const CGAffineTransform * __nullable */ CGAffineTransform* affine,
			/* CTFontDescriptorRef __nullable */ IntPtr attrs);

		static IntPtr Create (CGFont font, nfloat size, CGAffineTransform transform, CTFontDescriptor descriptor)
		{
			if (font is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (font));
			IntPtr handle;
			unsafe {
				handle = CTFontCreateWithGraphicsFont (font.Handle, size, &transform, descriptor.GetHandle ());
				GC.KeepAlive (font);
				GC.KeepAlive (descriptor);
			}
			if (handle == IntPtr.Zero)
				throw ConstructorError.Unknown (typeof (CTFont));
			return handle;
		}

		public CTFont (CGFont font, nfloat size, CGAffineTransform transform, CTFontDescriptor descriptor)
			: base (Create (font, size, transform, descriptor), true)
		{
		}

		static IntPtr Create (CGFont font, nfloat size, CTFontDescriptor descriptor)
		{
			if (font is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (font));
			IntPtr handle;
			unsafe {
				handle = CTFontCreateWithGraphicsFont (font.Handle, size, null, descriptor.GetHandle ());
				GC.KeepAlive (font);
				GC.KeepAlive (descriptor);
			}
			if (handle == IntPtr.Zero)
				throw ConstructorError.Unknown (typeof (CTFont));
			return handle;
		}

		public CTFont (CGFont font, nfloat size, CTFontDescriptor descriptor)
			: base (Create (font, size, descriptor), true)
		{
		}

		static IntPtr Create (CGFont font, nfloat size, CGAffineTransform transform)
		{
			if (font is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (font));
			IntPtr handle;
			unsafe {
				handle = CTFontCreateWithGraphicsFont (font.Handle, size, &transform, IntPtr.Zero);
				GC.KeepAlive (font);
			}
			if (handle == IntPtr.Zero)
				throw ConstructorError.Unknown (typeof (CTFont));
			return handle;
		}

		public CTFont (CGFont font, nfloat size, CGAffineTransform transform)
			: base (Create (font, size, transform), true)
		{
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern IntPtr CTFontCreateUIFontForLanguage (CTFontUIFontType uiType, nfloat size, IntPtr language);

		static IntPtr Create (CTFontUIFontType uiType, nfloat size, string language)
		{
			var n = CFString.CreateNative (language);
			try {
				var handle = CTFontCreateUIFontForLanguage (uiType, size, n);
				if (handle == IntPtr.Zero)
					throw ConstructorError.Unknown (typeof (CTFont));
				return handle;
			} finally {
				CFString.ReleaseNative (n);
			}
		}

		public CTFont (CTFontUIFontType uiType, nfloat size, string language)
			: base (Create (uiType, size, language), true)
		{
		}

		public CTFont? WithAttributes (nfloat size, CTFontDescriptor attributes)
		{
			if (attributes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (attributes));
			unsafe {
				CTFont? result = CreateFont (CTFontCreateCopyWithAttributes (Handle, size, null, attributes.Handle));
				GC.KeepAlive (attributes);
				return result;
			}
		}

		static CTFont? CreateFont (IntPtr h)
		{
			if (h == IntPtr.Zero)
				return null;
			return new CTFont (h, true);
		}

		[DllImport (Constants.CoreTextLibrary)]
		unsafe static extern IntPtr CTFontCreateCopyWithAttributes (IntPtr font, nfloat size, CGAffineTransform* matrix, IntPtr attributes);
		public CTFont? WithAttributes (nfloat size, CTFontDescriptor attributes, ref CGAffineTransform matrix)
		{
			unsafe {
				fixed (CGAffineTransform* matrixPtr = &matrix) {
					CTFont? result = CreateFont (CTFontCreateCopyWithAttributes (Handle, size, matrixPtr, attributes.GetHandle ()));
					GC.KeepAlive (attributes);
					return result;
				}
			}
		}

		public CTFont? WithSymbolicTraits (nfloat size, CTFontSymbolicTraits symTraitValue, CTFontSymbolicTraits symTraitMask)
		{
			unsafe {
				return CreateFont (CTFontCreateCopyWithSymbolicTraits (Handle, size, null, symTraitValue, symTraitMask));
			}
		}

		[DllImport (Constants.CoreTextLibrary)]
		unsafe static extern IntPtr CTFontCreateCopyWithSymbolicTraits (IntPtr font, nfloat size, CGAffineTransform* matrix, CTFontSymbolicTraits symTraitValue, CTFontSymbolicTraits symTraitMask);
		public CTFont? WithSymbolicTraits (nfloat size, CTFontSymbolicTraits symTraitValue, CTFontSymbolicTraits symTraitMask, ref CGAffineTransform matrix)
		{
			unsafe {
				fixed (CGAffineTransform* matrixPtr = &matrix) {
					return CreateFont (CTFontCreateCopyWithSymbolicTraits (Handle, size, matrixPtr, symTraitValue, symTraitMask));
				}
			}
		}

		public CTFont? WithFamily (nfloat size, string family)
		{
			if (family is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (family));
			var n = CFString.CreateNative (family);
			try {
				unsafe {
					return CreateFont (CTFontCreateCopyWithFamily (Handle, size, null, n));
				}
			} finally {
				CFString.ReleaseNative (n);
			}
		}

		[DllImport (Constants.CoreTextLibrary)]
		unsafe static extern IntPtr CTFontCreateCopyWithFamily (IntPtr font, nfloat size, CGAffineTransform* matrix, IntPtr family);
		public CTFont? WithFamily (nfloat size, string family, ref CGAffineTransform matrix)
		{
			if (family is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (family));
			var n = CFString.CreateNative (family);
			try {
				unsafe {
					fixed (CGAffineTransform* matrixPtr = &matrix) {
						return CreateFont (CTFontCreateCopyWithFamily (Handle, size, matrixPtr, n));
					}
				}
			} finally {
				CFString.ReleaseNative (n);
			}
		}

		#endregion

		#region Font Cascading

		[DllImport (Constants.CoreTextLibrary)]
		static extern /* CTFontRef __nonnull */ IntPtr CTFontCreateForString (
			/* CTFontRef __nonnull */ IntPtr currentFont,
			/* CFStringRef __nonnull */ IntPtr @string,
			NSRange range);

		/// <param name="value">The value.</param>
		/// <param name="range">The range.</param>
		/// <summary>For String.</summary>
		public CTFont? ForString (string value, NSRange range)
		{
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var n = CFString.CreateNative (value);
			try {
				return CreateFont (CTFontCreateForString (Handle, n, range));
			} finally {
				CFString.ReleaseNative (n);
			}
		}

		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[DllImport (Constants.CoreTextLibrary)]
		static extern /* CTFontRef */ IntPtr CTFontCreateForStringWithLanguage (
			/* CTFontRef */ IntPtr currentFont,
			/* CFStringRef */ IntPtr @string,
			NSRange range,
			/* CFStringRef _Nullable */ IntPtr language);

		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public CTFont? ForString (string value, NSRange range, string? language)
		{
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));

			var v = CFString.CreateNative (value);
			var l = CFString.CreateNative (language);
			try {
				return CreateFont (CTFontCreateForStringWithLanguage (Handle, v, range, l));
			} finally {
				CFString.ReleaseNative (l);
				CFString.ReleaseNative (v);
			}
		}

		#endregion

		#region Font Accessors

		[DllImport (Constants.CoreTextLibrary)]
		static extern /* CTFontDescriptorRef __nonnull */ IntPtr CTFontCopyFontDescriptor (
			/* CTFontRef __nonnull */ IntPtr font);

		/// <summary>Get Font Descriptor.</summary>
		public CTFontDescriptor GetFontDescriptor ()
		{
			var h = CTFontCopyFontDescriptor (Handle);
			return new CTFontDescriptor (h, true);
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern /* CFTypeRef __nullable */ IntPtr CTFontCopyAttribute (/* CTFontRef __nonnull */ IntPtr font,
			/* CFStringRef __nonnull */ IntPtr attribute);

		/// <param name="attribute">The attribute.</param>
		/// <summary>Get Attribute.</summary>
		public NSObject? GetAttribute (NSString attribute)
		{
			if (attribute is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (attribute));
			var result = Runtime.GetNSObject (CTFontCopyAttribute (Handle, attribute.Handle), true);
			GC.KeepAlive (attribute);
			return result;
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern nfloat CTFontGetSize (IntPtr font);
		/// <summary>The font size.</summary>
		///         <value>
		///         </value>
		///         <remarks>This is the size that was used when the font was constructed.</remarks>
		public nfloat Size {
			get { return CTFontGetSize (Handle); }
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern CGAffineTransform CTFontGetMatrix (/* CTFontRef __nonnull */ IntPtr font);

		/// <summary>The transformation matrix used when this font was created.</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///         </remarks>
		public CGAffineTransform Matrix {
			get { return CTFontGetMatrix (Handle); }
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern CTFontSymbolicTraits CTFontGetSymbolicTraits (IntPtr font);
		/// <summary>Gets the symbolic traits.</summary>
		public CTFontSymbolicTraits SymbolicTraits {
			get { return CTFontGetSymbolicTraits (Handle); }
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern CTFontUIFontType CTFontGetUIFontType (IntPtr font);

		/// <summary>Gets the UI font type of the font.</summary>
		/// <value>The UI font type, or <see cref="CTFontUIFontType.None" /> if the font is not a UI font.</value>
		[SupportedOSPlatform ("ios26.4")]
		[SupportedOSPlatform ("maccatalyst26.4")]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("tvos26.4")]
		public CTFontUIFontType UIFontType {
			get { return CTFontGetUIFontType (GetCheckedHandle ()); }
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern IntPtr CTFontCopyTraits (IntPtr font);
		/// <summary>Get Traits.</summary>
		public CTFontTraits? GetTraits ()
		{
			var d = Runtime.GetNSObject<NSDictionary> (CTFontCopyTraits (Handle), true);
			if (d is null)
				return null;
			return new CTFontTraits (d);
		}

		#endregion

		#region Font Names
		[DllImport (Constants.CoreTextLibrary)]
		static extern IntPtr CTFontCopyPostScriptName (IntPtr font);
		/// <summary>Gets the post script name.</summary>
		public string? PostScriptName {
			get { return CFString.FromHandle (CTFontCopyPostScriptName (Handle), releaseHandle: true); }
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern /* CFStringRef __nonnull */ IntPtr CTFontCopyFamilyName (
			/* CTFontRef __nonnull */ IntPtr font);

		/// <summary>Gets the family name.</summary>
		public string? FamilyName {
			get { return CFString.FromHandle (CTFontCopyFamilyName (Handle), releaseHandle: true); }
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern /* CFStringRef __nonnull */ IntPtr CTFontCopyFullName (
			/* CTFontRef __nonnull */ IntPtr font);

		/// <summary>Gets the full name.</summary>
		public string? FullName {
			get { return CFString.FromHandle (CTFontCopyFullName (Handle), releaseHandle: true); }
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern /* CFStringRef __nonnull */ IntPtr CTFontCopyDisplayName (
			/* CTFontRef __nonnull */ IntPtr font);

		/// <summary>Gets the display name.</summary>
		public string? DisplayName {
			get { return CFString.FromHandle (CTFontCopyDisplayName (Handle), releaseHandle: true); }
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern IntPtr CTFontCopyName (IntPtr font, IntPtr nameKey);
		/// <param name="nameKey">The nameKey.</param>
		/// <summary>Get Name.</summary>
		public string? GetName (CTFontNameKey nameKey)
		{
			var id = CTFontNameKeyId.ToId (nameKey);
			string? name = CFString.FromHandle (CTFontCopyName (Handle, id.GetHandle ()), releaseHandle: true);
			GC.KeepAlive (id);
			return name;
		}

		[DllImport (Constants.CoreTextLibrary)]
		unsafe static extern IntPtr CTFontCopyLocalizedName (IntPtr font, IntPtr nameKey, IntPtr* actualLanguage);

		/// <param name="nameKey">The nameKey.</param>
		/// <summary>Get Localized Name.</summary>
		public string? GetLocalizedName (CTFontNameKey nameKey)
		{
			return GetLocalizedName (nameKey, out _);
		}

		/// <param name="nameKey">The nameKey.</param>
		/// <param name="actualLanguage">The actualLanguage.</param>
		/// <summary>Get Localized Name.</summary>
		public string? GetLocalizedName (CTFontNameKey nameKey, out string? actualLanguage)
		{
			IntPtr actual;
			string? ret;
			unsafe {
				var id = CTFontNameKeyId.ToId (nameKey);
				ret = CFString.FromHandle (CTFontCopyLocalizedName (Handle, id.GetHandle (), &actual), releaseHandle: true);
				GC.KeepAlive (id);
			}
			actualLanguage = CFString.FromHandle (actual, releaseHandle: true);
			return ret;
		}
		#endregion

		#region Font Encoding
		[DllImport (Constants.CoreTextLibrary)]
		static extern /* CFCharacterSetRef __nonnull */ IntPtr CTFontCopyCharacterSet (
			/* CTFontRef __nonnull */ IntPtr font);

		/// <summary>Gets the character set.</summary>
		public NSCharacterSet? CharacterSet {
			get {
				return Runtime.GetNSObject<NSCharacterSet> (CTFontCopyCharacterSet (Handle), true);
			}
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern uint CTFontGetStringEncoding (IntPtr font);
		/// <summary>Gets the string encoding.</summary>
		public uint StringEncoding {
			get { return CTFontGetStringEncoding (Handle); }
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern IntPtr CTFontCopySupportedLanguages (IntPtr font);
		/// <summary>Get Supported Languages.</summary>
		public string? [] GetSupportedLanguages ()
		{
			var cfArrayRef = CTFontCopySupportedLanguages (Handle);
			if (cfArrayRef == IntPtr.Zero)
				return Array.Empty<string> ();
			return CFArray.StringArrayFromHandle (cfArrayRef, true)!;
		}

		[DllImport (Constants.CoreTextLibrary, CharSet = CharSet.Unicode)]
		unsafe static extern byte CTFontGetGlyphsForCharacters (IntPtr font, ushort* characters, CGGlyph* glyphs, nint count);

		public bool GetGlyphsForCharacters (char [] characters, CGGlyph [] glyphs, nint count)
		{
			AssertCount (count);
			AssertLength ("characters", characters, count);
			AssertLength ("glyphs", characters, count);

			unsafe {
				fixed (char* charactersPtr = characters) {
					fixed (CGGlyph* glyphsPtr = glyphs) {
						return CTFontGetGlyphsForCharacters (Handle, (ushort*) charactersPtr, glyphsPtr, count) != 0;
					}
				}
			}
		}

		/// <param name="characters">The characters.</param>
		/// <param name="glyphs">The glyphs.</param>
		/// <summary>Get Glyphs For Characters.</summary>
		public bool GetGlyphsForCharacters (char [] characters, CGGlyph [] glyphs)
		{
			return GetGlyphsForCharacters (characters, glyphs, Math.Min (characters.Length, glyphs.Length));
		}

		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[DllImport (Constants.CoreTextLibrary)]
		static extern unsafe /* CFStringRef _Nullable */ IntPtr CTFontCopyNameForGlyph (/* CTFontRef */ IntPtr font, CGGlyph glyph);

		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public string? GetGlyphName (CGGlyph glyph)
		{
			return CFString.FromHandle (CTFontCopyNameForGlyph (Handle, glyph), releaseHandle: true);
		}

		static void AssertCount (nint count)
		{
			if (count < 0)
				throw new ArgumentOutOfRangeException (nameof (count), "cannot be negative");
		}

		static void AssertLength<T> (string name, T []? array, nint count)
		{
			AssertLength (name, array, count, false);
		}

		static void AssertLength<T> (string name, T []? array, nint count, bool canBeNull)
		{
			if (canBeNull && array is null)
				return;
			if (array is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			if (array.Length < count)
				throw new ArgumentException (string.Format ("{0}.Length cannot be < count", name), name);
		}
		#endregion

		#region Font Metrics
		[DllImport (Constants.CoreTextLibrary)]
		static extern nfloat CTFontGetAscent (/* CTFontRef __nonnull */ IntPtr font);

		/// <summary>Gets the ascent metric.</summary>
		public nfloat AscentMetric {
			get { return CTFontGetAscent (Handle); }
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern nfloat CTFontGetDescent (/* CTFontRef __nonnull */ IntPtr font);

		/// <summary>Gets the descent metric.</summary>
		public nfloat DescentMetric {
			get { return CTFontGetDescent (Handle); }
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern nfloat CTFontGetLeading (/* CTFontRef __nonnull */ IntPtr font);

		/// <summary>Gets the leading metric.</summary>
		public nfloat LeadingMetric {
			get { return CTFontGetLeading (Handle); }
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern uint CTFontGetUnitsPerEm (IntPtr font);
		/// <summary>Gets the units per em metric.</summary>
		public uint UnitsPerEmMetric {
			get { return CTFontGetUnitsPerEm (Handle); }
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern /* CFIndex */ nint CTFontGetGlyphCount (/* CTFontRef __nonnull */ IntPtr font);

		/// <summary>Gets the glyph count.</summary>
		public nint GlyphCount {
			get { return CTFontGetGlyphCount (Handle); }
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern CGRect CTFontGetBoundingBox (/* CTFontRef __nonnull */ IntPtr font);

		/// <summary>Gets the bounding box.</summary>
		public CGRect BoundingBox {
			get { return CTFontGetBoundingBox (Handle); }
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern nfloat CTFontGetUnderlinePosition (IntPtr font);
		/// <summary>Gets the underline position.</summary>
		public nfloat UnderlinePosition {
			get { return CTFontGetUnderlinePosition (Handle); }
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern nfloat CTFontGetUnderlineThickness (IntPtr font);
		/// <summary>Gets the underline thickness.</summary>
		public nfloat UnderlineThickness {
			get { return CTFontGetUnderlineThickness (Handle); }
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern nfloat CTFontGetSlantAngle (IntPtr font);
		/// <summary>Gets the slant angle.</summary>
		public nfloat SlantAngle {
			get { return CTFontGetSlantAngle (Handle); }
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern nfloat CTFontGetCapHeight (/* CTFontRef __nonnull */ IntPtr font);

		/// <summary>Gets the cap height metric.</summary>
		public nfloat CapHeightMetric {
			get { return CTFontGetCapHeight (Handle); }
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern nfloat CTFontGetXHeight (IntPtr font);
		/// <summary>Gets the x height metric.</summary>
		public nfloat XHeightMetric {
			get { return CTFontGetXHeight (Handle); }
		}
		#endregion

		#region Font Glyphs
		[DllImport (Constants.CoreTextLibrary)]
		static extern CGGlyph CTFontGetGlyphWithName (/* CTFontRef __nonnull */ IntPtr font,
			/* CFStringRef __nonnull */ IntPtr glyphName);

		/// <param name="glyphName">The glyphName.</param>
		/// <summary>Get Glyph With Name.</summary>
		public CGGlyph GetGlyphWithName (string glyphName)
		{
			if (glyphName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (glyphName));
			var nameHandle = CFString.CreateNative (glyphName);
			try {
				return CTFontGetGlyphWithName (Handle, nameHandle);
			} finally {
				CFString.ReleaseNative (nameHandle);
			}
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern CGRect CTFontGetBoundingRectsForGlyphs (IntPtr font, CTFontOrientation orientation, [In] CGGlyph [] glyphs, [Out] CGRect []? boundingRects, nint count);
		public CGRect GetBoundingRects (CTFontOrientation orientation, CGGlyph [] glyphs, CGRect []? boundingRects, nint count)
		{
			AssertCount (count);
			AssertLength ("glyphs", glyphs, count);
			AssertLength ("boundingRects", boundingRects, count, true);

			return CTFontGetBoundingRectsForGlyphs (Handle, orientation, glyphs, boundingRects, count);
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern CGRect CTFontGetOpticalBoundsForGlyphs (IntPtr font, [In] CGGlyph [] glyphs, [Out] CGRect [] boundingRects, nint count, nuint options);

		public CGRect GetOpticalBounds (CGGlyph [] glyphs, CGRect [] boundingRects, nint count, CTFontOptions options = 0)
		{
			AssertCount (count);
			AssertLength ("glyphs", glyphs, count);
			AssertLength ("boundingRects", boundingRects, count, true);

			return CTFontGetOpticalBoundsForGlyphs (Handle, glyphs, boundingRects, count, (nuint) (ulong) options);
		}

		/// <param name="orientation">The orientation.</param>
		/// <param name="glyphs">The glyphs.</param>
		/// <summary>Get Bounding Rects.</summary>
		public CGRect GetBoundingRects (CTFontOrientation orientation, CGGlyph [] glyphs)
		{
			if (glyphs is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (glyphs));
			return GetBoundingRects (orientation, glyphs, null, glyphs.Length);
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern double CTFontGetAdvancesForGlyphs (IntPtr font, CTFontOrientation orientation, [In] CGGlyph [] glyphs, [Out] CGSize []? advances, nint count);
		public double GetAdvancesForGlyphs (CTFontOrientation orientation, CGGlyph [] glyphs, CGSize []? advances, nint count)
		{
			AssertCount (count);
			AssertLength ("glyphs", glyphs, count);
			AssertLength ("advances", advances, count, true);

			return CTFontGetAdvancesForGlyphs (Handle, orientation, glyphs, advances, count);
		}

		/// <param name="orientation">The orientation.</param>
		/// <param name="glyphs">The glyphs.</param>
		/// <summary>Get Advances For Glyphs.</summary>
		public double GetAdvancesForGlyphs (CTFontOrientation orientation, CGGlyph [] glyphs)
		{
			if (glyphs is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (glyphs));
			return GetAdvancesForGlyphs (orientation, glyphs, null, glyphs.Length);
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern void CTFontGetVerticalTranslationsForGlyphs (IntPtr font, [In] CGGlyph [] glyphs, [Out] CGSize [] translations, nint count);
		public void GetVerticalTranslationsForGlyphs (CGGlyph [] glyphs, CGSize [] translations, nint count)
		{
			AssertCount (count);
			AssertLength ("glyphs", glyphs, count);
			AssertLength ("translations", translations, count);

			CTFontGetVerticalTranslationsForGlyphs (Handle, glyphs, translations, count);
		}

		/// <param name="glyph">The glyph.</param>
		/// <summary>Get Path For Glyph.</summary>
		public CGPath? GetPathForGlyph (CGGlyph glyph)
		{
			IntPtr h;
			unsafe {
				h = CTFontCreatePathForGlyph (Handle, glyph, null);
			}
			if (h == IntPtr.Zero)
				return null;
			return new CGPath (h, true);
		}

		[DllImport (Constants.CoreTextLibrary)]
		unsafe static extern IntPtr CTFontCreatePathForGlyph (IntPtr font, CGGlyph glyph, CGAffineTransform* transform);
		/// <param name="glyph">The glyph.</param>
		/// <param name="transform">The transform.</param>
		/// <summary>Get Path For Glyph.</summary>
		public CGPath? GetPathForGlyph (CGGlyph glyph, ref CGAffineTransform transform)
		{
			IntPtr h;
			unsafe {
				fixed (CGAffineTransform* transformPtr = &transform) {
					h = CTFontCreatePathForGlyph (Handle, glyph, transformPtr);
				}
			}
			if (h == IntPtr.Zero)
				return null;
			return new CGPath (h, true);
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern void CTFontDrawGlyphs (/* CTFontRef __nonnull */ IntPtr font,
			[In] CGGlyph [] glyphs, [In] CGPoint [] positions, nint count,
			/* CGContextRef __nonnull */ IntPtr context);

		/// <param name="context">The context.</param>
		/// <param name="glyphs">The glyphs.</param>
		/// <param name="positions">The positions.</param>
		/// <summary>Draw Glyphs.</summary>
		public void DrawGlyphs (CGContext context, CGGlyph [] glyphs, CGPoint [] positions)
		{
			if (context is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (context));
			if (glyphs is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (glyphs));
			if (positions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (positions));
			int gl = glyphs.Length;
			if (gl != positions.Length)
				throw new ArgumentException ("array sizes fo context and glyphs differ");
			CTFontDrawGlyphs (Handle, glyphs, positions, gl, context.Handle);
			GC.KeepAlive (context);
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern unsafe nint CTFontGetLigatureCaretPositions (IntPtr handle, CGGlyph glyph, [Out] nfloat* positions, nint max);

		public nint GetLigatureCaretPositions (CGGlyph glyph, nfloat [] positions)
		{
			if (positions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (positions));
			unsafe {
				fixed (nfloat* positionsPtr = positions) {
					return CTFontGetLigatureCaretPositions (Handle, glyph, positionsPtr, positions.Length);
				}
			}
		}
		#endregion

		#region Font Variations
		[DllImport (Constants.CoreTextLibrary)]
		static extern IntPtr CTFontCopyVariationAxes (IntPtr font);
		/// <summary>Get Variation Axes.</summary>
		public CTFontVariationAxes [] GetVariationAxes ()
		{
			var cfArrayRef = CTFontCopyVariationAxes (Handle);
			return NSArray.NonNullDictionaryArrayFromHandleDropNullElements (cfArrayRef, d => new CTFontVariationAxes (d), true);
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern IntPtr CTFontCopyVariation (IntPtr font);
		/// <summary>Get Variation.</summary>
		public CTFontVariation? GetVariation ()
		{
			var cfDictionaryRef = CTFontCopyVariation (Handle);
			if (cfDictionaryRef == IntPtr.Zero)
				return null;
			return new CTFontVariation (Runtime.GetNSObject<NSDictionary> (cfDictionaryRef)!);
		}
		#endregion

		#region Font Features
		[DllImport (Constants.CoreTextLibrary)]
		static extern /* CFArrayRef __nullable */ IntPtr CTFontCopyFeatures (
			/* CTFontRef __nonnull */ IntPtr font);

		// Always returns only default features
		/// <summary>Get Features.</summary>
		public CTFontFeatures [] GetFeatures ()
		{
			var cfArrayRef = CTFontCopyFeatures (Handle);
			return NSArray.NonNullDictionaryArrayFromHandleDropNullElements (cfArrayRef,
					d => new CTFontFeatures (d), true);
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern /* CFArrayRef __nullable */ IntPtr CTFontCopyFeatureSettings (
			/* CTFontRef __nonnull */ IntPtr font);

		/// <summary>Get Feature Settings.</summary>
		public CTFontFeatureSettings [] GetFeatureSettings ()
		{
			var cfArrayRef = CTFontCopyFeatureSettings (Handle);
			return NSArray.NonNullDictionaryArrayFromHandleDropNullElements (cfArrayRef,
					d => new CTFontFeatureSettings (d), true);
		}
		#endregion

		#region Font Conversion
		[DllImport (Constants.CoreTextLibrary)]
		static extern IntPtr CTFontCopyGraphicsFont (IntPtr font, IntPtr attributes);
		/// <param name="attributes">The attributes.</param>
		/// <summary>To C G Font.</summary>
		public CGFont? ToCGFont (CTFontDescriptor? attributes)
		{
			var h = CTFontCopyGraphicsFont (Handle, attributes.GetHandle ());
			GC.KeepAlive (attributes);
			if (h == IntPtr.Zero)
				return null;
			return new CGFont (h, true);
		}

		/// <summary>To C G Font.</summary>
		public CGFont? ToCGFont ()
		{
			return ToCGFont (null);
		}
		#endregion

		#region Font Tables
		[DllImport (Constants.CoreTextLibrary)]
		static extern /* CFArrayRef __nullable */ IntPtr CTFontCopyAvailableTables (
			/* CTFontRef __nonnull */ IntPtr font, CTFontTableOptions options);

		/// <param name="options">The options.</param>
		/// <summary>Get Available Tables.</summary>
		public CTFontTable [] GetAvailableTables (CTFontTableOptions options)
		{
			var cfArrayRef = CTFontCopyAvailableTables (Handle, options);
			return NSArray.NonNullArrayFromHandle (cfArrayRef, v => {
				return (CTFontTable) (uint) (IntPtr) v;
			}, true);
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern IntPtr CTFontCopyTable (IntPtr font, CTFontTable table, CTFontTableOptions options);
		/// <param name="table">The table.</param>
		/// <param name="options">The options.</param>
		/// <summary>Get Font Table Data.</summary>
		public NSData? GetFontTableData (CTFontTable table, CTFontTableOptions options)
		{
			var cfDataRef = CTFontCopyTable (Handle, table, options);
			return Runtime.GetNSObject<NSData> (cfDataRef, true);
		}
		#endregion

		#region
		[DllImport (Constants.CoreTextLibrary)]
		extern static /* CFArrayRef __nullable */ IntPtr CTFontCopyDefaultCascadeListForLanguages (
			/* CTFontRef __nonnull */ IntPtr font, /* CFArrayRef __nullable */ IntPtr languagePrefList);

		/// <param name="languages">The languages.</param>
		/// <summary>Get Default Cascade List.</summary>
		public CTFontDescriptor? []? GetDefaultCascadeList (string []? languages)
		{
			using (var arr = NSArray.FromNullableStrings (languages)) {
				var h = CTFontCopyDefaultCascadeListForLanguages (Handle, arr.GetHandle ());
				return CFArray.ArrayFromHandleFunc<CTFontDescriptor> (h,
					(handle) => new CTFontDescriptor (handle, false), true);
			}
		}

		#endregion

		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[DllImport (Constants.CoreTextLibrary)]
		extern static /* CGRect */ CGRect CTFontGetTypographicBoundsForAdaptiveImageProvider (
			/* CTFontRef */ IntPtr font,
			/* id<CTAdaptiveImageProviding> __Nullable */ IntPtr provider);

		/// <summary>Computes metrics that clients performing their own typesetting of an adaptive image glyph need.</summary>
		/// <returns>The typographic bounds in points expressed as a rectangle, where the rectangle's Width property corresponds to the advance width, the rectangle's Bottom property corresponds to the ascent (above the baseline), and Top property corresponds to the descent (below the baseline).</returns>
		/// <param name="provider">The adaptive image provider used during the computation. If null, then default results will be returned, on the assumption that an image is not yet available.</param>
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("tvos18.0")]
		public CGRect GetTypographicBoundsForAdaptiveImageProvider (ICTAdaptiveImageProviding? provider)
		{
			CGRect result = CTFontGetTypographicBoundsForAdaptiveImageProvider (Handle, provider.GetHandle ());
			GC.KeepAlive (provider);
			return result;
		}

		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[DllImport (Constants.CoreTextLibrary)]
		extern static void CTFontDrawImageFromAdaptiveImageProviderAtPoint (
			/* CTFontRef */ IntPtr font,
			/* id<CTAdaptiveImageProviding> __Nullable */ IntPtr provider,
			/* CGPoint */ CGPoint point,
			/* CGContexRef */ IntPtr context);

		/// <summary>Draws the image for an adaptive image glyph at the given point.</summary>
		/// <param name="provider">The adaptive image provider used during the rendering.</param>
		/// <param name="point">The adaptive image glyph is rendered relative to this point.</param>
		/// <param name="context">The <see cref="CoreGraphics.CGBitmapContext" /> where the adaptive image glyph is drawn.</param>
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("tvos18.0")]
		public void DrawImage (ICTAdaptiveImageProviding provider, CGPoint point, CGContext context)
		{
			CTFontDrawImageFromAdaptiveImageProviderAtPoint (Handle, provider.GetNonNullHandle (nameof (provider)), point, context.GetNonNullHandle (nameof (context)));
			GC.KeepAlive (provider);
			GC.KeepAlive (context);
		}

		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[DllImport (Constants.CoreTextLibrary)]
		extern static byte CTFontHasTable (
			/* CTFontRef */ IntPtr font,
			/* CTFontTableTag */ CTFontTable tag);

		/// <summary>Checks whether a table is present in a font.</summary>
		/// <param name="tag">The table identifier to check for.</param>
		/// <returns>Whether the table is present in the font or not.</returns>
		/// <remarks>The check behaves as if <see cref="CTFontTableOptions.None" /> was specified.</remarks>
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		public bool HasTable (CTFontTable tag)
		{
			return CTFontHasTable (GetCheckedHandle (), tag) != 0;
		}


		/// <summary>To String.</summary>
		public override string? ToString ()
		{
			return FullName;
		}

		/// <summary>Type identifier for the CoreText.CTFont type.</summary>
		///         <remarks>
		///           <para>The returned token is the CoreFoundation type identifier (CFType) that has been assigned to this class.</para>
		///           <para>This can be used to determine type identity between different CoreFoundation objects.</para>
		///           <para>You can retrieve the type of a CoreFoundation object by invoking the <see cref="CoreFoundation.CFType.GetTypeID(System.IntPtr)" /> on the native handle of the object</para>
		///           <example>
		///             <code lang="csharp lang-csharp"><![CDATA[bool isCTFont = (CFType.GetTypeID (foo.Handle) == CTFont.GetTypeID ());]]></code>
		///           </example>
		///         </remarks>
		[DllImport (Constants.CoreTextLibrary, EntryPoint = "CTFontGetTypeID")]
		public extern static nint GetTypeID ();
	}
}
