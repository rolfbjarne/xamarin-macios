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
	public unsafe static partial class MPSGraph_MPSGraphResizeOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeBilinearWithGradientTensor_Input_CenterResult_AlignCorners_Layout_Name_X = "resizeBilinearWithGradientTensor:input:centerResult:alignCorners:layout:name:";
		static readonly NativeHandle selResizeBilinearWithGradientTensor_Input_CenterResult_AlignCorners_Layout_Name_XHandle = Selector.GetHandle ("resizeBilinearWithGradientTensor:input:centerResult:alignCorners:layout:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeBilinearWithGradientTensor_Input_ScaleOffsetTensor_Layout_Name_X = "resizeBilinearWithGradientTensor:input:scaleOffsetTensor:layout:name:";
		static readonly NativeHandle selResizeBilinearWithGradientTensor_Input_ScaleOffsetTensor_Layout_Name_XHandle = Selector.GetHandle ("resizeBilinearWithGradientTensor:input:scaleOffsetTensor:layout:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeBilinearWithGradientTensor_Input_ScaleTensor_OffsetTensor_Name_X = "resizeBilinearWithGradientTensor:input:scaleTensor:offsetTensor:name:";
		static readonly NativeHandle selResizeBilinearWithGradientTensor_Input_ScaleTensor_OffsetTensor_Name_XHandle = Selector.GetHandle ("resizeBilinearWithGradientTensor:input:scaleTensor:offsetTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeBilinearWithTensor_SizeTensor_CenterResult_AlignCorners_Layout_Name_X = "resizeBilinearWithTensor:sizeTensor:centerResult:alignCorners:layout:name:";
		static readonly NativeHandle selResizeBilinearWithTensor_SizeTensor_CenterResult_AlignCorners_Layout_Name_XHandle = Selector.GetHandle ("resizeBilinearWithTensor:sizeTensor:centerResult:alignCorners:layout:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeBilinearWithTensor_SizeTensor_CenterResult_AlignCorners_Name_X = "resizeBilinearWithTensor:sizeTensor:centerResult:alignCorners:name:";
		static readonly NativeHandle selResizeBilinearWithTensor_SizeTensor_CenterResult_AlignCorners_Name_XHandle = Selector.GetHandle ("resizeBilinearWithTensor:sizeTensor:centerResult:alignCorners:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeBilinearWithTensor_SizeTensor_ScaleOffsetTensor_Layout_Name_X = "resizeBilinearWithTensor:sizeTensor:scaleOffsetTensor:layout:name:";
		static readonly NativeHandle selResizeBilinearWithTensor_SizeTensor_ScaleOffsetTensor_Layout_Name_XHandle = Selector.GetHandle ("resizeBilinearWithTensor:sizeTensor:scaleOffsetTensor:layout:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeBilinearWithTensor_SizeTensor_ScaleTensor_OffsetTensor_Name_X = "resizeBilinearWithTensor:sizeTensor:scaleTensor:offsetTensor:name:";
		static readonly NativeHandle selResizeBilinearWithTensor_SizeTensor_ScaleTensor_OffsetTensor_Name_XHandle = Selector.GetHandle ("resizeBilinearWithTensor:sizeTensor:scaleTensor:offsetTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeNearestWithGradientTensor_Input_NearestRoundingMode_CenterResult_AlignCorners_Layout_Name_X = "resizeNearestWithGradientTensor:input:nearestRoundingMode:centerResult:alignCorners:layout:name:";
		static readonly NativeHandle selResizeNearestWithGradientTensor_Input_NearestRoundingMode_CenterResult_AlignCorners_Layout_Name_XHandle = Selector.GetHandle ("resizeNearestWithGradientTensor:input:nearestRoundingMode:centerResult:alignCorners:layout:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeNearestWithGradientTensor_Input_ScaleOffsetTensor_NearestRoundingMode_Layout_Name_X = "resizeNearestWithGradientTensor:input:scaleOffsetTensor:nearestRoundingMode:layout:name:";
		static readonly NativeHandle selResizeNearestWithGradientTensor_Input_ScaleOffsetTensor_NearestRoundingMode_Layout_Name_XHandle = Selector.GetHandle ("resizeNearestWithGradientTensor:input:scaleOffsetTensor:nearestRoundingMode:layout:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeNearestWithGradientTensor_Input_ScaleTensor_OffsetTensor_NearestRoundingMode_Name_X = "resizeNearestWithGradientTensor:input:scaleTensor:offsetTensor:nearestRoundingMode:name:";
		static readonly NativeHandle selResizeNearestWithGradientTensor_Input_ScaleTensor_OffsetTensor_NearestRoundingMode_Name_XHandle = Selector.GetHandle ("resizeNearestWithGradientTensor:input:scaleTensor:offsetTensor:nearestRoundingMode:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeNearestWithTensor_SizeTensor_NearestRoundingMode_CenterResult_AlignCorners_Layout_Name_X = "resizeNearestWithTensor:sizeTensor:nearestRoundingMode:centerResult:alignCorners:layout:name:";
		static readonly NativeHandle selResizeNearestWithTensor_SizeTensor_NearestRoundingMode_CenterResult_AlignCorners_Layout_Name_XHandle = Selector.GetHandle ("resizeNearestWithTensor:sizeTensor:nearestRoundingMode:centerResult:alignCorners:layout:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeNearestWithTensor_SizeTensor_NearestRoundingMode_CenterResult_AlignCorners_Name_X = "resizeNearestWithTensor:sizeTensor:nearestRoundingMode:centerResult:alignCorners:name:";
		static readonly NativeHandle selResizeNearestWithTensor_SizeTensor_NearestRoundingMode_CenterResult_AlignCorners_Name_XHandle = Selector.GetHandle ("resizeNearestWithTensor:sizeTensor:nearestRoundingMode:centerResult:alignCorners:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeNearestWithTensor_SizeTensor_ScaleOffsetTensor_NearestRoundingMode_Layout_Name_X = "resizeNearestWithTensor:sizeTensor:scaleOffsetTensor:nearestRoundingMode:layout:name:";
		static readonly NativeHandle selResizeNearestWithTensor_SizeTensor_ScaleOffsetTensor_NearestRoundingMode_Layout_Name_XHandle = Selector.GetHandle ("resizeNearestWithTensor:sizeTensor:scaleOffsetTensor:nearestRoundingMode:layout:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeNearestWithTensor_SizeTensor_ScaleTensor_OffsetTensor_NearestRoundingMode_Name_X = "resizeNearestWithTensor:sizeTensor:scaleTensor:offsetTensor:nearestRoundingMode:name:";
		static readonly NativeHandle selResizeNearestWithTensor_SizeTensor_ScaleTensor_OffsetTensor_NearestRoundingMode_Name_XHandle = Selector.GetHandle ("resizeNearestWithTensor:sizeTensor:scaleTensor:offsetTensor:nearestRoundingMode:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeTensor_Size_Mode_CenterResult_AlignCorners_Layout_Name_X = "resizeTensor:size:mode:centerResult:alignCorners:layout:name:";
		static readonly NativeHandle selResizeTensor_Size_Mode_CenterResult_AlignCorners_Layout_Name_XHandle = Selector.GetHandle ("resizeTensor:size:mode:centerResult:alignCorners:layout:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeTensor_SizeTensor_Mode_CenterResult_AlignCorners_Layout_Name_X = "resizeTensor:sizeTensor:mode:centerResult:alignCorners:layout:name:";
		static readonly NativeHandle selResizeTensor_SizeTensor_Mode_CenterResult_AlignCorners_Layout_Name_XHandle = Selector.GetHandle ("resizeTensor:sizeTensor:mode:centerResult:alignCorners:layout:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeTensor_SizeTensor_Mode_CenterResult_AlignCorners_Name_X = "resizeTensor:sizeTensor:mode:centerResult:alignCorners:name:";
		static readonly NativeHandle selResizeTensor_SizeTensor_Mode_CenterResult_AlignCorners_Name_XHandle = Selector.GetHandle ("resizeTensor:sizeTensor:mode:centerResult:alignCorners:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeTensor_SizeTensor_ScaleOffsetTensor_Mode_Layout_Name_X = "resizeTensor:sizeTensor:scaleOffsetTensor:mode:layout:name:";
		static readonly NativeHandle selResizeTensor_SizeTensor_ScaleOffsetTensor_Mode_Layout_Name_XHandle = Selector.GetHandle ("resizeTensor:sizeTensor:scaleOffsetTensor:mode:layout:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeTensor_SizeTensor_ScaleTensor_OffsetTensor_Mode_Name_X = "resizeTensor:sizeTensor:scaleTensor:offsetTensor:mode:name:";
		static readonly NativeHandle selResizeTensor_SizeTensor_ScaleTensor_OffsetTensor_Mode_Name_XHandle = Selector.GetHandle ("resizeTensor:sizeTensor:scaleTensor:offsetTensor:mode:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeWithGradientTensor_Input_Mode_CenterResult_AlignCorners_Layout_Name_X = "resizeWithGradientTensor:input:mode:centerResult:alignCorners:layout:name:";
		static readonly NativeHandle selResizeWithGradientTensor_Input_Mode_CenterResult_AlignCorners_Layout_Name_XHandle = Selector.GetHandle ("resizeWithGradientTensor:input:mode:centerResult:alignCorners:layout:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeWithGradientTensor_Input_ScaleOffsetTensor_Mode_Layout_Name_X = "resizeWithGradientTensor:input:scaleOffsetTensor:mode:layout:name:";
		static readonly NativeHandle selResizeWithGradientTensor_Input_ScaleOffsetTensor_Mode_Layout_Name_XHandle = Selector.GetHandle ("resizeWithGradientTensor:input:scaleOffsetTensor:mode:layout:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeWithGradientTensor_Input_ScaleTensor_OffsetTensor_Mode_Name_X = "resizeWithGradientTensor:input:scaleTensor:offsetTensor:mode:name:";
		static readonly NativeHandle selResizeWithGradientTensor_Input_ScaleTensor_OffsetTensor_Mode_Name_XHandle = Selector.GetHandle ("resizeWithGradientTensor:input:scaleTensor:offsetTensor:mode:name:");
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_bool_bool_UIntPtr_NativeHandle (This.Handle, selResizeTensor_Size_Mode_CenterResult_AlignCorners_Layout_Name_XHandle, imagesTensor__handle__, nsb_size.GetHandle (), (UIntPtr) (ulong) mode, centerResult ? (byte) 1 : (byte) 0, alignCorners ? (byte) 1 : (byte) 0, (UIntPtr) (ulong) layout, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_bool_bool_UIntPtr_NativeHandle (This.Handle, selResizeTensor_SizeTensor_Mode_CenterResult_AlignCorners_Layout_Name_XHandle, imagesTensor__handle__, size__handle__, (UIntPtr) (ulong) mode, centerResult ? (byte) 1 : (byte) 0, alignCorners ? (byte) 1 : (byte) 0, (UIntPtr) (ulong) layout, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_bool_bool_NativeHandle (This.Handle, selResizeTensor_SizeTensor_Mode_CenterResult_AlignCorners_Name_XHandle, imagesTensor__handle__, size__handle__, (UIntPtr) (ulong) mode, centerResult ? (byte) 1 : (byte) 0, alignCorners ? (byte) 1 : (byte) 0, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UIntPtr_UIntPtr_NativeHandle (This.Handle, selResizeTensor_SizeTensor_ScaleOffsetTensor_Mode_Layout_Name_XHandle, imagesTensor__handle__, size__handle__, scaleOffset__handle__, (UIntPtr) (ulong) mode, (UIntPtr) (ulong) layout, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_UIntPtr_NativeHandle (This.Handle, selResizeTensor_SizeTensor_ScaleTensor_OffsetTensor_Mode_Name_XHandle, imagesTensor__handle__, size__handle__, scale__handle__, offset__handle__, (UIntPtr) (ulong) mode, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool_bool_UIntPtr_NativeHandle (This.Handle, selResizeBilinearWithTensor_SizeTensor_CenterResult_AlignCorners_Layout_Name_XHandle, imagesTensor__handle__, size__handle__, centerResult ? (byte) 1 : (byte) 0, alignCorners ? (byte) 1 : (byte) 0, (UIntPtr) (ulong) layout, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool_bool_NativeHandle (This.Handle, selResizeBilinearWithTensor_SizeTensor_CenterResult_AlignCorners_Name_XHandle, imagesTensor__handle__, size__handle__, centerResult ? (byte) 1 : (byte) 0, alignCorners ? (byte) 1 : (byte) 0, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UIntPtr_NativeHandle (This.Handle, selResizeBilinearWithTensor_SizeTensor_ScaleOffsetTensor_Layout_Name_XHandle, imagesTensor__handle__, size__handle__, scaleOffset__handle__, (UIntPtr) (ulong) layout, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, selResizeBilinearWithTensor_SizeTensor_ScaleTensor_OffsetTensor_Name_XHandle, imagesTensor__handle__, size__handle__, scale__handle__, offset__handle__, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool_bool_UIntPtr_NativeHandle (This.Handle, selResizeBilinearWithGradientTensor_Input_CenterResult_AlignCorners_Layout_Name_XHandle, gradient__handle__, input__handle__, centerResult ? (byte) 1 : (byte) 0, alignCorners ? (byte) 1 : (byte) 0, (UIntPtr) (ulong) layout, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UIntPtr_NativeHandle (This.Handle, selResizeBilinearWithGradientTensor_Input_ScaleOffsetTensor_Layout_Name_XHandle, gradient__handle__, input__handle__, scaleOffset__handle__, (UIntPtr) (ulong) layout, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, selResizeBilinearWithGradientTensor_Input_ScaleTensor_OffsetTensor_Name_XHandle, gradient__handle__, input__handle__, scale__handle__, offset__handle__, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_bool_bool_UIntPtr_NativeHandle (This.Handle, selResizeWithGradientTensor_Input_Mode_CenterResult_AlignCorners_Layout_Name_XHandle, gradient__handle__, input__handle__, (UIntPtr) (ulong) mode, centerResult ? (byte) 1 : (byte) 0, alignCorners ? (byte) 1 : (byte) 0, (UIntPtr) (ulong) layout, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_bool_bool_UIntPtr_NativeHandle (This.Handle, selResizeNearestWithTensor_SizeTensor_NearestRoundingMode_CenterResult_AlignCorners_Layout_Name_XHandle, imagesTensor__handle__, size__handle__, (UIntPtr) (ulong) nearestRoundingMode, centerResult ? (byte) 1 : (byte) 0, alignCorners ? (byte) 1 : (byte) 0, (UIntPtr) (ulong) layout, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_bool_bool_NativeHandle (This.Handle, selResizeNearestWithTensor_SizeTensor_NearestRoundingMode_CenterResult_AlignCorners_Name_XHandle, imagesTensor__handle__, size__handle__, (UIntPtr) (ulong) nearestRoundingMode, centerResult ? (byte) 1 : (byte) 0, alignCorners ? (byte) 1 : (byte) 0, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UIntPtr_UIntPtr_NativeHandle (This.Handle, selResizeNearestWithTensor_SizeTensor_ScaleOffsetTensor_NearestRoundingMode_Layout_Name_XHandle, imagesTensor__handle__, size__handle__, scaleOffset__handle__, (UIntPtr) (ulong) nearestRoundingMode, (UIntPtr) (ulong) layout, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_UIntPtr_NativeHandle (This.Handle, selResizeNearestWithTensor_SizeTensor_ScaleTensor_OffsetTensor_NearestRoundingMode_Name_XHandle, imagesTensor__handle__, size__handle__, scale__handle__, offset__handle__, (UIntPtr) (ulong) nearestRoundingMode, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_bool_bool_UIntPtr_NativeHandle (This.Handle, selResizeNearestWithGradientTensor_Input_NearestRoundingMode_CenterResult_AlignCorners_Layout_Name_XHandle, gradient__handle__, input__handle__, (UIntPtr) (ulong) nearestRoundingMode, centerResult ? (byte) 1 : (byte) 0, alignCorners ? (byte) 1 : (byte) 0, (UIntPtr) (ulong) layout, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UIntPtr_UIntPtr_NativeHandle (This.Handle, selResizeNearestWithGradientTensor_Input_ScaleOffsetTensor_NearestRoundingMode_Layout_Name_XHandle, gradient__handle__, input__handle__, scaleOffset__handle__, (UIntPtr) (ulong) nearestRoundingMode, (UIntPtr) (ulong) layout, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_UIntPtr_NativeHandle (This.Handle, selResizeNearestWithGradientTensor_Input_ScaleTensor_OffsetTensor_NearestRoundingMode_Name_XHandle, gradient__handle__, input__handle__, scale__handle__, offset__handle__, (UIntPtr) (ulong) nearestRoundingMode, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UIntPtr_UIntPtr_NativeHandle (This.Handle, selResizeWithGradientTensor_Input_ScaleOffsetTensor_Mode_Layout_Name_XHandle, gradient__handle__, input__handle__, scaleOffset__handle__, (UIntPtr) (ulong) mode, (UIntPtr) (ulong) layout, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_UIntPtr_NativeHandle (This.Handle, selResizeWithGradientTensor_Input_ScaleTensor_OffsetTensor_Mode_Name_XHandle, gradient__handle__, input__handle__, scale__handle__, offset__handle__, (UIntPtr) (ulong) mode, nsname), false)!;
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
