// 
// CTFontCollection.cs: Implements the managed CTFontCollection
//
// Authors: Mono Team
//          Rolf Bjarne Kvinge <rolf@xamarin.com>
//     
// Copyright 2010 Novell, Inc
// Copyright 2014 Xamarin Inc (http://www.xamarin.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

#nullable enable

using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

using ObjCRuntime;
using Foundation;
using CoreFoundation;
using CoreGraphics;

#if NET
using CFIndex = System.IntPtr;
#else
using CFIndex = System.nint;
#endif

namespace CoreText {

	public static class CTFontCollectionOptionKey {
		public static readonly NSString RemoveDuplicates;

		static CTFontCollectionOptionKey ()
		{
			RemoveDuplicates = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTFontCollectionRemoveDuplicatesOption");
		}
	}

	public class CTFontCollectionOptions {

		public CTFontCollectionOptions ()
			: this (new NSMutableDictionary ())
		{
		}

		public CTFontCollectionOptions (NSDictionary dictionary)
		{
			if (dictionary is null)
				throw new ArgumentNullException (nameof (dictionary));
			Dictionary = dictionary;
		}

		public NSDictionary Dictionary {get; private set;}

		// The docs (and headers) only imply that this is a numeric value ('set to non-zero to ...')
		// No mention of the expected type (int? NSNumber?)
		public bool RemoveDuplicates {
			get {
				var v = Adapter.GetInt32Value (Dictionary, CTFontCollectionOptionKey.RemoveDuplicates);
				return v.HasValue ? v.Value != 0 : false;
			}
			set {
				var v = value ? (int?) 1 : null;
				Adapter.SetValue (Dictionary, CTFontCollectionOptionKey.RemoveDuplicates, v);
			}
		}
	}

	internal static class CTFontCollectionOptionsExtensions {
		public static IntPtr GetHandle (this CTFontCollectionOptions @self)
		{
			if (@self is null)
				return IntPtr.Zero;
			return self.Dictionary.GetHandle ();
		}
	}

	public class CTFontCollection : NativeObject {
		internal CTFontCollection (IntPtr handle, bool owns)
			: base (ConstructorError.VerifyNonZero (handle, nameof (handle)), owns)
		{
		}

#region Collection Creation
		[DllImport (Constants.CoreTextLibrary)]
		static extern IntPtr CTFontCollectionCreateFromAvailableFonts (IntPtr options);
		public CTFontCollection (CTFontCollectionOptions options)
			: base (CTFontCollectionCreateFromAvailableFonts (options == null ? IntPtr.Zero : options.Dictionary.Handle), true, true)
		{
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern IntPtr CTFontCollectionCreateWithFontDescriptors (IntPtr queryDescriptors, IntPtr options);
		static IntPtr Create (CTFontDescriptor [] queryDescriptors, CTFontCollectionOptions options)
		{
			using var descriptors = queryDescriptors == null ? null : CFArray.FromNativeObjects (queryDescriptors);
			return CTFontCollectionCreateWithFontDescriptors (descriptors.GetHandle (), options.GetHandle ());
		}
		public CTFontCollection (CTFontDescriptor[] queryDescriptors, CTFontCollectionOptions options)
			: base (Create (queryDescriptors, options), true, true)
		{
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern IntPtr CTFontCollectionCreateCopyWithFontDescriptors (IntPtr original, IntPtr queryDescriptors, IntPtr options);
		public CTFontCollection? WithFontDescriptors (CTFontDescriptor[] queryDescriptors, CTFontCollectionOptions options)
		{
			using var descriptors = queryDescriptors == null ? null : CFArray.FromNativeObjects (queryDescriptors);
			var	h = CTFontCollectionCreateCopyWithFontDescriptors (Handle, descriptors.GetHandle (), options.GetHandle ());
			if (h == IntPtr.Zero)
				return null;
			return new CTFontCollection (h, true);
		}
#endregion

#region Retrieving Matching Descriptors
		[DllImport (Constants.CoreTextLibrary)]
		static extern IntPtr CTFontCollectionCreateMatchingFontDescriptors (IntPtr collection);
		public CTFontDescriptor?[]? GetMatchingFontDescriptors ()
		{
			var cfArrayRef = CTFontCollectionCreateMatchingFontDescriptors (Handle);
			if (cfArrayRef == IntPtr.Zero)
				return Array.Empty <CTFontDescriptor> ();
			var matches = NSArray.ArrayFromHandle (cfArrayRef,
					fd => new CTFontDescriptor (fd, false));
			CFObject.CFRelease (cfArrayRef);
			return matches;
		}

#if !NET
		[iOS (12,0), TV (12,0), Watch (5,0)]
#else
		[SupportedOSPlatform ("ios12.0")]
		[SupportedOSPlatform ("tvos12.0")]
#endif
		[DllImport (Constants.CoreTextLibrary)]
		static extern IntPtr CTFontCollectionCreateMatchingFontDescriptorsWithOptions (IntPtr collection, IntPtr options);

#if !NET
		[iOS (12,0), TV (12,0), Watch (5,0)]
#else
		[SupportedOSPlatform ("ios12.0")]
		[SupportedOSPlatform ("tvos12.0")]
#endif
		public CTFontDescriptor? []? GetMatchingFontDescriptors (CTFontCollectionOptions options)
		{
			var cfArrayRef = CTFontCollectionCreateMatchingFontDescriptorsWithOptions (Handle, options.GetHandle ());
			if (cfArrayRef == IntPtr.Zero)
				return Array.Empty <CTFontDescriptor> ();
			var matches = NSArray.ArrayFromHandle (cfArrayRef,
					fd => new CTFontDescriptor (fd, false));
			CFObject.CFRelease (cfArrayRef);
			return matches;
		}

		[DllImport (Constants.CoreTextLibrary)]
		static extern IntPtr CTFontCollectionCreateMatchingFontDescriptorsSortedWithCallback (
				IntPtr collection, CTFontCollectionSortDescriptorsCallback sortCallback, IntPtr refCon);

		delegate CFIndex CTFontCollectionSortDescriptorsCallback (IntPtr first, IntPtr second, IntPtr refCon);

		[MonoPInvokeCallback (typeof (CTFontCollectionSortDescriptorsCallback))]
		static CFIndex CompareDescriptors (IntPtr first, IntPtr second, IntPtr context)
		{
			GCHandle c = GCHandle.FromIntPtr (context);
			var comparer = c.Target as Comparison<CTFontDescriptor>;
			if (comparer is null)
				return default (CFIndex);
			var rv = comparer (new CTFontDescriptor (first, false), new CTFontDescriptor (second, false));
			return (CFIndex) rv;
		}

		public CTFontDescriptor?[]? GetMatchingFontDescriptors (Comparison<CTFontDescriptor> comparer)
		{
			GCHandle comparison = GCHandle.Alloc (comparer);
			try {
				var cfArrayRef = CTFontCollectionCreateMatchingFontDescriptorsSortedWithCallback (
						Handle, 
						new CTFontCollectionSortDescriptorsCallback (CompareDescriptors),
						GCHandle.ToIntPtr (comparison));
				if (cfArrayRef == IntPtr.Zero)
					return new CTFontDescriptor [0];
				var matches = NSArray.ArrayFromHandle (cfArrayRef,
						fd => new CTFontDescriptor (fd, false));
				CFObject.CFRelease (cfArrayRef);
				return matches;
			}
			finally {
				comparison.Free ();
			}
		}
#endregion
	}
}
