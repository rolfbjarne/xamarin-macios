#nullable enable

using System.Collections;
using System.Collections.Generic;

namespace Photos {
	public partial class PHFetchResult : IEnumerable<NSObject> {
		/// <param name="index">The zero-based index.</param>
		/// <summary>Returns the asset at <paramref name="index" />.</summary>
		public NSObject this [nint index] {
			get { return _ObjectAtIndexedSubscript (index); }
		}

		/// <summary>A <see cref="System.Collections.Generic.IEnumerator{T}" /> that can iterate over the assets in the <see cref="Photos.PHFetchResult" />.</summary>
		public IEnumerator<NSObject> GetEnumerator ()
		{
			nint len = Count;

			for (nint i = 0; i < len; i++)
				yield return this [i];
		}

		/// <summary>Returns an <see cref="System.Collections.IEnumerator" /> of the assets in the <see cref="Photos.PHFetchResult" />.</summary>
		IEnumerator IEnumerable.GetEnumerator ()
		{
			nint len = Count;

			for (nint i = 0; i < len; i++)
				yield return this [i];
		}

		/// <typeparam name="T">The type of objects to retrieve from the fetch result.</typeparam>
		///         <param name="indexes">The indexes.</param>
		///         <summary>Returns the objects at <paramref name="indexes" />, all of which must be type T.</summary>
		public T? [] ObjectsAt<T> (NSIndexSet indexes) where T : NSObject
		{
			var nsarr = _ObjectsAt (indexes);
			return NSArray.NonNullArrayFromHandle<T> (nsarr);
		}
	}
}
