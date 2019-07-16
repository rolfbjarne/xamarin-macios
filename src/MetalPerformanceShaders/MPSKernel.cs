#if XAMCORE_2_0 || !MONOMAC
// Copyright 2015-2016 Xamarin Inc. All rights reserved.

using System;
using System.Runtime.InteropServices;
using CoreGraphics;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders {
	public partial class MPSKernel : NSObject {

#if !COREBUILD
		[DllImport (Constants.MetalPerformanceShadersLibrary)]
		extern static bool MPSSupportsMTLDevice (/* __nullable id <MTLDevice> */ IntPtr device);

		public static bool Supports (IMTLDevice device)
		{
			return MPSSupportsMTLDevice (device == null ? IntPtr.Zero : device.Handle);
		}

		internal unsafe static float [] GetTransform (IntPtr transform)
		{
			var t = (float*) transform;
			if (t == null)
				return null;
			return new float [3] { t [0], t [1], t [2] };
		}

		[Field ("MPSRectNoClip", "MetalPerformanceShaders")]
		public unsafe static MTLRegion RectNoClip {
			get {
				var p = Dlfcn.dlsym (Libraries.MetalPerformanceShaders.Handle, "MPSRectNoClip");
				if (p == IntPtr.Zero)
					return new MTLRegion ();
				unsafe {
					nint *ptr = (nint *) p;
					return MTLRegion.Create3D (ptr [0], ptr [1], ptr [2], ptr [3], ptr [4], ptr [5]);
				}
			}
		}

		[DllImport (Constants.MetalPerformanceShadersLibrary)]
		[TV (12,0), Mac (10,14), iOS (12,0)]
		static extern void MPSHintTemporaryMemoryHighWaterMark (IntPtr commandBuffer, nuint bytes);

		[TV (12,0), Mac (10,14), iOS (12,0)]
		public static void HintTemporaryMemoryHighWaterMark (IMTLCommandBuffer commandBuffer, nuint sizeInBytes) => MPSHintTemporaryMemoryHighWaterMark (commandBuffer == null ? IntPtr.Zero : commandBuffer.Handle, sizeInBytes);

		[DllImport (Constants.MetalPerformanceShadersLibrary)]
		[TV (12,0), Mac (10,14), iOS (12,0)]
		static extern void MPSSetHeapCacheDuration (IntPtr commandBuffer, double seconds);

		[TV (12,0), Mac (10,14), iOS (12,0)]
		public static void SetHeapCacheDuration (IMTLCommandBuffer commandBuffer, double seconds) => MPSSetHeapCacheDuration (commandBuffer == null ? IntPtr.Zero : commandBuffer.Handle, seconds);
#endif
	}

#if !COREBUILD
	public partial class MPSImageDilate {

		[DesignatedInitializer]
		public MPSImageDilate (IMTLDevice device, nuint kernelWidth, nuint kernelHeight, float[] values)
			: base (NSObjectFlag.Empty)
		{
			if (values == null)
				throw new ArgumentNullException (nameof (values));

			unsafe {
				fixed (float* ptr = values)
					InitializeHandle (InitWithDevice (device, kernelWidth, kernelHeight, (IntPtr) ptr), "initWithDevice:kernelWidth:kernelHeight:values:");
			}
		}
	}

	public partial class MPSImageErode : MPSImageDilate {

		public MPSImageErode (IMTLDevice device, nuint kernelWidth, nuint kernelHeight, float[] values)
			: base (device, kernelWidth, kernelHeight, values)
		{
		}
	}

	public partial class MPSImageThresholdBinary {

		public MPSImageThresholdBinary (IMTLDevice device, float thresholdValue, float maximumValue, /*[NullAllowed]*/ float[] transform)
			: base (NSObjectFlag.Empty)
		{
			// From: https://github.com/dotnet/csharplang/blob/master/spec/unsafe-code.md#unsafe-code
			// If the array expression is null or if the array has zero elements, the initializer computes an address equal to zero.
			unsafe {
				fixed (float* ptr = transform)
					InitializeHandle (InitWithDevice (device, thresholdValue, maximumValue, (IntPtr) ptr), "initWithDevice:thresholdValue:maximumValue:linearGrayColorTransform:");
			}
		}

		public float[] Transform {
			get { return MPSKernel.GetTransform (_Transform); }
		}
	}

	public partial class MPSImageThresholdBinaryInverse {

		[DesignatedInitializer]
		public MPSImageThresholdBinaryInverse (IMTLDevice device, float thresholdValue, float maximumValue, /*[NullAllowed]*/ float[] transform)
			: base (NSObjectFlag.Empty)
		{
			unsafe {
				fixed (float* ptr = transform)
					InitializeHandle (InitWithDevice (device, thresholdValue, maximumValue, (IntPtr) ptr), "initWithDevice:thresholdValue:maximumValue:linearGrayColorTransform:");
			}
		}

		public float[] Transform {
			get { return MPSKernel.GetTransform (_Transform); }
		}
	}

	public partial class MPSImageThresholdTruncate {

		[DesignatedInitializer]
		public MPSImageThresholdTruncate (IMTLDevice device, float thresholdValue, /*[NullAllowed]*/ float[] transform)
			: base (NSObjectFlag.Empty)
		{
			unsafe {
				fixed (float* ptr = transform)
					InitializeHandle (InitWithDevice (device, thresholdValue, (IntPtr) ptr), "initWithDevice:thresholdValue:linearGrayColorTransform:");
			}
		}

		public float[] Transform {
			get { return MPSKernel.GetTransform (_Transform); }
		}
	}

	public partial class MPSImageThresholdToZero {

		[DesignatedInitializer]
		public MPSImageThresholdToZero (IMTLDevice device, float thresholdValue, /*[NullAllowed]*/ float[] transform)
			: base (NSObjectFlag.Empty)
		{
			unsafe {
				fixed (float* ptr = transform)
					InitializeHandle (InitWithDevice (device, thresholdValue, (IntPtr) ptr), "initWithDevice:thresholdValue:linearGrayColorTransform:");
			}
		}

		public float[] Transform {
			get { return MPSKernel.GetTransform (_Transform); }
		}
	}

	public partial class MPSImageThresholdToZeroInverse {

		[DesignatedInitializer]
		public MPSImageThresholdToZeroInverse (IMTLDevice device, float thresholdValue, /*[NullAllowed]*/ float[] transform)
			: base (NSObjectFlag.Empty)
		{
			unsafe {
				fixed (float* ptr = transform)
					InitializeHandle (InitWithDevice (device, thresholdValue, (IntPtr) ptr), "initWithDevice:thresholdValue:linearGrayColorTransform:");
			}
		}

		public float[] Transform {
			get { return MPSKernel.GetTransform (_Transform); }
		}
	}

	public partial class MPSImageSobel {

		[DesignatedInitializer]
		public MPSImageSobel (IMTLDevice device, float[] transform)
			: base (NSObjectFlag.Empty)
		{
			if (transform == null)
				throw new ArgumentNullException (nameof (transform));

			unsafe {
				fixed (float* ptr = transform)
					InitializeHandle (InitWithDevice (device, (IntPtr) ptr), "initWithDevice:linearGrayColorTransform:");
			}
		}

		public float[] ColorTransform {
			get { return MPSKernel.GetTransform (_ColorTransform); }
		}
	}

	public partial class MPSCnnConvolution {

		[DesignatedInitializer]
		public MPSCnnConvolution (IMTLDevice device, MPSCnnConvolutionDescriptor convolutionDescriptor, float[] kernelWeights, float[] biasTerms, MPSCnnConvolutionFlags flags)
			: base (NSObjectFlag.Empty)
		{
			if (kernelWeights == null)
				throw new ArgumentNullException (nameof (kernelWeights));

			unsafe {
				fixed (float* kernelWeightsptr = kernelWeights)
				fixed (float* biasTermsptr = biasTerms)
					InitializeHandle (InitWithDevice (device, convolutionDescriptor, (IntPtr) kernelWeightsptr, (IntPtr) biasTermsptr, flags), "initWithDevice:convolutionDescriptor:kernelWeights:biasTerms:flags:");
			}
		}
	}

	public partial class MPSCnnFullyConnected {

		[Deprecated (PlatformName.TvOS, 11, 0, message: "Use any of the other 'DesignatedInitializer' ctors.")]
		[Deprecated (PlatformName.iOS, 11, 0, message: "Use any of the other 'DesignatedInitializer' ctors.")]
		public MPSCnnFullyConnected (IMTLDevice device, MPSCnnConvolutionDescriptor convolutionDescriptor, float[] kernelWeights, float[] biasTerms, MPSCnnConvolutionFlags flags)
			: base (NSObjectFlag.Empty)
		{
			if (kernelWeights == null)
				throw new ArgumentNullException (nameof (kernelWeights));

			unsafe {
				fixed (float* kernelWeightsptr = kernelWeights)
				fixed (float* biasTermsptr = biasTerms)
					InitializeHandle (InitWithDevice (device, convolutionDescriptor, (IntPtr) kernelWeightsptr, (IntPtr) biasTermsptr, flags), "initWithDevice:convolutionDescriptor:kernelWeights:biasTerms:flags:");
			}
		}
	}

	public partial class MPSImageConversion {
		public MPSImageConversion (IMTLDevice device, MPSAlphaType srcAlpha, MPSAlphaType destAlpha, nfloat[] backgroundColor, CGColorConversionInfo conversionInfo)
			: base (NSObjectFlag.Empty)
		{
			unsafe {
				fixed (nfloat* ptr = backgroundColor)
					InitializeHandle (InitWithDevice (device, srcAlpha, destAlpha, (IntPtr) ptr, conversionInfo), "initWithDevice:srcAlpha:destAlpha:backgroundColor:conversionInfo:");
			}
		}
	}

	public partial class MPSImagePyramid {

		[DesignatedInitializer]
		public MPSImagePyramid (IMTLDevice device, nuint kernelWidth, nuint kernelHeight, float[] kernelWeights)
			: base (NSObjectFlag.Empty)
		{
			if (kernelWeights == null)
				throw new ArgumentNullException (nameof (kernelWeights));

			unsafe {
				fixed (float* ptr = kernelWeights)
					InitializeHandle (InitWithDevice (device, kernelWidth, kernelHeight, (IntPtr) ptr), "initWithDevice:kernelWidth:kernelHeight:weights:");
			}
		}
	}

	public partial class MPSImageGaussianPyramid {

		[DesignatedInitializer]
		public MPSImageGaussianPyramid (IMTLDevice device, nuint kernelWidth, nuint kernelHeight, float[] kernelWeights)
			: base (NSObjectFlag.Empty)
		{
			if (kernelWeights == null)
				throw new ArgumentNullException (nameof (kernelWeights));

			unsafe {
				fixed (float* ptr = kernelWeights)
					InitializeHandle (InitWithDevice (device, kernelWidth, kernelHeight, (IntPtr) ptr), "initWithDevice:kernelWidth:kernelHeight:weights:");
			}
		}
	}

	public partial class MPSImageLaplacianPyramid {
		[DesignatedInitializer]
		public MPSImageLaplacianPyramid (IMTLDevice device, nuint kernelWidth, nuint kernelHeight, float[] kernelWeights) : base (NSObjectFlag.Empty)
		{
			if (kernelWeights == null)
				throw new ArgumentNullException (nameof (kernelWeights));
			if ((nuint) kernelWeights.Length < kernelWidth * kernelHeight)
				throw new ArgumentException ($"'{nameof (kernelWeights)}' size must be at least '{nameof (kernelWidth)}' * '{nameof (kernelHeight)}'.");

			unsafe {
				fixed (float* ptr = kernelWeights)
					InitializeHandle (InitWithDevice (device, kernelWidth, kernelHeight, (IntPtr) ptr), "initWithDevice:kernelWidth:kernelHeight:weights:");
			}
		}
	}

	public partial class MPSImageLaplacianPyramidSubtract {
		[DesignatedInitializer]
		public MPSImageLaplacianPyramidSubtract (IMTLDevice device, nuint kernelWidth, nuint kernelHeight, float[] kernelWeights) : base (NSObjectFlag.Empty)
		{
			if (kernelWeights == null)
				throw new ArgumentNullException (nameof (kernelWeights));
			if ((nuint) kernelWeights.Length < kernelWidth * kernelHeight)
				throw new ArgumentException ($"'{nameof (kernelWeights)}' size must be at least '{nameof (kernelWidth)}' * '{nameof (kernelHeight)}'.");

			unsafe {
				fixed (float* ptr = kernelWeights)
					InitializeHandle (InitWithDevice (device, kernelWidth, kernelHeight, (IntPtr) ptr), "initWithDevice:kernelWidth:kernelHeight:weights:");
			}
		}
	}

	public partial class MPSImageLaplacianPyramidAdd {
		[DesignatedInitializer]
		public MPSImageLaplacianPyramidAdd (IMTLDevice device, nuint kernelWidth, nuint kernelHeight, float[] kernelWeights) : base (NSObjectFlag.Empty)
		{
			if (kernelWeights == null)
				throw new ArgumentNullException (nameof (kernelWeights));
			if ((nuint) kernelWeights.Length < kernelWidth * kernelHeight)
				throw new ArgumentException ($"'{nameof (kernelWeights)}' size must be at least '{nameof (kernelWidth)}' * '{nameof (kernelHeight)}'.");

			unsafe {
				fixed (float* ptr = kernelWeights)
					InitializeHandle (InitWithDevice (device, kernelWidth, kernelHeight, (IntPtr) ptr), "initWithDevice:kernelWidth:kernelHeight:weights:");
			}
		}
	}

	public partial class MPSCnnBinaryConvolutionNode {
		[TV (11,3), Mac (10,13,4), iOS (11,3)]
		public static MPSCnnBinaryConvolutionNode Create (MPSNNImageNode sourceNode, IMPSCnnConvolutionDataSource weights, float [] outputBiasTerms, float [] outputScaleTerms, float [] inputBiasTerms, float [] inputScaleTerms, MPSCnnBinaryConvolutionType type, MPSCnnBinaryConvolutionFlags flags)
		{
			unsafe {
				fixed (void* outputBiasTermsHandle = outputBiasTerms)
				fixed (void* outputScaleTermsHandle = outputScaleTerms)
				fixed (void* inputBiasTermsHandle = inputBiasTerms)
				fixed (void* inputScaleTermsHandle = inputScaleTerms)
					return Create (sourceNode, weights, (IntPtr) outputBiasTermsHandle, (IntPtr) outputScaleTermsHandle, (IntPtr) inputBiasTermsHandle, (IntPtr) inputScaleTermsHandle, type, flags);
			}
		}

		[TV (11,3), Mac (10,13,4), iOS (11,3)]
		public MPSCnnBinaryConvolutionNode (MPSNNImageNode sourceNode, IMPSCnnConvolutionDataSource weights, float [] outputBiasTerms, float [] outputScaleTerms, float [] inputBiasTerms, float [] inputScaleTerms, MPSCnnBinaryConvolutionType type, MPSCnnBinaryConvolutionFlags flags) : base (NSObjectFlag.Empty)
		{
			unsafe {
				fixed (void* outputBiasTermsHandle = outputBiasTerms)
				fixed (void* outputScaleTermsHandle = outputScaleTerms)
				fixed (void* inputBiasTermsHandle = inputBiasTerms)
				fixed (void* inputScaleTermsHandle = inputScaleTerms)
					InitializeHandle (InitWithSource (sourceNode, weights, (IntPtr) outputBiasTermsHandle, (IntPtr) outputScaleTermsHandle, (IntPtr) inputBiasTermsHandle, (IntPtr) inputScaleTermsHandle, type, flags));
			}
		}
	}

	public partial class MPSCnnBinaryFullyConnectedNode {
		[TV (11,3), Mac (10,13,4), iOS (11,3)]
		public static MPSCnnBinaryFullyConnectedNode Create (MPSNNImageNode sourceNode, IMPSCnnConvolutionDataSource weights, float [] outputBiasTerms, float [] outputScaleTerms, float [] inputBiasTerms, float [] inputScaleTerms, MPSCnnBinaryConvolutionType type, MPSCnnBinaryConvolutionFlags flags)
		{
			unsafe {
				fixed (void* outputBiasTermsHandle = outputBiasTerms)
				fixed (void* outputScaleTermsHandle = outputScaleTerms)
				fixed (void* inputBiasTermsHandle = inputBiasTerms)
				fixed (void* inputScaleTermsHandle = inputScaleTerms)
					return Create (sourceNode, weights, (IntPtr) outputBiasTermsHandle, (IntPtr) outputScaleTermsHandle, (IntPtr) inputBiasTermsHandle, (IntPtr) inputScaleTermsHandle, type, flags);
			}
		}

		[TV (11,3), Mac (10,13,4), iOS (11,3)]
		public MPSCnnBinaryFullyConnectedNode (MPSNNImageNode sourceNode, IMPSCnnConvolutionDataSource weights, float [] outputBiasTerms, float [] outputScaleTerms, float [] inputBiasTerms, float [] inputScaleTerms, MPSCnnBinaryConvolutionType type, MPSCnnBinaryConvolutionFlags flags) : base (NSObjectFlag.Empty)
		{
			unsafe {
				fixed (void* outputBiasTermsHandle = outputBiasTerms)
				fixed (void* outputScaleTermsHandle = outputScaleTerms)
				fixed (void* inputBiasTermsHandle = inputBiasTerms)
				fixed (void* inputScaleTermsHandle = inputScaleTerms)
					InitializeHandle (InitWithSource (sourceNode, weights, (IntPtr) outputBiasTermsHandle, (IntPtr) outputScaleTermsHandle, (IntPtr) inputBiasTermsHandle, (IntPtr) inputScaleTermsHandle, type, flags));
			}
		}
	}
#endif
}
#endif