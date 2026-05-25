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
	public unsafe static partial class MPSGraph_MPSGraphActivationOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLeakyReLUGradientWithIncomingGradient_SourceTensor_AlphaTensor_Name_X = "leakyReLUGradientWithIncomingGradient:sourceTensor:alphaTensor:name:";
		static readonly NativeHandle selLeakyReLUGradientWithIncomingGradient_SourceTensor_AlphaTensor_Name_XHandle = Selector.GetHandle ("leakyReLUGradientWithIncomingGradient:sourceTensor:alphaTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLeakyReLUWithTensor_Alpha_Name_X = "leakyReLUWithTensor:alpha:name:";
		static readonly NativeHandle selLeakyReLUWithTensor_Alpha_Name_XHandle = Selector.GetHandle ("leakyReLUWithTensor:alpha:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLeakyReLUWithTensor_AlphaTensor_Name_X = "leakyReLUWithTensor:alphaTensor:name:";
		static readonly NativeHandle selLeakyReLUWithTensor_AlphaTensor_Name_XHandle = Selector.GetHandle ("leakyReLUWithTensor:alphaTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReLUGradientWithIncomingGradient_SourceTensor_Name_X = "reLUGradientWithIncomingGradient:sourceTensor:name:";
		static readonly NativeHandle selReLUGradientWithIncomingGradient_SourceTensor_Name_XHandle = Selector.GetHandle ("reLUGradientWithIncomingGradient:sourceTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReLUWithTensor_Name_X = "reLUWithTensor:name:";
		static readonly NativeHandle selReLUWithTensor_Name_XHandle = Selector.GetHandle ("reLUWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSigmoidGradientWithIncomingGradient_SourceTensor_Name_X = "sigmoidGradientWithIncomingGradient:sourceTensor:name:";
		static readonly NativeHandle selSigmoidGradientWithIncomingGradient_SourceTensor_Name_XHandle = Selector.GetHandle ("sigmoidGradientWithIncomingGradient:sourceTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSigmoidWithTensor_Name_X = "sigmoidWithTensor:name:";
		static readonly NativeHandle selSigmoidWithTensor_Name_XHandle = Selector.GetHandle ("sigmoidWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSoftMaxGradientWithIncomingGradient_SourceTensor_Axis_Name_X = "softMaxGradientWithIncomingGradient:sourceTensor:axis:name:";
		static readonly NativeHandle selSoftMaxGradientWithIncomingGradient_SourceTensor_Axis_Name_XHandle = Selector.GetHandle ("softMaxGradientWithIncomingGradient:sourceTensor:axis:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSoftMaxWithTensor_Axis_Name_X = "softMaxWithTensor:axis:name:";
		static readonly NativeHandle selSoftMaxWithTensor_Axis_Name_XHandle = Selector.GetHandle ("softMaxWithTensor:axis:name:");
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_Double_NativeHandle (This.Handle, selLeakyReLUWithTensor_Alpha_Name_XHandle, tensor__handle__, alpha, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selLeakyReLUWithTensor_AlphaTensor_Name_XHandle, tensor__handle__, alphaTensor__handle__, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, selLeakyReLUGradientWithIncomingGradient_SourceTensor_AlphaTensor_Name_XHandle, gradient__handle__, source__handle__, alphaTensor__handle__, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selReLUWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selReLUGradientWithIncomingGradient_SourceTensor_Name_XHandle, gradient__handle__, source__handle__, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selSigmoidWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selSigmoidGradientWithIncomingGradient_SourceTensor_Name_XHandle, gradient__handle__, source__handle__, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, selSoftMaxWithTensor_Axis_Name_XHandle, tensor__handle__, axis, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle (This.Handle, selSoftMaxGradientWithIncomingGradient_SourceTensor_Axis_Name_XHandle, gradient__handle__, source__handle__, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradient);
			GC.KeepAlive (source);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphActivationOps */
}
