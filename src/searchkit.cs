//
// searchkit.cs: Definitions for AppKit
//

namespace SearchKit {
	[Static]
	interface SKTextAnalysisKeys {
		/// <summary>Gets the minimum term length key.</summary>
		/// <value>The key string.</value>
		[Field ("kSKMinTermLength")]
		NSString MinTermLengthKey { get; }

		/// <summary>Gets the stop words key.</summary>
		/// <value>The key string.</value>
		[Field ("kSKStopWords")]
		NSString StopWordsKey { get; }

		/// <summary>Gets the substitutions key.</summary>
		/// <value>The key string.</value>
		[Field ("kSKSubstitutions")]
		NSString SubstitutionsKey { get; }

		/// <summary>Gets the maximum terms key.</summary>
		/// <value>The key string.</value>
		[Field ("kSKMaximumTerms")]
		NSString MaximumTermsKey { get; }

		/// <summary>Gets the proximity indexing key.</summary>
		/// <value>The key string.</value>
		[Field ("kSKProximityIndexing")]
		NSString ProximityIndexingKey { get; }

		/// <summary>Gets the term characters key.</summary>
		/// <value>The key string.</value>
		[Field ("kSKTermChars")]
		NSString TermCharsKey { get; }

		/// <summary>Gets the start term characters key.</summary>
		/// <value>The key string.</value>
		[Field ("kSKStartTermChars")]
		NSString StartTermCharsKey { get; }

		/// <summary>Gets the end term characters key.</summary>
		/// <value>The key string.</value>
		[Field ("kSKEndTermChars")]
		NSString EndTermCharsKey { get; }
	}

	[StrongDictionary ("SKTextAnalysisKeys")]
	interface SKTextAnalysis {
		/// <summary>Gets or sets the minimum term length.</summary>
		/// <value>The minimum number of characters for a term.</value>
		int MinTermLength { get; set; }
		/// <summary>Gets or sets the stop words.</summary>
		/// <value>A set of words to exclude from indexing.</value>
		NSSet StopWords { get; set; }
		/// <summary>Gets or sets the substitutions dictionary.</summary>
		/// <value>A dictionary of term substitutions.</value>
		NSDictionary Substitutions { get; set; }
		/// <summary>Gets or sets the maximum number of terms.</summary>
		/// <value>The maximum number of terms.</value>
		NSNumber MaximumTerms { get; set; }
		/// <summary>Gets or sets whether proximity indexing is enabled.</summary>
		/// <value><see langword="true" /> if proximity indexing is enabled; otherwise, <see langword="false" />.</value>
		bool ProximityIndexing { get; set; }
		/// <summary>Gets or sets the characters allowed in terms.</summary>
		/// <value>The term characters string.</value>
		string TermChars { get; set; }
		/// <summary>Gets or sets the characters allowed at the start of terms.</summary>
		/// <value>The start term characters string.</value>
		string StartTermChars { get; set; }
		/// <summary>Gets or sets the characters allowed at the end of terms.</summary>
		/// <value>The end term characters string.</value>
		string EndTermChars { get; set; }
	}
}
