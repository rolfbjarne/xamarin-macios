#if __IOS__
using System;
using System.ComponentModel;

using ObjCRuntime;

namespace WatchKit {
	[Introduced (PlatformName.iOS, 8,2, PlatformArchitecture.All)]
	[Unavailable (PlatformName.iOS, PlatformArchitecture.All)]
	[Obsolete ("The WatchKit framework has been removed from iOS", true)]
	[EditorBrowsable (EditorBrowsableState.Never)]
	public enum WKTextInputMode : long {
		Plain = 0,
		AllowEmoji = 1,
		AllowAnimatedEmoji = 2,
	}
}
#endif // __IOS__
