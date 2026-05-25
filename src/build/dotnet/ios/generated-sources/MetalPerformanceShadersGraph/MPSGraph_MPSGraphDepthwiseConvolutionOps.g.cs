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
	public unsafe static partial class MPSGraph_MPSGraphDepthwiseConvolutionOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("depthwiseConvolution2DWithSourceTensor:weightsTensor:descriptor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor DepthwiseConvolution2D (this MPSGraph This, MPSGraphTensor source, MPSGraphTensor weights, MPSGraphDepthwiseConvolution2DOpDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var weights__handle__ = weights!.GetNonNullHandle (nameof (weights));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("depthwiseConvolution2DWithSourceTensor:weightsTensor:descriptor:name:"), source__handle__, weights__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (weights);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("depthwiseConvolution2DDataGradientWithIncomingGradientTensor:weightsTensor:outputShape:descriptor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor DepthwiseConvolution2DDataGradient (this MPSGraph This, MPSGraphTensor incomingGradient, MPSGraphTensor weights, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] outputShape, MPSGraphDepthwiseConvolution2DOpDescriptor descriptor, string? name)
		{
			var incomingGradient__handle__ = incomingGradient!.GetNonNullHandle (nameof (incomingGradient));
			var weights__handle__ = weights!.GetNonNullHandle (nameof (weights));
			if (outputShape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (outputShape));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			using var nsb_outputShape = NSArray.FromNSObjects (o => new NSNumber (o), outputShape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("depthwiseConvolution2DDataGradientWithIncomingGradientTensor:weightsTensor:outputShape:descriptor:name:"), incomingGradient__handle__, weights__handle__, nsb_outputShape.GetHandle (), descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (incomingGradient);
			GC.KeepAlive (weights);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("depthwiseConvolution2DWeightsGradientWithIncomingGradientTensor:sourceTensor:outputShape:descriptor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor DepthwiseConvolution2DWeightsGradient (this MPSGraph This, MPSGraphTensor incomingGradient, MPSGraphTensor source, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] outputShape, MPSGraphDepthwiseConvolution2DOpDescriptor descriptor, string? name)
		{
			var incomingGradient__handle__ = incomingGradient!.GetNonNullHandle (nameof (incomingGradient));
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			if (outputShape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (outputShape));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			using var nsb_outputShape = NSArray.FromNSObjects (o => new NSNumber (o), outputShape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("depthwiseConvolution2DWeightsGradientWithIncomingGradientTensor:sourceTensor:outputShape:descriptor:name:"), incomingGradient__handle__, source__handle__, nsb_outputShape.GetHandle (), descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (incomingGradient);
			GC.KeepAlive (source);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("depthwiseConvolution3DWithSourceTensor:weightsTensor:descriptor:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor DepthwiseConvolution3D (this MPSGraph This, MPSGraphTensor source, MPSGraphTensor weights, MPSGraphDepthwiseConvolution3DOpDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var weights__handle__ = weights!.GetNonNullHandle (nameof (weights));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("depthwiseConvolution3DWithSourceTensor:weightsTensor:descriptor:name:"), source__handle__, weights__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (weights);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("depthwiseConvolution3DDataGradientWithIncomingGradientTensor:weightsTensor:outputShape:descriptor:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor DepthwiseConvolution3DDataGradient (this MPSGraph This, MPSGraphTensor incomingGradient, MPSGraphTensor weights, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[]? outputShape, MPSGraphDepthwiseConvolution3DOpDescriptor descriptor, string? name)
		{
			var incomingGradient__handle__ = incomingGradient!.GetNonNullHandle (nameof (incomingGradient));
			var weights__handle__ = weights!.GetNonNullHandle (nameof (weights));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			using var nsb_outputShape = NSArray.FromNSObjects (o => new NSNumber (o), outputShape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("depthwiseConvolution3DDataGradientWithIncomingGradientTensor:weightsTensor:outputShape:descriptor:name:"), incomingGradient__handle__, weights__handle__, nsb_outputShape.GetHandle (), descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (incomingGradient);
			GC.KeepAlive (weights);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("depthwiseConvolution3DWeightsGradientWithIncomingGradientTensor:sourceTensor:outputShape:descriptor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor DepthwiseConvolution3DWeightsGradient (this MPSGraph This, MPSGraphTensor incomingGradient, MPSGraphTensor source, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] outputShape, MPSGraphDepthwiseConvolution3DOpDescriptor descriptor, string? name)
		{
			var incomingGradient__handle__ = incomingGradient!.GetNonNullHandle (nameof (incomingGradient));
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			if (outputShape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (outputShape));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			using var nsb_outputShape = NSArray.FromNSObjects (o => new NSNumber (o), outputShape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("depthwiseConvolution3DWeightsGradientWithIncomingGradientTensor:sourceTensor:outputShape:descriptor:name:"), incomingGradient__handle__, source__handle__, nsb_outputShape.GetHandle (), descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (incomingGradient);
			GC.KeepAlive (source);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphDepthwiseConvolutionOps */
}
