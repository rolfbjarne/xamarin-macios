#nullable enable

using System;
using System.Runtime.InteropServices;

using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit {
#if !__MACCATALYST__
#if !NET
	public partial class NSDraggingInfo {
		public void EnumerateDraggingItems (NSDraggingItemEnumerationOptions enumOpts, NSView view, NSPasteboardReading [] classArray, NSDictionary searchOptions, NSDraggingEnumerator enumerator)
		{
			var nsa_classArray = NSArray.FromNSObjects (classArray);
			EnumerateDraggingItems (enumOpts, view, nsa_classArray.Handle, searchOptions, enumerator);
			nsa_classArray.Dispose ();
		}

		public void EnumerateDraggingItems (NSDraggingItemEnumerationOptions enumOpts, NSView view, NSArray classArray, NSDictionary searchOptions, NSDraggingEnumerator enumerator)
		{
			EnumerateDraggingItems (enumOpts, view, classArray.Handle, searchOptions, enumerator);
		}
	}
#else
	public static partial class NSDraggingInfo_Extensions {
		public static void EnumerateDraggingItems (this INSDraggingInfo self, NSDraggingItemEnumerationOptions enumOpts, NSView view, NSPasteboardReading [] classArray, NSDictionary searchOptions, NSDraggingEnumerator enumerator)
		{
			using var nsa_classArray = NSArray.FromNSObjects (classArray);
			self.EnumerateDraggingItems (enumOpts, view, nsa_classArray.Handle, searchOptions, enumerator);
		}

		public static void EnumerateDraggingItems (this INSDraggingInfo self, NSDraggingItemEnumerationOptions enumOpts, NSView view, NSArray classArray, NSDictionary searchOptions, NSDraggingEnumerator enumerator)
		{
			self.EnumerateDraggingItems (enumOpts, view, classArray.Handle, searchOptions, enumerator);
		}
	}
#endif // !NET
#endif // !__MACCATALYST__
}
