#if !__MACCATALYST__
using CoreText;

#nullable enable

namespace AppKit {
	public partial class NSTextStorage {
		/// <param name="str">The string content.</param>
		/// <param name="attributes">The text attributes.</param>
		/// <summary>Creates a new text storage with the specified string and attributes.</summary>
		public NSTextStorage (string str, NSDictionary attributes) : base (str, attributes)
		{
		}

		/// <param name="other">The attributed string to copy.</param>
		/// <summary>Creates a new text storage from the specified attributed string.</summary>
		public NSTextStorage (NSAttributedString other) : base (other)
		{
		}

		/// <param name="str">The string content.</param>
		/// <param name="attributes">The Core Text string attributes.</param>
		/// <summary>Creates a new text storage with the specified string and Core Text attributes.</summary>
		public NSTextStorage (string str, CTStringAttributes attributes) : base (str, attributes)
		{
		}
	}
}
#endif // !__MACCATALYST__
