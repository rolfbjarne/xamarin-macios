// 
// AVPlayerLayer.cs: AVPlayerLayer class
//
// Authors:
//	Alex Soto (alex.soto@xamarin.com)
//     
// Copyright 2015 Xamarin Inc.
//

using ObjCRuntime;
using CoreVideo;

#nullable enable

namespace AVFoundation {
	public partial class AVPlayerLayer {
#if NET
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst15.0")]
		[SupportedOSPlatform ("tvos")]
#endif
		public CVPixelBufferAttributes? PixelBufferAttributes {
			get {
				if (WeakPixelBufferAttributes is not null) {
					var strongDict = new CVPixelBufferAttributes (WeakPixelBufferAttributes);
					return strongDict;
				}
				return null;
			}
			set {
				WeakPixelBufferAttributes = value?.Dictionary;
			}
		}
	}
}
