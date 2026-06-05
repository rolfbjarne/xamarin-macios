//
// coretext.cs: Definitions for CoreText
//
// Authors: 
//  Sebastien Pouliot  <sebastien@xamarin.com>
//
// Copyright 2014 Xamarin Inc.
//

using CoreGraphics;

namespace CoreText {

	interface CTFontDescriptor : INativeObject { }

	[Partial]
	interface CTFontManager {
		[Field ("kCTFontManagerRegisteredFontsChangedNotification")]
		NSString RegisteredFontsChangedNotification { get; }
	}

	/// <summary>A class whose static properties can be used as keys for the <see cref="Foundation.NSDictionary" /> used by <see cref="CoreText.CTFontFeatures" />.</summary>
	[Static]
	interface CTFontFeatureKey {
		/// <summary>The key for the font feature type identifier.</summary>
		[Field ("kCTFontFeatureTypeIdentifierKey")]
		NSString Identifier { get; }

		/// <summary>The key for the font feature type name.</summary>
		[Field ("kCTFontFeatureTypeNameKey")]
		NSString Name { get; }

		/// <summary>The key for the font feature type exclusive setting.</summary>
		[Field ("kCTFontFeatureTypeExclusiveKey")]
		NSString Exclusive { get; }

		/// <summary>The key for the font feature type selectors.</summary>
		[Field ("kCTFontFeatureTypeSelectorsKey")]
		NSString Selectors { get; }
	}

	/// <summary>A class whose static properties can be used as keys for the <see cref="Foundation.NSDictionary" /> used by <see cref="CoreText.CTFontFeatureSelectors" />.</summary>
	[Static]
	interface CTFontFeatureSelectorKey {
		/// <summary>The key for the font feature selector identifier.</summary>
		[Field ("kCTFontFeatureSelectorIdentifierKey")]
		NSString Identifier { get; }

		/// <summary>The key for the font feature selector name.</summary>
		[Field ("kCTFontFeatureSelectorNameKey")]
		NSString Name { get; }

		/// <summary>The key for the font feature selector default value.</summary>
		[Field ("kCTFontFeatureSelectorDefaultKey")]
		NSString Default { get; }

		/// <summary>The key for the font feature selector setting value.</summary>
		[Field ("kCTFontFeatureSelectorSettingKey")]
		NSString Setting { get; }

		[iOS (13, 0), TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kCTFontFeatureSampleTextKey")]
		NSString SampleText { get; }

		[iOS (13, 0), TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kCTFontFeatureTooltipTextKey")]
		NSString TooltipText { get; }
	}

	/// <summary>A class whose static properties can be used as keys for the <see cref="Foundation.NSDictionary" /> used by <see cref="CoreText.CTFontVariationAxes" />.</summary>
	[Static]
	interface CTFontVariationAxisKey {

		/// <summary>The key for the font variation axis identifier.</summary>
		[Field ("kCTFontVariationAxisIdentifierKey")]
		NSString Identifier { get; }

		/// <summary>The key for the font variation axis minimum value.</summary>
		[Field ("kCTFontVariationAxisMinimumValueKey")]
		NSString MinimumValue { get; }

		/// <summary>The key for the font variation axis maximum value.</summary>
		[Field ("kCTFontVariationAxisMaximumValueKey")]
		NSString MaximumValue { get; }

		/// <summary>The key for the font variation axis default value.</summary>
		[Field ("kCTFontVariationAxisDefaultValueKey")]
		NSString DefaultValue { get; }

		/// <summary>The key for the font variation axis name.</summary>
		[Field ("kCTFontVariationAxisNameKey")]
		NSString Name { get; }

		/// <summary>The key for whether the font variation axis is hidden.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCTFontVariationAxisHiddenKey")]
		NSString Hidden { get; }
	}

	/// <summary>A class whose static properties can be used as keys for the <see cref="Foundation.NSDictionary" /> used by <see cref="CoreText.CTTypesetterOptions" />.</summary>
	[Static]
	interface CTTypesetterOptionKey {

		/// <summary>Developers should not use this deprecated field. </summary>
		
		[Deprecated (PlatformName.iOS, 6, 0)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1)]
		[Deprecated (PlatformName.MacOSX, 10, 8)]
		[Deprecated (PlatformName.TvOS, 9, 0)]
		[Field ("kCTTypesetterOptionDisableBidiProcessing")]
		NSString DisableBidiProcessing { get; }

		/// <summary>The key for the forced embedding level option.</summary>
		
		[Field ("kCTTypesetterOptionForcedEmbeddingLevel")]
		NSString ForceEmbeddingLevel { get; }

		/// <summary>The key for allowing unbounded layout.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCTTypesetterOptionAllowUnboundedLayout")]
		NSString AllowUnboundedLayout { get; }
	}

