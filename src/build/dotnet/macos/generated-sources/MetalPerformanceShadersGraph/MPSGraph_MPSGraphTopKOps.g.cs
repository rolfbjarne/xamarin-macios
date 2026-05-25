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
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class MPSGraph_MPSGraphTopKOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBottomKWithSourceTensor_Axis_K_Name_X = "bottomKWithSourceTensor:axis:k:name:";
		static readonly NativeHandle selBottomKWithSourceTensor_Axis_K_Name_XHandle = Selector.GetHandle ("bottomKWithSourceTensor:axis:k:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBottomKWithSourceTensor_AxisTensor_KTensor_Name_X = "bottomKWithSourceTensor:axisTensor:kTensor:name:";
		static readonly NativeHandle selBottomKWithSourceTensor_AxisTensor_KTensor_Name_XHandle = Selector.GetHandle ("bottomKWithSourceTensor:axisTensor:kTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTopKWithSourceTensor_Axis_K_Name_X = "topKWithSourceTensor:axis:k:name:";
		static readonly NativeHandle selTopKWithSourceTensor_Axis_K_Name_XHandle = Selector.GetHandle ("topKWithSourceTensor:axis:k:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTopKWithSourceTensor_AxisTensor_KTensor_Name_X = "topKWithSourceTensor:axisTensor:kTensor:name:";
		static readonly NativeHandle selTopKWithSourceTensor_AxisTensor_KTensor_Name_XHandle = Selector.GetHandle ("topKWithSourceTensor:axisTensor:kTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTopKWithSourceTensor_K_Name_X = "topKWithSourceTensor:k:name:";
		static readonly NativeHandle selTopKWithSourceTensor_K_Name_XHandle = Selector.GetHandle ("topKWithSourceTensor:k:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTopKWithSourceTensor_KTensor_Name_X = "topKWithSourceTensor:kTensor:name:";
		static readonly NativeHandle selTopKWithSourceTensor_KTensor_Name_XHandle = Selector.GetHandle ("topKWithSourceTensor:kTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("bottomKWithSourceTensor:axis:k:name:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] BottomK (this MPSGraph This, MPSGraphTensor source, nint axis, nuint k, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_UIntPtr_NativeHandle (This.Handle, selBottomKWithSourceTensor_Axis_K_Name_XHandle, source__handle__, axis, k, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("bottomKWithSourceTensor:axisTensor:kTensor:name:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] BottomK (this MPSGraph This, MPSGraphTensor source, MPSGraphTensor axisTensor, MPSGraphTensor kTensor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var axisTensor__handle__ = axisTensor!.GetNonNullHandle (nameof (axisTensor));
			var kTensor__handle__ = kTensor!.GetNonNullHandle (nameof (kTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, selBottomKWithSourceTensor_AxisTensor_KTensor_Name_XHandle, source__handle__, axisTensor__handle__, kTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (axisTensor);
			GC.KeepAlive (kTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("topKWithSourceTensor:k:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] TopK (this MPSGraph This, MPSGraphTensor source, nuint k, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (This.Handle, selTopKWithSourceTensor_K_Name_XHandle, source__handle__, k, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("topKWithSourceTensor:kTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] TopK (this MPSGraph This, MPSGraphTensor source, MPSGraphTensor kTensor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var kTensor__handle__ = kTensor!.GetNonNullHandle (nameof (kTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selTopKWithSourceTensor_KTensor_Name_XHandle, source__handle__, kTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (kTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("topKWithSourceTensor:axis:k:name:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] TopK (this MPSGraph This, MPSGraphTensor source, nint axis, nuint k, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_UIntPtr_NativeHandle (This.Handle, selTopKWithSourceTensor_Axis_K_Name_XHandle, source__handle__, axis, k, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("topKWithSourceTensor:axisTensor:kTensor:name:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] TopK (this MPSGraph This, MPSGraphTensor source, MPSGraphTensor axisTensor, MPSGraphTensor kTensor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var axisTensor__handle__ = axisTensor!.GetNonNullHandle (nameof (axisTensor));
			var kTensor__handle__ = kTensor!.GetNonNullHandle (nameof (kTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, selTopKWithSourceTensor_AxisTensor_KTensor_Name_XHandle, source__handle__, axisTensor__handle__, kTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (axisTensor);
			GC.KeepAlive (kTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphTopKOps */
}
