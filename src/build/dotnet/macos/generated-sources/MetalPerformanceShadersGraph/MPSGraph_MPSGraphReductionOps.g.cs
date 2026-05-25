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
	public unsafe static partial class MPSGraph_MPSGraphReductionOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReductionAndWithTensor_Axes_Name_X = "reductionAndWithTensor:axes:name:";
		static readonly NativeHandle selReductionAndWithTensor_Axes_Name_XHandle = Selector.GetHandle ("reductionAndWithTensor:axes:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReductionAndWithTensor_Axis_Name_X = "reductionAndWithTensor:axis:name:";
		static readonly NativeHandle selReductionAndWithTensor_Axis_Name_XHandle = Selector.GetHandle ("reductionAndWithTensor:axis:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReductionArgMaximumWithTensor_Axis_Name_X = "reductionArgMaximumWithTensor:axis:name:";
		static readonly NativeHandle selReductionArgMaximumWithTensor_Axis_Name_XHandle = Selector.GetHandle ("reductionArgMaximumWithTensor:axis:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReductionArgMinimumWithTensor_Axis_Name_X = "reductionArgMinimumWithTensor:axis:name:";
		static readonly NativeHandle selReductionArgMinimumWithTensor_Axis_Name_XHandle = Selector.GetHandle ("reductionArgMinimumWithTensor:axis:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReductionMaximumPropagateNaNWithTensor_Axes_Name_X = "reductionMaximumPropagateNaNWithTensor:axes:name:";
		static readonly NativeHandle selReductionMaximumPropagateNaNWithTensor_Axes_Name_XHandle = Selector.GetHandle ("reductionMaximumPropagateNaNWithTensor:axes:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReductionMaximumPropagateNaNWithTensor_Axis_Name_X = "reductionMaximumPropagateNaNWithTensor:axis:name:";
		static readonly NativeHandle selReductionMaximumPropagateNaNWithTensor_Axis_Name_XHandle = Selector.GetHandle ("reductionMaximumPropagateNaNWithTensor:axis:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReductionMaximumWithTensor_Axes_Name_X = "reductionMaximumWithTensor:axes:name:";
		static readonly NativeHandle selReductionMaximumWithTensor_Axes_Name_XHandle = Selector.GetHandle ("reductionMaximumWithTensor:axes:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReductionMaximumWithTensor_Axis_Name_X = "reductionMaximumWithTensor:axis:name:";
		static readonly NativeHandle selReductionMaximumWithTensor_Axis_Name_XHandle = Selector.GetHandle ("reductionMaximumWithTensor:axis:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReductionMinimumPropagateNaNWithTensor_Axes_Name_X = "reductionMinimumPropagateNaNWithTensor:axes:name:";
		static readonly NativeHandle selReductionMinimumPropagateNaNWithTensor_Axes_Name_XHandle = Selector.GetHandle ("reductionMinimumPropagateNaNWithTensor:axes:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReductionMinimumPropagateNaNWithTensor_Axis_Name_X = "reductionMinimumPropagateNaNWithTensor:axis:name:";
		static readonly NativeHandle selReductionMinimumPropagateNaNWithTensor_Axis_Name_XHandle = Selector.GetHandle ("reductionMinimumPropagateNaNWithTensor:axis:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReductionMinimumWithTensor_Axes_Name_X = "reductionMinimumWithTensor:axes:name:";
		static readonly NativeHandle selReductionMinimumWithTensor_Axes_Name_XHandle = Selector.GetHandle ("reductionMinimumWithTensor:axes:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReductionMinimumWithTensor_Axis_Name_X = "reductionMinimumWithTensor:axis:name:";
		static readonly NativeHandle selReductionMinimumWithTensor_Axis_Name_XHandle = Selector.GetHandle ("reductionMinimumWithTensor:axis:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReductionOrWithTensor_Axes_Name_X = "reductionOrWithTensor:axes:name:";
		static readonly NativeHandle selReductionOrWithTensor_Axes_Name_XHandle = Selector.GetHandle ("reductionOrWithTensor:axes:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReductionOrWithTensor_Axis_Name_X = "reductionOrWithTensor:axis:name:";
		static readonly NativeHandle selReductionOrWithTensor_Axis_Name_XHandle = Selector.GetHandle ("reductionOrWithTensor:axis:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReductionProductWithTensor_Axes_Name_X = "reductionProductWithTensor:axes:name:";
		static readonly NativeHandle selReductionProductWithTensor_Axes_Name_XHandle = Selector.GetHandle ("reductionProductWithTensor:axes:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReductionProductWithTensor_Axis_Name_X = "reductionProductWithTensor:axis:name:";
		static readonly NativeHandle selReductionProductWithTensor_Axis_Name_XHandle = Selector.GetHandle ("reductionProductWithTensor:axis:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReductionSumWithTensor_Axes_Name_X = "reductionSumWithTensor:axes:name:";
		static readonly NativeHandle selReductionSumWithTensor_Axes_Name_XHandle = Selector.GetHandle ("reductionSumWithTensor:axes:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReductionSumWithTensor_Axis_Name_X = "reductionSumWithTensor:axis:name:";
		static readonly NativeHandle selReductionSumWithTensor_Axis_Name_XHandle = Selector.GetHandle ("reductionSumWithTensor:axis:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("reductionAndWithTensor:axis:name:")]
		[SupportedOSPlatform ("tvos15.3")]
		[SupportedOSPlatform ("maccatalyst15.3")]
		[SupportedOSPlatform ("macos12.2")]
		[SupportedOSPlatform ("ios15.3")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ReductionAnd (this MPSGraph This, MPSGraphTensor tensor, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, selReductionAndWithTensor_Axis_Name_XHandle, tensor__handle__, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reductionAndWithTensor:axes:name:")]
		[SupportedOSPlatform ("tvos15.3")]
		[SupportedOSPlatform ("maccatalyst15.3")]
		[SupportedOSPlatform ("macos12.2")]
		[SupportedOSPlatform ("ios15.3")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ReductionAnd (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[]? axes, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			using var nsb_axes = NSArray.FromNSObjects (o => new NSNumber (o), axes);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selReductionAndWithTensor_Axes_Name_XHandle, tensor__handle__, nsb_axes.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reductionArgMaximumWithTensor:axis:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ReductionArgMaximum (this MPSGraph This, MPSGraphTensor tensor, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, selReductionArgMaximumWithTensor_Axis_Name_XHandle, tensor__handle__, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reductionArgMinimumWithTensor:axis:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ReductionArgMinimum (this MPSGraph This, MPSGraphTensor tensor, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, selReductionArgMinimumWithTensor_Axis_Name_XHandle, tensor__handle__, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reductionMaximumWithTensor:axis:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ReductionMaximum (this MPSGraph This, MPSGraphTensor tensor, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, selReductionMaximumWithTensor_Axis_Name_XHandle, tensor__handle__, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reductionMaximumWithTensor:axes:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ReductionMaximum (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[]? axes, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			using var nsb_axes = NSArray.FromNSObjects (o => new NSNumber (o), axes);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selReductionMaximumWithTensor_Axes_Name_XHandle, tensor__handle__, nsb_axes.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reductionMaximumPropagateNaNWithTensor:axis:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ReductionMaximumPropagateNaN (this MPSGraph This, MPSGraphTensor tensor, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, selReductionMaximumPropagateNaNWithTensor_Axis_Name_XHandle, tensor__handle__, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reductionMaximumPropagateNaNWithTensor:axes:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ReductionMaximumPropagateNaN (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[]? axes, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			using var nsb_axes = NSArray.FromNSObjects (o => new NSNumber (o), axes);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selReductionMaximumPropagateNaNWithTensor_Axes_Name_XHandle, tensor__handle__, nsb_axes.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reductionMinimumWithTensor:axis:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ReductionMinimum (this MPSGraph This, MPSGraphTensor tensor, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, selReductionMinimumWithTensor_Axis_Name_XHandle, tensor__handle__, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reductionMinimumWithTensor:axes:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ReductionMinimum (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[]? axes, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			using var nsb_axes = NSArray.FromNSObjects (o => new NSNumber (o), axes);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selReductionMinimumWithTensor_Axes_Name_XHandle, tensor__handle__, nsb_axes.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reductionMinimumPropagateNaNWithTensor:axis:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ReductionMinimumPropagateNaN (this MPSGraph This, MPSGraphTensor tensor, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, selReductionMinimumPropagateNaNWithTensor_Axis_Name_XHandle, tensor__handle__, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reductionMinimumPropagateNaNWithTensor:axes:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ReductionMinimumPropagateNaN (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[]? axes, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			using var nsb_axes = NSArray.FromNSObjects (o => new NSNumber (o), axes);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selReductionMinimumPropagateNaNWithTensor_Axes_Name_XHandle, tensor__handle__, nsb_axes.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reductionOrWithTensor:axis:name:")]
		[SupportedOSPlatform ("tvos15.3")]
		[SupportedOSPlatform ("maccatalyst15.3")]
		[SupportedOSPlatform ("macos12.2")]
		[SupportedOSPlatform ("ios15.3")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ReductionOr (this MPSGraph This, MPSGraphTensor tensor, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, selReductionOrWithTensor_Axis_Name_XHandle, tensor__handle__, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reductionOrWithTensor:axes:name:")]
		[SupportedOSPlatform ("tvos15.3")]
		[SupportedOSPlatform ("maccatalyst15.3")]
		[SupportedOSPlatform ("macos12.2")]
		[SupportedOSPlatform ("ios15.3")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ReductionOr (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[]? axes, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			using var nsb_axes = NSArray.FromNSObjects (o => new NSNumber (o), axes);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selReductionOrWithTensor_Axes_Name_XHandle, tensor__handle__, nsb_axes.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reductionProductWithTensor:axis:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ReductionProduct (this MPSGraph This, MPSGraphTensor tensor, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, selReductionProductWithTensor_Axis_Name_XHandle, tensor__handle__, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reductionProductWithTensor:axes:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ReductionProduct (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[]? axes, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			using var nsb_axes = NSArray.FromNSObjects (o => new NSNumber (o), axes);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selReductionProductWithTensor_Axes_Name_XHandle, tensor__handle__, nsb_axes.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reductionSumWithTensor:axis:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ReductionSum (this MPSGraph This, MPSGraphTensor tensor, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, selReductionSumWithTensor_Axis_Name_XHandle, tensor__handle__, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reductionSumWithTensor:axes:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ReductionSum (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[]? axes, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			using var nsb_axes = NSArray.FromNSObjects (o => new NSNumber (o), axes);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selReductionSumWithTensor_Axes_Name_XHandle, tensor__handle__, nsb_axes.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphReductionOps */
}
