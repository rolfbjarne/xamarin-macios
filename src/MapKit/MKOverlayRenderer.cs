using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using MapKit;

#nullable enable

namespace MapKit {
	public partial class MKOverlayRenderer {

#if NET
		[SupportedOSPlatform ("tvos12.2")]
		[SupportedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("ios12.2")]
		[SupportedOSPlatform ("maccatalyst15.0")]
#endif
		[DllImport (Constants.MapKitLibrary)]
		public static extern nfloat MKRoadWidthAtZoomScale (/* MKZoomScale */ nfloat zoomScale);
	}
}
