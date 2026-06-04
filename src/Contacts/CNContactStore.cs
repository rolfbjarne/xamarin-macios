//
// CNContactStore.cs:
//
// Copyright 2015 Xamarin Inc. All rights reserved.
//

#nullable enable

namespace Contacts {
	public partial class CNContactStore {

		/// <typeparam name="T">The type of contact to retrieve.</typeparam>
		///         <param name="identifier">The identifier to use.</param>
		///         <param name="keys">The keys.</param>
		///         <param name="error">The error that occurred, or <see langword="null" /> if no error occurred.</param>
		///         <summary>Retrieves the <see cref="Contacts.CNContact" /> with the specified <paramref name="identifier" />.</summary>
		public CNContact? GetUnifiedContact<T> (string identifier, T [] keys, out NSError? error)
			where T : INSObjectProtocol, INSSecureCoding, INSCopying
		{
			using (var array = NSArray.From<T> (keys))
				return GetUnifiedContact (identifier, array, out error);
		}

		/// <typeparam name="T">The type of contacts to retrieve.</typeparam>
		///         <param name="predicate">The predicate.</param>
		///         <param name="keys">The keys.</param>
		///         <param name="error">The error that occurred, or <see langword="null" /> if no error occurred.</param>
		///         <summary>Retrieves the unified <see cref="Contacts.CNContact" /> objects, populated with data for <paramref name="keys" />, for which the <paramref name="predicate" /> returns <see langword="true" />.</summary>
		public CNContact []? GetUnifiedContacts<T> (NSPredicate predicate, T [] keys, out NSError? error)
			where T : INSObjectProtocol, INSSecureCoding, INSCopying
		{
			using (var array = NSArray.From<T> (keys))
				return GetUnifiedContacts (predicate, array, out error);
		}

#if MONOMAC
		/// <typeparam name="T">The type of the me contact to retrieve.</typeparam>
		///         <param name="keys">The keys.</param>
		///         <param name="error">The error that occurred, or <see langword="null" /> if no error occurred.</param>
		///         <summary>Gets unified me contact.</summary>
		public NSObject? GetUnifiedMeContact<T> (T [] keys, out NSError? error)
			where T : INSObjectProtocol, INSSecureCoding, INSCopying
		{
			using (var array = NSArray.From<T> (keys))
				return GetUnifiedMeContact (array, out error);
		}
#endif

	}
}
