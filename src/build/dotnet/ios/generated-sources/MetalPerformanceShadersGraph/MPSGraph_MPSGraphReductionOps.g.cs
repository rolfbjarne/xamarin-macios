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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("reductionAndWithTensor:axis:name:"), tensor__handle__, axis, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("reductionAndWithTensor:axes:name:"), tensor__handle__, nsb_axes.GetHandle (), nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("reductionArgMaximumWithTensor:axis:name:"), tensor__handle__, axis, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("reductionArgMinimumWithTensor:axis:name:"), tensor__handle__, axis, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("reductionMaximumWithTensor:axis:name:"), tensor__handle__, axis, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("reductionMaximumWithTensor:axes:name:"), tensor__handle__, nsb_axes.GetHandle (), nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("reductionMaximumPropagateNaNWithTensor:axis:name:"), tensor__handle__, axis, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("reductionMaximumPropagateNaNWithTensor:axes:name:"), tensor__handle__, nsb_axes.GetHandle (), nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("reductionMinimumWithTensor:axis:name:"), tensor__handle__, axis, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("reductionMinimumWithTensor:axes:name:"), tensor__handle__, nsb_axes.GetHandle (), nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("reductionMinimumPropagateNaNWithTensor:axis:name:"), tensor__handle__, axis, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("reductionMinimumPropagateNaNWithTensor:axes:name:"), tensor__handle__, nsb_axes.GetHandle (), nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("reductionOrWithTensor:axis:name:"), tensor__handle__, axis, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("reductionOrWithTensor:axes:name:"), tensor__handle__, nsb_axes.GetHandle (), nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("reductionProductWithTensor:axis:name:"), tensor__handle__, axis, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("reductionProductWithTensor:axes:name:"), tensor__handle__, nsb_axes.GetHandle (), nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("reductionSumWithTensor:axis:name:"), tensor__handle__, axis, nsname), false)!;
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
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("reductionSumWithTensor:axes:name:"), tensor__handle__, nsb_axes.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphReductionOps */
}
