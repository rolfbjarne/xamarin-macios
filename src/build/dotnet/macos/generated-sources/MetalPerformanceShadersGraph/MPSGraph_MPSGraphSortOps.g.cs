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
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	public unsafe static partial class MPSGraph_MPSGraphSortOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selArgSortWithTensor_Axis_Descending_Name_X = "argSortWithTensor:axis:descending:name:";
		static readonly NativeHandle selArgSortWithTensor_Axis_Descending_Name_XHandle = Selector.GetHandle ("argSortWithTensor:axis:descending:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selArgSortWithTensor_Axis_Name_X = "argSortWithTensor:axis:name:";
		static readonly NativeHandle selArgSortWithTensor_Axis_Name_XHandle = Selector.GetHandle ("argSortWithTensor:axis:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selArgSortWithTensor_AxisTensor_Descending_Name_X = "argSortWithTensor:axisTensor:descending:name:";
		static readonly NativeHandle selArgSortWithTensor_AxisTensor_Descending_Name_XHandle = Selector.GetHandle ("argSortWithTensor:axisTensor:descending:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selArgSortWithTensor_AxisTensor_Name_X = "argSortWithTensor:axisTensor:name:";
		static readonly NativeHandle selArgSortWithTensor_AxisTensor_Name_XHandle = Selector.GetHandle ("argSortWithTensor:axisTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSortWithTensor_Axis_Descending_Name_X = "sortWithTensor:axis:descending:name:";
		static readonly NativeHandle selSortWithTensor_Axis_Descending_Name_XHandle = Selector.GetHandle ("sortWithTensor:axis:descending:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSortWithTensor_Axis_Name_X = "sortWithTensor:axis:name:";
		static readonly NativeHandle selSortWithTensor_Axis_Name_XHandle = Selector.GetHandle ("sortWithTensor:axis:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSortWithTensor_AxisTensor_Descending_Name_X = "sortWithTensor:axisTensor:descending:name:";
		static readonly NativeHandle selSortWithTensor_AxisTensor_Descending_Name_XHandle = Selector.GetHandle ("sortWithTensor:axisTensor:descending:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSortWithTensor_AxisTensor_Name_X = "sortWithTensor:axisTensor:name:";
		static readonly NativeHandle selSortWithTensor_AxisTensor_Name_XHandle = Selector.GetHandle ("sortWithTensor:axisTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("argSortWithTensor:axis:descending:name:")]
		[SupportedOSPlatform ("tvos16.1")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.1")]
		[SupportedOSPlatform ("maccatalyst16.1")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ArgSort (this MPSGraph This, MPSGraphTensor tensor, nint axis, bool descending, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_bool_NativeHandle (This.Handle, selArgSortWithTensor_Axis_Descending_Name_XHandle, tensor__handle__, axis, descending ? (byte) 1 : (byte) 0, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("argSortWithTensor:axisTensor:descending:name:")]
		[SupportedOSPlatform ("tvos16.1")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.1")]
		[SupportedOSPlatform ("maccatalyst16.1")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ArgSort (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor axisTensor, bool descending, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var axisTensor__handle__ = axisTensor!.GetNonNullHandle (nameof (axisTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool_NativeHandle (This.Handle, selArgSortWithTensor_AxisTensor_Descending_Name_XHandle, tensor__handle__, axisTensor__handle__, descending ? (byte) 1 : (byte) 0, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (axisTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("argSortWithTensor:axis:name:")]
		[SupportedOSPlatform ("tvos16.1")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.1")]
		[SupportedOSPlatform ("maccatalyst16.1")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ArgSort (this MPSGraph This, MPSGraphTensor tensor, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, selArgSortWithTensor_Axis_Name_XHandle, tensor__handle__, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("argSortWithTensor:axisTensor:name:")]
		[SupportedOSPlatform ("tvos16.1")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.1")]
		[SupportedOSPlatform ("maccatalyst16.1")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ArgSort (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor axisTensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var axisTensor__handle__ = axisTensor!.GetNonNullHandle (nameof (axisTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selArgSortWithTensor_AxisTensor_Name_XHandle, tensor__handle__, axisTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (axisTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sortWithTensor:axis:descending:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Sort (this MPSGraph This, MPSGraphTensor tensor, nint axis, bool descending, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_bool_NativeHandle (This.Handle, selSortWithTensor_Axis_Descending_Name_XHandle, tensor__handle__, axis, descending ? (byte) 1 : (byte) 0, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sortWithTensor:axisTensor:descending:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Sort (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor axisTensor, bool descending, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var axisTensor__handle__ = axisTensor!.GetNonNullHandle (nameof (axisTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool_NativeHandle (This.Handle, selSortWithTensor_AxisTensor_Descending_Name_XHandle, tensor__handle__, axisTensor__handle__, descending ? (byte) 1 : (byte) 0, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (axisTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sortWithTensor:axis:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Sort (this MPSGraph This, MPSGraphTensor tensor, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, selSortWithTensor_Axis_Name_XHandle, tensor__handle__, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sortWithTensor:axisTensor:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Sort (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor axisTensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var axisTensor__handle__ = axisTensor!.GetNonNullHandle (nameof (axisTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selSortWithTensor_AxisTensor_Name_XHandle, tensor__handle__, axisTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (axisTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphSortOps */
}
