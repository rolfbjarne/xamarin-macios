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
	public unsafe static partial class MPSGraph_MPSGraphActivationOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("leakyReLUWithTensor:alpha:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor LeakyReLU (this MPSGraph This, MPSGraphTensor tensor, double alpha, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_Double_NativeHandle (This.Handle, Selector.GetHandle ("leakyReLUWithTensor:alpha:name:"), tensor__handle__, alpha, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("leakyReLUWithTensor:alphaTensor:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor LeakyReLU (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor alphaTensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var alphaTensor__handle__ = alphaTensor!.GetNonNullHandle (nameof (alphaTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("leakyReLUWithTensor:alphaTensor:name:"), tensor__handle__, alphaTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (alphaTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("leakyReLUGradientWithIncomingGradient:sourceTensor:alphaTensor:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor LeakyReLUGradient (this MPSGraph This, MPSGraphTensor gradient, MPSGraphTensor source, MPSGraphTensor alphaTensor, string? name)
		{
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var alphaTensor__handle__ = alphaTensor!.GetNonNullHandle (nameof (alphaTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("leakyReLUGradientWithIncomingGradient:sourceTensor:alphaTensor:name:"), gradient__handle__, source__handle__, alphaTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradient);
			GC.KeepAlive (source);
			GC.KeepAlive (alphaTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reLUWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ReLU (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("reLUWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reLUGradientWithIncomingGradient:sourceTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ReLUGradient (this MPSGraph This, MPSGraphTensor gradient, MPSGraphTensor source, string? name)
		{
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("reLUGradientWithIncomingGradient:sourceTensor:name:"), gradient__handle__, source__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradient);
			GC.KeepAlive (source);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sigmoidWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Sigmoid (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sigmoidWithTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sigmoidGradientWithIncomingGradient:sourceTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor SigmoidGradient (this MPSGraph This, MPSGraphTensor gradient, MPSGraphTensor source, string? name)
		{
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sigmoidGradientWithIncomingGradient:sourceTensor:name:"), gradient__handle__, source__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradient);
			GC.KeepAlive (source);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("softMaxWithTensor:axis:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor SoftMax (this MPSGraph This, MPSGraphTensor tensor, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("softMaxWithTensor:axis:name:"), tensor__handle__, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("softMaxGradientWithIncomingGradient:sourceTensor:axis:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor SoftMaxGradient (this MPSGraph This, MPSGraphTensor gradient, MPSGraphTensor source, nint axis, string? name)
		{
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("softMaxGradientWithIncomingGradient:sourceTensor:axis:name:"), gradient__handle__, source__handle__, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradient);
			GC.KeepAlive (source);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphActivationOps */
}
