//
// Extensions.cs: C#isms for JavaScriptCore
//
// Authors:
//   Aaron Bockover (abock@xamarin.com)
//
// Copyright 2013 Xamarin, Inc.

#nullable enable

namespace JavaScriptCore {

	public partial class JSContext {

		public JSValue this [NSObject key] {
			get { return _GetObject (key); }
			set { _SetObject (value, key); }
		}
	}

	public partial class JSValue {

		/// <summary>Returns a string representation of the value of the current instance.</summary>
		///         <returns>
		///         </returns>
		///         <remarks>
		///         </remarks>
		public override string ToString ()
		{
			return _ToString ();
		}

		/// <param name="value">The value to set.</param>
		///         <param name="context">The context to use.</param>
		/// <summary>Creates a JavaScript string from the provided string.</summary>
		/// <returns>A new <see cref="JSValue" /> containing the string.</returns>
		static public JSValue From (string value, JSContext context)
		{
			using (var str = new NSString (value)) {
				return From ((NSObject) str, context);
			}
		}

		/// <param name="index">The zero-based index.</param>
		/// <summary>Gets or sets the item that is indexed by the provided <paramref name="index" />.</summary>
		public JSValue this [nuint index] {
			get { return _ObjectAtIndexedSubscript (index); }
			set { _SetObject (value, index); }
		}

		/// <param name="key">The key to use.</param>
		/// <summary>Gets or sets the item that is indexed by the provided <paramref name="key" />.</summary>
		public JSValue this [NSObject key] {
			get { return _ObjectForKeyedSubscript (key); }
			set { _SetObject (value, key); }
		}
	}
}
