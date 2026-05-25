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
	public unsafe static partial class MPSGraph_MPSGraphScatterAlongAxisOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("scatterAlongAxis:withUpdatesTensor:indicesTensor:shape:mode:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ScatterAlongAxis (this MPSGraph This, nint axis, MPSGraphTensor updatesTensor, MPSGraphTensor indicesTensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] shape, MPSGraphScatterMode mode, string? name)
		{
			var updatesTensor__handle__ = updatesTensor!.GetNonNullHandle (nameof (updatesTensor));
			var indicesTensor__handle__ = indicesTensor!.GetNonNullHandle (nameof (indicesTensor));
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle_NativeHandle_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("scatterAlongAxis:withUpdatesTensor:indicesTensor:shape:mode:name:"), axis, updatesTensor__handle__, indicesTensor__handle__, nsb_shape.GetHandle (), (IntPtr) (long) mode, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (updatesTensor);
			GC.KeepAlive (indicesTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("scatterAlongAxisTensor:withUpdatesTensor:indicesTensor:shape:mode:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ScatterAlongAxis (this MPSGraph This, MPSGraphTensor axisTensor, MPSGraphTensor updatesTensor, MPSGraphTensor indicesTensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] shape, MPSGraphScatterMode mode, string? name)
		{
			var axisTensor__handle__ = axisTensor!.GetNonNullHandle (nameof (axisTensor));
			var updatesTensor__handle__ = updatesTensor!.GetNonNullHandle (nameof (updatesTensor));
			var indicesTensor__handle__ = indicesTensor!.GetNonNullHandle (nameof (indicesTensor));
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("scatterAlongAxisTensor:withUpdatesTensor:indicesTensor:shape:mode:name:"), axisTensor__handle__, updatesTensor__handle__, indicesTensor__handle__, nsb_shape.GetHandle (), (IntPtr) (long) mode, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (axisTensor);
			GC.KeepAlive (updatesTensor);
			GC.KeepAlive (indicesTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("scatterAlongAxis:withDataTensor:updatesTensor:indicesTensor:mode:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ScatterAlongAxis (this MPSGraph This, nint axis, MPSGraphTensor dataTensor, MPSGraphTensor updatesTensor, MPSGraphTensor indicesTensor, MPSGraphScatterMode mode, string? name)
		{
			var dataTensor__handle__ = dataTensor!.GetNonNullHandle (nameof (dataTensor));
			var updatesTensor__handle__ = updatesTensor!.GetNonNullHandle (nameof (updatesTensor));
			var indicesTensor__handle__ = indicesTensor!.GetNonNullHandle (nameof (indicesTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle_NativeHandle_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("scatterAlongAxis:withDataTensor:updatesTensor:indicesTensor:mode:name:"), axis, dataTensor__handle__, updatesTensor__handle__, indicesTensor__handle__, (IntPtr) (long) mode, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (dataTensor);
			GC.KeepAlive (updatesTensor);
			GC.KeepAlive (indicesTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("scatterAlongAxisTensor:withDataTensor:updatesTensor:indicesTensor:mode:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ScatterAlongAxis (this MPSGraph This, MPSGraphTensor axisTensor, MPSGraphTensor dataTensor, MPSGraphTensor updatesTensor, MPSGraphTensor indicesTensor, MPSGraphScatterMode mode, string? name)
		{
			var axisTensor__handle__ = axisTensor!.GetNonNullHandle (nameof (axisTensor));
			var dataTensor__handle__ = dataTensor!.GetNonNullHandle (nameof (dataTensor));
			var updatesTensor__handle__ = updatesTensor!.GetNonNullHandle (nameof (updatesTensor));
			var indicesTensor__handle__ = indicesTensor!.GetNonNullHandle (nameof (indicesTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("scatterAlongAxisTensor:withDataTensor:updatesTensor:indicesTensor:mode:name:"), axisTensor__handle__, dataTensor__handle__, updatesTensor__handle__, indicesTensor__handle__, (IntPtr) (long) mode, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (axisTensor);
			GC.KeepAlive (dataTensor);
			GC.KeepAlive (updatesTensor);
			GC.KeepAlive (indicesTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphScatterAlongAxisOps */
}
