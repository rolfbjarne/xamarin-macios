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
	public unsafe static partial class MPSGraph_MPSGraphPoolingOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("avgPooling2DWithSourceTensor:descriptor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor AvgPooling2D (this MPSGraph This, MPSGraphTensor source, MPSGraphPooling2DOpDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("avgPooling2DWithSourceTensor:descriptor:name:"), source__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("avgPooling2DGradientWithGradientTensor:sourceTensor:descriptor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor AvgPooling2DGradient (this MPSGraph This, MPSGraphTensor gradient, MPSGraphTensor source, MPSGraphPooling2DOpDescriptor descriptor, string? name)
		{
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("avgPooling2DGradientWithGradientTensor:sourceTensor:descriptor:name:"), gradient__handle__, source__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradient);
			GC.KeepAlive (source);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("avgPooling4DWithSourceTensor:descriptor:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor AvgPooling4D (this MPSGraph This, MPSGraphTensor source, MPSGraphPooling4DOpDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("avgPooling4DWithSourceTensor:descriptor:name:"), source__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("avgPooling4DGradientWithGradientTensor:sourceTensor:descriptor:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor AvgPooling4DGradient (this MPSGraph This, MPSGraphTensor gradient, MPSGraphTensor source, MPSGraphPooling4DOpDescriptor descriptor, string? name)
		{
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("avgPooling4DGradientWithGradientTensor:sourceTensor:descriptor:name:"), gradient__handle__, source__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradient);
			GC.KeepAlive (source);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("L2NormPooling4DWithSourceTensor:descriptor:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor L2NormPooling4D (this MPSGraph This, MPSGraphTensor source, MPSGraphPooling4DOpDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("L2NormPooling4DWithSourceTensor:descriptor:name:"), source__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("L2NormPooling4DGradientWithGradientTensor:sourceTensor:descriptor:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor L2NormPooling4DGradient (this MPSGraph This, MPSGraphTensor gradient, MPSGraphTensor source, MPSGraphPooling4DOpDescriptor descriptor, string? name)
		{
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("L2NormPooling4DGradientWithGradientTensor:sourceTensor:descriptor:name:"), gradient__handle__, source__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradient);
			GC.KeepAlive (source);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("maxPooling2DWithSourceTensor:descriptor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor MaxPooling2D (this MPSGraph This, MPSGraphTensor source, MPSGraphPooling2DOpDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("maxPooling2DWithSourceTensor:descriptor:name:"), source__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("maxPooling2DGradientWithGradientTensor:sourceTensor:descriptor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor MaxPooling2DGradient (this MPSGraph This, MPSGraphTensor gradient, MPSGraphTensor source, MPSGraphPooling2DOpDescriptor descriptor, string? name)
		{
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("maxPooling2DGradientWithGradientTensor:sourceTensor:descriptor:name:"), gradient__handle__, source__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradient);
			GC.KeepAlive (source);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("maxPooling2DGradientWithGradientTensor:indicesTensor:outputShape:descriptor:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor MaxPooling2DGradient (this MPSGraph This, MPSGraphTensor gradient, MPSGraphTensor indices, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] outputShape, MPSGraphPooling2DOpDescriptor descriptor, string? name)
		{
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var indices__handle__ = indices!.GetNonNullHandle (nameof (indices));
			if (outputShape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (outputShape));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			using var nsb_outputShape = NSArray.FromNSObjects (o => new NSNumber (o), outputShape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("maxPooling2DGradientWithGradientTensor:indicesTensor:outputShape:descriptor:name:"), gradient__handle__, indices__handle__, nsb_outputShape.GetHandle (), descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradient);
			GC.KeepAlive (indices);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("maxPooling2DGradientWithGradientTensor:indicesTensor:outputShapeTensor:descriptor:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor MaxPooling2DGradient (this MPSGraph This, MPSGraphTensor gradient, MPSGraphTensor indices, MPSGraphTensor outputShape, MPSGraphPooling2DOpDescriptor descriptor, string? name)
		{
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var indices__handle__ = indices!.GetNonNullHandle (nameof (indices));
			var outputShape__handle__ = outputShape!.GetNonNullHandle (nameof (outputShape));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("maxPooling2DGradientWithGradientTensor:indicesTensor:outputShapeTensor:descriptor:name:"), gradient__handle__, indices__handle__, outputShape__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradient);
			GC.KeepAlive (indices);
			GC.KeepAlive (outputShape);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("maxPooling2DReturnIndicesWithSourceTensor:descriptor:name:")]
		[SupportedOSPlatform ("tvos15.3")]
		[SupportedOSPlatform ("macos12.2")]
		[SupportedOSPlatform ("ios15.3")]
		[SupportedOSPlatform ("maccatalyst15.3")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] MaxPooling2DReturnIndices (this MPSGraph This, MPSGraphTensor source, MPSGraphPooling2DOpDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("maxPooling2DReturnIndicesWithSourceTensor:descriptor:name:"), source__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("maxPooling4DWithSourceTensor:descriptor:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor MaxPooling4D (this MPSGraph This, MPSGraphTensor source, MPSGraphPooling4DOpDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("maxPooling4DWithSourceTensor:descriptor:name:"), source__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("maxPooling4DGradientWithGradientTensor:sourceTensor:descriptor:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor MaxPooling4DGradient (this MPSGraph This, MPSGraphTensor gradient, MPSGraphTensor source, MPSGraphPooling4DOpDescriptor descriptor, string? name)
		{
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("maxPooling4DGradientWithGradientTensor:sourceTensor:descriptor:name:"), gradient__handle__, source__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradient);
			GC.KeepAlive (source);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("maxPooling4DGradientWithGradientTensor:indicesTensor:outputShape:descriptor:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor MaxPooling4DGradient (this MPSGraph This, MPSGraphTensor gradient, MPSGraphTensor indices, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] outputShape, MPSGraphPooling4DOpDescriptor descriptor, string? name)
		{
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var indices__handle__ = indices!.GetNonNullHandle (nameof (indices));
			if (outputShape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (outputShape));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			using var nsb_outputShape = NSArray.FromNSObjects (o => new NSNumber (o), outputShape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("maxPooling4DGradientWithGradientTensor:indicesTensor:outputShape:descriptor:name:"), gradient__handle__, indices__handle__, nsb_outputShape.GetHandle (), descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradient);
			GC.KeepAlive (indices);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("maxPooling4DGradientWithGradientTensor:indicesTensor:outputShapeTensor:descriptor:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor MaxPooling4DGradient (this MPSGraph This, MPSGraphTensor gradient, MPSGraphTensor indices, MPSGraphTensor outputShape, MPSGraphPooling4DOpDescriptor descriptor, string? name)
		{
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var indices__handle__ = indices!.GetNonNullHandle (nameof (indices));
			var outputShape__handle__ = outputShape!.GetNonNullHandle (nameof (outputShape));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("maxPooling4DGradientWithGradientTensor:indicesTensor:outputShapeTensor:descriptor:name:"), gradient__handle__, indices__handle__, outputShape__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradient);
			GC.KeepAlive (indices);
			GC.KeepAlive (outputShape);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("maxPooling4DReturnIndicesWithSourceTensor:descriptor:name:")]
		[SupportedOSPlatform ("tvos15.3")]
		[SupportedOSPlatform ("macos12.2")]
		[SupportedOSPlatform ("ios15.3")]
		[SupportedOSPlatform ("maccatalyst15.3")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] MaxPooling4DReturnIndices (this MPSGraph This, MPSGraphTensor source, MPSGraphPooling4DOpDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("maxPooling4DReturnIndicesWithSourceTensor:descriptor:name:"), source__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphPoolingOps */
}
