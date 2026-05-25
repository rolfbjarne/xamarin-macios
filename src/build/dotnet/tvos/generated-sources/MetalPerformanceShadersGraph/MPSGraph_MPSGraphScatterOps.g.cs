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
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class MPSGraph_MPSGraphScatterOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("scatterWithUpdatesTensor:indicesTensor:shape:axis:mode:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Scatter (this MPSGraph This, MPSGraphTensor updatesTensor, MPSGraphTensor indicesTensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] shape, nint axis, MPSGraphScatterMode mode, string? name)
		{
			var updatesTensor__handle__ = updatesTensor!.GetNonNullHandle (nameof (updatesTensor));
			var indicesTensor__handle__ = indicesTensor!.GetNonNullHandle (nameof (indicesTensor));
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("scatterWithUpdatesTensor:indicesTensor:shape:axis:mode:name:"), updatesTensor__handle__, indicesTensor__handle__, nsb_shape.GetHandle (), axis, (IntPtr) (long) mode, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (updatesTensor);
			GC.KeepAlive (indicesTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("scatterWithDataTensor:updatesTensor:indicesTensor:axis:mode:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Scatter (this MPSGraph This, MPSGraphTensor dataTensor, MPSGraphTensor updatesTensor, MPSGraphTensor indicesTensor, nint axis, MPSGraphScatterMode mode, string? name)
		{
			var dataTensor__handle__ = dataTensor!.GetNonNullHandle (nameof (dataTensor));
			var updatesTensor__handle__ = updatesTensor!.GetNonNullHandle (nameof (updatesTensor));
			var indicesTensor__handle__ = indicesTensor!.GetNonNullHandle (nameof (indicesTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("scatterWithDataTensor:updatesTensor:indicesTensor:axis:mode:name:"), dataTensor__handle__, updatesTensor__handle__, indicesTensor__handle__, axis, (IntPtr) (long) mode, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (dataTensor);
			GC.KeepAlive (updatesTensor);
			GC.KeepAlive (indicesTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphScatterOps */
}
