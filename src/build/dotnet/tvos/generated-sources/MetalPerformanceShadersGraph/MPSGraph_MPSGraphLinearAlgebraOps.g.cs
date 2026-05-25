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
	[SupportedOSPlatform ("tvos15.4")]
	[SupportedOSPlatform ("macos12.3")]
	[SupportedOSPlatform ("ios15.4")]
	[SupportedOSPlatform ("maccatalyst15.4")]
	public unsafe static partial class MPSGraph_MPSGraphLinearAlgebraOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("bandPartWithTensor:numLower:numUpper:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor BandPart (this MPSGraph This, MPSGraphTensor inputTensor, nint numLower, nint numUpper, string? name)
		{
			var inputTensor__handle__ = inputTensor!.GetNonNullHandle (nameof (inputTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("bandPartWithTensor:numLower:numUpper:name:"), inputTensor__handle__, numLower, numUpper, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (inputTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("bandPartWithTensor:numLowerTensor:numUpperTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor BandPart (this MPSGraph This, MPSGraphTensor inputTensor, MPSGraphTensor numLowerTensor, MPSGraphTensor numUpperTensor, string? name)
		{
			var inputTensor__handle__ = inputTensor!.GetNonNullHandle (nameof (inputTensor));
			var numLowerTensor__handle__ = numLowerTensor!.GetNonNullHandle (nameof (numLowerTensor));
			var numUpperTensor__handle__ = numUpperTensor!.GetNonNullHandle (nameof (numUpperTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("bandPartWithTensor:numLowerTensor:numUpperTensor:name:"), inputTensor__handle__, numLowerTensor__handle__, numUpperTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (inputTensor);
			GC.KeepAlive (numLowerTensor);
			GC.KeepAlive (numUpperTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphLinearAlgebraOps */
}
