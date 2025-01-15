using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

using ObjCRuntime;

#nullable enable

namespace Foundation {
#if false // https://github.com/xamarin/xamarin-macios/issues/15577
#if !NET
	[iOS (13,0), TV (13,0)]
#else
	[SupportedOSPlatform ("macos12.0")]
#endif
	public partial class NSOrderedCollectionChange
	{

		public static NSOrderedCollectionChange ChangeWithObject (NSObject? anObject, NSCollectionChangeType type, nuint index)
			=> new NSOrderedCollectionChange (NSOrderedCollectionChange._ChangeWithObject (anObject.GetHandle (), type, index));

		public static NSOrderedCollectionChange ChangeWithObject (NSObject? anObject, NSCollectionChangeType type, nuint index, nuint associatedIndex)
			=> new NSOrderedCollectionChange (NSOrderedCollectionChange._ChangeWithObject (anObject.GetHandle (), type, index, associatedIndex));

		public NSObject? Object => Runtime.GetNSObject<NSObject> (_Object);
	}
#endif
}
