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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("bottomKWithSourceTensor:axis:k:name:"), source__handle__, axis, k, nsname), false)!;
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
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("bottomKWithSourceTensor:axisTensor:kTensor:name:"), source__handle__, axisTensor__handle__, kTensor__handle__, nsname), false)!;
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
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("topKWithSourceTensor:k:name:"), source__handle__, k, nsname), false)!;
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
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("topKWithSourceTensor:kTensor:name:"), source__handle__, kTensor__handle__, nsname), false)!;
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
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("topKWithSourceTensor:axis:k:name:"), source__handle__, axis, k, nsname), false)!;
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
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("topKWithSourceTensor:axisTensor:kTensor:name:"), source__handle__, axisTensor__handle__, kTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (axisTensor);
			GC.KeepAlive (kTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphTopKOps */
}
