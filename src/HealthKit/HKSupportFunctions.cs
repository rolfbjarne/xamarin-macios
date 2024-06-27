#nullable enable

using System;
using System.Runtime.InteropServices;

using Foundation;
using ObjCRuntime;

namespace HealthKit {
	/// <summary>This class contains static HealthKit functions that don't fit anywhere else.</summary>
#if NET
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("tvos18.0")]
#else
		[Watch (11, 0), TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
#endif
	public static class HKStateOfMindValence {
#if NET
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("tvos18.0")]
#else
		[Watch (11, 0), TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
#endif
		[DllImport (Constants.HealthKitLibrary)]
		static extern IntPtr HKStateOfMindValenceClassificationForValence (double valence);

		/// <summary>Gets the valence classification appropriate for a given valence value.</summary>
		/// <param name="valence">The valence value whose classification to get.</param>
		/// <returns>The valence classification, or null if the specified valence is outside of the supported range of valence values.</returns>
#if NET
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("tvos18.0")]
#else
		[Watch (11, 0), TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
#endif
		public static HKStateOfMindValenceClassification? GetClassification (double valence)
		{
			var nsnumber = Runtime.GetNSObject<NSNumber> (HKStateOfMindValenceClassificationForValence (valence), owns: false);
			if (nsnumber is null)
				return null;
			return (HKStateOfMindValenceClassification) (long) nsnumber.LongValue;
		}
	}
}
