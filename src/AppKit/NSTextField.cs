//
// NSTextField.cs: Support for the NSTextField class
//

#if !__MACCATALYST__

using System;
using ObjCRuntime;
using Foundation;

#nullable enable

namespace AppKit {

	public partial class NSTextField {
		[ObsoletedOSPlatform ("macos10.10")]
		[UnsupportedOSPlatform ("maccatalyst15.0")]
		[SupportedOSPlatform ("macos12.0")]
		public new NSTextFieldCell Cell {
			get { return (NSTextFieldCell) base.Cell; }
			set { base.Cell = value; }
		}
	}
}
#endif // !__MACCATALYST__
