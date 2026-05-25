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
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class MPSGraph_MPSGraphGradientOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("gradientForPrimaryTensor:withTensors:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary<MPSGraphTensor, MPSGraphTensor> Gradients (this MPSGraph This, MPSGraphTensor of, MPSGraphTensor[] with, string? name)
		{
			var of__handle__ = of!.GetNonNullHandle (nameof (of));
			if (with is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (with));
			using var nsa_with = NSArray.FromNSObjects (with);
			var nsname = CFString.CreateNative (name);
			NSDictionary<MPSGraphTensor, MPSGraphTensor>? ret;
			ret =  Runtime.GetNSObject<NSDictionary<MPSGraphTensor, MPSGraphTensor>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("gradientForPrimaryTensor:withTensors:name:"), of__handle__, nsa_with.Handle, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (of);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphGradientOps */
}
