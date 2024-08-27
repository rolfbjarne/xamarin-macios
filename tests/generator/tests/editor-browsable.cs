using System;
using System.ComponentModel;

using Foundation;

namespace EditorBrowsable {
	[EditorBrowsable (EditorBrowsable.Never)]
	enum StrongEnum {
		[Field ("AField", "__Internal")]
		A,
	}

	[EditorBrowsable (EditorBrowsable.Never)]
	[BaseType (typeof (NSObject))]
	interface ObjCClass {}
}
