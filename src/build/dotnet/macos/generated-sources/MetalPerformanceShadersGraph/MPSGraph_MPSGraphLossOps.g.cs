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
	public unsafe static partial class MPSGraph_MPSGraphLossOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSoftMaxCrossEntropyGradientWithIncomingGradientTensor_SourceTensor_LabelsTensor_Axis_ReductionType_Name_X = "softMaxCrossEntropyGradientWithIncomingGradientTensor:sourceTensor:labelsTensor:axis:reductionType:name:";
		static readonly NativeHandle selSoftMaxCrossEntropyGradientWithIncomingGradientTensor_SourceTensor_LabelsTensor_Axis_ReductionType_Name_XHandle = Selector.GetHandle ("softMaxCrossEntropyGradientWithIncomingGradientTensor:sourceTensor:labelsTensor:axis:reductionType:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSoftMaxCrossEntropyWithSourceTensor_LabelsTensor_Axis_ReductionType_Name_X = "softMaxCrossEntropyWithSourceTensor:labelsTensor:axis:reductionType:name:";
		static readonly NativeHandle selSoftMaxCrossEntropyWithSourceTensor_LabelsTensor_Axis_ReductionType_Name_XHandle = Selector.GetHandle ("softMaxCrossEntropyWithSourceTensor:labelsTensor:axis:reductionType:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("softMaxCrossEntropyWithSourceTensor:labelsTensor:axis:reductionType:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor SoftMaxCrossEntropy (this MPSGraph This, MPSGraphTensor source, MPSGraphTensor labels, nint axis, MPSGraphLossReductionType reductionType, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var labels__handle__ = labels!.GetNonNullHandle (nameof (labels));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr_UInt64_NativeHandle (This.Handle, selSoftMaxCrossEntropyWithSourceTensor_LabelsTensor_Axis_ReductionType_Name_XHandle, source__handle__, labels__handle__, axis, (UInt64)reductionType, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (labels);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("softMaxCrossEntropyGradientWithIncomingGradientTensor:sourceTensor:labelsTensor:axis:reductionType:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor SoftMaxCrossEntropyGradient (this MPSGraph This, MPSGraphTensor gradientTensor, MPSGraphTensor sourceTensor, MPSGraphTensor labelsTensor, nint axis, MPSGraphLossReductionType reductionType, string? name)
		{
			var gradientTensor__handle__ = gradientTensor!.GetNonNullHandle (nameof (gradientTensor));
			var sourceTensor__handle__ = sourceTensor!.GetNonNullHandle (nameof (sourceTensor));
			var labelsTensor__handle__ = labelsTensor!.GetNonNullHandle (nameof (labelsTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr_UInt64_NativeHandle (This.Handle, selSoftMaxCrossEntropyGradientWithIncomingGradientTensor_SourceTensor_LabelsTensor_Axis_ReductionType_Name_XHandle, gradientTensor__handle__, sourceTensor__handle__, labelsTensor__handle__, axis, (UInt64)reductionType, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradientTensor);
			GC.KeepAlive (sourceTensor);
			GC.KeepAlive (labelsTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphLossOps */
}
