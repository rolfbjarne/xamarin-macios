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
	public unsafe static partial class MPSGraph_MPSGraphResizeOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("resizeTensor:size:mode:centerResult:alignCorners:layout:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Resize (this MPSGraph This, MPSGraphTensor imagesTensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] size, MPSGraphResizeMode mode, bool centerResult, bool alignCorners, MPSGraphTensorNamedDataLayout layout, string? name)
		{
			var imagesTensor__handle__ = imagesTensor!.GetNonNullHandle (nameof (imagesTensor));
			if (size is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (size));
			using var nsb_size = NSArray.FromNSObjects (o => new NSNumber (o), size);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_bool_bool_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("resizeTensor:size:mode:centerResult:alignCorners:layout:name:"), imagesTensor__handle__, nsb_size.GetHandle (), (UIntPtr) (ulong) mode, centerResult ? (byte) 1 : (byte) 0, alignCorners ? (byte) 1 : (byte) 0, (UIntPtr) (ulong) layout, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (imagesTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("resizeTensor:sizeTensor:mode:centerResult:alignCorners:layout:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Resize (this MPSGraph This, MPSGraphTensor imagesTensor, MPSGraphTensor size, MPSGraphResizeMode mode, bool centerResult, bool alignCorners, MPSGraphTensorNamedDataLayout layout, string? name)
		{
			var imagesTensor__handle__ = imagesTensor!.GetNonNullHandle (nameof (imagesTensor));
			var size__handle__ = size!.GetNonNullHandle (nameof (size));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_bool_bool_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("resizeTensor:sizeTensor:mode:centerResult:alignCorners:layout:name:"), imagesTensor__handle__, size__handle__, (UIntPtr) (ulong) mode, centerResult ? (byte) 1 : (byte) 0, alignCorners ? (byte) 1 : (byte) 0, (UIntPtr) (ulong) layout, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (imagesTensor);
			GC.KeepAlive (size);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("resizeTensor:sizeTensor:mode:centerResult:alignCorners:name:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Resize (this MPSGraph This, MPSGraphTensor imagesTensor, MPSGraphTensor size, MPSGraphResizeMode mode, bool centerResult, bool alignCorners, string? name)
		{
			var imagesTensor__handle__ = imagesTensor!.GetNonNullHandle (nameof (imagesTensor));
			var size__handle__ = size!.GetNonNullHandle (nameof (size));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_bool_bool_NativeHandle (This.Handle, Selector.GetHandle ("resizeTensor:sizeTensor:mode:centerResult:alignCorners:name:"), imagesTensor__handle__, size__handle__, (UIntPtr) (ulong) mode, centerResult ? (byte) 1 : (byte) 0, alignCorners ? (byte) 1 : (byte) 0, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (imagesTensor);
			GC.KeepAlive (size);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("resizeTensor:sizeTensor:scaleOffsetTensor:mode:layout:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Resize (this MPSGraph This, MPSGraphTensor imagesTensor, MPSGraphTensor size, MPSGraphTensor scaleOffset, MPSGraphResizeMode mode, MPSGraphTensorNamedDataLayout layout, string? name)
		{
			var imagesTensor__handle__ = imagesTensor!.GetNonNullHandle (nameof (imagesTensor));
			var size__handle__ = size!.GetNonNullHandle (nameof (size));
			var scaleOffset__handle__ = scaleOffset!.GetNonNullHandle (nameof (scaleOffset));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UIntPtr_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("resizeTensor:sizeTensor:scaleOffsetTensor:mode:layout:name:"), imagesTensor__handle__, size__handle__, scaleOffset__handle__, (UIntPtr) (ulong) mode, (UIntPtr) (ulong) layout, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (imagesTensor);
			GC.KeepAlive (size);
			GC.KeepAlive (scaleOffset);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("resizeTensor:sizeTensor:scaleTensor:offsetTensor:mode:name:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Resize (this MPSGraph This, MPSGraphTensor imagesTensor, MPSGraphTensor size, MPSGraphTensor scale, MPSGraphTensor offset, MPSGraphResizeMode mode, string? name)
		{
			var imagesTensor__handle__ = imagesTensor!.GetNonNullHandle (nameof (imagesTensor));
			var size__handle__ = size!.GetNonNullHandle (nameof (size));
			var scale__handle__ = scale!.GetNonNullHandle (nameof (scale));
			var offset__handle__ = offset!.GetNonNullHandle (nameof (offset));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("resizeTensor:sizeTensor:scaleTensor:offsetTensor:mode:name:"), imagesTensor__handle__, size__handle__, scale__handle__, offset__handle__, (UIntPtr) (ulong) mode, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (imagesTensor);
			GC.KeepAlive (size);
			GC.KeepAlive (scale);
			GC.KeepAlive (offset);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("resizeBilinearWithTensor:sizeTensor:centerResult:alignCorners:layout:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ResizeBilinear (this MPSGraph This, MPSGraphTensor imagesTensor, MPSGraphTensor size, bool centerResult, bool alignCorners, MPSGraphTensorNamedDataLayout layout, string? name)
		{
			var imagesTensor__handle__ = imagesTensor!.GetNonNullHandle (nameof (imagesTensor));
			var size__handle__ = size!.GetNonNullHandle (nameof (size));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool_bool_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("resizeBilinearWithTensor:sizeTensor:centerResult:alignCorners:layout:name:"), imagesTensor__handle__, size__handle__, centerResult ? (byte) 1 : (byte) 0, alignCorners ? (byte) 1 : (byte) 0, (UIntPtr) (ulong) layout, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (imagesTensor);
			GC.KeepAlive (size);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("resizeBilinearWithTensor:sizeTensor:centerResult:alignCorners:name:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ResizeBilinear (this MPSGraph This, MPSGraphTensor imagesTensor, MPSGraphTensor size, bool centerResult, bool alignCorners, string? name)
		{
			var imagesTensor__handle__ = imagesTensor!.GetNonNullHandle (nameof (imagesTensor));
			var size__handle__ = size!.GetNonNullHandle (nameof (size));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool_bool_NativeHandle (This.Handle, Selector.GetHandle ("resizeBilinearWithTensor:sizeTensor:centerResult:alignCorners:name:"), imagesTensor__handle__, size__handle__, centerResult ? (byte) 1 : (byte) 0, alignCorners ? (byte) 1 : (byte) 0, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (imagesTensor);
			GC.KeepAlive (size);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("resizeBilinearWithTensor:sizeTensor:scaleOffsetTensor:layout:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ResizeBilinear (this MPSGraph This, MPSGraphTensor imagesTensor, MPSGraphTensor size, MPSGraphTensor scaleOffset, MPSGraphTensorNamedDataLayout layout, string? name)
		{
			var imagesTensor__handle__ = imagesTensor!.GetNonNullHandle (nameof (imagesTensor));
			var size__handle__ = size!.GetNonNullHandle (nameof (size));
			var scaleOffset__handle__ = scaleOffset!.GetNonNullHandle (nameof (scaleOffset));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("resizeBilinearWithTensor:sizeTensor:scaleOffsetTensor:layout:name:"), imagesTensor__handle__, size__handle__, scaleOffset__handle__, (UIntPtr) (ulong) layout, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (imagesTensor);
			GC.KeepAlive (size);
			GC.KeepAlive (scaleOffset);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("resizeBilinearWithTensor:sizeTensor:scaleTensor:offsetTensor:name:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ResizeBilinear (this MPSGraph This, MPSGraphTensor imagesTensor, MPSGraphTensor size, MPSGraphTensor scale, MPSGraphTensor offset, string? name)
		{
			var imagesTensor__handle__ = imagesTensor!.GetNonNullHandle (nameof (imagesTensor));
			var size__handle__ = size!.GetNonNullHandle (nameof (size));
			var scale__handle__ = scale!.GetNonNullHandle (nameof (scale));
			var offset__handle__ = offset!.GetNonNullHandle (nameof (offset));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resizeBilinearWithTensor:sizeTensor:scaleTensor:offsetTensor:name:"), imagesTensor__handle__, size__handle__, scale__handle__, offset__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (imagesTensor);
			GC.KeepAlive (size);
			GC.KeepAlive (scale);
			GC.KeepAlive (offset);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("resizeBilinearWithGradientTensor:input:centerResult:alignCorners:layout:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ResizeBilinearWithGradient (this MPSGraph This, MPSGraphTensor gradient, MPSGraphTensor input, bool centerResult, bool alignCorners, MPSGraphTensorNamedDataLayout layout, string? name)
		{
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var input__handle__ = input!.GetNonNullHandle (nameof (input));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool_bool_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("resizeBilinearWithGradientTensor:input:centerResult:alignCorners:layout:name:"), gradient__handle__, input__handle__, centerResult ? (byte) 1 : (byte) 0, alignCorners ? (byte) 1 : (byte) 0, (UIntPtr) (ulong) layout, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradient);
			GC.KeepAlive (input);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("resizeBilinearWithGradientTensor:input:scaleOffsetTensor:layout:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ResizeBilinearWithGradient (this MPSGraph This, MPSGraphTensor gradient, MPSGraphTensor input, MPSGraphTensor scaleOffset, MPSGraphTensorNamedDataLayout layout, string? name)
		{
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var input__handle__ = input!.GetNonNullHandle (nameof (input));
			var scaleOffset__handle__ = scaleOffset!.GetNonNullHandle (nameof (scaleOffset));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("resizeBilinearWithGradientTensor:input:scaleOffsetTensor:layout:name:"), gradient__handle__, input__handle__, scaleOffset__handle__, (UIntPtr) (ulong) layout, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradient);
			GC.KeepAlive (input);
			GC.KeepAlive (scaleOffset);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("resizeBilinearWithGradientTensor:input:scaleTensor:offsetTensor:name:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ResizeBilinearWithGradient (this MPSGraph This, MPSGraphTensor gradient, MPSGraphTensor input, MPSGraphTensor scale, MPSGraphTensor offset, string? name)
		{
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var input__handle__ = input!.GetNonNullHandle (nameof (input));
			var scale__handle__ = scale!.GetNonNullHandle (nameof (scale));
			var offset__handle__ = offset!.GetNonNullHandle (nameof (offset));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resizeBilinearWithGradientTensor:input:scaleTensor:offsetTensor:name:"), gradient__handle__, input__handle__, scale__handle__, offset__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradient);
			GC.KeepAlive (input);
			GC.KeepAlive (scale);
			GC.KeepAlive (offset);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("resizeWithGradientTensor:input:mode:centerResult:alignCorners:layout:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ResizeGradient (this MPSGraph This, MPSGraphTensor gradient, MPSGraphTensor input, MPSGraphResizeMode mode, bool centerResult, bool alignCorners, MPSGraphTensorNamedDataLayout layout, string? name)
		{
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var input__handle__ = input!.GetNonNullHandle (nameof (input));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_bool_bool_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("resizeWithGradientTensor:input:mode:centerResult:alignCorners:layout:name:"), gradient__handle__, input__handle__, (UIntPtr) (ulong) mode, centerResult ? (byte) 1 : (byte) 0, alignCorners ? (byte) 1 : (byte) 0, (UIntPtr) (ulong) layout, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradient);
			GC.KeepAlive (input);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("resizeNearestWithTensor:sizeTensor:nearestRoundingMode:centerResult:alignCorners:layout:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ResizeNearest (this MPSGraph This, MPSGraphTensor imagesTensor, MPSGraphTensor size, MPSGraphResizeNearestRoundingMode nearestRoundingMode, bool centerResult, bool alignCorners, MPSGraphTensorNamedDataLayout layout, string? name)
		{
			var imagesTensor__handle__ = imagesTensor!.GetNonNullHandle (nameof (imagesTensor));
			var size__handle__ = size!.GetNonNullHandle (nameof (size));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_bool_bool_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("resizeNearestWithTensor:sizeTensor:nearestRoundingMode:centerResult:alignCorners:layout:name:"), imagesTensor__handle__, size__handle__, (UIntPtr) (ulong) nearestRoundingMode, centerResult ? (byte) 1 : (byte) 0, alignCorners ? (byte) 1 : (byte) 0, (UIntPtr) (ulong) layout, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (imagesTensor);
			GC.KeepAlive (size);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("resizeNearestWithTensor:sizeTensor:nearestRoundingMode:centerResult:alignCorners:name:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ResizeNearest (this MPSGraph This, MPSGraphTensor imagesTensor, MPSGraphTensor size, MPSGraphResizeNearestRoundingMode nearestRoundingMode, bool centerResult, bool alignCorners, string? name)
		{
			var imagesTensor__handle__ = imagesTensor!.GetNonNullHandle (nameof (imagesTensor));
			var size__handle__ = size!.GetNonNullHandle (nameof (size));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_bool_bool_NativeHandle (This.Handle, Selector.GetHandle ("resizeNearestWithTensor:sizeTensor:nearestRoundingMode:centerResult:alignCorners:name:"), imagesTensor__handle__, size__handle__, (UIntPtr) (ulong) nearestRoundingMode, centerResult ? (byte) 1 : (byte) 0, alignCorners ? (byte) 1 : (byte) 0, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (imagesTensor);
			GC.KeepAlive (size);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("resizeNearestWithTensor:sizeTensor:scaleOffsetTensor:nearestRoundingMode:layout:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ResizeNearest (this MPSGraph This, MPSGraphTensor imagesTensor, MPSGraphTensor size, MPSGraphTensor scaleOffset, MPSGraphResizeNearestRoundingMode nearestRoundingMode, MPSGraphTensorNamedDataLayout layout, string? name)
		{
			var imagesTensor__handle__ = imagesTensor!.GetNonNullHandle (nameof (imagesTensor));
			var size__handle__ = size!.GetNonNullHandle (nameof (size));
			var scaleOffset__handle__ = scaleOffset!.GetNonNullHandle (nameof (scaleOffset));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UIntPtr_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("resizeNearestWithTensor:sizeTensor:scaleOffsetTensor:nearestRoundingMode:layout:name:"), imagesTensor__handle__, size__handle__, scaleOffset__handle__, (UIntPtr) (ulong) nearestRoundingMode, (UIntPtr) (ulong) layout, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (imagesTensor);
			GC.KeepAlive (size);
			GC.KeepAlive (scaleOffset);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("resizeNearestWithTensor:sizeTensor:scaleTensor:offsetTensor:nearestRoundingMode:name:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ResizeNearest (this MPSGraph This, MPSGraphTensor imagesTensor, MPSGraphTensor size, MPSGraphTensor scale, MPSGraphTensor offset, MPSGraphResizeNearestRoundingMode nearestRoundingMode, string? name)
		{
			var imagesTensor__handle__ = imagesTensor!.GetNonNullHandle (nameof (imagesTensor));
			var size__handle__ = size!.GetNonNullHandle (nameof (size));
			var scale__handle__ = scale!.GetNonNullHandle (nameof (scale));
			var offset__handle__ = offset!.GetNonNullHandle (nameof (offset));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("resizeNearestWithTensor:sizeTensor:scaleTensor:offsetTensor:nearestRoundingMode:name:"), imagesTensor__handle__, size__handle__, scale__handle__, offset__handle__, (UIntPtr) (ulong) nearestRoundingMode, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (imagesTensor);
			GC.KeepAlive (size);
			GC.KeepAlive (scale);
			GC.KeepAlive (offset);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("resizeNearestWithGradientTensor:input:nearestRoundingMode:centerResult:alignCorners:layout:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ResizeNearestWithGradient (this MPSGraph This, MPSGraphTensor gradient, MPSGraphTensor input, MPSGraphResizeNearestRoundingMode nearestRoundingMode, bool centerResult, bool alignCorners, MPSGraphTensorNamedDataLayout layout, string? name)
		{
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var input__handle__ = input!.GetNonNullHandle (nameof (input));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_bool_bool_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("resizeNearestWithGradientTensor:input:nearestRoundingMode:centerResult:alignCorners:layout:name:"), gradient__handle__, input__handle__, (UIntPtr) (ulong) nearestRoundingMode, centerResult ? (byte) 1 : (byte) 0, alignCorners ? (byte) 1 : (byte) 0, (UIntPtr) (ulong) layout, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradient);
			GC.KeepAlive (input);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("resizeNearestWithGradientTensor:input:scaleOffsetTensor:nearestRoundingMode:layout:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ResizeNearestWithGradient (this MPSGraph This, MPSGraphTensor gradient, MPSGraphTensor input, MPSGraphTensor scaleOffset, MPSGraphResizeNearestRoundingMode nearestRoundingMode, MPSGraphTensorNamedDataLayout layout, string? name)
		{
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var input__handle__ = input!.GetNonNullHandle (nameof (input));
			var scaleOffset__handle__ = scaleOffset!.GetNonNullHandle (nameof (scaleOffset));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UIntPtr_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("resizeNearestWithGradientTensor:input:scaleOffsetTensor:nearestRoundingMode:layout:name:"), gradient__handle__, input__handle__, scaleOffset__handle__, (UIntPtr) (ulong) nearestRoundingMode, (UIntPtr) (ulong) layout, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradient);
			GC.KeepAlive (input);
			GC.KeepAlive (scaleOffset);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("resizeNearestWithGradientTensor:input:scaleTensor:offsetTensor:nearestRoundingMode:name:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ResizeNearestWithGradient (this MPSGraph This, MPSGraphTensor gradient, MPSGraphTensor input, MPSGraphTensor scale, MPSGraphTensor offset, MPSGraphResizeNearestRoundingMode nearestRoundingMode, string? name)
		{
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var input__handle__ = input!.GetNonNullHandle (nameof (input));
			var scale__handle__ = scale!.GetNonNullHandle (nameof (scale));
			var offset__handle__ = offset!.GetNonNullHandle (nameof (offset));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("resizeNearestWithGradientTensor:input:scaleTensor:offsetTensor:nearestRoundingMode:name:"), gradient__handle__, input__handle__, scale__handle__, offset__handle__, (UIntPtr) (ulong) nearestRoundingMode, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradient);
			GC.KeepAlive (input);
			GC.KeepAlive (scale);
			GC.KeepAlive (offset);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("resizeWithGradientTensor:input:scaleOffsetTensor:mode:layout:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ResizeWithGradient (this MPSGraph This, MPSGraphTensor gradient, MPSGraphTensor input, MPSGraphTensor scaleOffset, MPSGraphResizeMode mode, MPSGraphTensorNamedDataLayout layout, string? name)
		{
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var input__handle__ = input!.GetNonNullHandle (nameof (input));
			var scaleOffset__handle__ = scaleOffset!.GetNonNullHandle (nameof (scaleOffset));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UIntPtr_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("resizeWithGradientTensor:input:scaleOffsetTensor:mode:layout:name:"), gradient__handle__, input__handle__, scaleOffset__handle__, (UIntPtr) (ulong) mode, (UIntPtr) (ulong) layout, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradient);
			GC.KeepAlive (input);
			GC.KeepAlive (scaleOffset);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("resizeWithGradientTensor:input:scaleTensor:offsetTensor:mode:name:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ResizeWithGradient (this MPSGraph This, MPSGraphTensor gradient, MPSGraphTensor input, MPSGraphTensor scale, MPSGraphTensor offset, MPSGraphResizeMode mode, string? name)
		{
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var input__handle__ = input!.GetNonNullHandle (nameof (input));
			var scale__handle__ = scale!.GetNonNullHandle (nameof (scale));
			var offset__handle__ = offset!.GetNonNullHandle (nameof (offset));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("resizeWithGradientTensor:input:scaleTensor:offsetTensor:mode:name:"), gradient__handle__, input__handle__, scale__handle__, offset__handle__, (UIntPtr) (ulong) mode, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradient);
			GC.KeepAlive (input);
			GC.KeepAlive (scale);
			GC.KeepAlive (offset);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphResizeOps */
}
