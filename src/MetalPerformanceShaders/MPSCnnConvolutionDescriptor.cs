#nullable enable

using System;
using ObjCRuntime;

namespace MetalPerformanceShaders {
	public partial class MPSCnnConvolutionDescriptor {

#if NET
		[SupportedOSPlatform ("tvos12.2")]
		[SupportedOSPlatform ("ios12.2")]
		[SupportedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("maccatalyst15.0")]
#else
		[Introduced (PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
#endif
		public unsafe void SetBatchNormalizationParameters (float [] mean, float [] variance, float [] gamma, float [] beta, float epsilon)
		{
			fixed (void* meanHandle = mean)
			fixed (void* varianceHandle = variance)
			fixed (void* gammaHandle = gamma)
			fixed (void* betaHandle = beta)
				SetBatchNormalizationParameters ((IntPtr) meanHandle, (IntPtr) varianceHandle, (IntPtr) gammaHandle, (IntPtr) betaHandle, epsilon);
		}

	}
}
