using System;
using ObjCRuntime;

#if NET
using Vector2i = global::CoreGraphics.NVector2i;
#else
using Vector2i = global::OpenTK.Vector2i;
#endif

#nullable enable

namespace ModelIO {

	public partial class MDLNoiseTexture {

		public MDLNoiseTexture (float input, string name, Vector2i textureDimensions, MDLTextureChannelEncoding channelEncoding) : this (input, name, textureDimensions, channelEncoding, MDLNoiseTextureType.Vector)
		{
		}

#if NET
		[SupportedOSPlatform ("ios12.2")]
		[SupportedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("maccatalyst15.0")]
		[SupportedOSPlatform ("tvos12.2")]
#endif
		public MDLNoiseTexture (float input, string name, Vector2i textureDimensions, MDLTextureChannelEncoding channelEncoding, MDLNoiseTextureType type)
		{
			// two different `init*` would share the same C# signature
			switch (type) {
			case MDLNoiseTextureType.Vector:
				Handle = InitVectorNoiseWithSmoothness (input, name, textureDimensions, channelEncoding);
				break;
			case MDLNoiseTextureType.Cellular:
				Handle = InitCellularNoiseWithFrequency (input, name, textureDimensions, channelEncoding);
				break;
			default:
				throw new ArgumentException ("type");
			}
		}
	}
}
