//
// 
//

#if !XAMCORE_5_0

using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using MapKit;

#nullable enable

namespace MapKit {
	public partial class MKOverlayView {

#if NET
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst15.0")]
		[ObsoletedOSPlatform ("ios", "Use 'MKOverlayRenderer.MKRoadWidthAtZoomScale' instead.")]
		[ObsoletedOSPlatform ("macos", "Use 'MKOverlayRenderer.MKRoadWidthAtZoomScale' instead.")]
		[ObsoletedOSPlatform ("tvos", "Use 'MKOverlayRenderer.MKRoadWidthAtZoomScale' instead.")]
		[ObsoletedOSPlatform ("maccatalyst", "Use 'MKOverlayRenderer.MKRoadWidthAtZoomScale' instead.")]
#else
		[Obsolete ("Use 'MKOverlayRenderer.MKRoadWidthAtZoomScale' instead.")]
#endif
		[DllImport (Constants.MapKitLibrary)]
		public static extern nfloat MKRoadWidthAtZoomScale (/* MKZoomScale */ nfloat zoomScale);
	}
}

#endif // !XAMCORE_5_0
