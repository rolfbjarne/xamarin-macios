
namespace Foundation {

#if !XAMCORE_5_0
	// Utility enum, ObjC uses NSString
	/// <summary>An enumeration of known document types. Used with the <see cref="Foundation.NSAttributedStringDocumentAttributes.DocumentType" /> property.</summary>
	public enum NSDocumentType {
		/// <summary>Indicates unknown.</summary>
		Unknown = -1,
		/// <summary>Indicates plain text.</summary>
		PlainText,
		/// <summary>Indicates RTF.</summary>
		RTF,
		/// <summary>Indicates RTFD.</summary>
		RTFD,
		/// <summary>Indicates HTML.</summary>
		HTML,
		/// <summary>Indicates mac simple text.</summary>
		[NoiOS, NoTV, NoMacCatalyst]
		MacSimpleText,
		/// <summary>Indicates doc format.</summary>
		[NoiOS, NoTV, NoMacCatalyst]
		DocFormat,
		/// <summary>Indicates word m l.</summary>
		[NoiOS, NoTV, NoMacCatalyst]
		WordML,
		/// <summary>Indicates office open xml.</summary>
		[NoiOS, NoTV, NoMacCatalyst]
		OfficeOpenXml,
		/// <summary>Indicates web archive.</summary>
		[NoiOS, NoTV, NoMacCatalyst]
		WebArchive,
		/// <summary>Indicates open document.</summary>
		[NoiOS, NoTV, NoMacCatalyst]
		OpenDocument,
	}
#endif // !XAMCORE_5_0

	// Utility enum, ObjC uses NSString
	/// <summary>An enumeration that specifies how a document is being viewed. Used with the <see cref="Foundation.NSAttributedStringDocumentAttributes.ViewMode" /> property.</summary>
	public enum NSDocumentViewMode {
		/// <summary>Indicates normal.</summary>
		Normal,
		/// <summary>Indicates page layout.</summary>
		PageLayout,

	}

	/// <summary>Run loop modes for <see cref="Foundation.NSRunLoop" />.</summary>
	public enum NSRunLoopMode {

		/// <summary>The default mode to handle input sources.   The most common run loop mode.</summary>
		[DefaultEnumValue]
		[Field ("NSDefaultRunLoopMode")]
		Default,

		/// <summary>Run loop mode constant used to run handlers in any of the declared “common” modes.</summary>
		[Field ("NSRunLoopCommonModes")]
		Common,

#if MONOMAC
		/// <summary>Indicates connection reply.</summary>
		[Field ("NSConnectionReplyMode")]
		ConnectionReply = 2,

		/// <summary>Indicates modal panel.</summary>
		[Field ("NSModalPanelRunLoopMode", "AppKit")]
		ModalPanel,

		/// <summary>Indicates event tracking.</summary>
		[Field ("NSEventTrackingRunLoopMode", "AppKit")]
		EventTracking,
#else
		// iOS-specific Enums start in 100 to avoid conflicting with future extensions to MonoMac
		/// <summary>The NSRunLoop mode used when tracking controls. Use this to receive timers and events during UI tracking.</summary>
		[Field ("UITrackingRunLoopMode", "UIKit")]
		UITracking = 100,
#endif
		// If it is not part of these enumerations
		/// <summary>Indicates other.</summary>
		[Field (null)]
		Other = 1000,
	}

	/// <summary>Enumerates download status values.</summary>
	[MacCatalyst (13, 1)]
	public enum NSItemDownloadingStatus {
		/// <summary>Indicates unknown.</summary>
		[Field (null)]
		Unknown = -1,

		/// <summary>Indicates current.</summary>
		[Field ("NSMetadataUbiquitousItemDownloadingStatusCurrent")]
		Current,

		/// <summary>Indicates downloaded.</summary>
		[Field ("NSMetadataUbiquitousItemDownloadingStatusDownloaded")]
		Downloaded,

		/// <summary>Indicates not downloaded.</summary>
		[Field ("NSMetadataUbiquitousItemDownloadingStatusNotDownloaded")]
		NotDownloaded,
	}

	[MacCatalyst (13, 1)]
	public enum NSStringTransform {
		/// <summary>Indicates latin to katakana.</summary>
		[Field ("NSStringTransformLatinToKatakana")]
		LatinToKatakana,

		/// <summary>Indicates latin to hiragana.</summary>
		[Field ("NSStringTransformLatinToHiragana")]
		LatinToHiragana,

		/// <summary>Indicates latin to hangul.</summary>
		[Field ("NSStringTransformLatinToHangul")]
		LatinToHangul,

		/// <summary>Indicates latin to arabic.</summary>
		[Field ("NSStringTransformLatinToArabic")]
		LatinToArabic,

