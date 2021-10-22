#if !XAMCORE_4_0

using System;
using Metal;
using System.Runtime.Versioning;

using ObjCRuntime;

#if !NET
using NativeHandle = System.IntPtr;
#endif

namespace MetalPerformanceShaders {

	public partial class MPSCnnConvolutionTransposeNode {

		[Obsolete ("Always return null (not a public API).")]
		static public MPSCnnConvolutionTransposeNode Create (MPSNNImageNode sourceNode,  MPSCnnConvolutionStateNode convolutionState, IMPSCnnConvolutionDataSource weights)
		{
			return null;
		}

		[Obsolete ("Always throw a 'NotSupportedException' (not a public API).")]
		public MPSCnnConvolutionTransposeNode (MPSNNImageNode sourceNode, MPSCnnConvolutionStateNode convolutionState, IMPSCnnConvolutionDataSource weights) : base (IntPtr.Zero)
		{
			throw new NotSupportedException ();
		}
	}

	public partial class MPSCnnConvolutionNode {

		[Obsolete ("Empty stub (not a public API).")]
		public virtual MPSCnnConvolutionStateNode ConvolutionState { get; }
	}

	public partial class MPSCnnConvolutionTranspose {
		[Obsolete ("Always throws 'NotSupportedException' (not a public API).")]
		public virtual MPSImage EncodeToCommandBuffer (IMTLCommandBuffer commandBuffer, MPSImage sourceImage, MPSCnnConvolutionState convolutionState) 
			=> throw new NotSupportedException ();
	}

	public partial class MPSCnnConvolution {
#if !NET
		[TV (11, 0), iOS (11, 0)]
		[Obsolete ("Always throws 'NotSupportedException' (not a public API).")]
#else
		[SupportedOSPlatform ("ios11.0")]
		[SupportedOSPlatform ("tvos11.0")]
		[Obsolete ("Always throws 'NotSupportedException' (not a public API).", DiagnosticId = "BI1234", UrlFormat = "https://github.com/xamarin/xamarin-macios/wiki/Obsolete")]
#endif
		public virtual void EncodeToCommandBuffer (IMTLCommandBuffer commandBuffer, MPSImage sourceImage, MPSImage destinationImage, out MPSCnnConvolutionState state)
			=> throw new NotSupportedException ();
	}

#if !NET
	[TV (11,0), Mac (10, 13), iOS (11,0)]
	[Obsolete ("Empty stub (not a public API).")]
#else
	[SupportedOSPlatform ("ios11.0")]
	[SupportedOSPlatform ("tvos11.0")]
	[Obsolete ("Empty stub (not a public API).", DiagnosticId = "BI1234", UrlFormat = "https://github.com/xamarin/xamarin-macios/wiki/Obsolete")]
#endif
	public partial class MPSCnnConvolutionState : MPSState, IMPSImageSizeEncodingState {

		[Obsolete ("Always throws 'NotSupportedException' (not a public API).")]
		protected MPSCnnConvolutionState (Foundation.NSObjectFlag t) : base (t)
			=> throw new NotSupportedException ();

		[Obsolete ("Always throws 'NotSupportedException' (not a public API).")]
		protected MPSCnnConvolutionState (NativeHandle handle) : base (handle)
			=> throw new NotSupportedException ();

		[Obsolete ("Empty stub (not a public API).")]
		public virtual nuint KernelWidth { get; }

		[Obsolete ("Empty stub (not a public API).")]
		public virtual nuint KernelHeight { get; }

		[Obsolete ("Empty stub (not a public API).")]
		public virtual MPSOffset SourceOffset { get; }

		[Obsolete ("Empty stub (not a public API).")]
		public virtual nuint SourceWidth { get; }

		[Obsolete ("Empty stub (not a public API).")]
		public virtual nuint SourceHeight { get; }

#pragma warning disable CS0809
		[Obsolete ("Empty stub (not a public API).")]
		public override NativeHandle ClassHandle { get; }
#pragma warning restore CS0809
	}
}

#endif
