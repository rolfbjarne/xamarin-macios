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
	public unsafe static partial class MPSGraph_MPSGraphTensorShapeOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("batchToSpaceTensor:spatialAxes:batchAxis:blockDimensions:usePixelShuffleOrder:name:")]
		[SupportedOSPlatform ("tvos16.1")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.1")]
		[SupportedOSPlatform ("maccatalyst16.1")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor BatchToSpace (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] spatialAxes, nint batchAxis, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] blockDimensions, bool usePixelShuffleOrder, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			if (spatialAxes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (spatialAxes));
			if (blockDimensions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (blockDimensions));
			using var nsb_spatialAxes = NSArray.FromNSObjects (o => new NSNumber (o), spatialAxes);
			using var nsb_blockDimensions = NSArray.FromNSObjects (o => new NSNumber (o), blockDimensions);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle_bool_NativeHandle (This.Handle, Selector.GetHandle ("batchToSpaceTensor:spatialAxes:batchAxis:blockDimensions:usePixelShuffleOrder:name:"), tensor__handle__, nsb_spatialAxes.GetHandle (), batchAxis, nsb_blockDimensions.GetHandle (), usePixelShuffleOrder ? (byte) 1 : (byte) 0, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("batchToSpaceTensor:spatialAxesTensor:batchAxisTensor:blockDimensionsTensor:usePixelShuffleOrder:name:")]
		[SupportedOSPlatform ("tvos16.1")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.1")]
		[SupportedOSPlatform ("maccatalyst16.1")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor BatchToSpace (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor spatialAxesTensor, MPSGraphTensor batchAxisTensor, MPSGraphTensor blockDimensionsTensor, bool usePixelShuffleOrder, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var spatialAxesTensor__handle__ = spatialAxesTensor!.GetNonNullHandle (nameof (spatialAxesTensor));
			var batchAxisTensor__handle__ = batchAxisTensor!.GetNonNullHandle (nameof (batchAxisTensor));
			var blockDimensionsTensor__handle__ = blockDimensionsTensor!.GetNonNullHandle (nameof (blockDimensionsTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_bool_NativeHandle (This.Handle, Selector.GetHandle ("batchToSpaceTensor:spatialAxesTensor:batchAxisTensor:blockDimensionsTensor:usePixelShuffleOrder:name:"), tensor__handle__, spatialAxesTensor__handle__, batchAxisTensor__handle__, blockDimensionsTensor__handle__, usePixelShuffleOrder ? (byte) 1 : (byte) 0, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (spatialAxesTensor);
			GC.KeepAlive (batchAxisTensor);
			GC.KeepAlive (blockDimensionsTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("broadcastTensor:toShape:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Broadcast (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] shape, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("broadcastTensor:toShape:name:"), tensor__handle__, nsb_shape.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("broadcastTensor:toShapeTensor:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Broadcast (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor shapeTensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var shapeTensor__handle__ = shapeTensor!.GetNonNullHandle (nameof (shapeTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("broadcastTensor:toShapeTensor:name:"), tensor__handle__, shapeTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (shapeTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("castTensor:toType:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Cast (this MPSGraph This, MPSGraphTensor tensor, global::MetalPerformanceShaders.MPSDataType type, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UInt32_NativeHandle (This.Handle, Selector.GetHandle ("castTensor:toType:name:"), tensor__handle__, (UInt32)type, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("concatTensor:withTensor:dimension:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Concat (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor tensor2, nint dimensionIndex, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var tensor2__handle__ = tensor2!.GetNonNullHandle (nameof (tensor2));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("concatTensor:withTensor:dimension:name:"), tensor__handle__, tensor2__handle__, dimensionIndex, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (tensor2);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("concatTensors:dimension:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ConcatTensors (this MPSGraph This, MPSGraphTensor[] tensors, nint dimensionIndex, string? name)
		{
			if (tensors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (tensors));
			using var nsa_tensors = NSArray.FromNSObjects (tensors);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("concatTensors:dimension:name:"), nsa_tensors.Handle, dimensionIndex, nsname), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("concatTensors:dimension:interleave:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ConcatTensors (this MPSGraph This, MPSGraphTensor[] tensors, nint dimensionIndex, bool interleave, string? name)
		{
			if (tensors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (tensors));
			using var nsa_tensors = NSArray.FromNSObjects (tensors);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_bool_NativeHandle (This.Handle, Selector.GetHandle ("concatTensors:dimension:interleave:name:"), nsa_tensors.Handle, dimensionIndex, interleave ? (byte) 1 : (byte) 0, nsname), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("coordinateAlongAxis:withShape:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor CoordinateAlongAxis (this MPSGraph This, nint axis, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] shape, string? name)
		{
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("coordinateAlongAxis:withShape:name:"), axis, nsb_shape.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("coordinateAlongAxisTensor:withShape:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor CoordinateAlongAxis (this MPSGraph This, MPSGraphTensor axisTensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] shape, string? name)
		{
			var axisTensor__handle__ = axisTensor!.GetNonNullHandle (nameof (axisTensor));
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("coordinateAlongAxisTensor:withShape:name:"), axisTensor__handle__, nsb_shape.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (axisTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("coordinateAlongAxis:withShapeTensor:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor CoordinateAlongAxis (this MPSGraph This, nint axis, MPSGraphTensor shapeTensor, string? name)
		{
			var shapeTensor__handle__ = shapeTensor!.GetNonNullHandle (nameof (shapeTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("coordinateAlongAxis:withShapeTensor:name:"), axis, shapeTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (shapeTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("coordinateAlongAxisTensor:withShapeTensor:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor CoordinateAlongAxis (this MPSGraph This, MPSGraphTensor axisTensor, MPSGraphTensor shapeTensor, string? name)
		{
			var axisTensor__handle__ = axisTensor!.GetNonNullHandle (nameof (axisTensor));
			var shapeTensor__handle__ = shapeTensor!.GetNonNullHandle (nameof (shapeTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("coordinateAlongAxisTensor:withShapeTensor:name:"), axisTensor__handle__, shapeTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (axisTensor);
			GC.KeepAlive (shapeTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("depthToSpace2DTensor:widthAxisTensor:heightAxisTensor:depthAxisTensor:blockSize:usePixelShuffleOrder:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor DepthToSpace2D (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor widthAxisTensor, MPSGraphTensor heightAxisTensor, MPSGraphTensor depthAxisTensor, nuint blockSize, bool usePixelShuffleOrder, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var widthAxisTensor__handle__ = widthAxisTensor!.GetNonNullHandle (nameof (widthAxisTensor));
			var heightAxisTensor__handle__ = heightAxisTensor!.GetNonNullHandle (nameof (heightAxisTensor));
			var depthAxisTensor__handle__ = depthAxisTensor!.GetNonNullHandle (nameof (depthAxisTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_UIntPtr_bool_NativeHandle (This.Handle, Selector.GetHandle ("depthToSpace2DTensor:widthAxisTensor:heightAxisTensor:depthAxisTensor:blockSize:usePixelShuffleOrder:name:"), tensor__handle__, widthAxisTensor__handle__, heightAxisTensor__handle__, depthAxisTensor__handle__, blockSize, usePixelShuffleOrder ? (byte) 1 : (byte) 0, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (widthAxisTensor);
			GC.KeepAlive (heightAxisTensor);
			GC.KeepAlive (depthAxisTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("depthToSpace2DTensor:widthAxis:heightAxis:depthAxis:blockSize:usePixelShuffleOrder:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor DepthToSpace2D (this MPSGraph This, MPSGraphTensor tensor, nuint widthAxis, nuint heightAxis, nuint depthAxis, nuint blockSize, bool usePixelShuffleOrder, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_UIntPtr_UIntPtr_bool_NativeHandle (This.Handle, Selector.GetHandle ("depthToSpace2DTensor:widthAxis:heightAxis:depthAxis:blockSize:usePixelShuffleOrder:name:"), tensor__handle__, widthAxis, heightAxis, depthAxis, blockSize, usePixelShuffleOrder ? (byte) 1 : (byte) 0, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("expandDimsOfTensor:axis:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ExpandDims (this MPSGraph This, MPSGraphTensor tensor, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("expandDimsOfTensor:axis:name:"), tensor__handle__, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("expandDimsOfTensor:axes:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ExpandDims (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] axes, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			if (axes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (axes));
			using var nsb_axes = NSArray.FromNSObjects (o => new NSNumber (o), axes);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("expandDimsOfTensor:axes:name:"), tensor__handle__, nsb_axes.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("expandDimsOfTensor:axesTensor:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ExpandDims (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor axesTensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var axesTensor__handle__ = axesTensor!.GetNonNullHandle (nameof (axesTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("expandDimsOfTensor:axesTensor:name:"), tensor__handle__, axesTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (axesTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("flatten2DTensor:axis:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Flatten2D (this MPSGraph This, MPSGraphTensor tensor, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("flatten2DTensor:axis:name:"), tensor__handle__, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("flatten2DTensor:axisTensor:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Flatten2D (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor axisTensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var axisTensor__handle__ = axisTensor!.GetNonNullHandle (nameof (axisTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("flatten2DTensor:axisTensor:name:"), tensor__handle__, axisTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (axisTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("padTensor:withPaddingMode:leftPadding:rightPadding:constantValue:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Pad (this MPSGraph This, MPSGraphTensor tensor, MPSGraphPaddingMode paddingMode, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] leftPadding, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] rightPadding, double constantValue, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			if (leftPadding is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (leftPadding));
			if (rightPadding is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (rightPadding));
			using var nsb_leftPadding = NSArray.FromNSObjects (o => new NSNumber (o), leftPadding);
			using var nsb_rightPadding = NSArray.FromNSObjects (o => new NSNumber (o), rightPadding);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle_NativeHandle_Double_NativeHandle (This.Handle, Selector.GetHandle ("padTensor:withPaddingMode:leftPadding:rightPadding:constantValue:name:"), tensor__handle__, (IntPtr) (long) paddingMode, nsb_leftPadding.GetHandle (), nsb_rightPadding.GetHandle (), constantValue, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("padGradientWithIncomingGradientTensor:sourceTensor:paddingMode:leftPadding:rightPadding:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor PadGradient (this MPSGraph This, MPSGraphTensor incomingGradientTensor, MPSGraphTensor sourceTensor, MPSGraphPaddingMode paddingMode, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] leftPadding, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] rightPadding, string? name)
		{
			var incomingGradientTensor__handle__ = incomingGradientTensor!.GetNonNullHandle (nameof (incomingGradientTensor));
			var sourceTensor__handle__ = sourceTensor!.GetNonNullHandle (nameof (sourceTensor));
			if (leftPadding is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (leftPadding));
			if (rightPadding is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (rightPadding));
			using var nsb_leftPadding = NSArray.FromNSObjects (o => new NSNumber (o), leftPadding);
			using var nsb_rightPadding = NSArray.FromNSObjects (o => new NSNumber (o), rightPadding);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("padGradientWithIncomingGradientTensor:sourceTensor:paddingMode:leftPadding:rightPadding:name:"), incomingGradientTensor__handle__, sourceTensor__handle__, (IntPtr) (long) paddingMode, nsb_leftPadding.GetHandle (), nsb_rightPadding.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (incomingGradientTensor);
			GC.KeepAlive (sourceTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reinterpretCastTensor:toType:name:")]
		[SupportedOSPlatform ("tvos16.3")]
		[SupportedOSPlatform ("macos13.2")]
		[SupportedOSPlatform ("ios16.3")]
		[SupportedOSPlatform ("maccatalyst16.3")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ReinterpretCast (this MPSGraph This, MPSGraphTensor tensor, global::MetalPerformanceShaders.MPSDataType type, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UInt32_NativeHandle (This.Handle, Selector.GetHandle ("reinterpretCastTensor:toType:name:"), tensor__handle__, (UInt32)type, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reshapeTensor:withShape:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Reshape (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] shape, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("reshapeTensor:withShape:name:"), tensor__handle__, nsb_shape.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reshapeTensor:withShapeTensor:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Reshape (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor shapeTensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var shapeTensor__handle__ = shapeTensor!.GetNonNullHandle (nameof (shapeTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("reshapeTensor:withShapeTensor:name:"), tensor__handle__, shapeTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (shapeTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reverseTensor:axesTensor:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Reverse (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor axesTensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var axesTensor__handle__ = axesTensor!.GetNonNullHandle (nameof (axesTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("reverseTensor:axesTensor:name:"), tensor__handle__, axesTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (axesTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reverseTensor:axes:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Reverse (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] axes, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			if (axes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (axes));
			using var nsb_axes = NSArray.FromNSObjects (o => new NSNumber (o), axes);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("reverseTensor:axes:name:"), tensor__handle__, nsb_axes.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reverseTensor:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Reverse (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("reverseTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("shapeOfTensor:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Shape (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("shapeOfTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sliceTensor:dimension:start:length:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Slice (this MPSGraph This, MPSGraphTensor tensor, nuint dimensionIndex, nint start, nint length, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_IntPtr_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("sliceTensor:dimension:start:length:name:"), tensor__handle__, dimensionIndex, start, length, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sliceTensor:starts:ends:strides:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Slice (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] starts, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] ends, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] strides, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			if (starts is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (starts));
			if (ends is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ends));
			if (strides is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (strides));
			using var nsb_starts = NSArray.FromNSObjects (o => new NSNumber (o), starts);
			using var nsb_ends = NSArray.FromNSObjects (o => new NSNumber (o), ends);
			using var nsb_strides = NSArray.FromNSObjects (o => new NSNumber (o), strides);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sliceTensor:starts:ends:strides:name:"), tensor__handle__, nsb_starts.GetHandle (), nsb_ends.GetHandle (), nsb_strides.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sliceTensor:starts:ends:strides:startMask:endMask:squeezeMask:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Slice (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] starts, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] ends, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] strides, uint startMask, uint endMask, uint squeezeMask, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			if (starts is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (starts));
			if (ends is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ends));
			if (strides is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (strides));
			using var nsb_starts = NSArray.FromNSObjects (o => new NSNumber (o), starts);
			using var nsb_ends = NSArray.FromNSObjects (o => new NSNumber (o), ends);
			using var nsb_strides = NSArray.FromNSObjects (o => new NSNumber (o), strides);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_UInt32_UInt32_UInt32_NativeHandle (This.Handle, Selector.GetHandle ("sliceTensor:starts:ends:strides:startMask:endMask:squeezeMask:name:"), tensor__handle__, nsb_starts.GetHandle (), nsb_ends.GetHandle (), nsb_strides.GetHandle (), startMask, endMask, squeezeMask, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sliceTensor:startTensor:endTensor:strideTensor:startMask:endMask:squeezeMask:name:")]
		[SupportedOSPlatform ("tvos18.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[SupportedOSPlatform ("macos15.2")]
		[SupportedOSPlatform ("ios18.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Slice (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor startTensor, MPSGraphTensor endTensor, MPSGraphTensor strideTensor, uint startMask, uint endMask, uint squeezeMask, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var startTensor__handle__ = startTensor!.GetNonNullHandle (nameof (startTensor));
			var endTensor__handle__ = endTensor!.GetNonNullHandle (nameof (endTensor));
			var strideTensor__handle__ = strideTensor!.GetNonNullHandle (nameof (strideTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_UInt32_UInt32_UInt32_NativeHandle (This.Handle, Selector.GetHandle ("sliceTensor:startTensor:endTensor:strideTensor:startMask:endMask:squeezeMask:name:"), tensor__handle__, startTensor__handle__, endTensor__handle__, strideTensor__handle__, startMask, endMask, squeezeMask, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (startTensor);
			GC.KeepAlive (endTensor);
			GC.KeepAlive (strideTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sliceTensor:startTensor:sizeTensor:squeezeMask:name:")]
		[SupportedOSPlatform ("tvos18.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[SupportedOSPlatform ("macos15.2")]
		[SupportedOSPlatform ("ios18.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Slice (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor startTensor, MPSGraphTensor sizeTensor, uint squeezeMask, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var startTensor__handle__ = startTensor!.GetNonNullHandle (nameof (startTensor));
			var sizeTensor__handle__ = sizeTensor!.GetNonNullHandle (nameof (sizeTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UInt32_NativeHandle (This.Handle, Selector.GetHandle ("sliceTensor:startTensor:sizeTensor:squeezeMask:name:"), tensor__handle__, startTensor__handle__, sizeTensor__handle__, squeezeMask, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (startTensor);
			GC.KeepAlive (sizeTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sliceGradientTensor:fwdInShapeTensor:starts:ends:strides:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor SliceGradient (this MPSGraph This, MPSGraphTensor inputGradientTensor, MPSGraphTensor fwdInShapeTensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] starts, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] ends, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] strides, string? name)
		{
			var inputGradientTensor__handle__ = inputGradientTensor!.GetNonNullHandle (nameof (inputGradientTensor));
			var fwdInShapeTensor__handle__ = fwdInShapeTensor!.GetNonNullHandle (nameof (fwdInShapeTensor));
			if (starts is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (starts));
			if (ends is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ends));
			if (strides is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (strides));
			using var nsb_starts = NSArray.FromNSObjects (o => new NSNumber (o), starts);
			using var nsb_ends = NSArray.FromNSObjects (o => new NSNumber (o), ends);
			using var nsb_strides = NSArray.FromNSObjects (o => new NSNumber (o), strides);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sliceGradientTensor:fwdInShapeTensor:starts:ends:strides:name:"), inputGradientTensor__handle__, fwdInShapeTensor__handle__, nsb_starts.GetHandle (), nsb_ends.GetHandle (), nsb_strides.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (inputGradientTensor);
			GC.KeepAlive (fwdInShapeTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sliceGradientTensor:fwdInShapeTensor:starts:ends:strides:startMask:endMask:squeezeMask:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor SliceGradient (this MPSGraph This, MPSGraphTensor inputGradientTensor, MPSGraphTensor fwdInShapeTensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] starts, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] ends, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] strides, uint startMask, uint endMask, uint squeezeMask, string? name)
		{
			var inputGradientTensor__handle__ = inputGradientTensor!.GetNonNullHandle (nameof (inputGradientTensor));
			var fwdInShapeTensor__handle__ = fwdInShapeTensor!.GetNonNullHandle (nameof (fwdInShapeTensor));
			if (starts is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (starts));
			if (ends is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ends));
			if (strides is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (strides));
			using var nsb_starts = NSArray.FromNSObjects (o => new NSNumber (o), starts);
			using var nsb_ends = NSArray.FromNSObjects (o => new NSNumber (o), ends);
			using var nsb_strides = NSArray.FromNSObjects (o => new NSNumber (o), strides);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_UInt32_UInt32_UInt32_NativeHandle (This.Handle, Selector.GetHandle ("sliceGradientTensor:fwdInShapeTensor:starts:ends:strides:startMask:endMask:squeezeMask:name:"), inputGradientTensor__handle__, fwdInShapeTensor__handle__, nsb_starts.GetHandle (), nsb_ends.GetHandle (), nsb_strides.GetHandle (), startMask, endMask, squeezeMask, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (inputGradientTensor);
			GC.KeepAlive (fwdInShapeTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sliceGradientTensor:fwdInShapeTensor:startTensor:endTensor:strideTensor:startMask:endMask:squeezeMask:name:")]
		[SupportedOSPlatform ("tvos18.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[SupportedOSPlatform ("macos15.2")]
		[SupportedOSPlatform ("ios18.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor SliceGradient (this MPSGraph This, MPSGraphTensor inputGradientTensor, MPSGraphTensor fwdInShapeTensor, MPSGraphTensor startTensor, MPSGraphTensor endTensor, MPSGraphTensor strideTensor, uint startMask, uint endMask, uint squeezeMask, string? name)
		{
			var inputGradientTensor__handle__ = inputGradientTensor!.GetNonNullHandle (nameof (inputGradientTensor));
			var fwdInShapeTensor__handle__ = fwdInShapeTensor!.GetNonNullHandle (nameof (fwdInShapeTensor));
			var startTensor__handle__ = startTensor!.GetNonNullHandle (nameof (startTensor));
			var endTensor__handle__ = endTensor!.GetNonNullHandle (nameof (endTensor));
			var strideTensor__handle__ = strideTensor!.GetNonNullHandle (nameof (strideTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_UInt32_UInt32_UInt32_NativeHandle (This.Handle, Selector.GetHandle ("sliceGradientTensor:fwdInShapeTensor:startTensor:endTensor:strideTensor:startMask:endMask:squeezeMask:name:"), inputGradientTensor__handle__, fwdInShapeTensor__handle__, startTensor__handle__, endTensor__handle__, strideTensor__handle__, startMask, endMask, squeezeMask, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (inputGradientTensor);
			GC.KeepAlive (fwdInShapeTensor);
			GC.KeepAlive (startTensor);
			GC.KeepAlive (endTensor);
			GC.KeepAlive (strideTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sliceGradientTensor:fwdInShapeTensor:startTensor:sizeTensor:squeezeMask:name:")]
		[SupportedOSPlatform ("tvos18.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[SupportedOSPlatform ("macos15.2")]
		[SupportedOSPlatform ("ios18.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor SliceGradient (this MPSGraph This, MPSGraphTensor inputGradientTensor, MPSGraphTensor fwdInShapeTensor, MPSGraphTensor startTensor, MPSGraphTensor sizeTensor, uint squeezeMask, string? name)
		{
			var inputGradientTensor__handle__ = inputGradientTensor!.GetNonNullHandle (nameof (inputGradientTensor));
			var fwdInShapeTensor__handle__ = fwdInShapeTensor!.GetNonNullHandle (nameof (fwdInShapeTensor));
			var startTensor__handle__ = startTensor!.GetNonNullHandle (nameof (startTensor));
			var sizeTensor__handle__ = sizeTensor!.GetNonNullHandle (nameof (sizeTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_UInt32_NativeHandle (This.Handle, Selector.GetHandle ("sliceGradientTensor:fwdInShapeTensor:startTensor:sizeTensor:squeezeMask:name:"), inputGradientTensor__handle__, fwdInShapeTensor__handle__, startTensor__handle__, sizeTensor__handle__, squeezeMask, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (inputGradientTensor);
			GC.KeepAlive (fwdInShapeTensor);
			GC.KeepAlive (startTensor);
			GC.KeepAlive (sizeTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sliceUpdateDataTensor:updateTensor:startsTensor:endsTensor:stridesTensor:startMask:endMask:squeezeMask:name:")]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor SliceUpdateData (this MPSGraph This, MPSGraphTensor dataTensor, MPSGraphTensor updateTensor, MPSGraphTensor startsTensor, MPSGraphTensor endsTensor, MPSGraphTensor stridesTensor, uint startMask, uint endMask, uint squeezeMask, string? name)
		{
			var dataTensor__handle__ = dataTensor!.GetNonNullHandle (nameof (dataTensor));
			var updateTensor__handle__ = updateTensor!.GetNonNullHandle (nameof (updateTensor));
			var startsTensor__handle__ = startsTensor!.GetNonNullHandle (nameof (startsTensor));
			var endsTensor__handle__ = endsTensor!.GetNonNullHandle (nameof (endsTensor));
			var stridesTensor__handle__ = stridesTensor!.GetNonNullHandle (nameof (stridesTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_UInt32_UInt32_UInt32_NativeHandle (This.Handle, Selector.GetHandle ("sliceUpdateDataTensor:updateTensor:startsTensor:endsTensor:stridesTensor:startMask:endMask:squeezeMask:name:"), dataTensor__handle__, updateTensor__handle__, startsTensor__handle__, endsTensor__handle__, stridesTensor__handle__, startMask, endMask, squeezeMask, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (dataTensor);
			GC.KeepAlive (updateTensor);
			GC.KeepAlive (startsTensor);
			GC.KeepAlive (endsTensor);
			GC.KeepAlive (stridesTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sliceUpdateDataTensor:updateTensor:starts:ends:strides:startMask:endMask:squeezeMask:name:")]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor SliceUpdateData (this MPSGraph This, MPSGraphTensor dataTensor, MPSGraphTensor updateTensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] starts, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] ends, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] strides, uint startMask, uint endMask, uint squeezeMask, string? name)
		{
			var dataTensor__handle__ = dataTensor!.GetNonNullHandle (nameof (dataTensor));
			var updateTensor__handle__ = updateTensor!.GetNonNullHandle (nameof (updateTensor));
			if (starts is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (starts));
			if (ends is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ends));
			if (strides is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (strides));
			using var nsb_starts = NSArray.FromNSObjects (o => new NSNumber (o), starts);
			using var nsb_ends = NSArray.FromNSObjects (o => new NSNumber (o), ends);
			using var nsb_strides = NSArray.FromNSObjects (o => new NSNumber (o), strides);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_UInt32_UInt32_UInt32_NativeHandle (This.Handle, Selector.GetHandle ("sliceUpdateDataTensor:updateTensor:starts:ends:strides:startMask:endMask:squeezeMask:name:"), dataTensor__handle__, updateTensor__handle__, nsb_starts.GetHandle (), nsb_ends.GetHandle (), nsb_strides.GetHandle (), startMask, endMask, squeezeMask, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (dataTensor);
			GC.KeepAlive (updateTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sliceUpdateDataTensor:updateTensor:startsTensor:endsTensor:stridesTensor:name:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor SliceUpdateData (this MPSGraph This, MPSGraphTensor dataTensor, MPSGraphTensor updatesTensor, MPSGraphTensor startsTensor, MPSGraphTensor endsTensor, MPSGraphTensor stridesTensor, string? name)
		{
			var dataTensor__handle__ = dataTensor!.GetNonNullHandle (nameof (dataTensor));
			var updatesTensor__handle__ = updatesTensor!.GetNonNullHandle (nameof (updatesTensor));
			var startsTensor__handle__ = startsTensor!.GetNonNullHandle (nameof (startsTensor));
			var endsTensor__handle__ = endsTensor!.GetNonNullHandle (nameof (endsTensor));
			var stridesTensor__handle__ = stridesTensor!.GetNonNullHandle (nameof (stridesTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sliceUpdateDataTensor:updateTensor:startsTensor:endsTensor:stridesTensor:name:"), dataTensor__handle__, updatesTensor__handle__, startsTensor__handle__, endsTensor__handle__, stridesTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (dataTensor);
			GC.KeepAlive (updatesTensor);
			GC.KeepAlive (startsTensor);
			GC.KeepAlive (endsTensor);
			GC.KeepAlive (stridesTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sliceUpdateDataTensor:updateTensor:starts:ends:strides:name:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor SliceUpdateData (this MPSGraph This, MPSGraphTensor dataTensor, MPSGraphTensor updatesTensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] starts, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] ends, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] strides, string? name)
		{
			var dataTensor__handle__ = dataTensor!.GetNonNullHandle (nameof (dataTensor));
			var updatesTensor__handle__ = updatesTensor!.GetNonNullHandle (nameof (updatesTensor));
			if (starts is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (starts));
			if (ends is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ends));
			if (strides is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (strides));
			using var nsb_starts = NSArray.FromNSObjects (o => new NSNumber (o), starts);
			using var nsb_ends = NSArray.FromNSObjects (o => new NSNumber (o), ends);
			using var nsb_strides = NSArray.FromNSObjects (o => new NSNumber (o), strides);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sliceUpdateDataTensor:updateTensor:starts:ends:strides:name:"), dataTensor__handle__, updatesTensor__handle__, nsb_starts.GetHandle (), nsb_ends.GetHandle (), nsb_strides.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (dataTensor);
			GC.KeepAlive (updatesTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("spaceToBatchTensor:spatialAxes:batchAxis:blockDimensions:usePixelShuffleOrder:name:")]
		[SupportedOSPlatform ("tvos16.1")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.1")]
		[SupportedOSPlatform ("maccatalyst16.1")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor SpaceToBatch (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] spatialAxes, nint batchAxis, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] blockDimensions, bool usePixelShuffleOrder, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			if (spatialAxes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (spatialAxes));
			if (blockDimensions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (blockDimensions));
			using var nsb_spatialAxes = NSArray.FromNSObjects (o => new NSNumber (o), spatialAxes);
			using var nsb_blockDimensions = NSArray.FromNSObjects (o => new NSNumber (o), blockDimensions);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle_bool_NativeHandle (This.Handle, Selector.GetHandle ("spaceToBatchTensor:spatialAxes:batchAxis:blockDimensions:usePixelShuffleOrder:name:"), tensor__handle__, nsb_spatialAxes.GetHandle (), batchAxis, nsb_blockDimensions.GetHandle (), usePixelShuffleOrder ? (byte) 1 : (byte) 0, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("spaceToBatchTensor:spatialAxesTensor:batchAxisTensor:blockDimensionsTensor:usePixelShuffleOrder:name:")]
		[SupportedOSPlatform ("tvos16.1")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.1")]
		[SupportedOSPlatform ("maccatalyst16.1")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor SpaceToBatch (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor spatialAxesTensor, MPSGraphTensor batchAxisTensor, MPSGraphTensor blockDimensionsTensor, bool usePixelShuffleOrder, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var spatialAxesTensor__handle__ = spatialAxesTensor!.GetNonNullHandle (nameof (spatialAxesTensor));
			var batchAxisTensor__handle__ = batchAxisTensor!.GetNonNullHandle (nameof (batchAxisTensor));
			var blockDimensionsTensor__handle__ = blockDimensionsTensor!.GetNonNullHandle (nameof (blockDimensionsTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_bool_NativeHandle (This.Handle, Selector.GetHandle ("spaceToBatchTensor:spatialAxesTensor:batchAxisTensor:blockDimensionsTensor:usePixelShuffleOrder:name:"), tensor__handle__, spatialAxesTensor__handle__, batchAxisTensor__handle__, blockDimensionsTensor__handle__, usePixelShuffleOrder ? (byte) 1 : (byte) 0, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (spatialAxesTensor);
			GC.KeepAlive (batchAxisTensor);
			GC.KeepAlive (blockDimensionsTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("spaceToDepth2DTensor:widthAxisTensor:heightAxisTensor:depthAxisTensor:blockSize:usePixelShuffleOrder:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor SpaceToDepth2D (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor widthAxisTensor, MPSGraphTensor heightAxisTensor, MPSGraphTensor depthAxisTensor, nuint blockSize, bool usePixelShuffleOrder, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var widthAxisTensor__handle__ = widthAxisTensor!.GetNonNullHandle (nameof (widthAxisTensor));
			var heightAxisTensor__handle__ = heightAxisTensor!.GetNonNullHandle (nameof (heightAxisTensor));
			var depthAxisTensor__handle__ = depthAxisTensor!.GetNonNullHandle (nameof (depthAxisTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_UIntPtr_bool_NativeHandle (This.Handle, Selector.GetHandle ("spaceToDepth2DTensor:widthAxisTensor:heightAxisTensor:depthAxisTensor:blockSize:usePixelShuffleOrder:name:"), tensor__handle__, widthAxisTensor__handle__, heightAxisTensor__handle__, depthAxisTensor__handle__, blockSize, usePixelShuffleOrder ? (byte) 1 : (byte) 0, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (widthAxisTensor);
			GC.KeepAlive (heightAxisTensor);
			GC.KeepAlive (depthAxisTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("spaceToDepth2DTensor:widthAxis:heightAxis:depthAxis:blockSize:usePixelShuffleOrder:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor SpaceToDepth2D (this MPSGraph This, MPSGraphTensor tensor, nuint widthAxis, nuint heightAxis, nuint depthAxis, nuint blockSize, bool usePixelShuffleOrder, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_UIntPtr_UIntPtr_bool_NativeHandle (This.Handle, Selector.GetHandle ("spaceToDepth2DTensor:widthAxis:heightAxis:depthAxis:blockSize:usePixelShuffleOrder:name:"), tensor__handle__, widthAxis, heightAxis, depthAxis, blockSize, usePixelShuffleOrder ? (byte) 1 : (byte) 0, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("splitTensor:splitSizes:axis:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] Split (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] splitSizes, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			if (splitSizes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (splitSizes));
			using var nsb_splitSizes = NSArray.FromNSObjects (o => new NSNumber (o), splitSizes);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("splitTensor:splitSizes:axis:name:"), tensor__handle__, nsb_splitSizes.GetHandle (), axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("splitTensor:splitSizesTensor:axis:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] Split (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor splitSizesTensor, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var splitSizesTensor__handle__ = splitSizesTensor!.GetNonNullHandle (nameof (splitSizesTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("splitTensor:splitSizesTensor:axis:name:"), tensor__handle__, splitSizesTensor__handle__, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (splitSizesTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("splitTensor:numSplits:axis:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] Split (this MPSGraph This, MPSGraphTensor tensor, nuint numSplits, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("splitTensor:numSplits:axis:name:"), tensor__handle__, numSplits, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("squeezeTensor:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Squeeze (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("squeezeTensor:name:"), tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("squeezeTensor:axis:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Squeeze (this MPSGraph This, MPSGraphTensor tensor, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("squeezeTensor:axis:name:"), tensor__handle__, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("squeezeTensor:axes:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Squeeze (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] axes, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			if (axes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (axes));
			using var nsb_axes = NSArray.FromNSObjects (o => new NSNumber (o), axes);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("squeezeTensor:axes:name:"), tensor__handle__, nsb_axes.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("squeezeTensor:axesTensor:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Squeeze (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor axesTensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var axesTensor__handle__ = axesTensor!.GetNonNullHandle (nameof (axesTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("squeezeTensor:axesTensor:name:"), tensor__handle__, axesTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (axesTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("stackTensors:axis:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Stack (this MPSGraph This, MPSGraphTensor[] inputTensors, nint axis, string? name)
		{
			if (inputTensors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (inputTensors));
			using var nsa_inputTensors = NSArray.FromNSObjects (inputTensors);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("stackTensors:axis:name:"), nsa_inputTensors.Handle, axis, nsname), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("tileTensor:withMultiplier:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Tile (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] multiplier, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			if (multiplier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (multiplier));
			using var nsb_multiplier = NSArray.FromNSObjects (o => new NSNumber (o), multiplier);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tileTensor:withMultiplier:name:"), tensor__handle__, nsb_multiplier.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("tileGradientWithIncomingGradientTensor:sourceTensor:withMultiplier:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor TileGradient (this MPSGraph This, MPSGraphTensor incomingGradientTensor, MPSGraphTensor sourceTensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] multiplier, string? name)
		{
			var incomingGradientTensor__handle__ = incomingGradientTensor!.GetNonNullHandle (nameof (incomingGradientTensor));
			var sourceTensor__handle__ = sourceTensor!.GetNonNullHandle (nameof (sourceTensor));
			if (multiplier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (multiplier));
			using var nsb_multiplier = NSArray.FromNSObjects (o => new NSNumber (o), multiplier);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tileGradientWithIncomingGradientTensor:sourceTensor:withMultiplier:name:"), incomingGradientTensor__handle__, sourceTensor__handle__, nsb_multiplier.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (incomingGradientTensor);
			GC.KeepAlive (sourceTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("transposeTensor:dimension:withDimension:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Transpose (this MPSGraph This, MPSGraphTensor tensor, nuint dimensionIndex, nuint dimensionIndex2, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("transposeTensor:dimension:withDimension:name:"), tensor__handle__, dimensionIndex, dimensionIndex2, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("transposeTensor:permutation:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Transpose (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] permutation, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			if (permutation is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (permutation));
			using var nsb_permutation = NSArray.FromNSObjects (o => new NSNumber (o), permutation);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("transposeTensor:permutation:name:"), tensor__handle__, nsb_permutation.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphTensorShapeOps */
}
