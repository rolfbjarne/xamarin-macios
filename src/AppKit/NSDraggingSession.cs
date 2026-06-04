#if !__MACCATALYST__

using CoreGraphics;

#nullable enable

namespace AppKit {
	public partial class NSDraggingSession {
		public void EnumerateDraggingItems (NSDraggingItemEnumerationOptions enumOpts, NSView view, INSPasteboardReading [] classArray, NSDictionary searchOptions, NSDraggingEnumerator enumerator)
		{
			var nsa_classArray = NSArray.FromNSObjects (classArray);
			EnumerateDraggingItems (enumOpts, view, nsa_classArray.Handle, searchOptions, enumerator);
			nsa_classArray.Dispose ();
		}

		/// <param name="enumOpts">The enum opts.</param>
		///         <param name="view">The view.</param>
		///         <param name="classArray">The class array.</param>
		///         <param name="searchOptions">The search options.</param>
		///         <param name="enumerator">The enumerator.</param>
		///         <summary>To be added.</summary>
		public void EnumerateDraggingItems (NSDraggingItemEnumerationOptions enumOpts, NSView view, NSArray classArray, NSDictionary searchOptions, NSDraggingEnumerator enumerator)
		{
			EnumerateDraggingItems (enumOpts, view, classArray.Handle, searchOptions, enumerator);
			GC.KeepAlive (classArray);
		}
	}
}
#endif // !__MACCATALYST__
