//
// NotImplementedAttribute.cs
//
// Authors:
//   Alex Soto (alexsoto@microsoft.com)
//
// Copyright 2017 Xamarin Inc.
//

#nullable enable

namespace Foundation {
	//
	// This is designed to be applied to setter methods in
	// a base class `Foo' when a `MutableFoo' exists.
	//
	// This allows the Foo.set_XXX to exists but throw an exception
	// but derived classes would then override the property
	//
	/// <summary>To be added.</summary>
	[AttributeUsage (AttributeTargets.Method, AllowMultiple = false)]
	public class NotImplementedAttribute : Attribute {
		/// <summary>Creates a new <see cref="NotImplementedAttribute" /> instance.</summary>
		public NotImplementedAttribute () { }
		/// <param name="message">The message.</param>
		///         <summary>Creates a new <see cref="NotImplementedAttribute" /> instance.</summary>
		public NotImplementedAttribute (string message) { Message = message; }
		/// <summary>Gets or sets the message.</summary>
		public string? Message { get; set; }
	}
}
