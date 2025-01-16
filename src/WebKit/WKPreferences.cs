#if !TVOS
using System;

using Foundation;
using ObjCRuntime;

#nullable enable

namespace WebKit {

	public partial class WKPreferences {

#if !COREBUILD
		// we use the attrs of the old property 
#if NET
		[SupportedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst15.0")]
		[UnsupportedOSPlatform ("tvos")]
#else
		[iOS (14, 5)]
		[MacCatalyst (14, 5)]
#endif
		public bool TextInteractionEnabled {
			get {
				if (SystemVersion.IsAtLeastXcode13)
					return _NewGetTextInteractionEnabled ();
				else
					return _OldTextInteractionEnabled;
			}
			set => _OldTextInteractionEnabled = value;
		}
#endif
	}
}
#endif