		/// <summary>Indicates latin to hebrew.</summary>
		[Field ("NSStringTransformLatinToHebrew")]
		LatinToHebrew,

		/// <summary>Indicates latin to thai.</summary>
		[Field ("NSStringTransformLatinToThai")]
		LatinToThai,

		/// <summary>Indicates latin to cyrillic.</summary>
		[Field ("NSStringTransformLatinToCyrillic")]
		LatinToCyrillic,

		/// <summary>Indicates latin to greek.</summary>
		[Field ("NSStringTransformLatinToGreek")]
		LatinToGreek,

		/// <summary>Indicates to latin.</summary>
		[Field ("NSStringTransformToLatin")]
		ToLatin,

		/// <summary>Indicates mandarin to latin.</summary>
		[Field ("NSStringTransformMandarinToLatin")]
		MandarinToLatin,

		/// <summary>Indicates hiragana to katakana.</summary>
		[Field ("NSStringTransformHiraganaToKatakana")]
		HiraganaToKatakana,

		/// <summary>Indicates fullwidth to halfwidth.</summary>
		[Field ("NSStringTransformFullwidthToHalfwidth")]
		FullwidthToHalfwidth,

		/// <summary>Indicates to xml hex.</summary>
		[Field ("NSStringTransformToXMLHex")]
		ToXmlHex,

		/// <summary>Indicates to unicode name.</summary>
		[Field ("NSStringTransformToUnicodeName")]
		ToUnicodeName,

		/// <summary>Indicates strip combining marks.</summary>
		[Field ("NSStringTransformStripCombiningMarks")]
		StripCombiningMarks,

		/// <summary>Indicates strip diacritics.</summary>
		[Field ("NSStringTransformStripDiacritics")]
		StripDiacritics,
	}

	[NoTV, NoMac]
	[MacCatalyst (13, 1)]
	[Native]
	public enum NSUrlSessionMultipathServiceType : long {
		/// <summary>Indicates none.</summary>
		None = 0,
		/// <summary>Indicates handover.</summary>
		Handover = 1,
		/// <summary>Indicates interactive.</summary>
		Interactive = 2,
		/// <summary>Indicates aggregate.</summary>
		Aggregate = 3,
	}

	/// <summary>Enumerates classes of tags that are returned from a text classifier.</summary>
	public enum NSLinguisticTagScheme {
		/// <summary>Indicates that tokens will be tagged with information about whether they are words, whitespace, or punctuation.</summary>
		[Field ("NSLinguisticTagSchemeTokenType")]
		Token,

		/// <summary>Indicates that tokens will be returned for whether they are part of speech or whitespace, or their punctuation type if they are punctuation.</summary>
		[Field ("NSLinguisticTagSchemeLexicalClass")]
		LexicalClass,

		/// <summary>Indicates that tokens will be tagged as names of which they are APart.</summary>
		[Field ("NSLinguisticTagSchemeNameType")]
		Name,

		/// <summary>Indicates that tokens will be tagged those tags indicated by <see cref="Foundation.NSLinguisticTagScheme.LexicalClass" /> and <see cref="Foundation.NSLinguisticTagScheme.Name" />.</summary>
		[Field ("NSLinguisticTagSchemeNameTypeOrLexicalClass")]
		NameOrLexicalClass,

		/// <summary>Indicates that tokens will be tagged with their stem, if known.</summary>
		[Field ("NSLinguisticTagSchemeLemma")]
		Lemma,

		/// <summary>Indicates that tokens will be tagged with their language, if known.</summary>
		[Field ("NSLinguisticTagSchemeLanguage")]
		Language,

		/// <summary>Indicates that tokens will be tagged with the script in which they were written.</summary>
		[Field ("NSLinguisticTagSchemeScript")]
		Script,
	}

	/// <summary>Contains read-only static properties corresponding to the parts of speech recognized by a <see cref="Foundation.NSLinguisticTagger" />.</summary>
	/// <summary>Enumerates tag values for linguistic units.</summary>
	public enum NSLinguisticTag {
		[Field ("NSLinguisticTagWord")]
		Word,

		[Field ("NSLinguisticTagPunctuation")]
		Punctuation,

		[Field ("NSLinguisticTagWhitespace")]
		Whitespace,

		[Field ("NSLinguisticTagOther")]
		Other,

		[Field ("NSLinguisticTagNoun")]
		Noun,

		[Field ("NSLinguisticTagVerb")]
		Verb,

		[Field ("NSLinguisticTagAdjective")]
		Adjective,

		[Field ("NSLinguisticTagAdverb")]
		Adverb,

