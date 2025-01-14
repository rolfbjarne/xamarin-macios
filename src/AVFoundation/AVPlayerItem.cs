using System;

using Foundation;
using ObjCRuntime;

#nullable enable

namespace AVFoundation {
	public partial class AVPlayerItem {

#if NET
		[SupportedOSPlatform ("tvos12.2")]
		[SupportedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("ios12.2")]
		[SupportedOSPlatform ("maccatalyst15.0")]
#endif
		public AVVideoApertureMode VideoApertureMode {
			get { return AVVideoApertureModeExtensions.GetValue (_VideoApertureMode); }
			set {
				var val = value.GetConstant ();
				if (val is not null)
					_VideoApertureMode = val;
			}
		}
	}
}
