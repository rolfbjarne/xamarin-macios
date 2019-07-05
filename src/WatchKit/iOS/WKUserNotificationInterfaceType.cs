#if __IOS__
using System;
using System.ComponentModel;

using ObjCRuntime;

namespace WatchKit {
	[Introduced (PlatformName.iOS, 8,2, PlatformArchitecture.All)]
	[Unavailable (PlatformName.iOS, PlatformArchitecture.All)]
	[Obsolete ("The WatchKit framework has been removed from iOS", true)]
	[EditorBrowsable (EditorBrowsableState.Never)]
	public enum WKUserNotificationInterfaceType : long {
		Default = 0,
		Custom = 1,
	}
}
#endif // __IOS__
