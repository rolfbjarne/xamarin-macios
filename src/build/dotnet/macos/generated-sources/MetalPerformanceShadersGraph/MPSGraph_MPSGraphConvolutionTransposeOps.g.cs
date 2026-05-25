//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace MetalPerformanceShadersGraph {
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class MPSGraph_MPSGraphConvolutionTransposeOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvolutionTranspose2DDataGradientWithIncomingGradientTensor_WeightsTensor_OutputShape_ForwardConvolutionDescriptor_Name_X = "convolutionTranspose2DDataGradientWithIncomingGradientTensor:weightsTensor:outputShape:forwardConvolutionDescriptor:name:";
		static readonly NativeHandle selConvolutionTranspose2DDataGradientWithIncomingGradientTensor_WeightsTensor_OutputShape_ForwardConvolutionDescriptor_Name_XHandle = Selector.GetHandle ("convolutionTranspose2DDataGradientWithIncomingGradientTensor:weightsTensor:outputShape:forwardConvolutionDescriptor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvolutionTranspose2DDataGradientWithIncomingGradientTensor_WeightsTensor_OutputShapeTensor_ForwardConvolutionDescriptor_Name_X = "convolutionTranspose2DDataGradientWithIncomingGradientTensor:weightsTensor:outputShapeTensor:forwardConvolutionDescriptor:name:";
		static readonly NativeHandle selConvolutionTranspose2DDataGradientWithIncomingGradientTensor_WeightsTensor_OutputShapeTensor_ForwardConvolutionDescriptor_Name_XHandle = Selector.GetHandle ("convolutionTranspose2DDataGradientWithIncomingGradientTensor:weightsTensor:outputShapeTensor:forwardConvolutionDescriptor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvolutionTranspose2DWeightsGradientWithIncomingGradientTensor_SourceTensor_OutputShape_ForwardConvolutionDescriptor_Name_X = "convolutionTranspose2DWeightsGradientWithIncomingGradientTensor:sourceTensor:outputShape:forwardConvolutionDescriptor:name:";
		static readonly NativeHandle selConvolutionTranspose2DWeightsGradientWithIncomingGradientTensor_SourceTensor_OutputShape_ForwardConvolutionDescriptor_Name_XHandle = Selector.GetHandle ("convolutionTranspose2DWeightsGradientWithIncomingGradientTensor:sourceTensor:outputShape:forwardConvolutionDescriptor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvolutionTranspose2DWeightsGradientWithIncomingGradientTensor_SourceTensor_OutputShapeTensor_ForwardConvolutionDescriptor_Name_X = "convolutionTranspose2DWeightsGradientWithIncomingGradientTensor:sourceTensor:outputShapeTensor:forwardConvolutionDescriptor:name:";
		static readonly NativeHandle selConvolutionTranspose2DWeightsGradientWithIncomingGradientTensor_SourceTensor_OutputShapeTensor_ForwardConvolutionDescriptor_Name_XHandle = Selector.GetHandle ("convolutionTranspose2DWeightsGradientWithIncomingGradientTensor:sourceTensor:outputShapeTensor:forwardConvolutionDescriptor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvolutionTranspose2DWithSourceTensor_WeightsTensor_OutputShape_Descriptor_Name_X = "convolutionTranspose2DWithSourceTensor:weightsTensor:outputShape:descriptor:name:";
		static readonly NativeHandle selConvolutionTranspose2DWithSourceTensor_WeightsTensor_OutputShape_Descriptor_Name_XHandle = Selector.GetHandle ("convolutionTranspose2DWithSourceTensor:weightsTensor:outputShape:descriptor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvolutionTranspose2DWithSourceTensor_WeightsTensor_OutputShapeTensor_Descriptor_Name_X = "convolutionTranspose2DWithSourceTensor:weightsTensor:outputShapeTensor:descriptor:name:";
		static readonly NativeHandle selConvolutionTranspose2DWithSourceTensor_WeightsTensor_OutputShapeTensor_Descriptor_Name_XHandle = Selector.GetHandle ("convolutionTranspose2DWithSourceTensor:weightsTensor:outputShapeTensor:descriptor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("convolutionTranspose2DWithSourceTensor:weightsTensor:outputShape:descriptor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ConvolutionTranspose2D (this MPSGraph This, MPSGraphTensor source, MPSGraphTensor weights, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] outputShape, MPSGraphConvolution2DOpDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var weights__handle__ = weights!.GetNonNullHandle (nameof (weights));
			if (outputShape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (outputShape));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			using var nsb_outputShape = NSArray.FromNSObjects (o => new NSNumber (o), outputShape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, selConvolutionTranspose2DWithSourceTensor_WeightsTensor_OutputShape_Descriptor_Name_XHandle, source__handle__, weights__handle__, nsb_outputShape.GetHandle (), descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (weights);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("convolutionTranspose2DWithSourceTensor:weightsTensor:outputShapeTensor:descriptor:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ConvolutionTranspose2D (this MPSGraph This, MPSGraphTensor source, MPSGraphTensor weights, MPSGraphTensor outputShape, MPSGraphConvolution2DOpDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var weights__handle__ = weights!.GetNonNullHandle (nameof (weights));
			var outputShape__handle__ = outputShape!.GetNonNullHandle (nameof (outputShape));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, selConvolutionTranspose2DWithSourceTensor_WeightsTensor_OutputShapeTensor_Descriptor_Name_XHandle, source__handle__, weights__handle__, outputShape__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (weights);
			GC.KeepAlive (outputShape);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("convolutionTranspose2DDataGradientWithIncomingGradientTensor:weightsTensor:outputShape:forwardConvolutionDescriptor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ConvolutionTranspose2DDataGradient (this MPSGraph This, MPSGraphTensor incomingGradient, MPSGraphTensor weights, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] outputShape, MPSGraphConvolution2DOpDescriptor forwardConvolutionDescriptor, string? name)
		{
			var incomingGradient__handle__ = incomingGradient!.GetNonNullHandle (nameof (incomingGradient));
			var weights__handle__ = weights!.GetNonNullHandle (nameof (weights));
			if (outputShape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (outputShape));
			var forwardConvolutionDescriptor__handle__ = forwardConvolutionDescriptor!.GetNonNullHandle (nameof (forwardConvolutionDescriptor));
			using var nsb_outputShape = NSArray.FromNSObjects (o => new NSNumber (o), outputShape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, selConvolutionTranspose2DDataGradientWithIncomingGradientTensor_WeightsTensor_OutputShape_ForwardConvolutionDescriptor_Name_XHandle, incomingGradient__handle__, weights__handle__, nsb_outputShape.GetHandle (), forwardConvolutionDescriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (incomingGradient);
			GC.KeepAlive (weights);
			GC.KeepAlive (forwardConvolutionDescriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("convolutionTranspose2DDataGradientWithIncomingGradientTensor:weightsTensor:outputShapeTensor:forwardConvolutionDescriptor:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ConvolutionTranspose2DDataGradient (this MPSGraph This, MPSGraphTensor incomingGradient, MPSGraphTensor weights, MPSGraphTensor outputShape, MPSGraphConvolution2DOpDescriptor forwardConvolutionDescriptor, string? name)
		{
			var incomingGradient__handle__ = incomingGradient!.GetNonNullHandle (nameof (incomingGradient));
			var weights__handle__ = weights!.GetNonNullHandle (nameof (weights));
			var outputShape__handle__ = outputShape!.GetNonNullHandle (nameof (outputShape));
			var forwardConvolutionDescriptor__handle__ = forwardConvolutionDescriptor!.GetNonNullHandle (nameof (forwardConvolutionDescriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, selConvolutionTranspose2DDataGradientWithIncomingGradientTensor_WeightsTensor_OutputShapeTensor_ForwardConvolutionDescriptor_Name_XHandle, incomingGradient__handle__, weights__handle__, outputShape__handle__, forwardConvolutionDescriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (incomingGradient);
			GC.KeepAlive (weights);
			GC.KeepAlive (outputShape);
			GC.KeepAlive (forwardConvolutionDescriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("convolutionTranspose2DWeightsGradientWithIncomingGradientTensor:sourceTensor:outputShape:forwardConvolutionDescriptor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ConvolutionTranspose2DWeightsGradient (this MPSGraph This, MPSGraphTensor incomingGradientTensor, MPSGraphTensor source, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] outputShape, MPSGraphConvolution2DOpDescriptor forwardConvolutionDescriptor, string? name)
		{
			var incomingGradientTensor__handle__ = incomingGradientTensor!.GetNonNullHandle (nameof (incomingGradientTensor));
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			if (outputShape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (outputShape));
			var forwardConvolutionDescriptor__handle__ = forwardConvolutionDescriptor!.GetNonNullHandle (nameof (forwardConvolutionDescriptor));
			using var nsb_outputShape = NSArray.FromNSObjects (o => new NSNumber (o), outputShape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, selConvolutionTranspose2DWeightsGradientWithIncomingGradientTensor_SourceTensor_OutputShape_ForwardConvolutionDescriptor_Name_XHandle, incomingGradientTensor__handle__, source__handle__, nsb_outputShape.GetHandle (), forwardConvolutionDescriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (incomingGradientTensor);
			GC.KeepAlive (source);
			GC.KeepAlive (forwardConvolutionDescriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("convolutionTranspose2DWeightsGradientWithIncomingGradientTensor:sourceTensor:outputShapeTensor:forwardConvolutionDescriptor:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ConvolutionTranspose2DWeightsGradient (this MPSGraph This, MPSGraphTensor incomingGradientTensor, MPSGraphTensor source, MPSGraphTensor outputShape, MPSGraphConvolution2DOpDescriptor forwardConvolutionDescriptor, string? name)
		{
			var incomingGradientTensor__handle__ = incomingGradientTensor!.GetNonNullHandle (nameof (incomingGradientTensor));
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var outputShape__handle__ = outputShape!.GetNonNullHandle (nameof (outputShape));
			var forwardConvolutionDescriptor__handle__ = forwardConvolutionDescriptor!.GetNonNullHandle (nameof (forwardConvolutionDescriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, selConvolutionTranspose2DWeightsGradientWithIncomingGradientTensor_SourceTensor_OutputShapeTensor_ForwardConvolutionDescriptor_Name_XHandle, incomingGradientTensor__handle__, source__handle__, outputShape__handle__, forwardConvolutionDescriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (incomingGradientTensor);
			GC.KeepAlive (source);
			GC.KeepAlive (outputShape);
			GC.KeepAlive (forwardConvolutionDescriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphConvolutionTransposeOps */
}
