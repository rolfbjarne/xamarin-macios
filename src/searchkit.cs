//
// searchkit.cs: Definitions for AppKit
//

namespace SearchKit {
	[Static]
	interface SKTextAnalysisKeys {
		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		[Field ("kSKMinTermLength")]
		NSString MinTermLengthKey { get; }

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		[Field ("kSKStopWords")]
		NSString StopWordsKey { get; }

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		[Field ("kSKSubstitutions")]
		NSString SubstitutionsKey { get; }

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		[Field ("kSKMaximumTerms")]
		NSString MaximumTermsKey { get; }

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		[Field ("kSKProximityIndexing")]
		NSString ProximityIndexingKey { get; }

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		[Field ("kSKTermChars")]
		NSString TermCharsKey { get; }

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		[Field ("kSKStartTermChars")]
		NSString StartTermCharsKey { get; }

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
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
