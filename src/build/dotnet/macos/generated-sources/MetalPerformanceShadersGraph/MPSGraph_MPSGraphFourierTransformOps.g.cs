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
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	public unsafe static partial class MPSGraph_MPSGraphFourierTransformOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHermiteanToRealFFTWithTensor_Axes_Descriptor_Name_X = "HermiteanToRealFFTWithTensor:axes:descriptor:name:";
		static readonly NativeHandle selHermiteanToRealFFTWithTensor_Axes_Descriptor_Name_XHandle = Selector.GetHandle ("HermiteanToRealFFTWithTensor:axes:descriptor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHermiteanToRealFFTWithTensor_AxesTensor_Descriptor_Name_X = "HermiteanToRealFFTWithTensor:axesTensor:descriptor:name:";
		static readonly NativeHandle selHermiteanToRealFFTWithTensor_AxesTensor_Descriptor_Name_XHandle = Selector.GetHandle ("HermiteanToRealFFTWithTensor:axesTensor:descriptor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFastFourierTransformWithTensor_Axes_Descriptor_Name_X = "fastFourierTransformWithTensor:axes:descriptor:name:";
		static readonly NativeHandle selFastFourierTransformWithTensor_Axes_Descriptor_Name_XHandle = Selector.GetHandle ("fastFourierTransformWithTensor:axes:descriptor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFastFourierTransformWithTensor_AxesTensor_Descriptor_Name_X = "fastFourierTransformWithTensor:axesTensor:descriptor:name:";
		static readonly NativeHandle selFastFourierTransformWithTensor_AxesTensor_Descriptor_Name_XHandle = Selector.GetHandle ("fastFourierTransformWithTensor:axesTensor:descriptor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRealToHermiteanFFTWithTensor_Axes_Descriptor_Name_X = "realToHermiteanFFTWithTensor:axes:descriptor:name:";
		static readonly NativeHandle selRealToHermiteanFFTWithTensor_Axes_Descriptor_Name_XHandle = Selector.GetHandle ("realToHermiteanFFTWithTensor:axes:descriptor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRealToHermiteanFFTWithTensor_AxesTensor_Descriptor_Name_X = "realToHermiteanFFTWithTensor:axesTensor:descriptor:name:";
		static readonly NativeHandle selRealToHermiteanFFTWithTensor_AxesTensor_Descriptor_Name_XHandle = Selector.GetHandle ("realToHermiteanFFTWithTensor:axesTensor:descriptor:name:");
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, selFastFourierTransformWithTensor_Axes_Descriptor_Name_XHandle, tensor__handle__, nsb_axes.GetHandle (), descriptor__handle__, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, selFastFourierTransformWithTensor_AxesTensor_Descriptor_Name_XHandle, tensor__handle__, axesTensor__handle__, descriptor__handle__, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, selHermiteanToRealFFTWithTensor_Axes_Descriptor_Name_XHandle, tensor__handle__, nsb_axes.GetHandle (), descriptor__handle__, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, selHermiteanToRealFFTWithTensor_AxesTensor_Descriptor_Name_XHandle, tensor__handle__, axesTensor__handle__, descriptor__handle__, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, selRealToHermiteanFFTWithTensor_Axes_Descriptor_Name_XHandle, tensor__handle__, nsb_axes.GetHandle (), descriptor__handle__, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, selRealToHermiteanFFTWithTensor_AxesTensor_Descriptor_Name_XHandle, tensor__handle__, axesTensor__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (axesTensor);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphFourierTransformOps */
}
