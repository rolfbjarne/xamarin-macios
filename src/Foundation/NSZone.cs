// Copyright 2013 Xamarin Inc. All rights reserved

using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Foundation {

	// Helper to (mostly) support NS[Mutable]Copying protocols
	public class NSZone : DisposableObject {
		[DllImport (Constants.FoundationLibrary)]
		static extern /* NSZone* */ IntPtr NSDefaultMallocZone ();

		[DllImport (Constants.FoundationLibrary)]
		static extern IntPtr /* NSString* */ NSZoneName (/* NSZone* */ IntPtr zone);

		[DllImport (Constants.FoundationLibrary)]
		static extern void NSSetZoneName (/* NSZone* */ IntPtr zone, /* NSString* */ IntPtr name);

#if !NET
		public NSZone (IntPtr handle)
			: base (handle, false)
		{
		}
#endif

		[Preserve (Conditional = true)]
#if NET
		internal NSZone (IntPtr handle, bool owns)
#else
		public NSZone (IntPtr handle, bool owns)
#endif
			: base (handle, owns)
		{
		}

		// NSZone is just an opaque pointer without reference counting, so there's nothing to dispose

#if !COREBUILD
		public string Name {
			get {
				return new NSString (NSZoneName (Handle)).ToString ();
			}
			set {
				using (var ns = new NSString (value))
					NSSetZoneName (Handle, ns.Handle);
			}
		}

		// note: Copy(NSZone) and MutableCopy(NSZone) with a nil pointer == default
		public static readonly NSZone Default = new NSZone (NSDefaultMallocZone (), false);
#endif
	}
}
