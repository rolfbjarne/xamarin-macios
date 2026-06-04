#nullable enable

using Metal;

namespace MetalPerformanceShaders {
	public partial class MPSCnnBinaryConvolution {
		/// <param name="device">The device.</param>
		///         <param name="convolutionData">The convolution data.</param>
		///         <param name="outputBiasTerms">The output bias terms.</param>
		///         <param name="outputScaleTerms">The output scale terms.</param>
		///         <param name="inputBiasTerms">The input bias terms.</param>
		///         <param name="inputScaleTerms">The input scale terms.</param>
		///         <param name="type">The type.</param>
		///         <param name="flags">The flags.</param>
		/// <summary>Creates a new binary convolution kernel with the specified parameters.</summary>
		public unsafe MPSCnnBinaryConvolution (IMTLDevice device, IMPSCnnConvolutionDataSource convolutionData, float [] outputBiasTerms, float [] outputScaleTerms, float [] inputBiasTerms, float [] inputScaleTerms, MPSCnnBinaryConvolutionType type, MPSCnnBinaryConvolutionFlags flags)
			: base (NSObjectFlag.Empty)
		{
			fixed (void* outputBiasTermsHandle = outputBiasTerms)
			fixed (void* outputScaleTermsHandle = outputScaleTerms)
			fixed (void* inputBiasTermsHandle = inputBiasTerms)
			fixed (void* inputScaleTermsHandle = inputScaleTerms)
				InitializeHandle (_InitWithDevice (device, convolutionData, (IntPtr) outputBiasTermsHandle, (IntPtr) outputScaleTermsHandle, (IntPtr) inputBiasTermsHandle, (IntPtr) inputScaleTermsHandle, type, flags));
		}
	}

	public partial class MPSCnnBinaryFullyConnected {
		/// <param name="device">The device.</param>
		///         <param name="convolutionData">The convolution data.</param>
		///         <param name="outputBiasTerms">The output bias terms.</param>
		///         <param name="outputScaleTerms">The output scale terms.</param>
		///         <param name="inputBiasTerms">The input bias terms.</param>
		///         <param name="inputScaleTerms">The input scale terms.</param>
		///         <param name="type">The type.</param>
		///         <param name="flags">The flags.</param>
		/// <summary>Creates a new binary fully connected layer with the specified parameters.</summary>
		public unsafe MPSCnnBinaryFullyConnected (IMTLDevice device, IMPSCnnConvolutionDataSource convolutionData, float [] outputBiasTerms, float [] outputScaleTerms, float [] inputBiasTerms, float [] inputScaleTerms, MPSCnnBinaryConvolutionType type, MPSCnnBinaryConvolutionFlags flags)
			: base (NSObjectFlag.Empty)
		{
			fixed (void* outputBiasTermsHandle = outputBiasTerms)
			fixed (void* outputScaleTermsHandle = outputScaleTerms)
			fixed (void* inputBiasTermsHandle = inputBiasTerms)
			fixed (void* inputScaleTermsHandle = inputScaleTerms)
				InitializeHandle (_InitWithDevice (device, convolutionData, (IntPtr) outputBiasTermsHandle, (IntPtr) outputScaleTermsHandle, (IntPtr) inputBiasTermsHandle, (IntPtr) inputScaleTermsHandle, type, flags));
		}
	}
}
