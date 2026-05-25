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
	public unsafe static partial class MPSGraph_MPSGraphCumulativeOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCumulativeMaximumWithTensor_Axis_Exclusive_Reverse_Name_X = "cumulativeMaximumWithTensor:axis:exclusive:reverse:name:";
		static readonly NativeHandle selCumulativeMaximumWithTensor_Axis_Exclusive_Reverse_Name_XHandle = Selector.GetHandle ("cumulativeMaximumWithTensor:axis:exclusive:reverse:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCumulativeMaximumWithTensor_Axis_Name_X = "cumulativeMaximumWithTensor:axis:name:";
		static readonly NativeHandle selCumulativeMaximumWithTensor_Axis_Name_XHandle = Selector.GetHandle ("cumulativeMaximumWithTensor:axis:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCumulativeMaximumWithTensor_AxisTensor_Exclusive_Reverse_Name_X = "cumulativeMaximumWithTensor:axisTensor:exclusive:reverse:name:";
		static readonly NativeHandle selCumulativeMaximumWithTensor_AxisTensor_Exclusive_Reverse_Name_XHandle = Selector.GetHandle ("cumulativeMaximumWithTensor:axisTensor:exclusive:reverse:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCumulativeMaximumWithTensor_AxisTensor_Name_X = "cumulativeMaximumWithTensor:axisTensor:name:";
		static readonly NativeHandle selCumulativeMaximumWithTensor_AxisTensor_Name_XHandle = Selector.GetHandle ("cumulativeMaximumWithTensor:axisTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCumulativeMinimumWithTensor_Axis_Exclusive_Reverse_Name_X = "cumulativeMinimumWithTensor:axis:exclusive:reverse:name:";
		static readonly NativeHandle selCumulativeMinimumWithTensor_Axis_Exclusive_Reverse_Name_XHandle = Selector.GetHandle ("cumulativeMinimumWithTensor:axis:exclusive:reverse:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCumulativeMinimumWithTensor_Axis_Name_X = "cumulativeMinimumWithTensor:axis:name:";
		static readonly NativeHandle selCumulativeMinimumWithTensor_Axis_Name_XHandle = Selector.GetHandle ("cumulativeMinimumWithTensor:axis:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCumulativeMinimumWithTensor_AxisTensor_Exclusive_Reverse_Name_X = "cumulativeMinimumWithTensor:axisTensor:exclusive:reverse:name:";
		static readonly NativeHandle selCumulativeMinimumWithTensor_AxisTensor_Exclusive_Reverse_Name_XHandle = Selector.GetHandle ("cumulativeMinimumWithTensor:axisTensor:exclusive:reverse:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCumulativeMinimumWithTensor_AxisTensor_Name_X = "cumulativeMinimumWithTensor:axisTensor:name:";
		static readonly NativeHandle selCumulativeMinimumWithTensor_AxisTensor_Name_XHandle = Selector.GetHandle ("cumulativeMinimumWithTensor:axisTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCumulativeProductWithTensor_Axis_Exclusive_Reverse_Name_X = "cumulativeProductWithTensor:axis:exclusive:reverse:name:";
		static readonly NativeHandle selCumulativeProductWithTensor_Axis_Exclusive_Reverse_Name_XHandle = Selector.GetHandle ("cumulativeProductWithTensor:axis:exclusive:reverse:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCumulativeProductWithTensor_Axis_Name_X = "cumulativeProductWithTensor:axis:name:";
		static readonly NativeHandle selCumulativeProductWithTensor_Axis_Name_XHandle = Selector.GetHandle ("cumulativeProductWithTensor:axis:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCumulativeProductWithTensor_AxisTensor_Exclusive_Reverse_Name_X = "cumulativeProductWithTensor:axisTensor:exclusive:reverse:name:";
		static readonly NativeHandle selCumulativeProductWithTensor_AxisTensor_Exclusive_Reverse_Name_XHandle = Selector.GetHandle ("cumulativeProductWithTensor:axisTensor:exclusive:reverse:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCumulativeProductWithTensor_AxisTensor_Name_X = "cumulativeProductWithTensor:axisTensor:name:";
		static readonly NativeHandle selCumulativeProductWithTensor_AxisTensor_Name_XHandle = Selector.GetHandle ("cumulativeProductWithTensor:axisTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCumulativeSumWithTensor_Axis_Exclusive_Reverse_Name_X = "cumulativeSumWithTensor:axis:exclusive:reverse:name:";
		static readonly NativeHandle selCumulativeSumWithTensor_Axis_Exclusive_Reverse_Name_XHandle = Selector.GetHandle ("cumulativeSumWithTensor:axis:exclusive:reverse:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCumulativeSumWithTensor_Axis_Name_X = "cumulativeSumWithTensor:axis:name:";
		static readonly NativeHandle selCumulativeSumWithTensor_Axis_Name_XHandle = Selector.GetHandle ("cumulativeSumWithTensor:axis:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCumulativeSumWithTensor_AxisTensor_Exclusive_Reverse_Name_X = "cumulativeSumWithTensor:axisTensor:exclusive:reverse:name:";
		static readonly NativeHandle selCumulativeSumWithTensor_AxisTensor_Exclusive_Reverse_Name_XHandle = Selector.GetHandle ("cumulativeSumWithTensor:axisTensor:exclusive:reverse:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCumulativeSumWithTensor_AxisTensor_Name_X = "cumulativeSumWithTensor:axisTensor:name:";
		static readonly NativeHandle selCumulativeSumWithTensor_AxisTensor_Name_XHandle = Selector.GetHandle ("cumulativeSumWithTensor:axisTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("cumulativeMaximumWithTensor:axis:exclusive:reverse:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor CumulativeMaximum (this MPSGraph This, MPSGraphTensor tensor, nint axis, bool exclusive, bool reverse, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_bool_bool_NativeHandle (This.Handle, selCumulativeMaximumWithTensor_Axis_Exclusive_Reverse_Name_XHandle, tensor__handle__, axis, exclusive ? (byte) 1 : (byte) 0, reverse ? (byte) 1 : (byte) 0, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("cumulativeMaximumWithTensor:axisTensor:exclusive:reverse:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor CumulativeMaximum (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor axisTensor, bool exclusive, bool reverse, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var axisTensor__handle__ = axisTensor!.GetNonNullHandle (nameof (axisTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool_bool_NativeHandle (This.Handle, selCumulativeMaximumWithTensor_AxisTensor_Exclusive_Reverse_Name_XHandle, tensor__handle__, axisTensor__handle__, exclusive ? (byte) 1 : (byte) 0, reverse ? (byte) 1 : (byte) 0, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (axisTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("cumulativeMaximumWithTensor:axis:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor CumulativeMaximum (this MPSGraph This, MPSGraphTensor tensor, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, selCumulativeMaximumWithTensor_Axis_Name_XHandle, tensor__handle__, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("cumulativeMaximumWithTensor:axisTensor:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor CumulativeMaximum (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor axisTensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var axisTensor__handle__ = axisTensor!.GetNonNullHandle (nameof (axisTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selCumulativeMaximumWithTensor_AxisTensor_Name_XHandle, tensor__handle__, axisTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (axisTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("cumulativeMinimumWithTensor:axis:exclusive:reverse:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor CumulativeMinimum (this MPSGraph This, MPSGraphTensor tensor, nint axis, bool exclusive, bool reverse, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_bool_bool_NativeHandle (This.Handle, selCumulativeMinimumWithTensor_Axis_Exclusive_Reverse_Name_XHandle, tensor__handle__, axis, exclusive ? (byte) 1 : (byte) 0, reverse ? (byte) 1 : (byte) 0, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("cumulativeMinimumWithTensor:axisTensor:exclusive:reverse:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor CumulativeMinimum (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor axisTensor, bool exclusive, bool reverse, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var axisTensor__handle__ = axisTensor!.GetNonNullHandle (nameof (axisTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool_bool_NativeHandle (This.Handle, selCumulativeMinimumWithTensor_AxisTensor_Exclusive_Reverse_Name_XHandle, tensor__handle__, axisTensor__handle__, exclusive ? (byte) 1 : (byte) 0, reverse ? (byte) 1 : (byte) 0, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (axisTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("cumulativeMinimumWithTensor:axis:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor CumulativeMinimum (this MPSGraph This, MPSGraphTensor tensor, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, selCumulativeMinimumWithTensor_Axis_Name_XHandle, tensor__handle__, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("cumulativeMinimumWithTensor:axisTensor:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor CumulativeMinimum (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor axisTensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var axisTensor__handle__ = axisTensor!.GetNonNullHandle (nameof (axisTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selCumulativeMinimumWithTensor_AxisTensor_Name_XHandle, tensor__handle__, axisTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (axisTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("cumulativeProductWithTensor:axis:exclusive:reverse:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor CumulativeProduct (this MPSGraph This, MPSGraphTensor tensor, nint axis, bool exclusive, bool reverse, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_bool_bool_NativeHandle (This.Handle, selCumulativeProductWithTensor_Axis_Exclusive_Reverse_Name_XHandle, tensor__handle__, axis, exclusive ? (byte) 1 : (byte) 0, reverse ? (byte) 1 : (byte) 0, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("cumulativeProductWithTensor:axisTensor:exclusive:reverse:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor CumulativeProduct (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor axisTensor, bool exclusive, bool reverse, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var axisTensor__handle__ = axisTensor!.GetNonNullHandle (nameof (axisTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool_bool_NativeHandle (This.Handle, selCumulativeProductWithTensor_AxisTensor_Exclusive_Reverse_Name_XHandle, tensor__handle__, axisTensor__handle__, exclusive ? (byte) 1 : (byte) 0, reverse ? (byte) 1 : (byte) 0, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (axisTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("cumulativeProductWithTensor:axis:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor CumulativeProduct (this MPSGraph This, MPSGraphTensor tensor, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, selCumulativeProductWithTensor_Axis_Name_XHandle, tensor__handle__, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("cumulativeProductWithTensor:axisTensor:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor CumulativeProduct (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor axisTensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var axisTensor__handle__ = axisTensor!.GetNonNullHandle (nameof (axisTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selCumulativeProductWithTensor_AxisTensor_Name_XHandle, tensor__handle__, axisTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (axisTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("cumulativeSumWithTensor:axis:exclusive:reverse:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor CumulativeSum (this MPSGraph This, MPSGraphTensor tensor, nint axis, bool exclusive, bool reverse, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_bool_bool_NativeHandle (This.Handle, selCumulativeSumWithTensor_Axis_Exclusive_Reverse_Name_XHandle, tensor__handle__, axis, exclusive ? (byte) 1 : (byte) 0, reverse ? (byte) 1 : (byte) 0, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("cumulativeSumWithTensor:axisTensor:exclusive:reverse:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor CumulativeSum (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor axisTensor, bool exclusive, bool reverse, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var axisTensor__handle__ = axisTensor!.GetNonNullHandle (nameof (axisTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool_bool_NativeHandle (This.Handle, selCumulativeSumWithTensor_AxisTensor_Exclusive_Reverse_Name_XHandle, tensor__handle__, axisTensor__handle__, exclusive ? (byte) 1 : (byte) 0, reverse ? (byte) 1 : (byte) 0, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (axisTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("cumulativeSumWithTensor:axis:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor CumulativeSum (this MPSGraph This, MPSGraphTensor tensor, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, selCumulativeSumWithTensor_Axis_Name_XHandle, tensor__handle__, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("cumulativeSumWithTensor:axisTensor:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor CumulativeSum (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor axisTensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var axisTensor__handle__ = axisTensor!.GetNonNullHandle (nameof (axisTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selCumulativeSumWithTensor_AxisTensor_Name_XHandle, tensor__handle__, axisTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (axisTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphCumulativeOps */
}
