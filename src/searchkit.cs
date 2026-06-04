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
		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		int MinTermLength { get; set; }
		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		NSSet StopWords { get; set; }
		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		NSDictionary Substitutions { get; set; }
		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		NSNumber MaximumTerms { get; set; }
		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		bool ProximityIndexing { get; set; }
		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		string TermChars { get; set; }
		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		string StartTermChars { get; set; }
		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		string EndTermChars { get; set; }
	}
}
