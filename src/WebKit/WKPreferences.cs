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
					// The CA1416 here is an analyzer bug: https://github.com/dotnet/roslyn-analyzers/issues/7530
#pragma warning disable CA1416 // This call site is reachable on: 'ios' 14.5 and later, 'maccatalyst' 14.5 and later, 'macOS/OSX' 12.0 and later. 'WKPreferences._NewGetTextInteractionEnabled()' is only supported on: 'ios' 15.0 and later, 'maccatalyst' 15.0 and later.
					return _NewGetTextInteractionEnabled ();
#pragma warning restore CA1416
				else
					return _OldTextInteractionEnabled;
			}
			set => _OldTextInteractionEnabled = value;
		}
#endif
	}
}
#endif
