#nullable enable

namespace MetalPerformanceShaders {
	public partial class MPSCnnConvolutionDescriptor {
		/// <param name="mean">The mean.</param>
		///         <param name="variance">The variance.</param>
		///         <param name="gamma">The gamma.</param>
		///         <param name="beta">The beta.</param>
		///         <param name="epsilon">The epsilon.</param>
		///         <summary>To be added.</summary>
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
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
