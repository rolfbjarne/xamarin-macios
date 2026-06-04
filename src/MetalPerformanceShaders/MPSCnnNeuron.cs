#nullable enable

using Metal;

namespace MetalPerformanceShaders {
	public partial class MPSCnnNeuronPReLU {
		/// <param name="device">The device.</param>
		///         <param name="a">The a.</param>
		///         <summary>To be added.</summary>
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst", "Please use the '.ctor (IMTLDevice, MPSNNNeuronDescriptor)' overload instead.")]
		[ObsoletedOSPlatform ("tvos12.0", "Please use the '.ctor (IMTLDevice, MPSNNNeuronDescriptor)' overload instead.")]
		[ObsoletedOSPlatform ("macos10.14", "Please use the '.ctor (IMTLDevice, MPSNNNeuronDescriptor)' overload instead.")]
		[ObsoletedOSPlatform ("ios12.0", "Please use the '.ctor (IMTLDevice, MPSNNNeuronDescriptor)' overload instead.")]
		public unsafe MPSCnnNeuronPReLU (IMTLDevice device, float [] a) : this (NSObjectFlag.Empty)
		{
			fixed (void* aHandle = a)
				InitializeHandle (InitWithDevice (device, (IntPtr) aHandle, (nuint) a.Length));
		}
	}
}
