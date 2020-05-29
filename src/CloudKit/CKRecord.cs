using ObjCRuntime;
using Foundation;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CloudKit
{
	public partial class CKRecord
	{
#if !MONOMAC
		public NSObject this[string key] {
			get { return _ObjectForKey (key); }
			set { _SetObject (value.Handle, key); }
		}
#endif
	}
}

