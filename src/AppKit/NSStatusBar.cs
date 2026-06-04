//
// NSStatusBar.cs: Proprietary extensions to MonoMac NSStatusBar
//
// Authors:
//   Aaron Bockover (abock@xamarin.com)
//
// Copyright 2012 Xamarin Inc
//

#if !__MACCATALYST__

#nullable enable

namespace AppKit {
	/// <summary>To be added.</summary>
	public enum NSStatusItemLength {
		/// <summary>Indicates variable.</summary>
		Variable = -1,
		/// <summary>Indicates square.</summary>
		Square = -2,
	}

	public partial class NSStatusBar {
		/// <param name="length">The length.</param>
		///         <summary>To be added.</summary>
		///         <returns>To be added.</returns>
		public NSStatusItem CreateStatusItem (NSStatusItemLength length)
		{
			return CreateStatusItem ((float) length);
		}
	}
}
#endif // !__MACCATALYST__
