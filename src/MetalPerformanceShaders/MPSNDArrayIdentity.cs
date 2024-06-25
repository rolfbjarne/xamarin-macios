#nullable enable

using System;
using Metal;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders {
	public partial class MPSNDArrayIdentity {
#if NET
		[ObsoletedOSPlatform ("macos15.0")]
		[ObsoletedOSPlatform ("tvos18.0")]
		[ObsoletedOSPlatform ("ios18.0")]
		[ObsoletedOSPlatform ("maccatalyst18.0")]
#else
		[Deprecated (PlatformName.iOS, 18, 0)]
		[Deprecated (PlatformName.MacCatalyst, 18, 0)]
		[Deprecated (PlatformName.TvOS, 18, 0)]
		[Deprecated (PlatformName.MacOSX, 15, 0)]
#endif
		public MPSNDArray? Reshape (IMTLComputeCommandEncoder encoder, MPSNDArray sourceArray, nuint[] dimensions, MPSNDArray destinationArray)
		{
			MPSNDArray? rv;
			unsafe {
				fixed (nuint* dimensionsPtr = dimensions) {
					rv = _Reshape (encoder, sourceArray, (nuint) dimensions.Length, (IntPtr) dimensionsPtr, destinationArray);
				}
			}
			return rv;
		}
#if NET
		[ObsoletedOSPlatform ("macos15.0")]
		[ObsoletedOSPlatform ("tvos18.0")]
		[ObsoletedOSPlatform ("ios18.0")]
		[ObsoletedOSPlatform ("maccatalyst18.0")]
#else
		[Deprecated (PlatformName.iOS, 18, 0)]
		[Deprecated (PlatformName.MacCatalyst, 18, 0)]
		[Deprecated (PlatformName.TvOS, 18, 0)]
		[Deprecated (PlatformName.MacOSX, 15, 0)]
#endif
		public MPSNDArray? Reshape (IMTLComputeCommandEncoder encoder, IMTLCommandBuffer? commandBuffer, MPSNDArray sourceArray, nuint[] dimensions, MPSNDArray destinationArray)
		{
			MPSNDArray? rv;
			unsafe {
				fixed (nuint* dimensionsPtr = dimensions) {
					rv = _Reshape (encoder, commandBuffer, sourceArray, (nuint) dimensions.Length, (IntPtr) dimensionsPtr, destinationArray);
				}
			}
			return rv;
		}
	}
}
