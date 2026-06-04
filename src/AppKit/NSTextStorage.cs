#if !__MACCATALYST__
using CoreText;

#nullable enable

namespace AppKit {
	public partial class NSTextStorage {
		/// <param name="str">The str.</param>
		///         <param name="attributes">The attributes.</param>
		///         <summary>To be added.</summary>
		public NSTextStorage (string str, NSDictionary attributes) : base (str, attributes)
		{
		}

		/// <param name="other">The other.</param>
		///         <summary>To be added.</summary>
		public NSTextStorage (NSAttributedString other) : base (other)
		{
		}

		/// <param name="str">The str.</param>
		///         <param name="attributes">The attributes.</param>
		///         <summary>To be added.</summary>
		public NSTextStorage (string str, CTStringAttributes attributes) : base (str, attributes)
		{
		}
	}
}
#endif // !__MACCATALYST__
