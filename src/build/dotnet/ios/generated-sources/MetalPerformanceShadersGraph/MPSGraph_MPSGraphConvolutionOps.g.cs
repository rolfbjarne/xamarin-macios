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
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
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
	public unsafe static partial class MPSGraph_MPSGraphConvolutionOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("convolution2DWithSourceTensor:weightsTensor:descriptor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Convolution2D (this MPSGraph This, MPSGraphTensor source, MPSGraphTensor weights, MPSGraphConvolution2DOpDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var weights__handle__ = weights!.GetNonNullHandle (nameof (weights));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("convolution2DWithSourceTensor:weightsTensor:descriptor:name:"), source__handle__, weights__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (weights);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("convolution2DDataGradientWithIncomingGradientTensor:weightsTensor:outputShape:forwardConvolutionDescriptor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Convolution2DDataGradient (this MPSGraph This, MPSGraphTensor incomingGradient, MPSGraphTensor weights, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] outputShape, MPSGraphConvolution2DOpDescriptor forwardConvolutionDescriptor, string? name)
		{
			var incomingGradient__handle__ = incomingGradient!.GetNonNullHandle (nameof (incomingGradient));
			var weights__handle__ = weights!.GetNonNullHandle (nameof (weights));
			if (outputShape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (outputShape));
			var forwardConvolutionDescriptor__handle__ = forwardConvolutionDescriptor!.GetNonNullHandle (nameof (forwardConvolutionDescriptor));
			using var nsb_outputShape = NSArray.FromNSObjects (o => new NSNumber (o), outputShape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("convolution2DDataGradientWithIncomingGradientTensor:weightsTensor:outputShape:forwardConvolutionDescriptor:name:"), incomingGradient__handle__, weights__handle__, nsb_outputShape.GetHandle (), forwardConvolutionDescriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (incomingGradient);
			GC.KeepAlive (weights);
			GC.KeepAlive (forwardConvolutionDescriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("convolution2DDataGradientWithIncomingGradientTensor:weightsTensor:outputShapeTensor:forwardConvolutionDescriptor:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Convolution2DDataGradient (this MPSGraph This, MPSGraphTensor gradient, MPSGraphTensor weights, MPSGraphTensor outputShapeTensor, MPSGraphConvolution2DOpDescriptor forwardConvolutionDescriptor, string? name)
		{
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var weights__handle__ = weights!.GetNonNullHandle (nameof (weights));
			var outputShapeTensor__handle__ = outputShapeTensor!.GetNonNullHandle (nameof (outputShapeTensor));
			var forwardConvolutionDescriptor__handle__ = forwardConvolutionDescriptor!.GetNonNullHandle (nameof (forwardConvolutionDescriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("convolution2DDataGradientWithIncomingGradientTensor:weightsTensor:outputShapeTensor:forwardConvolutionDescriptor:name:"), gradient__handle__, weights__handle__, outputShapeTensor__handle__, forwardConvolutionDescriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradient);
			GC.KeepAlive (weights);
			GC.KeepAlive (outputShapeTensor);
			GC.KeepAlive (forwardConvolutionDescriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("convolution2DWeightsGradientWithIncomingGradientTensor:sourceTensor:outputShape:forwardConvolutionDescriptor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Convolution2DWeightsGradient (this MPSGraph This, MPSGraphTensor incomingGradient, MPSGraphTensor source, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] outputShape, MPSGraphConvolution2DOpDescriptor forwardConvolutionDescriptor, string? name)
		{
			var incomingGradient__handle__ = incomingGradient!.GetNonNullHandle (nameof (incomingGradient));
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			if (outputShape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (outputShape));
			var forwardConvolutionDescriptor__handle__ = forwardConvolutionDescriptor!.GetNonNullHandle (nameof (forwardConvolutionDescriptor));
			using var nsb_outputShape = NSArray.FromNSObjects (o => new NSNumber (o), outputShape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("convolution2DWeightsGradientWithIncomingGradientTensor:sourceTensor:outputShape:forwardConvolutionDescriptor:name:"), incomingGradient__handle__, source__handle__, nsb_outputShape.GetHandle (), forwardConvolutionDescriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (incomingGradient);
			GC.KeepAlive (source);
			GC.KeepAlive (forwardConvolutionDescriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("convolution2DWeightsGradientWithIncomingGradientTensor:sourceTensor:outputShapeTensor:forwardConvolutionDescriptor:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Convolution2DWeightsGradient (this MPSGraph This, MPSGraphTensor gradient, MPSGraphTensor source, MPSGraphTensor outputShapeTensor, MPSGraphConvolution2DOpDescriptor forwardConvolutionDescriptor, string? name)
		{
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var outputShapeTensor__handle__ = outputShapeTensor!.GetNonNullHandle (nameof (outputShapeTensor));
			var forwardConvolutionDescriptor__handle__ = forwardConvolutionDescriptor!.GetNonNullHandle (nameof (forwardConvolutionDescriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("convolution2DWeightsGradientWithIncomingGradientTensor:sourceTensor:outputShapeTensor:forwardConvolutionDescriptor:name:"), gradient__handle__, source__handle__, outputShapeTensor__handle__, forwardConvolutionDescriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradient);
			GC.KeepAlive (source);
			GC.KeepAlive (outputShapeTensor);
			GC.KeepAlive (forwardConvolutionDescriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("convolution3DWithSourceTensor:weightsTensor:descriptor:name:")]
		[SupportedOSPlatform ("tvos16.3")]
		[SupportedOSPlatform ("macos13.2")]
		[SupportedOSPlatform ("ios16.3")]
		[SupportedOSPlatform ("maccatalyst16.3")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Convolution3D (this MPSGraph This, MPSGraphTensor source, MPSGraphTensor weights, MPSGraphConvolution3DOpDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var weights__handle__ = weights!.GetNonNullHandle (nameof (weights));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("convolution3DWithSourceTensor:weightsTensor:descriptor:name:"), source__handle__, weights__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (weights);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("convolution3DDataGradientWithIncomingGradientTensor:weightsTensor:outputShape:forwardConvolutionDescriptor:name:")]
		[SupportedOSPlatform ("tvos16.3")]
		[SupportedOSPlatform ("macos13.2")]
		[SupportedOSPlatform ("ios16.3")]
		[SupportedOSPlatform ("maccatalyst16.3")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Convolution3DDataGradient (this MPSGraph This, MPSGraphTensor incomingGradient, MPSGraphTensor weights, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] outputShape, MPSGraphConvolution3DOpDescriptor forwardConvolutionDescriptor, string? name)
		{
			var incomingGradient__handle__ = incomingGradient!.GetNonNullHandle (nameof (incomingGradient));
			var weights__handle__ = weights!.GetNonNullHandle (nameof (weights));
			if (outputShape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (outputShape));
			var forwardConvolutionDescriptor__handle__ = forwardConvolutionDescriptor!.GetNonNullHandle (nameof (forwardConvolutionDescriptor));
			using var nsb_outputShape = NSArray.FromNSObjects (o => new NSNumber (o), outputShape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("convolution3DDataGradientWithIncomingGradientTensor:weightsTensor:outputShape:forwardConvolutionDescriptor:name:"), incomingGradient__handle__, weights__handle__, nsb_outputShape.GetHandle (), forwardConvolutionDescriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (incomingGradient);
			GC.KeepAlive (weights);
			GC.KeepAlive (forwardConvolutionDescriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("convolution3DDataGradientWithIncomingGradientTensor:weightsTensor:outputShapeTensor:forwardConvolutionDescriptor:name:")]
		[SupportedOSPlatform ("tvos16.3")]
		[SupportedOSPlatform ("macos13.2")]
		[SupportedOSPlatform ("ios16.3")]
		[SupportedOSPlatform ("maccatalyst16.3")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Convolution3DDataGradient (this MPSGraph This, MPSGraphTensor gradient, MPSGraphTensor weights, MPSGraphTensor outputShapeTensor, MPSGraphConvolution3DOpDescriptor forwardConvolutionDescriptor, string? name)
		{
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var weights__handle__ = weights!.GetNonNullHandle (nameof (weights));
			var outputShapeTensor__handle__ = outputShapeTensor!.GetNonNullHandle (nameof (outputShapeTensor));
			var forwardConvolutionDescriptor__handle__ = forwardConvolutionDescriptor!.GetNonNullHandle (nameof (forwardConvolutionDescriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("convolution3DDataGradientWithIncomingGradientTensor:weightsTensor:outputShapeTensor:forwardConvolutionDescriptor:name:"), gradient__handle__, weights__handle__, outputShapeTensor__handle__, forwardConvolutionDescriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradient);
			GC.KeepAlive (weights);
			GC.KeepAlive (outputShapeTensor);
			GC.KeepAlive (forwardConvolutionDescriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("convolution3DWeightsGradientWithIncomingGradientTensor:sourceTensor:outputShape:forwardConvolutionDescriptor:name:")]
		[SupportedOSPlatform ("tvos16.3")]
		[SupportedOSPlatform ("macos13.2")]
		[SupportedOSPlatform ("ios16.3")]
		[SupportedOSPlatform ("maccatalyst16.3")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Convolution3DWeightsGradient (this MPSGraph This, MPSGraphTensor incomingGradient, MPSGraphTensor source, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] outputShape, MPSGraphConvolution3DOpDescriptor forwardConvolutionDescriptor, string? name)
		{
			var incomingGradient__handle__ = incomingGradient!.GetNonNullHandle (nameof (incomingGradient));
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			if (outputShape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (outputShape));
			var forwardConvolutionDescriptor__handle__ = forwardConvolutionDescriptor!.GetNonNullHandle (nameof (forwardConvolutionDescriptor));
			using var nsb_outputShape = NSArray.FromNSObjects (o => new NSNumber (o), outputShape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("convolution3DWeightsGradientWithIncomingGradientTensor:sourceTensor:outputShape:forwardConvolutionDescriptor:name:"), incomingGradient__handle__, source__handle__, nsb_outputShape.GetHandle (), forwardConvolutionDescriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (incomingGradient);
			GC.KeepAlive (source);
			GC.KeepAlive (forwardConvolutionDescriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("convolution3DWeightsGradientWithIncomingGradientTensor:sourceTensor:outputShapeTensor:forwardConvolutionDescriptor:name:")]
		[SupportedOSPlatform ("tvos16.3")]
		[SupportedOSPlatform ("macos13.2")]
		[SupportedOSPlatform ("ios16.3")]
		[SupportedOSPlatform ("maccatalyst16.3")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Convolution3DWeightsGradient (this MPSGraph This, MPSGraphTensor gradient, MPSGraphTensor source, MPSGraphTensor outputShapeTensor, MPSGraphConvolution3DOpDescriptor forwardConvolutionDescriptor, string? name)
		{
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var outputShapeTensor__handle__ = outputShapeTensor!.GetNonNullHandle (nameof (outputShapeTensor));
			var forwardConvolutionDescriptor__handle__ = forwardConvolutionDescriptor!.GetNonNullHandle (nameof (forwardConvolutionDescriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("convolution3DWeightsGradientWithIncomingGradientTensor:sourceTensor:outputShapeTensor:forwardConvolutionDescriptor:name:"), gradient__handle__, source__handle__, outputShapeTensor__handle__, forwardConvolutionDescriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradient);
			GC.KeepAlive (source);
			GC.KeepAlive (outputShapeTensor);
			GC.KeepAlive (forwardConvolutionDescriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphConvolutionOps */
}
