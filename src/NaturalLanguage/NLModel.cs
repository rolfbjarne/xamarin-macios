#nullable enable

using System;
using System.Collections.Generic;

using Foundation;
using ObjCRuntime;

namespace NaturalLanguage {

	public partial class NLModel {

#if NET
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst15.0")]
#else
		[TV (14, 0)]
		[iOS (14, 0)]
		[MacCatalyst (14, 0)]
#endif
		public Dictionary<NLLanguage, double> GetPredictedLabelHypotheses (string @string, nuint maximumCount)
		{
			using (var hypo = GetNativePredictedLabelHypotheses (@string, maximumCount))
				return NLLanguageExtensions.Convert (hypo);
		}

#if NET
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst15.0")]
#else
		[TV (14, 0)]
		[iOS (14, 0)]
		[MacCatalyst (14, 0)]
#endif
		public Dictionary<NLLanguage, double> [] GetPredictedLabelHypotheses (string [] tokens, nuint maximumCount)
		{
			var hypos = GetNativePredictedLabelHypotheses (tokens, maximumCount);
			var result = new Dictionary<NLLanguage, double> [hypos.Length];
			for (int i = 0; i < result.Length; i++)
				result [i] = NLLanguageExtensions.Convert (hypos [i]);
			return result;
		}
	}
}
