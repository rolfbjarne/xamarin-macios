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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace MetalPerformanceShadersGraph {
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	public unsafe static partial class MPSGraph_MPSGraphFourierTransformOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("fastFourierTransformWithTensor:axes:descriptor:name:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor FastFourierTransform (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] axes, MPSGraphFftDescriptor descriptor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			if (axes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (axes));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			using var nsb_axes = NSArray.FromNSObjects (o => new NSNumber (o), axes);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fastFourierTransformWithTensor:axes:descriptor:name:"), tensor__handle__, nsb_axes.GetHandle (), descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("fastFourierTransformWithTensor:axesTensor:descriptor:name:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor FastFourierTransform (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor axesTensor, MPSGraphFftDescriptor descriptor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var axesTensor__handle__ = axesTensor!.GetNonNullHandle (nameof (axesTensor));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fastFourierTransformWithTensor:axesTensor:descriptor:name:"), tensor__handle__, axesTensor__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (axesTensor);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("HermiteanToRealFFTWithTensor:axes:descriptor:name:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor HermiteanToRealFft (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] axes, MPSGraphFftDescriptor descriptor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			if (axes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (axes));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			using var nsb_axes = NSArray.FromNSObjects (o => new NSNumber (o), axes);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("HermiteanToRealFFTWithTensor:axes:descriptor:name:"), tensor__handle__, nsb_axes.GetHandle (), descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("HermiteanToRealFFTWithTensor:axesTensor:descriptor:name:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor HermiteanToRealFft (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor axesTensor, MPSGraphFftDescriptor descriptor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var axesTensor__handle__ = axesTensor!.GetNonNullHandle (nameof (axesTensor));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("HermiteanToRealFFTWithTensor:axesTensor:descriptor:name:"), tensor__handle__, axesTensor__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (axesTensor);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("realToHermiteanFFTWithTensor:axes:descriptor:name:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor RealToHermiteanFft (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] axes, MPSGraphFftDescriptor descriptor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			if (axes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (axes));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			using var nsb_axes = NSArray.FromNSObjects (o => new NSNumber (o), axes);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("realToHermiteanFFTWithTensor:axes:descriptor:name:"), tensor__handle__, nsb_axes.GetHandle (), descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("realToHermiteanFFTWithTensor:axesTensor:descriptor:name:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor RealToHermiteanFft (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor axesTensor, MPSGraphFftDescriptor descriptor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var axesTensor__handle__ = axesTensor!.GetNonNullHandle (nameof (axesTensor));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("realToHermiteanFFTWithTensor:axesTensor:descriptor:name:"), tensor__handle__, axesTensor__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (axesTensor);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphFourierTransformOps */
}
