//
// NSLevelIndicator: Support for the NSLevelIndicator class
//
// Author:
//   Pavel Sich (pavel.sich@me.com)
//

#if !__MACCATALYST__

using System;
using ObjCRuntime;
using Foundation;

#nullable enable

namespace AppKit {

	public partial class NSLevelIndicator {
		[ObsoletedOSPlatform ("macos10.10")]
		[UnsupportedOSPlatform ("maccatalyst15.0")]
		[SupportedOSPlatform ("macos12.0")]
		public new NSLevelIndicatorCell Cell {
			get { return (NSLevelIndicatorCell) base.Cell; }
			set { base.Cell = value; }
		}
	}
}
#endif // !__MACCATALYST__
