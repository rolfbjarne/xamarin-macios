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
	public unsafe static partial class MPSGraph_MPSGraphMatrixMultiplicationOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHammingDistanceWithPrimaryTensor_SecondaryTensor_ResultDataType_Name_X = "HammingDistanceWithPrimaryTensor:secondaryTensor:resultDataType:name:";
		static readonly NativeHandle selHammingDistanceWithPrimaryTensor_SecondaryTensor_ResultDataType_Name_XHandle = Selector.GetHandle ("HammingDistanceWithPrimaryTensor:secondaryTensor:resultDataType:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatrixMultiplicationWithPrimaryTensor_SecondaryTensor_Name_X = "matrixMultiplicationWithPrimaryTensor:secondaryTensor:name:";
		static readonly NativeHandle selMatrixMultiplicationWithPrimaryTensor_SecondaryTensor_Name_XHandle = Selector.GetHandle ("matrixMultiplicationWithPrimaryTensor:secondaryTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScaledDotProductAttentionWithQueryTensor_KeyTensor_ValueTensor_MaskTensor_Scale_Name_X = "scaledDotProductAttentionWithQueryTensor:keyTensor:valueTensor:maskTensor:scale:name:";
		static readonly NativeHandle selScaledDotProductAttentionWithQueryTensor_KeyTensor_ValueTensor_MaskTensor_Scale_Name_XHandle = Selector.GetHandle ("scaledDotProductAttentionWithQueryTensor:keyTensor:valueTensor:maskTensor:scale:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScaledDotProductAttentionWithQueryTensor_KeyTensor_ValueTensor_Scale_Name_X = "scaledDotProductAttentionWithQueryTensor:keyTensor:valueTensor:scale:name:";
		static readonly NativeHandle selScaledDotProductAttentionWithQueryTensor_KeyTensor_ValueTensor_Scale_Name_XHandle = Selector.GetHandle ("scaledDotProductAttentionWithQueryTensor:keyTensor:valueTensor:scale:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("HammingDistanceWithPrimaryTensor:secondaryTensor:resultDataType:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor HammingDistance (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, global::MetalPerformanceShaders.MPSDataType resultDataType, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UInt32_NativeHandle (This.Handle, selHammingDistanceWithPrimaryTensor_SecondaryTensor_ResultDataType_Name_XHandle, primaryTensor__handle__, secondaryTensor__handle__, (UInt32)resultDataType, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("matrixMultiplicationWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor MatrixMultiplication (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selMatrixMultiplicationWithPrimaryTensor_SecondaryTensor_Name_XHandle, primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("scaledDotProductAttentionWithQueryTensor:keyTensor:valueTensor:maskTensor:scale:name:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ScaledDotProductAttention (this MPSGraph This, MPSGraphTensor queryTensor, MPSGraphTensor keyTensor, MPSGraphTensor valueTensor, MPSGraphTensor? maskTensor, float scale, string? name)
		{
			var queryTensor__handle__ = queryTensor!.GetNonNullHandle (nameof (queryTensor));
			var keyTensor__handle__ = keyTensor!.GetNonNullHandle (nameof (keyTensor));
			var valueTensor__handle__ = valueTensor!.GetNonNullHandle (nameof (valueTensor));
			var maskTensor__handle__ = maskTensor.GetHandle ();
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_float_NativeHandle (This.Handle, selScaledDotProductAttentionWithQueryTensor_KeyTensor_ValueTensor_MaskTensor_Scale_Name_XHandle, queryTensor__handle__, keyTensor__handle__, valueTensor__handle__, maskTensor__handle__, scale, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (queryTensor);
			GC.KeepAlive (keyTensor);
			GC.KeepAlive (valueTensor);
			GC.KeepAlive (maskTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("scaledDotProductAttentionWithQueryTensor:keyTensor:valueTensor:scale:name:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ScaledDotProductAttention (this MPSGraph This, MPSGraphTensor queryTensor, MPSGraphTensor keyTensor, MPSGraphTensor valueTensor, float scale, string? name)
		{
			var queryTensor__handle__ = queryTensor!.GetNonNullHandle (nameof (queryTensor));
			var keyTensor__handle__ = keyTensor!.GetNonNullHandle (nameof (keyTensor));
			var valueTensor__handle__ = valueTensor!.GetNonNullHandle (nameof (valueTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_float_NativeHandle (This.Handle, selScaledDotProductAttentionWithQueryTensor_KeyTensor_ValueTensor_Scale_Name_XHandle, queryTensor__handle__, keyTensor__handle__, valueTensor__handle__, scale, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (queryTensor);
			GC.KeepAlive (keyTensor);
			GC.KeepAlive (valueTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphMatrixMultiplicationOps */
}
