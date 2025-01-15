using System;
using System.Globalization;
using ObjCRuntime;
using Foundation;

namespace UIKit {

	public partial class UIDevice {

#if NET
		[SupportedOSPlatform ("ios12.2")]
		[SupportedOSPlatform ("tvos12.2")]
		[SupportedOSPlatform ("maccatalyst15.0")]
#endif
		public bool CheckSystemVersion (int major, int minor)
		{
#if __MACCATALYST__
			return Runtime.CheckSystemVersion (major, minor, Runtime.iOSSupportVersion);	
#else
			return Runtime.CheckSystemVersion (major, minor, SystemVersion);
#endif
		}
	}
}
