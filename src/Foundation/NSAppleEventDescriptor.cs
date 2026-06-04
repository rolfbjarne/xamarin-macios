//
// NSAppleEventDescriptor.cs
//
// Copyright 2015 Xamarin Inc

#if MONOMAC

using AppKit;

namespace Foundation {
	/// <summary>To be added.</summary>
	public enum NSAppleEventDescriptorType {
		/// <summary>Indicates record.</summary>
		Record,
		/// <summary>Indicates list.</summary>
		List,
	}

	public partial class NSAppleEventDescriptor {
		/// <param name="type">The type.</param>
		///         <summary>To be added.</summary>
		public NSAppleEventDescriptor (NSAppleEventDescriptorType type)
		{
			switch (type) {
			case NSAppleEventDescriptorType.List:
				InitializeHandle (_InitListDescriptor (), "listDescriptor");
				break;
			case NSAppleEventDescriptorType.Record:
				InitializeHandle (_InitRecordDescriptor (), "recordDescriptor");
				break;
			default:
				throw new ArgumentOutOfRangeException ("type");
			}
		}
	}
}

#endif // MONOMAC