	[Static]
	interface CTFontManagerErrorKeys {
		[Field ("kCTFontManagerErrorFontURLsKey")]
		NSString FontUrlsKey { get; }

		[NoTV, NoMac, iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kCTFontManagerErrorFontDescriptorsKey")]
		NSString FontDescriptorsKey { get; }

		[NoTV, NoMac, iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kCTFontManagerErrorFontAssetNameKey")]
		NSString FontAssetNameKey { get; }
	}

	[Internal]
	[Static]
	[Partial]
	interface CTBaselineClassID {
		[Field ("kCTBaselineClassRoman")]
		NSString Roman { get; }

		[Field ("kCTBaselineClassIdeographicCentered")]
		NSString IdeographicCentered { get; }

		[Field ("kCTBaselineClassIdeographicLow")]
		NSString IdeographicLow { get; }

		[Field ("kCTBaselineClassIdeographicHigh")]
		NSString IdeographicHigh { get; }

		[Field ("kCTBaselineClassHanging")]
		NSString Hanging { get; }

		[Field ("kCTBaselineClassMath")]
		NSString Math { get; }
	}

	[Internal]
	[Static]
	[Partial]
	interface CTBaselineFontID {
		[Field ("kCTBaselineReferenceFont")]
		NSString Reference { get; }

		[Field ("kCTBaselineOriginalFont")]
		NSString Original { get; }
	}

	/// <summary>A valid key for use with <see cref="CoreText.CTFontDescriptor" /> attribute properties.</summary>
	[Static]
	interface CTFontDescriptorAttributeKey {
		/// <summary>The key for the font URL attribute.</summary>
		
		[Field ("kCTFontURLAttribute")]
		NSString Url { get; }

		/// <summary>The key for the font name attribute.</summary>
		
		[Field ("kCTFontNameAttribute")]
		NSString Name { get; }

		/// <summary>The key for the font display name attribute.</summary>
		
		[Field ("kCTFontDisplayNameAttribute")]
		NSString DisplayName { get; }

		/// <summary>The key for the font family name attribute.</summary>
		
		[Field ("kCTFontFamilyNameAttribute")]
		NSString FamilyName { get; }

		/// <summary>The key for the font style name attribute.</summary>
		
		[Field ("kCTFontStyleNameAttribute")]
		NSString StyleName { get; }

		/// <summary>The key for the font traits attribute.</summary>
		
		[Field ("kCTFontTraitsAttribute")]
		NSString Traits { get; }

		/// <summary>The key for the font variation attribute.</summary>
		
		[Field ("kCTFontVariationAttribute")]
		NSString Variation { get; }

		/// <summary>The key for the font size attribute.</summary>
		
		[Field ("kCTFontSizeAttribute")]
		NSString Size { get; }

		/// <summary>The key for the font matrix attribute.</summary>
		
		[Field ("kCTFontMatrixAttribute")]
		NSString Matrix { get; }

		/// <summary>Augment the list of cascading fonts to try out when a font is needed.</summary>
		/// <remarks>
		///           <para>
		/// 	    Since fonts do not cover the entire Unicode space, you can
		/// 	    provide a list of fallback fonts that will be tried for
		/// 	    glyphs that are not available for a certain codepoint in
		/// 	    the main selected font.
		/// 
		/// 	  </para>
		///           <para>
		/// 	    By default the system has a built-in cascade list that the
		/// 	    system uses to satisfy the font.  By setting this property
		/// 	    is to set a list that is consulted before the system
		/// 	    cascade list is looked up.
		/// 
		/// 	  </para>
		///           <para>
		/// 	    If you want to prevent the system cascade list from being
		/// 	    consulted, you can use the special font name "LastResort",
		/// 	    this is a special font that contains glyphs for every
		/// 	    unicode code point.  You can learn more about it at the
		/// 	    Unicode web site:
		/// 	    https://unicode.org/policies/lastresortfont_eula.html
		/// 
		/// 	  </para>
		///         </remarks>
		[Field ("kCTFontCascadeListAttribute")]
		NSString CascadeList { get; }

		/// <summary>The key for the font character set attribute.</summary>
		
		[Field ("kCTFontCharacterSetAttribute")]
		NSString CharacterSet { get; }

		/// <summary>The key for the font languages attribute.</summary>
		
		[Field ("kCTFontLanguagesAttribute")]
		NSString Languages { get; }

		/// <summary>The key for the font baseline adjustment attribute.</summary>
		
		[Field ("kCTFontBaselineAdjustAttribute")]
		NSString BaselineAdjust { get; }

		/// <summary>The key for the font Macintosh encodings attribute.</summary>
		
		[Field ("kCTFontMacintoshEncodingsAttribute")]
		NSString MacintoshEncodings { get; }

		/// <summary>The key for the font features attribute.</summary>
		
		[Field ("kCTFontFeaturesAttribute")]
		NSString Features { get; }

		/// <summary>The key for the font feature settings attribute.</summary>
		
		[Field ("kCTFontFeatureSettingsAttribute")]
		NSString FeatureSettings { get; }

		/// <summary>The key for the font fixed advance attribute.</summary>
		
		[Field ("kCTFontFixedAdvanceAttribute")]
		NSString FixedAdvance { get; }

		/// <summary>The key for the font orientation attribute.</summary>
		
		[Field ("kCTFontOrientationAttribute")]
		NSString FontOrientation { get; }

		/// <summary>The key for the font format attribute.</summary>
		
		[Field ("kCTFontFormatAttribute")]
		NSString FontFormat { get; }

		/// <summary>The key for the font registration scope attribute.</summary>
		
		[Field ("kCTFontRegistrationScopeAttribute")]
		NSString RegistrationScope { get; }

		/// <summary>The key for the font priority attribute.</summary>
		
		[Field ("kCTFontPriorityAttribute")]
		NSString Priority { get; }

		/// <summary>The key for the font enabled attribute.</summary>
		
		[Field ("kCTFontEnabledAttribute")]
		NSString Enabled { get; }

		[iOS (13, 0), NoTV, MacCatalyst (13, 1), NoMac]
		[Field ("kCTFontRegistrationUserInfoAttribute")]
		NSString RegistrationUserInfo { get; }

		[iOS (26, 4), TV (26, 4), Mac (26, 4), MacCatalyst (26, 4)]
		[Field ("kCTFontDescriptorLanguageAttribute")]
		NSString Language { get; }
	}

	/// <summary>A class whose static properties can be used as keys for the <see cref="Foundation.NSDictionary" /> used by <see cref="CoreText.CTTextTabOptions" />.</summary>
	[Static]
	interface CTTextTabOptionKey {
		/// <summary>The key for the text tab column terminators.</summary>
		
		[Field ("kCTTabColumnTerminatorsAttributeName")]
		NSString ColumnTerminators { get; }
	}

	/// <summary>A class whose static properties can be used as keys for the <see cref="Foundation.NSDictionary" /> used by <see cref="CoreText.CTFrameAttributes" />.</summary>
	[Static]
	interface CTFrameAttributeKey {
		/// <summary>The key for the frame progression attribute.</summary>
		
		[Field ("kCTFrameProgressionAttributeName")]
		NSString Progression { get; }

		/// <summary>The key for the frame path fill rule attribute.</summary>
		
		[Field ("kCTFramePathFillRuleAttributeName")]
		NSString PathFillRule { get; }

		/// <summary>The key for the frame path width attribute.</summary>
		
		[Field ("kCTFramePathWidthAttributeName")]
		NSString PathWidth { get; }

		/// <summary>The key for the frame clipping paths attribute.</summary>
		
		[Field ("kCTFrameClippingPathsAttributeName")]
		NSString ClippingPaths { get; }

		/// <summary>The key for the frame path clipping path attribute.</summary>
		
		[Field ("kCTFramePathClippingPathAttributeName")]
		NSString PathClippingPath { get; }
	}

	/// <summary>A class whose static properties can be used as keys for the <see cref="Foundation.NSDictionary" /> used by <see cref="CoreText.CTFontTraits" />.</summary>
	[Static]
	interface CTFontTraitKey {
		/// <summary>The key for the font symbolic trait.</summary>
		
		[Field ("kCTFontSymbolicTrait")]
		NSString Symbolic { get; }

		/// <summary>The key for the font weight trait.</summary>
		
		[Field ("kCTFontWeightTrait")]
		NSString Weight { get; }

		/// <summary>The key for the font width trait.</summary>
		
		[Field ("kCTFontWidthTrait")]
		NSString Width { get; }

		/// <summary>The key for the font slant trait.</summary>
		
		[Field ("kCTFontSlantTrait")]
		NSString Slant { get; }
	}

	[Internal]
	[Static]
	[Partial]
	interface CTFontNameKeyId {
		[Field ("kCTFontCopyrightNameKey")]
		NSString Copyright { get; }

		[Field ("kCTFontFamilyNameKey")]
		NSString Family { get; }

		[Field ("kCTFontSubFamilyNameKey")]
		NSString SubFamily { get; }

		[Field ("kCTFontStyleNameKey")]
		NSString Style { get; }

		[Field ("kCTFontUniqueNameKey")]
		NSString Unique { get; }

		[Field ("kCTFontFullNameKey")]
		NSString Full { get; }

		[Field ("kCTFontVersionNameKey")]
		NSString Version { get; }

		[Field ("kCTFontPostScriptNameKey")]
		NSString PostScript { get; }

		[Field ("kCTFontTrademarkNameKey")]
		NSString Trademark { get; }

		[Field ("kCTFontManufacturerNameKey")]
		NSString Manufacturer { get; }

		[Field ("kCTFontDesignerNameKey")]
		NSString Designer { get; }

		[Field ("kCTFontDescriptionNameKey")]
		NSString Description { get; }

		[Field ("kCTFontVendorURLNameKey")]
		NSString VendorUrl { get; }

		[Field ("kCTFontDesignerURLNameKey")]
		NSString DesignerUrl { get; }

		[Field ("kCTFontLicenseNameKey")]
		NSString License { get; }

		[Field ("kCTFontLicenseURLNameKey")]
		NSString LicenseUrl { get; }

		[Field ("kCTFontSampleTextNameKey")]
		NSString SampleText { get; }

		[Field ("kCTFontPostScriptCIDNameKey")]
		NSString PostscriptCid { get; }
	}

	/// <summary>A class whose static property can be used as a key for the <see cref="Foundation.NSDictionary" /> used by <see cref="CoreText.CTFontCollectionOptions" />.</summary>
	[Static]
	interface CTFontCollectionOptionKey {
		/// <summary>The key for the remove duplicates option.</summary>
		
		[Field ("kCTFontCollectionRemoveDuplicatesOption")]
		NSString RemoveDuplicates { get; }
	}

	[Internal]
	[Static]
	interface CTFontDescriptorMatchingKeys {
		[Field ("kCTFontDescriptorMatchingSourceDescriptor")]
		NSString SourceDescriptorKey { get; }

		[Field ("kCTFontDescriptorMatchingDescriptors")]
		NSString DescriptorsKey { get; }

		[Field ("kCTFontDescriptorMatchingResult")]
		NSString ResultKey { get; }

		[Field ("kCTFontDescriptorMatchingPercentage")]
		NSString PercentageKey { get; }

		[Field ("kCTFontDescriptorMatchingCurrentAssetSize")]
		NSString CurrentAssetSizeKey { get; }

		[Field ("kCTFontDescriptorMatchingTotalDownloadedSize")]
		NSString TotalDownloadedSizeKey { get; }

		[Field ("kCTFontDescriptorMatchingTotalAssetSize")]
		NSString TotalAssetSizeKey { get; }

		[Field ("kCTFontDescriptorMatchingError")]
		NSString ErrorKey { get; }
	}

	[StrongDictionary ("CTFontDescriptorMatchingKeys")]
	interface CTFontDescriptorMatchingProgress {
		CTFontDescriptor SourceDescriptor { get; }
		CTFontDescriptor [] Descriptors { get; }
		CTFontDescriptor [] Result { get; }
		double Percentage { get; }
		long CurrentAssetSize { get; }
		long TotalDownloadedSize { get; }
		long TotalAssetSize { get; }
		NSError Error { get; }
	}

	/// <summary>A class whose static properties can be used as keys for the <see cref="Foundation.NSDictionary" /> used by <see cref="CoreText.CTStringAttributes" />.</summary>
	[Static]
	[Partial]
	interface CTStringAttributeKey {
		/// <summary>The key for the font attribute.</summary>
		
		[Field ("kCTFontAttributeName")]
		NSString Font { get; }

		/// <summary>The key for using foreground color from context.</summary>
		
		[Field ("kCTForegroundColorFromContextAttributeName")]
		NSString ForegroundColorFromContext { get; }

		/// <summary>The key for kerning adjustment.</summary>
		
		[Field ("kCTKernAttributeName")]
		NSString KerningAdjustment { get; }

		/// <summary>The key for ligature formation.</summary>
		
		[Field ("kCTLigatureAttributeName")]
		NSString LigatureFormation { get; }

		/// <summary>The key for the foreground color.</summary>
		
		[Field ("kCTForegroundColorAttributeName")]
		NSString ForegroundColor { get; }

		/// <summary>The key for the background color.</summary>
		
		[Field ("kCTBackgroundColorAttributeName")]
		NSString BackgroundColor { get; }

		/// <summary>The key for the paragraph style.</summary>
		
		[Field ("kCTParagraphStyleAttributeName")]
		NSString ParagraphStyle { get; }

		/// <summary>The key for the stroke width.</summary>
		
		[Field ("kCTStrokeWidthAttributeName")]
		NSString StrokeWidth { get; }

		/// <summary>The key for the stroke color.</summary>
		
		[Field ("kCTStrokeColorAttributeName")]
		NSString StrokeColor { get; }

		/// <summary>The key for the underline style.</summary>
		
		[Field ("kCTUnderlineStyleAttributeName")]
		NSString UnderlineStyle { get; }

		/// <summary>The key for the superscript attribute.</summary>
		
		[Field ("kCTSuperscriptAttributeName")]
		NSString Superscript { get; }

		/// <summary>The key for the underline color.</summary>
		
		[Field ("kCTUnderlineColorAttributeName")]
		NSString UnderlineColor { get; }

		/// <summary>The key for vertical forms.</summary>
		
		[Field ("kCTVerticalFormsAttributeName")]
		NSString VerticalForms { get; }

		/// <summary>The key for horizontal in vertical forms.</summary>
		
		[Field ("kCTHorizontalInVerticalFormsAttributeName")]
		NSString HorizontalInVerticalForms { get; }

		/// <summary>The key for glyph info.</summary>
		
		[Field ("kCTGlyphInfoAttributeName")]
		NSString GlyphInfo { get; }

		/// <summary>The key for character shape.</summary>
		
		[Field ("kCTCharacterShapeAttributeName")]
		NSString CharacterShape { get; }

		/// <summary>The key for the run delegate.</summary>
		
		[Field ("kCTRunDelegateAttributeName")]
		NSString RunDelegate { get; }

		[Field ("kCTBaselineOffsetAttributeName")]
		NSString BaselineOffset { get; }

		[Field ("kCTBaselineClassAttributeName")]
		NSString BaselineClass { get; }

		[Field ("kCTBaselineInfoAttributeName")]
		NSString BaselineInfo { get; }

		[Field ("kCTBaselineReferenceInfoAttributeName")]
		NSString BaselineReferenceInfo { get; }

		[Field ("kCTWritingDirectionAttributeName")]
		NSString WritingDirection { get; }

		[Field ("kCTRubyAnnotationAttributeName")]
		NSString RubyAnnotation { get; }

		[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Field ("kCTAdaptiveImageProviderAttributeName")]
		NSString AdaptiveImageProvider { get; }

		[TV (13, 0), iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kCTTrackingAttributeName")]
		NSString TrackingAttributeName { get; }
	}

	[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	[Protocol (BackwardsCompatibleCodeGeneration = false)]
	interface CTAdaptiveImageProviding {
		[Abstract]
		[Export ("imageForProposedSize:scaleFactor:imageOffset:imageSize:")]
		[return: NullAllowed]
		CGImage GetImage (CGSize proposedSize, nfloat scaleFactor, out CGPoint imageOffset, out CGSize imageSize);
	}
}
