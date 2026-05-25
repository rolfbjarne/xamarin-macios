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
	[SupportedOSPlatform ("ios16.2")]
	[SupportedOSPlatform ("tvos16.2")]
	[SupportedOSPlatform ("macos13.1")]
	[SupportedOSPlatform ("maccatalyst16.2")]
	public unsafe static partial class MPSGraph_MPSGraphQuantizationOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDequantizeTensor_LUTTensor_Axis_Name_X = "dequantizeTensor:LUTTensor:axis:name:";
		static readonly NativeHandle selDequantizeTensor_LUTTensor_Axis_Name_XHandle = Selector.GetHandle ("dequantizeTensor:LUTTensor:axis:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDequantizeTensor_LUTTensor_Name_X = "dequantizeTensor:LUTTensor:name:";
		static readonly NativeHandle selDequantizeTensor_LUTTensor_Name_XHandle = Selector.GetHandle ("dequantizeTensor:LUTTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDequantizeTensor_Scale_ZeroPoint_DataType_Name_X = "dequantizeTensor:scale:zeroPoint:dataType:name:";
		static readonly NativeHandle selDequantizeTensor_Scale_ZeroPoint_DataType_Name_XHandle = Selector.GetHandle ("dequantizeTensor:scale:zeroPoint:dataType:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDequantizeTensor_ScaleTensor_DataType_Name_X = "dequantizeTensor:scaleTensor:dataType:name:";
		static readonly NativeHandle selDequantizeTensor_ScaleTensor_DataType_Name_XHandle = Selector.GetHandle ("dequantizeTensor:scaleTensor:dataType:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDequantizeTensor_ScaleTensor_ZeroPoint_DataType_Axis_Name_X = "dequantizeTensor:scaleTensor:zeroPoint:dataType:axis:name:";
		static readonly NativeHandle selDequantizeTensor_ScaleTensor_ZeroPoint_DataType_Axis_Name_XHandle = Selector.GetHandle ("dequantizeTensor:scaleTensor:zeroPoint:dataType:axis:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDequantizeTensor_ScaleTensor_ZeroPointTensor_DataType_Axis_Name_X = "dequantizeTensor:scaleTensor:zeroPointTensor:dataType:axis:name:";
		static readonly NativeHandle selDequantizeTensor_ScaleTensor_ZeroPointTensor_DataType_Axis_Name_XHandle = Selector.GetHandle ("dequantizeTensor:scaleTensor:zeroPointTensor:dataType:axis:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDequantizeTensor_ScaleTensor_ZeroPointTensor_DataType_Name_X = "dequantizeTensor:scaleTensor:zeroPointTensor:dataType:name:";
		static readonly NativeHandle selDequantizeTensor_ScaleTensor_ZeroPointTensor_DataType_Name_XHandle = Selector.GetHandle ("dequantizeTensor:scaleTensor:zeroPointTensor:dataType:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQuantizeTensor_Scale_ZeroPoint_DataType_Name_X = "quantizeTensor:scale:zeroPoint:dataType:name:";
		static readonly NativeHandle selQuantizeTensor_Scale_ZeroPoint_DataType_Name_XHandle = Selector.GetHandle ("quantizeTensor:scale:zeroPoint:dataType:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQuantizeTensor_ScaleTensor_ZeroPoint_DataType_Axis_Name_X = "quantizeTensor:scaleTensor:zeroPoint:dataType:axis:name:";
		static readonly NativeHandle selQuantizeTensor_ScaleTensor_ZeroPoint_DataType_Axis_Name_XHandle = Selector.GetHandle ("quantizeTensor:scaleTensor:zeroPoint:dataType:axis:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQuantizeTensor_ScaleTensor_ZeroPointTensor_DataType_Axis_Name_X = "quantizeTensor:scaleTensor:zeroPointTensor:dataType:axis:name:";
		static readonly NativeHandle selQuantizeTensor_ScaleTensor_ZeroPointTensor_DataType_Axis_Name_XHandle = Selector.GetHandle ("quantizeTensor:scaleTensor:zeroPointTensor:dataType:axis:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("dequantizeTensor:scale:zeroPoint:dataType:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Dequantize (this MPSGraph This, MPSGraphTensor tensor, double scale, double zeroPoint, global::MetalPerformanceShaders.MPSDataType dataType, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_Double_Double_UInt32_NativeHandle (This.Handle, selDequantizeTensor_Scale_ZeroPoint_DataType_Name_XHandle, tensor__handle__, scale, zeroPoint, (UInt32)dataType, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("dequantizeTensor:scaleTensor:zeroPoint:dataType:axis:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Dequantize (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor scaleTensor, double zeroPoint, global::MetalPerformanceShaders.MPSDataType dataType, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var scaleTensor__handle__ = scaleTensor!.GetNonNullHandle (nameof (scaleTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_Double_UInt32_IntPtr_NativeHandle (This.Handle, selDequantizeTensor_ScaleTensor_ZeroPoint_DataType_Axis_Name_XHandle, tensor__handle__, scaleTensor__handle__, zeroPoint, (UInt32)dataType, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (scaleTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("dequantizeTensor:scaleTensor:zeroPointTensor:dataType:axis:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Dequantize (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor scaleTensor, MPSGraphTensor zeroPointTensor, global::MetalPerformanceShaders.MPSDataType dataType, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var scaleTensor__handle__ = scaleTensor!.GetNonNullHandle (nameof (scaleTensor));
			var zeroPointTensor__handle__ = zeroPointTensor!.GetNonNullHandle (nameof (zeroPointTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UInt32_IntPtr_NativeHandle (This.Handle, selDequantizeTensor_ScaleTensor_ZeroPointTensor_DataType_Axis_Name_XHandle, tensor__handle__, scaleTensor__handle__, zeroPointTensor__handle__, (UInt32)dataType, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (scaleTensor);
			GC.KeepAlive (zeroPointTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("dequantizeTensor:scaleTensor:zeroPointTensor:dataType:name:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Dequantize (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor scaleTensor, MPSGraphTensor zeroPointTensor, global::MetalPerformanceShaders.MPSDataType dataType, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var scaleTensor__handle__ = scaleTensor!.GetNonNullHandle (nameof (scaleTensor));
			var zeroPointTensor__handle__ = zeroPointTensor!.GetNonNullHandle (nameof (zeroPointTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UInt32_NativeHandle (This.Handle, selDequantizeTensor_ScaleTensor_ZeroPointTensor_DataType_Name_XHandle, tensor__handle__, scaleTensor__handle__, zeroPointTensor__handle__, (UInt32)dataType, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (scaleTensor);
			GC.KeepAlive (zeroPointTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("dequantizeTensor:scaleTensor:dataType:name:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Dequantize (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor scaleTensor, global::MetalPerformanceShaders.MPSDataType dataType, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var scaleTensor__handle__ = scaleTensor!.GetNonNullHandle (nameof (scaleTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UInt32_NativeHandle (This.Handle, selDequantizeTensor_ScaleTensor_DataType_Name_XHandle, tensor__handle__, scaleTensor__handle__, (UInt32)dataType, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (scaleTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("dequantizeTensor:LUTTensor:name:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Dequantize (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor lookupTableTensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var lookupTableTensor__handle__ = lookupTableTensor!.GetNonNullHandle (nameof (lookupTableTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selDequantizeTensor_LUTTensor_Name_XHandle, tensor__handle__, lookupTableTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (lookupTableTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("dequantizeTensor:LUTTensor:axis:name:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Dequantize (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor lookupTableTensor, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var lookupTableTensor__handle__ = lookupTableTensor!.GetNonNullHandle (nameof (lookupTableTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle (This.Handle, selDequantizeTensor_LUTTensor_Axis_Name_XHandle, tensor__handle__, lookupTableTensor__handle__, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (lookupTableTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("quantizeTensor:scale:zeroPoint:dataType:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Quantize (this MPSGraph This, MPSGraphTensor tensor, double scale, double zeroPoint, global::MetalPerformanceShaders.MPSDataType dataType, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_Double_Double_UInt32_NativeHandle (This.Handle, selQuantizeTensor_Scale_ZeroPoint_DataType_Name_XHandle, tensor__handle__, scale, zeroPoint, (UInt32)dataType, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("quantizeTensor:scaleTensor:zeroPoint:dataType:axis:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Quantize (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor scaleTensor, double zeroPoint, global::MetalPerformanceShaders.MPSDataType dataType, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var scaleTensor__handle__ = scaleTensor!.GetNonNullHandle (nameof (scaleTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_Double_UInt32_IntPtr_NativeHandle (This.Handle, selQuantizeTensor_ScaleTensor_ZeroPoint_DataType_Axis_Name_XHandle, tensor__handle__, scaleTensor__handle__, zeroPoint, (UInt32)dataType, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (scaleTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("quantizeTensor:scaleTensor:zeroPointTensor:dataType:axis:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Quantize (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor scaleTensor, MPSGraphTensor zeroPointTensor, global::MetalPerformanceShaders.MPSDataType dataType, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var scaleTensor__handle__ = scaleTensor!.GetNonNullHandle (nameof (scaleTensor));
			var zeroPointTensor__handle__ = zeroPointTensor!.GetNonNullHandle (nameof (zeroPointTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UInt32_IntPtr_NativeHandle (This.Handle, selQuantizeTensor_ScaleTensor_ZeroPointTensor_DataType_Axis_Name_XHandle, tensor__handle__, scaleTensor__handle__, zeroPointTensor__handle__, (UInt32)dataType, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (scaleTensor);
			GC.KeepAlive (zeroPointTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphQuantizationOps */
}