		[Field ("NSLinguisticTagPronoun")]
		Pronoun,

		[Field ("NSLinguisticTagDeterminer")]
		Determiner,

		[Field ("NSLinguisticTagParticle")]
		Particle,

		[Field ("NSLinguisticTagPreposition")]
		Preposition,

		[Field ("NSLinguisticTagNumber")]
		Number,

		[Field ("NSLinguisticTagConjunction")]
		Conjunction,

		[Field ("NSLinguisticTagInterjection")]
		Interjection,

		[Field ("NSLinguisticTagClassifier")]
		Classifier,

		[Field ("NSLinguisticTagIdiom")]
		Idiom,

		[Field ("NSLinguisticTagOtherWord")]
		OtherWord,

		[Field ("NSLinguisticTagSentenceTerminator")]
		Terminator,

		[Field ("NSLinguisticTagOpenQuote")]
		OpenQuote,

		[Field ("NSLinguisticTagCloseQuote")]
		CloseQuote,

		[Field ("NSLinguisticTagOpenParenthesis")]
		OpenParenthesis,

		[Field ("NSLinguisticTagCloseParenthesis")]
		CloseParenthesis,

		[Field ("NSLinguisticTagWordJoiner")]
		WordJoiner,

		[Field ("NSLinguisticTagDash")]
		Dash,

		[Field ("NSLinguisticTagOtherPunctuation")]
		OtherPunctuation,

		[Field ("NSLinguisticTagParagraphBreak")]
		ParagraphBreak,

		[Field ("NSLinguisticTagOtherWhitespace")]
		OtherWhitespace,

		[Field ("NSLinguisticTagPersonalName")]
		PersonalName,

		[Field ("NSLinguisticTagOrganizationName")]
		OrganizationName,

		[Field ("NSLinguisticTagPlaceName")]
		PlaceName,
	}

	[Flags]
	[Native]
	public enum NSStringEnumerationOptions : ulong {
		ByLines = 0x0,
		ByParagraphs = 0x1,
		ByComposedCharacterSequences = 0x2,
		ByWords = 0x3,
		BySentences = 0x4,
		ByCaretPositions = 0x5,
		ByDeletionClusters = 0x6,
		Reverse = 1uL << 8,
		SubstringNotRequired = 1uL << 9,
		Localized = 1uL << 10,
	}

	[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
	[Flags]
	[Native]
	public enum NSAttributedStringFormattingOptions : ulong {
		InsertArgumentAttributesWithoutMerging = 1uL << 0,
		ApplyReplacementIndexAttribute = 1uL << 1,
	}

	[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
	[Native]
	public enum NSAttributedStringMarkdownInterpretedSyntax : long {
		Full = 0,
		InlineOnly = 1,
		InlineOnlyPreservingWhitespace = 2,
	}

	[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
	[Native]
	public enum NSAttributedStringMarkdownParsingFailurePolicy : long {
		Error = 0,
		PartiallyParsedIfPossible = 1,
	}

	[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
	[Native]
	public enum NSGrammaticalGender : long {
		NotSet = 0,
		Feminine,
		Masculine,
		Neuter,
	}

	[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
	[Native]
	public enum NSGrammaticalNumber : long {
		NotSet = 0,
		Singular,
		Zero,
		Plural,
		PluralTwo,
		PluralFew,
		PluralMany,
	}

	[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
	[Native]
	public enum NSGrammaticalPartOfSpeech : long {
		NotSet = 0,
		Determiner,
		Pronoun,
		Letter,
		Adverb,
		Particle,
		Adjective,
		Adposition,
		Verb,
		Noun,
		Conjunction,
		Numeral,
		Interjection,
		Preposition,
		Abbreviation,
	}

	[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
	[Native]
	public enum NSInlinePresentationIntent : ulong {
		Emphasized = 1uL << 0,
		StronglyEmphasized = 1uL << 1,
		Code = 1uL << 2,
		Strikethrough = 1uL << 5,
		SoftBreak = 1uL << 6,
		LineBreak = 1uL << 7,
		InlineHTML = 1uL << 8,
		BlockHTML = 1uL << 9,
	}

	[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
	[Native]
	public enum NSPresentationIntentKind : long {
		Paragraph,
		Header,
		OrderedList,
		UnorderedList,
		ListItem,
		CodeBlock,
		BlockQuote,
		ThematicBreak,
		Table,
		TableHeaderRow,
		TableRow,
		TableCell,
	}

	[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
	[Native]
	public enum NSPresentationIntentTableColumnAlignment : long {
		Left,
		Center,
		Right,
	}

	[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
	[Native]
	public enum NSURLRequestAttribution : ulong {
		Developer = 0,
		User = 1,
	}
}
