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
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class MPSGraph_MPSGraphTopKGradientOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("bottomKWithGradientTensor:source:axis:k:name:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor BottomKWithGradient (this MPSGraph This, MPSGraphTensor gradient, MPSGraphTensor source, nint axis, nuint k, string? name)
		{
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("bottomKWithGradientTensor:source:axis:k:name:"), gradient__handle__, source__handle__, axis, k, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradient);
			GC.KeepAlive (source);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("bottomKWithGradientTensor:source:axisTensor:kTensor:name:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor BottomKWithGradient (this MPSGraph This, MPSGraphTensor gradient, MPSGraphTensor source, MPSGraphTensor axisTensor, MPSGraphTensor kTensor, string? name)
		{
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var axisTensor__handle__ = axisTensor!.GetNonNullHandle (nameof (axisTensor));
			var kTensor__handle__ = kTensor!.GetNonNullHandle (nameof (kTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("bottomKWithGradientTensor:source:axisTensor:kTensor:name:"), gradient__handle__, source__handle__, axisTensor__handle__, kTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradient);
			GC.KeepAlive (source);
			GC.KeepAlive (axisTensor);
			GC.KeepAlive (kTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("topKWithGradientTensor:source:k:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor TopKGradient (this MPSGraph This, MPSGraphTensor gradient, MPSGraphTensor source, nuint k, string? name)
		{
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("topKWithGradientTensor:source:k:name:"), gradient__handle__, source__handle__, k, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradient);
			GC.KeepAlive (source);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("topKWithGradientTensor:source:kTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor TopKGradient (this MPSGraph This, MPSGraphTensor gradient, MPSGraphTensor source, MPSGraphTensor kTensor, string? name)
		{
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var kTensor__handle__ = kTensor!.GetNonNullHandle (nameof (kTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("topKWithGradientTensor:source:kTensor:name:"), gradient__handle__, source__handle__, kTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradient);
			GC.KeepAlive (source);
			GC.KeepAlive (kTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("topKWithGradientTensor:source:axis:k:name:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor TopKWithGradient (this MPSGraph This, MPSGraphTensor gradient, MPSGraphTensor source, nint axis, nuint k, string? name)
		{
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("topKWithGradientTensor:source:axis:k:name:"), gradient__handle__, source__handle__, axis, k, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradient);
			GC.KeepAlive (source);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("topKWithGradientTensor:source:axisTensor:kTensor:name:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor TopKWithGradient (this MPSGraph This, MPSGraphTensor gradient, MPSGraphTensor source, MPSGraphTensor axisTensor, MPSGraphTensor kTensor, string? name)
		{
			var gradient__handle__ = gradient!.GetNonNullHandle (nameof (gradient));
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var axisTensor__handle__ = axisTensor!.GetNonNullHandle (nameof (axisTensor));
			var kTensor__handle__ = kTensor!.GetNonNullHandle (nameof (kTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("topKWithGradientTensor:source:axisTensor:kTensor:name:"), gradient__handle__, source__handle__, axisTensor__handle__, kTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (gradient);
			GC.KeepAlive (source);
			GC.KeepAlive (axisTensor);
			GC.KeepAlive (kTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphTopKGradientOps */
}
