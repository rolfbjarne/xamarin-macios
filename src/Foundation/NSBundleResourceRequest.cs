using System.Reflection;
using System.Collections;

#if !MONOMAC

namespace Foundation {
	public partial class NSBundleResourceRequest : NSObject {
		static NSSet<NSString> MakeSetFromTags (string [] tags)
		{
			var x = new NSString [tags.Length];
			for (int i = 0; i < tags.Length; i++)
				x [i] = new NSString (tags [i]);
			return new NSSet<NSString> (x);
		}

		static NSSet<NSString> MakeSetFromTags (NSString [] tags)
		{
			return new NSSet<NSString> (tags);
		}

		/// <param name="tags">The tags.</param>
		///         <summary>Creates a new <see cref="NSBundleResourceRequest" /> instance.</summary>
		public NSBundleResourceRequest (params string [] tags) : this (MakeSetFromTags (tags)) { }
		/// <param name="bundle">The bundle.</param>
		///         <param name="tags">The tags.</param>
		///         <summary>Creates a new <see cref="NSBundleResourceRequest" /> instance.</summary>
		public NSBundleResourceRequest (NSBundle bundle, params string [] tags) : this (MakeSetFromTags (tags), bundle) { }

		/// <param name="tags">The tags.</param>
		///         <summary>Creates a new <see cref="NSBundleResourceRequest" /> instance.</summary>
		public NSBundleResourceRequest (params NSString [] tags) : this (MakeSetFromTags (tags)) { }
		/// <param name="bundle">The bundle.</param>
		///         <param name="tags">The tags.</param>
		///         <summary>Creates a new <see cref="NSBundleResourceRequest" /> instance.</summary>
		public NSBundleResourceRequest (NSBundle bundle, params NSString [] tags) : this (MakeSetFromTags (tags), bundle) { }

	}
}

#endif
