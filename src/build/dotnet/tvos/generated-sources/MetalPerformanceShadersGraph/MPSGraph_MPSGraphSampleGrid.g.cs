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
	public unsafe static partial class MPSGraph_MPSGraphSampleGrid  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("sampleGridWithSourceTensor:coordinateTensor:layout:normalizeCoordinates:relativeCoordinates:alignCorners:paddingMode:samplingMode:constantValue:name:")]
		[SupportedOSPlatform ("tvos16.2")]
		[SupportedOSPlatform ("macos13.1")]
		[SupportedOSPlatform ("ios16.2")]
		[SupportedOSPlatform ("maccatalyst16.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor SampleGrid (this MPSGraph This, MPSGraphTensor source, MPSGraphTensor coordinates, MPSGraphTensorNamedDataLayout layout, bool normalizeCoordinates, bool relativeCoordinates, bool alignCorners, MPSGraphPaddingMode paddingMode, MPSGraphResizeMode samplingMode, double constantValue, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var coordinates__handle__ = coordinates!.GetNonNullHandle (nameof (coordinates));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_bool_bool_bool_IntPtr_UIntPtr_Double_NativeHandle (This.Handle, Selector.GetHandle ("sampleGridWithSourceTensor:coordinateTensor:layout:normalizeCoordinates:relativeCoordinates:alignCorners:paddingMode:samplingMode:constantValue:name:"), source__handle__, coordinates__handle__, (UIntPtr) (ulong) layout, normalizeCoordinates ? (byte) 1 : (byte) 0, relativeCoordinates ? (byte) 1 : (byte) 0, alignCorners ? (byte) 1 : (byte) 0, (IntPtr) (long) paddingMode, (UIntPtr) (ulong) samplingMode, constantValue, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (coordinates);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sampleGridWithSourceTensor:coordinateTensor:layout:normalizeCoordinates:relativeCoordinates:alignCorners:paddingMode:nearestRoundingMode:constantValue:name:")]
		[SupportedOSPlatform ("tvos16.2")]
		[SupportedOSPlatform ("macos13.1")]
		[SupportedOSPlatform ("ios16.2")]
		[SupportedOSPlatform ("maccatalyst16.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor SampleGrid (this MPSGraph This, MPSGraphTensor source, MPSGraphTensor coordinates, MPSGraphTensorNamedDataLayout layout, bool normalizeCoordinates, bool relativeCoordinates, bool alignCorners, MPSGraphPaddingMode paddingMode, MPSGraphResizeNearestRoundingMode nearestRoundingMode, double constantValue, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var coordinates__handle__ = coordinates!.GetNonNullHandle (nameof (coordinates));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_bool_bool_bool_IntPtr_UIntPtr_Double_NativeHandle (This.Handle, Selector.GetHandle ("sampleGridWithSourceTensor:coordinateTensor:layout:normalizeCoordinates:relativeCoordinates:alignCorners:paddingMode:nearestRoundingMode:constantValue:name:"), source__handle__, coordinates__handle__, (UIntPtr) (ulong) layout, normalizeCoordinates ? (byte) 1 : (byte) 0, relativeCoordinates ? (byte) 1 : (byte) 0, alignCorners ? (byte) 1 : (byte) 0, (IntPtr) (long) paddingMode, (UIntPtr) (ulong) nearestRoundingMode, constantValue, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (coordinates);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphSampleGrid */
}
