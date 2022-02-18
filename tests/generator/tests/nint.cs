using System;

using Foundation;
using ObjCRuntime;

namespace NS {
	[BaseType (typeof (NSObject))]
	interface MyObject {
		[Export ("something:")]
		nint Something (nint something);

		[Export ("someProperty")]
		nint SomeProperty { get; set; }
	}
}
