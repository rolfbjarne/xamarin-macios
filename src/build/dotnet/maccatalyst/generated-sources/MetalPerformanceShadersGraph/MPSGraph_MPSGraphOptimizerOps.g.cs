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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
	public unsafe static partial class MPSGraph_MPSGraphOptimizerOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("adamWithLearningRateTensor:beta1Tensor:beta2Tensor:epsilonTensor:beta1PowerTensor:beta2PowerTensor:valuesTensor:momentumTensor:velocityTensor:maximumVelocityTensor:gradientTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] Adam (this MPSGraph This, MPSGraphTensor learningRateTensor, MPSGraphTensor beta1Tensor, MPSGraphTensor beta2Tensor, MPSGraphTensor epsilonTensor, MPSGraphTensor beta1PowerTensor, MPSGraphTensor beta2PowerTensor, MPSGraphTensor valuesTensor, MPSGraphTensor momentumTensor, MPSGraphTensor velocityTensor, MPSGraphTensor? maximumVelocityTensor, MPSGraphTensor gradientTensor, string? name)
		{
			var learningRateTensor__handle__ = learningRateTensor!.GetNonNullHandle (nameof (learningRateTensor));
			var beta1Tensor__handle__ = beta1Tensor!.GetNonNullHandle (nameof (beta1Tensor));
			var beta2Tensor__handle__ = beta2Tensor!.GetNonNullHandle (nameof (beta2Tensor));
			var epsilonTensor__handle__ = epsilonTensor!.GetNonNullHandle (nameof (epsilonTensor));
			var beta1PowerTensor__handle__ = beta1PowerTensor!.GetNonNullHandle (nameof (beta1PowerTensor));
			var beta2PowerTensor__handle__ = beta2PowerTensor!.GetNonNullHandle (nameof (beta2PowerTensor));
			var valuesTensor__handle__ = valuesTensor!.GetNonNullHandle (nameof (valuesTensor));
			var momentumTensor__handle__ = momentumTensor!.GetNonNullHandle (nameof (momentumTensor));
			var velocityTensor__handle__ = velocityTensor!.GetNonNullHandle (nameof (velocityTensor));
			var maximumVelocityTensor__handle__ = maximumVelocityTensor.GetHandle ();
			var gradientTensor__handle__ = gradientTensor!.GetNonNullHandle (nameof (gradientTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("adamWithLearningRateTensor:beta1Tensor:beta2Tensor:epsilonTensor:beta1PowerTensor:beta2PowerTensor:valuesTensor:momentumTensor:velocityTensor:maximumVelocityTensor:gradientTensor:name:"), learningRateTensor__handle__, beta1Tensor__handle__, beta2Tensor__handle__, epsilonTensor__handle__, beta1PowerTensor__handle__, beta2PowerTensor__handle__, valuesTensor__handle__, momentumTensor__handle__, velocityTensor__handle__, maximumVelocityTensor__handle__, gradientTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (learningRateTensor);
			GC.KeepAlive (beta1Tensor);
			GC.KeepAlive (beta2Tensor);
			GC.KeepAlive (epsilonTensor);
			GC.KeepAlive (beta1PowerTensor);
			GC.KeepAlive (beta2PowerTensor);
			GC.KeepAlive (valuesTensor);
			GC.KeepAlive (momentumTensor);
			GC.KeepAlive (velocityTensor);
			GC.KeepAlive (maximumVelocityTensor);
			GC.KeepAlive (gradientTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("adamWithCurrentLearningRateTensor:beta1Tensor:beta2Tensor:epsilonTensor:valuesTensor:momentumTensor:velocityTensor:maximumVelocityTensor:gradientTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] Adam (this MPSGraph This, MPSGraphTensor currentLearningRateTensor, MPSGraphTensor beta1Tensor, MPSGraphTensor beta2Tensor, MPSGraphTensor epsilonTensor, MPSGraphTensor valuesTensor, MPSGraphTensor momentumTensor, MPSGraphTensor velocityTensor, MPSGraphTensor? maximumVelocityTensor, MPSGraphTensor gradientTensor, string? name)
		{
			var currentLearningRateTensor__handle__ = currentLearningRateTensor!.GetNonNullHandle (nameof (currentLearningRateTensor));
			var beta1Tensor__handle__ = beta1Tensor!.GetNonNullHandle (nameof (beta1Tensor));
			var beta2Tensor__handle__ = beta2Tensor!.GetNonNullHandle (nameof (beta2Tensor));
			var epsilonTensor__handle__ = epsilonTensor!.GetNonNullHandle (nameof (epsilonTensor));
			var valuesTensor__handle__ = valuesTensor!.GetNonNullHandle (nameof (valuesTensor));
			var momentumTensor__handle__ = momentumTensor!.GetNonNullHandle (nameof (momentumTensor));
			var velocityTensor__handle__ = velocityTensor!.GetNonNullHandle (nameof (velocityTensor));
			var maximumVelocityTensor__handle__ = maximumVelocityTensor.GetHandle ();
			var gradientTensor__handle__ = gradientTensor!.GetNonNullHandle (nameof (gradientTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("adamWithCurrentLearningRateTensor:beta1Tensor:beta2Tensor:epsilonTensor:valuesTensor:momentumTensor:velocityTensor:maximumVelocityTensor:gradientTensor:name:"), currentLearningRateTensor__handle__, beta1Tensor__handle__, beta2Tensor__handle__, epsilonTensor__handle__, valuesTensor__handle__, momentumTensor__handle__, velocityTensor__handle__, maximumVelocityTensor__handle__, gradientTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (currentLearningRateTensor);
			GC.KeepAlive (beta1Tensor);
			GC.KeepAlive (beta2Tensor);
			GC.KeepAlive (epsilonTensor);
			GC.KeepAlive (valuesTensor);
			GC.KeepAlive (momentumTensor);
			GC.KeepAlive (velocityTensor);
			GC.KeepAlive (maximumVelocityTensor);
			GC.KeepAlive (gradientTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("applyStochasticGradientDescentWithLearningRateTensor:variable:gradientTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphOperation ApplyStochasticGradientDescent (this MPSGraph This, MPSGraphTensor learningRate, MPSGraphVariableOp variable, MPSGraphTensor gradient, string? name)
		{
			var learningRate__handle__ = learningRate!.GetNonNullHandle (nameof (learningRate));
			var variable__handle__ = variable!.GetNonNullHandle (nameof (variable));
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var nsname = CFString.CreateNative (name);
			MPSGraphOperation? ret;
			ret =  Runtime.GetNSObject<MPSGraphOperation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("applyStochasticGradientDescentWithLearningRateTensor:variable:gradientTensor:name:"), learningRate__handle__, variable__handle__, gradient__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (learningRate);
			GC.KeepAlive (variable);
			GC.KeepAlive (gradient);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("stochasticGradientDescentWithLearningRateTensor:valuesTensor:gradientTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor StochasticGradientDescent (this MPSGraph This, MPSGraphTensor learningRate, MPSGraphTensor values, MPSGraphTensor gradient, string? name)
		{
			var learningRate__handle__ = learningRate!.GetNonNullHandle (nameof (learningRate));
			var values__handle__ = values!.GetNonNullHandle (nameof (values));
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("stochasticGradientDescentWithLearningRateTensor:valuesTensor:gradientTensor:name:"), learningRate__handle__, values__handle__, gradient__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (learningRate);
			GC.KeepAlive (values);
			GC.KeepAlive (gradient);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphOptimizerOps */
}
