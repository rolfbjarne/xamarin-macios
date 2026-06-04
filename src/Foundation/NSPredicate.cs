// Copyright 2014, Xamarin Inc. All rights reserved.

#if !COREBUILD

namespace Foundation {

	public partial class NSPredicate {

		/// <param name="predicateFormat">The predicate format.</param>
		///         <summary>Froms format.</summary>
		public static NSPredicate FromFormat (string predicateFormat)
		{
			return _FromFormat (predicateFormat, null);
		}

		// a single `nil` is a valid parameter, not to be confused with no parameters
		/// <param name="predicateFormat">The predicate format.</param>
		///         <param name="argument">The argument.</param>
		///         <summary>Froms format.</summary>
		public static NSPredicate FromFormat (string predicateFormat, NSObject argument)
		{
			return _FromFormat (predicateFormat, new NSObject [] { argument });
		}

		/// <param name="predicateFormat">The predicate format.</param>
		///         <param name="arguments">The arguments.</param>
		///         <summary>Froms format.</summary>
		public static NSPredicate FromFormat (string predicateFormat, params NSObject [] arguments)
		{
			return _FromFormat (predicateFormat, arguments);
		}
	}
}

#endif
