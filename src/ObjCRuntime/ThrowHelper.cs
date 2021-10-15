using System;
using System.ComponentModel;
// the linker will remove the attributes
using System.Diagnostics.CodeAnalysis;

#nullable enable

namespace ObjCRuntime {

	[EditorBrowsable (EditorBrowsableState.Never)]
	public static class ThrowHelper {

		[DoesNotReturn]
		public static void ThrowArgumentException (string argumentName)
		{
			throw new ArgumentException (argumentName);
		}

		[DoesNotReturn]
		public static void ThrowArgumentException (string argumentName, string message)
		{
			throw new ArgumentException (message, argumentName);
		}

		[DoesNotReturn]
		public static void ThrowArgumentNullException (string argumentName)
		{
			throw new ArgumentNullException (argumentName);
		}

		[DoesNotReturn]
		public static void ThrowObjectDisposedException (object o)
		{
			throw new ObjectDisposedException (o.GetType ().ToString ());
		}

		public static T ThrowArgumentNullExceptionIfNeeded<T> (T? obj, string argumentName) where T: class
		{
			if (obj == null)
				throw new ArgumentException (argumentName);
			return obj;
		}
	}
}
