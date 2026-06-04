#if !__MACCATALYST__
using System.Collections.Generic;

#nullable enable

namespace AppKit {

	public partial class NSDocument {
		/// <param name="document">The document.</param>
		/// <param name="didDuplicate">Whether the document was duplicated successfully.</param>
		/// <summary>A callback invoked when a document duplication operation completes.</summary>
		public delegate void DuplicateCallback (NSDocument document, bool didDuplicate);

		[Register ("__NSDocumentDuplicateCallback")]
		internal class Callback : NSObject {
			DuplicateCallback callback;

			public Callback (DuplicateCallback callback)
			{
				this.callback = callback;
				IsDirectBinding = false;
				DangerousRetain ();
			}

			[Export ("document:didDuplicate:contextInfo:")]
			void SelectorCallback (NSDocument source, bool didDuplicate, IntPtr contextInfo)
			{
				try {
					callback (source, didDuplicate);
				} finally {
					DangerousRelease ();
				}
			}
		}

		/// <param name="callback">The callback to invoke.</param>
		/// <summary>Duplicates the document and invokes the callback when done.</summary>
		public void DuplicateDocument (DuplicateCallback? callback)
		{
			if (callback is null) {
				_DuplicateDocument (null, null, IntPtr.Zero);
			} else {
				_DuplicateDocument (new Callback (callback), new Selector ("document:didDuplicate:contextInfo:"), IntPtr.Zero);
			}
		}
	}
}
#endif // !__MACCATALYST__
